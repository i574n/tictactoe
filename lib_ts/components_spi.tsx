import { toString as toString_1, Union, Record } from "./fable_modules/fable-library-ts/Types.js";
import { lambda_type, unit_type, bool_type, class_type, array_type, tuple_type, string_type, int32_type, union_type, record_type, obj_type, TypeInfo } from "./fable_modules/fable-library-ts/Reflection.js";
import { uint8, op_UnaryNegation_Int32, int32 } from "./fable_modules/fable-library-ts/Int32.js";
import { createStoreon } from "storeon";
import { int32ToString, uncurry, createObj } from "./fable_modules/fable-library-ts/Util.js";
import { fill } from "./fable_modules/fable-library-ts/Array.js";
import { useStoreon } from "@storeon/solidjs";
import { int64, fromBits, op_Division, op_Subtraction, toString } from "./fable_modules/fable-library-ts/Long.js";
import { getTicks, utcNow } from "./fable_modules/fable-library-ts/Date.js";
import { Index, For, createMemo, createEffect, createSignal, createComponent, onCleanup } from "solid-js";
import { Input, RadioGroup, Radio, useColorMode, Anchor, hope, SimpleSelect, SimpleOption, Tr, Td, Stack, IconButton, Icon, Button, Checkbox, Box, Table, Tbody } from "@hope-ui/solid";
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

export type US2_Fields = [[], [int32]];

export type US2 = US2_Cons<US2_Tag.US2_0> | US2_Cons<US2_Tag.US2_1>;

export function US2_US2_0() {
    return new US2_Cons<US2_Tag.US2_0>(US2_Tag.US2_0, []);
}

export function US2_US2_1(f1_0: int32) {
    return new US2_Cons<US2_Tag.US2_1>(US2_Tag.US2_1, [f1_0]);
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
    return union_type("Components_spi.US2", [], US2_Cons, () => [[], [["f1_0", int32_type]]]);
}

export const enum US3_Tag {
    US3_0 = 0,
    US3_1 = 1
}

export type US3_Fields = [[], [string]];

export type US3 = US3_Cons<US3_Tag.US3_0> | US3_Cons<US3_Tag.US3_1>;

export function US3_US3_0() {
    return new US3_Cons<US3_Tag.US3_0>(US3_Tag.US3_0, []);
}

export function US3_US3_1(f1_0: string) {
    return new US3_Cons<US3_Tag.US3_1>(US3_Tag.US3_1, [f1_0]);
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
    return union_type("Components_spi.US3", [], US3_Cons, () => [[], [["f1_0", string_type]]]);
}

export const enum US4_Tag {
    US4_0 = 0,
    US4_1 = 1
}

export type US4_Fields = [[], []];

export type US4 = US4_Cons<US4_Tag.US4_0> | US4_Cons<US4_Tag.US4_1>;

export function US4_US4_0() {
    return new US4_Cons<US4_Tag.US4_0>(US4_Tag.US4_0, []);
}

export function US4_US4_1() {
    return new US4_Cons<US4_Tag.US4_1>(US4_Tag.US4_1, []);
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
    return union_type("Components_spi.US4", [], US4_Cons, () => [[], []]);
}

export const enum US5_Tag {
    US5_0 = 0,
    US5_1 = 1,
    US5_2 = 2,
    US5_3 = 3
}

export type US5_Fields = [[], [], [], []];

export type US5 = US5_Cons<US5_Tag.US5_0> | US5_Cons<US5_Tag.US5_1> | US5_Cons<US5_Tag.US5_2> | US5_Cons<US5_Tag.US5_3>;

export function US5_US5_0() {
    return new US5_Cons<US5_Tag.US5_0>(US5_Tag.US5_0, []);
}

export function US5_US5_1() {
    return new US5_Cons<US5_Tag.US5_1>(US5_Tag.US5_1, []);
}

export function US5_US5_2() {
    return new US5_Cons<US5_Tag.US5_2>(US5_Tag.US5_2, []);
}

export function US5_US5_3() {
    return new US5_Cons<US5_Tag.US5_3>(US5_Tag.US5_3, []);
}

export class US5_Cons<Tag extends keyof US5_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: US5_Fields[Tag]) {
        super();
    }
    cases() {
        return ["US5_0", "US5_1", "US5_2", "US5_3"];
    }
}

export function US5$reflection(): TypeInfo {
    return union_type("Components_spi.US5", [], US5_Cons, () => [[], [], [], []]);
}

export class Mut1 extends Record {
    l0: [US0, string, string, string][];
    l1: US2;
    l2: US3;
    l3: US3;
    l4: [US4, int32, string, string][];
    l5: [US4, US4][];
    l6: [int32, any][];
    l7: [int32, any][];
    l8: [int32, int32][];
    l9: US5;
    l10: US2;
    constructor(l0: [US0, string, string, string][], l1: US2, l2: US3, l3: US3, l4: [US4, int32, string, string][], l5: [US4, US4][], l6: [int32, any][], l7: [int32, any][], l8: [int32, int32][], l9: US5, l10: US2) {
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
    }
}

export function Mut1$reflection(): TypeInfo {
    return record_type("Components_spi.Mut1", [], Mut1, () => [["l0", array_type(tuple_type(US0$reflection(), string_type, string_type, string_type))], ["l1", US2$reflection()], ["l2", US3$reflection()], ["l3", US3$reflection()], ["l4", array_type(tuple_type(US4$reflection(), int32_type, string_type, string_type))], ["l5", array_type(tuple_type(US4$reflection(), US4$reflection()))], ["l6", array_type(tuple_type(int32_type, obj_type))], ["l7", array_type(tuple_type(int32_type, obj_type))], ["l8", array_type(tuple_type(int32_type, int32_type))], ["l9", US5$reflection()], ["l10", US2$reflection()]]);
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

export class Mut3 extends Record {
    l0: US3;
    l1: US3;
    l2: US3;
    l3: US6;
    l4: US3;
    l5: US3;
    l6: US3;
    l7: US3;
    l8: US3;
    l9: US3;
    l10: US7;
    l11: US8;
    l12: US3;
    l13: US3;
    l14: US7;
    l15: US9;
    l16: US3;
    l17: US3;
    l18: US3;
    l19: US10;
    l20: US7;
    l21: US3;
    l22: US3;
    l23: US3;
    l24: US3;
    l25: US3;
    l26: US3;
    l27: US11;
    l28: US3;
    l29: US3;
    l30: US3;
    l31: US11;
    l32: US3;
    l33: US3;
    l34: US3;
    l35: US3;
    l36: US3;
    l37: US3;
    l38: US3;
    l39: US3;
    l40: US12;
    l41: US13;
    l42: US12;
    l43: US3;
    l44: US3;
    l45: US3;
    l46: US3;
    l47: US3;
    l48: US3;
    l49: US3;
    l50: US3;
    l51: US3;
    l52: US3;
    l53: US3;
    l54: US3;
    l55: US3;
    l56: US3;
    l57: US3;
    l58: US3;
    l59: US3;
    l60: US11;
    l61: US3;
    l62: US3;
    l63: US9;
    l64: US9;
    l65: US3;
    l66: US2;
    l67: US3;
    constructor(l0: US3, l1: US3, l2: US3, l3: US6, l4: US3, l5: US3, l6: US3, l7: US3, l8: US3, l9: US3, l10: US7, l11: US8, l12: US3, l13: US3, l14: US7, l15: US9, l16: US3, l17: US3, l18: US3, l19: US10, l20: US7, l21: US3, l22: US3, l23: US3, l24: US3, l25: US3, l26: US3, l27: US11, l28: US3, l29: US3, l30: US3, l31: US11, l32: US3, l33: US3, l34: US3, l35: US3, l36: US3, l37: US3, l38: US3, l39: US3, l40: US12, l41: US13, l42: US12, l43: US3, l44: US3, l45: US3, l46: US3, l47: US3, l48: US3, l49: US3, l50: US3, l51: US3, l52: US3, l53: US3, l54: US3, l55: US3, l56: US3, l57: US3, l58: US3, l59: US3, l60: US11, l61: US3, l62: US3, l63: US9, l64: US9, l65: US3, l66: US2, l67: US3) {
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

export function Mut3$reflection(): TypeInfo {
    return record_type("Components_spi.Mut3", [], Mut3, () => [["l0", US3$reflection()], ["l1", US3$reflection()], ["l2", US3$reflection()], ["l3", US6$reflection()], ["l4", US3$reflection()], ["l5", US3$reflection()], ["l6", US3$reflection()], ["l7", US3$reflection()], ["l8", US3$reflection()], ["l9", US3$reflection()], ["l10", US7$reflection()], ["l11", US8$reflection()], ["l12", US3$reflection()], ["l13", US3$reflection()], ["l14", US7$reflection()], ["l15", US9$reflection()], ["l16", US3$reflection()], ["l17", US3$reflection()], ["l18", US3$reflection()], ["l19", US10$reflection()], ["l20", US7$reflection()], ["l21", US3$reflection()], ["l22", US3$reflection()], ["l23", US3$reflection()], ["l24", US3$reflection()], ["l25", US3$reflection()], ["l26", US3$reflection()], ["l27", US11$reflection()], ["l28", US3$reflection()], ["l29", US3$reflection()], ["l30", US3$reflection()], ["l31", US11$reflection()], ["l32", US3$reflection()], ["l33", US3$reflection()], ["l34", US3$reflection()], ["l35", US3$reflection()], ["l36", US3$reflection()], ["l37", US3$reflection()], ["l38", US3$reflection()], ["l39", US3$reflection()], ["l40", US12$reflection()], ["l41", US13$reflection()], ["l42", US12$reflection()], ["l43", US3$reflection()], ["l44", US3$reflection()], ["l45", US3$reflection()], ["l46", US3$reflection()], ["l47", US3$reflection()], ["l48", US3$reflection()], ["l49", US3$reflection()], ["l50", US3$reflection()], ["l51", US3$reflection()], ["l52", US3$reflection()], ["l53", US3$reflection()], ["l54", US3$reflection()], ["l55", US3$reflection()], ["l56", US3$reflection()], ["l57", US3$reflection()], ["l58", US3$reflection()], ["l59", US3$reflection()], ["l60", US11$reflection()], ["l61", US3$reflection()], ["l62", US3$reflection()], ["l63", US9$reflection()], ["l64", US9$reflection()], ["l65", US3$reflection()], ["l66", US2$reflection()], ["l67", US3$reflection()]]);
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
    US14_1 = 1
}

export type US14_Fields = [[], [(arg0: Mut1, arg1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void]];

export type US14 = US14_Cons<US14_Tag.US14_0> | US14_Cons<US14_Tag.US14_1>;

export function US14_US14_0() {
    return new US14_Cons<US14_Tag.US14_0>(US14_Tag.US14_0, []);
}

export function US14_US14_1(f1_0: (arg0: Mut1, arg1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void) {
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
    return union_type("Components_spi.US14", [], US14_Cons, () => [[], [["f1_0", lambda_type(Mut1$reflection(), lambda_type(lambda_type(lambda_type(Mut1$reflection(), lambda_type(Mut1$reflection(), unit_type)), unit_type), unit_type))]]]);
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
    l2: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3];
    l3: US15;
    constructor(l0: US14, l1: US14, l2: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3], l3: US15) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
        this.l3 = l3;
    }
}

export function Mut4$reflection(): TypeInfo {
    return record_type("Components_spi.Mut4", [], Mut4, () => [["l0", US14$reflection()], ["l1", US14$reflection()], ["l2", lambda_type(tuple_type(US3$reflection(), US3$reflection(), US3$reflection(), US6$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US7$reflection(), US8$reflection(), US3$reflection(), US3$reflection(), US7$reflection(), US9$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US10$reflection(), US7$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US12$reflection(), US13$reflection(), US12$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US9$reflection(), US9$reflection(), US3$reflection(), US2$reflection(), US3$reflection()), tuple_type(US3$reflection(), US3$reflection(), US3$reflection(), US6$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US7$reflection(), US8$reflection(), US3$reflection(), US3$reflection(), US7$reflection(), US9$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US10$reflection(), US7$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US12$reflection(), US13$reflection(), US12$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US9$reflection(), US9$reflection(), US3$reflection(), US2$reflection(), US3$reflection()))], ["l3", US15$reflection()]]);
}

export class Mut5 extends Record {
    l0: () => boolean;
    l1: (arg0: boolean) => void;
    l2: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3];
    constructor(l0: () => boolean, l1: (arg0: boolean) => void, l2: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
    }
}

export function Mut5$reflection(): TypeInfo {
    return record_type("Components_spi.Mut5", [], Mut5, () => [["l0", lambda_type(unit_type, bool_type)], ["l1", lambda_type(bool_type, unit_type)], ["l2", lambda_type(tuple_type(US3$reflection(), US3$reflection(), US3$reflection(), US6$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US7$reflection(), US8$reflection(), US3$reflection(), US3$reflection(), US7$reflection(), US9$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US10$reflection(), US7$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US12$reflection(), US13$reflection(), US12$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US9$reflection(), US9$reflection(), US3$reflection(), US2$reflection(), US3$reflection()), tuple_type(US3$reflection(), US3$reflection(), US3$reflection(), US6$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US7$reflection(), US8$reflection(), US3$reflection(), US3$reflection(), US7$reflection(), US9$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US10$reflection(), US7$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US12$reflection(), US13$reflection(), US12$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US9$reflection(), US9$reflection(), US3$reflection(), US2$reflection(), US3$reflection()))]]);
}

export class Mut6 extends Record {
    l0: boolean;
    l1: boolean;
    l2: US14;
    l3: US14;
    l4: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3];
    constructor(l0: boolean, l1: boolean, l2: US14, l3: US14, l4: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
        this.l3 = l3;
        this.l4 = l4;
    }
}

export function Mut6$reflection(): TypeInfo {
    return record_type("Components_spi.Mut6", [], Mut6, () => [["l0", bool_type], ["l1", bool_type], ["l2", US14$reflection()], ["l3", US14$reflection()], ["l4", lambda_type(tuple_type(US3$reflection(), US3$reflection(), US3$reflection(), US6$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US7$reflection(), US8$reflection(), US3$reflection(), US3$reflection(), US7$reflection(), US9$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US10$reflection(), US7$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US12$reflection(), US13$reflection(), US12$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US9$reflection(), US9$reflection(), US3$reflection(), US2$reflection(), US3$reflection()), tuple_type(US3$reflection(), US3$reflection(), US3$reflection(), US6$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US7$reflection(), US8$reflection(), US3$reflection(), US3$reflection(), US7$reflection(), US9$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US10$reflection(), US7$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US12$reflection(), US13$reflection(), US12$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US9$reflection(), US9$reflection(), US3$reflection(), US2$reflection(), US3$reflection()))]]);
}

export class Mut7 extends Record {
    l0: int32;
    constructor(l0: int32) {
        super();
        this.l0 = (l0 | 0);
    }
}

export function Mut7$reflection(): TypeInfo {
    return record_type("Components_spi.Mut7", [], Mut7, () => [["l0", int32_type]]);
}

export class Mut8 extends Record {
    l0: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3];
    l1: () => any;
    l2: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3];
    constructor(l0: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3], l1: () => any, l2: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
    }
}

export function Mut8$reflection(): TypeInfo {
    return record_type("Components_spi.Mut8", [], Mut8, () => [["l0", lambda_type(tuple_type(US3$reflection(), US3$reflection(), US3$reflection(), US6$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US7$reflection(), US8$reflection(), US3$reflection(), US3$reflection(), US7$reflection(), US9$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US10$reflection(), US7$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US12$reflection(), US13$reflection(), US12$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US9$reflection(), US9$reflection(), US3$reflection(), US2$reflection(), US3$reflection()), tuple_type(US3$reflection(), US3$reflection(), US3$reflection(), US6$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US7$reflection(), US8$reflection(), US3$reflection(), US3$reflection(), US7$reflection(), US9$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US10$reflection(), US7$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US12$reflection(), US13$reflection(), US12$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US9$reflection(), US9$reflection(), US3$reflection(), US2$reflection(), US3$reflection()))], ["l1", lambda_type(unit_type, class_type("Fable.Core.JS.Function"))], ["l2", lambda_type(tuple_type(US3$reflection(), US3$reflection(), US3$reflection(), US6$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US7$reflection(), US8$reflection(), US3$reflection(), US3$reflection(), US7$reflection(), US9$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US10$reflection(), US7$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US12$reflection(), US13$reflection(), US12$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US9$reflection(), US9$reflection(), US3$reflection(), US2$reflection(), US3$reflection()), tuple_type(US3$reflection(), US3$reflection(), US3$reflection(), US6$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US7$reflection(), US8$reflection(), US3$reflection(), US3$reflection(), US7$reflection(), US9$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US10$reflection(), US7$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US12$reflection(), US13$reflection(), US12$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US9$reflection(), US9$reflection(), US3$reflection(), US2$reflection(), US3$reflection()))]]);
}

export class Mut9 extends Record {
    l0: (arg0: Mut1) => US3;
    l1: (arg0: Mut1, arg1: Mut1, arg2: US3) => void;
    constructor(l0: (arg0: Mut1) => US3, l1: (arg0: Mut1, arg1: Mut1, arg2: US3) => void) {
        super();
        this.l0 = l0;
        this.l1 = l1;
    }
}

export function Mut9$reflection(): TypeInfo {
    return record_type("Components_spi.Mut9", [], Mut9, () => [["l0", lambda_type(Mut1$reflection(), US3$reflection())], ["l1", lambda_type(Mut1$reflection(), lambda_type(Mut1$reflection(), lambda_type(US3$reflection(), unit_type)))]]);
}

export class Mut10 extends Record {
    l0: (arg0: Mut1) => US2;
    l1: (arg0: Mut1, arg1: Mut1, arg2: US2) => void;
    constructor(l0: (arg0: Mut1) => US2, l1: (arg0: Mut1, arg1: Mut1, arg2: US2) => void) {
        super();
        this.l0 = l0;
        this.l1 = l1;
    }
}

export function Mut10$reflection(): TypeInfo {
    return record_type("Components_spi.Mut10", [], Mut10, () => [["l0", lambda_type(Mut1$reflection(), US2$reflection())], ["l1", lambda_type(Mut1$reflection(), lambda_type(Mut1$reflection(), lambda_type(US2$reflection(), unit_type)))]]);
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
    l0: US4;
    constructor(l0: US4) {
        super();
        this.l0 = l0;
    }
}

export function Mut12$reflection(): TypeInfo {
    return record_type("Components_spi.Mut12", [], Mut12, () => [["l0", US4$reflection()]]);
}

export class Mut13 extends Record {
    l0: US4;
    l1: (arg0: [US4, int32, string, string]) => US3;
    l2: (arg0: [US4, int32, string, string], arg1: US3) => [US4, int32, string, string];
    constructor(l0: US4, l1: (arg0: [US4, int32, string, string]) => US3, l2: (arg0: [US4, int32, string, string], arg1: US3) => [US4, int32, string, string]) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
    }
}

export function Mut13$reflection(): TypeInfo {
    return record_type("Components_spi.Mut13", [], Mut13, () => [["l0", US4$reflection()], ["l1", lambda_type(tuple_type(US4$reflection(), int32_type, string_type, string_type), US3$reflection())], ["l2", lambda_type(tuple_type(US4$reflection(), int32_type, string_type, string_type), lambda_type(US3$reflection(), tuple_type(US4$reflection(), int32_type, string_type, string_type)))]]);
}

export class Mut14 extends Record {
    l0: int32;
    l1: US3;
    constructor(l0: int32, l1: US3) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = l1;
    }
}

export function Mut14$reflection(): TypeInfo {
    return record_type("Components_spi.Mut14", [], Mut14, () => [["l0", int32_type], ["l1", US3$reflection()]]);
}

export class Mut15 extends Record {
    l0: US4;
    l1: (arg0: [US4, int32, string, string]) => US2;
    l2: (arg0: [US4, int32, string, string], arg1: US2) => [US4, int32, string, string];
    constructor(l0: US4, l1: (arg0: [US4, int32, string, string]) => US2, l2: (arg0: [US4, int32, string, string], arg1: US2) => [US4, int32, string, string]) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
    }
}

export function Mut15$reflection(): TypeInfo {
    return record_type("Components_spi.Mut15", [], Mut15, () => [["l0", US4$reflection()], ["l1", lambda_type(tuple_type(US4$reflection(), int32_type, string_type, string_type), US2$reflection())], ["l2", lambda_type(tuple_type(US4$reflection(), int32_type, string_type, string_type), lambda_type(US2$reflection(), tuple_type(US4$reflection(), int32_type, string_type, string_type)))]]);
}

export class Mut16 extends Record {
    l0: int32;
    l1: US2;
    constructor(l0: int32, l1: US2) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = l1;
    }
}

export function Mut16$reflection(): TypeInfo {
    return record_type("Components_spi.Mut16", [], Mut16, () => [["l0", int32_type], ["l1", US2$reflection()]]);
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

export function method1(): [string, any, string, string, boolean] {
    const v0_1: any = components_spi.env;
    const v1_1: string = v0_1.CODESPACE_NAME || "";
    const v2: string = v0_1.GITHUB_RUN_ID || "";
    const v3: string = v0_1.GITHUB_SHA || "";
    const v4: any = v0_1.IS_TEST;
    return [v1_1, v0_1, v2, v3, (!v4) === false];
}

export function method2(): string {
    return "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
}

export function method3(): string {
    return "http://localhost";
}

export function method4(): int32 {
    return 4001;
}

export function method5(): [US0, string, string, string][] {
    return [[US0_US0_0(), "4ZZJNAAPJGOUBHORYKX5DQSJJIMQLADNUIH7ONXZAVEZYZGOAM5CM7HV2M", "poem slush dry adult final thunder price pause concert topic mesh wild dry gate judge celery winter list promote clump country loan move about faith", "OBVzhzxAK4ZPdaF1QbkXsd8hgRUPJeCfYFjFghgMGnLmcpaAD0mdQJ3Rwq/RwklKGQWAbaIP9zb5BUmcZM4DOg=="], [US0_US0_1(US1_US1_1()), "Q2MAJEB7HYFK42KSN2MY26PL3P5P7HVIGR22GDAGCJQUARDEIM4WLHSIFQ", "crater dove click normal kitten aisle obvious error exotic lunar guard impact donkey gun lamp divide announce match cement excess piano turn fish above make", "lHFQVWKpvRYU00yAQqHOHJegn5nvP0owYkroBFKr94qGmASQPz4KrmlSbpmNeevb+v+eqDR1owwGEmFARGRDOQ=="], [US0_US0_1(US1_US1_0()), "KVGJONR4BETXZ3AS224T4MAJATTSTQGVO3VC3YAGSWAYBVD7KPR23RKNBI", "key churn alert mother lock run lyrics category office lamp silver nut cement pistol fury hollow faculty feed capable announce index cloth faint about bid", "0DNKDAK5QfWuMCTMNJ+Re5mSlc7rbI0q1UOUYDmvPGpVTJc2PAknfOwS1rk+MAkE5ynA1XbqLeAGlYGA1H9T4w=="]];
}

export function method0(): [[US0, string, string, string][], US2, US3, US3, [US4, int32, string, string][], [US4, US4][], [int32, any][], [int32, any][], [int32, int32][], US5, US2] {
    const patternInput: [string, any, string, string, boolean] = method1();
    const v4: boolean = patternInput[4];
    const v0_1: string = patternInput[0];
    const v5: string = method2();
    const v6: boolean = "" === v0_1;
    const v9: string = v6 ? method3() : (`http://${v0_1}-4001.githubpreview.dev`);
    const v11: int32 = (v6 ? method4() : 80) | 0;
    return [method5(), US2_US2_1(v11), US3_US3_1(v5), US3_US3_1(v9), [[US4_US4_1(), v6 ? ((true === v4) ? 14944 : ((false === v4) ? 4944 : 80)) : 80, v6 ? "ws://localhost" : ((true === v4) ? "ws://localhost" : (`ws://${v0_1}-4944.githubpreview.dev`)), "ws"], [US4_US4_0(), v6 ? ((true === v4) ? 18765 : ((false === v4) ? 8765 : 80)) : 80, v6 ? "wss://localhost" : ((true === v4) ? "wss://localhost" : (`ws://${v0_1}-8765.githubpreview.dev`)), "gun"]], [], [], [], [], (patternInput[2] === "") ? US5_US5_0() : US5_US5_3(), US2_US2_0()];
}

export function closure0(v0_1: any, v1_1: any): void {
    const v2: any = v1_1.on;
    v2("@init", ((): any => v0_1));
    v2("set", ((_: any, state: any) => state));
}

export function method6(v0_1: any): any {
    const v3: any = createStoreon;
    const v4: (arg0: any) => void = (v: any): void => {
        closure0(v0_1, v);
    };
    return v3([v4]);
}

export function closure2(v0_1: Mut1, v1_1: any, v2: (arg0: Mut1, arg1: Mut1) => void): void {
    const v5: Mut1 = createObj(fill(new Array(0), 0, 0, null));
    v2(v0_1, v5);
    v1_1("set", v5);
}

export function method8(): [Mut1, (arg0: (arg0: Mut1, arg1: Mut1) => void) => void] {
    const v2: any = useStoreon;
    const v3: any[] = v2();
    const v4: Mut1 = v3[0];
    const v5: any = v3[1];
    const v6: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void = (v: (arg0: Mut1, arg1: Mut1) => void): void => {
        closure2(v4, v5, uncurry(2, v));
    };
    return [v4, v6];
}

export function closure3(v0_1: Mut1, unitVar: void): boolean {
    if (v0_1.l9.tag === US5_Tag.US5_0) {
        return true;
    }
    else {
        return false;
    }
}

export function closure4(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function method10(v0_1_mut: int32, v1_1_mut: string): string {
    method10:
    while (true) {
        const v0_1: int32 = v0_1_mut, v1_1: string = v1_1_mut;
        if (v1_1.length < v0_1) {
            v0_1_mut = v0_1;
            v1_1_mut = (`0${v1_1}`);
            continue method10;
        }
        else {
            return v1_1;
        }
        break;
    }
}

export function closure5(v0_1: () => boolean, v1_1: () => any[], v2: string, v3: string, v4: any, v5: string, v6: string, v7: boolean, v8: int64, v9: any[]): void {
    let copyOfStruct: Date;
    if (v0_1()) {
        const v17: string = `[${method10(6, toString(op_Subtraction(op_Division((copyOfStruct = utcNow(), getTicks(copyOfStruct)), fromBits(1000, 0, false)), v8)))}] ${components_spi.run_id}`;
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

export function method9(v0_1: () => boolean, v1_1: () => any[], v2: string): (arg0: any[]) => void {
    let copyOfStruct: Date;
    const patternInput: [string, any, string, string, boolean] = method1();
    const v8: int64 = op_Division((copyOfStruct = utcNow(), getTicks(copyOfStruct)), fromBits(1000, 0, false));
    return (v: any[]): void => {
        closure5(v0_1, v1_1, v2, patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], v8, v);
    };
}

export function closure6(v0_1: (arg0: any[]) => void, _arg: [Mut1, Mut1, any]): void {
    const v2: Mut1 = _arg[1];
    v0_1([">> db_listener store.on(@changed)", ["b_changed:", v2]]);
    const patternInput: [[US4, int32, string, string][], [US4, US4][]] = [v2.l4, v2.l5];
    let v17: boolean;
    if ((!patternInput[1]) === false) {
        v17 = true;
    }
    else {
        const patternInput_1: [[US4, int32, string, string][], [US4, US4][]] = [v2.l4, v2.l5];
        v17 = ((!patternInput_1[0]) === false);
    }
}

export function method11(v0_1: () => void): void {
    const v3: any = onCleanup;
    v3(v0_1);
}

export function method7(v0_1: any): any {
    const patternInput: [Mut1, (arg0: (arg0: Mut1, arg1: Mut1) => void) => void] = method8();
    const v3: () => boolean = (): boolean => closure3(patternInput[0], void 0);
    const v4: () => any[] = (): any[] => closure4(void 0, void 0);
    const v6: (arg0: any[]) => void = method9(v3, v4, "#cf1100");
    v6(["> db_listener ()"]);
    const v10: any = v0_1.on;
    const v11: (arg0: [Mut1, Mut1, any]) => void = (arg10$0040_2: [Mut1, Mut1, any]): void => {
        closure6(v6, arg10$0040_2);
    };
    const v12: any = (...args: any[]) => v11(args);
    method11(v10("@changed", v12));
    return <></>;
}

export function closure1(v0_1: any, v1_1: Mut2): any {
    return method7(v0_1);
}

export function closure8(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], US3_US3_1("$bg"), _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], US3_US3_1("$text1"), _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], US3_US3_1("flex"), _arg[19], _arg[20], US3_US3_1("1"), US3_US3_1("column"), _arg[23], US3_US3_1("$sm"), US3_US3_1("100vh"), _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], US3_US3_1("100vw"), _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US3_US3_1("1px"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure11(v0_1: Mut1, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v79_1: string = "0";
    return [_arg[0], _arg[1], _arg[2], _arg[3], US3_US3_1("$blackAlpha9"), _arg[5], _arg[6], _arg[7], _arg[8], US3_US3_1(v79_1), _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], US3_US3_1("flex"), _arg[19], _arg[20], _arg[21], US3_US3_1("column"), _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], US3_US3_1("80vh"), US3_US3_1("50vw"), _arg[40], _arg[41], _arg[42], _arg[43], US3_US3_1("auto"), _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], (v0_1.l10.tag === US2_Tag.US2_0) ? US3_US3_1("absolute") : US3_US3_0(), US3_US3_1(v79_1), _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], US2_US2_1(2), _arg[67]];
}

export function closure14(v0_1: Mut3, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v69: US3 = v0_1.l46;
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], US3_US3_1("flex"), _arg[19], _arg[20], US3_US3_1("1"), US3_US3_1("column"), _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], US3_US3_1("hidden"), US3_US3_1((v69.tag === US3_Tag.US3_1) ? v69.fields[0] : "hidden"), _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure16(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure17(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], US3_US3_1("$blackAlpha3"), _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], US3_US3_1("flex"), _arg[19], _arg[20], _arg[21], US3_US3_1("column"), _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], US3_US3_1("-1px"), _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function method16(): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [US3_US3_0(), US3_US3_0(), US3_US3_0(), US6_US6_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US7_US7_0(), US8_US8_0(), US3_US3_0(), US3_US3_0(), US7_US7_0(), US9_US9_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US10_US10_0(), US7_US7_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US11_US11_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US11_US11_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US12_US12_0(), US13_US13_0(), US12_US12_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US11_US11_0(), US3_US3_0(), US3_US3_0(), US9_US9_0(), US9_US9_0(), US3_US3_0(), US2_US2_0(), US3_US3_0()];
}

export function method19(v0_1_mut: UH0, v1_1_mut: int32): int32 {
    method19:
    while (true) {
        const v0_1: UH0 = v0_1_mut, v1_1: int32 = v1_1_mut;
        if (v0_1.tag === UH0_Tag.UH0_1) {
            return v1_1 | 0;
        }
        else {
            v0_1_mut = v0_1.fields[1];
            v1_1_mut = (v1_1 + 1);
            continue method19;
        }
        break;
    }
}

export function method20(v0_1_mut: [string, any][], v1_1_mut: UH0, v2_mut: int32): int32 {
    method20:
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
            continue method20;
        }
        break;
    }
}

export function method18(v0_1: UH0): [string, any][] {
    const v2: int32 = method19(v0_1, 0) | 0;
    const v3: [string, any][] = fill(new Array(v2), 0, v2, null);
    const v5: int32 = method20(v3, v0_1, 0) | 0;
    return v3;
}

export function method17(v0_1: US3, v1_1: US3, v2: US3, v3: US6, v4: US3, v5: US3, v6: US3, v7: US3, v8: US3, v9: US3, v10: US7, v11: US8, v12: US3, v13: US3, v14: US7, v15: US9, v16: US3, v17: US3, v18: US3, v19: US10, v20: US7, v21: US3, v22: US3, v23: US3, v24: US3, v25: US3, v26: US3, v27: US11, v28: US3, v29: US3, v30: US3, v31: US11, v32: US3, v33: US3, v34: US3, v35: US3, v36: US3, v37: US3, v38: US3, v39: US3, v40: US12, v41: US13, v42: US12, v43: US3, v44: US3, v45: US3, v46: US3, v47: US3, v48: US3, v49: US3, v50: US3, v51: US3, v52: US3, v53: US3, v54: US3, v55: US3, v56: US3, v57: US3, v58: US3, v59: US3, v60: US11, v61: US3, v62: US3, v63: US9, v64: US9, v65: US3, v66: US2, v67: US3): [string, any][] {
    const v71_1: any = (v0_1.tag === US3_Tag.US3_1) ? v0_1.fields[0] : (void 0);
    const v78_1: UH0 = (!v71_1) ? UH0_UH0_1() : UH0_UH0_0(["alignItems", v71_1], UH0_UH0_1());
    const v82_1: any = (v1_1.tag === US3_Tag.US3_1) ? v1_1.fields[0] : (void 0);
    const v87_1: UH0 = (!v82_1) ? v78_1 : UH0_UH0_0(["alignSelf", v82_1], v78_1);
    const v91_1: any = (v2.tag === US3_Tag.US3_1) ? v2.fields[0] : (void 0);
    const v96_1: UH0 = (!v91_1) ? v87_1 : UH0_UH0_0(["aria-label", v91_1], v87_1);
    const v100_1: any = (v3.tag === US6_Tag.US6_1) ? v3.fields[0] : (void 0);
    const v105: UH0 = (!v100_1) ? v96_1 : UH0_UH0_0(["as", v100_1], v96_1);
    const v109: any = (v4.tag === US3_Tag.US3_1) ? v4.fields[0] : (void 0);
    const v114: UH0 = (!v109) ? v105 : UH0_UH0_0(["backgroundColor", v109], v105);
    const v118: any = (v5.tag === US3_Tag.US3_1) ? v5.fields[0] : (void 0);
    const v123: UH0 = (!v118) ? v114 : UH0_UH0_0(["border", v118], v114);
    const v127: any = (v6.tag === US3_Tag.US3_1) ? v6.fields[0] : (void 0);
    const v132: UH0 = (!v127) ? v123 : UH0_UH0_0(["borderBottomWidth", v127], v123);
    const v136: any = (v7.tag === US3_Tag.US3_1) ? v7.fields[0] : (void 0);
    const v141: UH0 = (!v136) ? v132 : UH0_UH0_0(["borderColor", v136], v132);
    const v145: any = (v8.tag === US3_Tag.US3_1) ? v8.fields[0] : (void 0);
    const v150: UH0 = (!v145) ? v141 : UH0_UH0_0(["borderWidth", v145], v141);
    const v154: any = (v9.tag === US3_Tag.US3_1) ? v9.fields[0] : (void 0);
    const v159: UH0 = (!v154) ? v150 : UH0_UH0_0(["bottom", v154], v150);
    const v163: any = (v10.tag === US7_Tag.US7_1) ? v10.fields[0] : (void 0);
    const v168: UH0 = (!v163) ? v159 : UH0_UH0_0(["checked", v163], v159);
    const v172: any = (v11.tag === US8_Tag.US8_1) ? v11.fields[0] : (void 0);
    const v177: UH0 = (!v172) ? v168 : UH0_UH0_0(["children", v172], v168);
    const v181: any = (v12.tag === US3_Tag.US3_1) ? v12.fields[0] : (void 0);
    const v186: UH0 = (!v181) ? v177 : UH0_UH0_0(["color", v181], v177);
    const v190: any = (v13.tag === US3_Tag.US3_1) ? v13.fields[0] : (void 0);
    const v195: UH0 = (!v190) ? v186 : UH0_UH0_0(["colorScheme", v190], v186);
    const v199: any = (v14.tag === US7_Tag.US7_1) ? v14.fields[0] : (void 0);
    const v204: UH0 = (!v199) ? v195 : UH0_UH0_0(["compact", v199], v195);
    const v208: any = (v15.tag === US9_Tag.US9_1) ? v15.fields[0] : (void 0);
    const v213: UH0 = (!v208) ? v204 : UH0_UH0_0(["css", v208], v204);
    const v217: any = (v16.tag === US3_Tag.US3_1) ? v16.fields[0] : (void 0);
    const v222: UH0 = (!v217) ? v213 : UH0_UH0_0(["defaultValue", v217], v213);
    const v226: any = (v17.tag === US3_Tag.US3_1) ? v17.fields[0] : (void 0);
    const v231: UH0 = (!v226) ? v222 : UH0_UH0_0(["direction", v226], v222);
    const v235: any = (v18.tag === US3_Tag.US3_1) ? v18.fields[0] : (void 0);
    const v240: UH0 = (!v235) ? v231 : UH0_UH0_0(["display", v235], v231);
    const v244: any = (v19.tag === US10_Tag.US10_1) ? v19.fields[0] : (void 0);
    const v249: UH0 = (!v244) ? v240 : UH0_UH0_0(["each", v244], v240);
    const v253: any = (v20.tag === US7_Tag.US7_1) ? v20.fields[0] : (void 0);
    const v258: UH0 = (!v253) ? v249 : UH0_UH0_0(["external", v253], v249);
    const v262: any = (v21.tag === US3_Tag.US3_1) ? v21.fields[0] : (void 0);
    const v267: UH0 = (!v262) ? v258 : UH0_UH0_0(["flex", v262], v258);
    const v271: any = (v22.tag === US3_Tag.US3_1) ? v22.fields[0] : (void 0);
    const v276: UH0 = (!v271) ? v267 : UH0_UH0_0(["flexDirection", v271], v267);
    const v280: any = (v23.tag === US3_Tag.US3_1) ? v23.fields[0] : (void 0);
    const v285: UH0 = (!v280) ? v276 : UH0_UH0_0(["flexFlow", v280], v276);
    const v289: any = (v24.tag === US3_Tag.US3_1) ? v24.fields[0] : (void 0);
    const v294: UH0 = (!v289) ? v285 : UH0_UH0_0(["fontSize", v289], v285);
    const v298: any = (v25.tag === US3_Tag.US3_1) ? v25.fields[0] : (void 0);
    const v303: UH0 = (!v298) ? v294 : UH0_UH0_0(["height", v298], v294);
    const v307: any = (v26.tag === US3_Tag.US3_1) ? v26.fields[0] : (void 0);
    const v312: UH0 = (!v307) ? v303 : UH0_UH0_0(["href", v307], v303);
    const v316: any = (v27.tag === US11_Tag.US11_1) ? v27.fields[0] : (void 0);
    const v321: UH0 = (!v316) ? v312 : UH0_UH0_0(["icon", v316], v312);
    const v325: any = (v28.tag === US3_Tag.US3_1) ? v28.fields[0] : (void 0);
    const v330: UH0 = (!v325) ? v321 : UH0_UH0_0(["id", v325], v321);
    const v334: any = (v29.tag === US3_Tag.US3_1) ? v29.fields[0] : (void 0);
    const v339: UH0 = (!v334) ? v330 : UH0_UH0_0(["justifyContent", v334], v330);
    const v343: any = (v30.tag === US3_Tag.US3_1) ? v30.fields[0] : (void 0);
    const v348: UH0 = (!v343) ? v339 : UH0_UH0_0(["left", v343], v339);
    const v352: any = (v31.tag === US11_Tag.US11_1) ? v31.fields[0] : (void 0);
    const v357: UH0 = (!v352) ? v348 : UH0_UH0_0(["leftIcon", v352], v348);
    const v361: any = (v32.tag === US3_Tag.US3_1) ? v32.fields[0] : (void 0);
    const v366: UH0 = (!v361) ? v357 : UH0_UH0_0(["lineHeight", v361], v357);
    const v370: any = (v33.tag === US3_Tag.US3_1) ? v33.fields[0] : (void 0);
    const v375: UH0 = (!v370) ? v366 : UH0_UH0_0(["margin", v370], v366);
    const v379: any = (v34.tag === US3_Tag.US3_1) ? v34.fields[0] : (void 0);
    const v384: UH0 = (!v379) ? v375 : UH0_UH0_0(["marginBottom", v379], v375);
    const v388: any = (v35.tag === US3_Tag.US3_1) ? v35.fields[0] : (void 0);
    const v393: UH0 = (!v388) ? v384 : UH0_UH0_0(["marginLeft", v388], v384);
    const v397: any = (v36.tag === US3_Tag.US3_1) ? v36.fields[0] : (void 0);
    const v402: UH0 = (!v397) ? v393 : UH0_UH0_0(["marginRight", v397], v393);
    const v406: any = (v37.tag === US3_Tag.US3_1) ? v37.fields[0] : (void 0);
    const v411: UH0 = (!v406) ? v402 : UH0_UH0_0(["marginTop", v406], v402);
    const v415: any = (v38.tag === US3_Tag.US3_1) ? v38.fields[0] : (void 0);
    const v420: UH0 = (!v415) ? v411 : UH0_UH0_0(["maxHeight", v415], v411);
    const v424: any = (v39.tag === US3_Tag.US3_1) ? v39.fields[0] : (void 0);
    const v429: UH0 = (!v424) ? v420 : UH0_UH0_0(["maxWidth", v424], v420);
    const v433: any = (v40.tag === US12_Tag.US12_1) ? v40.fields[0] : (void 0);
    const v438: UH0 = (!v433) ? v429 : UH0_UH0_0(["onChange", v433], v429);
    const v442: any = (v41.tag === US13_Tag.US13_1) ? v41.fields[0] : (void 0);
    const v447: UH0 = (!v442) ? v438 : UH0_UH0_0(["onClick", v442], v438);
    const v451: any = (v42.tag === US12_Tag.US12_1) ? v42.fields[0] : (void 0);
    const v456: UH0 = (!v451) ? v447 : UH0_UH0_0(["onInput", v451], v447);
    const v460: any = (v43.tag === US3_Tag.US3_1) ? v43.fields[0] : (void 0);
    const v465: UH0 = (!v460) ? v456 : UH0_UH0_0(["outline", v460], v456);
    const v469: any = (v44.tag === US3_Tag.US3_1) ? v44.fields[0] : (void 0);
    const v474: UH0 = (!v469) ? v465 : UH0_UH0_0(["overflow", v469], v465);
    const v478: any = (v45.tag === US3_Tag.US3_1) ? v45.fields[0] : (void 0);
    const v483: UH0 = (!v478) ? v474 : UH0_UH0_0(["overflowX", v478], v474);
    const v487: any = (v46.tag === US3_Tag.US3_1) ? v46.fields[0] : (void 0);
    const v492: UH0 = (!v487) ? v483 : UH0_UH0_0(["overflowY", v487], v483);
    const v496: any = (v47.tag === US3_Tag.US3_1) ? v47.fields[0] : (void 0);
    const v501: UH0 = (!v496) ? v492 : UH0_UH0_0(["padding", v496], v492);
    const v505: any = (v48.tag === US3_Tag.US3_1) ? v48.fields[0] : (void 0);
    const v510: UH0 = (!v505) ? v501 : UH0_UH0_0(["paddingBottom", v505], v501);
    const v514: any = (v49.tag === US3_Tag.US3_1) ? v49.fields[0] : (void 0);
    const v519: UH0 = (!v514) ? v510 : UH0_UH0_0(["paddingLeft", v514], v510);
    const v523: any = (v50.tag === US3_Tag.US3_1) ? v50.fields[0] : (void 0);
    const v528: UH0 = (!v523) ? v519 : UH0_UH0_0(["paddingRight", v523], v519);
    const v532: any = (v51.tag === US3_Tag.US3_1) ? v51.fields[0] : (void 0);
    const v537: UH0 = (!v532) ? v528 : UH0_UH0_0(["paddingTop", v532], v528);
    const v541: any = (v52.tag === US3_Tag.US3_1) ? v52.fields[0] : (void 0);
    const v546: UH0 = (!v541) ? v537 : UH0_UH0_0(["placeholder", v541], v537);
    const v550: any = (v53.tag === US3_Tag.US3_1) ? v53.fields[0] : (void 0);
    const v555: UH0 = (!v550) ? v546 : UH0_UH0_0(["position", v550], v546);
    const v559: any = (v54.tag === US3_Tag.US3_1) ? v54.fields[0] : (void 0);
    const v564: UH0 = (!v559) ? v555 : UH0_UH0_0(["right", v559], v555);
    const v568: any = (v55.tag === US3_Tag.US3_1) ? v55.fields[0] : (void 0);
    const v573: UH0 = (!v568) ? v564 : UH0_UH0_0(["size", v568], v564);
    const v577: any = (v56.tag === US3_Tag.US3_1) ? v56.fields[0] : (void 0);
    const v582: UH0 = (!v577) ? v573 : UH0_UH0_0(["spacing", v577], v573);
    const v586: any = (v57.tag === US3_Tag.US3_1) ? v57.fields[0] : (void 0);
    const v591: UH0 = (!v586) ? v582 : UH0_UH0_0(["src", v586], v582);
    const v595: any = (v58.tag === US3_Tag.US3_1) ? v58.fields[0] : (void 0);
    const v600: UH0 = (!v595) ? v591 : UH0_UH0_0(["striped", v595], v591);
    const v604: any = (v59.tag === US3_Tag.US3_1) ? v59.fields[0] : (void 0);
    const v609: UH0 = (!v604) ? v600 : UH0_UH0_0(["thickness", v604], v600);
    const v613: any = (v60.tag === US11_Tag.US11_1) ? v60.fields[0] : (void 0);
    const v618: UH0 = (!v613) ? v609 : UH0_UH0_0(["title", v613], v609);
    const v622: any = (v61.tag === US3_Tag.US3_1) ? v61.fields[0] : (void 0);
    const v627: UH0 = (!v622) ? v618 : UH0_UH0_0(["top", v622], v618);
    const v631: any = (v62.tag === US3_Tag.US3_1) ? v62.fields[0] : (void 0);
    const v636: UH0 = (!v631) ? v627 : UH0_UH0_0(["type", v631], v627);
    const v640: any = (v63.tag === US9_Tag.US9_1) ? v63.fields[0] : (void 0);
    const v645: UH0 = (!v640) ? v636 : UH0_UH0_0(["value", v640], v636);
    const v649: any = (v64.tag === US9_Tag.US9_1) ? v64.fields[0] : (void 0);
    const v654: UH0 = (!v649) ? v645 : UH0_UH0_0(["when", v649], v645);
    const v658: any = (v65.tag === US3_Tag.US3_1) ? v65.fields[0] : (void 0);
    const v663: UH0 = (!v658) ? v654 : UH0_UH0_0(["width", v658], v654);
    const v667: any = (v66.tag === US2_Tag.US2_1) ? v66.fields[0] : (void 0);
    const v672: UH0 = (!v667) ? v663 : UH0_UH0_0(["zIndex", v667], v663);
    const v676: any = (v67.tag === US3_Tag.US3_1) ? v67.fields[0] : (void 0);
    return method18((!v676) ? v672 : UH0_UH0_0(["zoom", v676], v672));
}

export function method15(v0_1: any, v1_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3], v2: () => any[]): any {
    const patternInput: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = method16();
    const patternInput_1: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = v1_1([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]]);
    const v141: any = createObj(method17(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US8_US8_1(v2), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67]));
    const v142: (arg0: any) => any = v0_1;
    const v145: any = createComponent;
    return v145(v142, v141);
}

export function closure15(v0_1: Mut3, unitVar: void): any[] {
    const v1_1: US8 = v0_1.l11;
    const v7: any = Tbody;
    const v8: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_1: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure17(void 0, arg10$0040_1);
    return [method15(v7, v8, (v1_1.tag === US8_Tag.US8_1) ? v1_1.fields[0] : ((): any[] => closure16(void 0, void 0)))];
}

export function method14(v0_1: Mut3): any {
    const v3: any = Table;
    const v4: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure14(v0_1, arg10$0040);
    const v5: () => any[] = (): any[] => closure15(v0_1, void 0);
    return method15(v3, v4, v5);
}

export function closure13(unitVar: void, v0_1: Mut3): any {
    return method14(v0_1);
}

export function closure18(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function method22(v0_1: boolean): [() => boolean, (arg0: boolean) => void] {
    let value_1: any, value_2: any;
    const v3: any = createSignal;
    const v4: any[] = v3(v0_1);
    return [(value_1 = v4[0], value_1), (value_2 = v4[1], (arg_1: boolean): void => {
        value_2(arg_1);
    })];
}

export function method23(v0_1: string, v1_1: string): string {
    return {
        "@initial": v1_1,
        "@sm": v0_1,
    };
}

export function closure21(v0_1: US3, v1_1: US3, v2: US3, v3: US6, v4: US3, v5: US3, v6: US3, v7: US3, v8: US3, v9: US3, v10: US7, v11: US8, v12: US3, v13: US3, v14: US7, v15: US9, v16: US3, v17: US3, v18: US3, v19: US10, v20: US7, v21: US3, v22: US3, v23: US3, v24: US3, v25: US3, v26: US3, v27: US11, v28: US3, v29: US3, v30: US3, v31: US11, v32: US3, v33: US3, v34: US3, v35: US3, v36: US3, v37: US3, v38: US3, v39: US3, v40: US12, v41: US13, v42: US12, v43: US3, v44: US3, v45: US3, v46: US3, v47: US3, v48: US3, v49: US3, v50: US3, v51: US3, v52: US3, v53: US3, v54: US3, v55: US3, v56: US3, v57: US3, v58: US3, v59: US3, v60: US11, v61: US3, v62: US3, v63: US9, v64: US9, v65: US3, v66: US2, v67: US3, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], US3_US3_1("$neutral5"), US3_US3_1("1px 2px"), _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], US3_US3_1("flex"), _arg[19], _arg[20], US3_US3_1("1"), US3_US3_1(method23("row", "column")), _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], v28, _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure23(v0_1: Mut4, v1_1: () => boolean, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], US3_US3_1(((v0_1.l3.tag === US15_Tag.US15_2) ? true : v1_1()) ? method23("0px !important", "2px !important") : "0px !important"), US3_US3_1("$neutral5"), _arg[8], _arg[9], _arg[10], _arg[11], US3_US3_1("$neutral9"), _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], US3_US3_1("flex"), _arg[19], _arg[20], _arg[21], US3_US3_1("column"), _arg[23], US3_US3_1("$sm"), _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US3_US3_1("3px 20px 0 8px"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure27(v0_1: Mut5, v1_1: any): void {
    const v2: boolean = v1_1.target.checked;
    v0_1.l1(v2);
}

export function closure26(v0_1: Mut5, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v76_1: (arg0: any) => void = (v: any): void => {
        closure27(v0_1, v);
    };
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], US7_US7_1(v0_1.l0()), _arg[11], _arg[12], US3_US3_1("neutral"), _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], US3_US3_1("2px"), _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], US12_US12_1(v76_1), _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], US3_US3_1("sm"), _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure29(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure30(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], US3_US3_1("2px"), _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure28(v0_1: US3, v1_1: US3, v2: US3, v3: US6, v4: US3, v5: US3, v6: US3, v7: US3, v8: US3, v9: US3, v10: US7, v11: US8, v12: US3, v13: US3, v14: US7, v15: US9, v16: US3, v17: US3, v18: US3, v19: US10, v20: US7, v21: US3, v22: US3, v23: US3, v24: US3, v25: US3, v26: US3, v27: US11, v28: US3, v29: US3, v30: US3, v31: US11, v32: US3, v33: US3, v34: US3, v35: US3, v36: US3, v37: US3, v38: US3, v39: US3, v40: US12, v41: US13, v42: US12, v43: US3, v44: US3, v45: US3, v46: US3, v47: US3, v48: US3, v49: US3, v50: US3, v51: US3, v52: US3, v53: US3, v54: US3, v55: US3, v56: US3, v57: US3, v58: US3, v59: US3, v60: US11, v61: US3, v62: US3, v63: US9, v64: US9, v65: US3, v66: US2, v67: US3, unitVar: void): any[] {
    const v73_1: any = Box;
    const v74_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_1: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure30(void 0, arg10$0040_1);
    return [method15(v73_1, v74_1, (v11.tag === US8_Tag.US8_1) ? v11.fields[0] : ((): any[] => closure29(void 0, void 0)))];
}

export function closure25(unitVar: void, v0_1: Mut5): any {
    const v1_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = v0_1.l2;
    const patternInput: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = method16();
    const patternInput_1: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = v1_1([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]]);
    const v140: any = Checkbox;
    const v141: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure26(v0_1, arg10$0040);
    const v142: () => any[] = (): any[] => closure28(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], patternInput_1[11], patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67], void 0);
    return method15(v140, v141, v142);
}

export function closure32(v0_1: any, unitVar: void): any[] {
    return [v0_1];
}

export function closure31(v0_1: any, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v69: () => any[] = (): any[] => closure32(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v69), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function method24(v0_1: (arg0: Mut5) => any, v1_1: () => boolean, v2: (arg0: boolean) => void, v3: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): any {
    const v4: Mut5 = new Mut5(v1_1, v2, v3);
    const v7: any = createComponent;
    return v7(v0_1, v4);
}

export function closure24(v0_1: Mut4, v1_1: (arg0: boolean) => void, v2: () => boolean, v3: any, unitVar: void): any[] {
    let v8: (arg0: Mut5) => any, v9: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3], v5: (arg0: Mut5) => any, v6: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3];
    const v4: US15 = v0_1.l3;
    return [(v4.tag === US15_Tag.US15_1) ? ((v8 = ((v_1: Mut5): any => closure25(void 0, v_1)), (v9 = ((arg10$0040_1: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure31(v3, arg10$0040_1)), method24(v8, v2, v1_1, v9)))) : ((v4.tag === US15_Tag.US15_2) ? v3 : ((v5 = ((v: Mut5): any => closure25(void 0, v)), (v6 = ((arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure31(v3, arg10$0040)), method24(v5, v2, v1_1, v6)))))];
}

export function closure33(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v68: string = "0";
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], US3_US3_1(v68), _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], US3_US3_1("9px"), _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US3_US3_1(v68), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure34(unitVar: void, unitVar_1: void): any[] {
    return [<>
        &nbsp;
    </>];
}

export function closure35(v0_1: US3, v1_1: US3, v2: US3, v3: US6, v4: US3, v5: US3, v6: US3, v7: US3, v8: US3, v9: US3, v10: US7, v11: US8, v12: US3, v13: US3, v14: US7, v15: US9, v16: US3, v17: US3, v18: US3, v19: US10, v20: US7, v21: US3, v22: US3, v23: US3, v24: US3, v25: US3, v26: US3, v27: US11, v28: US3, v29: US3, v30: US3, v31: US11, v32: US3, v33: US3, v34: US3, v35: US3, v36: US3, v37: US3, v38: US3, v39: US3, v40: US12, v41: US13, v42: US12, v43: US3, v44: US3, v45: US3, v46: US3, v47: US3, v48: US3, v49: US3, v50: US3, v51: US3, v52: US3, v53: US3, v54: US3, v55: US3, v56: US3, v57: US3, v58: US3, v59: US3, v60: US11, v61: US3, v62: US3, v63: US9, v64: US9, v65: US3, v66: US2, v67: US3, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v139: string = "0";
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], US3_US3_1(v139), _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], US3_US3_1("flex"), _arg[19], _arg[20], US3_US3_1("6"), US3_US3_1("column"), _arg[23], US3_US3_1("$sm"), _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], US3_US3_1("$base"), US3_US3_1(v139), _arg[34], _arg[35], _arg[36], _arg[37], US3_US3_1("85vh"), _arg[39], _arg[40], _arg[41], _arg[42], US3_US3_1(v139), _arg[44], _arg[45], US3_US3_1("auto"), US3_US3_1((v47.tag === US3_Tag.US3_1) ? v47.fields[0] : "0"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure38(v0_1: Mut1, unitVar: void): boolean {
    if (v0_1.l9.tag === US5_Tag.US5_0) {
        return true;
    }
    else {
        return false;
    }
}

export function closure39(v0_1: int32, unitVar: void): any[] {
    return [v0_1];
}

export function closure42(v0_1: int32, v1_1: Mut1): void {
    v1_1.l10 = US2_US2_1(v0_1);
}

export function closure41(v0_1: int32, v1_1: Mut1): (arg0: Mut1) => void {
    return (v: Mut1): void => {
        closure42(v0_1, v);
    };
}

export function closure40(v0_1: Mut6, v1_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void, v2: int32, unitVar: void): void {
    if (v0_1.l1) {
        const v4: (arg0: Mut1, arg1: Mut1) => void = (v: Mut1): (arg0: Mut1) => void => closure41(v2, v);
        v1_1(v4);
    }
}

export function method26(v0_1: () => void): void {
    const v3: any = createEffect;
    v3(v0_1);
}

export function closure43(v0_1: (arg0: boolean) => void, v1_1: () => boolean, unitVar: void): void {
    if (v1_1()) {
        v0_1(false);
    }
}

export function closure44(v0_1: Mut6, v1_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void, v2: Mut1, unitVar: void): void {
    const v3: US14 = v0_1.l3;
    if (v3.tag === US14_Tag.US14_1) {
        v3.fields[0](v2, v1_1);
    }
}

export function closure45(v0_1: US3, v1_1: US3, v2: US3, v3: US6, v4: US3, v5: US3, v6: US3, v7: US3, v8: US3, v9: US3, v10: US7, v11: US8, v12: US3, v13: US3, v14: US7, v15: US9, v16: US3, v17: US3, v18: US3, v19: US10, v20: US7, v21: US3, v22: US3, v23: US3, v24: US3, v25: US3, v26: US3, v27: US11, v28: US3, v29: US3, v30: US3, v31: US11, v32: US3, v33: US3, v34: US3, v35: US3, v36: US3, v37: US3, v38: US3, v39: US3, v40: US12, v41: US13, v42: US12, v43: US3, v44: US3, v45: US3, v46: US3, v47: US3, v48: US3, v49: US3, v50: US3, v51: US3, v52: US3, v53: US3, v54: US3, v55: US3, v56: US3, v57: US3, v58: US3, v59: US3, v60: US11, v61: US3, v62: US3, v63: US9, v64: US9, v65: US3, v66: US2, v67: US3, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], US3_US3_1("flex"), _arg[19], _arg[20], US3_US3_1("1"), _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], v28, _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure47(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US3_US3_1("3px 0"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure50(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function method29(v0_1: int32, v1_1: Mut7): boolean {
    return v1_1.l0 < v0_1;
}

export function method28(v0_1: Mut3, v1_1: Mut3): void {
    const v2: string[] = Object.keys(v0_1);
    const v3: int32 = v2.length | 0;
    const v4: Mut7 = new Mut7(0);
    while (method29(v3, v4)) {
        const v6: int32 = v4.l0 | 0;
        const v7: string = v2[v6];
        if (!!v1_1[v7].tag) {
            v0_1[v7] = v1_1[v7];
        }
        const v9: int32 = (v6 + 1) | 0;
        v4.l0 = (v9 | 0);
    }
}

export function closure51(v0_1: Mut3, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const patternInput: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = [v0_1.l0, v0_1.l1, v0_1.l2, v0_1.l3, v0_1.l4, v0_1.l5, v0_1.l6, v0_1.l7, v0_1.l8, v0_1.l9, v0_1.l10, v0_1.l11, v0_1.l12, v0_1.l13, v0_1.l14, v0_1.l15, v0_1.l16, v0_1.l17, v0_1.l18, v0_1.l19, v0_1.l20, v0_1.l21, v0_1.l22, v0_1.l23, v0_1.l24, v0_1.l25, v0_1.l26, v0_1.l27, v0_1.l28, v0_1.l29, v0_1.l30, v0_1.l31, v0_1.l32, v0_1.l33, v0_1.l34, v0_1.l35, v0_1.l36, v0_1.l37, v0_1.l38, v0_1.l39, v0_1.l40, v0_1.l41, v0_1.l42, v0_1.l43, v0_1.l44, v0_1.l45, v0_1.l46, v0_1.l47, v0_1.l48, v0_1.l49, v0_1.l50, v0_1.l51, v0_1.l52, v0_1.l53, v0_1.l54, v0_1.l55, v0_1.l56, v0_1.l57, v0_1.l58, v0_1.l59, v0_1.l60, v0_1.l61, v0_1.l62, v0_1.l63, v0_1.l64, v0_1.l65, v0_1.l66, v0_1.l67];
    const v145: Mut3 = new Mut3(_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], US3_US3_1("neutral"), US7_US7_1(true), _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], US3_US3_1("left"), _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], US3_US3_1("xs"), _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]);
    method28(v145, new Mut3(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]));
    const patternInput_1: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = [v145.l0, v145.l1, v145.l2, v145.l3, v145.l4, v145.l5, v145.l6, v145.l7, v145.l8, v145.l9, v145.l10, v145.l11, v145.l12, v145.l13, v145.l14, v145.l15, v145.l16, v145.l17, v145.l18, v145.l19, v145.l20, v145.l21, v145.l22, v145.l23, v145.l24, v145.l25, v145.l26, v145.l27, v145.l28, v145.l29, v145.l30, v145.l31, v145.l32, v145.l33, v145.l34, v145.l35, v145.l36, v145.l37, v145.l38, v145.l39, v145.l40, v145.l41, v145.l42, v145.l43, v145.l44, v145.l45, v145.l46, v145.l47, v145.l48, v145.l49, v145.l50, v145.l51, v145.l52, v145.l53, v145.l54, v145.l55, v145.l56, v145.l57, v145.l58, v145.l59, v145.l60, v145.l61, v145.l62, v145.l63, v145.l64, v145.l65, v145.l66, v145.l67];
    return [patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], patternInput_1[11], patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67]];
}

export function method27(v0_1: Mut3): any {
    const v1_1: US8 = v0_1.l11;
    const v7: any = Button;
    const v8: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_1: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure51(v0_1, arg10$0040_1);
    return method15(v7, v8, (v1_1.tag === US8_Tag.US8_1) ? v1_1.fields[0] : ((): any[] => closure50(void 0, void 0)));
}

export function closure49(unitVar: void, v0_1: Mut3): any {
    return method27(v0_1);
}

export function closure53(v0_1: (arg0: boolean) => void, v1_1: Mut6, v2: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void, v3: Mut1, unitVar: void): void {
    const v4: US14 = v1_1.l2;
    if (v4.tag === US14_Tag.US14_1) {
        v4.fields[0](v3, v2);
    }
    v0_1(true);
}

export function closure52(v0_1: (arg0: boolean) => void, v1_1: Mut6, v2: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void, v3: Mut1, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v72_1: () => void = (): void => {
        closure53(v0_1, v1_1, v2, v3, void 0);
    };
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], US13_US13_1(v72_1), _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure54(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Load
    </>];
}

export function method30(v0_1: (arg0: Mut3) => any, v1_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3], v2: () => any[]): any {
    const patternInput: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = method16();
    const patternInput_1: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = v1_1([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]]);
    const v140: Mut3 = new Mut3(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], US8_US8_1(v2), patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67]);
    v140.children = v2;
    const v143: any = createComponent;
    return v143(v0_1, v140);
}

export function closure48(v0_1: (arg0: boolean) => void, v1_1: Mut6, v2: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void, v3: Mut1, unitVar: void): any[] {
    const v4: (arg0: Mut3) => any = (v: Mut3): any => closure49(void 0, v);
    const v5: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure52(v0_1, v1_1, v2, v3, arg10$0040);
    const v6: () => any[] = (): any[] => closure54(void 0, void 0);
    return [method30(v4, v5, v6)];
}

export function closure55(v0_1: Mut1, v1_1: int32, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v71_1: US2 = v0_1.l10;
    const v78_1: US2 = ((v71_1.tag === US2_Tag.US2_1) && (v71_1.fields[0] === v1_1)) ? US2_US2_1(1) : US2_US2_0();
    const v80_1: US2 = v0_1.l10;
    const v88_1: US3 = ((v80_1.tag === US2_Tag.US2_1) && (v80_1.fields[0] === v1_1)) ? US3_US3_1("absolute") : US3_US3_0();
    const v90_1: US2 = v0_1.l10;
    const v98_1: US3 = ((v90_1.tag === US2_Tag.US2_1) && (v90_1.fields[0] === v1_1)) ? US3_US3_1("0") : US3_US3_0();
    const v100_1: US2 = v0_1.l10;
    const v108: US3 = ((v100_1.tag === US2_Tag.US2_1) && (v100_1.fields[0] === v1_1)) ? US3_US3_1("0") : US3_US3_0();
    const v110: US2 = v0_1.l10;
    const v118: US3 = ((v110.tag === US2_Tag.US2_1) && (v110.fields[0] === v1_1)) ? US3_US3_1("0") : US3_US3_0();
    const v120: US2 = v0_1.l10;
    const v128: US3 = ((v120.tag === US2_Tag.US2_1) && (v120.fields[0] === v1_1)) ? US3_US3_1("0") : US3_US3_0();
    const v130: US2 = v0_1.l10;
    return [_arg[0], _arg[1], _arg[2], _arg[3], ((v130.tag === US2_Tag.US2_1) && (v130.fields[0] === v1_1)) ? US3_US3_1("$bg") : US3_US3_0(), _arg[5], _arg[6], _arg[7], _arg[8], v118, _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], US3_US3_1("flex"), _arg[19], _arg[20], US3_US3_1("1"), _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], v128, _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], v88_1, v108, _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], v98_1, _arg[62], _arg[63], _arg[64], _arg[65], v78_1, _arg[67]];
}

export function closure57(v0_1: Mut1, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], US3_US3_1("flex"), _arg[19], _arg[20], US3_US3_1("1"), _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], (v0_1.l10.tag === US2_Tag.US2_0) ? US3_US3_1("relative") : US3_US3_0(), _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure59(v0_1: Mut1, v1_1: int32, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v71_1: US2 = v0_1.l10;
    const v85_1: string = "6px";
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], US3_US3_1("row"), (v71_1.tag === US2_Tag.US2_1) ? (((v71_1.fields[0] === v1_1) !== true) ? US3_US3_1("none") : US3_US3_0()) : US3_US3_0(), _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], US3_US3_1("absolute"), US3_US3_1(v85_1), _arg[55], US3_US3_1("3px"), _arg[57], _arg[58], _arg[59], _arg[60], US3_US3_1(v85_1), _arg[62], _arg[63], _arg[64], _arg[65], US2_US2_1(2), _arg[67]];
}

export function closure63(v0_1: Mut8, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v70_1: any = v0_1.l1();
    const patternInput: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = method16();
    const v140: string = "-12px";
    const patternInput_1: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = v0_1.l0([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], US3_US3_1(v140), patternInput[36], US3_US3_1(v140), patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], US3_US3_1("0.6")]);
    const v214: any = createObj(method17(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], patternInput_1[11], patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67]));
    const patternInput_2: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = v0_1.l2([_arg[0], _arg[1], _arg[2], US6_US6_1(v70_1), _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], US9_US9_1(v214), _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], US3_US3_1("14px"), _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]]);
    return [patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], patternInput_2[10], patternInput_2[11], patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], patternInput_2[18], patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], patternInput_2[29], patternInput_2[30], patternInput_2[31], patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], patternInput_2[41], patternInput_2[42], patternInput_2[43], patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62], patternInput_2[63], patternInput_2[64], patternInput_2[65], patternInput_2[66], patternInput_2[67]];
}

export function closure64(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function method31(v0_1: Mut8): any {
    const v3: any = Icon;
    const v4: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure63(v0_1, arg10$0040);
    const v5: () => any[] = (): any[] => closure64(void 0, void 0);
    return method15(v3, v4, v5);
}

export function closure62(unitVar: void, v0_1: Mut8): any {
    return method31(v0_1);
}

export function closure65(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularRefresh;
    return v2;
}

export function method32(v0_1: (arg0: Mut8) => any, v1_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3], v2: () => any): any {
    const v3: Mut8 = new Mut8(v1_1, v2, v1_1);
    const v6: any = createComponent;
    return v6(v0_1, v3);
}

export function closure66(v0_1: (arg0: boolean) => void, unitVar: void): void {
    v0_1(true);
}

export function closure61(v0_1: (arg0: boolean) => void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v69: (arg0: Mut8) => any = (v: Mut8): any => closure62(void 0, v);
    const v70_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040);
    const v71_1: () => any = (): any => closure65(void 0, void 0);
    const v80_1: () => void = (): void => {
        closure66(v0_1, void 0);
    };
    return [_arg[0], _arg[1], US3_US3_1("Refresh"), _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], US3_US3_1("neutral"), _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], US3_US3_1("20px"), _arg[26], US11_US11_1(method32(v69, v70_1, v71_1)), _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], US13_US13_1(v80_1), _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], US3_US3_1("xs"), _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure67(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure69(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularDownArrow;
    return v2;
}

export function closure70(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularUpArrow;
    return v2;
}

export function closure73(v0_1: int32, v1_1: Mut1, v2: Mut1): void {
    const v4: US2 = v1_1.l10;
    const v12: US2 = (((v4.tag === US2_Tag.US2_1) && (v4.fields[0] === v0_1)) === false) ? US2_US2_1(v0_1) : US2_US2_0();
    v2.l10 = v12;
}

export function closure72(v0_1: int32, v1_1: Mut1, v2: Mut1): (arg0: Mut1) => void {
    return (v: Mut1): void => {
        closure73(v0_1, v1_1, v);
    };
}

export function closure71(v0_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void, v1_1: int32, v2: Mut1, unitVar: void): void {
    const v3: (arg0: Mut1, arg1: Mut1) => void = (v: Mut1): (arg0: Mut1) => void => closure72(v1_1, v2, v);
    v0_1(v3);
}

export function closure68(v0_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void, v1_1: int32, v2: Mut1, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v72_1: US2 = v2.l10;
    const v79_1: string = ((v72_1.tag === US2_Tag.US2_1) && (v72_1.fields[0] === v1_1)) ? "Restore" : "Maximize";
    const v81_1: US2 = v2.l10;
    const v89_1: (arg0: Mut8) => any = (v: Mut8): any => closure62(void 0, v);
    const v90_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_2: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040_2);
    const v98_1: () => void = (): void => {
        closure71(v0_1, v1_1, v2, void 0);
    };
    return [_arg[0], _arg[1], US3_US3_1(v79_1), _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], US3_US3_1("neutral"), _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], US3_US3_1("20px"), _arg[26], US11_US11_1(method32(v89_1, v90_1, ((v81_1.tag === US2_Tag.US2_1) && (v81_1.fields[0] === v1_1)) ? ((): any => closure69(void 0, void 0)) : ((): any => closure70(void 0, void 0)))), _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], US13_US13_1(v98_1), _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], US3_US3_1("xs"), _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure74(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure76(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularUndo;
    return v2;
}

export function closure77(v0_1: (arg0: boolean) => void, v1_1: Mut6, v2: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void, v3: Mut1, unitVar: void): void {
    const v4: US14 = v1_1.l3;
    if (v4.tag === US14_Tag.US14_1) {
        v4.fields[0](v3, v2);
    }
    v0_1(false);
}

export function closure75(v0_1: (arg0: boolean) => void, v1_1: Mut6, v2: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void, v3: Mut1, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v72_1: (arg0: Mut8) => any = (v: Mut8): any => closure62(void 0, v);
    const v73_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040);
    const v74_1: () => any = (): any => closure76(void 0, void 0);
    const v83_1: () => void = (): void => {
        closure77(v0_1, v1_1, v2, v3, void 0);
    };
    return [_arg[0], _arg[1], US3_US3_1("Unload"), _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], US3_US3_1("neutral"), _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], US3_US3_1("20px"), _arg[26], US11_US11_1(method32(v72_1, v73_1, v74_1)), _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], US13_US13_1(v83_1), _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], US3_US3_1("xs"), _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure78(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure60(v0_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void, v1_1: int32, v2: (arg0: boolean) => void, v3: (arg0: boolean) => void, v4: Mut6, v5: Mut1, unitVar: void): any[] {
    const v8: any = IconButton;
    const v9: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure61(v3, arg10$0040);
    const v10: () => any[] = (): any[] => closure67(void 0, void 0);
    const v12: any = IconButton;
    const v13: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_2: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure68(v0_1, v1_1, v5, arg10$0040_2);
    const v14: () => any[] = (): any[] => closure74(void 0, void 0);
    const v16: any = IconButton;
    const v17: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_4: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure75(v2, v4, v0_1, v5, arg10$0040_4);
    const v18: () => any[] = (): any[] => closure78(void 0, void 0);
    return [method15(v8, v9, v10), method15(v12, v13, v14), method15(v16, v17, v18)];
}

export function closure58(v0_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void, v1_1: Mut1, v2: int32, v3: (arg0: boolean) => void, v4: (arg0: boolean) => void, v5: () => boolean, v6: Mut6, v7: () => any[], unitVar: void): any[] {
    const v10: any = Stack;
    const v11: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure59(v1_1, v2, arg10$0040);
    const v12: () => any[] = (): any[] => closure60(v0_1, v2, v3, v4, v6, v1_1, void 0);
    return [method15(v10, v11, v12), v5() ? <></> : v7];
}

export function closure56(v0_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void, v1_1: Mut1, v2: int32, v3: (arg0: boolean) => void, v4: (arg0: boolean) => void, v5: () => boolean, v6: Mut6, v7: US8, unitVar: void): any[] {
    let v12: any, v13: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3], v14: () => any[];
    return [(v7.tag === US8_Tag.US8_1) ? ((v12 = Box, (v13 = ((arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure57(v1_1, arg10$0040)), (v14 = ((): any[] => closure58(v0_1, v1_1, v2, v3, v4, v5, v6, v7.fields[0], void 0)), method15(v12, v13, v14))))) : <></>];
}

export function closure46(v0_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void, v1_1: Mut1, v2: int32, v3: (arg0: boolean) => void, v4: () => boolean, v5: (arg0: boolean) => void, v6: () => boolean, v7: Mut6, v8: US8, unitVar: void): any[] {
    let v13: any, v14: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3], v15: () => any[], v19: any, v20: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3], v21: () => any[];
    return [(v4() === false) ? ((v13 = Box, (v14 = ((arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure47(void 0, arg10$0040)), (v15 = ((): any[] => closure48(v3, v7, v0_1, v1_1, void 0)), method15(v13, v14, v15))))) : ((v19 = Box, (v20 = ((arg10$0040_2: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure55(v1_1, v2, arg10$0040_2)), (v21 = ((): any[] => closure56(v0_1, v1_1, v2, v3, v5, v6, v7, v8, void 0)), method15(v19, v20, v21)))))];
}

export function method25(v0_1: Mut6): any {
    let clo_1: () => any[];
    const v1_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = v0_1.l4;
    const patternInput: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = method16();
    const patternInput_1: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = v1_1([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]]);
    const v81_1: US8 = patternInput_1[11];
    const patternInput_2: [Mut1, (arg0: (arg0: Mut1, arg1: Mut1) => void) => void] = method8();
    const v139: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void = patternInput_2[1];
    const v138: Mut1 = patternInput_2[0];
    const v140: int32 = nonSeeded().Next0() | 0;
    const v141: () => boolean = (): boolean => closure38(v138, void 0);
    const v142: () => any[] = (): any[] => closure39(v140, void 0);
    method9(v141, v142, "#de884c")(["> loader ()"]);
    const patternInput_3: [() => boolean, (arg0: boolean) => void] = method22(v0_1.l0);
    const patternInput_4: [() => boolean, (arg0: boolean) => void] = method22(false);
    const v153: (arg0: boolean) => void = patternInput_4[1];
    const v152: () => boolean = patternInput_4[0];
    const v154: () => void = (): void => {
        closure40(v0_1, v139, v140, void 0);
    };
    method26(v154);
    const v155: () => void = (): void => {
        closure43(v153, v152, void 0);
    };
    method26(v155);
    const v156: () => void = (): void => {
        closure44(v0_1, v139, v138, void 0);
    };
    method11(v156);
    if (v0_1.l0 === true) {
        const v159: US14 = v0_1.l2;
        if (v159.tag === US14_Tag.US14_1) {
            v159.fields[0](v138, v139);
        }
    }
    let v170: US8;
    if (v81_1.tag === US8_Tag.US8_1) {
        const v166: any = createMemo;
        v170 = US8_US8_1((clo_1 = v166(v81_1.fields[0]), clo_1));
    }
    else {
        v170 = US8_US8_0();
    }
    const v173: any = Box;
    const v174: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_5: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure45(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], v81_1, patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67], arg10$0040_5);
    const v175: () => any[] = (): any[] => closure46(v139, v138, v140, patternInput_3[1], patternInput_3[0], v153, v152, v0_1, v170, void 0);
    return method15(v173, v174, v175);
}

export function closure37(unitVar: void, v0_1: Mut6): any {
    return method25(v0_1);
}

export function closure79(v0_1: () => any[], _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v0_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function method33(v0_1: (arg0: Mut6) => any, v1_1: boolean, v2: boolean, v3: US14, v4: US14, v5: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): any {
    const v6: Mut6 = new Mut6(v1_1, v2, v3, v4, v5);
    const v9: any = createComponent;
    return v9(v0_1, v6);
}

export function closure36(v0_1: Mut4, v1_1: () => boolean, v2: () => any[], unitVar: void): any[] {
    let v17: (arg0: Mut6) => any, v20: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3], v7: (arg0: Mut6) => any, v10: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3];
    const v3: US15 = v0_1.l3;
    return [(v3.tag === US15_Tag.US15_1) ? (v1_1() ? ((v17 = ((v_1: Mut6): any => closure37(void 0, v_1)), (v20 = ((arg10$0040_1: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure79(v2, arg10$0040_1)), method33(v17, true, false, v0_1.l0, v0_1.l1, v20)))) : <></>) : ((v3.tag === US15_Tag.US15_2) ? v2 : (v1_1() ? ((v7 = ((v: Mut6): any => closure37(void 0, v)), (v10 = ((arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure79(v2, arg10$0040)), method33(v7, true, false, v0_1.l0, v0_1.l1, v10)))) : <></>))];
}

export function closure22(v0_1: Mut4, v1_1: US3, v2: US3, v3: US3, v4: US6, v5: US3, v6: US3, v7: US3, v8: US3, v9: US3, v10: US3, v11: US7, v12: US8, v13: US3, v14: US3, v15: US7, v16: US9, v17: US3, v18: US3, v19: US3, v20: US10, v21: US7, v22: US3, v23: US3, v24: US3, v25: US3, v26: US3, v27: US3, v28: US11, v29: US3, v30: US3, v31: US3, v32: US11, v33: US3, v34: US3, v35: US3, v36: US3, v37: US3, v38: US3, v39: US3, v40: US3, v41: US12, v42: US13, v43: US12, v44: US3, v45: US3, v46: US3, v47: US3, v48: US3, v49: US3, v50: US3, v51: US3, v52: US3, v53: US3, v54: US3, v55: US3, v56: US3, v57: US3, v58: US3, v59: US3, v60: US3, v61: US11, v62: US3, v63: US3, v64: US9, v65: US9, v66: US3, v67: US2, v68: US3, v69: (arg0: boolean) => void, v70_1: () => boolean, unitVar: void): any[] {
    let v75_1: any, v76_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3], v77_1: () => any[], v89_1: any, v90_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3], v91_1: () => any[], v82_1: any, v83_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3], v84_1: () => any[];
    return [(v61.tag === US11_Tag.US11_1) ? ((v75_1 = Td, (v76_1 = ((arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure23(v0_1, v70_1, arg10$0040)), (v77_1 = ((): any[] => closure24(v0_1, v69, v70_1, v61.fields[0], void 0)), method15(v75_1, v76_1, v77_1))))) : <></>, (v12.tag === US8_Tag.US8_1) ? ((v89_1 = Td, (v90_1 = ((arg10$0040_4: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure35(v1_1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, arg10$0040_4)), (v91_1 = ((): any[] => closure36(v0_1, v70_1, v12.fields[0], void 0)), method15(v89_1, v90_1, v91_1))))) : ((v82_1 = Td, (v83_1 = ((arg10$0040_2: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure33(void 0, arg10$0040_2)), (v84_1 = ((): any[] => closure34(void 0, void 0)), method15(v82_1, v83_1, v84_1)))))];
}

export function method21(v0_1: Mut4): any {
    const v1_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = v0_1.l2;
    const patternInput: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = method16();
    const patternInput_1: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = v1_1([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]]);
    const v99_1: US3 = patternInput_1[29];
    const v98_1: US3 = patternInput_1[28];
    const v97_1: US11 = patternInput_1[27];
    const v96_1: US3 = patternInput_1[26];
    const v95_1: US3 = patternInput_1[25];
    const v94_1: US3 = patternInput_1[24];
    const v93_1: US3 = patternInput_1[23];
    const v92_1: US3 = patternInput_1[22];
    const v91_1: US3 = patternInput_1[21];
    const v90_1: US7 = patternInput_1[20];
    const v89_1: US10 = patternInput_1[19];
    const v88_1: US3 = patternInput_1[18];
    const v87_1: US3 = patternInput_1[17];
    const v86_1: US3 = patternInput_1[16];
    const v85_1: US9 = patternInput_1[15];
    const v84_1: US7 = patternInput_1[14];
    const v83_1: US3 = patternInput_1[13];
    const v82_1: US3 = patternInput_1[12];
    const v81_1: US8 = patternInput_1[11];
    const v80_1: US7 = patternInput_1[10];
    const v79_1: US3 = patternInput_1[9];
    const v78_1: US3 = patternInput_1[8];
    const v77_1: US3 = patternInput_1[7];
    const v76_1: US3 = patternInput_1[6];
    const v75_1: US3 = patternInput_1[5];
    const v74_1: US3 = patternInput_1[4];
    const v73_1: US6 = patternInput_1[3];
    const v72_1: US3 = patternInput_1[2];
    const v71_1: US3 = patternInput_1[1];
    const v70_1: US3 = patternInput_1[0];
    const v137: US3 = patternInput_1[67];
    const v136: US2 = patternInput_1[66];
    const v135: US3 = patternInput_1[65];
    const v134: US9 = patternInput_1[64];
    const v133: US9 = patternInput_1[63];
    const v132: US3 = patternInput_1[62];
    const v131: US3 = patternInput_1[61];
    const v130: US11 = patternInput_1[60];
    const v129: US3 = patternInput_1[59];
    const v128: US3 = patternInput_1[58];
    const v127: US3 = patternInput_1[57];
    const v126: US3 = patternInput_1[56];
    const v125: US3 = patternInput_1[55];
    const v124: US3 = patternInput_1[54];
    const v123: US3 = patternInput_1[53];
    const v122: US3 = patternInput_1[52];
    const v121: US3 = patternInput_1[51];
    const v120: US3 = patternInput_1[50];
    const v119: US3 = patternInput_1[49];
    const v118: US3 = patternInput_1[48];
    const v117: US3 = patternInput_1[47];
    const v116: US3 = patternInput_1[46];
    const v115: US3 = patternInput_1[45];
    const v114: US3 = patternInput_1[44];
    const v113: US3 = patternInput_1[43];
    const v112: US12 = patternInput_1[42];
    const v111: US13 = patternInput_1[41];
    const v110: US12 = patternInput_1[40];
    const v109: US3 = patternInput_1[39];
    const v108: US3 = patternInput_1[38];
    const v107: US3 = patternInput_1[37];
    const v106: US3 = patternInput_1[36];
    const v105: US3 = patternInput_1[35];
    const v104: US3 = patternInput_1[34];
    const v103: US3 = patternInput_1[33];
    const v102: US3 = patternInput_1[32];
    const v101_1: US11 = patternInput_1[31];
    const v100_1: US3 = patternInput_1[30];
    const patternInput_2: [() => boolean, (arg0: boolean) => void] = method22((v0_1.l3.tag === US15_Tag.US15_0) !== true);
    const v146: any = Tr;
    const v147: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure21(v70_1, v71_1, v72_1, v73_1, v74_1, v75_1, v76_1, v77_1, v78_1, v79_1, v80_1, v81_1, v82_1, v83_1, v84_1, v85_1, v86_1, v87_1, v88_1, v89_1, v90_1, v91_1, v92_1, v93_1, v94_1, v95_1, v96_1, v97_1, v98_1, v99_1, v100_1, v101_1, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, arg10$0040);
    const v148: () => any[] = (): any[] => closure22(v0_1, v70_1, v71_1, v72_1, v73_1, v74_1, v75_1, v76_1, v77_1, v78_1, v79_1, v80_1, v81_1, v82_1, v83_1, v84_1, v85_1, v86_1, v87_1, v88_1, v89_1, v90_1, v91_1, v92_1, v93_1, v94_1, v95_1, v96_1, v97_1, v98_1, v99_1, v100_1, v101_1, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114, v115, v116, v117, v118, v119, v120, v121, v122, v123, v124, v125, v126, v127, v128, v129, v130, v131, v132, v133, v134, v135, v136, v137, patternInput_2[1], patternInput_2[0], void 0);
    return method15(v146, v147, v148);
}

export function closure20(unitVar: void, v0_1: Mut4): any {
    return method21(v0_1);
}

export function closure86(v0_1: Mut3, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v69: US3 = v0_1.l37;
    const v70_1: US3 = v0_1.l52;
    const v71_1: US9 = v0_1.l63;
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], v69, _arg[38], _arg[39], v0_1.l40, _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], v70_1, _arg[53], _arg[54], US3_US3_1("xs"), _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], v71_1, _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure89(v0_1: any, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], US9_US9_1(v0_1), _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure90(v0_1: any, unitVar: void): any[] {
    return [<>
        {toString_1(v0_1)}
    </>];
}

export function closure88(unitVar: void, v0_1: any): any[] {
    const v3: any = SimpleOption;
    const v4: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure89(v0_1, arg10$0040);
    const v5: () => any[] = (): any[] => closure90(v0_1, void 0);
    return [method15(v3, v4, v5)];
}

export function closure91(v0_1: any[], _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], US10_US10_1(v0_1), _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function method35(v0_1: any[], v1_1: (arg0: any) => any[]): any {
    const v4: any = For;
    const v6: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure91(v0_1, arg10$0040);
    return method15(v4, v6, v1_1);
}

export function closure87(v0_1: Mut3, unitVar: void): any[] {
    const v1_1: US10 = v0_1.l19;
    const v5: (arg0: any) => any[] = (v: any): any[] => closure88(void 0, v);
    return [method35((v1_1.tag === US10_Tag.US10_1) ? v1_1.fields[0] : [], v5)];
}

export function method34(v0_1: Mut3): any {
    const v3: any = SimpleSelect;
    const v4: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure86(v0_1, arg10$0040);
    const v5: () => any[] = (): any[] => closure87(v0_1, void 0);
    return method15(v3, v4, v5);
}

export function closure85(unitVar: void, v0_1: Mut3): any {
    return method34(v0_1);
}

export function closure95(v0_1: any, v1_1: Mut1): void {
    const v2: string = toString_1(v0_1);
    let v15: US5;
    if ("Debug" === v2) {
        v15 = US5_US5_0();
    }
    else if ("Info" === v2) {
        v15 = US5_US5_2();
    }
    else if ("Warn" === v2) {
        v15 = US5_US5_3();
    }
    else {
        const v9: boolean = "Error" === v2;
        v15 = US5_US5_1();
    }
    v1_1.l9 = v15;
}

export function closure94(v0_1: any, v1_1: Mut1): (arg0: Mut1) => void {
    return (v: Mut1): void => {
        closure95(v0_1, v);
    };
}

export function closure93(v0_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void, v1_1: any): void {
    const v2: (arg0: Mut1, arg1: Mut1) => void = (v: Mut1): (arg0: Mut1) => void => closure94(v1_1, v);
    v0_1(v2);
}

export function closure92(v0_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void, v1_1: Mut1, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v74_1: US5[] = [US5_US5_0(), US5_US5_2(), US5_US5_3(), US5_US5_1()];
    const v75_1: int32 = v74_1.length | 0;
    const v76_1: string[] = fill(new Array(v75_1), 0, v75_1, "");
    const v77_1: Mut7 = new Mut7(0);
    while (method29(v75_1, v77_1)) {
        const v79_1: int32 = v77_1.l0 | 0;
        const v80_1: US5 = v74_1[v79_1];
        const v85_1: string = (v80_1.tag === US5_Tag.US5_1) ? "Error" : ((v80_1.tag === US5_Tag.US5_2) ? "Info" : ((v80_1.tag === US5_Tag.US5_3) ? "Warn" : "Debug"));
        v76_1[v79_1] = v85_1;
        const v86_1: int32 = (v79_1 + 1) | 0;
        v77_1.l0 = (v86_1 | 0);
    }
    const v87_1: int32 = v76_1.length | 0;
    const v88_1: any[] = fill(new Array(v87_1), 0, v87_1, null);
    const v89_1: Mut7 = new Mut7(0);
    while (method29(v87_1, v89_1)) {
        const v91_1: int32 = v89_1.l0 | 0;
        const v92_1: string = v76_1[v91_1];
        v88_1[v91_1] = v92_1;
        const v94_1: int32 = (v91_1 + 1) | 0;
        v89_1.l0 = (v94_1 | 0);
    }
    const v95_1: US5 = v1_1.l9;
    const v106: (arg0: any) => void = (v: any): void => {
        closure93(v0_1, v);
    };
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], US10_US10_1(v88_1), _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], US3_US3_1("2px"), _arg[38], _arg[39], US12_US12_1(v106), _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], US9_US9_1((v95_1.tag === US5_Tag.US5_1) ? "Error" : ((v95_1.tag === US5_Tag.US5_2) ? "Info" : ((v95_1.tag === US5_Tag.US5_3) ? "Warn" : "Debug"))), _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure96(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure84(v0_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void, v1_1: Mut1, unitVar: void): any[] {
    const v2: (arg0: Mut3) => any = (v: Mut3): any => closure85(void 0, v);
    const v3: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure92(v0_1, v1_1, arg10$0040);
    const v4: () => any[] = (): any[] => closure96(void 0, void 0);
    return [method30(v2, v3, v4)];
}

export function closure83(v0_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void, v1_1: Mut1, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v72_1: () => any[] = (): any[] => closure84(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v72_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        Log Level
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function method36(v0_1: (arg0: Mut4) => any, v1_1: US14, v2: US14, v3: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3], v4: US15): any {
    const v5: Mut4 = new Mut4(v1_1, v2, v3, v4);
    const v8: any = createComponent;
    return v8(v0_1, v5);
}

export function closure99(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], US3_US3_1("8px"), _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure100(v0_1: Mut1, unitVar: void): any[] {
    return [<>
        {JSON.stringify(v0_1, null, 2)}
    </>];
}

export function closure98(v0_1: Mut1, unitVar: void): any[] {
    const v3: any = hope;
    const v5: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure99(void 0, arg10$0040);
    const v6: () => any[] = (): any[] => closure100(v0_1, void 0);
    return [method15(v3.pre, v5, v6)];
}

export function closure97(v0_1: Mut1, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v71_1: () => any[] = (): any[] => closure98(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v71_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        State
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure82(v0_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void, v1_1: Mut1, unitVar: void): any[] {
    const v2: (arg0: Mut4) => any = (v: Mut4): any => closure20(void 0, v);
    const v5: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure83(v0_1, v1_1, arg10$0040);
    const v10: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_1: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure97(v1_1, arg10$0040_1);
    return [method36(v2, US14_US14_0(), US14_US14_0(), v5, US15_US15_2()), method36(v2, US14_US14_0(), US14_US14_0(), v10, US15_US15_2())];
}

export function closure81(v0_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void, v1_1: Mut1, unitVar: void): any[] {
    const v2: (arg0: Mut3) => any = (v: Mut3): any => closure13(void 0, v);
    const v3: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040);
    const v4: () => any[] = (): any[] => closure82(v0_1, v1_1, void 0);
    return [method30(v2, v3, v4)];
}

export function closure80(v0_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void, v1_1: Mut1, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v72_1: () => any[] = (): any[] => closure81(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v72_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        Debug
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure19(v0_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void, v1_1: Mut1, unitVar: void): any[] {
    const v2: (arg0: Mut4) => any = (v: Mut4): any => closure20(void 0, v);
    const v5: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure80(v0_1, v1_1, arg10$0040);
    return [method36(v2, US14_US14_0(), US14_US14_0(), v5, US15_US15_0())];
}

export function closure12(v0_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void, v1_1: Mut1, unitVar: void): any[] {
    const v2: (arg0: Mut3) => any = (v: Mut3): any => closure13(void 0, v);
    const v3: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040);
    const v4: () => any[] = (): any[] => closure19(v0_1, v1_1, void 0);
    return [method30(v2, v3, v4)];
}

export function method13(): any {
    const patternInput: [Mut1, (arg0: (arg0: Mut1, arg1: Mut1) => void) => void] = method8();
    const v0_1: Mut1 = patternInput[0];
    const v4: any = Box;
    const v5: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure11(v0_1, arg10$0040);
    const v6: () => any[] = (): any[] => closure12(patternInput[1], v0_1, void 0);
    return method15(v4, v5, v6);
}

export function closure10(unitVar: void, v0_1: Mut2): any {
    return method13();
}

export function method37(v0_1: (arg0: Mut2) => any): any {
    const v1_1: Mut2 = Mut2_$ctor();
    const v4: any = createComponent;
    return v4(v0_1, v1_1);
}

export function closure101(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], US3_US3_1("flex"), _arg[19], _arg[20], US3_US3_1("1"), US3_US3_1("column"), _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], US3_US3_1("hidden"), US3_US3_1("auto"), _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure111(v0_1: Mut3, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const patternInput: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = [v0_1.l0, v0_1.l1, v0_1.l2, v0_1.l3, v0_1.l4, v0_1.l5, v0_1.l6, v0_1.l7, v0_1.l8, v0_1.l9, v0_1.l10, v0_1.l11, v0_1.l12, v0_1.l13, v0_1.l14, v0_1.l15, v0_1.l16, v0_1.l17, v0_1.l18, v0_1.l19, v0_1.l20, v0_1.l21, v0_1.l22, v0_1.l23, v0_1.l24, v0_1.l25, v0_1.l26, v0_1.l27, v0_1.l28, v0_1.l29, v0_1.l30, v0_1.l31, v0_1.l32, v0_1.l33, v0_1.l34, v0_1.l35, v0_1.l36, v0_1.l37, v0_1.l38, v0_1.l39, v0_1.l40, v0_1.l41, v0_1.l42, v0_1.l43, v0_1.l44, v0_1.l45, v0_1.l46, v0_1.l47, v0_1.l48, v0_1.l49, v0_1.l50, v0_1.l51, v0_1.l52, v0_1.l53, v0_1.l54, v0_1.l55, v0_1.l56, v0_1.l57, v0_1.l58, v0_1.l59, v0_1.l60, v0_1.l61, v0_1.l62, v0_1.l63, v0_1.l64, v0_1.l65, v0_1.l66, v0_1.l67];
    const v139: Mut3 = new Mut3(_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], US7_US7_1(true), _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]);
    method28(v139, new Mut3(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62], patternInput[63], patternInput[64], patternInput[65], patternInput[66], patternInput[67]));
    const patternInput_1: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = [v139.l0, v139.l1, v139.l2, v139.l3, v139.l4, v139.l5, v139.l6, v139.l7, v139.l8, v139.l9, v139.l10, v139.l11, v139.l12, v139.l13, v139.l14, v139.l15, v139.l16, v139.l17, v139.l18, v139.l19, v139.l20, v139.l21, v139.l22, v139.l23, v139.l24, v139.l25, v139.l26, v139.l27, v139.l28, v139.l29, v139.l30, v139.l31, v139.l32, v139.l33, v139.l34, v139.l35, v139.l36, v139.l37, v139.l38, v139.l39, v139.l40, v139.l41, v139.l42, v139.l43, v139.l44, v139.l45, v139.l46, v139.l47, v139.l48, v139.l49, v139.l50, v139.l51, v139.l52, v139.l53, v139.l54, v139.l55, v139.l56, v139.l57, v139.l58, v139.l59, v139.l60, v139.l61, v139.l62, v139.l63, v139.l64, v139.l65, v139.l66, v139.l67];
    return [patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], patternInput_1[11], patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], patternInput_1[63], patternInput_1[64], patternInput_1[65], patternInput_1[66], patternInput_1[67]];
}

export function closure112(v0_1: Mut3, unitVar: void): any[] {
    const v1_1: US3 = v0_1.l26;
    return [<>
        {(v1_1.tag === US3_Tag.US3_1) ? v1_1.fields[0] : ""}
    </>];
}

export function closure113(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], US3_US3_0(), _arg[36], US3_US3_1("-13px"), _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure114(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularLinkExternal;
    return v2;
}

export function method40(v0_1: (arg0: Mut8) => any, v1_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3], v2: () => any, v3: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): any {
    const v4: Mut8 = new Mut8(v1_1, v2, v3);
    const v7: any = createComponent;
    return v7(v0_1, v4);
}

export function closure110(v0_1: Mut3, unitVar: void): any[] {
    const v3: any = Anchor;
    const v4: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure111(v0_1, arg10$0040);
    const v5: () => any[] = (): any[] => closure112(v0_1, void 0);
    const v9: (arg0: Mut8) => any = (v: Mut8): any => closure62(void 0, v);
    const v10: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_2: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure113(void 0, arg10$0040_2);
    const v11: () => any = (): any => closure114(void 0, void 0);
    const v12: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_4: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040_4);
    return [method15(v3, v4, v5), <>
        &nbsp;
    </>, method40(v9, v10, v11, v12)];
}

export function method39(v0_1: Mut3): any {
    const v3: any = Box;
    const v4: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040);
    const v5: () => any[] = (): any[] => closure110(v0_1, void 0);
    return method15(v3, v4, v5);
}

export function closure109(unitVar: void, v0_1: Mut3): any {
    return method39(v0_1);
}

export function closure115(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], US3_US3_1("https://github.com/fc1943s/tictactoe_spiral"), _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure116(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure108(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut3) => any = (v: Mut3): any => closure109(void 0, v);
    const v1_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure115(void 0, arg10$0040);
    const v2: () => any[] = (): any[] => closure116(void 0, void 0);
    return [method30(v0_1, v1_1, v2)];
}

export function closure107(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v68: () => any[] = (): any[] => closure108(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v68), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US3_US3_1("1px 6px"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure119(v0_1: string, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], US3_US3_1(v0_1), _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure118(v0_1: string, unitVar: void): any[] {
    const v1_1: (arg0: Mut3) => any = (v: Mut3): any => closure109(void 0, v);
    const v2: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure119(v0_1, arg10$0040);
    const v3: () => any[] = (): any[] => closure116(void 0, void 0);
    return [method30(v1_1, v2, v3)];
}

export function closure117(v0_1: string, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v69: () => any[] = (): any[] => closure118(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v69), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US3_US3_1("1px 6px"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure122(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], US3_US3_1("https://fc1943s.github.io/tictactoe_spiral"), _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure121(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut3) => any = (v: Mut3): any => closure109(void 0, v);
    const v1_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure122(void 0, arg10$0040);
    const v2: () => any[] = (): any[] => closure116(void 0, void 0);
    return [method30(v0_1, v1_1, v2)];
}

export function closure120(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v68: () => any[] = (): any[] => closure121(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v68), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US3_US3_1("1px 6px"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure125(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], US3_US3_1("https://fc1943s.github.io/tictactoe_spiral/docs"), _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure124(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut3) => any = (v: Mut3): any => closure109(void 0, v);
    const v1_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure125(void 0, arg10$0040);
    const v2: () => any[] = (): any[] => closure116(void 0, void 0);
    return [method30(v0_1, v1_1, v2)];
}

export function closure123(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v68: () => any[] = (): any[] => closure124(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v68), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US3_US3_1("1px 6px"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure106(v0_1: string, unitVar: void): any[] {
    let v2: (arg0: Mut4) => any, v5: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3], v9: (arg0: Mut4) => any, v12: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3];
    const v16: (arg0: Mut4) => any = (v_2: Mut4): any => closure20(void 0, v_2);
    const v19: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_2: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure120(void 0, arg10$0040_2);
    const v24: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_3: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure123(void 0, arg10$0040_3);
    return [("" === v0_1) ? ((v2 = ((v: Mut4): any => closure20(void 0, v)), (v5 = ((arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure107(void 0, arg10$0040)), method36(v2, US14_US14_0(), US14_US14_0(), v5, US15_US15_2())))) : ((v9 = ((v_1: Mut4): any => closure20(void 0, v_1)), (v12 = ((arg10$0040_1: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure117(`https://github.com/fc1943s/tictactoe_spiral/tree/${v0_1}`, arg10$0040_1)), method36(v9, US14_US14_0(), US14_US14_0(), v12, US15_US15_2())))), method36(v16, US14_US14_0(), US14_US14_0(), v19, US15_US15_2()), method36(v16, US14_US14_0(), US14_US14_0(), v24, US15_US15_2())];
}

export function method38(): any {
    const patternInput: [string, any, string, string, boolean] = method1();
    const v5: (arg0: Mut3) => any = (v: Mut3): any => closure13(void 0, v);
    const v6: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040);
    const v7: () => any[] = (): any[] => closure106(patternInput[3], void 0);
    return method30(v5, v6, v7);
}

export function closure105(unitVar: void, v0_1: Mut3): any {
    return method38();
}

export function closure126(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure104(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut3) => any = (v: Mut3): any => closure105(void 0, v);
    const v1_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040);
    const v2: () => any[] = (): any[] => closure126(void 0, void 0);
    return [method30(v0_1, v1_1, v2)];
}

export function closure103(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v70_1: () => any[] = (): any[] => closure104(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v70_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        Links
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function method42(): [() => string, () => void] {
    const v2: any = useColorMode;
    const v3: any = v2();
    return [v3.colorMode, v3.toggleColorMode];
}

export function closure134(v0_1: () => void, v1_1: any): void {
    v0_1();
}

export function closure133(v0_1: () => void, v1_1: () => string, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v72_1: (arg0: any) => void = (v: any): void => {
        closure134(v0_1, v);
    };
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], US3_US3_1(v1_1()), _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], US12_US12_1(v72_1), _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure136(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], US3_US3_1("row"), _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US3_US3_1("$4"), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure138(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], US3_US3_1("neutral"), _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], US3_US3_1("sm"), _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], US9_US9_1("dark"), _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure139(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Dark
    </>];
}

export function closure140(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], US3_US3_1("neutral"), _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], US3_US3_1("sm"), _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], US9_US9_1("light"), _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure141(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Light
    </>];
}

export function closure137(unitVar: void, unitVar_1: void): any[] {
    const v2: any = Radio;
    const v3: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure138(void 0, arg10$0040);
    const v4: () => any[] = (): any[] => closure139(void 0, void 0);
    const v6: any = Radio;
    const v7: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_2: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure140(void 0, arg10$0040_2);
    const v8: () => any[] = (): any[] => closure141(void 0, void 0);
    return [method15(v2, v3, v4), method15(v6, v7, v8)];
}

export function closure135(unitVar: void, unitVar_1: void): any[] {
    const v2: any = Stack;
    const v3: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure136(void 0, arg10$0040);
    const v4: () => any[] = (): any[] => closure137(void 0, void 0);
    return [method15(v2, v3, v4)];
}

export function closure132(v0_1: () => void, v1_1: () => string, unitVar: void): any[] {
    const v4: any = RadioGroup;
    const v5: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure133(v0_1, v1_1, arg10$0040);
    const v6: () => any[] = (): any[] => closure135(void 0, void 0);
    return [method15(v4, v5, v6)];
}

export function closure131(v0_1: () => void, v1_1: () => string, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v72_1: () => any[] = (): any[] => closure132(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v72_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US3_US3_1("5px 6px"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        Theme
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure130(v0_1: () => void, v1_1: () => string, unitVar: void): any[] {
    const v2: (arg0: Mut4) => any = (v: Mut4): any => closure20(void 0, v);
    const v5: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure131(v0_1, v1_1, arg10$0040);
    return [method36(v2, US14_US14_0(), US14_US14_0(), v5, US15_US15_2())];
}

export function method41(): any {
    const patternInput: [() => string, () => void] = method42();
    const v2: (arg0: Mut3) => any = (v: Mut3): any => closure13(void 0, v);
    const v3: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040);
    const v4: () => any[] = (): any[] => closure130(patternInput[1], patternInput[0], void 0);
    return method30(v2, v3, v4);
}

export function closure129(unitVar: void, v0_1: Mut3): any {
    return method41();
}

export function closure142(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure128(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut3) => any = (v: Mut3): any => closure129(void 0, v);
    const v1_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040);
    const v2: () => any[] = (): any[] => closure142(void 0, void 0);
    return [method30(v0_1, v1_1, v2)];
}

export function closure127(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v70_1: () => any[] = (): any[] => closure128(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v70_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        Settings
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure157(v0_1: Mut9, v1_1: string, v2: Mut1, v3: Mut1): void {
    v0_1.l1(v2, v3, US3_US3_1(v1_1));
}

export function closure156(v0_1: Mut9, v1_1: string, v2: Mut1): (arg0: Mut1) => void {
    return (v: Mut1): void => {
        closure157(v0_1, v1_1, v2, v);
    };
}

export function closure155(v0_1: Mut9, v1_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void, v2: any): void {
    const v3: string = v2.currentTarget.value;
    const v4: (arg0: Mut1, arg1: Mut1) => void = (v: Mut1): (arg0: Mut1) => void => closure156(v0_1, v3, v);
    v1_1(v4);
}

export function closure154(v0_1: Mut9, v1_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void, v2: Mut1, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v72_1: US3 = v0_1.l0(v2);
    const v73_1: string = void 0;
    const v77_1: (arg0: any) => void = (v: any): void => {
        closure155(v0_1, v1_1, v);
    };
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], US12_US12_1(v77_1), _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], US3_US3_1("xs"), _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US3_US3_1("text"), US9_US9_1((v72_1.tag === US3_Tag.US3_1) ? v72_1.fields[0] : v73_1), _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure158(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function method45(v0_1: Mut9): any {
    const patternInput: [Mut1, (arg0: (arg0: Mut1, arg1: Mut1) => void) => void] = method8();
    const v5: any = Input;
    const v6: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure154(v0_1, patternInput[1], patternInput[0], arg10$0040);
    const v7: () => any[] = (): any[] => closure158(void 0, void 0);
    return method15(v5, v6, v7);
}

export function closure153(unitVar: void, v0_1: Mut9): any {
    return method45(v0_1);
}

export function closure159(unitVar: void, v0_1: Mut1): US3 {
    return v0_1.l2;
}

export function closure162(v0_1: Mut1, v1_1: US3): void {
    v0_1.l2 = v1_1;
}

export function closure161(unitVar: void, v0_1: Mut1): (arg0: US3) => void {
    return (v: US3): void => {
        closure162(v0_1, v);
    };
}

export function closure160(unitVar: void, v0_1: Mut1): (arg0: Mut1, arg1: US3) => void {
    return (v: Mut1): (arg0: US3) => void => closure161(void 0, v);
}

export function method46(v0_1: (arg0: Mut9) => any, v1_1: (arg0: Mut1) => US3, v2: (arg0: Mut1, arg1: Mut1, arg2: US3) => void): any {
    const v3: Mut9 = new Mut9(v1_1, v2);
    const v6: any = createComponent;
    return v6(v0_1, v3);
}

export function closure152(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut9) => any = (v: Mut9): any => closure153(void 0, v);
    const v1_1: (arg0: Mut1) => US3 = (v_1: Mut1): US3 => closure159(void 0, v_1);
    const v2: (arg0: Mut1, arg1: Mut1, arg2: US3) => void = (v_2: Mut1): (arg0: Mut1, arg1: US3) => void => closure160(void 0, v_2);
    return [method46(v0_1, v1_1, uncurry(3, v2))];
}

export function closure151(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v70_1: () => any[] = (): any[] => closure152(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v70_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US3_US3_1("3px"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        Token
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure165(unitVar: void, v0_1: Mut1): US3 {
    return v0_1.l3;
}

export function closure168(v0_1: Mut1, v1_1: US3): void {
    v0_1.l3 = v1_1;
}

export function closure167(unitVar: void, v0_1: Mut1): (arg0: US3) => void {
    return (v: US3): void => {
        closure168(v0_1, v);
    };
}

export function closure166(unitVar: void, v0_1: Mut1): (arg0: Mut1, arg1: US3) => void {
    return (v: Mut1): (arg0: US3) => void => closure167(void 0, v);
}

export function closure164(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut9) => any = (v: Mut9): any => closure153(void 0, v);
    const v1_1: (arg0: Mut1) => US3 = (v_1: Mut1): US3 => closure165(void 0, v_1);
    const v2: (arg0: Mut1, arg1: Mut1, arg2: US3) => void = (v_2: Mut1): (arg0: Mut1, arg1: US3) => void => closure166(void 0, v_2);
    return [method46(v0_1, v1_1, uncurry(3, v2))];
}

export function closure163(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v70_1: () => any[] = (): any[] => closure164(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v70_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US3_US3_1("3px"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        URL
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure175(v0_1: Mut10, v1_1: int32, v2: Mut1, v3: Mut1): void {
    v0_1.l1(v2, v3, US2_US2_1(v1_1));
}

export function closure174(v0_1: Mut10, v1_1: int32, v2: Mut1): (arg0: Mut1) => void {
    return (v: Mut1): void => {
        closure175(v0_1, v1_1, v2, v);
    };
}

export function closure173(v0_1: Mut10, v1_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void, v2: any): void {
    const v3: int32 = v2.currentTarget.value | 0;
    const v4: (arg0: Mut1, arg1: Mut1) => void = (v: Mut1): (arg0: Mut1) => void => closure174(v0_1, v3, v);
    v1_1(v4);
}

export function closure172(v0_1: Mut10, v1_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void, v2: Mut1, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v72_1: US2 = v0_1.l0(v2);
    const v73_1: int32 = (void 0) | 0;
    const v77_1: (arg0: any) => void = (v: any): void => {
        closure173(v0_1, v1_1, v);
    };
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], US12_US12_1(v77_1), _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], US3_US3_1("xs"), _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], US3_US3_1("text"), US9_US9_1((v72_1.tag === US2_Tag.US2_1) ? v72_1.fields[0] : v73_1), _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function method47(v0_1: Mut10): any {
    const patternInput: [Mut1, (arg0: (arg0: Mut1, arg1: Mut1) => void) => void] = method8();
    const v5: any = Input;
    const v6: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure172(v0_1, patternInput[1], patternInput[0], arg10$0040);
    const v7: () => any[] = (): any[] => closure158(void 0, void 0);
    return method15(v5, v6, v7);
}

export function closure171(unitVar: void, v0_1: Mut10): any {
    return method47(v0_1);
}

export function closure176(unitVar: void, v0_1: Mut1): US2 {
    return v0_1.l1;
}

export function closure179(v0_1: Mut1, v1_1: US2): void {
    v0_1.l1 = v1_1;
}

export function closure178(unitVar: void, v0_1: Mut1): (arg0: US2) => void {
    return (v: US2): void => {
        closure179(v0_1, v);
    };
}

export function closure177(unitVar: void, v0_1: Mut1): (arg0: Mut1, arg1: US2) => void {
    return (v: Mut1): (arg0: US2) => void => closure178(void 0, v);
}

export function method48(v0_1: (arg0: Mut10) => any, v1_1: (arg0: Mut1) => US2, v2: (arg0: Mut1, arg1: Mut1, arg2: US2) => void): any {
    const v3: Mut10 = new Mut10(v1_1, v2);
    const v6: any = createComponent;
    return v6(v0_1, v3);
}

export function closure170(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut10) => any = (v: Mut10): any => closure171(void 0, v);
    const v1_1: (arg0: Mut1) => US2 = (v_1: Mut1): US2 => closure176(void 0, v_1);
    const v2: (arg0: Mut1, arg1: Mut1, arg2: US2) => void = (v_2: Mut1): (arg0: Mut1, arg1: US2) => void => closure177(void 0, v_2);
    return [method48(v0_1, v1_1, uncurry(3, v2))];
}

export function closure169(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v70_1: () => any[] = (): any[] => closure170(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v70_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US3_US3_1("3px"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        Port
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure150(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut4) => any = (v: Mut4): any => closure20(void 0, v);
    const v3: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure151(void 0, arg10$0040);
    const v8: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_1: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure163(void 0, arg10$0040_1);
    const v13: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_2: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure169(void 0, arg10$0040_2);
    return [method36(v0_1, US14_US14_0(), US14_US14_0(), v3, US15_US15_2()), method36(v0_1, US14_US14_0(), US14_US14_0(), v8, US15_US15_2()), method36(v0_1, US14_US14_0(), US14_US14_0(), v13, US15_US15_2())];
}

export function method44(): any {
    const v0_1: (arg0: Mut3) => any = (v: Mut3): any => closure13(void 0, v);
    const v1_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040);
    const v2: () => any[] = (): any[] => closure150(void 0, void 0);
    return method30(v0_1, v1_1, v2);
}

export function closure149(unitVar: void, v0_1: Mut3): any {
    return method44();
}

export function closure180(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure148(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut3) => any = (v: Mut3): any => closure149(void 0, v);
    const v1_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040);
    const v2: () => any[] = (): any[] => closure180(void 0, void 0);
    return [method30(v0_1, v1_1, v2)];
}

export function closure147(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v70_1: () => any[] = (): any[] => closure148(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v70_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        Connection
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure191(v0_1: US0, v1_1: string, v2: string, v3: string, v4: Mut1): US3 {
    return US3_US3_1(v1_1);
}

export function closure194(v0_1: US0, v1_1: string, v2: string, v3: string, v4: Mut1, v5: Mut1, v6: US3): void {
    let copyOfStruct: US0, copyOfStruct_1: US0;
    const v7: [US0, string, string, string][] = v4.l0;
    const v11: int32 = v7.length | 0;
    const v12: [US0, string, string, string][] = fill(new Array(v11), 0, v11, null);
    const v13: Mut7 = new Mut7(0);
    while (method29(v11, v13)) {
        const v15: int32 = v13.l0 | 0;
        const patternInput_1: [US0, string, string, string] = v7[v15];
        const v19: string = patternInput_1[3];
        const v18: string = patternInput_1[2];
        const v16: US0 = patternInput_1[0];
        const patternInput_2: [US0, string, string, string] = ((copyOfStruct = v16, (copyOfStruct.tag === US0_Tag.US0_1) ? ((copyOfStruct_1 = v0_1, (copyOfStruct_1.tag === US0_Tag.US0_1) && ((copyOfStruct.fields[0].tag === US1_Tag.US1_1) ? (copyOfStruct_1.fields[0].tag === US1_Tag.US1_1) : (copyOfStruct_1.fields[0].tag === US1_Tag.US1_0)))) : (v0_1.tag === US0_Tag.US0_0))) ? [v16, (v6.tag === US3_Tag.US3_1) ? v6.fields[0] : "", v18, v19] : [v16, patternInput_1[1], v18, v19];
        v12[v15] = [patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3]];
        const v31: int32 = (v15 + 1) | 0;
        v13.l0 = (v31 | 0);
    }
    v5.l0 = v12;
}

export function closure193(v0_1: US0, v1_1: string, v2: string, v3: string, v4: Mut1, v5: Mut1): (arg0: US3) => void {
    return (v: US3): void => {
        closure194(v0_1, v1_1, v2, v3, v4, v5, v);
    };
}

export function closure192(v0_1: US0, v1_1: string, v2: string, v3: string, v4: Mut1): (arg0: Mut1, arg1: US3) => void {
    return (v: Mut1): (arg0: US3) => void => closure193(v0_1, v1_1, v2, v3, v4, v);
}

export function closure190(v0_1: US0, v1_1: string, v2: string, v3: string, unitVar: void): any[] {
    const v4: (arg0: Mut9) => any = (v: Mut9): any => closure153(void 0, v);
    const v5: (arg0: Mut1) => US3 = (v_1: Mut1): US3 => closure191(v0_1, v1_1, v2, v3, v_1);
    const v6: (arg0: Mut1, arg1: Mut1, arg2: US3) => void = (v_2: Mut1): (arg0: Mut1, arg1: US3) => void => closure192(v0_1, v1_1, v2, v3, v_2);
    return [method46(v4, v5, uncurry(3, v6))];
}

export function closure189(v0_1: US0, v1_1: string, v2: string, v3: string, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v74_1: () => any[] = (): any[] => closure190(v0_1, v1_1, v2, v3, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v74_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US3_US3_1("3px"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        Address
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure197(v0_1: US0, v1_1: string, v2: string, v3: string, v4: Mut1): US3 {
    return US3_US3_1(v3);
}

export function closure200(v0_1: US0, v1_1: string, v2: string, v3: string, v4: Mut1, v5: Mut1, v6: US3): void {
    let copyOfStruct: US0, copyOfStruct_1: US0;
    const v7: [US0, string, string, string][] = v4.l0;
    const v11: int32 = v7.length | 0;
    const v12: [US0, string, string, string][] = fill(new Array(v11), 0, v11, null);
    const v13: Mut7 = new Mut7(0);
    while (method29(v11, v13)) {
        const v15: int32 = v13.l0 | 0;
        const patternInput_1: [US0, string, string, string] = v7[v15];
        const v18: string = patternInput_1[2];
        const v17: string = patternInput_1[1];
        const v16: US0 = patternInput_1[0];
        const patternInput_2: [US0, string, string, string] = ((copyOfStruct = v16, (copyOfStruct.tag === US0_Tag.US0_1) ? ((copyOfStruct_1 = v0_1, (copyOfStruct_1.tag === US0_Tag.US0_1) && ((copyOfStruct.fields[0].tag === US1_Tag.US1_1) ? (copyOfStruct_1.fields[0].tag === US1_Tag.US1_1) : (copyOfStruct_1.fields[0].tag === US1_Tag.US1_0)))) : (v0_1.tag === US0_Tag.US0_0))) ? [v16, v17, v18, (v6.tag === US3_Tag.US3_1) ? v6.fields[0] : ""] : [v16, v17, v18, patternInput_1[3]];
        v12[v15] = [patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3]];
        const v31: int32 = (v15 + 1) | 0;
        v13.l0 = (v31 | 0);
    }
    v5.l0 = v12;
}

export function closure199(v0_1: US0, v1_1: string, v2: string, v3: string, v4: Mut1, v5: Mut1): (arg0: US3) => void {
    return (v: US3): void => {
        closure200(v0_1, v1_1, v2, v3, v4, v5, v);
    };
}

export function closure198(v0_1: US0, v1_1: string, v2: string, v3: string, v4: Mut1): (arg0: Mut1, arg1: US3) => void {
    return (v: Mut1): (arg0: US3) => void => closure199(v0_1, v1_1, v2, v3, v4, v);
}

export function closure196(v0_1: US0, v1_1: string, v2: string, v3: string, unitVar: void): any[] {
    const v4: (arg0: Mut9) => any = (v: Mut9): any => closure153(void 0, v);
    const v5: (arg0: Mut1) => US3 = (v_1: Mut1): US3 => closure197(v0_1, v1_1, v2, v3, v_1);
    const v6: (arg0: Mut1, arg1: Mut1, arg2: US3) => void = (v_2: Mut1): (arg0: Mut1, arg1: US3) => void => closure198(v0_1, v1_1, v2, v3, v_2);
    return [method46(v4, v5, uncurry(3, v6))];
}

export function closure195(v0_1: US0, v1_1: string, v2: string, v3: string, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v74_1: () => any[] = (): any[] => closure196(v0_1, v1_1, v2, v3, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v74_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US3_US3_1("3px"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        Private Key
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure188(v0_1: US0, v1_1: string, v2: string, v3: string, unitVar: void): any[] {
    const v4: (arg0: Mut4) => any = (v: Mut4): any => closure20(void 0, v);
    const v7: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure189(v0_1, v1_1, v2, v3, arg10$0040);
    const v12: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_1: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure195(v0_1, v1_1, v2, v3, arg10$0040_1);
    return [method36(v4, US14_US14_0(), US14_US14_0(), v7, US15_US15_2()), method36(v4, US14_US14_0(), US14_US14_0(), v12, US15_US15_2())];
}

export function closure187(v0_1: US0, v1_1: string, v2: string, v3: string, unitVar: void): any[] {
    const v4: (arg0: Mut3) => any = (v: Mut3): any => closure13(void 0, v);
    const v5: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040);
    const v6: () => any[] = (): any[] => closure188(v0_1, v1_1, v2, v3, void 0);
    return [method30(v4, v5, v6)];
}

export function closure186(v0_1: US0, v1_1: string, v2: string, v3: string, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v79_1: () => any[] = (): any[] => closure187(v0_1, v1_1, v2, v3, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v79_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        {(v0_1.tag === US0_Tag.US0_1) ? ((v0_1.fields[0].tag === US1_Tag.US1_1) ? "x" : "o") : "admin"}
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure185(unitVar: void, _arg: [US0, string, string, string]): any[] {
    const v4: (arg0: Mut4) => any = (v: Mut4): any => closure20(void 0, v);
    const v7: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure186(_arg[0], _arg[1], _arg[2], _arg[3], arg10$0040);
    return [method36(v4, US14_US14_0(), US14_US14_0(), v7, US15_US15_2())];
}

export function closure201(v0_1: [US0, string, string, string][], _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], US10_US10_1(v0_1), _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function method50(v0_1: [US0, string, string, string][], v1_1: (arg0: [US0, string, string, string]) => any[]): any {
    const v4: any = For;
    const v6: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure201(v0_1, arg10$0040);
    return method15(v4, v6, v1_1);
}

export function closure184(v0_1: Mut1, unitVar: void): any[] {
    const v5: (arg0: [US0, string, string, string]) => any[] = (arg10$0040: [US0, string, string, string]): any[] => closure185(void 0, arg10$0040);
    return [method50(v0_1.l0, v5)];
}

export function method49(): any {
    const patternInput: [Mut1, (arg0: (arg0: Mut1, arg1: Mut1) => void) => void] = method8();
    const v2: (arg0: Mut3) => any = (v: Mut3): any => closure13(void 0, v);
    const v3: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040);
    const v4: () => any[] = (): any[] => closure184(patternInput[0], void 0);
    return method30(v2, v3, v4);
}

export function closure183(unitVar: void, v0_1: Mut3): any {
    return method49();
}

export function closure202(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure182(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut3) => any = (v: Mut3): any => closure183(void 0, v);
    const v1_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040);
    const v2: () => any[] = (): any[] => closure202(void 0, void 0);
    return [method30(v0_1, v1_1, v2)];
}

export function closure181(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v70_1: () => any[] = (): any[] => closure182(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v70_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        Accounts
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure205(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], US3_US3_1("#aaa"), _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], US3_US3_1("1"), _arg[22], _arg[23], _arg[24], US3_US3_1("350px"), _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], US3_US3_1("https://bank.testnet.algorand.network"), _arg[58], _arg[59], US11_US11_1(<>
        algorand testnet bank
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure206(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure204(unitVar: void, unitVar_1: void): any[] {
    const v2: any = hope;
    const v4: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure205(void 0, arg10$0040);
    const v5: () => any[] = (): any[] => closure206(void 0, void 0);
    return [method15(v2.iframe, v4, v5)];
}

export function closure203(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v70_1: () => any[] = (): any[] => closure204(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v70_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        Testnet Bank Dispenser
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure146(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut4) => any = (v: Mut4): any => closure20(void 0, v);
    const v3: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure147(void 0, arg10$0040);
    const v8: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_1: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure181(void 0, arg10$0040_1);
    const v13: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_2: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure203(void 0, arg10$0040_2);
    return [method36(v0_1, US14_US14_0(), US14_US14_0(), v3, US15_US15_2()), method36(v0_1, US14_US14_0(), US14_US14_0(), v8, US15_US15_2()), method36(v0_1, US14_US14_0(), US14_US14_0(), v13, US15_US15_0())];
}

export function method43(): any {
    const v0_1: (arg0: Mut3) => any = (v: Mut3): any => closure13(void 0, v);
    const v1_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040);
    const v2: () => any[] = (): any[] => closure146(void 0, void 0);
    return method30(v0_1, v1_1, v2);
}

export function closure145(unitVar: void, v0_1: Mut3): any {
    return method43();
}

export function closure207(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure144(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut3) => any = (v: Mut3): any => closure145(void 0, v);
    const v1_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040);
    const v2: () => any[] = (): any[] => closure207(void 0, void 0);
    return [method30(v0_1, v1_1, v2)];
}

export function closure143(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v70_1: () => any[] = (): any[] => closure144(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v70_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US3_US3_1("db"), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        Chain
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure215(v0_1: Mut1, v1_1: Mut1): void {
    const v3: [US4, US4][] = v0_1.l5;
    const v6: [US4, US4][] = [[US4_US4_1(), US4_US4_1()]];
    const v7: int32 = v3.length | 0;
    const v9: int32 = (v7 + v6.length) | 0;
    const v10: [US4, US4][] = fill(new Array(v9), 0, v9, null);
    const v11: Mut7 = new Mut7(0);
    while (method29(v9, v11)) {
        const v13: int32 = v11.l0 | 0;
        let patternInput_3: [US4, US4];
        if (v13 < v7) {
            const patternInput_1: [US4, US4] = v3[v13];
            patternInput_3 = [patternInput_1[0], patternInput_1[1]];
        }
        else {
            const v17: int32 = (v13 - v7) | 0;
            const patternInput_2: [US4, US4] = v6[v17];
            patternInput_3 = [patternInput_2[0], patternInput_2[1]];
        }
        v10[v13] = [patternInput_3[0], patternInput_3[1]];
        const v22: int32 = (v13 + 1) | 0;
        v11.l0 = (v22 | 0);
    }
    v1_1.l5 = v10;
}

export function closure214(unitVar: void, v0_1: Mut1): (arg0: Mut1) => void {
    return (v: Mut1): void => {
        closure215(v0_1, v);
    };
}

export function closure213(unitVar: void, v0_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void): void {
    const v1_1: (arg0: Mut1, arg1: Mut1) => void = (v: Mut1): (arg0: Mut1) => void => closure214(void 0, v);
    v0_1(v1_1);
}

export function closure212(unitVar: void, v0_1: Mut1): (arg0: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void {
    return (v: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void): void => {
        closure213(void 0, v);
    };
}

export function method52(v0_1: int32, v1_1: Mut11): boolean {
    return v1_1.l0 < v0_1;
}

export function closure219(v0_1: Mut1, v1_1: Mut1): void {
    const v3: [US4, US4][] = v0_1.l5;
    const v4: int32 = v3.length | 0;
    const v5: [US4, US4][] = fill(new Array(v4), 0, v4, null);
    const v6: Mut11 = new Mut11(0, 0);
    while (method52(v4, v6)) {
        const v8: int32 = v6.l0 | 0;
        const v9: int32 = v6.l1 | 0;
        const patternInput_1: [US4, US4] = v3[v8];
        const v11: US4 = patternInput_1[1];
        const v10: US4 = patternInput_1[0];
        let v19: int32;
        if (((v10.tag === US4_Tag.US4_1) && (v11.tag === US4_Tag.US4_1)) !== true) {
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
    const v22: [US4, US4][] = fill(new Array(v21), 0, v21, null);
    const v23: Mut7 = new Mut7(0);
    while (method29(v21, v23)) {
        const v25: int32 = v23.l0 | 0;
        const patternInput_2: [US4, US4] = v5[v25];
        v22[v25] = [patternInput_2[0], patternInput_2[1]];
        const v28: int32 = (v25 + 1) | 0;
        v23.l0 = (v28 | 0);
    }
    v1_1.l5 = v22;
}

export function closure218(unitVar: void, v0_1: Mut1): (arg0: Mut1) => void {
    return (v: Mut1): void => {
        closure219(v0_1, v);
    };
}

export function closure217(unitVar: void, v0_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void): void {
    const v1_1: (arg0: Mut1, arg1: Mut1) => void = (v: Mut1): (arg0: Mut1) => void => closure218(void 0, v);
    v0_1(v1_1);
}

export function closure216(unitVar: void, v0_1: Mut1): (arg0: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void {
    return (v: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void): void => {
        closure217(void 0, v);
    };
}

export function method55(v0_1: int32, v1_1: Mut14): boolean {
    return v1_1.l0 < v0_1;
}

export function closure227(v0_1: Mut13, v1_1: Mut1): US3 {
    const v2: [US4, int32, string, string][] = v1_1.l4;
    const v4: int32 = v2.length | 0;
    const v6: Mut14 = new Mut14(0, US3_US3_0());
    while (method55(v4, v6)) {
        const v8: int32 = v6.l0 | 0;
        const v11: int32 = ((op_UnaryNegation_Int32(v8) + v4) - 1) | 0;
        const v12: US3 = v6.l1;
        const patternInput_1: [US4, int32, string, string] = v2[v11];
        const v13: US4 = patternInput_1[0];
        let v24: US3;
        if (v12.tag === US3_Tag.US3_1) {
            v24 = v12;
        }
        else {
            const v17: US4 = v0_1.l0;
            v24 = (((v13.tag === US4_Tag.US4_1) ? (v17.tag === US4_Tag.US4_1) : (v17.tag === US4_Tag.US4_0)) ? v0_1.l1([v13, patternInput_1[1], patternInput_1[2], patternInput_1[3]]) : US3_US3_0());
        }
        const v25: int32 = (v8 + 1) | 0;
        v6.l0 = (v25 | 0);
        v6.l1 = v24;
    }
    return v6.l1;
}

export function closure230(v0_1: Mut13, v1_1: Mut1, v2: Mut1, v3: US3): void {
    const v4: [US4, int32, string, string][] = v1_1.l4;
    const v6: int32 = v4.length | 0;
    const v7: [US4, int32, string, string][] = fill(new Array(v6), 0, v6, null);
    const v8: Mut7 = new Mut7(0);
    while (method29(v6, v8)) {
        const v10: int32 = v8.l0 | 0;
        const patternInput_1: [US4, int32, string, string] = v4[v10];
        const v14: string = patternInput_1[3];
        const v13: string = patternInput_1[2];
        const v12: int32 = patternInput_1[1] | 0;
        const v11: US4 = patternInput_1[0];
        const v15: US4 = v0_1.l0;
        let patternInput_3: [US4, int32, string, string];
        if ((v11.tag === US4_Tag.US4_1) ? (v15.tag === US4_Tag.US4_1) : (v15.tag === US4_Tag.US4_0)) {
            const patternInput_2: [US4, int32, string, string] = v0_1.l2([v11, v12, v13, v14], v3);
            patternInput_3 = [patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3]];
        }
        else {
            patternInput_3 = [v11, v12, v13, v14];
        }
        v7[v10] = [patternInput_3[0], patternInput_3[1], patternInput_3[2], patternInput_3[3]];
        const v27: int32 = (v10 + 1) | 0;
        v8.l0 = (v27 | 0);
    }
    v2.l4 = v7;
}

export function closure229(v0_1: Mut13, v1_1: Mut1, v2: Mut1): (arg0: US3) => void {
    return (v: US3): void => {
        closure230(v0_1, v1_1, v2, v);
    };
}

export function closure228(v0_1: Mut13, v1_1: Mut1): (arg0: Mut1, arg1: US3) => void {
    return (v: Mut1): (arg0: US3) => void => closure229(v0_1, v1_1, v);
}

export function method54(v0_1: Mut13): any {
    const v1_1: (arg0: Mut9) => any = (v: Mut9): any => closure153(void 0, v);
    const v2: (arg0: Mut1) => US3 = (v_1: Mut1): US3 => closure227(v0_1, v_1);
    const v3: (arg0: Mut1, arg1: Mut1, arg2: US3) => void = (v_2: Mut1): (arg0: Mut1, arg1: US3) => void => closure228(v0_1, v_2);
    return method46(v1_1, v2, uncurry(3, v3));
}

export function closure226(unitVar: void, v0_1: Mut13): any {
    return method54(v0_1);
}

export function closure231(unitVar: void, _arg: [US4, int32, string, string]): US3 {
    return US3_US3_1(_arg[2]);
}

export function closure233(v0_1: Mut12, v1_1: US4, v2: int32, v3: string, v4: string, v5: US3): [US4, int32, string, string] {
    return [v0_1.l0, v2, (v5.tag === US3_Tag.US3_1) ? v5.fields[0] : "", v4];
}

export function closure232(v0_1: Mut12, _arg: [US4, int32, string, string]): (arg0: US3) => [US4, int32, string, string] {
    return (v: US3): [US4, int32, string, string] => closure233(v0_1, _arg[0], _arg[1], _arg[2], _arg[3], v);
}

export function method56(v0_1: (arg0: Mut13) => any, v1_1: US4, v2: (arg0: [US4, int32, string, string]) => US3, v3: (arg0: [US4, int32, string, string], arg1: US3) => [US4, int32, string, string]): any {
    const v4: Mut13 = new Mut13(v1_1, v2, v3);
    const v7: any = createComponent;
    return v7(v0_1, v4);
}

export function closure225(v0_1: Mut12, unitVar: void): any[] {
    const v2: (arg0: Mut13) => any = (v: Mut13): any => closure226(void 0, v);
    const v3: (arg0: [US4, int32, string, string]) => US3 = (arg10$0040: [US4, int32, string, string]): US3 => closure231(void 0, arg10$0040);
    const v4: (arg0: [US4, int32, string, string], arg1: US3) => [US4, int32, string, string] = (arg10$0040_1: [US4, int32, string, string]): (arg0: US3) => [US4, int32, string, string] => closure232(v0_1, arg10$0040_1);
    return [method56(v2, v0_1.l0, v3, uncurry(2, v4))];
}

export function closure224(v0_1: Mut12, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v71_1: () => any[] = (): any[] => closure225(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v71_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US3_US3_1("3px"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        URL
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function method58(v0_1: int32, v1_1: Mut16): boolean {
    return v1_1.l0 < v0_1;
}

export function closure237(v0_1: Mut15, v1_1: Mut1): US2 {
    const v2: [US4, int32, string, string][] = v1_1.l4;
    const v4: int32 = v2.length | 0;
    const v6: Mut16 = new Mut16(0, US2_US2_0());
    while (method58(v4, v6)) {
        const v8: int32 = v6.l0 | 0;
        const v11: int32 = ((op_UnaryNegation_Int32(v8) + v4) - 1) | 0;
        const v12: US2 = v6.l1;
        const patternInput_1: [US4, int32, string, string] = v2[v11];
        const v13: US4 = patternInput_1[0];
        let v24: US2;
        if (v12.tag === US2_Tag.US2_1) {
            v24 = v12;
        }
        else {
            const v17: US4 = v0_1.l0;
            v24 = (((v13.tag === US4_Tag.US4_1) ? (v17.tag === US4_Tag.US4_1) : (v17.tag === US4_Tag.US4_0)) ? v0_1.l1([v13, patternInput_1[1], patternInput_1[2], patternInput_1[3]]) : US2_US2_0());
        }
        const v25: int32 = (v8 + 1) | 0;
        v6.l0 = (v25 | 0);
        v6.l1 = v24;
    }
    return v6.l1;
}

export function closure240(v0_1: Mut15, v1_1: Mut1, v2: Mut1, v3: US2): void {
    const v4: [US4, int32, string, string][] = v1_1.l4;
    const v6: int32 = v4.length | 0;
    const v7: [US4, int32, string, string][] = fill(new Array(v6), 0, v6, null);
    const v8: Mut7 = new Mut7(0);
    while (method29(v6, v8)) {
        const v10: int32 = v8.l0 | 0;
        const patternInput_1: [US4, int32, string, string] = v4[v10];
        const v14: string = patternInput_1[3];
        const v13: string = patternInput_1[2];
        const v12: int32 = patternInput_1[1] | 0;
        const v11: US4 = patternInput_1[0];
        const v15: US4 = v0_1.l0;
        let patternInput_3: [US4, int32, string, string];
        if ((v11.tag === US4_Tag.US4_1) ? (v15.tag === US4_Tag.US4_1) : (v15.tag === US4_Tag.US4_0)) {
            const patternInput_2: [US4, int32, string, string] = v0_1.l2([v11, v12, v13, v14], v3);
            patternInput_3 = [patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3]];
        }
        else {
            patternInput_3 = [v11, v12, v13, v14];
        }
        v7[v10] = [patternInput_3[0], patternInput_3[1], patternInput_3[2], patternInput_3[3]];
        const v27: int32 = (v10 + 1) | 0;
        v8.l0 = (v27 | 0);
    }
    v2.l4 = v7;
}

export function closure239(v0_1: Mut15, v1_1: Mut1, v2: Mut1): (arg0: US2) => void {
    return (v: US2): void => {
        closure240(v0_1, v1_1, v2, v);
    };
}

export function closure238(v0_1: Mut15, v1_1: Mut1): (arg0: Mut1, arg1: US2) => void {
    return (v: Mut1): (arg0: US2) => void => closure239(v0_1, v1_1, v);
}

export function method57(v0_1: Mut15): any {
    const v1_1: (arg0: Mut10) => any = (v: Mut10): any => closure171(void 0, v);
    const v2: (arg0: Mut1) => US2 = (v_1: Mut1): US2 => closure237(v0_1, v_1);
    const v3: (arg0: Mut1, arg1: Mut1, arg2: US2) => void = (v_2: Mut1): (arg0: Mut1, arg1: US2) => void => closure238(v0_1, v_2);
    return method48(v1_1, v2, uncurry(3, v3));
}

export function closure236(unitVar: void, v0_1: Mut15): any {
    return method57(v0_1);
}

export function closure241(unitVar: void, _arg: [US4, int32, string, string]): US2 {
    return US2_US2_1(_arg[1]);
}

export function closure243(v0_1: Mut12, v1_1: US4, v2: int32, v3: string, v4: string, v5: US2): [US4, int32, string, string] {
    return [v0_1.l0, (v5.tag === US2_Tag.US2_1) ? v5.fields[0] : 0, v3, v4];
}

export function closure242(v0_1: Mut12, _arg: [US4, int32, string, string]): (arg0: US2) => [US4, int32, string, string] {
    return (v: US2): [US4, int32, string, string] => closure243(v0_1, _arg[0], _arg[1], _arg[2], _arg[3], v);
}

export function method59(v0_1: (arg0: Mut15) => any, v1_1: US4, v2: (arg0: [US4, int32, string, string]) => US2, v3: (arg0: [US4, int32, string, string], arg1: US2) => [US4, int32, string, string]): any {
    const v4: Mut15 = new Mut15(v1_1, v2, v3);
    const v7: any = createComponent;
    return v7(v0_1, v4);
}

export function closure235(v0_1: Mut12, unitVar: void): any[] {
    const v2: (arg0: Mut15) => any = (v: Mut15): any => closure236(void 0, v);
    const v3: (arg0: [US4, int32, string, string]) => US2 = (arg10$0040: [US4, int32, string, string]): US2 => closure241(void 0, arg10$0040);
    const v4: (arg0: [US4, int32, string, string], arg1: US2) => [US4, int32, string, string] = (arg10$0040_1: [US4, int32, string, string]): (arg0: US2) => [US4, int32, string, string] => closure242(v0_1, arg10$0040_1);
    return [method59(v2, v0_1.l0, v3, uncurry(2, v4))];
}

export function closure234(v0_1: Mut12, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v71_1: () => any[] = (): any[] => closure235(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v71_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US3_US3_1("3px"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        Port
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure223(v0_1: Mut12, unitVar: void): any[] {
    const v1_1: (arg0: Mut4) => any = (v: Mut4): any => closure20(void 0, v);
    const v4: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure224(v0_1, arg10$0040);
    const v9: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_1: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure234(v0_1, arg10$0040_1);
    return [method36(v1_1, US14_US14_0(), US14_US14_0(), v4, US15_US15_2()), method36(v1_1, US14_US14_0(), US14_US14_0(), v9, US15_US15_2())];
}

export function method53(v0_1: Mut12): any {
    const v1_1: (arg0: Mut3) => any = (v: Mut3): any => closure13(void 0, v);
    const v2: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040);
    const v3: () => any[] = (): any[] => closure223(v0_1, void 0);
    return method30(v1_1, v2, v3);
}

export function closure222(unitVar: void, v0_1: Mut12): any {
    return method53(v0_1);
}

export function method60(v0_1: (arg0: Mut12) => any, v1_1: US4): any {
    const v2: Mut12 = new Mut12(v1_1);
    const v5: any = createComponent;
    return v5(v0_1, v2);
}

export function closure221(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut12) => any = (v: Mut12): any => closure222(void 0, v);
    return [method60(v0_1, US4_US4_1())];
}

export function closure220(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v70_1: () => any[] = (): any[] => closure221(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v70_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US3_US3_1("db-gun-rs-rs"), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        Rust -{'>'} Rust
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure247(v0_1: Mut1, v1_1: Mut1): void {
    const v3: [US4, US4][] = v0_1.l5;
    const v6: [US4, US4][] = [[US4_US4_1(), US4_US4_0()]];
    const v7: int32 = v3.length | 0;
    const v9: int32 = (v7 + v6.length) | 0;
    const v10: [US4, US4][] = fill(new Array(v9), 0, v9, null);
    const v11: Mut7 = new Mut7(0);
    while (method29(v9, v11)) {
        const v13: int32 = v11.l0 | 0;
        let patternInput_3: [US4, US4];
        if (v13 < v7) {
            const patternInput_1: [US4, US4] = v3[v13];
            patternInput_3 = [patternInput_1[0], patternInput_1[1]];
        }
        else {
            const v17: int32 = (v13 - v7) | 0;
            const patternInput_2: [US4, US4] = v6[v17];
            patternInput_3 = [patternInput_2[0], patternInput_2[1]];
        }
        v10[v13] = [patternInput_3[0], patternInput_3[1]];
        const v22: int32 = (v13 + 1) | 0;
        v11.l0 = (v22 | 0);
    }
    v1_1.l5 = v10;
}

export function closure246(unitVar: void, v0_1: Mut1): (arg0: Mut1) => void {
    return (v: Mut1): void => {
        closure247(v0_1, v);
    };
}

export function closure245(unitVar: void, v0_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void): void {
    const v1_1: (arg0: Mut1, arg1: Mut1) => void = (v: Mut1): (arg0: Mut1) => void => closure246(void 0, v);
    v0_1(v1_1);
}

export function closure244(unitVar: void, v0_1: Mut1): (arg0: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void {
    return (v: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void): void => {
        closure245(void 0, v);
    };
}

export function closure251(v0_1: Mut1, v1_1: Mut1): void {
    const v3: [US4, US4][] = v0_1.l5;
    const v4: int32 = v3.length | 0;
    const v5: [US4, US4][] = fill(new Array(v4), 0, v4, null);
    const v6: Mut11 = new Mut11(0, 0);
    while (method52(v4, v6)) {
        const v8: int32 = v6.l0 | 0;
        const v9: int32 = v6.l1 | 0;
        const patternInput_1: [US4, US4] = v3[v8];
        const v11: US4 = patternInput_1[1];
        const v10: US4 = patternInput_1[0];
        let v19: int32;
        if (((v10.tag === US4_Tag.US4_1) && (v11.tag === US4_Tag.US4_0)) !== true) {
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
    const v22: [US4, US4][] = fill(new Array(v21), 0, v21, null);
    const v23: Mut7 = new Mut7(0);
    while (method29(v21, v23)) {
        const v25: int32 = v23.l0 | 0;
        const patternInput_2: [US4, US4] = v5[v25];
        v22[v25] = [patternInput_2[0], patternInput_2[1]];
        const v28: int32 = (v25 + 1) | 0;
        v23.l0 = (v28 | 0);
    }
    v1_1.l5 = v22;
}

export function closure250(unitVar: void, v0_1: Mut1): (arg0: Mut1) => void {
    return (v: Mut1): void => {
        closure251(v0_1, v);
    };
}

export function closure249(unitVar: void, v0_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void): void {
    const v1_1: (arg0: Mut1, arg1: Mut1) => void = (v: Mut1): (arg0: Mut1) => void => closure250(void 0, v);
    v0_1(v1_1);
}

export function closure248(unitVar: void, v0_1: Mut1): (arg0: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void {
    return (v: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void): void => {
        closure249(void 0, v);
    };
}

export function closure253(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut12) => any = (v: Mut12): any => closure222(void 0, v);
    return [method60(v0_1, US4_US4_0())];
}

export function closure252(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v70_1: () => any[] = (): any[] => closure253(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v70_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US3_US3_1("db-gun-rs-js"), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        Rust -{'>'} JavaScript
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure257(v0_1: Mut1, v1_1: Mut1): void {
    const v3: [US4, US4][] = v0_1.l5;
    const v6: [US4, US4][] = [[US4_US4_0(), US4_US4_0()]];
    const v7: int32 = v3.length | 0;
    const v9: int32 = (v7 + v6.length) | 0;
    const v10: [US4, US4][] = fill(new Array(v9), 0, v9, null);
    const v11: Mut7 = new Mut7(0);
    while (method29(v9, v11)) {
        const v13: int32 = v11.l0 | 0;
        let patternInput_3: [US4, US4];
        if (v13 < v7) {
            const patternInput_1: [US4, US4] = v3[v13];
            patternInput_3 = [patternInput_1[0], patternInput_1[1]];
        }
        else {
            const v17: int32 = (v13 - v7) | 0;
            const patternInput_2: [US4, US4] = v6[v17];
            patternInput_3 = [patternInput_2[0], patternInput_2[1]];
        }
        v10[v13] = [patternInput_3[0], patternInput_3[1]];
        const v22: int32 = (v13 + 1) | 0;
        v11.l0 = (v22 | 0);
    }
    v1_1.l5 = v10;
}

export function closure256(unitVar: void, v0_1: Mut1): (arg0: Mut1) => void {
    return (v: Mut1): void => {
        closure257(v0_1, v);
    };
}

export function closure255(unitVar: void, v0_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void): void {
    const v1_1: (arg0: Mut1, arg1: Mut1) => void = (v: Mut1): (arg0: Mut1) => void => closure256(void 0, v);
    v0_1(v1_1);
}

export function closure254(unitVar: void, v0_1: Mut1): (arg0: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void {
    return (v: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void): void => {
        closure255(void 0, v);
    };
}

export function closure261(v0_1: Mut1, v1_1: Mut1): void {
    const v3: [US4, US4][] = v0_1.l5;
    const v4: int32 = v3.length | 0;
    const v5: [US4, US4][] = fill(new Array(v4), 0, v4, null);
    const v6: Mut11 = new Mut11(0, 0);
    while (method52(v4, v6)) {
        const v8: int32 = v6.l0 | 0;
        const v9: int32 = v6.l1 | 0;
        const patternInput_1: [US4, US4] = v3[v8];
        const v11: US4 = patternInput_1[1];
        const v10: US4 = patternInput_1[0];
        let v19: int32;
        if (((v10.tag === US4_Tag.US4_0) && (v11.tag === US4_Tag.US4_0)) !== true) {
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
    const v22: [US4, US4][] = fill(new Array(v21), 0, v21, null);
    const v23: Mut7 = new Mut7(0);
    while (method29(v21, v23)) {
        const v25: int32 = v23.l0 | 0;
        const patternInput_2: [US4, US4] = v5[v25];
        v22[v25] = [patternInput_2[0], patternInput_2[1]];
        const v28: int32 = (v25 + 1) | 0;
        v23.l0 = (v28 | 0);
    }
    v1_1.l5 = v22;
}

export function closure260(unitVar: void, v0_1: Mut1): (arg0: Mut1) => void {
    return (v: Mut1): void => {
        closure261(v0_1, v);
    };
}

export function closure259(unitVar: void, v0_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void): void {
    const v1_1: (arg0: Mut1, arg1: Mut1) => void = (v: Mut1): (arg0: Mut1) => void => closure260(void 0, v);
    v0_1(v1_1);
}

export function closure258(unitVar: void, v0_1: Mut1): (arg0: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void {
    return (v: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void): void => {
        closure259(void 0, v);
    };
}

export function closure262(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v70_1: () => any[] = (): any[] => closure253(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v70_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US3_US3_1("db-gun-js-js"), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        JavaScript -{'>'} JavaScript
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure266(v0_1: Mut1, v1_1: Mut1): void {
    const v3: [US4, US4][] = v0_1.l5;
    const v6: [US4, US4][] = [[US4_US4_0(), US4_US4_1()]];
    const v7: int32 = v3.length | 0;
    const v9: int32 = (v7 + v6.length) | 0;
    const v10: [US4, US4][] = fill(new Array(v9), 0, v9, null);
    const v11: Mut7 = new Mut7(0);
    while (method29(v9, v11)) {
        const v13: int32 = v11.l0 | 0;
        let patternInput_3: [US4, US4];
        if (v13 < v7) {
            const patternInput_1: [US4, US4] = v3[v13];
            patternInput_3 = [patternInput_1[0], patternInput_1[1]];
        }
        else {
            const v17: int32 = (v13 - v7) | 0;
            const patternInput_2: [US4, US4] = v6[v17];
            patternInput_3 = [patternInput_2[0], patternInput_2[1]];
        }
        v10[v13] = [patternInput_3[0], patternInput_3[1]];
        const v22: int32 = (v13 + 1) | 0;
        v11.l0 = (v22 | 0);
    }
    v1_1.l5 = v10;
}

export function closure265(unitVar: void, v0_1: Mut1): (arg0: Mut1) => void {
    return (v: Mut1): void => {
        closure266(v0_1, v);
    };
}

export function closure264(unitVar: void, v0_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void): void {
    const v1_1: (arg0: Mut1, arg1: Mut1) => void = (v: Mut1): (arg0: Mut1) => void => closure265(void 0, v);
    v0_1(v1_1);
}

export function closure263(unitVar: void, v0_1: Mut1): (arg0: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void {
    return (v: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void): void => {
        closure264(void 0, v);
    };
}

export function closure270(v0_1: Mut1, v1_1: Mut1): void {
    const v3: [US4, US4][] = v0_1.l5;
    const v4: int32 = v3.length | 0;
    const v5: [US4, US4][] = fill(new Array(v4), 0, v4, null);
    const v6: Mut11 = new Mut11(0, 0);
    while (method52(v4, v6)) {
        const v8: int32 = v6.l0 | 0;
        const v9: int32 = v6.l1 | 0;
        const patternInput_1: [US4, US4] = v3[v8];
        const v11: US4 = patternInput_1[1];
        const v10: US4 = patternInput_1[0];
        let v19: int32;
        if (((v10.tag === US4_Tag.US4_0) && (v11.tag === US4_Tag.US4_1)) !== true) {
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
    const v22: [US4, US4][] = fill(new Array(v21), 0, v21, null);
    const v23: Mut7 = new Mut7(0);
    while (method29(v21, v23)) {
        const v25: int32 = v23.l0 | 0;
        const patternInput_2: [US4, US4] = v5[v25];
        v22[v25] = [patternInput_2[0], patternInput_2[1]];
        const v28: int32 = (v25 + 1) | 0;
        v23.l0 = (v28 | 0);
    }
    v1_1.l5 = v22;
}

export function closure269(unitVar: void, v0_1: Mut1): (arg0: Mut1) => void {
    return (v: Mut1): void => {
        closure270(v0_1, v);
    };
}

export function closure268(unitVar: void, v0_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void): void {
    const v1_1: (arg0: Mut1, arg1: Mut1) => void = (v: Mut1): (arg0: Mut1) => void => closure269(void 0, v);
    v0_1(v1_1);
}

export function closure267(unitVar: void, v0_1: Mut1): (arg0: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void {
    return (v: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void): void => {
        closure268(void 0, v);
    };
}

export function closure271(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v70_1: () => any[] = (): any[] => closure221(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v70_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US3_US3_1("db-gun-js-rs"), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        JavaScript -{'>'} Rust
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure211(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut4) => any = (v: Mut4): any => closure20(void 0, v);
    const v1_1: (arg0: Mut1, arg1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void = (v_1: Mut1): (arg0: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void => closure212(void 0, v_1);
    const v3: (arg0: Mut1, arg1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void = (v_2: Mut1): (arg0: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void => closure216(void 0, v_2);
    const v5: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure220(void 0, arg10$0040);
    const v8: (arg0: Mut1, arg1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void = (v_3: Mut1): (arg0: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void => closure244(void 0, v_3);
    const v10: (arg0: Mut1, arg1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void = (v_4: Mut1): (arg0: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void => closure248(void 0, v_4);
    const v12: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_1: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure252(void 0, arg10$0040_1);
    const v15: (arg0: Mut1, arg1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void = (v_5: Mut1): (arg0: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void => closure254(void 0, v_5);
    const v17: (arg0: Mut1, arg1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void = (v_6: Mut1): (arg0: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void => closure258(void 0, v_6);
    const v19: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_2: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure262(void 0, arg10$0040_2);
    const v22: (arg0: Mut1, arg1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void = (v_7: Mut1): (arg0: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void => closure263(void 0, v_7);
    const v24: (arg0: Mut1, arg1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void = (v_8: Mut1): (arg0: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void => closure267(void 0, v_8);
    const v26: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_3: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure271(void 0, arg10$0040_3);
    return [method36(v0_1, US14_US14_1(uncurry(2, v1_1)), US14_US14_1(uncurry(2, v3)), v5, US15_US15_0()), method36(v0_1, US14_US14_1(uncurry(2, v8)), US14_US14_1(uncurry(2, v10)), v12, US15_US15_0()), method36(v0_1, US14_US14_1(uncurry(2, v15)), US14_US14_1(uncurry(2, v17)), v19, US15_US15_0()), method36(v0_1, US14_US14_1(uncurry(2, v22)), US14_US14_1(uncurry(2, v24)), v26, US15_US15_0())];
}

export function method51(): any {
    const v0_1: (arg0: Mut3) => any = (v: Mut3): any => closure13(void 0, v);
    const v1_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040);
    const v2: () => any[] = (): any[] => closure211(void 0, void 0);
    return method30(v0_1, v1_1, v2);
}

export function closure210(unitVar: void, v0_1: Mut3): any {
    return method51();
}

export function closure272(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure209(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut3) => any = (v: Mut3): any => closure210(void 0, v);
    const v1_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040);
    const v2: () => any[] = (): any[] => closure272(void 0, void 0);
    return [method30(v0_1, v1_1, v2)];
}

export function closure208(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v70_1: () => any[] = (): any[] => closure209(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v70_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US3_US3_1("db"), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        Database
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure279(v0_1: Mut1, v1_1: [int32, int32][]): void {
    v0_1.l8 = v1_1;
}

export function closure278(v0_1: Mut1, v1_1: Mut1): (arg0: [int32, int32][]) => void {
    return (v: [int32, int32][]): void => {
        closure279(v0_1, v);
    };
}

export function closure277(unitVar: void, v0_1: Mut1): (arg0: Mut1, arg1: [int32, int32][]) => void {
    return (v: Mut1): (arg0: [int32, int32][]) => void => closure278(v0_1, v);
}

export function closure280(v0_1: Mut1, v1_1: any): int32 {
    const v4: [int32, int32][] = v0_1.l8;
    const v5: int32 = v4.length | 0;
    const v6: Mut11 = new Mut11(0, 0);
    while (method52(v5, v6)) {
        const v8: int32 = v6.l0 | 0;
        const v9: int32 = v6.l1 | 0;
        const patternInput_1: [int32, int32] = v4[v8];
        const v12: int32 = (v9 + 1) | 0;
        const v13: int32 = (v8 + 1) | 0;
        v6.l0 = (v13 | 0);
        v6.l1 = (v12 | 0);
    }
    return v6.l1 | 0;
}

export function closure281(v0_1: Mut1, unitVar: void): boolean {
    if (v0_1.l9.tag === US5_Tag.US5_0) {
        return true;
    }
    else {
        return false;
    }
}

export function closure282(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure283(v0_1: string, v1_1: (arg0: any[]) => void, unitVar: void): void {
    v1_1([">> use_fetch request()", ["content_address:", v0_1]]);
}

export function closure284(v0_1: string, v1_1: (arg0: any[]) => void, unitVar: void): void {
    v1_1([">> use_fetch clear()", ["content_address:", v0_1]]);
}

export function method62(v0_1: string): [() => void, () => void] {
    const patternInput: [Mut1, (arg0: (arg0: Mut1, arg1: Mut1) => void) => void] = method8();
    const v3: uint8[] = Array.from(get_UTF8().getBytes(v0_1));
    const v4: int32 = v3.length | 0;
    const v5: Mut11 = new Mut11(0, 100000);
    while (method52(v4, v5)) {
        const v7: int32 = v5.l0 | 0;
        const v12: int32 = (v5.l1 + (v3[v7] * 12)) | 0;
        const v13: int32 = (v7 + 1) | 0;
        v5.l0 = (v13 | 0);
        v5.l1 = (v12 | 0);
    }
    const v17: () => boolean = (): boolean => closure281(patternInput[0], void 0);
    const v18: () => any[] = (): any[] => closure282(void 0, void 0);
    const v19: (arg0: any[]) => void = method9(v17, v18, `#${int32ToString(v5.l1)}`);
    v19(["> use_fetch ()"]);
    const v23: () => void = (): void => {
        closure283(v0_1, v19, void 0);
    };
    const v24: () => void = (): void => {
        closure284(v0_1, v19, void 0);
    };
    return [v23, v24];
}

export function closure286(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [US3_US3_1("start"), _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], US3_US3_1(method23("column", "row")), _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], US3_US3_1(method23("8px", "0")), _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US3_US3_1("3px"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US3_US3_1("7px"), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure288(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure289(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Counter
    </>];
}

export function closure291(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], US3_US3_0(), _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure292(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularPlus;
    return v2;
}

export function closure290(v0_1: () => void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v69: (arg0: Mut8) => any = (v: Mut8): any => closure62(void 0, v);
    const v70_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure291(void 0, arg10$0040);
    const v71_1: () => any = (): any => closure292(void 0, void 0);
    const v72_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_2: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040_2);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], US11_US11_1(method40(v69, v70_1, v71_1, v72_1)), _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], US13_US13_1(v0_1), _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], US3_US3_1("10px"), _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure293(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Request
    </>];
}

export function closure295(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], US3_US3_0(), _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure296(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularMinus;
    return v2;
}

export function closure294(v0_1: () => void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v69: (arg0: Mut8) => any = (v: Mut8): any => closure62(void 0, v);
    const v70_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure295(void 0, arg10$0040);
    const v71_1: () => any = (): any => closure296(void 0, void 0);
    const v72_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_2: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040_2);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], US11_US11_1(method40(v69, v70_1, v71_1, v72_1)), _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], US13_US13_1(v0_1), _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], US3_US3_1("10px"), _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure297(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Clear
    </>];
}

export function closure287(v0_1: () => void, v1_1: () => void, unitVar: void): any[] {
    const v4: any = Box;
    const v5: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure288(void 0, arg10$0040);
    const v6: () => any[] = (): any[] => closure289(void 0, void 0);
    const v8: (arg0: Mut3) => any = (v: Mut3): any => closure49(void 0, v);
    const v9: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_2: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure290(v1_1, arg10$0040_2);
    const v10: () => any[] = (): any[] => closure293(void 0, void 0);
    const v12: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_4: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure294(v0_1, arg10$0040_4);
    const v13: () => any[] = (): any[] => closure297(void 0, void 0);
    return [method15(v4, v5, v6), method30(v8, v9, v10), method30(v8, v12, v13)];
}

export function method63(v0_1: int32, v1_1: Mut17): boolean {
    return v1_1.l0 < v0_1;
}

export function method64(v0_1_mut: UH1, v1_1_mut: UH1): UH1 {
    method64:
    while (true) {
        const v0_1: UH1 = v0_1_mut, v1_1: UH1 = v1_1_mut;
        if (v0_1.tag === UH1_Tag.UH1_1) {
            return v1_1;
        }
        else {
            v0_1_mut = v0_1.fields[2];
            v1_1_mut = UH1_UH1_0(v0_1.fields[0], v0_1.fields[1], v1_1);
            continue method64;
        }
        break;
    }
}

export function method66(v0_1_mut: UH1, v1_1_mut: int32): int32 {
    method66:
    while (true) {
        const v0_1: UH1 = v0_1_mut, v1_1: int32 = v1_1_mut;
        if (v0_1.tag === UH1_Tag.UH1_1) {
            return v1_1 | 0;
        }
        else {
            v0_1_mut = v0_1.fields[2];
            v1_1_mut = (v1_1 + 1);
            continue method66;
        }
        break;
    }
}

export function method67(v0_1_mut: [int32, int32][], v1_1_mut: UH1, v2_mut: int32): int32 {
    method67:
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
            continue method67;
        }
        break;
    }
}

export function method65(v0_1: UH1): [int32, int32][] {
    const v2: int32 = method66(v0_1, 0) | 0;
    const v3: [int32, int32][] = fill(new Array(v2), 0, v2, null);
    const v5: int32 = method67(v3, v0_1, 0) | 0;
    return v3;
}

export function closure303(v0_1: () => [int32, int32], unitVar: void): any[] {
    const patternInput: [int32, int32] = v0_1();
    return [<>
        {JSON.stringify(patternInput[1], null, 2)}
    </>];
}

export function closure302(v0_1: () => [int32, int32], unitVar: void): any[] {
    const v3: any = hope;
    const v5: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040);
    const v6: () => any[] = (): any[] => closure303(v0_1, void 0);
    return [method15(v3.pre, v5, v6)];
}

export function closure301(v0_1: () => [int32, int32], _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v73_1: () => any[] = (): any[] => closure302(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US3_US3_1("3px"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        {int32ToString(v0_1()[0])}
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure300(unitVar: void, v0_1: () => [int32, int32]): any[] {
    const v1_1: (arg0: Mut4) => any = (v: Mut4): any => closure20(void 0, v);
    const v4: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure301(v0_1, arg10$0040);
    return [method36(v1_1, US14_US14_0(), US14_US14_0(), v4, US15_US15_2())];
}

export function closure304(v0_1: [int32, int32][], _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], US10_US10_1(v0_1), _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function method68(v0_1: [int32, int32][], v1_1: (arg0: () => [int32, int32]) => any[]): any {
    const v4: any = Index;
    const v6: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure304(v0_1, arg10$0040);
    return method15(v4, v6, v1_1);
}

export function closure299(v0_1: Mut1, unitVar: void): any[] {
    const v3: [int32, int32][] = v0_1.l8;
    const v4: int32 = v3.length | 0;
    const v6: Mut17 = new Mut17(0, UH1_UH1_1());
    while (method63(v4, v6)) {
        const v8: int32 = v6.l0 | 0;
        const v11: int32 = ((op_UnaryNegation_Int32(v8) + v4) - 1) | 0;
        const v12: UH1 = v6.l1;
        const patternInput_1: [int32, int32] = v3[v11];
        const v15: int32 = (v8 + 1) | 0;
        v6.l0 = (v15 | 0);
        v6.l1 = UH1_UH1_0(patternInput_1[0], patternInput_1[1], v12);
    }
    const v21: (arg0: () => [int32, int32]) => any[] = (v: () => [int32, int32]): any[] => closure300(void 0, v);
    return [method68(method65(method64(v6.l1, UH1_UH1_1())), v21)];
}

export function closure298(v0_1: Mut1, unitVar: void): any[] {
    const v1_1: (arg0: Mut3) => any = (v: Mut3): any => closure13(void 0, v);
    const v2: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040);
    const v3: () => any[] = (): any[] => closure299(v0_1, void 0);
    return [method30(v1_1, v2, v3)];
}

export function closure285(v0_1: Mut1, v1_1: () => void, v2: () => void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v73_1: any = Stack;
    const v74_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure286(void 0, arg10$0040);
    const v75_1: () => any[] = (): any[] => closure287(v1_1, v2, void 0);
    const v77_1: () => any[] = (): any[] => closure298(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v77_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US3_US3_1("counter"), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(method15(v73_1, v74_1, v75_1)), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function method61(): any {
    const v0_1: Mut1 = method8()[0];
    const patternInput_1: [[int32, any][], [int32, any][], [int32, int32][]] = [v0_1.l6, v0_1.l7, v0_1.l8];
    const v6: (arg0: Mut1, arg1: Mut1, arg2: [int32, int32][]) => void = (v: Mut1): (arg0: Mut1, arg1: [int32, int32][]) => void => closure277(void 0, v);
    const v7: (arg0: any) => int32 = (v_1: any): int32 => closure280(v0_1, v_1);
    const patternInput_2: [() => void, () => void] = method62("profile/tmp/counter");
    const v10: (arg0: Mut4) => any = (v_2: Mut4): any => closure20(void 0, v_2);
    const v13: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure285(v0_1, patternInput_2[1], patternInput_2[0], arg10$0040);
    return method36(v10, US14_US14_0(), US14_US14_0(), v13, US15_US15_2());
}

export function closure276(unitVar: void, v0_1: Mut3): any {
    return method61();
}

export function closure305(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure309(v0_1: Mut1, v1_1: [int32, any][]): void {
    v0_1.l7 = v1_1;
}

export function closure308(v0_1: Mut1, v1_1: Mut1): (arg0: [int32, any][]) => void {
    return (v: [int32, any][]): void => {
        closure309(v0_1, v);
    };
}

export function closure307(unitVar: void, v0_1: Mut1): (arg0: Mut1, arg1: [int32, any][]) => void {
    return (v: Mut1): (arg0: [int32, any][]) => void => closure308(v0_1, v);
}

export function closure310(unitVar: void, v0_1: any): any {
    return "status";
}

export function closure312(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [US3_US3_1("start"), _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], US3_US3_1(method23("column", "row")), _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], US3_US3_1(method23("8px", "0")), _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US3_US3_1("3px"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US3_US3_1("7px"), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure314(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Chain Status
    </>];
}

export function closure316(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], US3_US3_0(), _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure315(v0_1: () => void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v69: (arg0: Mut8) => any = (v: Mut8): any => closure62(void 0, v);
    const v70_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure316(void 0, arg10$0040);
    const v71_1: () => any = (): any => closure292(void 0, void 0);
    const v72_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_2: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040_2);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], US11_US11_1(method40(v69, v70_1, v71_1, v72_1)), _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], US13_US13_1(v0_1), _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], US3_US3_1("10px"), _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure317(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Request
    </>];
}

export function closure319(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], US3_US3_0(), _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure318(v0_1: () => void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v69: (arg0: Mut8) => any = (v: Mut8): any => closure62(void 0, v);
    const v70_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure319(void 0, arg10$0040);
    const v71_1: () => any = (): any => closure296(void 0, void 0);
    const v72_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_2: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040_2);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], US11_US11_1(method40(v69, v70_1, v71_1, v72_1)), _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], US13_US13_1(v0_1), _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], US3_US3_1("10px"), _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure320(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Clear
    </>];
}

export function closure313(v0_1: () => void, v1_1: () => void, unitVar: void): any[] {
    const v4: any = Box;
    const v5: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040);
    const v6: () => any[] = (): any[] => closure314(void 0, void 0);
    const v8: (arg0: Mut3) => any = (v: Mut3): any => closure49(void 0, v);
    const v9: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_2: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure315(v1_1, arg10$0040_2);
    const v10: () => any[] = (): any[] => closure317(void 0, void 0);
    const v12: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_4: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure318(v0_1, arg10$0040_4);
    const v13: () => any[] = (): any[] => closure320(void 0, void 0);
    return [method15(v4, v5, v6), method30(v8, v9, v10), method30(v8, v12, v13)];
}

export function method70(v0_1: int32, v1_1: Mut18): boolean {
    return v1_1.l0 < v0_1;
}

export function method71(v0_1_mut: UH2, v1_1_mut: UH2): UH2 {
    method71:
    while (true) {
        const v0_1: UH2 = v0_1_mut, v1_1: UH2 = v1_1_mut;
        if (v0_1.tag === UH2_Tag.UH2_1) {
            return v1_1;
        }
        else {
            v0_1_mut = v0_1.fields[2];
            v1_1_mut = UH2_UH2_0(v0_1.fields[0], v0_1.fields[1], v1_1);
            continue method71;
        }
        break;
    }
}

export function method73(v0_1_mut: UH2, v1_1_mut: int32): int32 {
    method73:
    while (true) {
        const v0_1: UH2 = v0_1_mut, v1_1: int32 = v1_1_mut;
        if (v0_1.tag === UH2_Tag.UH2_1) {
            return v1_1 | 0;
        }
        else {
            v0_1_mut = v0_1.fields[2];
            v1_1_mut = (v1_1 + 1);
            continue method73;
        }
        break;
    }
}

export function method74(v0_1_mut: [int32, any][], v1_1_mut: UH2, v2_mut: int32): int32 {
    method74:
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
            continue method74;
        }
        break;
    }
}

export function method72(v0_1: UH2): [int32, any][] {
    const v2: int32 = method73(v0_1, 0) | 0;
    const v3: [int32, any][] = fill(new Array(v2), 0, v2, null);
    const v5: int32 = method74(v3, v0_1, 0) | 0;
    return v3;
}

export function closure326(v0_1: () => [int32, any], unitVar: void): any[] {
    const patternInput: [int32, any] = v0_1();
    return [<>
        {JSON.stringify(patternInput[1], null, 2)}
    </>];
}

export function closure325(v0_1: () => [int32, any], unitVar: void): any[] {
    const v3: any = hope;
    const v5: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040);
    const v6: () => any[] = (): any[] => closure326(v0_1, void 0);
    return [method15(v3.pre, v5, v6)];
}

export function closure324(v0_1: () => [int32, any], _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v73_1: () => any[] = (): any[] => closure325(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US3_US3_1("3px"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        {int32ToString(v0_1()[0])}
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure323(unitVar: void, v0_1: () => [int32, any]): any[] {
    const v1_1: (arg0: Mut4) => any = (v: Mut4): any => closure20(void 0, v);
    const v4: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure324(v0_1, arg10$0040);
    return [method36(v1_1, US14_US14_0(), US14_US14_0(), v4, US15_US15_2())];
}

export function closure327(v0_1: [int32, any][], _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], US10_US10_1(v0_1), _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function method75(v0_1: [int32, any][], v1_1: (arg0: () => [int32, any]) => any[]): any {
    const v4: any = Index;
    const v6: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure327(v0_1, arg10$0040);
    return method15(v4, v6, v1_1);
}

export function closure322(v0_1: Mut1, unitVar: void): any[] {
    const v2: [int32, any][] = v0_1.l7;
    const v4: int32 = v2.length | 0;
    const v6: Mut18 = new Mut18(0, UH2_UH2_1());
    while (method70(v4, v6)) {
        const v8: int32 = v6.l0 | 0;
        const v11: int32 = ((op_UnaryNegation_Int32(v8) + v4) - 1) | 0;
        const v12: UH2 = v6.l1;
        const patternInput_1: [int32, any] = v2[v11];
        const v15: int32 = (v8 + 1) | 0;
        v6.l0 = (v15 | 0);
        v6.l1 = UH2_UH2_0(patternInput_1[0], patternInput_1[1], v12);
    }
    const v21: (arg0: () => [int32, any]) => any[] = (v: () => [int32, any]): any[] => closure323(void 0, v);
    return [method75(method72(method71(v6.l1, UH2_UH2_1())), v21)];
}

export function closure321(v0_1: Mut1, unitVar: void): any[] {
    const v1_1: (arg0: Mut3) => any = (v: Mut3): any => closure13(void 0, v);
    const v2: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040);
    const v3: () => any[] = (): any[] => closure322(v0_1, void 0);
    return [method30(v1_1, v2, v3)];
}

export function closure311(v0_1: Mut1, v1_1: () => void, v2: () => void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v73_1: any = Stack;
    const v74_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure312(void 0, arg10$0040);
    const v75_1: () => any[] = (): any[] => closure313(v1_1, v2, void 0);
    const v77_1: () => any[] = (): any[] => closure321(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v77_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US3_US3_1("status"), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(method15(v73_1, v74_1, v75_1)), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function method69(): any {
    const v0_1: Mut1 = method8()[0];
    const patternInput_1: [[int32, any][], [int32, any][], [int32, int32][]] = [v0_1.l6, v0_1.l7, v0_1.l8];
    const v6: (arg0: Mut1, arg1: Mut1, arg2: [int32, any][]) => void = (v: Mut1): (arg0: Mut1, arg1: [int32, any][]) => void => closure307(void 0, v);
    const v7: (arg0: any) => any = (v_1: any): any => closure310(void 0, v_1);
    const patternInput_2: [() => void, () => void] = method62("profile/tmp/chain_status");
    const v10: (arg0: Mut4) => any = (v_2: Mut4): any => closure20(void 0, v_2);
    const v13: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure311(v0_1, patternInput_2[1], patternInput_2[0], arg10$0040);
    return method36(v10, US14_US14_0(), US14_US14_0(), v13, US15_US15_2());
}

export function closure306(unitVar: void, v0_1: Mut3): any {
    return method69();
}

export function closure328(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure332(v0_1: Mut1, v1_1: [int32, any][]): void {
    v0_1.l6 = v1_1;
}

export function closure331(v0_1: Mut1, v1_1: Mut1): (arg0: [int32, any][]) => void {
    return (v: [int32, any][]): void => {
        closure332(v0_1, v);
    };
}

export function closure330(unitVar: void, v0_1: Mut1): (arg0: Mut1, arg1: [int32, any][]) => void {
    return (v: Mut1): (arg0: [int32, any][]) => void => closure331(v0_1, v);
}

export function closure333(unitVar: void, v0_1: any): any {
    return void 0;
}

export function closure335(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [US3_US3_1("start"), _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], US3_US3_1(method23("column", "row")), _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], US3_US3_1(method23("8px", "0")), _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US3_US3_1("3px"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US3_US3_1("7px"), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure337(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Chain Deploy
    </>];
}

export function closure339(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], US3_US3_0(), _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure338(v0_1: () => void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v69: (arg0: Mut8) => any = (v: Mut8): any => closure62(void 0, v);
    const v70_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure339(void 0, arg10$0040);
    const v71_1: () => any = (): any => closure292(void 0, void 0);
    const v72_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_2: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040_2);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], US11_US11_1(method40(v69, v70_1, v71_1, v72_1)), _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], US13_US13_1(v0_1), _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], US3_US3_1("10px"), _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure340(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Request
    </>];
}

export function closure342(unitVar: void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], US3_US3_0(), _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure341(v0_1: () => void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v69: (arg0: Mut8) => any = (v: Mut8): any => closure62(void 0, v);
    const v70_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure342(void 0, arg10$0040);
    const v71_1: () => any = (): any => closure296(void 0, void 0);
    const v72_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_2: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040_2);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], US11_US11_1(method40(v69, v70_1, v71_1, v72_1)), _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], US13_US13_1(v0_1), _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], US3_US3_1("10px"), _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure343(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Clear
    </>];
}

export function closure336(v0_1: () => void, v1_1: () => void, unitVar: void): any[] {
    const v4: any = Box;
    const v5: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040);
    const v6: () => any[] = (): any[] => closure337(void 0, void 0);
    const v8: (arg0: Mut3) => any = (v: Mut3): any => closure49(void 0, v);
    const v9: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_2: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure338(v1_1, arg10$0040_2);
    const v10: () => any[] = (): any[] => closure340(void 0, void 0);
    const v12: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_4: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure341(v0_1, arg10$0040_4);
    const v13: () => any[] = (): any[] => closure343(void 0, void 0);
    return [method15(v4, v5, v6), method30(v8, v9, v10), method30(v8, v12, v13)];
}

export function closure349(v0_1: () => [int32, any], unitVar: void): any[] {
    const patternInput: [int32, any] = v0_1();
    return [<>
        {JSON.stringify(patternInput[1], null, 2)}
    </>];
}

export function closure348(v0_1: () => [int32, any], unitVar: void): any[] {
    const v3: any = hope;
    const v5: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040);
    const v6: () => any[] = (): any[] => closure349(v0_1, void 0);
    return [method15(v3.pre, v5, v6)];
}

export function closure347(v0_1: () => [int32, any], _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v73_1: () => any[] = (): any[] => closure348(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v73_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], US3_US3_1("3px"), _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        {int32ToString(v0_1()[0])}
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure346(unitVar: void, v0_1: () => [int32, any]): any[] {
    const v1_1: (arg0: Mut4) => any = (v: Mut4): any => closure20(void 0, v);
    const v4: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure347(v0_1, arg10$0040);
    return [method36(v1_1, US14_US14_0(), US14_US14_0(), v4, US15_US15_2())];
}

export function closure345(v0_1: Mut1, unitVar: void): any[] {
    const v1_1: [int32, any][] = v0_1.l6;
    const v4: int32 = v1_1.length | 0;
    const v6: Mut18 = new Mut18(0, UH2_UH2_1());
    while (method70(v4, v6)) {
        const v8: int32 = v6.l0 | 0;
        const v11: int32 = ((op_UnaryNegation_Int32(v8) + v4) - 1) | 0;
        const v12: UH2 = v6.l1;
        const patternInput_1: [int32, any] = v1_1[v11];
        const v15: int32 = (v8 + 1) | 0;
        v6.l0 = (v15 | 0);
        v6.l1 = UH2_UH2_0(patternInput_1[0], patternInput_1[1], v12);
    }
    const v21: (arg0: () => [int32, any]) => any[] = (v: () => [int32, any]): any[] => closure346(void 0, v);
    return [method75(method72(method71(v6.l1, UH2_UH2_1())), v21)];
}

export function closure344(v0_1: Mut1, unitVar: void): any[] {
    const v1_1: (arg0: Mut3) => any = (v: Mut3): any => closure13(void 0, v);
    const v2: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040);
    const v3: () => any[] = (): any[] => closure345(v0_1, void 0);
    return [method30(v1_1, v2, v3)];
}

export function closure334(v0_1: Mut1, v1_1: () => void, v2: () => void, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v73_1: any = Stack;
    const v74_1: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure335(void 0, arg10$0040);
    const v75_1: () => any[] = (): any[] => closure336(v1_1, v2, void 0);
    const v77_1: () => any[] = (): any[] => closure344(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v77_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], US3_US3_1("deploy"), _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(method15(v73_1, v74_1, v75_1)), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function method76(): any {
    const v0_1: Mut1 = method8()[0];
    const patternInput_1: [[int32, any][], [int32, any][], [int32, int32][]] = [v0_1.l6, v0_1.l7, v0_1.l8];
    const v6: (arg0: Mut1, arg1: Mut1, arg2: [int32, any][]) => void = (v: Mut1): (arg0: Mut1, arg1: [int32, any][]) => void => closure330(void 0, v);
    const v7: (arg0: any) => any = (v_1: any): any => closure333(void 0, v_1);
    const patternInput_2: [() => void, () => void] = method62("profile/tmp/chain_deploy");
    const v10: (arg0: Mut4) => any = (v_2: Mut4): any => closure20(void 0, v_2);
    const v13: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure334(v0_1, patternInput_2[1], patternInput_2[0], arg10$0040);
    return method36(v10, US14_US14_0(), US14_US14_0(), v13, US15_US15_2());
}

export function closure329(unitVar: void, v0_1: Mut3): any {
    return method76();
}

export function closure350(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure275(v0_1: string, v1_1: any, v2: string, v3: string, v4: boolean, unitVar: void): any[] {
    let v12: (arg0: Mut3) => any, v13: () => any[], v18: (arg0: Mut3) => any, v19: () => any[];
    const v5: (arg0: Mut3) => any = (v: Mut3): any => closure276(void 0, v);
    const v6: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040);
    const v7: () => any[] = (): any[] => closure305(void 0, void 0);
    const v11: boolean = (v2 === "") !== true;
    return [method30(v5, v6, v7), v11 ? ((v12 = ((v_1: Mut3): any => closure306(void 0, v_1)), (v13 = ((): any[] => closure328(void 0, void 0)), method30(v12, v6, v13)))) : <></>, v11 ? ((v18 = ((v_2: Mut3): any => closure329(void 0, v_2)), (v19 = ((): any[] => closure350(void 0, void 0)), method30(v18, v6, v19)))) : <></>];
}

export function closure274(v0_1: string, v1_1: any, v2: string, v3: string, v4: boolean, unitVar: void): any[] {
    const v5: (arg0: Mut3) => any = (v: Mut3): any => closure13(void 0, v);
    const v6: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040);
    const v7: () => any[] = (): any[] => closure275(v0_1, v1_1, v2, v3, v4, void 0);
    return [method30(v5, v6, v7)];
}

export function closure273(v0_1: string, v1_1: any, v2: string, v3: string, v4: boolean, _arg: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] {
    const v75_1: () => any[] = (): any[] => closure274(v0_1, v1_1, v2, v3, v4, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], US8_US8_1(v75_1), _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], US11_US11_1(<>
        Profile
    </>), _arg[61], _arg[62], _arg[63], _arg[64], _arg[65], _arg[66], _arg[67]];
}

export function closure102(v0_1: string, v1_1: any, v2: string, v3: string, v4: boolean, unitVar: void): any[] {
    const v5: (arg0: Mut4) => any = (v: Mut4): any => closure20(void 0, v);
    const v8: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure103(void 0, arg10$0040);
    const v13: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_1: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure18(void 0, arg10$0040_1);
    const v18: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_2: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure127(void 0, arg10$0040_2);
    const v27: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_3: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure143(void 0, arg10$0040_3);
    const v36: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_4: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure208(void 0, arg10$0040_4);
    const v45: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040_5: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure273(v0_1, v1_1, v2, v3, v4, arg10$0040_5);
    return [method36(v5, US14_US14_0(), US14_US14_0(), v8, US15_US15_2()), method36(v5, US14_US14_0(), US14_US14_0(), v13, US15_US15_2()), method36(v5, US14_US14_0(), US14_US14_0(), v18, US15_US15_2()), method36(v5, US14_US14_0(), US14_US14_0(), v13, US15_US15_2()), method36(v5, US14_US14_0(), US14_US14_0(), v27, US15_US15_0()), method36(v5, US14_US14_0(), US14_US14_0(), v13, US15_US15_2()), method36(v5, US14_US14_0(), US14_US14_0(), v36, US15_US15_0()), method36(v5, US14_US14_0(), US14_US14_0(), v13, US15_US15_2()), method36(v5, US14_US14_0(), US14_US14_0(), v45, US15_US15_2())];
}

export function closure9(v0_1: string, v1_1: any, v2: string, v3: string, v4: boolean, unitVar: void): any[] {
    let v7: (arg0: Mut2) => any;
    const v11: (arg0: Mut3) => any = (v_1: Mut3): any => closure13(void 0, v_1);
    const v12: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure101(void 0, arg10$0040);
    const v13: () => any[] = (): any[] => closure102(v0_1, v1_1, v2, v3, v4, void 0);
    return [(v2 === "") ? ((v7 = ((v: Mut2): any => closure10(void 0, v)), method37(v7))) : <></>, method30(v11, v12, v13)];
}

export function method12(): any {
    const patternInput: [string, any, string, string, boolean] = method1();
    const v7: any = Box;
    const v8: (arg0: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]) => [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] = (arg10$0040: [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3]): [US3, US3, US3, US6, US3, US3, US3, US3, US3, US3, US7, US8, US3, US3, US7, US9, US3, US3, US3, US10, US7, US3, US3, US3, US3, US3, US3, US11, US3, US3, US3, US11, US3, US3, US3, US3, US3, US3, US3, US3, US12, US13, US12, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US11, US3, US3, US9, US9, US3, US2, US3] => closure8(void 0, arg10$0040);
    const v9: () => any[] = (): any[] => closure9(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], void 0);
    return method15(v7, v8, v9);
}

export function closure7(unitVar: void, v0_1: Mut3): any {
    return method12();
}

export const v0 = void 0;

export const v1 = new Mut0(v0);

export const v70 = process.env;

export const v71 = "env";

export const v72 = [v71, v70];

export const v73 = [v72];

export const v74 = createObj(v73);

window.components_spi = v74;

export const patternInput$00405066 = method0();

export const v85 = patternInput$00405066[10];

export const v84 = patternInput$00405066[9];

export const v83 = patternInput$00405066[8];

export const v82 = patternInput$00405066[7];

export const v81 = patternInput$00405066[6];

export const v80 = patternInput$00405066[5];

export const v79 = patternInput$00405066[4];

export const v78 = patternInput$00405066[3];

export const v77 = patternInput$00405066[2];

export const v76 = patternInput$00405066[1];

export const v75 = patternInput$00405066[0];

export const v86 = new Mut1(v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85);

export const v87 = v86;

export const v88 = method6(v87);

export const v89 = nonSeeded().Next0();

export const v90 = "db_listener";

export const v91 = (v: Mut2): any => closure1(v88, v);

export const v92 = [v90, v91];

export const v93 = "content";

export const v94 = (v: Mut3): any => closure7(void 0, v);

export const v95 = [v93, v94];

export const v96 = "store";

export const v97 = [v96, v88];

export const v98 = "run_id";

export const v99 = [v98, v89];

export const v100 = [v92, v95, v97, v99, v72];

export const v101 = createObj(v100);

window.components_spi = v101;

v1.l0 = v101;


