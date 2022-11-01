import { Union, Record } from "./fable_modules/fable-library-ts/Types.js";
import { lambda_type, unit_type, bool_type, class_type, array_type, tuple_type, string_type, int32_type, union_type, record_type, obj_type, TypeInfo } from "./fable_modules/fable-library-ts/Reflection.js";
import { op_UnaryNegation_Int32, int32 } from "./fable_modules/fable-library-ts/Int32.js";
import { createStoreon } from "storeon";
import { int64, fromBits, op_Division, op_Subtraction, toString } from "./fable_modules/fable-library-ts/Long.js";
import { getTicks, utcNow } from "./fable_modules/fable-library-ts/Date.js";
import { Index, For, createEffect, on, createSignal, createComponent, onCleanup } from "solid-js";
import { fill } from "./fable_modules/fable-library-ts/Array.js";
import { Input, useColorMode, RadioGroup, Radio, Anchor, Tr, Td, Stack, IconButton, Icon, Button, Checkbox, Table, Tbody, Box, hope } from "@hope-ui/solid";
import { int32ToString, uncurry, createObj } from "./fable_modules/fable-library-ts/Util.js";
import { useStoreon } from "@storeon/solidjs";
import { interpolate, toConsole } from "./fable_modules/fable-library-ts/String.js";
import { BiRegularMinus, BiRegularPlus, BiRegularLinkExternal, BiRegularUndo, BiRegularUpArrow, BiRegularDownArrow, BiRegularRefresh } from "solid-icons/bi";
import { nonSeeded } from "./fable_modules/fable-library-ts/Random.js";

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
    l9: US2;
    constructor(l0: [US0, string, string, string][], l1: US2, l2: US3, l3: US3, l4: [US4, int32, string, string][], l5: [US4, US4][], l6: [int32, any][], l7: [int32, any][], l8: [int32, int32][], l9: US2) {
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
    }
}

export function Mut1$reflection(): TypeInfo {
    return record_type("Components_spi.Mut1", [], Mut1, () => [["l0", array_type(tuple_type(US0$reflection(), string_type, string_type, string_type))], ["l1", US2$reflection()], ["l2", US3$reflection()], ["l3", US3$reflection()], ["l4", array_type(tuple_type(US4$reflection(), int32_type, string_type, string_type))], ["l5", array_type(tuple_type(US4$reflection(), US4$reflection()))], ["l6", array_type(tuple_type(int32_type, obj_type))], ["l7", array_type(tuple_type(int32_type, obj_type))], ["l8", array_type(tuple_type(int32_type, int32_type))], ["l9", US2$reflection()]]);
}

export const enum US5_Tag {
    US5_0 = 0,
    US5_1 = 1
}

export type US5_Fields = [[], [any]];

export type US5 = US5_Cons<US5_Tag.US5_0> | US5_Cons<US5_Tag.US5_1>;

export function US5_US5_0() {
    return new US5_Cons<US5_Tag.US5_0>(US5_Tag.US5_0, []);
}

export function US5_US5_1(f1_0: any) {
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
    return union_type("Components_spi.US5", [], US5_Cons, () => [[], [["f1_0", class_type("Fable.Core.JS.Function")]]]);
}

export const enum US6_Tag {
    US6_0 = 0,
    US6_1 = 1
}

export type US6_Fields = [[], [boolean]];

export type US6 = US6_Cons<US6_Tag.US6_0> | US6_Cons<US6_Tag.US6_1>;

export function US6_US6_0() {
    return new US6_Cons<US6_Tag.US6_0>(US6_Tag.US6_0, []);
}

export function US6_US6_1(f1_0: boolean) {
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
    return union_type("Components_spi.US6", [], US6_Cons, () => [[], [["f1_0", bool_type]]]);
}

export const enum US7_Tag {
    US7_0 = 0,
    US7_1 = 1
}

export type US7_Fields = [[], [() => any[]]];

export type US7 = US7_Cons<US7_Tag.US7_0> | US7_Cons<US7_Tag.US7_1>;

export function US7_US7_0() {
    return new US7_Cons<US7_Tag.US7_0>(US7_Tag.US7_0, []);
}

export function US7_US7_1(f1_0: () => any[]) {
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
    return union_type("Components_spi.US7", [], US7_Cons, () => [[], [["f1_0", lambda_type(unit_type, array_type(class_type("Fable.Core.JSX.Element")))]]]);
}

export const enum US8_Tag {
    US8_0 = 0,
    US8_1 = 1
}

export type US8_Fields = [[], [any]];

export type US8 = US8_Cons<US8_Tag.US8_0> | US8_Cons<US8_Tag.US8_1>;

export function US8_US8_0() {
    return new US8_Cons<US8_Tag.US8_0>(US8_Tag.US8_0, []);
}

export function US8_US8_1(f1_0: any) {
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
    return union_type("Components_spi.US8", [], US8_Cons, () => [[], [["f1_0", obj_type]]]);
}

export const enum US9_Tag {
    US9_0 = 0,
    US9_1 = 1
}

export type US9_Fields = [[], [any[]]];

export type US9 = US9_Cons<US9_Tag.US9_0> | US9_Cons<US9_Tag.US9_1>;

export function US9_US9_0() {
    return new US9_Cons<US9_Tag.US9_0>(US9_Tag.US9_0, []);
}

export function US9_US9_1(f1_0: any[]) {
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
    return union_type("Components_spi.US9", [], US9_Cons, () => [[], [["f1_0", array_type(obj_type)]]]);
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
    return union_type("Components_spi.US10", [], US10_Cons, () => [[], [["f1_0", class_type("Fable.Core.JSX.Element")]]]);
}

export const enum US11_Tag {
    US11_0 = 0,
    US11_1 = 1
}

export type US11_Fields = [[], [(arg0: any) => void]];

export type US11 = US11_Cons<US11_Tag.US11_0> | US11_Cons<US11_Tag.US11_1>;

export function US11_US11_0() {
    return new US11_Cons<US11_Tag.US11_0>(US11_Tag.US11_0, []);
}

export function US11_US11_1(f1_0: (arg0: any) => void) {
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
    return union_type("Components_spi.US11", [], US11_Cons, () => [[], [["f1_0", lambda_type(obj_type, unit_type)]]]);
}

export const enum US12_Tag {
    US12_0 = 0,
    US12_1 = 1
}

export type US12_Fields = [[], [() => void]];

export type US12 = US12_Cons<US12_Tag.US12_0> | US12_Cons<US12_Tag.US12_1>;

export function US12_US12_0() {
    return new US12_Cons<US12_Tag.US12_0>(US12_Tag.US12_0, []);
}

export function US12_US12_1(f1_0: () => void) {
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
    return union_type("Components_spi.US12", [], US12_Cons, () => [[], [["f1_0", lambda_type(unit_type, unit_type)]]]);
}

export class Mut2 extends Record {
    l0: US3;
    l1: US3;
    l2: US5;
    l3: US3;
    l4: US3;
    l5: US3;
    l6: US3;
    l7: US3;
    l8: US3;
    l9: US6;
    l10: US7;
    l11: US3;
    l12: US3;
    l13: US6;
    l14: US8;
    l15: US3;
    l16: US3;
    l17: US3;
    l18: US9;
    l19: US6;
    l20: US3;
    l21: US3;
    l22: US3;
    l23: US3;
    l24: US3;
    l25: US10;
    l26: US3;
    l27: US3;
    l28: US3;
    l29: US10;
    l30: US3;
    l31: US3;
    l32: US3;
    l33: US3;
    l34: US3;
    l35: US3;
    l36: US3;
    l37: US3;
    l38: US11;
    l39: US12;
    l40: US11;
    l41: US3;
    l42: US3;
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
    l56: US10;
    l57: US3;
    l58: US3;
    l59: US8;
    l60: US3;
    l61: US2;
    l62: US3;
    constructor(l0: US3, l1: US3, l2: US5, l3: US3, l4: US3, l5: US3, l6: US3, l7: US3, l8: US3, l9: US6, l10: US7, l11: US3, l12: US3, l13: US6, l14: US8, l15: US3, l16: US3, l17: US3, l18: US9, l19: US6, l20: US3, l21: US3, l22: US3, l23: US3, l24: US3, l25: US10, l26: US3, l27: US3, l28: US3, l29: US10, l30: US3, l31: US3, l32: US3, l33: US3, l34: US3, l35: US3, l36: US3, l37: US3, l38: US11, l39: US12, l40: US11, l41: US3, l42: US3, l43: US3, l44: US3, l45: US3, l46: US3, l47: US3, l48: US3, l49: US3, l50: US3, l51: US3, l52: US3, l53: US3, l54: US3, l55: US3, l56: US10, l57: US3, l58: US3, l59: US8, l60: US3, l61: US2, l62: US3) {
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
    }
}

export function Mut2$reflection(): TypeInfo {
    return record_type("Components_spi.Mut2", [], Mut2, () => [["l0", US3$reflection()], ["l1", US3$reflection()], ["l2", US5$reflection()], ["l3", US3$reflection()], ["l4", US3$reflection()], ["l5", US3$reflection()], ["l6", US3$reflection()], ["l7", US3$reflection()], ["l8", US3$reflection()], ["l9", US6$reflection()], ["l10", US7$reflection()], ["l11", US3$reflection()], ["l12", US3$reflection()], ["l13", US6$reflection()], ["l14", US8$reflection()], ["l15", US3$reflection()], ["l16", US3$reflection()], ["l17", US3$reflection()], ["l18", US9$reflection()], ["l19", US6$reflection()], ["l20", US3$reflection()], ["l21", US3$reflection()], ["l22", US3$reflection()], ["l23", US3$reflection()], ["l24", US3$reflection()], ["l25", US10$reflection()], ["l26", US3$reflection()], ["l27", US3$reflection()], ["l28", US3$reflection()], ["l29", US10$reflection()], ["l30", US3$reflection()], ["l31", US3$reflection()], ["l32", US3$reflection()], ["l33", US3$reflection()], ["l34", US3$reflection()], ["l35", US3$reflection()], ["l36", US3$reflection()], ["l37", US3$reflection()], ["l38", US11$reflection()], ["l39", US12$reflection()], ["l40", US11$reflection()], ["l41", US3$reflection()], ["l42", US3$reflection()], ["l43", US3$reflection()], ["l44", US3$reflection()], ["l45", US3$reflection()], ["l46", US3$reflection()], ["l47", US3$reflection()], ["l48", US3$reflection()], ["l49", US3$reflection()], ["l50", US3$reflection()], ["l51", US3$reflection()], ["l52", US3$reflection()], ["l53", US3$reflection()], ["l54", US3$reflection()], ["l55", US3$reflection()], ["l56", US10$reflection()], ["l57", US3$reflection()], ["l58", US3$reflection()], ["l59", US8$reflection()], ["l60", US3$reflection()], ["l61", US2$reflection()], ["l62", US3$reflection()]]);
}

export class Mut3 {
    constructor() {
    }
}

export function Mut3$reflection(): TypeInfo {
    return class_type("Components_spi.Mut3", void 0, Mut3);
}

export function Mut3_$ctor(): Mut3 {
    return new Mut3();
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

export const enum US13_Tag {
    US13_0 = 0,
    US13_1 = 1
}

export type US13_Fields = [[], [(arg0: Mut1, arg1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void]];

export type US13 = US13_Cons<US13_Tag.US13_0> | US13_Cons<US13_Tag.US13_1>;

export function US13_US13_0() {
    return new US13_Cons<US13_Tag.US13_0>(US13_Tag.US13_0, []);
}

export function US13_US13_1(f1_0: (arg0: Mut1, arg1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void) {
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
    return union_type("Components_spi.US13", [], US13_Cons, () => [[], [["f1_0", lambda_type(Mut1$reflection(), lambda_type(lambda_type(lambda_type(Mut1$reflection(), lambda_type(Mut1$reflection(), unit_type)), unit_type), unit_type))]]]);
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
    l1: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3];
    l2: US14;
    constructor(l0: US13, l1: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3], l2: US14) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
    }
}

export function Mut4$reflection(): TypeInfo {
    return record_type("Components_spi.Mut4", [], Mut4, () => [["l0", US13$reflection()], ["l1", lambda_type(tuple_type(US3$reflection(), US3$reflection(), US5$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US6$reflection(), US7$reflection(), US3$reflection(), US3$reflection(), US6$reflection(), US8$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US9$reflection(), US6$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US10$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US10$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US12$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US10$reflection(), US3$reflection(), US3$reflection(), US8$reflection(), US3$reflection(), US2$reflection(), US3$reflection()), tuple_type(US3$reflection(), US3$reflection(), US5$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US6$reflection(), US7$reflection(), US3$reflection(), US3$reflection(), US6$reflection(), US8$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US9$reflection(), US6$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US10$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US10$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US12$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US10$reflection(), US3$reflection(), US3$reflection(), US8$reflection(), US3$reflection(), US2$reflection(), US3$reflection()))], ["l2", US14$reflection()]]);
}

export class Mut5 extends Record {
    l0: boolean;
    l1: boolean;
    l2: US13;
    l3: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3];
    constructor(l0: boolean, l1: boolean, l2: US13, l3: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
        this.l3 = l3;
    }
}

export function Mut5$reflection(): TypeInfo {
    return record_type("Components_spi.Mut5", [], Mut5, () => [["l0", bool_type], ["l1", bool_type], ["l2", US13$reflection()], ["l3", lambda_type(tuple_type(US3$reflection(), US3$reflection(), US5$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US6$reflection(), US7$reflection(), US3$reflection(), US3$reflection(), US6$reflection(), US8$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US9$reflection(), US6$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US10$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US10$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US12$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US10$reflection(), US3$reflection(), US3$reflection(), US8$reflection(), US3$reflection(), US2$reflection(), US3$reflection()), tuple_type(US3$reflection(), US3$reflection(), US5$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US6$reflection(), US7$reflection(), US3$reflection(), US3$reflection(), US6$reflection(), US8$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US9$reflection(), US6$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US10$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US10$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US12$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US10$reflection(), US3$reflection(), US3$reflection(), US8$reflection(), US3$reflection(), US2$reflection(), US3$reflection()))]]);
}

export class Mut6 extends Record {
    l0: int32;
    constructor(l0: int32) {
        super();
        this.l0 = (l0 | 0);
    }
}

export function Mut6$reflection(): TypeInfo {
    return record_type("Components_spi.Mut6", [], Mut6, () => [["l0", int32_type]]);
}

export class Mut7 extends Record {
    l0: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3];
    l1: () => any;
    l2: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3];
    constructor(l0: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3], l1: () => any, l2: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
    }
}

export function Mut7$reflection(): TypeInfo {
    return record_type("Components_spi.Mut7", [], Mut7, () => [["l0", lambda_type(tuple_type(US3$reflection(), US3$reflection(), US5$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US6$reflection(), US7$reflection(), US3$reflection(), US3$reflection(), US6$reflection(), US8$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US9$reflection(), US6$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US10$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US10$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US12$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US10$reflection(), US3$reflection(), US3$reflection(), US8$reflection(), US3$reflection(), US2$reflection(), US3$reflection()), tuple_type(US3$reflection(), US3$reflection(), US5$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US6$reflection(), US7$reflection(), US3$reflection(), US3$reflection(), US6$reflection(), US8$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US9$reflection(), US6$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US10$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US10$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US12$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US10$reflection(), US3$reflection(), US3$reflection(), US8$reflection(), US3$reflection(), US2$reflection(), US3$reflection()))], ["l1", lambda_type(unit_type, class_type("Fable.Core.JS.Function"))], ["l2", lambda_type(tuple_type(US3$reflection(), US3$reflection(), US5$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US6$reflection(), US7$reflection(), US3$reflection(), US3$reflection(), US6$reflection(), US8$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US9$reflection(), US6$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US10$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US10$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US12$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US10$reflection(), US3$reflection(), US3$reflection(), US8$reflection(), US3$reflection(), US2$reflection(), US3$reflection()), tuple_type(US3$reflection(), US3$reflection(), US5$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US6$reflection(), US7$reflection(), US3$reflection(), US3$reflection(), US6$reflection(), US8$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US9$reflection(), US6$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US10$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US10$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US11$reflection(), US12$reflection(), US11$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US3$reflection(), US10$reflection(), US3$reflection(), US3$reflection(), US8$reflection(), US3$reflection(), US2$reflection(), US3$reflection()))]]);
}

export class Mut8 extends Record {
    l0: (arg0: Mut1) => US3;
    l1: (arg0: Mut1, arg1: Mut1, arg2: US3) => void;
    constructor(l0: (arg0: Mut1) => US3, l1: (arg0: Mut1, arg1: Mut1, arg2: US3) => void) {
        super();
        this.l0 = l0;
        this.l1 = l1;
    }
}

export function Mut8$reflection(): TypeInfo {
    return record_type("Components_spi.Mut8", [], Mut8, () => [["l0", lambda_type(Mut1$reflection(), US3$reflection())], ["l1", lambda_type(Mut1$reflection(), lambda_type(Mut1$reflection(), lambda_type(US3$reflection(), unit_type)))]]);
}

export class Mut9 extends Record {
    l0: (arg0: Mut1) => US2;
    l1: (arg0: Mut1, arg1: Mut1, arg2: US2) => void;
    constructor(l0: (arg0: Mut1) => US2, l1: (arg0: Mut1, arg1: Mut1, arg2: US2) => void) {
        super();
        this.l0 = l0;
        this.l1 = l1;
    }
}

export function Mut9$reflection(): TypeInfo {
    return record_type("Components_spi.Mut9", [], Mut9, () => [["l0", lambda_type(Mut1$reflection(), US2$reflection())], ["l1", lambda_type(Mut1$reflection(), lambda_type(Mut1$reflection(), lambda_type(US2$reflection(), unit_type)))]]);
}

export class Mut10 extends Record {
    l0: US4;
    constructor(l0: US4) {
        super();
        this.l0 = l0;
    }
}

export function Mut10$reflection(): TypeInfo {
    return record_type("Components_spi.Mut10", [], Mut10, () => [["l0", US4$reflection()]]);
}

export class Mut11 extends Record {
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

export function Mut11$reflection(): TypeInfo {
    return record_type("Components_spi.Mut11", [], Mut11, () => [["l0", US4$reflection()], ["l1", lambda_type(tuple_type(US4$reflection(), int32_type, string_type, string_type), US3$reflection())], ["l2", lambda_type(tuple_type(US4$reflection(), int32_type, string_type, string_type), lambda_type(US3$reflection(), tuple_type(US4$reflection(), int32_type, string_type, string_type)))]]);
}

export class Mut12 extends Record {
    l0: int32;
    l1: US3;
    constructor(l0: int32, l1: US3) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = l1;
    }
}

export function Mut12$reflection(): TypeInfo {
    return record_type("Components_spi.Mut12", [], Mut12, () => [["l0", int32_type], ["l1", US3$reflection()]]);
}

export const enum US15_Tag {
    US15_0 = 0,
    US15_1 = 1
}

export type US15_Fields = [[], [US4, int32, string, string]];

export type US15 = US15_Cons<US15_Tag.US15_0> | US15_Cons<US15_Tag.US15_1>;

export function US15_US15_0() {
    return new US15_Cons<US15_Tag.US15_0>(US15_Tag.US15_0, []);
}

export function US15_US15_1(f1_0: US4, f1_1: int32, f1_2: string, f1_3: string) {
    return new US15_Cons<US15_Tag.US15_1>(US15_Tag.US15_1, [f1_0, f1_1, f1_2, f1_3]);
}

export class US15_Cons<Tag extends keyof US15_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: US15_Fields[Tag]) {
        super();
    }
    cases() {
        return ["US15_0", "US15_1"];
    }
}

export function US15$reflection(): TypeInfo {
    return union_type("Components_spi.US15", [], US15_Cons, () => [[], [["f1_0", US4$reflection()], ["f1_1", int32_type], ["f1_2", string_type], ["f1_3", string_type]]]);
}

export class Mut13 extends Record {
    l0: int32;
    l1: US15;
    constructor(l0: int32, l1: US15) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = l1;
    }
}

export function Mut13$reflection(): TypeInfo {
    return record_type("Components_spi.Mut13", [], Mut13, () => [["l0", int32_type], ["l1", US15$reflection()]]);
}

export class Mut14 extends Record {
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

export function Mut14$reflection(): TypeInfo {
    return record_type("Components_spi.Mut14", [], Mut14, () => [["l0", US4$reflection()], ["l1", lambda_type(tuple_type(US4$reflection(), int32_type, string_type, string_type), US2$reflection())], ["l2", lambda_type(tuple_type(US4$reflection(), int32_type, string_type, string_type), lambda_type(US2$reflection(), tuple_type(US4$reflection(), int32_type, string_type, string_type)))]]);
}

export class Mut15 extends Record {
    l0: int32;
    l1: US2;
    constructor(l0: int32, l1: US2) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = l1;
    }
}

export function Mut15$reflection(): TypeInfo {
    return record_type("Components_spi.Mut15", [], Mut15, () => [["l0", int32_type], ["l1", US2$reflection()]]);
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

export class Mut16 extends Record {
    l0: int32;
    l1: UH1;
    constructor(l0: int32, l1: UH1) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = l1;
    }
}

export function Mut16$reflection(): TypeInfo {
    return record_type("Components_spi.Mut16", [], Mut16, () => [["l0", int32_type], ["l1", UH1$reflection()]]);
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

export class Mut17 extends Record {
    l0: int32;
    l1: UH2;
    constructor(l0: int32, l1: UH2) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = l1;
    }
}

export function Mut17$reflection(): TypeInfo {
    return record_type("Components_spi.Mut17", [], Mut17, () => [["l0", int32_type], ["l1", UH2$reflection()]]);
}

export function method0(v0_1: string, v1_1: any, v2: string, v3: string, v4: boolean): [[US0, string, string, string][], US2, US3, US3, [US4, int32, string, string][], [US4, US4][], [int32, any][], [int32, any][], [int32, int32][], US2] {
    const v5: boolean = "" === v0_1;
    return [[[US0_US0_0(), "4ZZJNAAPJGOUBHORYKX5DQSJJIMQLADNUIH7ONXZAVEZYZGOAM5CM7HV2M", "poem slush dry adult final thunder price pause concert topic mesh wild dry gate judge celery winter list promote clump country loan move about faith", "OBVzhzxAK4ZPdaF1QbkXsd8hgRUPJeCfYFjFghgMGnLmcpaAD0mdQJ3Rwq/RwklKGQWAbaIP9zb5BUmcZM4DOg=="], [US0_US0_1(US1_US1_1()), "Q2MAJEB7HYFK42KSN2MY26PL3P5P7HVIGR22GDAGCJQUARDEIM4WLHSIFQ", "crater dove click normal kitten aisle obvious error exotic lunar guard impact donkey gun lamp divide announce match cement excess piano turn fish above make", "lHFQVWKpvRYU00yAQqHOHJegn5nvP0owYkroBFKr94qGmASQPz4KrmlSbpmNeevb+v+eqDR1owwGEmFARGRDOQ=="], [US0_US0_1(US1_US1_0()), "KVGJONR4BETXZ3AS224T4MAJATTSTQGVO3VC3YAGSWAYBVD7KPR23RKNBI", "key churn alert mother lock run lyrics category office lamp silver nut cement pistol fury hollow faculty feed capable announce index cloth faint about bid", "0DNKDAK5QfWuMCTMNJ+Re5mSlc7rbI0q1UOUYDmvPGpVTJc2PAknfOwS1rk+MAkE5ynA1XbqLeAGlYGA1H9T4w=="]], US2_US2_1(v5 ? 4001 : 80), US3_US3_1("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"), US3_US3_1(v5 ? "http://localhost" : (`http://${v0_1}-4001.githubpreview.dev`)), [[US4_US4_1(), v5 ? ((true === v4) ? 14944 : ((false === v4) ? 4944 : 80)) : 80, v5 ? "ws://localhost" : ((true === v4) ? "ws://localhost" : (`ws://${v0_1}-4944.githubpreview.dev`)), "ws"], [US4_US4_0(), v5 ? ((true === v4) ? 18765 : ((false === v4) ? 8765 : 80)) : 80, v5 ? "wss://localhost" : ((true === v4) ? "wss://localhost" : (`ws://${v0_1}-8765.githubpreview.dev`)), "gun"]], [], [], [], [], US2_US2_0()];
}

export function closure1(v0_1: any, v1_1: any): void {
    const v2: any = v1_1.on;
    v2("@init", ((): any => v0_1));
    v2("set", ((_: any, state: any) => state));
}

export function closure0(unitVar: void, v0_1: any): any {
    const v3: any = createStoreon;
    const v4: (arg0: any) => void = (v: any): void => {
        closure1(v0_1, v);
    };
    return v3([v4]);
}

export function method1(): (arg0: any) => any {
    return (v: any): any => closure0(void 0, v);
}

export function method3(v0_1_mut: int32, v1_1_mut: string): string {
    method3:
    while (true) {
        const v0_1: int32 = v0_1_mut, v1_1: string = v1_1_mut;
        if (v1_1.length < v0_1) {
            v0_1_mut = v0_1;
            v1_1_mut = (`0${v1_1}`);
            continue method3;
        }
        else {
            return v1_1;
        }
        break;
    }
}

export function closure3(v0_1: string, v1_1: any, v2: string, v3: string, v4: boolean, v5: int64, _arg: [Mut1, Mut1, any]): void {
    let copyOfStruct: Date;
    const v7: Mut1 = _arg[1];
    const v13: any[] = [">> db_listener store.on(@changed)", ["b_changed:", v7]];
    const v20: string = `[${method3(6, toString(op_Subtraction(op_Division((copyOfStruct = utcNow(), getTicks(copyOfStruct)), fromBits(1000, 0, false)), v5)))}] ${components_spi.run_id}`;
    const v21: string = JSON.stringify(v13);
    const v23: string = JSON.stringify([]);
    let patternInput: [string, string, string, string, string];
    if (v4) {
        const v24: string = "";
        patternInput = [v20, v21, v23, v24, v24];
    }
    else {
        patternInput = [`${v20} %c%s %c%s`, `font-weight: bold; color: ${"#cf1100"}`, v21, "font-weight: bold; color: #444", v23];
    }
    console.log.apply(console, [patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4]]);
    const patternInput_1: [[US4, int32, string, string][], [US4, US4][]] = [v7.l4, v7.l5];
    let v42: boolean;
    if ((!patternInput_1[1]) === false) {
        v42 = true;
    }
    else {
        const patternInput_2: [[US4, int32, string, string][], [US4, US4][]] = [v7.l4, v7.l5];
        v42 = ((!patternInput_2[0]) === false);
    }
}

export function method2(v0_1: any): any {
    let copyOfStruct: Date, copyOfStruct_1: Date;
    const v1_1: any = components_spi.env;
    const v2: string = v1_1.CODESPACE_NAME || "";
    const v3: string = v1_1.GITHUB_RUN_ID || "";
    const v4: string = v1_1.GITHUB_SHA || "";
    const v5: any = v1_1.IS_TEST;
    const v7: boolean = (!v5) === false;
    const v8: int64 = op_Division((copyOfStruct = utcNow(), getTicks(copyOfStruct)), fromBits(1000, 0, false));
    const v11: any[] = ["> db_listener ()"];
    const v18: string = `[${method3(6, toString(op_Subtraction(op_Division((copyOfStruct_1 = utcNow(), getTicks(copyOfStruct_1)), fromBits(1000, 0, false)), v8)))}] ${components_spi.run_id}`;
    const v19: string = JSON.stringify(v11);
    const v21: string = JSON.stringify([]);
    let patternInput: [string, string, string, string, string];
    if (v7) {
        const v22: string = "";
        patternInput = [v18, v19, v21, v22, v22];
    }
    else {
        patternInput = [`${v18} %c%s %c%s`, `font-weight: bold; color: ${"#cf1100"}`, v19, "font-weight: bold; color: #444", v21];
    }
    console.log.apply(console, [patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4]]);
    const v32: any = v0_1.on;
    const v33: (arg0: [Mut1, Mut1, any]) => void = (arg10$0040: [Mut1, Mut1, any]): void => {
        closure3(v2, v1_1, v3, v4, v7, v8, arg10$0040);
    };
    const v34: any = (...args: any[]) => v33(args);
    const v35: () => void = v32("@changed", v34);
    const v38: any = onCleanup;
    v38(v35);
    return <></>;
}

export function closure2(v0_1: any, v1_1: Mut2): any {
    return method2(v0_1);
}

export function method5(): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    return [US3_US3_0(), US3_US3_0(), US5_US5_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US6_US6_0(), US7_US7_0(), US3_US3_0(), US3_US3_0(), US6_US6_0(), US8_US8_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US9_US9_0(), US6_US6_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US10_US10_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US10_US10_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US11_US11_0(), US12_US12_0(), US11_US11_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US3_US3_0(), US10_US10_0(), US3_US3_0(), US3_US3_0(), US8_US8_0(), US3_US3_0(), US2_US2_0(), US3_US3_0()];
}

export function closure8(v0_1: Mut1, unitVar: void): any[] {
    return [<>
        {JSON.stringify(v0_1, null, 2)}
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

export function method7(v0_1: US3, v1_1: US3, v2: US5, v3: US3, v4: US3, v5: US3, v6: US3, v7: US3, v8: US3, v9: US6, v10: US7, v11: US3, v12: US3, v13: US6, v14: US8, v15: US3, v16: US3, v17: US3, v18: US9, v19: US6, v20: US3, v21: US3, v22: US3, v23: US3, v24: US3, v25: US10, v26: US3, v27: US3, v28: US3, v29: US10, v30: US3, v31: US3, v32: US3, v33: US3, v34: US3, v35: US3, v36: US3, v37: US3, v38: US11, v39: US12, v40: US11, v41: US3, v42: US3, v43: US3, v44: US3, v45: US3, v46: US3, v47: US3, v48: US3, v49: US3, v50: US3, v51: US3, v52: US3, v53: US3, v54: US3, v55: US3, v56: US10, v57: US3, v58: US3, v59: US8, v60: US3, v61: US2, v62: US3): [string, any][] {
    const v66_1: any = (v0_1.tag === US3_Tag.US3_1) ? v0_1.fields[0] : (void 0);
    const v73_1: UH0 = (!v66_1) ? UH0_UH0_1() : UH0_UH0_0(["alignItems", v66_1], UH0_UH0_1());
    const v77_1: any = (v1_1.tag === US3_Tag.US3_1) ? v1_1.fields[0] : (void 0);
    const v82_1: UH0 = (!v77_1) ? v73_1 : UH0_UH0_0(["aria-label", v77_1], v73_1);
    const v86_1: any = (v2.tag === US5_Tag.US5_1) ? v2.fields[0] : (void 0);
    const v91_1: UH0 = (!v86_1) ? v82_1 : UH0_UH0_0(["as", v86_1], v82_1);
    const v95_1: any = (v3.tag === US3_Tag.US3_1) ? v3.fields[0] : (void 0);
    const v100_1: UH0 = (!v95_1) ? v91_1 : UH0_UH0_0(["backgroundColor", v95_1], v91_1);
    const v104: any = (v4.tag === US3_Tag.US3_1) ? v4.fields[0] : (void 0);
    const v109: UH0 = (!v104) ? v100_1 : UH0_UH0_0(["border", v104], v100_1);
    const v113: any = (v5.tag === US3_Tag.US3_1) ? v5.fields[0] : (void 0);
    const v118: UH0 = (!v113) ? v109 : UH0_UH0_0(["borderBottomWidth", v113], v109);
    const v122: any = (v6.tag === US3_Tag.US3_1) ? v6.fields[0] : (void 0);
    const v127: UH0 = (!v122) ? v118 : UH0_UH0_0(["borderColor", v122], v118);
    const v131: any = (v7.tag === US3_Tag.US3_1) ? v7.fields[0] : (void 0);
    const v136: UH0 = (!v131) ? v127 : UH0_UH0_0(["borderWidth", v131], v127);
    const v140: any = (v8.tag === US3_Tag.US3_1) ? v8.fields[0] : (void 0);
    const v145: UH0 = (!v140) ? v136 : UH0_UH0_0(["bottom", v140], v136);
    const v149: any = (v9.tag === US6_Tag.US6_1) ? v9.fields[0] : (void 0);
    const v154: UH0 = (!v149) ? v145 : UH0_UH0_0(["checked", v149], v145);
    const v158: any = (v10.tag === US7_Tag.US7_1) ? v10.fields[0] : (void 0);
    const v163: UH0 = (!v158) ? v154 : UH0_UH0_0(["children", v158], v154);
    const v167: any = (v11.tag === US3_Tag.US3_1) ? v11.fields[0] : (void 0);
    const v172: UH0 = (!v167) ? v163 : UH0_UH0_0(["color", v167], v163);
    const v176: any = (v12.tag === US3_Tag.US3_1) ? v12.fields[0] : (void 0);
    const v181: UH0 = (!v176) ? v172 : UH0_UH0_0(["colorScheme", v176], v172);
    const v185: any = (v13.tag === US6_Tag.US6_1) ? v13.fields[0] : (void 0);
    const v190: UH0 = (!v185) ? v181 : UH0_UH0_0(["compact", v185], v181);
    const v194: any = (v14.tag === US8_Tag.US8_1) ? v14.fields[0] : (void 0);
    const v199: UH0 = (!v194) ? v190 : UH0_UH0_0(["css", v194], v190);
    const v203: any = (v15.tag === US3_Tag.US3_1) ? v15.fields[0] : (void 0);
    const v208: UH0 = (!v203) ? v199 : UH0_UH0_0(["defaultValue", v203], v199);
    const v212: any = (v16.tag === US3_Tag.US3_1) ? v16.fields[0] : (void 0);
    const v217: UH0 = (!v212) ? v208 : UH0_UH0_0(["direction", v212], v208);
    const v221: any = (v17.tag === US3_Tag.US3_1) ? v17.fields[0] : (void 0);
    const v226: UH0 = (!v221) ? v217 : UH0_UH0_0(["display", v221], v217);
    const v230: any = (v18.tag === US9_Tag.US9_1) ? v18.fields[0] : (void 0);
    const v235: UH0 = (!v230) ? v226 : UH0_UH0_0(["each", v230], v226);
    const v239: any = (v19.tag === US6_Tag.US6_1) ? v19.fields[0] : (void 0);
    const v244: UH0 = (!v239) ? v235 : UH0_UH0_0(["external", v239], v235);
    const v248: any = (v20.tag === US3_Tag.US3_1) ? v20.fields[0] : (void 0);
    const v253: UH0 = (!v248) ? v244 : UH0_UH0_0(["flex", v248], v244);
    const v257: any = (v21.tag === US3_Tag.US3_1) ? v21.fields[0] : (void 0);
    const v262: UH0 = (!v257) ? v253 : UH0_UH0_0(["flexDirection", v257], v253);
    const v266: any = (v22.tag === US3_Tag.US3_1) ? v22.fields[0] : (void 0);
    const v271: UH0 = (!v266) ? v262 : UH0_UH0_0(["fontSize", v266], v262);
    const v275: any = (v23.tag === US3_Tag.US3_1) ? v23.fields[0] : (void 0);
    const v280: UH0 = (!v275) ? v271 : UH0_UH0_0(["height", v275], v271);
    const v284: any = (v24.tag === US3_Tag.US3_1) ? v24.fields[0] : (void 0);
    const v289: UH0 = (!v284) ? v280 : UH0_UH0_0(["href", v284], v280);
    const v293: any = (v25.tag === US10_Tag.US10_1) ? v25.fields[0] : (void 0);
    const v298: UH0 = (!v293) ? v289 : UH0_UH0_0(["icon", v293], v289);
    const v302: any = (v26.tag === US3_Tag.US3_1) ? v26.fields[0] : (void 0);
    const v307: UH0 = (!v302) ? v298 : UH0_UH0_0(["id", v302], v298);
    const v311: any = (v27.tag === US3_Tag.US3_1) ? v27.fields[0] : (void 0);
    const v316: UH0 = (!v311) ? v307 : UH0_UH0_0(["justifyContent", v311], v307);
    const v320: any = (v28.tag === US3_Tag.US3_1) ? v28.fields[0] : (void 0);
    const v325: UH0 = (!v320) ? v316 : UH0_UH0_0(["left", v320], v316);
    const v329: any = (v29.tag === US10_Tag.US10_1) ? v29.fields[0] : (void 0);
    const v334: UH0 = (!v329) ? v325 : UH0_UH0_0(["leftIcon", v329], v325);
    const v338: any = (v30.tag === US3_Tag.US3_1) ? v30.fields[0] : (void 0);
    const v343: UH0 = (!v338) ? v334 : UH0_UH0_0(["lineHeight", v338], v334);
    const v347: any = (v31.tag === US3_Tag.US3_1) ? v31.fields[0] : (void 0);
    const v352: UH0 = (!v347) ? v343 : UH0_UH0_0(["margin", v347], v343);
    const v356: any = (v32.tag === US3_Tag.US3_1) ? v32.fields[0] : (void 0);
    const v361: UH0 = (!v356) ? v352 : UH0_UH0_0(["marginBottom", v356], v352);
    const v365: any = (v33.tag === US3_Tag.US3_1) ? v33.fields[0] : (void 0);
    const v370: UH0 = (!v365) ? v361 : UH0_UH0_0(["marginLeft", v365], v361);
    const v374: any = (v34.tag === US3_Tag.US3_1) ? v34.fields[0] : (void 0);
    const v379: UH0 = (!v374) ? v370 : UH0_UH0_0(["marginRight", v374], v370);
    const v383: any = (v35.tag === US3_Tag.US3_1) ? v35.fields[0] : (void 0);
    const v388: UH0 = (!v383) ? v379 : UH0_UH0_0(["marginTop", v383], v379);
    const v392: any = (v36.tag === US3_Tag.US3_1) ? v36.fields[0] : (void 0);
    const v397: UH0 = (!v392) ? v388 : UH0_UH0_0(["maxHeight", v392], v388);
    const v401: any = (v37.tag === US3_Tag.US3_1) ? v37.fields[0] : (void 0);
    const v406: UH0 = (!v401) ? v397 : UH0_UH0_0(["maxWidth", v401], v397);
    const v410: any = (v38.tag === US11_Tag.US11_1) ? v38.fields[0] : (void 0);
    const v415: UH0 = (!v410) ? v406 : UH0_UH0_0(["onChange", v410], v406);
    const v419: any = (v39.tag === US12_Tag.US12_1) ? v39.fields[0] : (void 0);
    const v424: UH0 = (!v419) ? v415 : UH0_UH0_0(["onClick", v419], v415);
    const v428: any = (v40.tag === US11_Tag.US11_1) ? v40.fields[0] : (void 0);
    const v433: UH0 = (!v428) ? v424 : UH0_UH0_0(["onInput", v428], v424);
    const v437: any = (v41.tag === US3_Tag.US3_1) ? v41.fields[0] : (void 0);
    const v442: UH0 = (!v437) ? v433 : UH0_UH0_0(["outline", v437], v433);
    const v446: any = (v42.tag === US3_Tag.US3_1) ? v42.fields[0] : (void 0);
    const v451: UH0 = (!v446) ? v442 : UH0_UH0_0(["overflowX", v446], v442);
    const v455: any = (v43.tag === US3_Tag.US3_1) ? v43.fields[0] : (void 0);
    const v460: UH0 = (!v455) ? v451 : UH0_UH0_0(["overflowY", v455], v451);
    const v464: any = (v44.tag === US3_Tag.US3_1) ? v44.fields[0] : (void 0);
    const v469: UH0 = (!v464) ? v460 : UH0_UH0_0(["padding", v464], v460);
    const v473: any = (v45.tag === US3_Tag.US3_1) ? v45.fields[0] : (void 0);
    const v478: UH0 = (!v473) ? v469 : UH0_UH0_0(["paddingBottom", v473], v469);
    const v482: any = (v46.tag === US3_Tag.US3_1) ? v46.fields[0] : (void 0);
    const v487: UH0 = (!v482) ? v478 : UH0_UH0_0(["paddingLeft", v482], v478);
    const v491: any = (v47.tag === US3_Tag.US3_1) ? v47.fields[0] : (void 0);
    const v496: UH0 = (!v491) ? v487 : UH0_UH0_0(["paddingRight", v491], v487);
    const v500: any = (v48.tag === US3_Tag.US3_1) ? v48.fields[0] : (void 0);
    const v505: UH0 = (!v500) ? v496 : UH0_UH0_0(["paddingTop", v500], v496);
    const v509: any = (v49.tag === US3_Tag.US3_1) ? v49.fields[0] : (void 0);
    const v514: UH0 = (!v509) ? v505 : UH0_UH0_0(["position", v509], v505);
    const v518: any = (v50.tag === US3_Tag.US3_1) ? v50.fields[0] : (void 0);
    const v523: UH0 = (!v518) ? v514 : UH0_UH0_0(["right", v518], v514);
    const v527: any = (v51.tag === US3_Tag.US3_1) ? v51.fields[0] : (void 0);
    const v532: UH0 = (!v527) ? v523 : UH0_UH0_0(["size", v527], v523);
    const v536: any = (v52.tag === US3_Tag.US3_1) ? v52.fields[0] : (void 0);
    const v541: UH0 = (!v536) ? v532 : UH0_UH0_0(["spacing", v536], v532);
    const v545: any = (v53.tag === US3_Tag.US3_1) ? v53.fields[0] : (void 0);
    const v550: UH0 = (!v545) ? v541 : UH0_UH0_0(["src", v545], v541);
    const v554: any = (v54.tag === US3_Tag.US3_1) ? v54.fields[0] : (void 0);
    const v559: UH0 = (!v554) ? v550 : UH0_UH0_0(["striped", v554], v550);
    const v563: any = (v55.tag === US3_Tag.US3_1) ? v55.fields[0] : (void 0);
    const v568: UH0 = (!v563) ? v559 : UH0_UH0_0(["thickness", v563], v559);
    const v572: any = (v56.tag === US10_Tag.US10_1) ? v56.fields[0] : (void 0);
    const v577: UH0 = (!v572) ? v568 : UH0_UH0_0(["title", v572], v568);
    const v581: any = (v57.tag === US3_Tag.US3_1) ? v57.fields[0] : (void 0);
    const v586: UH0 = (!v581) ? v577 : UH0_UH0_0(["top", v581], v577);
    const v590: any = (v58.tag === US3_Tag.US3_1) ? v58.fields[0] : (void 0);
    const v595: UH0 = (!v590) ? v586 : UH0_UH0_0(["type", v590], v586);
    const v599: any = (v59.tag === US8_Tag.US8_1) ? v59.fields[0] : (void 0);
    const v604: UH0 = (!v599) ? v595 : UH0_UH0_0(["value", v599], v595);
    const v608: any = (v60.tag === US3_Tag.US3_1) ? v60.fields[0] : (void 0);
    const v613: UH0 = (!v608) ? v604 : UH0_UH0_0(["width", v608], v604);
    const v617: any = (v61.tag === US2_Tag.US2_1) ? v61.fields[0] : (void 0);
    const v622: UH0 = (!v617) ? v613 : UH0_UH0_0(["zIndex", v617], v613);
    const v626: any = (v62.tag === US3_Tag.US3_1) ? v62.fields[0] : (void 0);
    return method8((!v626) ? v622 : UH0_UH0_0(["zoom", v626], v622));
}

export function closure7(v0_1: Mut1, unitVar: void): any[] {
    const v3: any = hope;
    const v4: any = v3.pre;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v68_1: () => any[] = (): any[] => closure8(v0_1, void 0);
    const v73_1: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v68_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], US3_US3_1("9px"), patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]));
    const v74_1: (arg0: any) => any = v4;
    const v77_1: any = createComponent;
    return [v77_1(v74_1, v73_1)];
}

export function method6(): any {
    const v2: any = useStoreon;
    const v3: any[] = v2();
    const v4: Mut1 = v3[0];
    const v5: any = v3[1];
    const v8: any = Box;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v74_1: string = "0";
    const v76_1: () => any[] = (): any[] => closure7(v4, void 0);
    const v87_1: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], US3_US3_1("#00000066"), patternInput[4], patternInput[5], patternInput[6], patternInput[7], US3_US3_1(v74_1), patternInput[9], US7_US7_1(v76_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], US3_US3_1("auto"), patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], US3_US3_1("absolute"), US3_US3_1(v74_1), patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], US3_US3_1(v74_1), patternInput[58], patternInput[59], patternInput[60], US2_US2_1(1), patternInput[62]));
    const v88_1: (arg0: any) => any = v8;
    const v91_1: any = createComponent;
    return v91_1(v88_1, v87_1);
}

export function closure6(unitVar: void, v0_1: Mut3): any {
    return method6();
}

export function closure11(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure10(v0_1: Mut2, unitVar: void): any[] {
    const v1_1: US7 = v0_1.l10;
    const v4: () => any[] = (v1_1.tag === US7_Tag.US7_1) ? v1_1.fields[0] : ((): any[] => closure11(void 0, void 0));
    const v7: any = Tbody;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v81_1: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], US3_US3_1("$blackAlpha3"), patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v4), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], US3_US3_1("flex"), patternInput[18], patternInput[19], patternInput[20], US3_US3_1("column"), patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], US3_US3_1("-1px"), patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]));
    const v82_1: (arg0: any) => any = v7;
    const v85_1: any = createComponent;
    return [v85_1(v82_1, v81_1)];
}

export function method11(v0_1: Mut2): any {
    const v3: any = Table;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v67_1: US3 = v0_1.l43;
    const v71_1: () => any[] = (): any[] => closure10(v0_1, void 0);
    const v83_1: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v71_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], US3_US3_1("flex"), patternInput[18], patternInput[19], US3_US3_1("1"), US3_US3_1("column"), patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], US3_US3_1("hidden"), US3_US3_1((v67_1.tag === US3_Tag.US3_1) ? v67_1.fields[0] : "hidden"), patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]));
    const v84_1: (arg0: any) => any = v3;
    const v87_1: any = createComponent;
    return v87_1(v84_1, v83_1);
}

export function closure9(unitVar: void, v0_1: Mut2): any {
    return method11(v0_1);
}

export function method13(v0_1: string, v1_1: string): string {
    return {
        "@initial": v1_1,
        "@sm": v0_1,
    };
}

export function closure17(v0_1: any, unitVar: void): any[] {
    return [v0_1];
}

export function closure16(v0_1: any, unitVar: void): any[] {
    const v3: any = Box;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v67_1: () => any[] = (): any[] => closure17(v0_1, void 0);
    const v72_1: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v67_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], US3_US3_1("2px"), patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]));
    const v73_1: (arg0: any) => any = v3;
    const v76_1: any = createComponent;
    return [v76_1(v73_1, v72_1)];
}

export function closure18(v0_1: (arg0: boolean) => void, v1_1: any): void {
    v0_1(v1_1.target.checked);
}

export function closure15(v0_1: Mut4, v1_1: (arg0: boolean) => void, v2: () => boolean, v3: any, unitVar: void): any[] {
    let v92_1: any, patternInput_1: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3], v158: () => any[], v164: (arg0: any) => void, v169: any, v170: (arg0: any) => any, v173: any, v7: any, patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3], v73_1: () => any[], v79_1: (arg0: any) => void, v84_1: any, v85_1: (arg0: any) => any, v88_1: any;
    const v4: US14 = v0_1.l2;
    return [(v4.tag === US14_Tag.US14_1) ? ((v92_1 = Checkbox, (patternInput_1 = method5(), (v158 = ((): any[] => closure16(v3, void 0)), (v164 = ((v_1: any): void => {
        closure18(v1_1, v_1);
    }), (v169 = createObj(method7(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], US6_US6_1(v2()), US7_US7_1(v158), patternInput_1[11], US3_US3_1("neutral"), patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], US3_US3_1("2px"), patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], US11_US11_1(v164), patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], US3_US3_1("sm"), patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62])), (v170 = (v92_1), (v173 = createComponent, v173(v170, v169))))))))) : ((v4.tag === US14_Tag.US14_2) ? v3 : ((v7 = Checkbox, (patternInput = method5(), (v73_1 = ((): any[] => closure16(v3, void 0)), (v79_1 = ((v: any): void => {
        closure18(v1_1, v);
    }), (v84_1 = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], US6_US6_1(v2()), US7_US7_1(v73_1), patternInput[11], US3_US3_1("neutral"), patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], US3_US3_1("2px"), patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], US11_US11_1(v79_1), patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], US3_US3_1("sm"), patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62])), (v85_1 = (v7), (v88_1 = createComponent, v88_1(v85_1, v84_1))))))))))];
}

export function closure19(unitVar: void, unitVar_1: void): any[] {
    return [<>
        &nbsp;
    </>];
}

export function closure22(v0_1: () => boolean, unitVar: void): any[] {
    return [v0_1()];
}

export function closure23(v0_1: (arg0: boolean) => void, v1_1: () => boolean, unitVar: void): void {
    if (v1_1()) {
        v0_1(false);
    }
}

export function closure24(v0_1: Mut1, v1_1: any, v2: (arg0: Mut1, arg1: Mut1) => void): void {
    const v5: Mut1 = createObj(fill(new Array(0), 0, 0, null));
    v2(v0_1, v5);
    toConsole(interpolate("%A%P()", [["use_store dispatch", "new_state(new):", JSON.stringify(v5)]]));
    v1_1("set", v5);
}

export function closure28(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function method17(v0_1: int32, v1_1: Mut6): boolean {
    return v1_1.l0 < v0_1;
}

export function method16(v0_1: Mut2, v1_1: Mut2): void {
    const v2: string[] = Object.keys(v0_1);
    const v3: int32 = v2.length | 0;
    const v4: Mut6 = new Mut6(0);
    while (method17(v3, v4)) {
        const v6: int32 = v4.l0 | 0;
        const v7: string = v2[v6];
        if (!!v1_1[v7].tag) {
            v0_1[v7] = v1_1[v7];
        }
        const v9: int32 = (v6 + 1) | 0;
        v4.l0 = (v9 | 0);
    }
}

export function method15(v0_1: Mut2): any {
    const v1_1: US7 = v0_1.l10;
    const v4: () => any[] = (v1_1.tag === US7_Tag.US7_1) ? v1_1.fields[0] : ((): any[] => closure28(void 0, void 0));
    const v7: any = Button;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const patternInput_1: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = [v0_1.l0, v0_1.l1, v0_1.l2, v0_1.l3, v0_1.l4, v0_1.l5, v0_1.l6, v0_1.l7, v0_1.l8, v0_1.l9, v0_1.l10, v0_1.l11, v0_1.l12, v0_1.l13, v0_1.l14, v0_1.l15, v0_1.l16, v0_1.l17, v0_1.l18, v0_1.l19, v0_1.l20, v0_1.l21, v0_1.l22, v0_1.l23, v0_1.l24, v0_1.l25, v0_1.l26, v0_1.l27, v0_1.l28, v0_1.l29, v0_1.l30, v0_1.l31, v0_1.l32, v0_1.l33, v0_1.l34, v0_1.l35, v0_1.l36, v0_1.l37, v0_1.l38, v0_1.l39, v0_1.l40, v0_1.l41, v0_1.l42, v0_1.l43, v0_1.l44, v0_1.l45, v0_1.l46, v0_1.l47, v0_1.l48, v0_1.l49, v0_1.l50, v0_1.l51, v0_1.l52, v0_1.l53, v0_1.l54, v0_1.l55, v0_1.l56, v0_1.l57, v0_1.l58, v0_1.l59, v0_1.l60, v0_1.l61, v0_1.l62];
    const v142: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], US3_US3_1("neutral"), US6_US6_1(true), patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], US3_US3_1("left"), patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], US3_US3_1("xs"), patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]);
    method16(v142, new Mut2(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], patternInput_1[11], patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62]));
    const patternInput_2: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = [v142.l0, v142.l1, v142.l2, v142.l3, v142.l4, v142.l5, v142.l6, v142.l7, v142.l8, v142.l9, v142.l10, v142.l11, v142.l12, v142.l13, v142.l14, v142.l15, v142.l16, v142.l17, v142.l18, v142.l19, v142.l20, v142.l21, v142.l22, v142.l23, v142.l24, v142.l25, v142.l26, v142.l27, v142.l28, v142.l29, v142.l30, v142.l31, v142.l32, v142.l33, v142.l34, v142.l35, v142.l36, v142.l37, v142.l38, v142.l39, v142.l40, v142.l41, v142.l42, v142.l43, v142.l44, v142.l45, v142.l46, v142.l47, v142.l48, v142.l49, v142.l50, v142.l51, v142.l52, v142.l53, v142.l54, v142.l55, v142.l56, v142.l57, v142.l58, v142.l59, v142.l60, v142.l61, v142.l62];
    const v208: any = createObj(method7(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], US7_US7_1(v4), patternInput_2[11], patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], patternInput_2[18], patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], patternInput_2[29], patternInput_2[30], patternInput_2[31], patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], patternInput_2[41], patternInput_2[42], patternInput_2[43], patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62]));
    const v209: (arg0: any) => any = v7;
    const v212: any = createComponent;
    return v212(v209, v208);
}

export function closure27(unitVar: void, v0_1: Mut2): any {
    return method15(v0_1);
}

export function closure29(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Load
    </>];
}

export function closure30(v0_1: (arg0: boolean) => void, v1_1: Mut5, v2: Mut1, v3: any, unitVar: void): void {
    const v4: US13 = v1_1.l2;
    if (v4.tag === US13_Tag.US13_1) {
        const v7: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void = (v: (arg0: Mut1, arg1: Mut1) => void): void => {
            closure24(v2, v3, uncurry(2, v));
        };
        v4.fields[0](v2, v7);
    }
    v0_1(true);
}

export function closure26(v0_1: (arg0: boolean) => void, v1_1: Mut5, v2: Mut1, v3: any, unitVar: void): any[] {
    const v4: (arg0: Mut2) => any = (v: Mut2): any => closure27(void 0, v);
    const v5: (arg0: any) => any = v4;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v69_1: () => any[] = (): any[] => closure29(void 0, void 0);
    const v71_1: () => void = (): void => {
        closure30(v0_1, v1_1, v2, v3, void 0);
    };
    const v73_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v69_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], US12_US12_1(v71_1), patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]);
    v73_1.children = v69_1;
    const v77_1: any = createComponent;
    return [v77_1(v5, v73_1)];
}

export function closure35(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function method18(v0_1: Mut7): any {
    const v3: any = Icon;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v68_1: any = v0_1.l1();
    const patternInput_1: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v133: string = "-12px";
    const patternInput_2: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = v0_1.l0([patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], patternInput_1[11], patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], US3_US3_1(v133), patternInput_1[34], US3_US3_1(v133), patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], US3_US3_1("0.6")]);
    const v202: any = createObj(method7(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], patternInput_2[10], patternInput_2[11], patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], patternInput_2[18], patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], patternInput_2[29], patternInput_2[30], patternInput_2[31], patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], patternInput_2[41], patternInput_2[42], patternInput_2[43], patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62]));
    const patternInput_3: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = v0_1.l2([patternInput[0], patternInput[1], US5_US5_1(v68_1), patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], US8_US8_1(v202), patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], US3_US3_1("14px"), patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]]);
    const v271: () => any[] = (): any[] => closure35(void 0, void 0);
    const v274: any = createObj(method7(patternInput_3[0], patternInput_3[1], patternInput_3[2], patternInput_3[3], patternInput_3[4], patternInput_3[5], patternInput_3[6], patternInput_3[7], patternInput_3[8], patternInput_3[9], US7_US7_1(v271), patternInput_3[11], patternInput_3[12], patternInput_3[13], patternInput_3[14], patternInput_3[15], patternInput_3[16], patternInput_3[17], patternInput_3[18], patternInput_3[19], patternInput_3[20], patternInput_3[21], patternInput_3[22], patternInput_3[23], patternInput_3[24], patternInput_3[25], patternInput_3[26], patternInput_3[27], patternInput_3[28], patternInput_3[29], patternInput_3[30], patternInput_3[31], patternInput_3[32], patternInput_3[33], patternInput_3[34], patternInput_3[35], patternInput_3[36], patternInput_3[37], patternInput_3[38], patternInput_3[39], patternInput_3[40], patternInput_3[41], patternInput_3[42], patternInput_3[43], patternInput_3[44], patternInput_3[45], patternInput_3[46], patternInput_3[47], patternInput_3[48], patternInput_3[49], patternInput_3[50], patternInput_3[51], patternInput_3[52], patternInput_3[53], patternInput_3[54], patternInput_3[55], patternInput_3[56], patternInput_3[57], patternInput_3[58], patternInput_3[59], patternInput_3[60], patternInput_3[61], patternInput_3[62]));
    const v275: (arg0: any) => any = v3;
    const v278: any = createComponent;
    return v278(v275, v274);
}

export function closure34(unitVar: void, v0_1: Mut7): any {
    return method18(v0_1);
}

export function closure36(unitVar: void, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure37(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularRefresh;
    return v2;
}

export function closure38(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure39(v0_1: (arg0: boolean) => void, unitVar: void): void {
    v0_1(true);
}

export function closure40(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularDownArrow;
    return v2;
}

export function closure41(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularUpArrow;
    return v2;
}

export function closure42(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure43(v0_1: Mut1, v1_1: any, v2: int32, v3: (arg0: boolean) => void, v4: () => boolean, unitVar: void): void {
    const v6: boolean = v4() === false;
    v3(v6);
    const v9: Mut1 = createObj(fill(new Array(0), 0, 0, null));
    const v12: US2 = v6 ? US2_US2_1(v2) : US2_US2_0();
    v9.l9 = v12;
    toConsole(interpolate("%A%P()", [["use_store dispatch", "new_state(new):", JSON.stringify(v9)]]));
    v1_1("set", v9);
}

export function closure44(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularUndo;
    return v2;
}

export function closure45(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure46(v0_1: (arg0: boolean) => void, unitVar: void): void {
    v0_1(false);
}

export function closure33(v0_1: Mut1, v1_1: any, v2: int32, v3: (arg0: boolean) => void, v4: (arg0: boolean) => void, v5: (arg0: boolean) => void, v6: () => boolean, unitVar: void): any[] {
    const v9: any = IconButton;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v73_1: (arg0: Mut7) => any = (v: Mut7): any => closure34(void 0, v);
    const v74_1: (arg0: any) => any = v73_1;
    const v75_1: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure36(void 0, arg10$0040);
    const v76_1: () => any = (): any => closure37(void 0, void 0);
    const v77_1: Mut7 = new Mut7(v75_1, v76_1, v75_1);
    const v81_1: any = createComponent;
    const v85_1: () => any[] = (): any[] => closure38(void 0, void 0);
    const v87_1: string = "neutral";
    const v89_1: string = "20px";
    const v92_1: () => void = (): void => {
        closure39(v4, void 0);
    };
    const v94_1: string = "xs";
    const v97_1: any = createObj(method7(patternInput[0], US3_US3_1("Refresh"), patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v85_1), patternInput[11], US3_US3_1(v87_1), patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], US3_US3_1(v89_1), patternInput[24], US10_US10_1(v81_1(v74_1, v77_1)), patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], US12_US12_1(v92_1), patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], US3_US3_1(v94_1), patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]));
    const v98_1: (arg0: any) => any = v9;
    const v99_1: any = createComponent;
    const v100_1: any = v99_1(v98_1, v97_1);
    const v101_1: any = IconButton;
    const patternInput_1: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v168: string = v6() ? "Restore" : "Maximize";
    const v173: (arg0: any) => any = v73_1;
    const v174: Mut7 = new Mut7(v75_1, v6() ? ((): any => closure40(void 0, void 0)) : ((): any => closure41(void 0, void 0)), v75_1);
    const v176: any = createComponent;
    const v179: () => any[] = (): any[] => closure42(void 0, void 0);
    const v184: () => void = (): void => {
        closure43(v0_1, v1_1, v2, v5, v6, void 0);
    };
    const v188: any = createObj(method7(patternInput_1[0], US3_US3_1(v168), patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], US7_US7_1(v179), patternInput_1[11], US3_US3_1(v87_1), patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], US3_US3_1(v89_1), patternInput_1[24], US10_US10_1(v176(v173, v174)), patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], US12_US12_1(v184), patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], US3_US3_1(v94_1), patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62]));
    const v189: (arg0: any) => any = v101_1;
    const v190: any = createComponent;
    const v191: any = v190(v189, v188);
    const v192: any = IconButton;
    const patternInput_2: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v256: (arg0: any) => any = v73_1;
    const v257: () => any = (): any => closure44(void 0, void 0);
    const v258: Mut7 = new Mut7(v75_1, v257, v75_1);
    const v260: any = createComponent;
    const v264: () => any[] = (): any[] => closure45(void 0, void 0);
    const v269: () => void = (): void => {
        closure46(v3, void 0);
    };
    const v273: any = createObj(method7(patternInput_2[0], US3_US3_1("Unload"), patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], US7_US7_1(v264), patternInput_2[11], US3_US3_1(v87_1), patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], patternInput_2[18], patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], US3_US3_1(v89_1), patternInput_2[24], US10_US10_1(v260(v256, v258)), patternInput_2[26], patternInput_2[27], patternInput_2[28], patternInput_2[29], patternInput_2[30], patternInput_2[31], patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], US12_US12_1(v269), patternInput_2[40], patternInput_2[41], patternInput_2[42], patternInput_2[43], patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], patternInput_2[50], US3_US3_1(v94_1), patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62]));
    const v274: (arg0: any) => any = v192;
    const v275: any = createComponent;
    return [v100_1, v191, v275(v274, v273)];
}

export function closure32(v0_1: Mut1, v1_1: any, v2: int32, v3: (arg0: boolean) => void, v4: (arg0: boolean) => void, v5: () => boolean, v6: (arg0: boolean) => void, v7: () => boolean, v8: () => any[], unitVar: void): any[] {
    const v11: any = Stack;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v75_1: US2 = v0_1.l9;
    const v85_1: () => any[] = (): any[] => closure33(v0_1, v1_1, v2, v3, v4, v6, v7, void 0);
    const v91_1: string = "6px";
    const v99_1: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v85_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], US3_US3_1("row"), (v75_1.tag === US2_Tag.US2_1) ? (((v75_1.fields[0] === v2) !== true) ? US3_US3_1("none") : US3_US3_0()) : US3_US3_0(), patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], US3_US3_1("absolute"), US3_US3_1(v91_1), patternInput[51], US3_US3_1("3px"), patternInput[53], patternInput[54], patternInput[55], patternInput[56], US3_US3_1(v91_1), patternInput[58], patternInput[59], patternInput[60], US2_US2_1(1), patternInput[62]));
    const v100_1: (arg0: any) => any = v11;
    const v103_1: any = createComponent;
    return [v103_1(v100_1, v99_1), v5() ? <></> : v8];
}

export function closure31(v0_1: US3, v1_1: US3, v2: US5, v3: US3, v4: US3, v5: US3, v6: US3, v7: US3, v8: US3, v9: US6, v10: US7, v11: US3, v12: US3, v13: US6, v14: US8, v15: US3, v16: US3, v17: US3, v18: US9, v19: US6, v20: US3, v21: US3, v22: US3, v23: US3, v24: US3, v25: US10, v26: US3, v27: US3, v28: US3, v29: US10, v30: US3, v31: US3, v32: US3, v33: US3, v34: US3, v35: US3, v36: US3, v37: US3, v38: US11, v39: US12, v40: US11, v41: US3, v42: US3, v43: US3, v44: US3, v45: US3, v46: US3, v47: US3, v48: US3, v49: US3, v50: US3, v51: US3, v52: US3, v53: US3, v54: US3, v55: US3, v56: US10, v57: US3, v58: US3, v59: US8, v60: US3, v61: US2, v62: US3, v63: Mut1, v64: any, v65_1: int32, v66_1: (arg0: boolean) => void, v67_1: (arg0: boolean) => void, v68_1: () => boolean, v69_1: (arg0: boolean) => void, v70_1: () => boolean, unitVar: void): any[] {
    let v75_1: any, patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3], v146: () => any[], v153: any, v154: (arg0: any) => any, v157: any;
    return [(v10.tag === US7_Tag.US7_1) ? ((v75_1 = Box, (patternInput = method5(), (v146 = ((): any[] => closure32(v63, v64, v65_1, v66_1, v67_1, v68_1, v69_1, v70_1, v10.fields[0], void 0)), (v153 = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v146), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], US3_US3_1("flex"), patternInput[18], patternInput[19], US3_US3_1("1"), patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], (v63.l9.tag === US2_Tag.US2_0) ? US3_US3_1("relative") : US3_US3_0(), patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62])), (v154 = (v75_1), (v157 = createComponent, v157(v154, v153)))))))) : <></>];
}

export function closure25(v0_1: US3, v1_1: US3, v2: US5, v3: US3, v4: US3, v5: US3, v6: US3, v7: US3, v8: US3, v9: US6, v10: US7, v11: US3, v12: US3, v13: US6, v14: US8, v15: US3, v16: US3, v17: US3, v18: US9, v19: US6, v20: US3, v21: US3, v22: US3, v23: US3, v24: US3, v25: US10, v26: US3, v27: US3, v28: US3, v29: US10, v30: US3, v31: US3, v32: US3, v33: US3, v34: US3, v35: US3, v36: US3, v37: US3, v38: US11, v39: US12, v40: US11, v41: US3, v42: US3, v43: US3, v44: US3, v45: US3, v46: US3, v47: US3, v48: US3, v49: US3, v50: US3, v51: US3, v52: US3, v53: US3, v54: US3, v55: US3, v56: US10, v57: US3, v58: US3, v59: US8, v60: US3, v61: US2, v62: US3, v63: Mut1, v64: any, v65_1: int32, v66_1: (arg0: boolean) => void, v67_1: () => boolean, v68_1: (arg0: boolean) => void, v69_1: () => boolean, v70_1: (arg0: boolean) => void, v71_1: () => boolean, v72_1: Mut5, unitVar: void): any[] {
    let v77_1: any, patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3], v141: () => any[], v146: any, v147: (arg0: any) => any, v150: any, v154: any, patternInput_1: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3], v221: US2, v226: US3, v231: US3, v236: US3, v241: US3, v246: US3, v252: () => any[], v259: any, v260: (arg0: any) => any, v263: any;
    return [(v67_1() === false) ? ((v77_1 = Box, (patternInput = method5(), (v141 = ((): any[] => closure26(v66_1, v72_1, v63, v64, void 0)), (v146 = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v141), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], US3_US3_1("3px 0"), patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62])), (v147 = (v77_1), (v150 = createComponent, v150(v147, v146)))))))) : ((v154 = Box, (patternInput_1 = method5(), (v221 = (v71_1() ? US2_US2_1(1) : US2_US2_0()), (v226 = (v71_1() ? US3_US3_1("absolute") : US3_US3_0()), (v231 = (v71_1() ? US3_US3_1("0") : US3_US3_0()), (v236 = (v71_1() ? US3_US3_1("0") : US3_US3_0()), (v241 = (v71_1() ? US3_US3_1("0") : US3_US3_0()), (v246 = (v71_1() ? US3_US3_1("0") : US3_US3_0()), (v252 = ((): any[] => closure31(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65_1, v66_1, v68_1, v69_1, v70_1, v71_1, void 0)), (v259 = createObj(method7(patternInput_1[0], patternInput_1[1], patternInput_1[2], v71_1() ? US3_US3_1("$bg") : US3_US3_0(), patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], v241, patternInput_1[9], US7_US7_1(v252), patternInput_1[11], patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], US3_US3_1("flex"), patternInput_1[18], patternInput_1[19], US3_US3_1("1"), patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], v246, patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], v226, v236, patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], v231, patternInput_1[58], patternInput_1[59], patternInput_1[60], v221, patternInput_1[62])), (v260 = (v154), (v263 = createComponent, v263(v260, v259))))))))))))))];
}

export function method14(v0_1: Mut5): any {
    const v1_1: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = v0_1.l3;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const patternInput_1: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = v1_1([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]]);
    const v91_1: US3 = patternInput_1[26];
    const v130: any = useStoreon;
    const v131: any[] = v130();
    const v132: Mut1 = v131[0];
    const v133: any = v131[1];
    const v134: int32 = nonSeeded().Next0() | 0;
    const v135: boolean = v0_1.l0;
    const v138: any = createSignal;
    const v139: any[] = v138(v135);
    let v140: () => boolean;
    const value_4: any = v139[0];
    v140 = (value_4);
    let v141: (arg0: boolean) => void;
    const value_5: any = v139[1];
    v141 = ((arg_1: boolean): void => {
        value_5(arg_1);
    });
    const v142: any = createSignal;
    const v143: any[] = v142(false);
    let v144: () => boolean;
    const value_7: any = v143[0];
    v144 = (value_7);
    let v145: (arg0: boolean) => void;
    const value_8: any = v143[1];
    v145 = ((arg_3: boolean): void => {
        value_8(arg_3);
    });
    const v146: boolean = v0_1.l1;
    const v147: any = createSignal;
    const v148: any[] = v147(v146);
    let v149: () => boolean;
    const value_10: any = v148[0];
    v149 = (value_10);
    let v150: (arg0: boolean) => void;
    const value_11: any = v148[1];
    v150 = ((arg_5: boolean): void => {
        value_11(arg_5);
    });
    const v152: any = on;
    const v153: () => any[] = (): any[] => closure22(v144, void 0);
    const v154: () => void = (): void => {
        closure23(v145, v144, void 0);
    };
    const v155: any = v152(v153, v154);
    const v157: any = createEffect;
    v157(v155);
    if (v0_1.l0 === true) {
        const v160: US13 = v0_1.l2;
        if (v160.tag === US13_Tag.US13_1) {
            const v163: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void = (v: (arg0: Mut1, arg1: Mut1) => void): void => {
                closure24(v132, v133, uncurry(2, v));
            };
            v160.fields[0](v132, v163);
        }
    }
    const v166: any = Box;
    const patternInput_2: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v230: () => any[] = (): any[] => closure25(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], patternInput_1[11], patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], v91_1, patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], v132, v133, v134, v141, v140, v145, v144, v150, v149, v0_1, void 0);
    const v237: any = createObj(method7(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], US7_US7_1(v230), patternInput_2[11], patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], US3_US3_1("flex"), patternInput_2[18], patternInput_2[19], US3_US3_1("1"), patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], v91_1, patternInput_2[27], patternInput_2[28], patternInput_2[29], patternInput_2[30], patternInput_2[31], patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], patternInput_2[41], patternInput_2[42], patternInput_2[43], patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62]));
    const v238: (arg0: any) => any = v166;
    const v240: any = createComponent;
    return v240(v238, v237);
}

export function closure21(unitVar: void, v0_1: Mut5): any {
    return method14(v0_1);
}

export function closure47(v0_1: () => any[], _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], US7_US7_1(v0_1), _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure20(v0_1: Mut4, v1_1: () => boolean, v2: () => any[], unitVar: void): any[] {
    let v19: (arg0: Mut5) => any, v20: (arg0: any) => any, v21: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3], v22: Mut5, v26: any, v6: (arg0: Mut5) => any, v7: (arg0: any) => any, v8: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3], v9: Mut5, v13: any;
    const v3: US14 = v0_1.l2;
    return [(v3.tag === US14_Tag.US14_1) ? (v1_1() ? ((v19 = ((v_1: Mut5): any => closure21(void 0, v_1)), (v20 = (v19), (v21 = ((arg10$0040_1: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure47(v2, arg10$0040_1)), (v22 = (new Mut5(true, false, v0_1.l0, v21)), (v26 = createComponent, v26(v20, v22))))))) : <></>) : ((v3.tag === US14_Tag.US14_2) ? v2 : (v1_1() ? ((v6 = ((v: Mut5): any => closure21(void 0, v)), (v7 = (v6), (v8 = ((arg10$0040: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure47(v2, arg10$0040)), (v9 = (new Mut5(true, false, v0_1.l0, v8)), (v13 = createComponent, v13(v7, v9))))))) : <></>))];
}

export function closure14(v0_1: Mut4, v1_1: US3, v2: US3, v3: US5, v4: US3, v5: US3, v6: US3, v7: US3, v8: US3, v9: US3, v10: US6, v11: US7, v12: US3, v13: US3, v14: US6, v15: US8, v16: US3, v17: US3, v18: US3, v19: US9, v20: US6, v21: US3, v22: US3, v23: US3, v24: US3, v25: US3, v26: US10, v27: US3, v28: US3, v29: US3, v30: US10, v31: US3, v32: US3, v33: US3, v34: US3, v35: US3, v36: US3, v37: US3, v38: US3, v39: US11, v40: US12, v41: US11, v42: US3, v43: US3, v44: US3, v45: US3, v46: US3, v47: US3, v48: US3, v49: US3, v50: US3, v51: US3, v52: US3, v53: US3, v54: US3, v55: US3, v56: US3, v57: US10, v58: US3, v59: US3, v60: US8, v61: US3, v62: US2, v63: US3, v64: (arg0: boolean) => void, v65_1: () => boolean, unitVar: void): any[] {
    let v70_1: any, patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3], v147: () => any[], v160: any, v161: (arg0: any) => any, v164: any, v250: any, patternInput_2: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3], v317: string, v319: () => any[], v339: any, v340: (arg0: any) => any, v343: any, v169: any, patternInput_1: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3], v233: string, v235: () => any[], v241: any, v242: (arg0: any) => any, v245: any;
    return [(v57.tag === US10_Tag.US10_1) ? ((v70_1 = Td, (patternInput = method5(), (v147 = ((): any[] => closure15(v0_1, v64, v65_1, v57.fields[0], void 0)), (v160 = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], US3_US3_1(((v0_1.l2.tag === US14_Tag.US14_2) ? true : v65_1()) ? method13("0px !important", "2px !important") : "0px !important"), US3_US3_1("$neutral5"), patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v147), US3_US3_1("$neutral9"), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], US3_US3_1("flex"), patternInput[18], patternInput[19], patternInput[20], US3_US3_1("column"), US3_US3_1("$sm"), patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], US3_US3_1("3px 20px 0 8px"), patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62])), (v161 = (v70_1), (v164 = createComponent, v164(v161, v160)))))))) : <></>, (v11.tag === US7_Tag.US7_1) ? ((v250 = Td, (patternInput_2 = method5(), (v317 = "0", (v319 = ((): any[] => closure20(v0_1, v65_1, v11.fields[0], void 0)), (v339 = createObj(method7(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], US3_US3_1(v317), patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], US7_US7_1(v319), patternInput_2[11], patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], US3_US3_1("flex"), patternInput_2[18], patternInput_2[19], US3_US3_1("6"), US3_US3_1("column"), US3_US3_1("$sm"), patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], patternInput_2[29], US3_US3_1("$base"), US3_US3_1(v317), patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], US3_US3_1("85vh"), patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], US3_US3_1(v317), patternInput_2[42], US3_US3_1("auto"), US3_US3_1((v45.tag === US3_Tag.US3_1) ? v45.fields[0] : "0"), patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62])), (v340 = (v250), (v343 = createComponent, v343(v340, v339))))))))) : ((v169 = Td, (patternInput_1 = method5(), (v233 = "0", (v235 = ((): any[] => closure19(void 0, void 0)), (v241 = createObj(method7(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], US3_US3_1(v233), patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], US7_US7_1(v235), patternInput_1[11], patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], US3_US3_1("9px"), patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], US3_US3_1(v233), patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62])), (v242 = (v169), (v245 = createComponent, v245(v242, v241)))))))))];
}

export function method12(v0_1: Mut4): any {
    const v1_1: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = v0_1.l1;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const patternInput_1: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = v1_1([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]]);
    const v91_1: US3 = patternInput_1[26];
    const v131: boolean = (v0_1.l2.tag === US14_Tag.US14_0) !== true;
    const v134: any = createSignal;
    const v135: any[] = v134(v131);
    let v136: () => boolean;
    const value_1: any = v135[0];
    v136 = (value_1);
    let v137: (arg0: boolean) => void;
    const value_2: any = v135[1];
    v137 = ((arg_1: boolean): void => {
        value_2(arg_1);
    });
    const v140: any = Tr;
    const patternInput_2: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v211: () => any[] = (): any[] => closure14(v0_1, patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], patternInput_1[11], patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], v91_1, patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62], v137, v136, void 0);
    const v219: any = createObj(method7(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], US3_US3_1("$neutral5"), US3_US3_1("1px 2px"), patternInput_2[8], patternInput_2[9], US7_US7_1(v211), patternInput_2[11], patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], US3_US3_1("flex"), patternInput_2[18], patternInput_2[19], US3_US3_1("1"), US3_US3_1(method13("row", "column")), patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], v91_1, patternInput_2[27], patternInput_2[28], patternInput_2[29], patternInput_2[30], patternInput_2[31], patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], patternInput_2[41], patternInput_2[42], patternInput_2[43], patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62]));
    const v220: (arg0: any) => any = v140;
    const v222: any = createComponent;
    return v222(v220, v219);
}

export function closure13(unitVar: void, v0_1: Mut4): any {
    return method12(v0_1);
}

export function closure56(v0_1: Mut2, unitVar: void): any[] {
    const v1_1: US3 = v0_1.l24;
    return [<>
        {(v1_1.tag === US3_Tag.US3_1) ? v1_1.fields[0] : ""}
    </>];
}

export function closure57(unitVar: void, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], US3_US3_0(), _arg[34], US3_US3_1("-13px"), _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure58(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularLinkExternal;
    return v2;
}

export function closure55(v0_1: Mut2, unitVar: void): any[] {
    const v3: any = Anchor;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const patternInput_1: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = [v0_1.l0, v0_1.l1, v0_1.l2, v0_1.l3, v0_1.l4, v0_1.l5, v0_1.l6, v0_1.l7, v0_1.l8, v0_1.l9, v0_1.l10, v0_1.l11, v0_1.l12, v0_1.l13, v0_1.l14, v0_1.l15, v0_1.l16, v0_1.l17, v0_1.l18, v0_1.l19, v0_1.l20, v0_1.l21, v0_1.l22, v0_1.l23, v0_1.l24, v0_1.l25, v0_1.l26, v0_1.l27, v0_1.l28, v0_1.l29, v0_1.l30, v0_1.l31, v0_1.l32, v0_1.l33, v0_1.l34, v0_1.l35, v0_1.l36, v0_1.l37, v0_1.l38, v0_1.l39, v0_1.l40, v0_1.l41, v0_1.l42, v0_1.l43, v0_1.l44, v0_1.l45, v0_1.l46, v0_1.l47, v0_1.l48, v0_1.l49, v0_1.l50, v0_1.l51, v0_1.l52, v0_1.l53, v0_1.l54, v0_1.l55, v0_1.l56, v0_1.l57, v0_1.l58, v0_1.l59, v0_1.l60, v0_1.l61, v0_1.l62];
    const v132: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], US6_US6_1(true), patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]);
    method16(v132, new Mut2(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], patternInput_1[11], patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62]));
    const patternInput_2: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = [v132.l0, v132.l1, v132.l2, v132.l3, v132.l4, v132.l5, v132.l6, v132.l7, v132.l8, v132.l9, v132.l10, v132.l11, v132.l12, v132.l13, v132.l14, v132.l15, v132.l16, v132.l17, v132.l18, v132.l19, v132.l20, v132.l21, v132.l22, v132.l23, v132.l24, v132.l25, v132.l26, v132.l27, v132.l28, v132.l29, v132.l30, v132.l31, v132.l32, v132.l33, v132.l34, v132.l35, v132.l36, v132.l37, v132.l38, v132.l39, v132.l40, v132.l41, v132.l42, v132.l43, v132.l44, v132.l45, v132.l46, v132.l47, v132.l48, v132.l49, v132.l50, v132.l51, v132.l52, v132.l53, v132.l54, v132.l55, v132.l56, v132.l57, v132.l58, v132.l59, v132.l60, v132.l61, v132.l62];
    const v196: () => any[] = (): any[] => closure56(v0_1, void 0);
    const v199: any = createObj(method7(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], US7_US7_1(v196), patternInput_2[11], patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], patternInput_2[18], patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], patternInput_2[29], patternInput_2[30], patternInput_2[31], patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], patternInput_2[41], patternInput_2[42], patternInput_2[43], patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62]));
    const v200: (arg0: any) => any = v3;
    const v203: any = createComponent;
    const v207: (arg0: Mut7) => any = (v: Mut7): any => closure34(void 0, v);
    const v208: (arg0: any) => any = v207;
    const v209: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040_1: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure57(void 0, arg10$0040_1);
    const v210: () => any = (): any => closure58(void 0, void 0);
    const v211: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040_3: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure36(void 0, arg10$0040_3);
    const v212: Mut7 = new Mut7(v209, v210, v211);
    const v214: any = createComponent;
    return [v203(v200, v199), <>
        &nbsp;
    </>, v214(v208, v212)];
}

export function method20(v0_1: Mut2): any {
    const v3: any = Box;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v67_1: () => any[] = (): any[] => closure55(v0_1, void 0);
    const v70_1: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v67_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]));
    const v71_1: (arg0: any) => any = v3;
    const v74_1: any = createComponent;
    return v74_1(v71_1, v70_1);
}

export function closure54(unitVar: void, v0_1: Mut2): any {
    return method20(v0_1);
}

export function closure59(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure53(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut2) => any = (v: Mut2): any => closure54(void 0, v);
    const v1_1: (arg0: any) => any = v0_1;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v65_1: () => any[] = (): any[] => closure59(void 0, void 0);
    const v69_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v65_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], US3_US3_1("https://github.com/fc1943s/tictactoe_spiral"), patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]);
    v69_1.children = v65_1;
    const v73_1: any = createComponent;
    return [v73_1(v1_1, v69_1)];
}

export function closure52(unitVar: void, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    const v63: () => any[] = (): any[] => closure53(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], US7_US7_1(v63), _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], US3_US3_1("1px 6px"), _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure61(v0_1: string, unitVar: void): any[] {
    const v1_1: (arg0: Mut2) => any = (v: Mut2): any => closure54(void 0, v);
    const v2: (arg0: any) => any = v1_1;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v66_1: () => any[] = (): any[] => closure59(void 0, void 0);
    const v69_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v66_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], US3_US3_1(v0_1), patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]);
    v69_1.children = v66_1;
    const v73_1: any = createComponent;
    return [v73_1(v2, v69_1)];
}

export function closure60(v0_1: string, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    const v64: () => any[] = (): any[] => closure61(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], US7_US7_1(v64), _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], US3_US3_1("1px 6px"), _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure63(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut2) => any = (v: Mut2): any => closure54(void 0, v);
    const v1_1: (arg0: any) => any = v0_1;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v65_1: () => any[] = (): any[] => closure59(void 0, void 0);
    const v69_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v65_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], US3_US3_1("https://fc1943s.github.io/tictactoe_spiral"), patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]);
    v69_1.children = v65_1;
    const v73_1: any = createComponent;
    return [v73_1(v1_1, v69_1)];
}

export function closure62(unitVar: void, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    const v63: () => any[] = (): any[] => closure63(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], US7_US7_1(v63), _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], US3_US3_1("1px 6px"), _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure65(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut2) => any = (v: Mut2): any => closure54(void 0, v);
    const v1_1: (arg0: any) => any = v0_1;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v65_1: () => any[] = (): any[] => closure59(void 0, void 0);
    const v69_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v65_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], US3_US3_1("https://fc1943s.github.io/tictactoe_spiral/docs"), patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]);
    v69_1.children = v65_1;
    const v73_1: any = createComponent;
    return [v73_1(v1_1, v69_1)];
}

export function closure64(unitVar: void, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    const v63: () => any[] = (): any[] => closure65(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], US7_US7_1(v63), _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], US3_US3_1("1px 6px"), _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure51(v0_1: string, unitVar: void): any[] {
    let v2: (arg0: Mut4) => any, v3: (arg0: any) => any, v5: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3], v7: Mut4, v11: any, v14: (arg0: Mut4) => any, v15: (arg0: any) => any, v17: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3], v19: Mut4, v23: any;
    const v26: (arg0: Mut4) => any = (v_2: Mut4): any => closure13(void 0, v_2);
    const v27: (arg0: any) => any = v26;
    const v29: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040_2: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure62(void 0, arg10$0040_2);
    const v31: Mut4 = new Mut4(US13_US13_0(), v29, US14_US14_2());
    const v35: any = createComponent;
    const v37: (arg0: any) => any = v26;
    const v39: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040_3: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure64(void 0, arg10$0040_3);
    const v41: Mut4 = new Mut4(US13_US13_0(), v39, US14_US14_2());
    const v43: any = createComponent;
    return [("" === v0_1) ? ((v2 = ((v: Mut4): any => closure13(void 0, v)), (v3 = (v2), (v5 = ((arg10$0040: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure52(void 0, arg10$0040)), (v7 = (new Mut4(US13_US13_0(), v5, US14_US14_2())), (v11 = createComponent, v11(v3, v7))))))) : ((v14 = ((v_1: Mut4): any => closure13(void 0, v_1)), (v15 = (v14), (v17 = ((arg10$0040_1: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure60(`https://github.com/fc1943s/tictactoe_spiral/tree/${v0_1}`, arg10$0040_1)), (v19 = (new Mut4(US13_US13_0(), v17, US14_US14_2())), (v23 = createComponent, v23(v15, v19))))))), v35(v27, v31), v43(v37, v41)];
}

export function method19(): any {
    const v0_1: any = components_spi.env;
    const v1_1: string = v0_1.CODESPACE_NAME || "";
    const v2: string = v0_1.GITHUB_RUN_ID || "";
    const v3: string = v0_1.GITHUB_SHA || "";
    const v4: any = v0_1.IS_TEST;
    const v6: boolean = (!v4) === false;
    const v7: (arg0: Mut2) => any = (v: Mut2): any => closure9(void 0, v);
    const v8: (arg0: any) => any = v7;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v72_1: () => any[] = (): any[] => closure51(v3, void 0);
    const v74_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v72_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]);
    v74_1.children = v72_1;
    const v78_1: any = createComponent;
    return v78_1(v8, v74_1);
}

export function closure50(unitVar: void, v0_1: Mut2): any {
    return method19();
}

export function closure66(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure49(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut2) => any = (v: Mut2): any => closure50(void 0, v);
    const v1_1: (arg0: any) => any = v0_1;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v65_1: () => any[] = (): any[] => closure66(void 0, void 0);
    const v67_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v65_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]);
    v67_1.children = v65_1;
    const v71_1: any = createComponent;
    return [v71_1(v1_1, v67_1)];
}

export function closure48(unitVar: void, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    const v65_1: () => any[] = (): any[] => closure49(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], US7_US7_1(v65_1), _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US10_US10_1(<>
        Links
    </>), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure75(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Dark
    </>];
}

export function closure76(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Light
    </>];
}

export function closure74(unitVar: void, unitVar_1: void): any[] {
    const v2: any = Radio;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v68_1: () => any[] = (): any[] => closure75(void 0, void 0);
    const v70_1: string = "neutral";
    const v72_1: string = "sm";
    const v76_1: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v68_1), patternInput[11], US3_US3_1(v70_1), patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], US3_US3_1(v72_1), patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], US8_US8_1("dark"), patternInput[60], patternInput[61], patternInput[62]));
    const v77_1: (arg0: any) => any = v2;
    const v80_1: any = createComponent;
    const v81_1: any = v80_1(v77_1, v76_1);
    const v82_1: any = Radio;
    const patternInput_1: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v148: () => any[] = (): any[] => closure76(void 0, void 0);
    const v154: any = createObj(method7(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], US7_US7_1(v148), patternInput_1[11], US3_US3_1(v70_1), patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], US3_US3_1(v72_1), patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], US8_US8_1("light"), patternInput_1[60], patternInput_1[61], patternInput_1[62]));
    const v155: (arg0: any) => any = v82_1;
    const v156: any = createComponent;
    return [v81_1, v156(v155, v154)];
}

export function closure73(unitVar: void, unitVar_1: void): any[] {
    const v2: any = Stack;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v66_1: () => any[] = (): any[] => closure74(void 0, void 0);
    const v73_1: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v66_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], US3_US3_1("row"), patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], US3_US3_1("$4"), patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]));
    const v74_1: (arg0: any) => any = v2;
    const v77_1: any = createComponent;
    return [v77_1(v74_1, v73_1)];
}

export function closure77(v0_1: () => void, v1_1: any): void {
    v0_1();
}

export function closure72(v0_1: () => void, v1_1: () => string, unitVar: void): any[] {
    const v4: any = RadioGroup;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v69_1: () => any[] = (): any[] => closure73(void 0, void 0);
    const v72_1: (arg0: any) => void = (v: any): void => {
        closure77(v0_1, v);
    };
    const v75_1: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v69_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], US3_US3_1(v1_1()), patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], US11_US11_1(v72_1), patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]));
    const v76_1: (arg0: any) => any = v4;
    const v79_1: any = createComponent;
    return [v79_1(v76_1, v75_1)];
}

export function closure71(v0_1: () => void, v1_1: () => string, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    const v67_1: () => any[] = (): any[] => closure72(v0_1, v1_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], US7_US7_1(v67_1), _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], US3_US3_1("5px 6px"), _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US10_US10_1(<>
        Theme
    </>), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure70(v0_1: () => void, v1_1: () => string, unitVar: void): any[] {
    const v2: (arg0: Mut4) => any = (v: Mut4): any => closure13(void 0, v);
    const v3: (arg0: any) => any = v2;
    const v5: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure71(v0_1, v1_1, arg10$0040);
    const v7: Mut4 = new Mut4(US13_US13_0(), v5, US14_US14_2());
    const v11: any = createComponent;
    return [v11(v3, v7)];
}

export function method21(): any {
    const v2: any = useColorMode;
    const v3: any = v2();
    const v4: () => string = v3.colorMode;
    const v5: () => void = v3.toggleColorMode;
    const v6: (arg0: Mut2) => any = (v: Mut2): any => closure9(void 0, v);
    const v7: (arg0: any) => any = v6;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v71_1: () => any[] = (): any[] => closure70(v5, v4, void 0);
    const v73_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v71_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]);
    v73_1.children = v71_1;
    const v77_1: any = createComponent;
    return v77_1(v7, v73_1);
}

export function closure69(unitVar: void, v0_1: Mut2): any {
    return method21();
}

export function closure78(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure68(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut2) => any = (v: Mut2): any => closure69(void 0, v);
    const v1_1: (arg0: any) => any = v0_1;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v65_1: () => any[] = (): any[] => closure78(void 0, void 0);
    const v67_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v65_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]);
    v67_1.children = v65_1;
    const v71_1: any = createComponent;
    return [v71_1(v1_1, v67_1)];
}

export function closure67(unitVar: void, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    const v65_1: () => any[] = (): any[] => closure68(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], US7_US7_1(v65_1), _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US10_US10_1(<>
        Settings
    </>), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure90(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure91(v0_1: Mut8, v1_1: Mut1, v2: any, v3: any): void {
    const v4: string = v3.currentTarget.value;
    const v7: Mut1 = createObj(fill(new Array(0), 0, 0, null));
    v0_1.l1(v1_1, v7, US3_US3_1(v4));
    toConsole(interpolate("%A%P()", [["use_store dispatch", "new_state(new):", JSON.stringify(v7)]]));
    v2("set", v7);
}

export function method24(v0_1: Mut8): any {
    const v3: any = useStoreon;
    const v4: any[] = v3();
    const v5: Mut1 = v4[0];
    const v6: any = v4[1];
    const v9: any = Input;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v74_1: US3 = v0_1.l0(v5);
    const v75_1: string = void 0;
    const v79_1: () => any[] = (): any[] => closure90(void 0, void 0);
    const v81_1: (arg0: any) => void = (v: any): void => {
        closure91(v0_1, v5, v6, v);
    };
    const v89_1: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v79_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], US11_US11_1(v81_1), patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], US3_US3_1("xs"), patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], US3_US3_1("text"), US8_US8_1((v74_1.tag === US3_Tag.US3_1) ? v74_1.fields[0] : v75_1), patternInput[60], patternInput[61], patternInput[62]));
    const v90_1: (arg0: any) => any = v9;
    const v93_1: any = createComponent;
    return v93_1(v90_1, v89_1);
}

export function closure89(unitVar: void, v0_1: Mut8): any {
    return method24(v0_1);
}

export function closure92(unitVar: void, v0_1: Mut1): US3 {
    return v0_1.l2;
}

export function closure95(v0_1: Mut1, v1_1: US3): void {
    v0_1.l2 = v1_1;
}

export function closure94(unitVar: void, v0_1: Mut1): (arg0: US3) => void {
    return (v: US3): void => {
        closure95(v0_1, v);
    };
}

export function closure93(unitVar: void, v0_1: Mut1): (arg0: Mut1, arg1: US3) => void {
    return (v: Mut1): (arg0: US3) => void => closure94(void 0, v);
}

export function closure88(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut8) => any = (v: Mut8): any => closure89(void 0, v);
    const v1_1: (arg0: any) => any = v0_1;
    const v2: (arg0: Mut1) => US3 = (v_1: Mut1): US3 => closure92(void 0, v_1);
    const v3: (arg0: Mut1, arg1: Mut1, arg2: US3) => void = (v_2: Mut1): (arg0: Mut1, arg1: US3) => void => closure93(void 0, v_2);
    const v4: Mut8 = new Mut8(v2, uncurry(3, v3));
    const v8: any = createComponent;
    return [v8(v1_1, v4)];
}

export function closure87(unitVar: void, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    const v65_1: () => any[] = (): any[] => closure88(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], US7_US7_1(v65_1), _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], US3_US3_1("3px"), _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US10_US10_1(<>
        Token
    </>), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure98(unitVar: void, v0_1: Mut1): US3 {
    return v0_1.l3;
}

export function closure101(v0_1: Mut1, v1_1: US3): void {
    v0_1.l3 = v1_1;
}

export function closure100(unitVar: void, v0_1: Mut1): (arg0: US3) => void {
    return (v: US3): void => {
        closure101(v0_1, v);
    };
}

export function closure99(unitVar: void, v0_1: Mut1): (arg0: Mut1, arg1: US3) => void {
    return (v: Mut1): (arg0: US3) => void => closure100(void 0, v);
}

export function closure97(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut8) => any = (v: Mut8): any => closure89(void 0, v);
    const v1_1: (arg0: any) => any = v0_1;
    const v2: (arg0: Mut1) => US3 = (v_1: Mut1): US3 => closure98(void 0, v_1);
    const v3: (arg0: Mut1, arg1: Mut1, arg2: US3) => void = (v_2: Mut1): (arg0: Mut1, arg1: US3) => void => closure99(void 0, v_2);
    const v4: Mut8 = new Mut8(v2, uncurry(3, v3));
    const v8: any = createComponent;
    return [v8(v1_1, v4)];
}

export function closure96(unitVar: void, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    const v65_1: () => any[] = (): any[] => closure97(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], US7_US7_1(v65_1), _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], US3_US3_1("3px"), _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US10_US10_1(<>
        URL
    </>), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure105(v0_1: Mut9, v1_1: Mut1, v2: any, v3: any): void {
    const v4: int32 = v3.currentTarget.value | 0;
    const v7: Mut1 = createObj(fill(new Array(0), 0, 0, null));
    v0_1.l1(v1_1, v7, US2_US2_1(v4));
    toConsole(interpolate("%A%P()", [["use_store dispatch", "new_state(new):", JSON.stringify(v7)]]));
    v2("set", v7);
}

export function method25(v0_1: Mut9): any {
    const v3: any = useStoreon;
    const v4: any[] = v3();
    const v5: Mut1 = v4[0];
    const v6: any = v4[1];
    const v9: any = Input;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v74_1: US2 = v0_1.l0(v5);
    const v75_1: int32 = (void 0) | 0;
    const v79_1: () => any[] = (): any[] => closure90(void 0, void 0);
    const v81_1: (arg0: any) => void = (v: any): void => {
        closure105(v0_1, v5, v6, v);
    };
    const v89_1: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v79_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], US11_US11_1(v81_1), patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], US3_US3_1("xs"), patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], US3_US3_1("text"), US8_US8_1((v74_1.tag === US2_Tag.US2_1) ? v74_1.fields[0] : v75_1), patternInput[60], patternInput[61], patternInput[62]));
    const v90_1: (arg0: any) => any = v9;
    const v93_1: any = createComponent;
    return v93_1(v90_1, v89_1);
}

export function closure104(unitVar: void, v0_1: Mut9): any {
    return method25(v0_1);
}

export function closure106(unitVar: void, v0_1: Mut1): US2 {
    return v0_1.l1;
}

export function closure109(v0_1: Mut1, v1_1: US2): void {
    v0_1.l1 = v1_1;
}

export function closure108(unitVar: void, v0_1: Mut1): (arg0: US2) => void {
    return (v: US2): void => {
        closure109(v0_1, v);
    };
}

export function closure107(unitVar: void, v0_1: Mut1): (arg0: Mut1, arg1: US2) => void {
    return (v: Mut1): (arg0: US2) => void => closure108(void 0, v);
}

export function closure103(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut9) => any = (v: Mut9): any => closure104(void 0, v);
    const v1_1: (arg0: any) => any = v0_1;
    const v2: (arg0: Mut1) => US2 = (v_1: Mut1): US2 => closure106(void 0, v_1);
    const v3: (arg0: Mut1, arg1: Mut1, arg2: US2) => void = (v_2: Mut1): (arg0: Mut1, arg1: US2) => void => closure107(void 0, v_2);
    const v4: Mut9 = new Mut9(v2, uncurry(3, v3));
    const v8: any = createComponent;
    return [v8(v1_1, v4)];
}

export function closure102(unitVar: void, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    const v65_1: () => any[] = (): any[] => closure103(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], US7_US7_1(v65_1), _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], US3_US3_1("3px"), _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US10_US10_1(<>
        Port
    </>), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure86(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut4) => any = (v: Mut4): any => closure13(void 0, v);
    const v1_1: (arg0: any) => any = v0_1;
    const v3: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure87(void 0, arg10$0040);
    const v5: Mut4 = new Mut4(US13_US13_0(), v3, US14_US14_2());
    const v9: any = createComponent;
    const v11: (arg0: any) => any = v0_1;
    const v13: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040_1: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure96(void 0, arg10$0040_1);
    const v15: Mut4 = new Mut4(US13_US13_0(), v13, US14_US14_2());
    const v17: any = createComponent;
    const v19: (arg0: any) => any = v0_1;
    const v21: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040_2: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure102(void 0, arg10$0040_2);
    const v23: Mut4 = new Mut4(US13_US13_0(), v21, US14_US14_2());
    const v25: any = createComponent;
    return [v9(v1_1, v5), v17(v11, v15), v25(v19, v23)];
}

export function method23(): any {
    const v0_1: (arg0: Mut2) => any = (v: Mut2): any => closure9(void 0, v);
    const v1_1: (arg0: any) => any = v0_1;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v65_1: () => any[] = (): any[] => closure86(void 0, void 0);
    const v67_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v65_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]);
    v67_1.children = v65_1;
    const v71_1: any = createComponent;
    return v71_1(v1_1, v67_1);
}

export function closure85(unitVar: void, v0_1: Mut2): any {
    return method23();
}

export function closure110(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure84(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut2) => any = (v: Mut2): any => closure85(void 0, v);
    const v1_1: (arg0: any) => any = v0_1;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v65_1: () => any[] = (): any[] => closure110(void 0, void 0);
    const v67_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v65_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]);
    v67_1.children = v65_1;
    const v71_1: any = createComponent;
    return [v71_1(v1_1, v67_1)];
}

export function closure83(unitVar: void, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    const v65_1: () => any[] = (): any[] => closure84(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], US7_US7_1(v65_1), _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US10_US10_1(<>
        Connection
    </>), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure121(v0_1: US0, v1_1: string, v2: string, v3: string, v4: Mut1): US3 {
    return US3_US3_1(v1_1);
}

export function closure124(v0_1: US0, v1_1: string, v2: string, v3: string, v4: Mut1, v5: Mut1, v6: US3): void {
    let copyOfStruct: US0, copyOfStruct_1: US0;
    const v7: [US0, string, string, string][] = v4.l0;
    const v11: int32 = v7.length | 0;
    const v12: [US0, string, string, string][] = fill(new Array(v11), 0, v11, null);
    const v13: Mut6 = new Mut6(0);
    while (method17(v11, v13)) {
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

export function closure123(v0_1: US0, v1_1: string, v2: string, v3: string, v4: Mut1, v5: Mut1): (arg0: US3) => void {
    return (v: US3): void => {
        closure124(v0_1, v1_1, v2, v3, v4, v5, v);
    };
}

export function closure122(v0_1: US0, v1_1: string, v2: string, v3: string, v4: Mut1): (arg0: Mut1, arg1: US3) => void {
    return (v: Mut1): (arg0: US3) => void => closure123(v0_1, v1_1, v2, v3, v4, v);
}

export function closure120(v0_1: US0, v1_1: string, v2: string, v3: string, unitVar: void): any[] {
    const v4: (arg0: Mut8) => any = (v: Mut8): any => closure89(void 0, v);
    const v5: (arg0: any) => any = v4;
    const v6: (arg0: Mut1) => US3 = (v_1: Mut1): US3 => closure121(v0_1, v1_1, v2, v3, v_1);
    const v7: (arg0: Mut1, arg1: Mut1, arg2: US3) => void = (v_2: Mut1): (arg0: Mut1, arg1: US3) => void => closure122(v0_1, v1_1, v2, v3, v_2);
    const v8: Mut8 = new Mut8(v6, uncurry(3, v7));
    const v12: any = createComponent;
    return [v12(v5, v8)];
}

export function closure119(v0_1: US0, v1_1: string, v2: string, v3: string, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    const v69_1: () => any[] = (): any[] => closure120(v0_1, v1_1, v2, v3, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], US7_US7_1(v69_1), _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], US3_US3_1("3px"), _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US10_US10_1(<>
        Address
    </>), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure127(v0_1: US0, v1_1: string, v2: string, v3: string, v4: Mut1): US3 {
    return US3_US3_1(v3);
}

export function closure130(v0_1: US0, v1_1: string, v2: string, v3: string, v4: Mut1, v5: Mut1, v6: US3): void {
    let copyOfStruct: US0, copyOfStruct_1: US0;
    const v7: [US0, string, string, string][] = v4.l0;
    const v11: int32 = v7.length | 0;
    const v12: [US0, string, string, string][] = fill(new Array(v11), 0, v11, null);
    const v13: Mut6 = new Mut6(0);
    while (method17(v11, v13)) {
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

export function closure129(v0_1: US0, v1_1: string, v2: string, v3: string, v4: Mut1, v5: Mut1): (arg0: US3) => void {
    return (v: US3): void => {
        closure130(v0_1, v1_1, v2, v3, v4, v5, v);
    };
}

export function closure128(v0_1: US0, v1_1: string, v2: string, v3: string, v4: Mut1): (arg0: Mut1, arg1: US3) => void {
    return (v: Mut1): (arg0: US3) => void => closure129(v0_1, v1_1, v2, v3, v4, v);
}

export function closure126(v0_1: US0, v1_1: string, v2: string, v3: string, unitVar: void): any[] {
    const v4: (arg0: Mut8) => any = (v: Mut8): any => closure89(void 0, v);
    const v5: (arg0: any) => any = v4;
    const v6: (arg0: Mut1) => US3 = (v_1: Mut1): US3 => closure127(v0_1, v1_1, v2, v3, v_1);
    const v7: (arg0: Mut1, arg1: Mut1, arg2: US3) => void = (v_2: Mut1): (arg0: Mut1, arg1: US3) => void => closure128(v0_1, v1_1, v2, v3, v_2);
    const v8: Mut8 = new Mut8(v6, uncurry(3, v7));
    const v12: any = createComponent;
    return [v12(v5, v8)];
}

export function closure125(v0_1: US0, v1_1: string, v2: string, v3: string, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    const v69_1: () => any[] = (): any[] => closure126(v0_1, v1_1, v2, v3, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], US7_US7_1(v69_1), _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], US3_US3_1("3px"), _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US10_US10_1(<>
        Private Key
    </>), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure118(v0_1: US0, v1_1: string, v2: string, v3: string, unitVar: void): any[] {
    const v4: (arg0: Mut4) => any = (v: Mut4): any => closure13(void 0, v);
    const v5: (arg0: any) => any = v4;
    const v7: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure119(v0_1, v1_1, v2, v3, arg10$0040);
    const v9: Mut4 = new Mut4(US13_US13_0(), v7, US14_US14_2());
    const v13: any = createComponent;
    const v15: (arg0: any) => any = v4;
    const v17: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040_1: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure125(v0_1, v1_1, v2, v3, arg10$0040_1);
    const v19: Mut4 = new Mut4(US13_US13_0(), v17, US14_US14_2());
    const v21: any = createComponent;
    return [v13(v5, v9), v21(v15, v19)];
}

export function closure117(v0_1: US0, v1_1: string, v2: string, v3: string, unitVar: void): any[] {
    const v4: (arg0: Mut2) => any = (v: Mut2): any => closure9(void 0, v);
    const v5: (arg0: any) => any = v4;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v69_1: () => any[] = (): any[] => closure118(v0_1, v1_1, v2, v3, void 0);
    const v71_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v69_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]);
    v71_1.children = v69_1;
    const v75_1: any = createComponent;
    return [v75_1(v5, v71_1)];
}

export function closure116(v0_1: US0, v1_1: string, v2: string, v3: string, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    const v74_1: () => any[] = (): any[] => closure117(v0_1, v1_1, v2, v3, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], US7_US7_1(v74_1), _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US10_US10_1(<>
        {(v0_1.tag === US0_Tag.US0_1) ? ((v0_1.fields[0].tag === US1_Tag.US1_1) ? "x" : "o") : "admin"}
    </>), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure115(unitVar: void, _arg: [US0, string, string, string]): any[] {
    const v4: (arg0: Mut4) => any = (v: Mut4): any => closure13(void 0, v);
    const v5: (arg0: any) => any = v4;
    const v7: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure116(_arg[0], _arg[1], _arg[2], _arg[3], arg10$0040);
    const v9: Mut4 = new Mut4(US13_US13_0(), v7, US14_US14_2());
    const v13: any = createComponent;
    return [v13(v5, v9)];
}

export function closure114(v0_1: Mut1, unitVar: void): any[] {
    const patternInput: [[US0, string, string, string][], US2, US3, US3] = [v0_1.l0, v0_1.l1, v0_1.l2, v0_1.l3];
    const v7: any = For;
    const v8: (arg0: [US0, string, string, string]) => any[] = (arg10$0040: [US0, string, string, string]): any[] => closure115(void 0, arg10$0040);
    const v9: () => any[] = v8;
    const patternInput_1: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v77_1: any = createObj(method7(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], US7_US7_1(v9), patternInput_1[11], patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], US9_US9_1(patternInput[0]), patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62]));
    const v78_1: (arg0: any) => any = v7;
    const v80_1: any = createComponent;
    return [v80_1(v78_1, v77_1)];
}

export function method26(): any {
    const v2: any = useStoreon;
    const v3: any[] = v2();
    const v4: Mut1 = v3[0];
    const v5: any = v3[1];
    const v6: (arg0: Mut2) => any = (v: Mut2): any => closure9(void 0, v);
    const v7: (arg0: any) => any = v6;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v71_1: () => any[] = (): any[] => closure114(v4, void 0);
    const v73_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v71_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]);
    v73_1.children = v71_1;
    const v77_1: any = createComponent;
    return v77_1(v7, v73_1);
}

export function closure113(unitVar: void, v0_1: Mut2): any {
    return method26();
}

export function closure131(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure112(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut2) => any = (v: Mut2): any => closure113(void 0, v);
    const v1_1: (arg0: any) => any = v0_1;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v65_1: () => any[] = (): any[] => closure131(void 0, void 0);
    const v67_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v65_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]);
    v67_1.children = v65_1;
    const v71_1: any = createComponent;
    return [v71_1(v1_1, v67_1)];
}

export function closure111(unitVar: void, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    const v65_1: () => any[] = (): any[] => closure112(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], US7_US7_1(v65_1), _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US10_US10_1(<>
        Accounts
    </>), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure134(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure133(unitVar: void, unitVar_1: void): any[] {
    const v2: any = hope;
    const v3: any = v2.iframe;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v71_1: () => any[] = (): any[] => closure134(void 0, void 0);
    const v81_1: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], US3_US3_1("#aaa"), patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v71_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], US3_US3_1("1"), patternInput[21], patternInput[22], US3_US3_1("350px"), patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], US3_US3_1("https://bank.testnet.algorand.network"), patternInput[54], patternInput[55], US10_US10_1(<>
        algorand testnet bank
    </>), patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]));
    const v82_1: (arg0: any) => any = v3;
    const v85_1: any = createComponent;
    return [v85_1(v82_1, v81_1)];
}

export function closure132(unitVar: void, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    const v65_1: () => any[] = (): any[] => closure133(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], US7_US7_1(v65_1), _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US10_US10_1(<>
        Testnet Bank Dispenser
    </>), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure82(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut4) => any = (v: Mut4): any => closure13(void 0, v);
    const v1_1: (arg0: any) => any = v0_1;
    const v3: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure83(void 0, arg10$0040);
    const v5: Mut4 = new Mut4(US13_US13_0(), v3, US14_US14_2());
    const v9: any = createComponent;
    const v11: (arg0: any) => any = v0_1;
    const v13: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040_1: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure111(void 0, arg10$0040_1);
    const v15: Mut4 = new Mut4(US13_US13_0(), v13, US14_US14_2());
    const v17: any = createComponent;
    const v19: (arg0: any) => any = v0_1;
    const v21: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040_2: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure132(void 0, arg10$0040_2);
    const v23: Mut4 = new Mut4(US13_US13_0(), v21, US14_US14_0());
    const v25: any = createComponent;
    return [v9(v1_1, v5), v17(v11, v15), v25(v19, v23)];
}

export function method22(): any {
    const v0_1: (arg0: Mut2) => any = (v: Mut2): any => closure9(void 0, v);
    const v1_1: (arg0: any) => any = v0_1;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v65_1: () => any[] = (): any[] => closure82(void 0, void 0);
    const v67_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v65_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]);
    v67_1.children = v65_1;
    const v71_1: any = createComponent;
    return v71_1(v1_1, v67_1);
}

export function closure81(unitVar: void, v0_1: Mut2): any {
    return method22();
}

export function closure135(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure80(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut2) => any = (v: Mut2): any => closure81(void 0, v);
    const v1_1: (arg0: any) => any = v0_1;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v65_1: () => any[] = (): any[] => closure135(void 0, void 0);
    const v67_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v65_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]);
    v67_1.children = v65_1;
    const v71_1: any = createComponent;
    return [v71_1(v1_1, v67_1)];
}

export function closure79(unitVar: void, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    const v65_1: () => any[] = (): any[] => closure80(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], US7_US7_1(v65_1), _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], US3_US3_1("db"), _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US10_US10_1(<>
        Chain
    </>), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure143(v0_1: Mut1, v1_1: Mut1): void {
    const v2: string = JSON.stringify(v0_1);
    const v3: string = JSON.stringify(v1_1);
    const patternInput: [[US4, int32, string, string][], [US4, US4][]] = [v1_1.l4, v1_1.l5];
    toConsole(interpolate("%A%P()", [["database row on_load", "old_state:", v2, "state:", v3, "state.db.status:", JSON.stringify(patternInput[1])]]));
    const v12: [US4, US4][] = v0_1.l5;
    const v15: [US4, US4][] = [[US4_US4_1(), US4_US4_1()]];
    const v16: int32 = v12.length | 0;
    const v18: int32 = (v16 + v15.length) | 0;
    const v19: [US4, US4][] = fill(new Array(v18), 0, v18, null);
    const v20: Mut6 = new Mut6(0);
    while (method17(v18, v20)) {
        const v22: int32 = v20.l0 | 0;
        let patternInput_4: [US4, US4];
        if (v22 < v16) {
            const patternInput_2: [US4, US4] = v12[v22];
            patternInput_4 = [patternInput_2[0], patternInput_2[1]];
        }
        else {
            const v26: int32 = (v22 - v16) | 0;
            const patternInput_3: [US4, US4] = v15[v26];
            patternInput_4 = [patternInput_3[0], patternInput_3[1]];
        }
        v19[v22] = [patternInput_4[0], patternInput_4[1]];
        const v31: int32 = (v22 + 1) | 0;
        v20.l0 = (v31 | 0);
    }
    v1_1.l5 = v19;
}

export function closure142(unitVar: void, v0_1: Mut1): (arg0: Mut1) => void {
    return (v: Mut1): void => {
        closure143(v0_1, v);
    };
}

export function closure141(unitVar: void, v0_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void): void {
    const v1_1: (arg0: Mut1, arg1: Mut1) => void = (v: Mut1): (arg0: Mut1) => void => closure142(void 0, v);
    v0_1(v1_1);
}

export function closure140(unitVar: void, v0_1: Mut1): (arg0: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void {
    return (v: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void): void => {
        closure141(void 0, v);
    };
}

export function method30(v0_1: int32, v1_1: Mut12): boolean {
    return v1_1.l0 < v0_1;
}

export function closure151(v0_1: Mut11, v1_1: Mut1): US3 {
    const v2: [US4, int32, string, string][] = v1_1.l4;
    const v4: int32 = v2.length | 0;
    const v6: Mut12 = new Mut12(0, US3_US3_0());
    while (method30(v4, v6)) {
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

export function method31(v0_1: int32, v1_1: Mut13): boolean {
    return v1_1.l0 < v0_1;
}

export function method32(): [US4, int32, string, string] {
    const v1_1: string = "";
    return [US4_US4_1(), 0, v1_1, v1_1];
}

export function closure154(v0_1: Mut11, v1_1: Mut1, v2: Mut1, v3: US3): void {
    const v4: [US4, int32, string, string][] = v1_1.l4;
    const v6: [US4, int32, string, string][] = v1_1.l4;
    const v8: int32 = v6.length | 0;
    const v10: Mut13 = new Mut13(0, US15_US15_0());
    while (method31(v8, v10)) {
        const v12: int32 = v10.l0 | 0;
        const v15: int32 = ((op_UnaryNegation_Int32(v12) + v8) - 1) | 0;
        const v16: US15 = v10.l1;
        const patternInput_2: [US4, int32, string, string] = v6[v15];
        const v17: US4 = patternInput_2[0];
        let v30: US15;
        if (v16.tag === US15_Tag.US15_1) {
            v30 = v16;
        }
        else {
            const v21: US4 = v0_1.l0;
            v30 = (((v17.tag === US4_Tag.US4_1) ? (v21.tag === US4_Tag.US4_1) : (v21.tag === US4_Tag.US4_0)) ? US15_US15_1(v17, patternInput_2[1], patternInput_2[2], patternInput_2[3]) : US15_US15_0());
        }
        const v31: int32 = (v12 + 1) | 0;
        v10.l0 = (v31 | 0);
        v10.l1 = v30;
    }
    const v32: US15 = v10.l1;
    const patternInput_3: [US4, int32, string, string] = method32();
    const patternInput_4: [US4, int32, string, string] = (v32.tag === US15_Tag.US15_1) ? [v32.fields[0], v32.fields[1], v32.fields[2], v32.fields[3]] : [patternInput_3[0], patternInput_3[1], patternInput_3[2], patternInput_3[3]];
    const patternInput_5: [US4, int32, string, string] = v0_1.l2([patternInput_4[0], patternInput_4[1], patternInput_4[2], patternInput_4[3]], v3);
    const v51: [US4, int32, string, string][] = [[patternInput_5[0], patternInput_5[1], patternInput_5[2], patternInput_5[3]]];
    const v52: int32 = v4.length | 0;
    const v54: int32 = (v52 + v51.length) | 0;
    const v55: [US4, int32, string, string][] = fill(new Array(v54), 0, v54, null);
    const v56: Mut6 = new Mut6(0);
    while (method17(v54, v56)) {
        const v58: int32 = v56.l0 | 0;
        let patternInput_8: [US4, int32, string, string];
        if (v58 < v52) {
            const patternInput_6: [US4, int32, string, string] = v4[v58];
            patternInput_8 = [patternInput_6[0], patternInput_6[1], patternInput_6[2], patternInput_6[3]];
        }
        else {
            const v64: int32 = (v58 - v52) | 0;
            const patternInput_7: [US4, int32, string, string] = v51[v64];
            patternInput_8 = [patternInput_7[0], patternInput_7[1], patternInput_7[2], patternInput_7[3]];
        }
        v55[v58] = [patternInput_8[0], patternInput_8[1], patternInput_8[2], patternInput_8[3]];
        const v73_1: int32 = (v58 + 1) | 0;
        v56.l0 = (v73_1 | 0);
    }
    v2.l4 = v55;
}

export function closure153(v0_1: Mut11, v1_1: Mut1, v2: Mut1): (arg0: US3) => void {
    return (v: US3): void => {
        closure154(v0_1, v1_1, v2, v);
    };
}

export function closure152(v0_1: Mut11, v1_1: Mut1): (arg0: Mut1, arg1: US3) => void {
    return (v: Mut1): (arg0: US3) => void => closure153(v0_1, v1_1, v);
}

export function method29(v0_1: Mut11): any {
    const v1_1: (arg0: Mut8) => any = (v: Mut8): any => closure89(void 0, v);
    const v2: (arg0: any) => any = v1_1;
    const v3: (arg0: Mut1) => US3 = (v_1: Mut1): US3 => closure151(v0_1, v_1);
    const v4: (arg0: Mut1, arg1: Mut1, arg2: US3) => void = (v_2: Mut1): (arg0: Mut1, arg1: US3) => void => closure152(v0_1, v_2);
    const v5: Mut8 = new Mut8(v3, uncurry(3, v4));
    const v9: any = createComponent;
    return v9(v2, v5);
}

export function closure150(unitVar: void, v0_1: Mut11): any {
    return method29(v0_1);
}

export function closure155(unitVar: void, _arg: [US4, int32, string, string]): US3 {
    return US3_US3_1(_arg[2]);
}

export function closure157(v0_1: Mut10, v1_1: US4, v2: int32, v3: string, v4: string, v5: US3): [US4, int32, string, string] {
    return [v0_1.l0, v2, (v5.tag === US3_Tag.US3_1) ? v5.fields[0] : "", v4];
}

export function closure156(v0_1: Mut10, _arg: [US4, int32, string, string]): (arg0: US3) => [US4, int32, string, string] {
    return (v: US3): [US4, int32, string, string] => closure157(v0_1, _arg[0], _arg[1], _arg[2], _arg[3], v);
}

export function closure149(v0_1: Mut10, unitVar: void): any[] {
    const v2: (arg0: Mut11) => any = (v: Mut11): any => closure150(void 0, v);
    const v3: (arg0: any) => any = v2;
    const v4: (arg0: [US4, int32, string, string]) => US3 = (arg10$0040: [US4, int32, string, string]): US3 => closure155(void 0, arg10$0040);
    const v5: (arg0: [US4, int32, string, string], arg1: US3) => [US4, int32, string, string] = (arg10$0040_1: [US4, int32, string, string]): (arg0: US3) => [US4, int32, string, string] => closure156(v0_1, arg10$0040_1);
    const v6: Mut11 = new Mut11(v0_1.l0, v4, uncurry(2, v5));
    const v10: any = createComponent;
    return [v10(v3, v6)];
}

export function closure148(v0_1: Mut10, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    const v66_1: () => any[] = (): any[] => closure149(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], US7_US7_1(v66_1), _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], US3_US3_1("3px"), _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US10_US10_1(<>
        URL
    </>), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function method34(v0_1: int32, v1_1: Mut15): boolean {
    return v1_1.l0 < v0_1;
}

export function closure161(v0_1: Mut14, v1_1: Mut1): US2 {
    const v2: [US4, int32, string, string][] = v1_1.l4;
    const v4: int32 = v2.length | 0;
    const v6: Mut15 = new Mut15(0, US2_US2_0());
    while (method34(v4, v6)) {
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

export function closure164(v0_1: Mut14, v1_1: Mut1, v2: Mut1, v3: US2): void {
    const v4: [US4, int32, string, string][] = v1_1.l4;
    const v6: [US4, int32, string, string][] = v1_1.l4;
    const v8: int32 = v6.length | 0;
    const v10: Mut13 = new Mut13(0, US15_US15_0());
    while (method31(v8, v10)) {
        const v12: int32 = v10.l0 | 0;
        const v15: int32 = ((op_UnaryNegation_Int32(v12) + v8) - 1) | 0;
        const v16: US15 = v10.l1;
        const patternInput_2: [US4, int32, string, string] = v6[v15];
        const v17: US4 = patternInput_2[0];
        let v30: US15;
        if (v16.tag === US15_Tag.US15_1) {
            v30 = v16;
        }
        else {
            const v21: US4 = v0_1.l0;
            v30 = (((v17.tag === US4_Tag.US4_1) ? (v21.tag === US4_Tag.US4_1) : (v21.tag === US4_Tag.US4_0)) ? US15_US15_1(v17, patternInput_2[1], patternInput_2[2], patternInput_2[3]) : US15_US15_0());
        }
        const v31: int32 = (v12 + 1) | 0;
        v10.l0 = (v31 | 0);
        v10.l1 = v30;
    }
    const v32: US15 = v10.l1;
    const patternInput_3: [US4, int32, string, string] = method32();
    const patternInput_4: [US4, int32, string, string] = (v32.tag === US15_Tag.US15_1) ? [v32.fields[0], v32.fields[1], v32.fields[2], v32.fields[3]] : [patternInput_3[0], patternInput_3[1], patternInput_3[2], patternInput_3[3]];
    const patternInput_5: [US4, int32, string, string] = v0_1.l2([patternInput_4[0], patternInput_4[1], patternInput_4[2], patternInput_4[3]], v3);
    const v51: [US4, int32, string, string][] = [[patternInput_5[0], patternInput_5[1], patternInput_5[2], patternInput_5[3]]];
    const v52: int32 = v4.length | 0;
    const v54: int32 = (v52 + v51.length) | 0;
    const v55: [US4, int32, string, string][] = fill(new Array(v54), 0, v54, null);
    const v56: Mut6 = new Mut6(0);
    while (method17(v54, v56)) {
        const v58: int32 = v56.l0 | 0;
        let patternInput_8: [US4, int32, string, string];
        if (v58 < v52) {
            const patternInput_6: [US4, int32, string, string] = v4[v58];
            patternInput_8 = [patternInput_6[0], patternInput_6[1], patternInput_6[2], patternInput_6[3]];
        }
        else {
            const v64: int32 = (v58 - v52) | 0;
            const patternInput_7: [US4, int32, string, string] = v51[v64];
            patternInput_8 = [patternInput_7[0], patternInput_7[1], patternInput_7[2], patternInput_7[3]];
        }
        v55[v58] = [patternInput_8[0], patternInput_8[1], patternInput_8[2], patternInput_8[3]];
        const v73_1: int32 = (v58 + 1) | 0;
        v56.l0 = (v73_1 | 0);
    }
    v2.l4 = v55;
}

export function closure163(v0_1: Mut14, v1_1: Mut1, v2: Mut1): (arg0: US2) => void {
    return (v: US2): void => {
        closure164(v0_1, v1_1, v2, v);
    };
}

export function closure162(v0_1: Mut14, v1_1: Mut1): (arg0: Mut1, arg1: US2) => void {
    return (v: Mut1): (arg0: US2) => void => closure163(v0_1, v1_1, v);
}

export function method33(v0_1: Mut14): any {
    const v1_1: (arg0: Mut9) => any = (v: Mut9): any => closure104(void 0, v);
    const v2: (arg0: any) => any = v1_1;
    const v3: (arg0: Mut1) => US2 = (v_1: Mut1): US2 => closure161(v0_1, v_1);
    const v4: (arg0: Mut1, arg1: Mut1, arg2: US2) => void = (v_2: Mut1): (arg0: Mut1, arg1: US2) => void => closure162(v0_1, v_2);
    const v5: Mut9 = new Mut9(v3, uncurry(3, v4));
    const v9: any = createComponent;
    return v9(v2, v5);
}

export function closure160(unitVar: void, v0_1: Mut14): any {
    return method33(v0_1);
}

export function closure165(unitVar: void, _arg: [US4, int32, string, string]): US2 {
    return US2_US2_1(_arg[1]);
}

export function closure167(v0_1: Mut10, v1_1: US4, v2: int32, v3: string, v4: string, v5: US2): [US4, int32, string, string] {
    return [v0_1.l0, (v5.tag === US2_Tag.US2_1) ? v5.fields[0] : 0, v3, v4];
}

export function closure166(v0_1: Mut10, _arg: [US4, int32, string, string]): (arg0: US2) => [US4, int32, string, string] {
    return (v: US2): [US4, int32, string, string] => closure167(v0_1, _arg[0], _arg[1], _arg[2], _arg[3], v);
}

export function closure159(v0_1: Mut10, unitVar: void): any[] {
    const v2: (arg0: Mut14) => any = (v: Mut14): any => closure160(void 0, v);
    const v3: (arg0: any) => any = v2;
    const v4: (arg0: [US4, int32, string, string]) => US2 = (arg10$0040: [US4, int32, string, string]): US2 => closure165(void 0, arg10$0040);
    const v5: (arg0: [US4, int32, string, string], arg1: US2) => [US4, int32, string, string] = (arg10$0040_1: [US4, int32, string, string]): (arg0: US2) => [US4, int32, string, string] => closure166(v0_1, arg10$0040_1);
    const v6: Mut14 = new Mut14(v0_1.l0, v4, uncurry(2, v5));
    const v10: any = createComponent;
    return [v10(v3, v6)];
}

export function closure158(v0_1: Mut10, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    const v66_1: () => any[] = (): any[] => closure159(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], US7_US7_1(v66_1), _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], US3_US3_1("3px"), _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US10_US10_1(<>
        Port
    </>), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure147(v0_1: Mut10, unitVar: void): any[] {
    const v1_1: (arg0: Mut4) => any = (v: Mut4): any => closure13(void 0, v);
    const v2: (arg0: any) => any = v1_1;
    const v4: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure148(v0_1, arg10$0040);
    const v6: Mut4 = new Mut4(US13_US13_0(), v4, US14_US14_2());
    const v10: any = createComponent;
    const v12: (arg0: any) => any = v1_1;
    const v14: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040_1: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure158(v0_1, arg10$0040_1);
    const v16: Mut4 = new Mut4(US13_US13_0(), v14, US14_US14_2());
    const v18: any = createComponent;
    return [v10(v2, v6), v18(v12, v16)];
}

export function method28(v0_1: Mut10): any {
    const v1_1: (arg0: Mut2) => any = (v: Mut2): any => closure9(void 0, v);
    const v2: (arg0: any) => any = v1_1;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v66_1: () => any[] = (): any[] => closure147(v0_1, void 0);
    const v68_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v66_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]);
    v68_1.children = v66_1;
    const v72_1: any = createComponent;
    return v72_1(v2, v68_1);
}

export function closure146(unitVar: void, v0_1: Mut10): any {
    return method28(v0_1);
}

export function closure145(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut10) => any = (v: Mut10): any => closure146(void 0, v);
    const v1_1: (arg0: any) => any = v0_1;
    const v3: Mut10 = new Mut10(US4_US4_1());
    const v7: any = createComponent;
    return [v7(v1_1, v3)];
}

export function closure144(unitVar: void, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    const v65_1: () => any[] = (): any[] => closure145(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], US7_US7_1(v65_1), _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], US3_US3_1("db-gun-rs-rs"), _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US10_US10_1(<>
        Rust -{'>'} Rust
    </>), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure171(v0_1: Mut1, v1_1: Mut1): void {
    const v3: [US4, US4][] = v0_1.l5;
    const v6: [US4, US4][] = [[US4_US4_1(), US4_US4_0()]];
    const v7: int32 = v3.length | 0;
    const v9: int32 = (v7 + v6.length) | 0;
    const v10: [US4, US4][] = fill(new Array(v9), 0, v9, null);
    const v11: Mut6 = new Mut6(0);
    while (method17(v9, v11)) {
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

export function closure170(unitVar: void, v0_1: Mut1): (arg0: Mut1) => void {
    return (v: Mut1): void => {
        closure171(v0_1, v);
    };
}

export function closure169(unitVar: void, v0_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void): void {
    const v1_1: (arg0: Mut1, arg1: Mut1) => void = (v: Mut1): (arg0: Mut1) => void => closure170(void 0, v);
    v0_1(v1_1);
}

export function closure168(unitVar: void, v0_1: Mut1): (arg0: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void {
    return (v: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void): void => {
        closure169(void 0, v);
    };
}

export function closure173(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut10) => any = (v: Mut10): any => closure146(void 0, v);
    const v1_1: (arg0: any) => any = v0_1;
    const v3: Mut10 = new Mut10(US4_US4_0());
    const v7: any = createComponent;
    return [v7(v1_1, v3)];
}

export function closure172(unitVar: void, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    const v65_1: () => any[] = (): any[] => closure173(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], US7_US7_1(v65_1), _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], US3_US3_1("db-gun-rs-js"), _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US10_US10_1(<>
        Rust -{'>'} JavaScript
    </>), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure177(v0_1: Mut1, v1_1: Mut1): void {
    const v3: [US4, US4][] = v0_1.l5;
    const v6: [US4, US4][] = [[US4_US4_0(), US4_US4_0()]];
    const v7: int32 = v3.length | 0;
    const v9: int32 = (v7 + v6.length) | 0;
    const v10: [US4, US4][] = fill(new Array(v9), 0, v9, null);
    const v11: Mut6 = new Mut6(0);
    while (method17(v9, v11)) {
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

export function closure176(unitVar: void, v0_1: Mut1): (arg0: Mut1) => void {
    return (v: Mut1): void => {
        closure177(v0_1, v);
    };
}

export function closure175(unitVar: void, v0_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void): void {
    const v1_1: (arg0: Mut1, arg1: Mut1) => void = (v: Mut1): (arg0: Mut1) => void => closure176(void 0, v);
    v0_1(v1_1);
}

export function closure174(unitVar: void, v0_1: Mut1): (arg0: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void {
    return (v: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void): void => {
        closure175(void 0, v);
    };
}

export function closure179(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut10) => any = (v: Mut10): any => closure146(void 0, v);
    const v1_1: (arg0: any) => any = v0_1;
    const v3: Mut10 = new Mut10(US4_US4_0());
    const v7: any = createComponent;
    return [v7(v1_1, v3)];
}

export function closure178(unitVar: void, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    const v65_1: () => any[] = (): any[] => closure179(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], US7_US7_1(v65_1), _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], US3_US3_1("db-gun-js-js"), _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US10_US10_1(<>
        JavaScript -{'>'} JavaScript
    </>), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure183(v0_1: Mut1, v1_1: Mut1): void {
    const v3: [US4, US4][] = v0_1.l5;
    const v6: [US4, US4][] = [[US4_US4_0(), US4_US4_1()]];
    const v7: int32 = v3.length | 0;
    const v9: int32 = (v7 + v6.length) | 0;
    const v10: [US4, US4][] = fill(new Array(v9), 0, v9, null);
    const v11: Mut6 = new Mut6(0);
    while (method17(v9, v11)) {
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

export function closure182(unitVar: void, v0_1: Mut1): (arg0: Mut1) => void {
    return (v: Mut1): void => {
        closure183(v0_1, v);
    };
}

export function closure181(unitVar: void, v0_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void): void {
    const v1_1: (arg0: Mut1, arg1: Mut1) => void = (v: Mut1): (arg0: Mut1) => void => closure182(void 0, v);
    v0_1(v1_1);
}

export function closure180(unitVar: void, v0_1: Mut1): (arg0: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void {
    return (v: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void): void => {
        closure181(void 0, v);
    };
}

export function closure185(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut10) => any = (v: Mut10): any => closure146(void 0, v);
    const v1_1: (arg0: any) => any = v0_1;
    const v3: Mut10 = new Mut10(US4_US4_1());
    const v7: any = createComponent;
    return [v7(v1_1, v3)];
}

export function closure184(unitVar: void, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    const v65_1: () => any[] = (): any[] => closure185(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], US7_US7_1(v65_1), _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], US3_US3_1("db-gun-js-rs"), _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US10_US10_1(<>
        JavaScript -{'>'} Rust
    </>), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure139(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut4) => any = (v: Mut4): any => closure13(void 0, v);
    const v1_1: (arg0: any) => any = v0_1;
    const v2: (arg0: Mut1, arg1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void = (v_1: Mut1): (arg0: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void => closure140(void 0, v_1);
    const v4: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure144(void 0, arg10$0040);
    const v6: Mut4 = new Mut4(US13_US13_1(uncurry(2, v2)), v4, US14_US14_0());
    const v10: any = createComponent;
    const v12: (arg0: any) => any = v0_1;
    const v13: (arg0: Mut1, arg1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void = (v_2: Mut1): (arg0: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void => closure168(void 0, v_2);
    const v15: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040_1: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure172(void 0, arg10$0040_1);
    const v17: Mut4 = new Mut4(US13_US13_1(uncurry(2, v13)), v15, US14_US14_0());
    const v19: any = createComponent;
    const v21: (arg0: any) => any = v0_1;
    const v22: (arg0: Mut1, arg1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void = (v_3: Mut1): (arg0: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void => closure174(void 0, v_3);
    const v24: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040_2: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure178(void 0, arg10$0040_2);
    const v26: Mut4 = new Mut4(US13_US13_1(uncurry(2, v22)), v24, US14_US14_0());
    const v28: any = createComponent;
    const v30: (arg0: any) => any = v0_1;
    const v31: (arg0: Mut1, arg1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void = (v_4: Mut1): (arg0: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void => closure180(void 0, v_4);
    const v33: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040_3: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure184(void 0, arg10$0040_3);
    const v35: Mut4 = new Mut4(US13_US13_1(uncurry(2, v31)), v33, US14_US14_0());
    const v37: any = createComponent;
    return [v10(v1_1, v6), v19(v12, v17), v28(v21, v26), v37(v30, v35)];
}

export function method27(): any {
    const v0_1: (arg0: Mut2) => any = (v: Mut2): any => closure9(void 0, v);
    const v1_1: (arg0: any) => any = v0_1;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v65_1: () => any[] = (): any[] => closure139(void 0, void 0);
    const v67_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v65_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]);
    v67_1.children = v65_1;
    const v71_1: any = createComponent;
    return v71_1(v1_1, v67_1);
}

export function closure138(unitVar: void, v0_1: Mut2): any {
    return method27();
}

export function closure186(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure137(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut2) => any = (v: Mut2): any => closure138(void 0, v);
    const v1_1: (arg0: any) => any = v0_1;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v65_1: () => any[] = (): any[] => closure186(void 0, void 0);
    const v67_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v65_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]);
    v67_1.children = v65_1;
    const v71_1: any = createComponent;
    return [v71_1(v1_1, v67_1)];
}

export function closure136(unitVar: void, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    const v65_1: () => any[] = (): any[] => closure137(void 0, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], US7_US7_1(v65_1), _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], US3_US3_1("db"), _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US10_US10_1(<>
        Database
    </>), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure193(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Counter
    </>];
}

export function closure194(unitVar: void, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], US3_US3_0(), _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure195(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularPlus;
    return v2;
}

export function closure196(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Request
    </>];
}

export function closure197(unitVar: void, unitVar_1: void): void {
    toConsole(interpolate("%A%P()", [["use_fetch request.", "content_address:", "profile/tmp/counter"]]));
}

export function closure198(unitVar: void, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], US3_US3_0(), _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure199(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularMinus;
    return v2;
}

export function closure200(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Clear
    </>];
}

export function closure201(unitVar: void, unitVar_1: void): void {
    toConsole(interpolate("%A%P()", [["use_fetch clear.", "content_address:", "profile/tmp/counter"]]));
}

export function closure192(unitVar: void, unitVar_1: void): any[] {
    const v2: any = Box;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v66_1: () => any[] = (): any[] => closure193(void 0, void 0);
    const v69_1: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v66_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]));
    const v70_1: (arg0: any) => any = v2;
    const v73_1: any = createComponent;
    const v74_1: any = v73_1(v70_1, v69_1);
    const v75_1: (arg0: Mut2) => any = (v: Mut2): any => closure27(void 0, v);
    const v76_1: (arg0: any) => any = v75_1;
    const patternInput_1: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v140: (arg0: Mut7) => any = (v_1: Mut7): any => closure34(void 0, v_1);
    const v141: (arg0: any) => any = v140;
    const v142: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040_1: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure194(void 0, arg10$0040_1);
    const v143: () => any = (): any => closure195(void 0, void 0);
    const v144: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040_3: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure36(void 0, arg10$0040_3);
    const v145: Mut7 = new Mut7(v142, v143, v144);
    const v147: any = createComponent;
    const v149: () => any[] = (): any[] => closure196(void 0, void 0);
    const v152: () => void = (): void => {
        closure197(void 0, void 0);
    };
    const v154: string = "10px";
    const v156: Mut2 = new Mut2(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], US7_US7_1(v149), patternInput_1[11], patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], US10_US10_1(v147(v141, v145)), patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], US12_US12_1(v152), patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], US3_US3_1(v154), patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62]);
    v156.children = v149;
    const v158: any = createComponent;
    const v159: any = v158(v76_1, v156);
    const v160: (arg0: any) => any = v75_1;
    const patternInput_2: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v224: (arg0: any) => any = v140;
    const v225: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040_6: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure198(void 0, arg10$0040_6);
    const v226: () => any = (): any => closure199(void 0, void 0);
    const v227: Mut7 = new Mut7(v225, v226, v144);
    const v229: any = createComponent;
    const v231: () => any[] = (): any[] => closure200(void 0, void 0);
    const v234: () => void = (): void => {
        closure201(void 0, void 0);
    };
    const v237: Mut2 = new Mut2(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], US7_US7_1(v231), patternInput_2[11], patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], patternInput_2[18], patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], US10_US10_1(v229(v224, v227)), patternInput_2[30], patternInput_2[31], patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], US12_US12_1(v234), patternInput_2[40], patternInput_2[41], patternInput_2[42], patternInput_2[43], patternInput_2[44], patternInput_2[45], patternInput_2[46], US3_US3_1(v154), patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62]);
    v237.children = v231;
    const v239: any = createComponent;
    return [v74_1, v159, v239(v160, v237)];
}

export function method36(v0_1: int32, v1_1: Mut16): boolean {
    return v1_1.l0 < v0_1;
}

export function method37(v0_1_mut: UH1, v1_1_mut: UH1): UH1 {
    method37:
    while (true) {
        const v0_1: UH1 = v0_1_mut, v1_1: UH1 = v1_1_mut;
        if (v0_1.tag === UH1_Tag.UH1_1) {
            return v1_1;
        }
        else {
            v0_1_mut = v0_1.fields[2];
            v1_1_mut = UH1_UH1_0(v0_1.fields[0], v0_1.fields[1], v1_1);
            continue method37;
        }
        break;
    }
}

export function method39(v0_1_mut: UH1, v1_1_mut: int32): int32 {
    method39:
    while (true) {
        const v0_1: UH1 = v0_1_mut, v1_1: int32 = v1_1_mut;
        if (v0_1.tag === UH1_Tag.UH1_1) {
            return v1_1 | 0;
        }
        else {
            v0_1_mut = v0_1.fields[2];
            v1_1_mut = (v1_1 + 1);
            continue method39;
        }
        break;
    }
}

export function method40(v0_1_mut: [int32, int32][], v1_1_mut: UH1, v2_mut: int32): int32 {
    method40:
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
            continue method40;
        }
        break;
    }
}

export function method38(v0_1: UH1): [int32, int32][] {
    const v2: int32 = method39(v0_1, 0) | 0;
    const v3: [int32, int32][] = fill(new Array(v2), 0, v2, null);
    const v5: int32 = method40(v3, v0_1, 0) | 0;
    return v3;
}

export function closure207(v0_1: () => [int32, int32], unitVar: void): any[] {
    const patternInput: [int32, int32] = v0_1();
    return [<>
        {JSON.stringify(patternInput[1], null, 2)}
    </>];
}

export function closure206(v0_1: () => [int32, int32], unitVar: void): any[] {
    const v3: any = hope;
    const v4: any = v3.pre;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v68_1: () => any[] = (): any[] => closure207(v0_1, void 0);
    const v71_1: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v68_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]));
    const v72_1: (arg0: any) => any = v4;
    const v75_1: any = createComponent;
    return [v75_1(v72_1, v71_1)];
}

export function closure205(v0_1: () => [int32, int32], _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    const v68_1: () => any[] = (): any[] => closure206(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], US7_US7_1(v68_1), _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], US3_US3_1("3px"), _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US10_US10_1(<>
        {int32ToString(v0_1()[0])}
    </>), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure204(unitVar: void, v0_1: () => [int32, int32]): any[] {
    const v1_1: (arg0: Mut4) => any = (v: Mut4): any => closure13(void 0, v);
    const v2: (arg0: any) => any = v1_1;
    const v4: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure205(v0_1, arg10$0040);
    const v6: Mut4 = new Mut4(US13_US13_0(), v4, US14_US14_2());
    const v10: any = createComponent;
    return [v10(v2, v6)];
}

export function closure203(v0_1: Mut1, unitVar: void): any[] {
    const v3: [int32, int32][] = v0_1.l8;
    const v4: int32 = v3.length | 0;
    const v6: Mut16 = new Mut16(0, UH1_UH1_1());
    while (method36(v4, v6)) {
        const v8: int32 = v6.l0 | 0;
        const v11: int32 = ((op_UnaryNegation_Int32(v8) + v4) - 1) | 0;
        const v12: UH1 = v6.l1;
        const patternInput_1: [int32, int32] = v3[v11];
        const v15: int32 = (v8 + 1) | 0;
        v6.l0 = (v15 | 0);
        v6.l1 = UH1_UH1_0(patternInput_1[0], patternInput_1[1], v12);
    }
    const v20: [int32, int32][] = method38(method37(v6.l1, UH1_UH1_1()));
    const v23: any = Index;
    const v24: (arg0: () => [int32, int32]) => any[] = (v: () => [int32, int32]): any[] => closure204(void 0, v);
    const v25: () => any[] = v24;
    const patternInput_2: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v93_1: any = createObj(method7(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], US7_US7_1(v25), patternInput_2[11], patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], US9_US9_1(v20), patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], patternInput_2[29], patternInput_2[30], patternInput_2[31], patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], patternInput_2[41], patternInput_2[42], patternInput_2[43], patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62]));
    const v94_1: (arg0: any) => any = v23;
    const v96_1: any = createComponent;
    return [v96_1(v94_1, v93_1)];
}

export function closure202(v0_1: Mut1, unitVar: void): any[] {
    const v1_1: (arg0: Mut2) => any = (v: Mut2): any => closure9(void 0, v);
    const v2: (arg0: any) => any = v1_1;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v66_1: () => any[] = (): any[] => closure203(v0_1, void 0);
    const v68_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v66_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]);
    v68_1.children = v66_1;
    const v72_1: any = createComponent;
    return [v72_1(v2, v68_1)];
}

export function closure191(v0_1: Mut1, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    const v66_1: any = Stack;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v138: () => any[] = (): any[] => closure192(void 0, void 0);
    const v147: any = createObj(method7(US3_US3_1("start"), patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v138), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], US3_US3_1(method13("column", "row")), patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], US3_US3_1(method13("8px", "0")), patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], US3_US3_1("3px"), patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], US3_US3_1("7px"), patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]));
    const v148: (arg0: any) => any = v66_1;
    const v151: any = createComponent;
    const v153: () => any[] = (): any[] => closure202(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], US7_US7_1(v153), _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], US3_US3_1("counter"), _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US10_US10_1(v151(v148, v147)), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function method35(): any {
    const v2: any = useStoreon;
    const v3: any[] = v2();
    const v4: Mut1 = v3[0];
    const v5: any = v3[1];
    const patternInput: [[int32, any][], [int32, any][], [int32, int32][]] = [v4.l6, v4.l7, v4.l8];
    const v9: (arg0: Mut4) => any = (v: Mut4): any => closure13(void 0, v);
    const v10: (arg0: any) => any = v9;
    const v12: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure191(v4, arg10$0040);
    const v14: Mut4 = new Mut4(US13_US13_0(), v12, US14_US14_2());
    const v18: any = createComponent;
    return v18(v10, v14);
}

export function closure190(unitVar: void, v0_1: Mut2): any {
    return method35();
}

export function closure208(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure212(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Chain Status
    </>];
}

export function closure213(unitVar: void, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], US3_US3_0(), _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure214(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Request
    </>];
}

export function closure215(unitVar: void, unitVar_1: void): void {
    toConsole(interpolate("%A%P()", [["use_fetch request.", "content_address:", "profile/tmp/chain_status"]]));
}

export function closure216(unitVar: void, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], US3_US3_0(), _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure217(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Clear
    </>];
}

export function closure218(unitVar: void, unitVar_1: void): void {
    toConsole(interpolate("%A%P()", [["use_fetch clear.", "content_address:", "profile/tmp/chain_status"]]));
}

export function closure211(unitVar: void, unitVar_1: void): any[] {
    const v2: any = Box;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v66_1: () => any[] = (): any[] => closure212(void 0, void 0);
    const v69_1: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v66_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]));
    const v70_1: (arg0: any) => any = v2;
    const v73_1: any = createComponent;
    const v74_1: any = v73_1(v70_1, v69_1);
    const v75_1: (arg0: Mut2) => any = (v: Mut2): any => closure27(void 0, v);
    const v76_1: (arg0: any) => any = v75_1;
    const patternInput_1: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v140: (arg0: Mut7) => any = (v_1: Mut7): any => closure34(void 0, v_1);
    const v141: (arg0: any) => any = v140;
    const v142: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040_1: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure213(void 0, arg10$0040_1);
    const v143: () => any = (): any => closure195(void 0, void 0);
    const v144: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040_3: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure36(void 0, arg10$0040_3);
    const v145: Mut7 = new Mut7(v142, v143, v144);
    const v147: any = createComponent;
    const v149: () => any[] = (): any[] => closure214(void 0, void 0);
    const v152: () => void = (): void => {
        closure215(void 0, void 0);
    };
    const v154: string = "10px";
    const v156: Mut2 = new Mut2(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], US7_US7_1(v149), patternInput_1[11], patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], US10_US10_1(v147(v141, v145)), patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], US12_US12_1(v152), patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], US3_US3_1(v154), patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62]);
    v156.children = v149;
    const v158: any = createComponent;
    const v159: any = v158(v76_1, v156);
    const v160: (arg0: any) => any = v75_1;
    const patternInput_2: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v224: (arg0: any) => any = v140;
    const v225: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040_6: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure216(void 0, arg10$0040_6);
    const v226: () => any = (): any => closure199(void 0, void 0);
    const v227: Mut7 = new Mut7(v225, v226, v144);
    const v229: any = createComponent;
    const v231: () => any[] = (): any[] => closure217(void 0, void 0);
    const v234: () => void = (): void => {
        closure218(void 0, void 0);
    };
    const v237: Mut2 = new Mut2(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], US7_US7_1(v231), patternInput_2[11], patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], patternInput_2[18], patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], US10_US10_1(v229(v224, v227)), patternInput_2[30], patternInput_2[31], patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], US12_US12_1(v234), patternInput_2[40], patternInput_2[41], patternInput_2[42], patternInput_2[43], patternInput_2[44], patternInput_2[45], patternInput_2[46], US3_US3_1(v154), patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62]);
    v237.children = v231;
    const v239: any = createComponent;
    return [v74_1, v159, v239(v160, v237)];
}

export function method42(v0_1: int32, v1_1: Mut17): boolean {
    return v1_1.l0 < v0_1;
}

export function method43(v0_1_mut: UH2, v1_1_mut: UH2): UH2 {
    method43:
    while (true) {
        const v0_1: UH2 = v0_1_mut, v1_1: UH2 = v1_1_mut;
        if (v0_1.tag === UH2_Tag.UH2_1) {
            return v1_1;
        }
        else {
            v0_1_mut = v0_1.fields[2];
            v1_1_mut = UH2_UH2_0(v0_1.fields[0], v0_1.fields[1], v1_1);
            continue method43;
        }
        break;
    }
}

export function method45(v0_1_mut: UH2, v1_1_mut: int32): int32 {
    method45:
    while (true) {
        const v0_1: UH2 = v0_1_mut, v1_1: int32 = v1_1_mut;
        if (v0_1.tag === UH2_Tag.UH2_1) {
            return v1_1 | 0;
        }
        else {
            v0_1_mut = v0_1.fields[2];
            v1_1_mut = (v1_1 + 1);
            continue method45;
        }
        break;
    }
}

export function method46(v0_1_mut: [int32, any][], v1_1_mut: UH2, v2_mut: int32): int32 {
    method46:
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
            continue method46;
        }
        break;
    }
}

export function method44(v0_1: UH2): [int32, any][] {
    const v2: int32 = method45(v0_1, 0) | 0;
    const v3: [int32, any][] = fill(new Array(v2), 0, v2, null);
    const v5: int32 = method46(v3, v0_1, 0) | 0;
    return v3;
}

export function closure224(v0_1: () => [int32, any], unitVar: void): any[] {
    const patternInput: [int32, any] = v0_1();
    return [<>
        {JSON.stringify(patternInput[1], null, 2)}
    </>];
}

export function closure223(v0_1: () => [int32, any], unitVar: void): any[] {
    const v3: any = hope;
    const v4: any = v3.pre;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v68_1: () => any[] = (): any[] => closure224(v0_1, void 0);
    const v71_1: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v68_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]));
    const v72_1: (arg0: any) => any = v4;
    const v75_1: any = createComponent;
    return [v75_1(v72_1, v71_1)];
}

export function closure222(v0_1: () => [int32, any], _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    const v68_1: () => any[] = (): any[] => closure223(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], US7_US7_1(v68_1), _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], US3_US3_1("3px"), _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US10_US10_1(<>
        {int32ToString(v0_1()[0])}
    </>), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure221(unitVar: void, v0_1: () => [int32, any]): any[] {
    const v1_1: (arg0: Mut4) => any = (v: Mut4): any => closure13(void 0, v);
    const v2: (arg0: any) => any = v1_1;
    const v4: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure222(v0_1, arg10$0040);
    const v6: Mut4 = new Mut4(US13_US13_0(), v4, US14_US14_2());
    const v10: any = createComponent;
    return [v10(v2, v6)];
}

export function closure220(v0_1: Mut1, unitVar: void): any[] {
    const v2: [int32, any][] = v0_1.l7;
    const v4: int32 = v2.length | 0;
    const v6: Mut17 = new Mut17(0, UH2_UH2_1());
    while (method42(v4, v6)) {
        const v8: int32 = v6.l0 | 0;
        const v11: int32 = ((op_UnaryNegation_Int32(v8) + v4) - 1) | 0;
        const v12: UH2 = v6.l1;
        const patternInput_1: [int32, any] = v2[v11];
        const v15: int32 = (v8 + 1) | 0;
        v6.l0 = (v15 | 0);
        v6.l1 = UH2_UH2_0(patternInput_1[0], patternInput_1[1], v12);
    }
    const v20: [int32, any][] = method44(method43(v6.l1, UH2_UH2_1()));
    const v23: any = Index;
    const v24: (arg0: () => [int32, any]) => any[] = (v: () => [int32, any]): any[] => closure221(void 0, v);
    const v25: () => any[] = v24;
    const patternInput_2: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v93_1: any = createObj(method7(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], US7_US7_1(v25), patternInput_2[11], patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], US9_US9_1(v20), patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], patternInput_2[29], patternInput_2[30], patternInput_2[31], patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], patternInput_2[41], patternInput_2[42], patternInput_2[43], patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62]));
    const v94_1: (arg0: any) => any = v23;
    const v96_1: any = createComponent;
    return [v96_1(v94_1, v93_1)];
}

export function closure219(v0_1: Mut1, unitVar: void): any[] {
    const v1_1: (arg0: Mut2) => any = (v: Mut2): any => closure9(void 0, v);
    const v2: (arg0: any) => any = v1_1;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v66_1: () => any[] = (): any[] => closure220(v0_1, void 0);
    const v68_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v66_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]);
    v68_1.children = v66_1;
    const v72_1: any = createComponent;
    return [v72_1(v2, v68_1)];
}

export function closure210(v0_1: Mut1, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    const v66_1: any = Stack;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v138: () => any[] = (): any[] => closure211(void 0, void 0);
    const v147: any = createObj(method7(US3_US3_1("start"), patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v138), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], US3_US3_1(method13("column", "row")), patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], US3_US3_1(method13("8px", "0")), patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], US3_US3_1("3px"), patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], US3_US3_1("7px"), patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]));
    const v148: (arg0: any) => any = v66_1;
    const v151: any = createComponent;
    const v153: () => any[] = (): any[] => closure219(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], US7_US7_1(v153), _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], US3_US3_1("status"), _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US10_US10_1(v151(v148, v147)), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function method41(): any {
    const v2: any = useStoreon;
    const v3: any[] = v2();
    const v4: Mut1 = v3[0];
    const v5: any = v3[1];
    const patternInput: [[int32, any][], [int32, any][], [int32, int32][]] = [v4.l6, v4.l7, v4.l8];
    const v9: (arg0: Mut4) => any = (v: Mut4): any => closure13(void 0, v);
    const v10: (arg0: any) => any = v9;
    const v12: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure210(v4, arg10$0040);
    const v14: Mut4 = new Mut4(US13_US13_0(), v12, US14_US14_2());
    const v18: any = createComponent;
    return v18(v10, v14);
}

export function closure209(unitVar: void, v0_1: Mut2): any {
    return method41();
}

export function closure225(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure229(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Chain Deploy
    </>];
}

export function closure230(unitVar: void, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], US3_US3_0(), _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure231(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Request
    </>];
}

export function closure232(unitVar: void, unitVar_1: void): void {
    toConsole(interpolate("%A%P()", [["use_fetch request.", "content_address:", "profile/tmp/chain_deploy"]]));
}

export function closure233(unitVar: void, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], _arg[10], _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], US3_US3_0(), _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], _arg[56], _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure234(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Clear
    </>];
}

export function closure235(unitVar: void, unitVar_1: void): void {
    toConsole(interpolate("%A%P()", [["use_fetch clear.", "content_address:", "profile/tmp/chain_deploy"]]));
}

export function closure228(unitVar: void, unitVar_1: void): any[] {
    const v2: any = Box;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v66_1: () => any[] = (): any[] => closure229(void 0, void 0);
    const v69_1: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v66_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]));
    const v70_1: (arg0: any) => any = v2;
    const v73_1: any = createComponent;
    const v74_1: any = v73_1(v70_1, v69_1);
    const v75_1: (arg0: Mut2) => any = (v: Mut2): any => closure27(void 0, v);
    const v76_1: (arg0: any) => any = v75_1;
    const patternInput_1: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v140: (arg0: Mut7) => any = (v_1: Mut7): any => closure34(void 0, v_1);
    const v141: (arg0: any) => any = v140;
    const v142: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040_1: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure230(void 0, arg10$0040_1);
    const v143: () => any = (): any => closure195(void 0, void 0);
    const v144: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040_3: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure36(void 0, arg10$0040_3);
    const v145: Mut7 = new Mut7(v142, v143, v144);
    const v147: any = createComponent;
    const v149: () => any[] = (): any[] => closure231(void 0, void 0);
    const v152: () => void = (): void => {
        closure232(void 0, void 0);
    };
    const v154: string = "10px";
    const v156: Mut2 = new Mut2(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], US7_US7_1(v149), patternInput_1[11], patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], US10_US10_1(v147(v141, v145)), patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], US12_US12_1(v152), patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], US3_US3_1(v154), patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62]);
    v156.children = v149;
    const v158: any = createComponent;
    const v159: any = v158(v76_1, v156);
    const v160: (arg0: any) => any = v75_1;
    const patternInput_2: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v224: (arg0: any) => any = v140;
    const v225: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040_6: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure233(void 0, arg10$0040_6);
    const v226: () => any = (): any => closure199(void 0, void 0);
    const v227: Mut7 = new Mut7(v225, v226, v144);
    const v229: any = createComponent;
    const v231: () => any[] = (): any[] => closure234(void 0, void 0);
    const v234: () => void = (): void => {
        closure235(void 0, void 0);
    };
    const v237: Mut2 = new Mut2(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], US7_US7_1(v231), patternInput_2[11], patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], patternInput_2[18], patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], US10_US10_1(v229(v224, v227)), patternInput_2[30], patternInput_2[31], patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], US12_US12_1(v234), patternInput_2[40], patternInput_2[41], patternInput_2[42], patternInput_2[43], patternInput_2[44], patternInput_2[45], patternInput_2[46], US3_US3_1(v154), patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62]);
    v237.children = v231;
    const v239: any = createComponent;
    return [v74_1, v159, v239(v160, v237)];
}

export function closure241(v0_1: () => [int32, any], unitVar: void): any[] {
    const patternInput: [int32, any] = v0_1();
    return [<>
        {JSON.stringify(patternInput[1], null, 2)}
    </>];
}

export function closure240(v0_1: () => [int32, any], unitVar: void): any[] {
    const v3: any = hope;
    const v4: any = v3.pre;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v68_1: () => any[] = (): any[] => closure241(v0_1, void 0);
    const v71_1: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v68_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]));
    const v72_1: (arg0: any) => any = v4;
    const v75_1: any = createComponent;
    return [v75_1(v72_1, v71_1)];
}

export function closure239(v0_1: () => [int32, any], _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    const v68_1: () => any[] = (): any[] => closure240(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], US7_US7_1(v68_1), _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], US3_US3_1("3px"), _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US10_US10_1(<>
        {int32ToString(v0_1()[0])}
    </>), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure238(unitVar: void, v0_1: () => [int32, any]): any[] {
    const v1_1: (arg0: Mut4) => any = (v: Mut4): any => closure13(void 0, v);
    const v2: (arg0: any) => any = v1_1;
    const v4: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure239(v0_1, arg10$0040);
    const v6: Mut4 = new Mut4(US13_US13_0(), v4, US14_US14_2());
    const v10: any = createComponent;
    return [v10(v2, v6)];
}

export function closure237(v0_1: Mut1, unitVar: void): any[] {
    const v1_1: [int32, any][] = v0_1.l6;
    const v4: int32 = v1_1.length | 0;
    const v6: Mut17 = new Mut17(0, UH2_UH2_1());
    while (method42(v4, v6)) {
        const v8: int32 = v6.l0 | 0;
        const v11: int32 = ((op_UnaryNegation_Int32(v8) + v4) - 1) | 0;
        const v12: UH2 = v6.l1;
        const patternInput_1: [int32, any] = v1_1[v11];
        const v15: int32 = (v8 + 1) | 0;
        v6.l0 = (v15 | 0);
        v6.l1 = UH2_UH2_0(patternInput_1[0], patternInput_1[1], v12);
    }
    const v20: [int32, any][] = method44(method43(v6.l1, UH2_UH2_1()));
    const v23: any = Index;
    const v24: (arg0: () => [int32, any]) => any[] = (v: () => [int32, any]): any[] => closure238(void 0, v);
    const v25: () => any[] = v24;
    const patternInput_2: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v93_1: any = createObj(method7(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], US7_US7_1(v25), patternInput_2[11], patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], US9_US9_1(v20), patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], patternInput_2[29], patternInput_2[30], patternInput_2[31], patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], patternInput_2[41], patternInput_2[42], patternInput_2[43], patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62]));
    const v94_1: (arg0: any) => any = v23;
    const v96_1: any = createComponent;
    return [v96_1(v94_1, v93_1)];
}

export function closure236(v0_1: Mut1, unitVar: void): any[] {
    const v1_1: (arg0: Mut2) => any = (v: Mut2): any => closure9(void 0, v);
    const v2: (arg0: any) => any = v1_1;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v66_1: () => any[] = (): any[] => closure237(v0_1, void 0);
    const v68_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v66_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]);
    v68_1.children = v66_1;
    const v72_1: any = createComponent;
    return [v72_1(v2, v68_1)];
}

export function closure227(v0_1: Mut1, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    const v66_1: any = Stack;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v138: () => any[] = (): any[] => closure228(void 0, void 0);
    const v147: any = createObj(method7(US3_US3_1("start"), patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v138), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], US3_US3_1(method13("column", "row")), patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], US3_US3_1(method13("8px", "0")), patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], US3_US3_1("3px"), patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], US3_US3_1("7px"), patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]));
    const v148: (arg0: any) => any = v66_1;
    const v151: any = createComponent;
    const v153: () => any[] = (): any[] => closure236(v0_1, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], US7_US7_1(v153), _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], US3_US3_1("deploy"), _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US10_US10_1(v151(v148, v147)), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function method47(): any {
    const v2: any = useStoreon;
    const v3: any[] = v2();
    const v4: Mut1 = v3[0];
    const v5: any = v3[1];
    const patternInput: [[int32, any][], [int32, any][], [int32, int32][]] = [v4.l6, v4.l7, v4.l8];
    const v9: (arg0: Mut4) => any = (v: Mut4): any => closure13(void 0, v);
    const v10: (arg0: any) => any = v9;
    const v12: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure227(v4, arg10$0040);
    const v14: Mut4 = new Mut4(US13_US13_0(), v12, US14_US14_2());
    const v18: any = createComponent;
    return v18(v10, v14);
}

export function closure226(unitVar: void, v0_1: Mut2): any {
    return method47();
}

export function closure242(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure189(v0_1: string, v1_1: any, v2: string, v3: string, v4: boolean, unitVar: void): any[] {
    const v5: (arg0: Mut2) => any = (v: Mut2): any => closure190(void 0, v);
    const v6: (arg0: any) => any = v5;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v70_1: () => any[] = (): any[] => closure208(void 0, void 0);
    const v72_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v70_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]);
    v72_1.children = v70_1;
    const v76_1: any = createComponent;
    const v77_1: any = v76_1(v6, v72_1);
    const v78_1: (arg0: Mut2) => any = (v_1: Mut2): any => closure209(void 0, v_1);
    const v79_1: (arg0: any) => any = v78_1;
    const patternInput_1: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v143: () => any[] = (): any[] => closure225(void 0, void 0);
    const v145: Mut2 = new Mut2(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], US7_US7_1(v143), patternInput_1[11], patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61], patternInput_1[62]);
    v145.children = v143;
    const v147: any = createComponent;
    const v151: boolean = (v2 === "") !== true;
    const v153: any = v151 ? (v147(v79_1, v145)) : <></>;
    const v154: (arg0: Mut2) => any = (v_2: Mut2): any => closure226(void 0, v_2);
    const v155: (arg0: any) => any = v154;
    const patternInput_2: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v219: () => any[] = (): any[] => closure242(void 0, void 0);
    const v221: Mut2 = new Mut2(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], US7_US7_1(v219), patternInput_2[11], patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], patternInput_2[18], patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], patternInput_2[29], patternInput_2[30], patternInput_2[31], patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], patternInput_2[41], patternInput_2[42], patternInput_2[43], patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61], patternInput_2[62]);
    v221.children = v219;
    const v223: any = createComponent;
    return [v77_1, v153, v151 ? (v223(v155, v221)) : <></>];
}

export function closure188(v0_1: string, v1_1: any, v2: string, v3: string, v4: boolean, unitVar: void): any[] {
    const v5: (arg0: Mut2) => any = (v: Mut2): any => closure9(void 0, v);
    const v6: (arg0: any) => any = v5;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v70_1: () => any[] = (): any[] => closure189(v0_1, v1_1, v2, v3, v4, void 0);
    const v72_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v70_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]);
    v72_1.children = v70_1;
    const v76_1: any = createComponent;
    return [v76_1(v6, v72_1)];
}

export function closure187(v0_1: string, v1_1: any, v2: string, v3: string, v4: boolean, _arg: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] {
    const v70_1: () => any[] = (): any[] => closure188(v0_1, v1_1, v2, v3, v4, void 0);
    return [_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6], _arg[7], _arg[8], _arg[9], US7_US7_1(v70_1), _arg[11], _arg[12], _arg[13], _arg[14], _arg[15], _arg[16], _arg[17], _arg[18], _arg[19], _arg[20], _arg[21], _arg[22], _arg[23], _arg[24], _arg[25], _arg[26], _arg[27], _arg[28], _arg[29], _arg[30], _arg[31], _arg[32], _arg[33], _arg[34], _arg[35], _arg[36], _arg[37], _arg[38], _arg[39], _arg[40], _arg[41], _arg[42], _arg[43], _arg[44], _arg[45], _arg[46], _arg[47], _arg[48], _arg[49], _arg[50], _arg[51], _arg[52], _arg[53], _arg[54], _arg[55], US10_US10_1(<>
        Profile
    </>), _arg[57], _arg[58], _arg[59], _arg[60], _arg[61], _arg[62]];
}

export function closure12(v0_1: string, v1_1: any, v2: string, v3: string, v4: boolean, unitVar: void): any[] {
    const v5: (arg0: Mut4) => any = (v: Mut4): any => closure13(void 0, v);
    const v6: (arg0: any) => any = v5;
    const v8: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure48(void 0, arg10$0040);
    const v10: Mut4 = new Mut4(US13_US13_0(), v8, US14_US14_2());
    const v14: any = createComponent;
    const v16: (arg0: any) => any = v5;
    const v18: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040_1: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure36(void 0, arg10$0040_1);
    const v20: Mut4 = new Mut4(US13_US13_0(), v18, US14_US14_2());
    const v22: any = createComponent;
    const v24: (arg0: any) => any = v5;
    const v26: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040_2: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure67(void 0, arg10$0040_2);
    const v28: Mut4 = new Mut4(US13_US13_0(), v26, US14_US14_2());
    const v30: any = createComponent;
    const v32: (arg0: any) => any = v5;
    const v35: Mut4 = new Mut4(US13_US13_0(), v18, US14_US14_2());
    const v37: any = createComponent;
    const v39: (arg0: any) => any = v5;
    const v41: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040_3: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure79(void 0, arg10$0040_3);
    const v43: Mut4 = new Mut4(US13_US13_0(), v41, US14_US14_0());
    const v45: any = createComponent;
    const v47: (arg0: any) => any = v5;
    const v50: Mut4 = new Mut4(US13_US13_0(), v18, US14_US14_2());
    const v52: any = createComponent;
    const v54: (arg0: any) => any = v5;
    const v56: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040_4: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure136(void 0, arg10$0040_4);
    const v58: Mut4 = new Mut4(US13_US13_0(), v56, US14_US14_0());
    const v60: any = createComponent;
    const v62: (arg0: any) => any = v5;
    const v65_1: Mut4 = new Mut4(US13_US13_0(), v18, US14_US14_2());
    const v67_1: any = createComponent;
    const v69_1: (arg0: any) => any = v5;
    const v71_1: (arg0: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]) => [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = (arg10$0040_5: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3]): [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] => closure187(v0_1, v1_1, v2, v3, v4, arg10$0040_5);
    const v73_1: Mut4 = new Mut4(US13_US13_0(), v71_1, US14_US14_2());
    const v75_1: any = createComponent;
    return [v14(v6, v10), v22(v16, v20), v30(v24, v28), v37(v32, v35), v45(v39, v43), v52(v47, v50), v60(v54, v58), v67_1(v62, v65_1), v75_1(v69_1, v73_1)];
}

export function closure5(v0_1: string, v1_1: any, v2: string, v3: string, v4: boolean, unitVar: void): any[] {
    const v5: (arg0: Mut3) => any = (v: Mut3): any => closure6(void 0, v);
    const v6: (arg0: any) => any = v5;
    const v7: Mut3 = Mut3_$ctor();
    const v11: any = createComponent;
    const v16: any = (v2 === "") ? (v11(v6, v7)) : <></>;
    const v17: (arg0: Mut2) => any = (v_1: Mut2): any => closure9(void 0, v_1);
    const v18: (arg0: any) => any = v17;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v82_1: () => any[] = (): any[] => closure12(v0_1, v1_1, v2, v3, v4, void 0);
    const v94_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v82_1), patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], US3_US3_1("flex"), patternInput[18], patternInput[19], US3_US3_1("1"), US3_US3_1("column"), patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], US3_US3_1("hidden"), US3_US3_1("auto"), patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]);
    v94_1.children = v82_1;
    const v96_1: any = createComponent;
    return [v16, v96_1(v18, v94_1)];
}

export function method4(): any {
    const v0_1: any = components_spi.env;
    const v1_1: string = v0_1.CODESPACE_NAME || "";
    const v2: string = v0_1.GITHUB_RUN_ID || "";
    const v3: string = v0_1.GITHUB_SHA || "";
    const v4: any = v0_1.IS_TEST;
    const v6: boolean = (!v4) === false;
    const v9: any = Box;
    const patternInput: [US3, US3, US5, US3, US3, US3, US3, US3, US3, US6, US7, US3, US3, US6, US8, US3, US3, US3, US9, US6, US3, US3, US3, US3, US3, US10, US3, US3, US3, US10, US3, US3, US3, US3, US3, US3, US3, US3, US11, US12, US11, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US10, US3, US3, US8, US3, US2, US3] = method5();
    const v75_1: () => any[] = (): any[] => closure5(v1_1, v0_1, v2, v3, v6, void 0);
    const v94_1: any = createObj(method7(patternInput[0], patternInput[1], patternInput[2], US3_US3_1("$bg"), patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], US7_US7_1(v75_1), US3_US3_1("$text1"), patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], US3_US3_1("flex"), patternInput[18], patternInput[19], US3_US3_1("1"), US3_US3_1("column"), US3_US3_1("$sm"), US3_US3_1("100vh"), patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], US3_US3_1("100vw"), patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], US3_US3_1("1px"), patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61], patternInput[62]));
    const v95_1: (arg0: any) => any = v9;
    const v98_1: any = createComponent;
    return v98_1(v95_1, v94_1);
}

export function closure4(unitVar: void, v0_1: Mut2): any {
    return method4();
}

export const v0 = void 0;

export const v1 = new Mut0(v0);

export const v65 = process.env;

export const v66 = "env";

export const v67 = [v66, v65];

export const v68 = [v67];

export const v69 = createObj(v68);

window.components_spi = v69;

export const v70 = components_spi.env;

export const v71 = v70.CODESPACE_NAME || "";

export const v72 = v70.GITHUB_RUN_ID || "";

export const v73 = v70.GITHUB_SHA || "";

export const v74 = v70.IS_TEST;

export const v75 = !v74;

export const v76 = v75 === false;

export const patternInput$00405111 = method0(v71, v70, v72, v73, v76);

export const v86 = patternInput$00405111[9];

export const v85 = patternInput$00405111[8];

export const v84 = patternInput$00405111[7];

export const v83 = patternInput$00405111[6];

export const v82 = patternInput$00405111[5];

export const v81 = patternInput$00405111[4];

export const v80 = patternInput$00405111[3];

export const v79 = patternInput$00405111[2];

export const v78 = patternInput$00405111[1];

export const v77 = patternInput$00405111[0];

export const v87 = new Mut1(v77, v78, v79, v80, v81, v82, v83, v84, v85, v86);

export const v88 = v87;

export const v89 = method1();

export const v90 = v89(v88);

export const v91 = nonSeeded().Next0();

export const v92 = "db_listener";

export const v93 = (v: Mut2): any => closure2(v90, v);

export const v94 = [v92, v93];

export const v95 = "content";

export const v96 = (v: Mut2): any => closure4(void 0, v);

export const v97 = [v95, v96];

export const v98 = "store";

export const v99 = [v98, v90];

export const v100 = "run_id";

export const v101 = [v100, v91];

export const v102 = [v94, v97, v99, v101, v67];

export const v103 = createObj(v102);

window.components_spi = v103;

v1.l0 = v103;


