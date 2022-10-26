import { Union, Record } from "./fable_modules/fable-library-ts/Types.js";
import { lambda_type, unit_type, bool_type, class_type, array_type, tuple_type, string_type, union_type, int32_type, record_type, obj_type, TypeInfo } from "./fable_modules/fable-library-ts/Reflection.js";
import { op_UnaryNegation_Int32, int32 } from "./fable_modules/fable-library-ts/Int32.js";
import { createStoreon } from "storeon";
import { int64, fromBits, op_Division, op_Subtraction, toString } from "./fable_modules/fable-library-ts/Long.js";
import { getTicks, utcNow } from "./fable_modules/fable-library-ts/Date.js";
import { For, createEffect, on, createSignal, createComponent, onCleanup } from "solid-js";
import { fill } from "./fable_modules/fable-library-ts/Array.js";
import { hope, Input, useColorMode, RadioGroup, Radio, Anchor, Tr, Td, Stack, IconButton, Icon, Button, Checkbox, Box, Table, Tbody } from "@hope-ui/solid";
import { uncurry, createObj } from "./fable_modules/fable-library-ts/Util.js";
import { BiRegularLinkExternal, BiRegularUndo, BiRegularUpArrow, BiRegularDownArrow, BiRegularRefresh } from "solid-icons/bi";
import { useStoreon } from "@storeon/solidjs";
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

export const enum US0_Tag {
    US0_0 = 0,
    US0_1 = 1
}

export type US0_Fields = [[], [int32]];

export type US0 = US0_Cons<US0_Tag.US0_0> | US0_Cons<US0_Tag.US0_1>;

export function US0_US0_0() {
    return new US0_Cons<US0_Tag.US0_0>(US0_Tag.US0_0, []);
}

export function US0_US0_1(f1_0: int32) {
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
    return union_type("Components_spi.US0", [], US0_Cons, () => [[], [["f1_0", int32_type]]]);
}

export const enum US1_Tag {
    US1_0 = 0,
    US1_1 = 1
}

export type US1_Fields = [[], [string]];

export type US1 = US1_Cons<US1_Tag.US1_0> | US1_Cons<US1_Tag.US1_1>;

export function US1_US1_0() {
    return new US1_Cons<US1_Tag.US1_0>(US1_Tag.US1_0, []);
}

export function US1_US1_1(f1_0: string) {
    return new US1_Cons<US1_Tag.US1_1>(US1_Tag.US1_1, [f1_0]);
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
    return union_type("Components_spi.US1", [], US1_Cons, () => [[], [["f1_0", string_type]]]);
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

export class Mut1 extends Record {
    l0: [string, string, string, string][];
    l1: US0;
    l2: US1;
    l3: US1;
    l4: [US2, int32, string, string][];
    l5: [US2, US2][];
    l6: US1;
    l7: US0;
    constructor(l0: [string, string, string, string][], l1: US0, l2: US1, l3: US1, l4: [US2, int32, string, string][], l5: [US2, US2][], l6: US1, l7: US0) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
        this.l3 = l3;
        this.l4 = l4;
        this.l5 = l5;
        this.l6 = l6;
        this.l7 = l7;
    }
}

export function Mut1$reflection(): TypeInfo {
    return record_type("Components_spi.Mut1", [], Mut1, () => [["l0", array_type(tuple_type(string_type, string_type, string_type, string_type))], ["l1", US0$reflection()], ["l2", US1$reflection()], ["l3", US1$reflection()], ["l4", array_type(tuple_type(US2$reflection(), int32_type, string_type, string_type))], ["l5", array_type(tuple_type(US2$reflection(), US2$reflection()))], ["l6", US1$reflection()], ["l7", US0$reflection()]]);
}

export const enum US3_Tag {
    US3_0 = 0,
    US3_1 = 1
}

export type US3_Fields = [[], [any]];

export type US3 = US3_Cons<US3_Tag.US3_0> | US3_Cons<US3_Tag.US3_1>;

export function US3_US3_0() {
    return new US3_Cons<US3_Tag.US3_0>(US3_Tag.US3_0, []);
}

export function US3_US3_1(f1_0: any) {
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
    return union_type("Components_spi.US3", [], US3_Cons, () => [[], [["f1_0", class_type("Fable.Core.JS.Function")]]]);
}

export const enum US4_Tag {
    US4_0 = 0,
    US4_1 = 1
}

export type US4_Fields = [[], [boolean]];

export type US4 = US4_Cons<US4_Tag.US4_0> | US4_Cons<US4_Tag.US4_1>;

export function US4_US4_0() {
    return new US4_Cons<US4_Tag.US4_0>(US4_Tag.US4_0, []);
}

export function US4_US4_1(f1_0: boolean) {
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
    return union_type("Components_spi.US4", [], US4_Cons, () => [[], [["f1_0", bool_type]]]);
}

export const enum US5_Tag {
    US5_0 = 0,
    US5_1 = 1
}

export type US5_Fields = [[], [() => any[]]];

export type US5 = US5_Cons<US5_Tag.US5_0> | US5_Cons<US5_Tag.US5_1>;

export function US5_US5_0() {
    return new US5_Cons<US5_Tag.US5_0>(US5_Tag.US5_0, []);
}

export function US5_US5_1(f1_0: () => any[]) {
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
    return union_type("Components_spi.US5", [], US5_Cons, () => [[], [["f1_0", lambda_type(unit_type, array_type(class_type("Fable.Core.JSX.Element")))]]]);
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
    return union_type("Components_spi.US6", [], US6_Cons, () => [[], [["f1_0", obj_type]]]);
}

export const enum US7_Tag {
    US7_0 = 0,
    US7_1 = 1
}

export type US7_Fields = [[], [any[]]];

export type US7 = US7_Cons<US7_Tag.US7_0> | US7_Cons<US7_Tag.US7_1>;

export function US7_US7_0() {
    return new US7_Cons<US7_Tag.US7_0>(US7_Tag.US7_0, []);
}

export function US7_US7_1(f1_0: any[]) {
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
    return union_type("Components_spi.US7", [], US7_Cons, () => [[], [["f1_0", array_type(obj_type)]]]);
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
    return union_type("Components_spi.US8", [], US8_Cons, () => [[], [["f1_0", class_type("Fable.Core.JSX.Element")]]]);
}

export const enum US9_Tag {
    US9_0 = 0,
    US9_1 = 1
}

export type US9_Fields = [[], [(arg0: any) => void]];

export type US9 = US9_Cons<US9_Tag.US9_0> | US9_Cons<US9_Tag.US9_1>;

export function US9_US9_0() {
    return new US9_Cons<US9_Tag.US9_0>(US9_Tag.US9_0, []);
}

export function US9_US9_1(f1_0: (arg0: any) => void) {
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
    return union_type("Components_spi.US9", [], US9_Cons, () => [[], [["f1_0", lambda_type(obj_type, unit_type)]]]);
}

export const enum US10_Tag {
    US10_0 = 0,
    US10_1 = 1
}

export type US10_Fields = [[], [() => void]];

export type US10 = US10_Cons<US10_Tag.US10_0> | US10_Cons<US10_Tag.US10_1>;

export function US10_US10_0() {
    return new US10_Cons<US10_Tag.US10_0>(US10_Tag.US10_0, []);
}

export function US10_US10_1(f1_0: () => void) {
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
    return union_type("Components_spi.US10", [], US10_Cons, () => [[], [["f1_0", lambda_type(unit_type, unit_type)]]]);
}

export class Mut2 extends Record {
    l0: US1;
    l1: US3;
    l2: US1;
    l3: US1;
    l4: US1;
    l5: US1;
    l6: US1;
    l7: US1;
    l8: US4;
    l9: US5;
    l10: US1;
    l11: US1;
    l12: US4;
    l13: US6;
    l14: US1;
    l15: US1;
    l16: US1;
    l17: US7;
    l18: US4;
    l19: US1;
    l20: US1;
    l21: US1;
    l22: US1;
    l23: US1;
    l24: US8;
    l25: US1;
    l26: US1;
    l27: US1;
    l28: US6;
    l29: US1;
    l30: US1;
    l31: US1;
    l32: US1;
    l33: US1;
    l34: US1;
    l35: US1;
    l36: US1;
    l37: US9;
    l38: US10;
    l39: US9;
    l40: US1;
    l41: US1;
    l42: US1;
    l43: US1;
    l44: US1;
    l45: US1;
    l46: US1;
    l47: US1;
    l48: US1;
    l49: US1;
    l50: US1;
    l51: US1;
    l52: US1;
    l53: US1;
    l54: US1;
    l55: US8;
    l56: US1;
    l57: US1;
    l58: US6;
    l59: US1;
    l60: US0;
    l61: US1;
    constructor(l0: US1, l1: US3, l2: US1, l3: US1, l4: US1, l5: US1, l6: US1, l7: US1, l8: US4, l9: US5, l10: US1, l11: US1, l12: US4, l13: US6, l14: US1, l15: US1, l16: US1, l17: US7, l18: US4, l19: US1, l20: US1, l21: US1, l22: US1, l23: US1, l24: US8, l25: US1, l26: US1, l27: US1, l28: US6, l29: US1, l30: US1, l31: US1, l32: US1, l33: US1, l34: US1, l35: US1, l36: US1, l37: US9, l38: US10, l39: US9, l40: US1, l41: US1, l42: US1, l43: US1, l44: US1, l45: US1, l46: US1, l47: US1, l48: US1, l49: US1, l50: US1, l51: US1, l52: US1, l53: US1, l54: US1, l55: US8, l56: US1, l57: US1, l58: US6, l59: US1, l60: US0, l61: US1) {
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
    }
}

export function Mut2$reflection(): TypeInfo {
    return record_type("Components_spi.Mut2", [], Mut2, () => [["l0", US1$reflection()], ["l1", US3$reflection()], ["l2", US1$reflection()], ["l3", US1$reflection()], ["l4", US1$reflection()], ["l5", US1$reflection()], ["l6", US1$reflection()], ["l7", US1$reflection()], ["l8", US4$reflection()], ["l9", US5$reflection()], ["l10", US1$reflection()], ["l11", US1$reflection()], ["l12", US4$reflection()], ["l13", US6$reflection()], ["l14", US1$reflection()], ["l15", US1$reflection()], ["l16", US1$reflection()], ["l17", US7$reflection()], ["l18", US4$reflection()], ["l19", US1$reflection()], ["l20", US1$reflection()], ["l21", US1$reflection()], ["l22", US1$reflection()], ["l23", US1$reflection()], ["l24", US8$reflection()], ["l25", US1$reflection()], ["l26", US1$reflection()], ["l27", US1$reflection()], ["l28", US6$reflection()], ["l29", US1$reflection()], ["l30", US1$reflection()], ["l31", US1$reflection()], ["l32", US1$reflection()], ["l33", US1$reflection()], ["l34", US1$reflection()], ["l35", US1$reflection()], ["l36", US1$reflection()], ["l37", US9$reflection()], ["l38", US10$reflection()], ["l39", US9$reflection()], ["l40", US1$reflection()], ["l41", US1$reflection()], ["l42", US1$reflection()], ["l43", US1$reflection()], ["l44", US1$reflection()], ["l45", US1$reflection()], ["l46", US1$reflection()], ["l47", US1$reflection()], ["l48", US1$reflection()], ["l49", US1$reflection()], ["l50", US1$reflection()], ["l51", US1$reflection()], ["l52", US1$reflection()], ["l53", US1$reflection()], ["l54", US1$reflection()], ["l55", US8$reflection()], ["l56", US1$reflection()], ["l57", US1$reflection()], ["l58", US6$reflection()], ["l59", US1$reflection()], ["l60", US0$reflection()], ["l61", US1$reflection()]]);
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

export const enum US11_Tag {
    US11_0 = 0,
    US11_1 = 1
}

export type US11_Fields = [[], [(arg0: Mut1, arg1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void]];

export type US11 = US11_Cons<US11_Tag.US11_0> | US11_Cons<US11_Tag.US11_1>;

export function US11_US11_0() {
    return new US11_Cons<US11_Tag.US11_0>(US11_Tag.US11_0, []);
}

export function US11_US11_1(f1_0: (arg0: Mut1, arg1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void) {
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
    return union_type("Components_spi.US11", [], US11_Cons, () => [[], [["f1_0", lambda_type(Mut1$reflection(), lambda_type(lambda_type(lambda_type(Mut1$reflection(), lambda_type(Mut1$reflection(), unit_type)), unit_type), unit_type))]]]);
}

export const enum US12_Tag {
    US12_0 = 0,
    US12_1 = 1,
    US12_2 = 2
}

export type US12_Fields = [[], [], []];

export type US12 = US12_Cons<US12_Tag.US12_0> | US12_Cons<US12_Tag.US12_1> | US12_Cons<US12_Tag.US12_2>;

export function US12_US12_0() {
    return new US12_Cons<US12_Tag.US12_0>(US12_Tag.US12_0, []);
}

export function US12_US12_1() {
    return new US12_Cons<US12_Tag.US12_1>(US12_Tag.US12_1, []);
}

export function US12_US12_2() {
    return new US12_Cons<US12_Tag.US12_2>(US12_Tag.US12_2, []);
}

export class US12_Cons<Tag extends keyof US12_Fields> extends Union {
    constructor(readonly tag: Tag, readonly fields: US12_Fields[Tag]) {
        super();
    }
    cases() {
        return ["US12_0", "US12_1", "US12_2"];
    }
}

export function US12$reflection(): TypeInfo {
    return union_type("Components_spi.US12", [], US12_Cons, () => [[], [], []]);
}

export class Mut3 extends Record {
    l0: US11;
    l1: Mut2;
    l2: US12;
    constructor(l0: US11, l1: Mut2, l2: US12) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
    }
}

export function Mut3$reflection(): TypeInfo {
    return record_type("Components_spi.Mut3", [], Mut3, () => [["l0", US11$reflection()], ["l1", Mut2$reflection()], ["l2", US12$reflection()]]);
}

export class Mut4 extends Record {
    l0: boolean;
    l1: boolean;
    l2: US11;
    l3: Mut2;
    constructor(l0: boolean, l1: boolean, l2: US11, l3: Mut2) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
        this.l3 = l3;
    }
}

export function Mut4$reflection(): TypeInfo {
    return record_type("Components_spi.Mut4", [], Mut4, () => [["l0", bool_type], ["l1", bool_type], ["l2", US11$reflection()], ["l3", Mut2$reflection()]]);
}

export class Mut5 extends Record {
    l0: int32;
    constructor(l0: int32) {
        super();
        this.l0 = (l0 | 0);
    }
}

export function Mut5$reflection(): TypeInfo {
    return record_type("Components_spi.Mut5", [], Mut5, () => [["l0", int32_type]]);
}

export class Mut6 extends Record {
    l0: (arg0: Mut1) => US1;
    l1: (arg0: Mut1, arg1: Mut1, arg2: US1) => void;
    constructor(l0: (arg0: Mut1) => US1, l1: (arg0: Mut1, arg1: Mut1, arg2: US1) => void) {
        super();
        this.l0 = l0;
        this.l1 = l1;
    }
}

export function Mut6$reflection(): TypeInfo {
    return record_type("Components_spi.Mut6", [], Mut6, () => [["l0", lambda_type(Mut1$reflection(), US1$reflection())], ["l1", lambda_type(Mut1$reflection(), lambda_type(Mut1$reflection(), lambda_type(US1$reflection(), unit_type)))]]);
}

export class Mut7 extends Record {
    l0: (arg0: Mut1) => US0;
    l1: (arg0: Mut1, arg1: Mut1, arg2: US0) => void;
    constructor(l0: (arg0: Mut1) => US0, l1: (arg0: Mut1, arg1: Mut1, arg2: US0) => void) {
        super();
        this.l0 = l0;
        this.l1 = l1;
    }
}

export function Mut7$reflection(): TypeInfo {
    return record_type("Components_spi.Mut7", [], Mut7, () => [["l0", lambda_type(Mut1$reflection(), US0$reflection())], ["l1", lambda_type(Mut1$reflection(), lambda_type(Mut1$reflection(), lambda_type(US0$reflection(), unit_type)))]]);
}

export class Mut8 extends Record {
    l0: US2;
    constructor(l0: US2) {
        super();
        this.l0 = l0;
    }
}

export function Mut8$reflection(): TypeInfo {
    return record_type("Components_spi.Mut8", [], Mut8, () => [["l0", US2$reflection()]]);
}

export class Mut9 extends Record {
    l0: US2;
    l1: (arg0: [US2, int32, string, string]) => US1;
    l2: (arg0: [US2, int32, string, string], arg1: US1) => [US2, int32, string, string];
    constructor(l0: US2, l1: (arg0: [US2, int32, string, string]) => US1, l2: (arg0: [US2, int32, string, string], arg1: US1) => [US2, int32, string, string]) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
    }
}

export function Mut9$reflection(): TypeInfo {
    return record_type("Components_spi.Mut9", [], Mut9, () => [["l0", US2$reflection()], ["l1", lambda_type(tuple_type(US2$reflection(), int32_type, string_type, string_type), US1$reflection())], ["l2", lambda_type(tuple_type(US2$reflection(), int32_type, string_type, string_type), lambda_type(US1$reflection(), tuple_type(US2$reflection(), int32_type, string_type, string_type)))]]);
}

export class Mut10 extends Record {
    l0: int32;
    l1: US1;
    constructor(l0: int32, l1: US1) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = l1;
    }
}

export function Mut10$reflection(): TypeInfo {
    return record_type("Components_spi.Mut10", [], Mut10, () => [["l0", int32_type], ["l1", US1$reflection()]]);
}

export const enum US13_Tag {
    US13_0 = 0,
    US13_1 = 1
}

export type US13_Fields = [[], [US2, int32, string, string]];

export type US13 = US13_Cons<US13_Tag.US13_0> | US13_Cons<US13_Tag.US13_1>;

export function US13_US13_0() {
    return new US13_Cons<US13_Tag.US13_0>(US13_Tag.US13_0, []);
}

export function US13_US13_1(f1_0: US2, f1_1: int32, f1_2: string, f1_3: string) {
    return new US13_Cons<US13_Tag.US13_1>(US13_Tag.US13_1, [f1_0, f1_1, f1_2, f1_3]);
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
    return union_type("Components_spi.US13", [], US13_Cons, () => [[], [["f1_0", US2$reflection()], ["f1_1", int32_type], ["f1_2", string_type], ["f1_3", string_type]]]);
}

export class Mut11 extends Record {
    l0: int32;
    l1: US13;
    constructor(l0: int32, l1: US13) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = l1;
    }
}

export function Mut11$reflection(): TypeInfo {
    return record_type("Components_spi.Mut11", [], Mut11, () => [["l0", int32_type], ["l1", US13$reflection()]]);
}

export class Mut12 extends Record {
    l0: US2;
    l1: (arg0: [US2, int32, string, string]) => US0;
    l2: (arg0: [US2, int32, string, string], arg1: US0) => [US2, int32, string, string];
    constructor(l0: US2, l1: (arg0: [US2, int32, string, string]) => US0, l2: (arg0: [US2, int32, string, string], arg1: US0) => [US2, int32, string, string]) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
    }
}

export function Mut12$reflection(): TypeInfo {
    return record_type("Components_spi.Mut12", [], Mut12, () => [["l0", US2$reflection()], ["l1", lambda_type(tuple_type(US2$reflection(), int32_type, string_type, string_type), US0$reflection())], ["l2", lambda_type(tuple_type(US2$reflection(), int32_type, string_type, string_type), lambda_type(US0$reflection(), tuple_type(US2$reflection(), int32_type, string_type, string_type)))]]);
}

export class Mut13 extends Record {
    l0: int32;
    l1: US0;
    constructor(l0: int32, l1: US0) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = l1;
    }
}

export function Mut13$reflection(): TypeInfo {
    return record_type("Components_spi.Mut13", [], Mut13, () => [["l0", int32_type], ["l1", US0$reflection()]]);
}

export function method0(): [[string, string, string, string][], US0, US1, US1, [US2, int32, string, string][], [US2, US2][], US1, US0] {
    return [[["4ZZJNAAPJGOUBHORYKX5DQSJJIMQLADNUIH7ONXZAVEZYZGOAM5CM7HV2M", "admin", "poem slush dry adult final thunder price pause concert topic mesh wild dry gate judge celery winter list promote clump country loan move about faith", "OBVzhzxAK4ZPdaF1QbkXsd8hgRUPJeCfYFjFghgMGnLmcpaAD0mdQJ3Rwq/RwklKGQWAbaIP9zb5BUmcZM4DOg=="], ["Q2MAJEB7HYFK42KSN2MY26PL3P5P7HVIGR22GDAGCJQUARDEIM4WLHSIFQ", "x", "crater dove click normal kitten aisle obvious error exotic lunar guard impact donkey gun lamp divide announce match cement excess piano turn fish above make", "lHFQVWKpvRYU00yAQqHOHJegn5nvP0owYkroBFKr94qGmASQPz4KrmlSbpmNeevb+v+eqDR1owwGEmFARGRDOQ=="], ["KVGJONR4BETXZ3AS224T4MAJATTSTQGVO3VC3YAGSWAYBVD7KPR23RKNBI", "o", "key churn alert mother lock run lyrics category office lamp silver nut cement pistol fury hollow faculty feed capable announce index cloth faint about bid", "0DNKDAK5QfWuMCTMNJ+Re5mSlc7rbI0q1UOUYDmvPGpVTJc2PAknfOwS1rk+MAkE5ynA1XbqLeAGlYGA1H9T4w=="]], US0_US0_1(4001), US1_US1_1("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"), US1_US1_1("http://localhost"), [], [], US1_US1_0(), US0_US0_0()];
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

export function method2(): [any, string, boolean] {
    const v0_1: any = components_spi.env;
    const v1_1: string = v0_1.GITHUB_RUN_ID;
    const v2: any = v0_1.IS_TEST;
    return [v0_1, v1_1, (!v2) === false];
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

export function closure3(v0_1: any, v1_1: string, v2: boolean, v3: int64, _arg: [Mut1, Mut1, any]): void {
    let copyOfStruct: Date;
    const v5: Mut1 = _arg[1];
    const v11: any[] = [">> db_listener store.on(@changed)", ["b_changed:", v5]];
    const v18: string = `[${method3(6, toString(op_Subtraction(op_Division((copyOfStruct = utcNow(), getTicks(copyOfStruct)), fromBits(1000, 0, false)), v3)))}] ${components_spi.run_id}`;
    const v19: string = JSON.stringify(v11);
    const v21: string = JSON.stringify([]);
    let patternInput: [string, string, string, string, string];
    if (v2) {
        const v22: string = "";
        patternInput = [v18, v19, v21, v22, v22];
    }
    else {
        patternInput = [`${v18} %c%s %c%s`, `font-weight: bold; color: ${"#cf1100"}`, v19, "font-weight: bold; color: #444", v21];
    }
    console.log.apply(console, [patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4]]);
    const patternInput_1: [[US2, int32, string, string][], [US2, US2][]] = [v5.l4, v5.l5];
    let v40: boolean;
    if ((!patternInput_1[1]) === false) {
        v40 = true;
    }
    else {
        const patternInput_2: [[US2, int32, string, string][], [US2, US2][]] = [v5.l4, v5.l5];
        v40 = ((!patternInput_2[0]) === false);
    }
}

export function closure2(v0_1: any, v1_1: Mut2): any {
    let copyOfStruct: Date, copyOfStruct_1: Date;
    const patternInput: [any, string, boolean] = method2();
    const v4: boolean = patternInput[2];
    const v5: int64 = op_Division((copyOfStruct = utcNow(), getTicks(copyOfStruct)), fromBits(1000, 0, false));
    const v8: any[] = ["> db_listener ()"];
    const v15: string = `[${method3(6, toString(op_Subtraction(op_Division((copyOfStruct_1 = utcNow(), getTicks(copyOfStruct_1)), fromBits(1000, 0, false)), v5)))}] ${components_spi.run_id}`;
    const v16: string = JSON.stringify(v8);
    const v18: string = JSON.stringify([]);
    let patternInput_1: [string, string, string, string, string];
    if (v4) {
        const v19: string = "";
        patternInput_1 = [v15, v16, v18, v19, v19];
    }
    else {
        patternInput_1 = [`${v15} %c%s %c%s`, `font-weight: bold; color: ${"#cf1100"}`, v16, "font-weight: bold; color: #444", v18];
    }
    console.log.apply(console, [patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4]]);
    const v29: any = v0_1.on;
    const v30: (arg0: [Mut1, Mut1, any]) => void = (arg10$0040: [Mut1, Mut1, any]): void => {
        closure3(patternInput[0], patternInput[1], v4, v5, arg10$0040);
    };
    const v31: any = (...args: any[]) => v30(args);
    const v32: () => void = v29("@changed", v31);
    const v35: any = onCleanup;
    v35(v32);
    return <></>;
}

export function closure8(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function method5(): [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] {
    return [US1_US1_0(), US3_US3_0(), US1_US1_0(), US1_US1_0(), US1_US1_0(), US1_US1_0(), US1_US1_0(), US1_US1_0(), US4_US4_0(), US5_US5_0(), US1_US1_0(), US1_US1_0(), US4_US4_0(), US6_US6_0(), US1_US1_0(), US1_US1_0(), US1_US1_0(), US7_US7_0(), US4_US4_0(), US1_US1_0(), US1_US1_0(), US1_US1_0(), US1_US1_0(), US1_US1_0(), US8_US8_0(), US1_US1_0(), US1_US1_0(), US1_US1_0(), US6_US6_0(), US1_US1_0(), US1_US1_0(), US1_US1_0(), US1_US1_0(), US1_US1_0(), US1_US1_0(), US1_US1_0(), US1_US1_0(), US9_US9_0(), US10_US10_0(), US9_US9_0(), US1_US1_0(), US1_US1_0(), US1_US1_0(), US1_US1_0(), US1_US1_0(), US1_US1_0(), US1_US1_0(), US1_US1_0(), US1_US1_0(), US1_US1_0(), US1_US1_0(), US1_US1_0(), US1_US1_0(), US1_US1_0(), US1_US1_0(), US8_US8_0(), US1_US1_0(), US1_US1_0(), US6_US6_0(), US1_US1_0(), US0_US0_0(), US1_US1_0()];
}

export function method4(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    v62.l16 = US1_US1_1("flex");
    v62.l20 = US1_US1_1("column");
    v62.l2 = US1_US1_1("$blackAlpha3");
    v62.l30 = US1_US1_1("-1px");
    return v62;
}

export function method6(v0_1: () => any[], v1_1: Mut2): Mut2 {
    v1_1.l9 = US5_US5_1(v0_1);
    v1_1.children = v0_1;
    return v1_1;
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

export function method7(v0_1: Mut2): [string, any][] {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = [v0_1.l0, v0_1.l1, v0_1.l2, v0_1.l3, v0_1.l4, v0_1.l5, v0_1.l6, v0_1.l7, v0_1.l8, v0_1.l9, v0_1.l10, v0_1.l11, v0_1.l12, v0_1.l13, v0_1.l14, v0_1.l15, v0_1.l16, v0_1.l17, v0_1.l18, v0_1.l19, v0_1.l20, v0_1.l21, v0_1.l22, v0_1.l23, v0_1.l24, v0_1.l25, v0_1.l26, v0_1.l27, v0_1.l28, v0_1.l29, v0_1.l30, v0_1.l31, v0_1.l32, v0_1.l33, v0_1.l34, v0_1.l35, v0_1.l36, v0_1.l37, v0_1.l38, v0_1.l39, v0_1.l40, v0_1.l41, v0_1.l42, v0_1.l43, v0_1.l44, v0_1.l45, v0_1.l46, v0_1.l47, v0_1.l48, v0_1.l49, v0_1.l50, v0_1.l51, v0_1.l52, v0_1.l53, v0_1.l54, v0_1.l55, v0_1.l56, v0_1.l57, v0_1.l58, v0_1.l59, v0_1.l60, v0_1.l61];
    const v9: US4 = patternInput[8];
    const v8: US1 = patternInput[7];
    const v7: US1 = patternInput[6];
    const v62: US1 = patternInput[61];
    const v61: US0 = patternInput[60];
    const v60: US1 = patternInput[59];
    const v6: US1 = patternInput[5];
    const v59: US6 = patternInput[58];
    const v58: US1 = patternInput[57];
    const v57: US1 = patternInput[56];
    const v56: US8 = patternInput[55];
    const v55: US1 = patternInput[54];
    const v54: US1 = patternInput[53];
    const v53: US1 = patternInput[52];
    const v52: US1 = patternInput[51];
    const v51: US1 = patternInput[50];
    const v50: US1 = patternInput[49];
    const v5: US1 = patternInput[4];
    const v49: US1 = patternInput[48];
    const v48: US1 = patternInput[47];
    const v47: US1 = patternInput[46];
    const v46: US1 = patternInput[45];
    const v45: US1 = patternInput[44];
    const v44: US1 = patternInput[43];
    const v43: US1 = patternInput[42];
    const v42: US1 = patternInput[41];
    const v41: US1 = patternInput[40];
    const v40: US9 = patternInput[39];
    const v4: US1 = patternInput[3];
    const v39: US10 = patternInput[38];
    const v38: US9 = patternInput[37];
    const v37: US1 = patternInput[36];
    const v36: US1 = patternInput[35];
    const v35: US1 = patternInput[34];
    const v34: US1 = patternInput[33];
    const v33: US1 = patternInput[32];
    const v32: US1 = patternInput[31];
    const v31: US1 = patternInput[30];
    const v30: US1 = patternInput[29];
    const v3: US1 = patternInput[2];
    const v29: US6 = patternInput[28];
    const v28: US1 = patternInput[27];
    const v27: US1 = patternInput[26];
    const v26: US1 = patternInput[25];
    const v25: US8 = patternInput[24];
    const v24: US1 = patternInput[23];
    const v23: US1 = patternInput[22];
    const v22: US1 = patternInput[21];
    const v21: US1 = patternInput[20];
    const v20: US1 = patternInput[19];
    const v2: US3 = patternInput[1];
    const v19: US4 = patternInput[18];
    const v18: US7 = patternInput[17];
    const v17: US1 = patternInput[16];
    const v16: US1 = patternInput[15];
    const v15: US1 = patternInput[14];
    const v14: US6 = patternInput[13];
    const v13: US4 = patternInput[12];
    const v12: US1 = patternInput[11];
    const v11: US1 = patternInput[10];
    const v10: US5 = patternInput[9];
    const v1_1: US1 = patternInput[0];
    const v66_1: any = (v1_1.tag === US1_Tag.US1_1) ? v1_1.fields[0] : (void 0);
    const v73_1: UH0 = (!v66_1) ? UH0_UH0_1() : UH0_UH0_0(["aria-label", v66_1], UH0_UH0_1());
    const v77_1: any = (v2.tag === US3_Tag.US3_1) ? v2.fields[0] : (void 0);
    const v82_1: UH0 = (!v77_1) ? v73_1 : UH0_UH0_0(["as", v77_1], v73_1);
    const v86_1: any = (v3.tag === US1_Tag.US1_1) ? v3.fields[0] : (void 0);
    const v91_1: UH0 = (!v86_1) ? v82_1 : UH0_UH0_0(["backgroundColor", v86_1], v82_1);
    const v95: any = (v4.tag === US1_Tag.US1_1) ? v4.fields[0] : (void 0);
    const v100: UH0 = (!v95) ? v91_1 : UH0_UH0_0(["border", v95], v91_1);
    const v104: any = (v5.tag === US1_Tag.US1_1) ? v5.fields[0] : (void 0);
    const v109: UH0 = (!v104) ? v100 : UH0_UH0_0(["borderBottomWidth", v104], v100);
    const v113: any = (v6.tag === US1_Tag.US1_1) ? v6.fields[0] : (void 0);
    const v118: UH0 = (!v113) ? v109 : UH0_UH0_0(["borderColor", v113], v109);
    const v122: any = (v7.tag === US1_Tag.US1_1) ? v7.fields[0] : (void 0);
    const v127: UH0 = (!v122) ? v118 : UH0_UH0_0(["borderWidth", v122], v118);
    const v131: any = (v8.tag === US1_Tag.US1_1) ? v8.fields[0] : (void 0);
    const v136: UH0 = (!v131) ? v127 : UH0_UH0_0(["bottom", v131], v127);
    const v140: any = (v9.tag === US4_Tag.US4_1) ? v9.fields[0] : (void 0);
    const v145: UH0 = (!v140) ? v136 : UH0_UH0_0(["checked", v140], v136);
    const v149: any = (v10.tag === US5_Tag.US5_1) ? v10.fields[0] : (void 0);
    const v154: UH0 = (!v149) ? v145 : UH0_UH0_0(["children", v149], v145);
    const v158: any = (v11.tag === US1_Tag.US1_1) ? v11.fields[0] : (void 0);
    const v163: UH0 = (!v158) ? v154 : UH0_UH0_0(["color", v158], v154);
    const v167: any = (v12.tag === US1_Tag.US1_1) ? v12.fields[0] : (void 0);
    const v172: UH0 = (!v167) ? v163 : UH0_UH0_0(["colorScheme", v167], v163);
    const v176: any = (v13.tag === US4_Tag.US4_1) ? v13.fields[0] : (void 0);
    const v181: UH0 = (!v176) ? v172 : UH0_UH0_0(["compact", v176], v172);
    const v185: any = (v14.tag === US6_Tag.US6_1) ? v14.fields[0] : (void 0);
    const v190: UH0 = (!v185) ? v181 : UH0_UH0_0(["css", v185], v181);
    const v194: any = (v15.tag === US1_Tag.US1_1) ? v15.fields[0] : (void 0);
    const v199: UH0 = (!v194) ? v190 : UH0_UH0_0(["defaultValue", v194], v190);
    const v203: any = (v16.tag === US1_Tag.US1_1) ? v16.fields[0] : (void 0);
    const v208: UH0 = (!v203) ? v199 : UH0_UH0_0(["direction", v203], v199);
    const v212: any = (v17.tag === US1_Tag.US1_1) ? v17.fields[0] : (void 0);
    const v217: UH0 = (!v212) ? v208 : UH0_UH0_0(["display", v212], v208);
    const v221: any = (v18.tag === US7_Tag.US7_1) ? v18.fields[0] : (void 0);
    const v226: UH0 = (!v221) ? v217 : UH0_UH0_0(["each", v221], v217);
    const v230: any = (v19.tag === US4_Tag.US4_1) ? v19.fields[0] : (void 0);
    const v235: UH0 = (!v230) ? v226 : UH0_UH0_0(["external", v230], v226);
    const v239: any = (v20.tag === US1_Tag.US1_1) ? v20.fields[0] : (void 0);
    const v244: UH0 = (!v239) ? v235 : UH0_UH0_0(["flex", v239], v235);
    const v248: any = (v21.tag === US1_Tag.US1_1) ? v21.fields[0] : (void 0);
    const v253: UH0 = (!v248) ? v244 : UH0_UH0_0(["flexDirection", v248], v244);
    const v257: any = (v22.tag === US1_Tag.US1_1) ? v22.fields[0] : (void 0);
    const v262: UH0 = (!v257) ? v253 : UH0_UH0_0(["fontSize", v257], v253);
    const v266: any = (v23.tag === US1_Tag.US1_1) ? v23.fields[0] : (void 0);
    const v271: UH0 = (!v266) ? v262 : UH0_UH0_0(["height", v266], v262);
    const v275: any = (v24.tag === US1_Tag.US1_1) ? v24.fields[0] : (void 0);
    const v280: UH0 = (!v275) ? v271 : UH0_UH0_0(["href", v275], v271);
    const v284: any = (v25.tag === US8_Tag.US8_1) ? v25.fields[0] : (void 0);
    const v289: UH0 = (!v284) ? v280 : UH0_UH0_0(["icon", v284], v280);
    const v293: any = (v26.tag === US1_Tag.US1_1) ? v26.fields[0] : (void 0);
    const v298: UH0 = (!v293) ? v289 : UH0_UH0_0(["id", v293], v289);
    const v302: any = (v27.tag === US1_Tag.US1_1) ? v27.fields[0] : (void 0);
    const v307: UH0 = (!v302) ? v298 : UH0_UH0_0(["justifyContent", v302], v298);
    const v311: any = (v28.tag === US1_Tag.US1_1) ? v28.fields[0] : (void 0);
    const v316: UH0 = (!v311) ? v307 : UH0_UH0_0(["left", v311], v307);
    const v320: any = (v29.tag === US6_Tag.US6_1) ? v29.fields[0] : (void 0);
    const v325: UH0 = (!v320) ? v316 : UH0_UH0_0(["leftIcon", v320], v316);
    const v329: any = (v30.tag === US1_Tag.US1_1) ? v30.fields[0] : (void 0);
    const v334: UH0 = (!v329) ? v325 : UH0_UH0_0(["lineHeight", v329], v325);
    const v338: any = (v31.tag === US1_Tag.US1_1) ? v31.fields[0] : (void 0);
    const v343: UH0 = (!v338) ? v334 : UH0_UH0_0(["margin", v338], v334);
    const v347: any = (v32.tag === US1_Tag.US1_1) ? v32.fields[0] : (void 0);
    const v352: UH0 = (!v347) ? v343 : UH0_UH0_0(["marginBottom", v347], v343);
    const v356: any = (v33.tag === US1_Tag.US1_1) ? v33.fields[0] : (void 0);
    const v361: UH0 = (!v356) ? v352 : UH0_UH0_0(["marginLeft", v356], v352);
    const v365: any = (v34.tag === US1_Tag.US1_1) ? v34.fields[0] : (void 0);
    const v370: UH0 = (!v365) ? v361 : UH0_UH0_0(["marginRight", v365], v361);
    const v374: any = (v35.tag === US1_Tag.US1_1) ? v35.fields[0] : (void 0);
    const v379: UH0 = (!v374) ? v370 : UH0_UH0_0(["marginTop", v374], v370);
    const v383: any = (v36.tag === US1_Tag.US1_1) ? v36.fields[0] : (void 0);
    const v388: UH0 = (!v383) ? v379 : UH0_UH0_0(["maxHeight", v383], v379);
    const v392: any = (v37.tag === US1_Tag.US1_1) ? v37.fields[0] : (void 0);
    const v397: UH0 = (!v392) ? v388 : UH0_UH0_0(["maxWidth", v392], v388);
    const v401: any = (v38.tag === US9_Tag.US9_1) ? v38.fields[0] : (void 0);
    const v406: UH0 = (!v401) ? v397 : UH0_UH0_0(["onChange", v401], v397);
    const v410: any = (v39.tag === US10_Tag.US10_1) ? v39.fields[0] : (void 0);
    const v415: UH0 = (!v410) ? v406 : UH0_UH0_0(["onClick", v410], v406);
    const v419: any = (v40.tag === US9_Tag.US9_1) ? v40.fields[0] : (void 0);
    const v424: UH0 = (!v419) ? v415 : UH0_UH0_0(["onInput", v419], v415);
    const v428: any = (v41.tag === US1_Tag.US1_1) ? v41.fields[0] : (void 0);
    const v433: UH0 = (!v428) ? v424 : UH0_UH0_0(["outline", v428], v424);
    const v437: any = (v42.tag === US1_Tag.US1_1) ? v42.fields[0] : (void 0);
    const v442: UH0 = (!v437) ? v433 : UH0_UH0_0(["overflowX", v437], v433);
    const v446: any = (v43.tag === US1_Tag.US1_1) ? v43.fields[0] : (void 0);
    const v451: UH0 = (!v446) ? v442 : UH0_UH0_0(["overflowY", v446], v442);
    const v455: any = (v44.tag === US1_Tag.US1_1) ? v44.fields[0] : (void 0);
    const v460: UH0 = (!v455) ? v451 : UH0_UH0_0(["padding", v455], v451);
    const v464: any = (v45.tag === US1_Tag.US1_1) ? v45.fields[0] : (void 0);
    const v469: UH0 = (!v464) ? v460 : UH0_UH0_0(["paddingBottom", v464], v460);
    const v473: any = (v46.tag === US1_Tag.US1_1) ? v46.fields[0] : (void 0);
    const v478: UH0 = (!v473) ? v469 : UH0_UH0_0(["paddingLeft", v473], v469);
    const v482: any = (v47.tag === US1_Tag.US1_1) ? v47.fields[0] : (void 0);
    const v487: UH0 = (!v482) ? v478 : UH0_UH0_0(["paddingRight", v482], v478);
    const v491: any = (v48.tag === US1_Tag.US1_1) ? v48.fields[0] : (void 0);
    const v496: UH0 = (!v491) ? v487 : UH0_UH0_0(["paddingTop", v491], v487);
    const v500: any = (v49.tag === US1_Tag.US1_1) ? v49.fields[0] : (void 0);
    const v505: UH0 = (!v500) ? v496 : UH0_UH0_0(["position", v500], v496);
    const v509: any = (v50.tag === US1_Tag.US1_1) ? v50.fields[0] : (void 0);
    const v514: UH0 = (!v509) ? v505 : UH0_UH0_0(["right", v509], v505);
    const v518: any = (v51.tag === US1_Tag.US1_1) ? v51.fields[0] : (void 0);
    const v523: UH0 = (!v518) ? v514 : UH0_UH0_0(["size", v518], v514);
    const v527: any = (v52.tag === US1_Tag.US1_1) ? v52.fields[0] : (void 0);
    const v532: UH0 = (!v527) ? v523 : UH0_UH0_0(["spacing", v527], v523);
    const v536: any = (v53.tag === US1_Tag.US1_1) ? v53.fields[0] : (void 0);
    const v541: UH0 = (!v536) ? v532 : UH0_UH0_0(["src", v536], v532);
    const v545: any = (v54.tag === US1_Tag.US1_1) ? v54.fields[0] : (void 0);
    const v550: UH0 = (!v545) ? v541 : UH0_UH0_0(["striped", v545], v541);
    const v554: any = (v55.tag === US1_Tag.US1_1) ? v55.fields[0] : (void 0);
    const v559: UH0 = (!v554) ? v550 : UH0_UH0_0(["thickness", v554], v550);
    const v563: any = (v56.tag === US8_Tag.US8_1) ? v56.fields[0] : (void 0);
    const v568: UH0 = (!v563) ? v559 : UH0_UH0_0(["title", v563], v559);
    const v572: any = (v57.tag === US1_Tag.US1_1) ? v57.fields[0] : (void 0);
    const v577: UH0 = (!v572) ? v568 : UH0_UH0_0(["top", v572], v568);
    const v581: any = (v58.tag === US1_Tag.US1_1) ? v58.fields[0] : (void 0);
    const v586: UH0 = (!v581) ? v577 : UH0_UH0_0(["type", v581], v577);
    const v590: any = (v59.tag === US6_Tag.US6_1) ? v59.fields[0] : (void 0);
    const v595: UH0 = (!v590) ? v586 : UH0_UH0_0(["value", v590], v586);
    const v599: any = (v60.tag === US1_Tag.US1_1) ? v60.fields[0] : (void 0);
    const v604: UH0 = (!v599) ? v595 : UH0_UH0_0(["width", v599], v595);
    const v608: any = (v61.tag === US0_Tag.US0_1) ? v61.fields[0] : (void 0);
    const v613: UH0 = (!v608) ? v604 : UH0_UH0_0(["zIndex", v608], v604);
    const v617: any = (v62.tag === US1_Tag.US1_1) ? v62.fields[0] : (void 0);
    return method8((!v617) ? v613 : UH0_UH0_0(["zoom", v617], v613));
}

export function closure7(v0_1: Mut2, unitVar: void): any[] {
    const v1_1: US5 = v0_1.l9;
    const v7: any = Tbody;
    const v11: any = createObj(method7(method6((v1_1.tag === US5_Tag.US5_1) ? v1_1.fields[0] : ((): any[] => closure8(void 0, void 0)), method4())));
    const v12: (arg0: any) => any = v7;
    const v15: any = createComponent;
    return [v15(v12, v11)];
}

export function method11(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    v62.l16 = US1_US1_1("flex");
    v62.l19 = US1_US1_1("1");
    v62.l20 = US1_US1_1("column");
    const v69_1: string = "hidden";
    v62.l41 = US1_US1_1(v69_1);
    const v71_1: US1 = v62.l42;
    const v73_1: string = (v71_1.tag === US1_Tag.US1_1) ? v71_1.fields[0] : v69_1;
    v62.l42 = US1_US1_1(v73_1);
    return v62;
}

export function closure6(unitVar: void, v0_1: Mut2): any {
    const v3: any = Table;
    const v4: () => any[] = (): any[] => closure7(v0_1, void 0);
    const v8: any = createObj(method7(method6(v4, method11())));
    const v9: (arg0: any) => any = v3;
    const v12: any = createComponent;
    return v12(v9, v8);
}

export function method12(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    v62.l16 = US1_US1_1("flex");
    v62.l19 = US1_US1_1("1");
    v62.l20 = US1_US1_1("column");
    v62.l42 = US1_US1_1("auto");
    v62.l41 = US1_US1_1("hidden");
    return v62;
}

export function closure14(v0_1: any, unitVar: void): any[] {
    return [v0_1];
}

export function method13(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    v62.l47 = US1_US1_1("2px");
    return v62;
}

export function closure13(v0_1: any, unitVar: void): any[] {
    const v3: any = Box;
    const v4: () => any[] = (): any[] => closure14(v0_1, void 0);
    const v8: any = createObj(method7(method6(v4, method13())));
    const v9: (arg0: any) => any = v3;
    const v12: any = createComponent;
    return [v12(v9, v8)];
}

export function closure15(v0_1: (arg0: boolean) => void, v1_1: any): void {
    v0_1(v1_1.target.checked);
}

export function method14(v0_1: (arg0: boolean) => void, v1_1: () => boolean): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v64_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    v64_1.l50 = US1_US1_1("sm");
    v64_1.l31 = US1_US1_1("2px");
    const v69_1: boolean = v1_1();
    v64_1.l8 = US4_US4_1(v69_1);
    v64_1.l11 = US1_US1_1("neutral");
    const v73_1: (arg0: any) => void = (v: any): void => {
        closure15(v0_1, v);
    };
    v64_1.l37 = US9_US9_1(v73_1);
    return v64_1;
}

export function closure12(v0_1: Mut3, v1_1: (arg0: boolean) => void, v2: () => boolean, v3: any, unitVar: void): any[] {
    let v20: any, v21: () => any[], v25: any, v26: (arg0: any) => any, v29: any, v7: any, v8: () => any[], v12: any, v13: (arg0: any) => any, v16: any;
    const v4: US12 = v0_1.l2;
    return [(v4.tag === US12_Tag.US12_1) ? ((v20 = Checkbox, (v21 = ((): any[] => closure13(v3, void 0)), (v25 = createObj(method7(method6(v21, method14(v1_1, v2)))), (v26 = (v20), (v29 = createComponent, v29(v26, v25))))))) : ((v4.tag === US12_Tag.US12_2) ? v3 : ((v7 = Checkbox, (v8 = ((): any[] => closure13(v3, void 0)), (v12 = createObj(method7(method6(v8, method14(v1_1, v2)))), (v13 = (v7), (v16 = createComponent, v16(v13, v12))))))))];
}

export function method15(v0_1: Mut3, v1_1: () => boolean): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v64_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v74_1: string = ((v0_1.l2.tag === US12_Tag.US12_2) ? true : v1_1()) ? {
        "@initial": "2px !important",
        "@sm": "0px !important",
    } : "0px !important";
    v64_1.l4 = US1_US1_1(v74_1);
    v64_1.l5 = US1_US1_1("$neutral5");
    v64_1.l10 = US1_US1_1("$neutral9");
    v64_1.l16 = US1_US1_1("flex");
    v64_1.l20 = US1_US1_1("column");
    v64_1.l21 = US1_US1_1("$sm");
    v64_1.l43 = US1_US1_1("3px 20px 0 8px");
    return v64_1;
}

export function closure16(unitVar: void, unitVar_1: void): any[] {
    return [<>
        &nbsp;
    </>];
}

export function method16(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v63: string = "0";
    v62.l3 = US1_US1_1(v63);
    v62.l43 = US1_US1_1(v63);
    v62.l29 = US1_US1_1("9px");
    return v62;
}

export function closure19(v0_1: () => boolean, unitVar: void): any[] {
    return [v0_1()];
}

export function closure20(v0_1: (arg0: boolean) => void, v1_1: () => boolean, unitVar: void): void {
    if (v1_1()) {
        v0_1(false);
    }
}

export function closure21(v0_1: Mut1, v1_1: any, v2: (arg0: Mut1, arg1: Mut1) => void): void {
    const v5: Mut1 = createObj(fill(new Array(0), 0, 0, null));
    v2(v0_1, v5);
    v1_1("set", v5);
}

export function closure25(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function method19(v0_1: int32, v1_1: Mut5): boolean {
    return v1_1.l0 < v0_1;
}

export function method18(v0_1: Mut2, v1_1: Mut2): void {
    const v2: string[] = Object.keys(v1_1);
    const v3: int32 = v2.length | 0;
    const v4: Mut5 = new Mut5(0);
    while (method19(v3, v4)) {
        const v6: int32 = v4.l0 | 0;
        const v7: string = v2[v6];
        if (!!v1_1[v7].tag) {
            v0_1[v7] = v1_1[v7];
        }
        const v9: int32 = (v6 + 1) | 0;
        v4.l0 = (v9 | 0);
    }
}

export function method17(v0_1: Mut2): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v63: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    v63.l50 = US1_US1_1("xs");
    v63.l26 = US1_US1_1("left");
    v63.l12 = US4_US4_1(true);
    v63.l11 = US1_US1_1("neutral");
    method18(v63, v0_1);
    return v63;
}

export function closure24(unitVar: void, v0_1: Mut2): any {
    const v3: any = Button;
    const v4: () => any[] = (): any[] => closure25(void 0, void 0);
    const v8: any = createObj(method7(method6(v4, method17(v0_1))));
    const v9: (arg0: any) => any = v3;
    const v12: any = createComponent;
    return v12(v9, v8);
}

export function closure26(v0_1: (arg0: boolean) => void, v1_1: Mut4, v2: Mut1, v3: any, unitVar: void): void {
    const v4: US11 = v1_1.l2;
    if (v4.tag === US11_Tag.US11_1) {
        const v7: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void = (v: (arg0: Mut1, arg1: Mut1) => void): void => {
            closure21(v2, v3, uncurry(2, v));
        };
        v4.fields[0](v2, v7);
    }
    v0_1(true);
}

export function method20(v0_1: (arg0: boolean) => void, v1_1: Mut4, v2: Mut1, v3: any): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v66_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v67_1: () => void = (): void => {
        closure26(v0_1, v1_1, v2, v3, void 0);
    };
    v66_1.l38 = US10_US10_1(v67_1);
    return v66_1;
}

export function closure27(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Load
    </>];
}

export function closure23(v0_1: (arg0: boolean) => void, v1_1: Mut4, v2: Mut1, v3: any, unitVar: void): any[] {
    const v4: (arg0: Mut2) => any = (v: Mut2): any => closure24(void 0, v);
    const v6: () => any[] = (): any[] => closure27(void 0, void 0);
    const v7: Mut2 = method6(v6, method20(v0_1, v1_1, v2, v3));
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = [v7.l0, v7.l1, v7.l2, v7.l3, v7.l4, v7.l5, v7.l6, v7.l7, v7.l8, v7.l9, v7.l10, v7.l11, v7.l12, v7.l13, v7.l14, v7.l15, v7.l16, v7.l17, v7.l18, v7.l19, v7.l20, v7.l21, v7.l22, v7.l23, v7.l24, v7.l25, v7.l26, v7.l27, v7.l28, v7.l29, v7.l30, v7.l31, v7.l32, v7.l33, v7.l34, v7.l35, v7.l36, v7.l37, v7.l38, v7.l39, v7.l40, v7.l41, v7.l42, v7.l43, v7.l44, v7.l45, v7.l46, v7.l47, v7.l48, v7.l49, v7.l50, v7.l51, v7.l52, v7.l53, v7.l54, v7.l55, v7.l56, v7.l57, v7.l58, v7.l59, v7.l60, v7.l61];
    const v70_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v72_1: (arg0: any) => any = v4;
    const v75_1: any = createComponent;
    return [v75_1(v72_1, v70_1)];
}

export function method21(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    v62.l43 = US1_US1_1("3px 0");
    return v62;
}

export function closure31(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure32(v0_1: (arg0: boolean) => void, unitVar: void): void {
    v0_1(true);
}

export function closure33(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function method24(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    v62.l61 = US1_US1_1("0.6");
    const v65_1: string = "-12px";
    v62.l34 = US1_US1_1(v65_1);
    v62.l32 = US1_US1_1(v65_1);
    return v62;
}

export function method23(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v65_1: any = BiRegularRefresh;
    v62.l1 = US3_US3_1(v65_1);
    v62.l50 = US1_US1_1("14px");
    const v71_1: any = createObj(method7(method24()));
    v62.l13 = US6_US6_1(v71_1);
    return v62;
}

export function method22(v0_1: (arg0: boolean) => void): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v63: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    v63.l0 = US1_US1_1("Refresh");
    v63.l50 = US1_US1_1("xs");
    v63.l22 = US1_US1_1("20px");
    v63.l11 = US1_US1_1("neutral");
    const v72_1: () => void = (): void => {
        closure32(v0_1, void 0);
    };
    v63.l38 = US10_US10_1(v72_1);
    const v76_1: any = Icon;
    const v77_1: () => any[] = (): any[] => closure33(void 0, void 0);
    const v81_1: any = createObj(method7(method6(v77_1, method23())));
    const v82_1: (arg0: any) => any = v76_1;
    const v85_1: any = createComponent;
    const v86_1: any = v85_1(v82_1, v81_1);
    v63.l24 = US8_US8_1(v86_1);
    return v63;
}

export function closure34(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure35(v0_1: Mut1, v1_1: any, v2: int32, v3: (arg0: boolean) => void, v4: () => boolean, unitVar: void): void {
    const v6: boolean = v4() === false;
    v3(v6);
    const v9: Mut1 = createObj(fill(new Array(0), 0, 0, null));
    const v12: US0 = v6 ? US0_US0_1(v2) : US0_US0_0();
    v9.l7 = v12;
    v1_1("set", v9);
}

export function closure36(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure37(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularDownArrow;
    return v2;
}

export function closure38(unitVar: void, unitVar_1: void): any {
    const v2: any = BiRegularUpArrow;
    return v2;
}

export function method27(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    v62.l61 = US1_US1_1("0.6");
    const v65_1: string = "-12px";
    v62.l34 = US1_US1_1(v65_1);
    v62.l32 = US1_US1_1(v65_1);
    return v62;
}

export function method26(v0_1: () => boolean): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v63: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v68_1: any = (v0_1() ? ((): any => closure37(void 0, void 0)) : ((): any => closure38(void 0, void 0)))();
    v63.l1 = US3_US3_1(v68_1);
    v63.l50 = US1_US1_1("14px");
    const v74_1: any = createObj(method7(method27()));
    v63.l13 = US6_US6_1(v74_1);
    return v63;
}

export function method25(v0_1: Mut1, v1_1: any, v2: int32, v3: (arg0: boolean) => void, v4: () => boolean): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v67_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v71_1: string = v4() ? "Restore" : "Maximize";
    v67_1.l0 = US1_US1_1(v71_1);
    v67_1.l50 = US1_US1_1("xs");
    v67_1.l22 = US1_US1_1("20px");
    v67_1.l11 = US1_US1_1("neutral");
    const v79_1: () => void = (): void => {
        closure35(v0_1, v1_1, v2, v3, v4, void 0);
    };
    v67_1.l38 = US10_US10_1(v79_1);
    const v83_1: any = Icon;
    const v84_1: () => any[] = (): any[] => closure36(void 0, void 0);
    const v88_1: any = createObj(method7(method6(v84_1, method26(v4))));
    const v89_1: (arg0: any) => any = v83_1;
    const v92: any = createComponent;
    const v93: any = v92(v89_1, v88_1);
    v67_1.l24 = US8_US8_1(v93);
    return v67_1;
}

export function closure39(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure40(v0_1: (arg0: boolean) => void, unitVar: void): void {
    v0_1(false);
}

export function closure41(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function method30(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    v62.l61 = US1_US1_1("0.6");
    const v65_1: string = "-12px";
    v62.l34 = US1_US1_1(v65_1);
    v62.l32 = US1_US1_1(v65_1);
    return v62;
}

export function method29(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v65_1: any = BiRegularUndo;
    v62.l1 = US3_US3_1(v65_1);
    v62.l50 = US1_US1_1("14px");
    const v71_1: any = createObj(method7(method30()));
    v62.l13 = US6_US6_1(v71_1);
    return v62;
}

export function method28(v0_1: (arg0: boolean) => void): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v63: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    v63.l0 = US1_US1_1("Unload");
    v63.l50 = US1_US1_1("xs");
    v63.l22 = US1_US1_1("20px");
    v63.l11 = US1_US1_1("neutral");
    const v72_1: () => void = (): void => {
        closure40(v0_1, void 0);
    };
    v63.l38 = US10_US10_1(v72_1);
    const v76_1: any = Icon;
    const v77_1: () => any[] = (): any[] => closure41(void 0, void 0);
    const v81_1: any = createObj(method7(method6(v77_1, method29())));
    const v82_1: (arg0: any) => any = v76_1;
    const v85_1: any = createComponent;
    const v86_1: any = v85_1(v82_1, v81_1);
    v63.l24 = US8_US8_1(v86_1);
    return v63;
}

export function closure30(v0_1: Mut1, v1_1: any, v2: int32, v3: (arg0: boolean) => void, v4: (arg0: boolean) => void, v5: (arg0: boolean) => void, v6: () => boolean, unitVar: void): any[] {
    const v9: any = IconButton;
    const v10: () => any[] = (): any[] => closure31(void 0, void 0);
    const v14: any = createObj(method7(method6(v10, method22(v4))));
    const v15: (arg0: any) => any = v9;
    const v18: any = createComponent;
    const v19: any = v18(v15, v14);
    const v20: any = IconButton;
    const v21: () => any[] = (): any[] => closure34(void 0, void 0);
    const v25: any = createObj(method7(method6(v21, method25(v0_1, v1_1, v2, v5, v6))));
    const v26: (arg0: any) => any = v20;
    const v27: any = createComponent;
    const v28: any = v27(v26, v25);
    const v29: any = IconButton;
    const v30: () => any[] = (): any[] => closure39(void 0, void 0);
    const v34: any = createObj(method7(method6(v30, method28(v3))));
    const v35: (arg0: any) => any = v29;
    const v36: any = createComponent;
    return [v19, v28, v36(v35, v34)];
}

export function method31(v0_1: Mut1, v1_1: int32): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v64_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v65_1: US0 = v0_1.l7;
    if (v65_1.tag === US0_Tag.US0_1) {
        if ((v65_1.fields[0] === v1_1) !== true) {
            v64_1.l16 = US1_US1_1("none");
        }
    }
    v64_1.l15 = US1_US1_1("row");
    v64_1.l51 = US1_US1_1("3px");
    v64_1.l48 = US1_US1_1("absolute");
    const v77_1: string = "6px";
    v64_1.l56 = US1_US1_1(v77_1);
    v64_1.l49 = US1_US1_1(v77_1);
    v64_1.l60 = US0_US0_1(1);
    return v64_1;
}

export function closure29(v0_1: Mut1, v1_1: any, v2: int32, v3: (arg0: boolean) => void, v4: (arg0: boolean) => void, v5: () => boolean, v6: (arg0: boolean) => void, v7: () => boolean, v8: () => any[], unitVar: void): any[] {
    const v11: any = Stack;
    const v12: () => any[] = (): any[] => closure30(v0_1, v1_1, v2, v3, v4, v6, v7, void 0);
    const v16: any = createObj(method7(method6(v12, method31(v0_1, v2))));
    const v17: (arg0: any) => any = v11;
    const v20: any = createComponent;
    return [v20(v17, v16), v5() ? <></> : v8];
}

export function method32(v0_1: Mut1): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v63: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    if (v0_1.l7.tag === US0_Tag.US0_0) {
        v63.l48 = US1_US1_1("relative");
    }
    v63.l19 = US1_US1_1("1");
    v63.l16 = US1_US1_1("flex");
    return v63;
}

export function closure28(v0_1: Mut2, v1_1: Mut1, v2: any, v3: int32, v4: (arg0: boolean) => void, v5: (arg0: boolean) => void, v6: () => boolean, v7: (arg0: boolean) => void, v8: () => boolean, unitVar: void): any[] {
    let v14: any, v15: () => any[], v19: any, v20: (arg0: any) => any, v23: any;
    const v9: US5 = v0_1.l9;
    return [(v9.tag === US5_Tag.US5_1) ? ((v14 = Box, (v15 = ((): any[] => closure29(v1_1, v2, v3, v4, v5, v6, v7, v8, v9.fields[0], void 0)), (v19 = createObj(method7(method6(v15, method32(v1_1)))), (v20 = (v14), (v23 = createComponent, v23(v20, v19))))))) : <></>];
}

export function method33(v0_1: () => boolean): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v63: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    if (v0_1()) {
        v63.l60 = US0_US0_1(1);
        v63.l48 = US1_US1_1("absolute");
        const v68_1: string = "0";
        v63.l56 = US1_US1_1(v68_1);
        v63.l49 = US1_US1_1(v68_1);
        v63.l7 = US1_US1_1(v68_1);
        v63.l27 = US1_US1_1(v68_1);
        v63.l2 = US1_US1_1("$bg");
    }
    v63.l16 = US1_US1_1("flex");
    v63.l19 = US1_US1_1("1");
    return v63;
}

export function closure22(v0_1: Mut2, v1_1: Mut1, v2: any, v3: int32, v4: (arg0: boolean) => void, v5: () => boolean, v6: (arg0: boolean) => void, v7: () => boolean, v8: (arg0: boolean) => void, v9: () => boolean, v10: Mut4, unitVar: void): any[] {
    let v15: any, v16: () => any[], v20: any, v21: (arg0: any) => any, v24: any, v28: any, v29: () => any[], v33: any, v34: (arg0: any) => any, v37: any;
    return [(v5() === false) ? ((v15 = Box, (v16 = ((): any[] => closure23(v4, v10, v1_1, v2, void 0)), (v20 = createObj(method7(method6(v16, method21()))), (v21 = (v15), (v24 = createComponent, v24(v21, v20))))))) : ((v28 = Box, (v29 = ((): any[] => closure28(v0_1, v1_1, v2, v3, v4, v6, v7, v8, v9, void 0)), (v33 = createObj(method7(method6(v29, method33(v9)))), (v34 = (v28), (v37 = createComponent, v37(v34, v33)))))))];
}

export function method34(v0_1: Mut2): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v63: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v64_1: US1 = v0_1.l25;
    v63.l25 = v64_1;
    v0_1.l16 = US1_US1_1("flex");
    v0_1.l19 = US1_US1_1("1");
    return v63;
}

export function closure18(unitVar: void, v0_1: Mut4): any {
    const v1_1: Mut2 = v0_1.l3;
    const v4: any = useStoreon;
    const v5: any[] = v4();
    const v6: Mut1 = v5[0];
    const v7: any = v5[1];
    const v8: int32 = nonSeeded().Next0() | 0;
    const v9: boolean = v0_1.l0;
    const v12: any = createSignal;
    const v13: any[] = v12(v9);
    let v14: () => boolean;
    const value_4: any = v13[0];
    v14 = (value_4);
    let v15: (arg0: boolean) => void;
    const value_5: any = v13[1];
    v15 = ((arg_1: boolean): void => {
        value_5(arg_1);
    });
    const v16: any = createSignal;
    const v17: any[] = v16(false);
    let v18: () => boolean;
    const value_7: any = v17[0];
    v18 = (value_7);
    let v19: (arg0: boolean) => void;
    const value_8: any = v17[1];
    v19 = ((arg_3: boolean): void => {
        value_8(arg_3);
    });
    const v20: boolean = v0_1.l1;
    const v21: any = createSignal;
    const v22: any[] = v21(v20);
    let v23: () => boolean;
    const value_10: any = v22[0];
    v23 = (value_10);
    let v24: (arg0: boolean) => void;
    const value_11: any = v22[1];
    v24 = ((arg_5: boolean): void => {
        value_11(arg_5);
    });
    const v26: any = on;
    const v27: () => any[] = (): any[] => closure19(v18, void 0);
    const v28: () => void = (): void => {
        closure20(v19, v18, void 0);
    };
    const v29: any = v26(v27, v28);
    const v31: any = createEffect;
    v31(v29);
    if (v0_1.l0 === true) {
        const v34: US11 = v0_1.l2;
        if (v34.tag === US11_Tag.US11_1) {
            const v37: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void = (v: (arg0: Mut1, arg1: Mut1) => void): void => {
                closure21(v6, v7, uncurry(2, v));
            };
            v34.fields[0](v6, v37);
        }
    }
    const v40: any = Box;
    const v41: () => any[] = (): any[] => closure22(v1_1, v6, v7, v8, v15, v14, v19, v18, v24, v23, v0_1, void 0);
    const v45: any = createObj(method7(method6(v41, method34(v1_1))));
    const v46: (arg0: any) => any = v40;
    const v48: any = createComponent;
    return v48(v46, v45);
}

export function method35(v0_1: () => any[]): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v63: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    v63.l9 = US5_US5_1(v0_1);
    return v63;
}

export function closure17(v0_1: Mut3, v1_1: () => boolean, v2: () => any[], unitVar: void): any[] {
    let v18: (arg0: Mut4) => any, v21: Mut4, v23: (arg0: any) => any, v26: any, v5: (arg0: Mut4) => any, v8: Mut4, v10: (arg0: any) => any, v13: any;
    const v3: US12 = v0_1.l2;
    return [(v3.tag === US12_Tag.US12_1) ? (v1_1() ? ((v18 = ((v_1: Mut4): any => closure18(void 0, v_1)), (v21 = (new Mut4(true, false, v0_1.l0, method35(v2))), (v23 = (v18), (v26 = createComponent, v26(v23, v21)))))) : <></>) : ((v3.tag === US12_Tag.US12_2) ? v2 : (v1_1() ? ((v5 = ((v: Mut4): any => closure18(void 0, v)), (v8 = (new Mut4(true, false, v0_1.l0, method35(v2))), (v10 = (v5), (v13 = createComponent, v13(v10, v8)))))) : <></>))];
}

export function method36(v0_1: Mut2): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v63: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v64_1: string = "0";
    v63.l3 = US1_US1_1(v64_1);
    v63.l40 = US1_US1_1(v64_1);
    v63.l30 = US1_US1_1(v64_1);
    const v68_1: US1 = v0_1.l43;
    const v70_1: string = (v68_1.tag === US1_Tag.US1_1) ? v68_1.fields[0] : v64_1;
    v63.l43 = US1_US1_1(v70_1);
    v63.l16 = US1_US1_1("flex");
    v63.l19 = US1_US1_1("6");
    v63.l29 = US1_US1_1("$base");
    v63.l20 = US1_US1_1("column");
    v63.l21 = US1_US1_1("$sm");
    v63.l35 = US1_US1_1("85vh");
    v63.l42 = US1_US1_1("auto");
    return v63;
}

export function closure11(v0_1: Mut3, v1_1: Mut2, v2: (arg0: boolean) => void, v3: () => boolean, unitVar: void): any[] {
    let v38: any, v39: () => any[], v43: any, v44: (arg0: any) => any, v47: any, v24: any, v25: () => any[], v29: any, v30: (arg0: any) => any, v33: any;
    const v4: US8 = v1_1.l55;
    let v20: any;
    if (v4.tag === US8_Tag.US8_1) {
        const v9: any = Td;
        const v10: () => any[] = (): any[] => closure12(v0_1, v2, v3, v4.fields[0], void 0);
        const v14: any = createObj(method7(method6(v10, method15(v0_1, v3))));
        const v15: (arg0: any) => any = v9;
        const v18: any = createComponent;
        v20 = (v18(v15, v14));
    }
    else {
        v20 = <></>;
    }
    const v21: US5 = v1_1.l9;
    return [v20, (v21.tag === US5_Tag.US5_1) ? ((v38 = Td, (v39 = ((): any[] => closure17(v0_1, v3, v21.fields[0], void 0)), (v43 = createObj(method7(method6(v39, method36(v1_1)))), (v44 = (v38), (v47 = createComponent, v47(v44, v43))))))) : ((v24 = Td, (v25 = ((): any[] => closure16(void 0, void 0)), (v29 = createObj(method7(method6(v25, method16()))), (v30 = (v24), (v33 = createComponent, v33(v30, v29)))))))];
}

export function method37(v0_1: Mut2): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v63: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v64_1: US1 = v0_1.l25;
    v63.l25 = v64_1;
    v63.l16 = US1_US1_1("flex");
    v63.l19 = US1_US1_1("1");
    v63.l6 = US1_US1_1("1px 2px");
    v63.l5 = US1_US1_1("$neutral5");
    const v75_1: string = {
        "@initial": "column",
        "@sm": "row",
    };
    v63.l20 = US1_US1_1(v75_1);
    return v63;
}

export function closure10(unitVar: void, v0_1: Mut3): any {
    const v1_1: Mut2 = v0_1.l1;
    const v5: boolean = (v0_1.l2.tag === US12_Tag.US12_0) !== true;
    const v8: any = createSignal;
    const v9: any[] = v8(v5);
    let v10: () => boolean;
    const value_1: any = v9[0];
    v10 = (value_1);
    let v11: (arg0: boolean) => void;
    const value_2: any = v9[1];
    v11 = ((arg_1: boolean): void => {
        value_2(arg_1);
    });
    const v14: any = Tr;
    const v15: () => any[] = (): any[] => closure11(v0_1, v1_1, v11, v10, void 0);
    const v19: any = createObj(method7(method6(v15, method37(v1_1))));
    const v20: (arg0: any) => any = v14;
    const v22: any = createComponent;
    return v22(v20, v19);
}

export function method39(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    return new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
}

export function closure48(v0_1: Mut2, unitVar: void): any[] {
    const v1_1: US1 = v0_1.l23;
    return [<>
        {(v1_1.tag === US1_Tag.US1_1) ? v1_1.fields[0] : ""}
    </>];
}

export function method41(v0_1: Mut2): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v63: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    v63.l18 = US4_US4_1(true);
    method18(v63, v0_1);
    return v63;
}

export function closure49(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function method43(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    v62.l61 = US1_US1_1("0.6");
    v62.l34 = US1_US1_1("-13px");
    return v62;
}

export function method42(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v65_1: any = BiRegularLinkExternal;
    v62.l1 = US3_US3_1(v65_1);
    const v69_1: any = createObj(method7(method43()));
    v62.l13 = US6_US6_1(v69_1);
    return v62;
}

export function closure47(v0_1: Mut2, unitVar: void): any[] {
    const v3: any = Anchor;
    const v4: () => any[] = (): any[] => closure48(v0_1, void 0);
    const v8: any = createObj(method7(method6(v4, method41(v0_1))));
    const v9: (arg0: any) => any = v3;
    const v12: any = createComponent;
    const v13: any = v12(v9, v8);
    const v15: any = <>
        &nbsp;
    </>;
    const v17: any = Icon;
    const v18: () => any[] = (): any[] => closure49(void 0, void 0);
    const v22: any = createObj(method7(method6(v18, method42())));
    const v23: (arg0: any) => any = v17;
    const v24: any = createComponent;
    return [v13, v15, v24(v23, v22)];
}

export function method44(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    return new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
}

export function closure46(unitVar: void, v0_1: Mut2): any {
    const v3: any = Box;
    const v4: () => any[] = (): any[] => closure47(v0_1, void 0);
    const v8: any = createObj(method7(method6(v4, method44())));
    const v9: (arg0: any) => any = v3;
    const v12: any = createComponent;
    return v12(v9, v8);
}

export function method45(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    v62.l23 = US1_US1_1("https://github.com/fc1943s/tictactoe_spiral");
    return v62;
}

export function closure50(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure45(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut2) => any = (v: Mut2): any => closure46(void 0, v);
    const v2: () => any[] = (): any[] => closure50(void 0, void 0);
    const v3: Mut2 = method6(v2, method45());
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = [v3.l0, v3.l1, v3.l2, v3.l3, v3.l4, v3.l5, v3.l6, v3.l7, v3.l8, v3.l9, v3.l10, v3.l11, v3.l12, v3.l13, v3.l14, v3.l15, v3.l16, v3.l17, v3.l18, v3.l19, v3.l20, v3.l21, v3.l22, v3.l23, v3.l24, v3.l25, v3.l26, v3.l27, v3.l28, v3.l29, v3.l30, v3.l31, v3.l32, v3.l33, v3.l34, v3.l35, v3.l36, v3.l37, v3.l38, v3.l39, v3.l40, v3.l41, v3.l42, v3.l43, v3.l44, v3.l45, v3.l46, v3.l47, v3.l48, v3.l49, v3.l50, v3.l51, v3.l52, v3.l53, v3.l54, v3.l55, v3.l56, v3.l57, v3.l58, v3.l59, v3.l60, v3.l61];
    const v66_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v68_1: (arg0: any) => any = v0_1;
    const v71_1: any = createComponent;
    return [v71_1(v68_1, v66_1)];
}

export function method40(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    v62.l43 = US1_US1_1("1px 6px");
    const v65_1: () => any[] = (): any[] => closure45(void 0, void 0);
    v62.l9 = US5_US5_1(v65_1);
    return v62;
}

export function method47(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    v62.l23 = US1_US1_1("https://fc1943s.github.io/tictactoe_spiral");
    return v62;
}

export function closure51(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut2) => any = (v: Mut2): any => closure46(void 0, v);
    const v2: () => any[] = (): any[] => closure50(void 0, void 0);
    const v3: Mut2 = method6(v2, method47());
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = [v3.l0, v3.l1, v3.l2, v3.l3, v3.l4, v3.l5, v3.l6, v3.l7, v3.l8, v3.l9, v3.l10, v3.l11, v3.l12, v3.l13, v3.l14, v3.l15, v3.l16, v3.l17, v3.l18, v3.l19, v3.l20, v3.l21, v3.l22, v3.l23, v3.l24, v3.l25, v3.l26, v3.l27, v3.l28, v3.l29, v3.l30, v3.l31, v3.l32, v3.l33, v3.l34, v3.l35, v3.l36, v3.l37, v3.l38, v3.l39, v3.l40, v3.l41, v3.l42, v3.l43, v3.l44, v3.l45, v3.l46, v3.l47, v3.l48, v3.l49, v3.l50, v3.l51, v3.l52, v3.l53, v3.l54, v3.l55, v3.l56, v3.l57, v3.l58, v3.l59, v3.l60, v3.l61];
    const v66_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v68_1: (arg0: any) => any = v0_1;
    const v71_1: any = createComponent;
    return [v71_1(v68_1, v66_1)];
}

export function method46(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    v62.l43 = US1_US1_1("1px 6px");
    const v65_1: () => any[] = (): any[] => closure51(void 0, void 0);
    v62.l9 = US5_US5_1(v65_1);
    return v62;
}

export function method49(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    v62.l23 = US1_US1_1("https://fc1943s.github.io/tictactoe_spiral/docs");
    return v62;
}

export function closure52(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut2) => any = (v: Mut2): any => closure46(void 0, v);
    const v2: () => any[] = (): any[] => closure50(void 0, void 0);
    const v3: Mut2 = method6(v2, method49());
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = [v3.l0, v3.l1, v3.l2, v3.l3, v3.l4, v3.l5, v3.l6, v3.l7, v3.l8, v3.l9, v3.l10, v3.l11, v3.l12, v3.l13, v3.l14, v3.l15, v3.l16, v3.l17, v3.l18, v3.l19, v3.l20, v3.l21, v3.l22, v3.l23, v3.l24, v3.l25, v3.l26, v3.l27, v3.l28, v3.l29, v3.l30, v3.l31, v3.l32, v3.l33, v3.l34, v3.l35, v3.l36, v3.l37, v3.l38, v3.l39, v3.l40, v3.l41, v3.l42, v3.l43, v3.l44, v3.l45, v3.l46, v3.l47, v3.l48, v3.l49, v3.l50, v3.l51, v3.l52, v3.l53, v3.l54, v3.l55, v3.l56, v3.l57, v3.l58, v3.l59, v3.l60, v3.l61];
    const v66_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v68_1: (arg0: any) => any = v0_1;
    const v71_1: any = createComponent;
    return [v71_1(v68_1, v66_1)];
}

export function method48(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    v62.l43 = US1_US1_1("1px 6px");
    const v65_1: () => any[] = (): any[] => closure52(void 0, void 0);
    v62.l9 = US5_US5_1(v65_1);
    return v62;
}

export function closure44(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut3) => any = (v: Mut3): any => closure10(void 0, v);
    const v4: Mut3 = new Mut3(US11_US11_0(), method40(), US12_US12_2());
    const v6: (arg0: any) => any = v0_1;
    const v9: any = createComponent;
    const v10: any = v9(v6, v4);
    const v14: Mut3 = new Mut3(US11_US11_0(), method46(), US12_US12_2());
    const v16: (arg0: any) => any = v0_1;
    const v17: any = createComponent;
    const v18: any = v17(v16, v14);
    const v22: Mut3 = new Mut3(US11_US11_0(), method48(), US12_US12_2());
    const v24: (arg0: any) => any = v0_1;
    const v25: any = createComponent;
    return [v10, v18, v25(v24, v22)];
}

export function closure43(unitVar: void, v0_1: Mut2): any {
    const v1_1: (arg0: Mut2) => any = (v: Mut2): any => closure6(void 0, v);
    const v3: () => any[] = (): any[] => closure44(void 0, void 0);
    const v4: Mut2 = method6(v3, method39());
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = [v4.l0, v4.l1, v4.l2, v4.l3, v4.l4, v4.l5, v4.l6, v4.l7, v4.l8, v4.l9, v4.l10, v4.l11, v4.l12, v4.l13, v4.l14, v4.l15, v4.l16, v4.l17, v4.l18, v4.l19, v4.l20, v4.l21, v4.l22, v4.l23, v4.l24, v4.l25, v4.l26, v4.l27, v4.l28, v4.l29, v4.l30, v4.l31, v4.l32, v4.l33, v4.l34, v4.l35, v4.l36, v4.l37, v4.l38, v4.l39, v4.l40, v4.l41, v4.l42, v4.l43, v4.l44, v4.l45, v4.l46, v4.l47, v4.l48, v4.l49, v4.l50, v4.l51, v4.l52, v4.l53, v4.l54, v4.l55, v4.l56, v4.l57, v4.l58, v4.l59, v4.l60, v4.l61];
    const v67_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v69_1: (arg0: any) => any = v1_1;
    const v72_1: any = createComponent;
    return v72_1(v69_1, v67_1);
}

export function method50(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    return new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
}

export function closure53(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure42(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut2) => any = (v: Mut2): any => closure43(void 0, v);
    const v2: () => any[] = (): any[] => closure53(void 0, void 0);
    const v3: Mut2 = method6(v2, method50());
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = [v3.l0, v3.l1, v3.l2, v3.l3, v3.l4, v3.l5, v3.l6, v3.l7, v3.l8, v3.l9, v3.l10, v3.l11, v3.l12, v3.l13, v3.l14, v3.l15, v3.l16, v3.l17, v3.l18, v3.l19, v3.l20, v3.l21, v3.l22, v3.l23, v3.l24, v3.l25, v3.l26, v3.l27, v3.l28, v3.l29, v3.l30, v3.l31, v3.l32, v3.l33, v3.l34, v3.l35, v3.l36, v3.l37, v3.l38, v3.l39, v3.l40, v3.l41, v3.l42, v3.l43, v3.l44, v3.l45, v3.l46, v3.l47, v3.l48, v3.l49, v3.l50, v3.l51, v3.l52, v3.l53, v3.l54, v3.l55, v3.l56, v3.l57, v3.l58, v3.l59, v3.l60, v3.l61];
    const v66_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v68_1: (arg0: any) => any = v0_1;
    const v71_1: any = createComponent;
    return [v71_1(v68_1, v66_1)];
}

export function method38(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v64_1: any = <>
        Links
    </>;
    v62.l55 = US8_US8_1(v64_1);
    const v66_1: () => any[] = (): any[] => closure42(void 0, void 0);
    v62.l9 = US5_US5_1(v66_1);
    return v62;
}

export function method51(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    return new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
}

export function method53(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    return new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
}

export function closure60(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Dark
    </>];
}

export function method55(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    v62.l58 = US6_US6_1("dark");
    v62.l50 = US1_US1_1("sm");
    v62.l11 = US1_US1_1("neutral");
    return v62;
}

export function closure61(unitVar: void, unitVar_1: void): any[] {
    return [<>
        Light
    </>];
}

export function method56(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    v62.l58 = US6_US6_1("light");
    v62.l50 = US1_US1_1("sm");
    v62.l11 = US1_US1_1("neutral");
    return v62;
}

export function closure59(unitVar: void, unitVar_1: void): any[] {
    const v2: any = Radio;
    const v3: () => any[] = (): any[] => closure60(void 0, void 0);
    const v7: any = createObj(method7(method6(v3, method55())));
    const v8: (arg0: any) => any = v2;
    const v11: any = createComponent;
    const v12: any = v11(v8, v7);
    const v13: any = Radio;
    const v14: () => any[] = (): any[] => closure61(void 0, void 0);
    const v18: any = createObj(method7(method6(v14, method56())));
    const v19: (arg0: any) => any = v13;
    const v20: any = createComponent;
    return [v12, v20(v19, v18)];
}

export function method57(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    v62.l15 = US1_US1_1("row");
    v62.l51 = US1_US1_1("$4");
    return v62;
}

export function closure58(unitVar: void, unitVar_1: void): any[] {
    const v2: any = Stack;
    const v3: () => any[] = (): any[] => closure59(void 0, void 0);
    const v7: any = createObj(method7(method6(v3, method57())));
    const v8: (arg0: any) => any = v2;
    const v11: any = createComponent;
    return [v11(v8, v7)];
}

export function closure62(v0_1: () => void, v1_1: any): void {
    v0_1();
}

export function method58(v0_1: () => void, v1_1: () => string): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v64_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v65_1: string = v1_1();
    v64_1.l14 = US1_US1_1(v65_1);
    const v67_1: (arg0: any) => void = (v: any): void => {
        closure62(v0_1, v);
    };
    v64_1.l37 = US9_US9_1(v67_1);
    return v64_1;
}

export function closure57(v0_1: () => void, v1_1: () => string, unitVar: void): any[] {
    const v4: any = RadioGroup;
    const v5: () => any[] = (): any[] => closure58(void 0, void 0);
    const v9: any = createObj(method7(method6(v5, method58(v0_1, v1_1))));
    const v10: (arg0: any) => any = v4;
    const v13: any = createComponent;
    return [v13(v10, v9)];
}

export function method54(v0_1: () => void, v1_1: () => string): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v64_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v66_1: any = <>
        Theme
    </>;
    v64_1.l55 = US8_US8_1(v66_1);
    v64_1.l43 = US1_US1_1("5px 6px");
    const v70_1: () => any[] = (): any[] => closure57(v0_1, v1_1, void 0);
    v64_1.l9 = US5_US5_1(v70_1);
    return v64_1;
}

export function closure56(v0_1: () => void, v1_1: () => string, unitVar: void): any[] {
    const v2: (arg0: Mut3) => any = (v: Mut3): any => closure10(void 0, v);
    const v6: Mut3 = new Mut3(US11_US11_0(), method54(v0_1, v1_1), US12_US12_2());
    const v8: (arg0: any) => any = v2;
    const v11: any = createComponent;
    return [v11(v8, v6)];
}

export function closure55(unitVar: void, v0_1: Mut2): any {
    const v3: any = useColorMode;
    const v4: any = v3();
    const v5: () => string = v4.colorMode;
    const v6: () => void = v4.toggleColorMode;
    const v7: (arg0: Mut2) => any = (v: Mut2): any => closure6(void 0, v);
    const v9: () => any[] = (): any[] => closure56(v6, v5, void 0);
    const v10: Mut2 = method6(v9, method53());
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = [v10.l0, v10.l1, v10.l2, v10.l3, v10.l4, v10.l5, v10.l6, v10.l7, v10.l8, v10.l9, v10.l10, v10.l11, v10.l12, v10.l13, v10.l14, v10.l15, v10.l16, v10.l17, v10.l18, v10.l19, v10.l20, v10.l21, v10.l22, v10.l23, v10.l24, v10.l25, v10.l26, v10.l27, v10.l28, v10.l29, v10.l30, v10.l31, v10.l32, v10.l33, v10.l34, v10.l35, v10.l36, v10.l37, v10.l38, v10.l39, v10.l40, v10.l41, v10.l42, v10.l43, v10.l44, v10.l45, v10.l46, v10.l47, v10.l48, v10.l49, v10.l50, v10.l51, v10.l52, v10.l53, v10.l54, v10.l55, v10.l56, v10.l57, v10.l58, v10.l59, v10.l60, v10.l61];
    const v73_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v75_1: (arg0: any) => any = v7;
    const v78_1: any = createComponent;
    return v78_1(v75_1, v73_1);
}

export function method59(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    return new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
}

export function closure63(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure54(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut2) => any = (v: Mut2): any => closure55(void 0, v);
    const v2: () => any[] = (): any[] => closure63(void 0, void 0);
    const v3: Mut2 = method6(v2, method59());
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = [v3.l0, v3.l1, v3.l2, v3.l3, v3.l4, v3.l5, v3.l6, v3.l7, v3.l8, v3.l9, v3.l10, v3.l11, v3.l12, v3.l13, v3.l14, v3.l15, v3.l16, v3.l17, v3.l18, v3.l19, v3.l20, v3.l21, v3.l22, v3.l23, v3.l24, v3.l25, v3.l26, v3.l27, v3.l28, v3.l29, v3.l30, v3.l31, v3.l32, v3.l33, v3.l34, v3.l35, v3.l36, v3.l37, v3.l38, v3.l39, v3.l40, v3.l41, v3.l42, v3.l43, v3.l44, v3.l45, v3.l46, v3.l47, v3.l48, v3.l49, v3.l50, v3.l51, v3.l52, v3.l53, v3.l54, v3.l55, v3.l56, v3.l57, v3.l58, v3.l59, v3.l60, v3.l61];
    const v66_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v68_1: (arg0: any) => any = v0_1;
    const v71_1: any = createComponent;
    return [v71_1(v68_1, v66_1)];
}

export function method52(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v64_1: any = <>
        Settings
    </>;
    v62.l55 = US8_US8_1(v64_1);
    const v66_1: () => any[] = (): any[] => closure54(void 0, void 0);
    v62.l9 = US5_US5_1(v66_1);
    return v62;
}

export function method60(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    return new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
}

export function method62(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    return new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
}

export function method64(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    return new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
}

export function closure72(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure73(v0_1: Mut6, v1_1: Mut1, v2: any, v3: any): void {
    const v4: string = v3.currentTarget.value;
    const v7: Mut1 = createObj(fill(new Array(0), 0, 0, null));
    v0_1.l1(v1_1, v7, US1_US1_1(v4));
    v2("set", v7);
}

export function method66(v0_1: Mut6, v1_1: Mut1, v2: any): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v65_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    v65_1.l57 = US1_US1_1("text");
    v65_1.l50 = US1_US1_1("xs");
    const v71_1: US1 = v0_1.l0(v1_1);
    const v72_1: string = void 0;
    const v74_1: string = (v71_1.tag === US1_Tag.US1_1) ? v71_1.fields[0] : v72_1;
    v65_1.l58 = US6_US6_1(v74_1);
    const v77_1: (arg0: any) => void = (v: any): void => {
        closure73(v0_1, v1_1, v2, v);
    };
    v65_1.l39 = US9_US9_1(v77_1);
    return v65_1;
}

export function closure71(unitVar: void, v0_1: Mut6): any {
    const v3: any = useStoreon;
    const v4: any[] = v3();
    const v9: any = Input;
    const v10: () => any[] = (): any[] => closure72(void 0, void 0);
    const v14: any = createObj(method7(method6(v10, method66(v0_1, v4[0], v4[1]))));
    const v15: (arg0: any) => any = v9;
    const v18: any = createComponent;
    return v18(v15, v14);
}

export function closure74(unitVar: void, v0_1: Mut1): US1 {
    return v0_1.l2;
}

export function closure77(v0_1: Mut1, v1_1: US1): void {
    v0_1.l2 = v1_1;
}

export function closure76(unitVar: void, v0_1: Mut1): (arg0: US1) => void {
    return (v: US1): void => {
        closure77(v0_1, v);
    };
}

export function closure75(unitVar: void, v0_1: Mut1): (arg0: Mut1, arg1: US1) => void {
    return (v: Mut1): (arg0: US1) => void => closure76(void 0, v);
}

export function closure70(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut6) => any = (v: Mut6): any => closure71(void 0, v);
    const v1_1: (arg0: Mut1) => US1 = (v_1: Mut1): US1 => closure74(void 0, v_1);
    const v2: (arg0: Mut1, arg1: Mut1, arg2: US1) => void = (v_2: Mut1): (arg0: Mut1, arg1: US1) => void => closure75(void 0, v_2);
    const v3: Mut6 = new Mut6(v1_1, uncurry(3, v2));
    const v5: (arg0: any) => any = v0_1;
    const v8: any = createComponent;
    return [v8(v5, v3)];
}

export function method65(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v64_1: any = <>
        Token
    </>;
    v62.l55 = US8_US8_1(v64_1);
    v62.l43 = US1_US1_1("3px");
    const v68_1: () => any[] = (): any[] => closure70(void 0, void 0);
    v62.l9 = US5_US5_1(v68_1);
    return v62;
}

export function closure79(unitVar: void, v0_1: Mut1): US1 {
    return v0_1.l3;
}

export function closure82(v0_1: Mut1, v1_1: US1): void {
    v0_1.l3 = v1_1;
}

export function closure81(unitVar: void, v0_1: Mut1): (arg0: US1) => void {
    return (v: US1): void => {
        closure82(v0_1, v);
    };
}

export function closure80(unitVar: void, v0_1: Mut1): (arg0: Mut1, arg1: US1) => void {
    return (v: Mut1): (arg0: US1) => void => closure81(void 0, v);
}

export function closure78(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut6) => any = (v: Mut6): any => closure71(void 0, v);
    const v1_1: (arg0: Mut1) => US1 = (v_1: Mut1): US1 => closure79(void 0, v_1);
    const v2: (arg0: Mut1, arg1: Mut1, arg2: US1) => void = (v_2: Mut1): (arg0: Mut1, arg1: US1) => void => closure80(void 0, v_2);
    const v3: Mut6 = new Mut6(v1_1, uncurry(3, v2));
    const v5: (arg0: any) => any = v0_1;
    const v8: any = createComponent;
    return [v8(v5, v3)];
}

export function method67(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v64_1: any = <>
        URL
    </>;
    v62.l55 = US8_US8_1(v64_1);
    v62.l43 = US1_US1_1("3px");
    const v68_1: () => any[] = (): any[] => closure78(void 0, void 0);
    v62.l9 = US5_US5_1(v68_1);
    return v62;
}

export function closure85(v0_1: Mut7, v1_1: Mut1, v2: any, v3: any): void {
    const v4: int32 = v3.currentTarget.value | 0;
    const v7: Mut1 = createObj(fill(new Array(0), 0, 0, null));
    v0_1.l1(v1_1, v7, US0_US0_1(v4));
    v2("set", v7);
}

export function method69(v0_1: Mut7, v1_1: Mut1, v2: any): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v65_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    v65_1.l57 = US1_US1_1("text");
    v65_1.l50 = US1_US1_1("xs");
    const v71_1: US0 = v0_1.l0(v1_1);
    const v72_1: int32 = (void 0) | 0;
    const v74_1: int32 = ((v71_1.tag === US0_Tag.US0_1) ? v71_1.fields[0] : v72_1) | 0;
    v65_1.l58 = US6_US6_1(v74_1);
    const v77_1: (arg0: any) => void = (v: any): void => {
        closure85(v0_1, v1_1, v2, v);
    };
    v65_1.l39 = US9_US9_1(v77_1);
    return v65_1;
}

export function closure84(unitVar: void, v0_1: Mut7): any {
    const v3: any = useStoreon;
    const v4: any[] = v3();
    const v9: any = Input;
    const v10: () => any[] = (): any[] => closure72(void 0, void 0);
    const v14: any = createObj(method7(method6(v10, method69(v0_1, v4[0], v4[1]))));
    const v15: (arg0: any) => any = v9;
    const v18: any = createComponent;
    return v18(v15, v14);
}

export function closure86(unitVar: void, v0_1: Mut1): US0 {
    return v0_1.l1;
}

export function closure89(v0_1: Mut1, v1_1: US0): void {
    v0_1.l1 = v1_1;
}

export function closure88(unitVar: void, v0_1: Mut1): (arg0: US0) => void {
    return (v: US0): void => {
        closure89(v0_1, v);
    };
}

export function closure87(unitVar: void, v0_1: Mut1): (arg0: Mut1, arg1: US0) => void {
    return (v: Mut1): (arg0: US0) => void => closure88(void 0, v);
}

export function closure83(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut7) => any = (v: Mut7): any => closure84(void 0, v);
    const v1_1: (arg0: Mut1) => US0 = (v_1: Mut1): US0 => closure86(void 0, v_1);
    const v2: (arg0: Mut1, arg1: Mut1, arg2: US0) => void = (v_2: Mut1): (arg0: Mut1, arg1: US0) => void => closure87(void 0, v_2);
    const v3: Mut7 = new Mut7(v1_1, uncurry(3, v2));
    const v5: (arg0: any) => any = v0_1;
    const v8: any = createComponent;
    return [v8(v5, v3)];
}

export function method68(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v64_1: any = <>
        Port
    </>;
    v62.l55 = US8_US8_1(v64_1);
    v62.l43 = US1_US1_1("3px");
    const v68_1: () => any[] = (): any[] => closure83(void 0, void 0);
    v62.l9 = US5_US5_1(v68_1);
    return v62;
}

export function closure69(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut3) => any = (v: Mut3): any => closure10(void 0, v);
    const v4: Mut3 = new Mut3(US11_US11_0(), method65(), US12_US12_2());
    const v6: (arg0: any) => any = v0_1;
    const v9: any = createComponent;
    const v10: any = v9(v6, v4);
    const v14: Mut3 = new Mut3(US11_US11_0(), method67(), US12_US12_2());
    const v16: (arg0: any) => any = v0_1;
    const v17: any = createComponent;
    const v18: any = v17(v16, v14);
    const v22: Mut3 = new Mut3(US11_US11_0(), method68(), US12_US12_2());
    const v24: (arg0: any) => any = v0_1;
    const v25: any = createComponent;
    return [v10, v18, v25(v24, v22)];
}

export function closure68(unitVar: void, v0_1: Mut2): any {
    const v1_1: (arg0: Mut2) => any = (v: Mut2): any => closure6(void 0, v);
    const v3: () => any[] = (): any[] => closure69(void 0, void 0);
    const v4: Mut2 = method6(v3, method64());
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = [v4.l0, v4.l1, v4.l2, v4.l3, v4.l4, v4.l5, v4.l6, v4.l7, v4.l8, v4.l9, v4.l10, v4.l11, v4.l12, v4.l13, v4.l14, v4.l15, v4.l16, v4.l17, v4.l18, v4.l19, v4.l20, v4.l21, v4.l22, v4.l23, v4.l24, v4.l25, v4.l26, v4.l27, v4.l28, v4.l29, v4.l30, v4.l31, v4.l32, v4.l33, v4.l34, v4.l35, v4.l36, v4.l37, v4.l38, v4.l39, v4.l40, v4.l41, v4.l42, v4.l43, v4.l44, v4.l45, v4.l46, v4.l47, v4.l48, v4.l49, v4.l50, v4.l51, v4.l52, v4.l53, v4.l54, v4.l55, v4.l56, v4.l57, v4.l58, v4.l59, v4.l60, v4.l61];
    const v67_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v69_1: (arg0: any) => any = v1_1;
    const v72_1: any = createComponent;
    return v72_1(v69_1, v67_1);
}

export function method70(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    return new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
}

export function closure90(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure67(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut2) => any = (v: Mut2): any => closure68(void 0, v);
    const v2: () => any[] = (): any[] => closure90(void 0, void 0);
    const v3: Mut2 = method6(v2, method70());
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = [v3.l0, v3.l1, v3.l2, v3.l3, v3.l4, v3.l5, v3.l6, v3.l7, v3.l8, v3.l9, v3.l10, v3.l11, v3.l12, v3.l13, v3.l14, v3.l15, v3.l16, v3.l17, v3.l18, v3.l19, v3.l20, v3.l21, v3.l22, v3.l23, v3.l24, v3.l25, v3.l26, v3.l27, v3.l28, v3.l29, v3.l30, v3.l31, v3.l32, v3.l33, v3.l34, v3.l35, v3.l36, v3.l37, v3.l38, v3.l39, v3.l40, v3.l41, v3.l42, v3.l43, v3.l44, v3.l45, v3.l46, v3.l47, v3.l48, v3.l49, v3.l50, v3.l51, v3.l52, v3.l53, v3.l54, v3.l55, v3.l56, v3.l57, v3.l58, v3.l59, v3.l60, v3.l61];
    const v66_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v68_1: (arg0: any) => any = v0_1;
    const v71_1: any = createComponent;
    return [v71_1(v68_1, v66_1)];
}

export function method63(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v64_1: any = <>
        Connection
    </>;
    v62.l55 = US8_US8_1(v64_1);
    const v66_1: () => any[] = (): any[] => closure67(void 0, void 0);
    v62.l9 = US5_US5_1(v66_1);
    return v62;
}

export function method72(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    return new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
}

export function method74(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    return new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
}

export function closure98(v0_1: string, v1_1: string, v2: string, v3: string, v4: Mut1): US1 {
    return US1_US1_1(v0_1);
}

export function closure101(v0_1: string, v1_1: string, v2: string, v3: string, v4: Mut1, v5: Mut1, v6: US1): void {
    const v7: [string, string, string, string][] = v4.l0;
    const v11: int32 = v7.length | 0;
    const v12: [string, string, string, string][] = fill(new Array(v11), 0, v11, null);
    const v13: Mut5 = new Mut5(0);
    while (method19(v11, v13)) {
        const v15: int32 = v13.l0 | 0;
        const patternInput_1: [string, string, string, string] = v7[v15];
        const v19: string = patternInput_1[3];
        const v18: string = patternInput_1[2];
        const v17: string = patternInput_1[1];
        const patternInput_2: [string, string, string, string] = (v17 === v1_1) ? [(v6.tag === US1_Tag.US1_1) ? v6.fields[0] : "", v17, v18, v19] : [patternInput_1[0], v17, v18, v19];
        v12[v15] = [patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3]];
        const v28: int32 = (v15 + 1) | 0;
        v13.l0 = (v28 | 0);
    }
    v5.l0 = v12;
}

export function closure100(v0_1: string, v1_1: string, v2: string, v3: string, v4: Mut1, v5: Mut1): (arg0: US1) => void {
    return (v: US1): void => {
        closure101(v0_1, v1_1, v2, v3, v4, v5, v);
    };
}

export function closure99(v0_1: string, v1_1: string, v2: string, v3: string, v4: Mut1): (arg0: Mut1, arg1: US1) => void {
    return (v: Mut1): (arg0: US1) => void => closure100(v0_1, v1_1, v2, v3, v4, v);
}

export function closure97(v0_1: string, v1_1: string, v2: string, v3: string, unitVar: void): any[] {
    const v4: (arg0: Mut6) => any = (v: Mut6): any => closure71(void 0, v);
    const v5: (arg0: Mut1) => US1 = (v_1: Mut1): US1 => closure98(v0_1, v1_1, v2, v3, v_1);
    const v6: (arg0: Mut1, arg1: Mut1, arg2: US1) => void = (v_2: Mut1): (arg0: Mut1, arg1: US1) => void => closure99(v0_1, v1_1, v2, v3, v_2);
    const v7: Mut6 = new Mut6(v5, uncurry(3, v6));
    const v9: (arg0: any) => any = v4;
    const v12: any = createComponent;
    return [v12(v9, v7)];
}

export function method75(v0_1: Mut2, v1_1: string, v2: string, v3: string, v4: string): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v67_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v69_1: any = <>
        Address
    </>;
    v67_1.l55 = US8_US8_1(v69_1);
    v67_1.l43 = US1_US1_1("3px");
    const v73_1: () => any[] = (): any[] => closure97(v1_1, v2, v3, v4, void 0);
    v0_1.l9 = US5_US5_1(v73_1);
    return v67_1;
}

export function closure103(v0_1: string, v1_1: string, v2: string, v3: string, v4: Mut1): US1 {
    return US1_US1_1(v3);
}

export function closure106(v0_1: string, v1_1: string, v2: string, v3: string, v4: Mut1, v5: Mut1, v6: US1): void {
    const v7: [string, string, string, string][] = v4.l0;
    const v11: int32 = v7.length | 0;
    const v12: [string, string, string, string][] = fill(new Array(v11), 0, v11, null);
    const v13: Mut5 = new Mut5(0);
    while (method19(v11, v13)) {
        const v15: int32 = v13.l0 | 0;
        const patternInput_1: [string, string, string, string] = v7[v15];
        const v18: string = patternInput_1[2];
        const v17: string = patternInput_1[1];
        const v16: string = patternInput_1[0];
        const patternInput_2: [string, string, string, string] = (v17 === v1_1) ? [v16, v17, v18, (v6.tag === US1_Tag.US1_1) ? v6.fields[0] : ""] : [v16, v17, v18, patternInput_1[3]];
        v12[v15] = [patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3]];
        const v28: int32 = (v15 + 1) | 0;
        v13.l0 = (v28 | 0);
    }
    v5.l0 = v12;
}

export function closure105(v0_1: string, v1_1: string, v2: string, v3: string, v4: Mut1, v5: Mut1): (arg0: US1) => void {
    return (v: US1): void => {
        closure106(v0_1, v1_1, v2, v3, v4, v5, v);
    };
}

export function closure104(v0_1: string, v1_1: string, v2: string, v3: string, v4: Mut1): (arg0: Mut1, arg1: US1) => void {
    return (v: Mut1): (arg0: US1) => void => closure105(v0_1, v1_1, v2, v3, v4, v);
}

export function closure102(v0_1: string, v1_1: string, v2: string, v3: string, unitVar: void): any[] {
    const v4: (arg0: Mut6) => any = (v: Mut6): any => closure71(void 0, v);
    const v5: (arg0: Mut1) => US1 = (v_1: Mut1): US1 => closure103(v0_1, v1_1, v2, v3, v_1);
    const v6: (arg0: Mut1, arg1: Mut1, arg2: US1) => void = (v_2: Mut1): (arg0: Mut1, arg1: US1) => void => closure104(v0_1, v1_1, v2, v3, v_2);
    const v7: Mut6 = new Mut6(v5, uncurry(3, v6));
    const v9: (arg0: any) => any = v4;
    const v12: any = createComponent;
    return [v12(v9, v7)];
}

export function method76(v0_1: Mut2, v1_1: string, v2: string, v3: string, v4: string): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v67_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v69_1: any = <>
        Private Key
    </>;
    v67_1.l55 = US8_US8_1(v69_1);
    v67_1.l43 = US1_US1_1("3px");
    const v73_1: () => any[] = (): any[] => closure102(v1_1, v2, v3, v4, void 0);
    v0_1.l9 = US5_US5_1(v73_1);
    return v67_1;
}

export function closure96(v0_1: Mut2, v1_1: string, v2: string, v3: string, v4: string, unitVar: void): any[] {
    const v5: (arg0: Mut3) => any = (v: Mut3): any => closure10(void 0, v);
    const v9: Mut3 = new Mut3(US11_US11_0(), method75(v0_1, v1_1, v2, v3, v4), US12_US12_2());
    const v11: (arg0: any) => any = v5;
    const v14: any = createComponent;
    const v15: any = v14(v11, v9);
    const v19: Mut3 = new Mut3(US11_US11_0(), method76(v0_1, v1_1, v2, v3, v4), US12_US12_2());
    const v21: (arg0: any) => any = v5;
    const v22: any = createComponent;
    return [v15, v22(v21, v19)];
}

export function closure95(v0_1: Mut2, v1_1: string, v2: string, v3: string, v4: string, unitVar: void): any[] {
    const v5: (arg0: Mut2) => any = (v: Mut2): any => closure6(void 0, v);
    const v7: () => any[] = (): any[] => closure96(v0_1, v1_1, v2, v3, v4, void 0);
    const v8: Mut2 = method6(v7, method74());
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = [v8.l0, v8.l1, v8.l2, v8.l3, v8.l4, v8.l5, v8.l6, v8.l7, v8.l8, v8.l9, v8.l10, v8.l11, v8.l12, v8.l13, v8.l14, v8.l15, v8.l16, v8.l17, v8.l18, v8.l19, v8.l20, v8.l21, v8.l22, v8.l23, v8.l24, v8.l25, v8.l26, v8.l27, v8.l28, v8.l29, v8.l30, v8.l31, v8.l32, v8.l33, v8.l34, v8.l35, v8.l36, v8.l37, v8.l38, v8.l39, v8.l40, v8.l41, v8.l42, v8.l43, v8.l44, v8.l45, v8.l46, v8.l47, v8.l48, v8.l49, v8.l50, v8.l51, v8.l52, v8.l53, v8.l54, v8.l55, v8.l56, v8.l57, v8.l58, v8.l59, v8.l60, v8.l61];
    const v71_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v73_1: (arg0: any) => any = v5;
    const v76_1: any = createComponent;
    return [v76_1(v73_1, v71_1)];
}

export function method73(v0_1: Mut2, v1_1: string, v2: string, v3: string, v4: string): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v67_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v68_1: any = <>
        {v2}
    </>;
    v67_1.l55 = US8_US8_1(v68_1);
    const v70_1: () => any[] = (): any[] => closure95(v0_1, v1_1, v2, v3, v4, void 0);
    v0_1.l9 = US5_US5_1(v70_1);
    return v67_1;
}

export function closure94(v0_1: Mut2, _arg: [string, string, string, string]): any[] {
    const v5: (arg0: Mut3) => any = (v: Mut3): any => closure10(void 0, v);
    const v9: Mut3 = new Mut3(US11_US11_0(), method73(v0_1, _arg[0], _arg[1], _arg[2], _arg[3]), US12_US12_2());
    const v11: (arg0: any) => any = v5;
    const v14: any = createComponent;
    return [v14(v11, v9)];
}

export function method77(v0_1: [string, string, string, string][]): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v63: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v66_1: int32 = v0_1.length | 0;
    const v67_1: any[] = fill(new Array(v66_1), 0, v66_1, null);
    const v68_1: Mut5 = new Mut5(0);
    while (method19(v66_1, v68_1)) {
        const v70_1: int32 = v68_1.l0 | 0;
        const patternInput_1: [string, string, string, string] = v0_1[v70_1];
        v67_1[v70_1] = [patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3]];
        const v76_1: int32 = (v70_1 + 1) | 0;
        v68_1.l0 = (v76_1 | 0);
    }
    v63.l17 = US7_US7_1(v67_1);
    return v63;
}

export function closure93(v0_1: Mut2, v1_1: Mut1, unitVar: void): any[] {
    const v8: any = For;
    const v9: (arg0: [string, string, string, string]) => any[] = (arg10$0040: [string, string, string, string]): any[] => closure94(v0_1, arg10$0040);
    const v14: any = createObj(method7(method6(v9, method77(v1_1.l0))));
    const v15: (arg0: any) => any = v8;
    const v17: any = createComponent;
    return [v17(v15, v14)];
}

export function closure92(unitVar: void, v0_1: Mut2): any {
    const v3: any = useStoreon;
    const v4: any[] = v3();
    const v5: Mut1 = v4[0];
    const v6: any = v4[1];
    const v7: (arg0: Mut2) => any = (v: Mut2): any => closure6(void 0, v);
    const v9: () => any[] = (): any[] => closure93(v0_1, v5, void 0);
    const v10: Mut2 = method6(v9, method72());
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = [v10.l0, v10.l1, v10.l2, v10.l3, v10.l4, v10.l5, v10.l6, v10.l7, v10.l8, v10.l9, v10.l10, v10.l11, v10.l12, v10.l13, v10.l14, v10.l15, v10.l16, v10.l17, v10.l18, v10.l19, v10.l20, v10.l21, v10.l22, v10.l23, v10.l24, v10.l25, v10.l26, v10.l27, v10.l28, v10.l29, v10.l30, v10.l31, v10.l32, v10.l33, v10.l34, v10.l35, v10.l36, v10.l37, v10.l38, v10.l39, v10.l40, v10.l41, v10.l42, v10.l43, v10.l44, v10.l45, v10.l46, v10.l47, v10.l48, v10.l49, v10.l50, v10.l51, v10.l52, v10.l53, v10.l54, v10.l55, v10.l56, v10.l57, v10.l58, v10.l59, v10.l60, v10.l61];
    const v73_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v75_1: (arg0: any) => any = v7;
    const v78_1: any = createComponent;
    return v78_1(v75_1, v73_1);
}

export function method78(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    return new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
}

export function closure107(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure91(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut2) => any = (v: Mut2): any => closure92(void 0, v);
    const v2: () => any[] = (): any[] => closure107(void 0, void 0);
    const v3: Mut2 = method6(v2, method78());
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = [v3.l0, v3.l1, v3.l2, v3.l3, v3.l4, v3.l5, v3.l6, v3.l7, v3.l8, v3.l9, v3.l10, v3.l11, v3.l12, v3.l13, v3.l14, v3.l15, v3.l16, v3.l17, v3.l18, v3.l19, v3.l20, v3.l21, v3.l22, v3.l23, v3.l24, v3.l25, v3.l26, v3.l27, v3.l28, v3.l29, v3.l30, v3.l31, v3.l32, v3.l33, v3.l34, v3.l35, v3.l36, v3.l37, v3.l38, v3.l39, v3.l40, v3.l41, v3.l42, v3.l43, v3.l44, v3.l45, v3.l46, v3.l47, v3.l48, v3.l49, v3.l50, v3.l51, v3.l52, v3.l53, v3.l54, v3.l55, v3.l56, v3.l57, v3.l58, v3.l59, v3.l60, v3.l61];
    const v66_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v68_1: (arg0: any) => any = v0_1;
    const v71_1: any = createComponent;
    return [v71_1(v68_1, v66_1)];
}

export function method71(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v64_1: any = <>
        Accounts
    </>;
    v62.l55 = US8_US8_1(v64_1);
    const v66_1: () => any[] = (): any[] => closure91(void 0, void 0);
    v62.l9 = US5_US5_1(v66_1);
    return v62;
}

export function closure109(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function method80(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    v62.l52 = US1_US1_1("https://bank.testnet.algorand.network");
    const v66_1: any = <>
        algorand testnet bank
    </>;
    v62.l55 = US8_US8_1(v66_1);
    v62.l2 = US1_US1_1("#aaa");
    v62.l22 = US1_US1_1("350px");
    v62.l19 = US1_US1_1("1");
    return v62;
}

export function closure108(unitVar: void, unitVar_1: void): any[] {
    const v2: any = hope;
    const v3: any = v2.iframe;
    const v4: () => any[] = (): any[] => closure109(void 0, void 0);
    const v8: any = createObj(method7(method6(v4, method80())));
    const v9: (arg0: any) => any = v3;
    const v12: any = createComponent;
    return [v12(v9, v8)];
}

export function method79(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v64_1: any = <>
        Testnet Bank Dispenser
    </>;
    v62.l55 = US8_US8_1(v64_1);
    const v66_1: () => any[] = (): any[] => closure108(void 0, void 0);
    v62.l9 = US5_US5_1(v66_1);
    return v62;
}

export function closure66(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut3) => any = (v: Mut3): any => closure10(void 0, v);
    const v4: Mut3 = new Mut3(US11_US11_0(), method63(), US12_US12_2());
    const v6: (arg0: any) => any = v0_1;
    const v9: any = createComponent;
    const v10: any = v9(v6, v4);
    const v14: Mut3 = new Mut3(US11_US11_0(), method71(), US12_US12_2());
    const v16: (arg0: any) => any = v0_1;
    const v17: any = createComponent;
    const v18: any = v17(v16, v14);
    const v22: Mut3 = new Mut3(US11_US11_0(), method79(), US12_US12_0());
    const v24: (arg0: any) => any = v0_1;
    const v25: any = createComponent;
    return [v10, v18, v25(v24, v22)];
}

export function closure65(unitVar: void, v0_1: Mut2): any {
    const v1_1: (arg0: Mut2) => any = (v: Mut2): any => closure6(void 0, v);
    const v3: () => any[] = (): any[] => closure66(void 0, void 0);
    const v4: Mut2 = method6(v3, method62());
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = [v4.l0, v4.l1, v4.l2, v4.l3, v4.l4, v4.l5, v4.l6, v4.l7, v4.l8, v4.l9, v4.l10, v4.l11, v4.l12, v4.l13, v4.l14, v4.l15, v4.l16, v4.l17, v4.l18, v4.l19, v4.l20, v4.l21, v4.l22, v4.l23, v4.l24, v4.l25, v4.l26, v4.l27, v4.l28, v4.l29, v4.l30, v4.l31, v4.l32, v4.l33, v4.l34, v4.l35, v4.l36, v4.l37, v4.l38, v4.l39, v4.l40, v4.l41, v4.l42, v4.l43, v4.l44, v4.l45, v4.l46, v4.l47, v4.l48, v4.l49, v4.l50, v4.l51, v4.l52, v4.l53, v4.l54, v4.l55, v4.l56, v4.l57, v4.l58, v4.l59, v4.l60, v4.l61];
    const v67_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v69_1: (arg0: any) => any = v1_1;
    const v72_1: any = createComponent;
    return v72_1(v69_1, v67_1);
}

export function method81(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    return new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
}

export function closure110(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure64(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut2) => any = (v: Mut2): any => closure65(void 0, v);
    const v2: () => any[] = (): any[] => closure110(void 0, void 0);
    const v3: Mut2 = method6(v2, method81());
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = [v3.l0, v3.l1, v3.l2, v3.l3, v3.l4, v3.l5, v3.l6, v3.l7, v3.l8, v3.l9, v3.l10, v3.l11, v3.l12, v3.l13, v3.l14, v3.l15, v3.l16, v3.l17, v3.l18, v3.l19, v3.l20, v3.l21, v3.l22, v3.l23, v3.l24, v3.l25, v3.l26, v3.l27, v3.l28, v3.l29, v3.l30, v3.l31, v3.l32, v3.l33, v3.l34, v3.l35, v3.l36, v3.l37, v3.l38, v3.l39, v3.l40, v3.l41, v3.l42, v3.l43, v3.l44, v3.l45, v3.l46, v3.l47, v3.l48, v3.l49, v3.l50, v3.l51, v3.l52, v3.l53, v3.l54, v3.l55, v3.l56, v3.l57, v3.l58, v3.l59, v3.l60, v3.l61];
    const v66_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v68_1: (arg0: any) => any = v0_1;
    const v71_1: any = createComponent;
    return [v71_1(v68_1, v66_1)];
}

export function method61(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    v62.l25 = US1_US1_1("db");
    const v66_1: any = <>
        Chain
    </>;
    v62.l55 = US8_US8_1(v66_1);
    const v68_1: () => any[] = (): any[] => closure64(void 0, void 0);
    v62.l9 = US5_US5_1(v68_1);
    return v62;
}

export function method82(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    return new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
}

export function method84(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    return new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
}

export function method86(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    return new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
}

export function method88(v0_1: int32, v1_1: Mut10): boolean {
    return v1_1.l0 < v0_1;
}

export function closure119(v0_1: Mut9, v1_1: Mut1): US1 {
    const v2: [US2, int32, string, string][] = v1_1.l4;
    const v4: (arg0: [US2, int32, string, string]) => US1 = v0_1.l1;
    const v5: int32 = v2.length | 0;
    const v7: Mut10 = new Mut10(0, US1_US1_0());
    while (method88(v5, v7)) {
        const v9: int32 = v7.l0 | 0;
        const v12: int32 = ((op_UnaryNegation_Int32(v9) + v5) - 1) | 0;
        const v13: US1 = v7.l1;
        const patternInput_1: [US2, int32, string, string] = v2[v12];
        const v20: US1 = (v13.tag === US1_Tag.US1_1) ? v13 : v4([patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3]]);
        const v21: int32 = (v9 + 1) | 0;
        v7.l0 = (v21 | 0);
        v7.l1 = v20;
    }
    return v7.l1;
}

export function method89(v0_1: int32, v1_1: Mut11): boolean {
    return v1_1.l0 < v0_1;
}

export function method90(): [US2, int32, string, string] {
    const v1_1: string = "";
    return [US2_US2_1(), 0, v1_1, v1_1];
}

export function closure122(v0_1: Mut9, v1_1: Mut1, v2: US1): void {
    const v3: [US2, int32, string, string][] = v1_1.l4;
    const v5: [US2, int32, string, string][] = v1_1.l4;
    const v7: int32 = v5.length | 0;
    const v9: Mut11 = new Mut11(0, US13_US13_0());
    while (method89(v7, v9)) {
        const v11: int32 = v9.l0 | 0;
        const v14: int32 = ((op_UnaryNegation_Int32(v11) + v7) - 1) | 0;
        const v15: US13 = v9.l1;
        const patternInput_2: [US2, int32, string, string] = v5[v14];
        const v16: US2 = patternInput_2[0];
        let v29: US13;
        if (v15.tag === US13_Tag.US13_1) {
            v29 = v15;
        }
        else {
            const v20: US2 = v0_1.l0;
            v29 = (((v16.tag === US2_Tag.US2_1) ? (v20.tag === US2_Tag.US2_1) : (v20.tag === US2_Tag.US2_0)) ? US13_US13_1(v16, patternInput_2[1], patternInput_2[2], patternInput_2[3]) : US13_US13_0());
        }
        const v30: int32 = (v11 + 1) | 0;
        v9.l0 = (v30 | 0);
        v9.l1 = v29;
    }
    const v31: US13 = v9.l1;
    const patternInput_3: [US2, int32, string, string] = method90();
    const patternInput_4: [US2, int32, string, string] = (v31.tag === US13_Tag.US13_1) ? [v31.fields[0], v31.fields[1], v31.fields[2], v31.fields[3]] : [patternInput_3[0], patternInput_3[1], patternInput_3[2], patternInput_3[3]];
    const patternInput_5: [US2, int32, string, string] = v0_1.l2([patternInput_4[0], patternInput_4[1], patternInput_4[2], patternInput_4[3]], v2);
    const v50: [US2, int32, string, string][] = [[patternInput_5[0], patternInput_5[1], patternInput_5[2], patternInput_5[3]]];
    const v51: int32 = v3.length | 0;
    const v53: int32 = (v51 + v50.length) | 0;
    const v54: [US2, int32, string, string][] = fill(new Array(v53), 0, v53, null);
    const v55: Mut5 = new Mut5(0);
    while (method19(v53, v55)) {
        const v57: int32 = v55.l0 | 0;
        let patternInput_8: [US2, int32, string, string];
        if (v57 < v51) {
            const patternInput_6: [US2, int32, string, string] = v3[v57];
            patternInput_8 = [patternInput_6[0], patternInput_6[1], patternInput_6[2], patternInput_6[3]];
        }
        else {
            const v63: int32 = (v57 - v51) | 0;
            const patternInput_7: [US2, int32, string, string] = v50[v63];
            patternInput_8 = [patternInput_7[0], patternInput_7[1], patternInput_7[2], patternInput_7[3]];
        }
        v54[v57] = [patternInput_8[0], patternInput_8[1], patternInput_8[2], patternInput_8[3]];
        const v72_1: int32 = (v57 + 1) | 0;
        v55.l0 = (v72_1 | 0);
    }
    v1_1.l4 = v54;
}

export function closure121(v0_1: Mut9, v1_1: Mut1): (arg0: US1) => void {
    return (v: US1): void => {
        closure122(v0_1, v1_1, v);
    };
}

export function closure120(v0_1: Mut9, v1_1: Mut1): (arg0: Mut1, arg1: US1) => void {
    return (v: Mut1): (arg0: US1) => void => closure121(v0_1, v);
}

export function closure118(unitVar: void, v0_1: Mut9): any {
    const v1_1: (arg0: Mut6) => any = (v: Mut6): any => closure71(void 0, v);
    const v2: (arg0: Mut1) => US1 = (v_1: Mut1): US1 => closure119(v0_1, v_1);
    const v3: (arg0: Mut1, arg1: Mut1, arg2: US1) => void = (v_2: Mut1): (arg0: Mut1, arg1: US1) => void => closure120(v0_1, v_2);
    const v4: Mut6 = new Mut6(v2, uncurry(3, v3));
    const v6: (arg0: any) => any = v1_1;
    const v9: any = createComponent;
    return v9(v6, v4);
}

export function closure123(unitVar: void, _arg: [US2, int32, string, string]): US1 {
    return US1_US1_1(_arg[2]);
}

export function closure125(v0_1: Mut8, v1_1: US2, v2: int32, v3: string, v4: string, v5: US1): [US2, int32, string, string] {
    return [v0_1.l0, v2, (v5.tag === US1_Tag.US1_1) ? v5.fields[0] : "", v4];
}

export function closure124(v0_1: Mut8, _arg: [US2, int32, string, string]): (arg0: US1) => [US2, int32, string, string] {
    return (v: US1): [US2, int32, string, string] => closure125(v0_1, _arg[0], _arg[1], _arg[2], _arg[3], v);
}

export function closure117(v0_1: Mut8, unitVar: void): any[] {
    const v1_1: (arg0: Mut9) => any = (v: Mut9): any => closure118(void 0, v);
    const v3: (arg0: [US2, int32, string, string]) => US1 = (arg10$0040: [US2, int32, string, string]): US1 => closure123(void 0, arg10$0040);
    const v4: (arg0: [US2, int32, string, string], arg1: US1) => [US2, int32, string, string] = (arg10$0040_1: [US2, int32, string, string]): (arg0: US1) => [US2, int32, string, string] => closure124(v0_1, arg10$0040_1);
    const v5: Mut9 = new Mut9(v0_1.l0, v3, uncurry(2, v4));
    const v7: (arg0: any) => any = v1_1;
    const v10: any = createComponent;
    return [v10(v7, v5)];
}

export function method87(v0_1: Mut8): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v63: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v65_1: any = <>
        URL
    </>;
    v63.l55 = US8_US8_1(v65_1);
    v63.l43 = US1_US1_1("3px");
    const v69_1: () => any[] = (): any[] => closure117(v0_1, void 0);
    v63.l9 = US5_US5_1(v69_1);
    return v63;
}

export function method92(v0_1: int32, v1_1: Mut13): boolean {
    return v1_1.l0 < v0_1;
}

export function closure128(v0_1: Mut12, v1_1: Mut1): US0 {
    const v2: [US2, int32, string, string][] = v1_1.l4;
    const v4: (arg0: [US2, int32, string, string]) => US0 = v0_1.l1;
    const v5: int32 = v2.length | 0;
    const v7: Mut13 = new Mut13(0, US0_US0_0());
    while (method92(v5, v7)) {
        const v9: int32 = v7.l0 | 0;
        const v12: int32 = ((op_UnaryNegation_Int32(v9) + v5) - 1) | 0;
        const v13: US0 = v7.l1;
        const patternInput_1: [US2, int32, string, string] = v2[v12];
        const v20: US0 = (v13.tag === US0_Tag.US0_1) ? v13 : v4([patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3]]);
        const v21: int32 = (v9 + 1) | 0;
        v7.l0 = (v21 | 0);
        v7.l1 = v20;
    }
    return v7.l1;
}

export function closure131(v0_1: Mut12, v1_1: Mut1, v2: US0): void {
    const v3: [US2, int32, string, string][] = v1_1.l4;
    const v5: [US2, int32, string, string][] = v1_1.l4;
    const v7: int32 = v5.length | 0;
    const v9: Mut11 = new Mut11(0, US13_US13_0());
    while (method89(v7, v9)) {
        const v11: int32 = v9.l0 | 0;
        const v14: int32 = ((op_UnaryNegation_Int32(v11) + v7) - 1) | 0;
        const v15: US13 = v9.l1;
        const patternInput_2: [US2, int32, string, string] = v5[v14];
        const v16: US2 = patternInput_2[0];
        let v29: US13;
        if (v15.tag === US13_Tag.US13_1) {
            v29 = v15;
        }
        else {
            const v20: US2 = v0_1.l0;
            v29 = (((v16.tag === US2_Tag.US2_1) ? (v20.tag === US2_Tag.US2_1) : (v20.tag === US2_Tag.US2_0)) ? US13_US13_1(v16, patternInput_2[1], patternInput_2[2], patternInput_2[3]) : US13_US13_0());
        }
        const v30: int32 = (v11 + 1) | 0;
        v9.l0 = (v30 | 0);
        v9.l1 = v29;
    }
    const v31: US13 = v9.l1;
    const patternInput_3: [US2, int32, string, string] = method90();
    const patternInput_4: [US2, int32, string, string] = (v31.tag === US13_Tag.US13_1) ? [v31.fields[0], v31.fields[1], v31.fields[2], v31.fields[3]] : [patternInput_3[0], patternInput_3[1], patternInput_3[2], patternInput_3[3]];
    const patternInput_5: [US2, int32, string, string] = v0_1.l2([patternInput_4[0], patternInput_4[1], patternInput_4[2], patternInput_4[3]], v2);
    const v50: [US2, int32, string, string][] = [[patternInput_5[0], patternInput_5[1], patternInput_5[2], patternInput_5[3]]];
    const v51: int32 = v3.length | 0;
    const v53: int32 = (v51 + v50.length) | 0;
    const v54: [US2, int32, string, string][] = fill(new Array(v53), 0, v53, null);
    const v55: Mut5 = new Mut5(0);
    while (method19(v53, v55)) {
        const v57: int32 = v55.l0 | 0;
        let patternInput_8: [US2, int32, string, string];
        if (v57 < v51) {
            const patternInput_6: [US2, int32, string, string] = v3[v57];
            patternInput_8 = [patternInput_6[0], patternInput_6[1], patternInput_6[2], patternInput_6[3]];
        }
        else {
            const v63: int32 = (v57 - v51) | 0;
            const patternInput_7: [US2, int32, string, string] = v50[v63];
            patternInput_8 = [patternInput_7[0], patternInput_7[1], patternInput_7[2], patternInput_7[3]];
        }
        v54[v57] = [patternInput_8[0], patternInput_8[1], patternInput_8[2], patternInput_8[3]];
        const v72_1: int32 = (v57 + 1) | 0;
        v55.l0 = (v72_1 | 0);
    }
    v1_1.l4 = v54;
}

export function closure130(v0_1: Mut12, v1_1: Mut1): (arg0: US0) => void {
    return (v: US0): void => {
        closure131(v0_1, v1_1, v);
    };
}

export function closure129(v0_1: Mut12, v1_1: Mut1): (arg0: Mut1, arg1: US0) => void {
    return (v: Mut1): (arg0: US0) => void => closure130(v0_1, v);
}

export function closure127(unitVar: void, v0_1: Mut12): any {
    const v1_1: (arg0: Mut7) => any = (v: Mut7): any => closure84(void 0, v);
    const v2: (arg0: Mut1) => US0 = (v_1: Mut1): US0 => closure128(v0_1, v_1);
    const v3: (arg0: Mut1, arg1: Mut1, arg2: US0) => void = (v_2: Mut1): (arg0: Mut1, arg1: US0) => void => closure129(v0_1, v_2);
    const v4: Mut7 = new Mut7(v2, uncurry(3, v3));
    const v6: (arg0: any) => any = v1_1;
    const v9: any = createComponent;
    return v9(v6, v4);
}

export function closure132(unitVar: void, _arg: [US2, int32, string, string]): US0 {
    return US0_US0_1(_arg[1]);
}

export function closure134(v0_1: Mut8, v1_1: US2, v2: int32, v3: string, v4: string, v5: US0): [US2, int32, string, string] {
    return [v0_1.l0, (v5.tag === US0_Tag.US0_1) ? v5.fields[0] : 0, v3, v4];
}

export function closure133(v0_1: Mut8, _arg: [US2, int32, string, string]): (arg0: US0) => [US2, int32, string, string] {
    return (v: US0): [US2, int32, string, string] => closure134(v0_1, _arg[0], _arg[1], _arg[2], _arg[3], v);
}

export function closure126(v0_1: Mut8, unitVar: void): any[] {
    const v1_1: (arg0: Mut12) => any = (v: Mut12): any => closure127(void 0, v);
    const v3: (arg0: [US2, int32, string, string]) => US0 = (arg10$0040: [US2, int32, string, string]): US0 => closure132(void 0, arg10$0040);
    const v4: (arg0: [US2, int32, string, string], arg1: US0) => [US2, int32, string, string] = (arg10$0040_1: [US2, int32, string, string]): (arg0: US0) => [US2, int32, string, string] => closure133(v0_1, arg10$0040_1);
    const v5: Mut12 = new Mut12(v0_1.l0, v3, uncurry(2, v4));
    const v7: (arg0: any) => any = v1_1;
    const v10: any = createComponent;
    return [v10(v7, v5)];
}

export function method91(v0_1: Mut8): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v63: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v65_1: any = <>
        Port
    </>;
    v63.l55 = US8_US8_1(v65_1);
    v63.l43 = US1_US1_1("3px");
    const v69_1: () => any[] = (): any[] => closure126(v0_1, void 0);
    v63.l9 = US5_US5_1(v69_1);
    return v63;
}

export function closure116(v0_1: Mut8, unitVar: void): any[] {
    const v1_1: (arg0: Mut3) => any = (v: Mut3): any => closure10(void 0, v);
    const v5: Mut3 = new Mut3(US11_US11_0(), method87(v0_1), US12_US12_2());
    const v7: (arg0: any) => any = v1_1;
    const v10: any = createComponent;
    const v11: any = v10(v7, v5);
    const v15: Mut3 = new Mut3(US11_US11_0(), method91(v0_1), US12_US12_2());
    const v17: (arg0: any) => any = v1_1;
    const v18: any = createComponent;
    return [v11, v18(v17, v15)];
}

export function closure115(unitVar: void, v0_1: Mut8): any {
    const v1_1: (arg0: Mut2) => any = (v: Mut2): any => closure6(void 0, v);
    const v3: () => any[] = (): any[] => closure116(v0_1, void 0);
    const v4: Mut2 = method6(v3, method86());
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = [v4.l0, v4.l1, v4.l2, v4.l3, v4.l4, v4.l5, v4.l6, v4.l7, v4.l8, v4.l9, v4.l10, v4.l11, v4.l12, v4.l13, v4.l14, v4.l15, v4.l16, v4.l17, v4.l18, v4.l19, v4.l20, v4.l21, v4.l22, v4.l23, v4.l24, v4.l25, v4.l26, v4.l27, v4.l28, v4.l29, v4.l30, v4.l31, v4.l32, v4.l33, v4.l34, v4.l35, v4.l36, v4.l37, v4.l38, v4.l39, v4.l40, v4.l41, v4.l42, v4.l43, v4.l44, v4.l45, v4.l46, v4.l47, v4.l48, v4.l49, v4.l50, v4.l51, v4.l52, v4.l53, v4.l54, v4.l55, v4.l56, v4.l57, v4.l58, v4.l59, v4.l60, v4.l61];
    const v67_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v69_1: (arg0: any) => any = v1_1;
    const v72_1: any = createComponent;
    return v72_1(v69_1, v67_1);
}

export function closure114(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut8) => any = (v: Mut8): any => closure115(void 0, v);
    const v2: Mut8 = new Mut8(US2_US2_1());
    const v4: (arg0: any) => any = v0_1;
    const v7: any = createComponent;
    return [v7(v4, v2)];
}

export function method85(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    v62.l25 = US1_US1_1("db-gun-rs-rs");
    const v66_1: any = <>
        Rust -> Rust
    </>;
    v62.l55 = US8_US8_1(v66_1);
    const v68_1: () => any[] = (): any[] => closure114(void 0, void 0);
    v62.l9 = US5_US5_1(v68_1);
    return v62;
}

export function closure138(unitVar: void, v0_1: Mut1): void {
    const v2: [US2, US2][] = v0_1.l5;
    const v5: [US2, US2][] = [[US2_US2_1(), US2_US2_1()]];
    const v6: int32 = v2.length | 0;
    const v8: int32 = (v6 + v5.length) | 0;
    const v9: [US2, US2][] = fill(new Array(v8), 0, v8, null);
    const v10: Mut5 = new Mut5(0);
    while (method19(v8, v10)) {
        const v12: int32 = v10.l0 | 0;
        let patternInput_3: [US2, US2];
        if (v12 < v6) {
            const patternInput_1: [US2, US2] = v2[v12];
            patternInput_3 = [patternInput_1[0], patternInput_1[1]];
        }
        else {
            const v16: int32 = (v12 - v6) | 0;
            const patternInput_2: [US2, US2] = v5[v16];
            patternInput_3 = [patternInput_2[0], patternInput_2[1]];
        }
        v9[v12] = [patternInput_3[0], patternInput_3[1]];
        const v21: int32 = (v12 + 1) | 0;
        v10.l0 = (v21 | 0);
    }
    v0_1.l5 = v9;
}

export function closure137(unitVar: void, v0_1: Mut1): (arg0: Mut1) => void {
    return (v: Mut1): void => {
        closure138(void 0, v);
    };
}

export function closure136(unitVar: void, v0_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void): void {
    const v1_1: (arg0: Mut1, arg1: Mut1) => void = (v: Mut1): (arg0: Mut1) => void => closure137(void 0, v);
    v0_1(v1_1);
}

export function closure135(unitVar: void, v0_1: Mut1): (arg0: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void {
    return (v: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void): void => {
        closure136(void 0, v);
    };
}

export function closure139(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut8) => any = (v: Mut8): any => closure115(void 0, v);
    const v2: Mut8 = new Mut8(US2_US2_0());
    const v4: (arg0: any) => any = v0_1;
    const v7: any = createComponent;
    return [v7(v4, v2)];
}

export function method93(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    v62.l25 = US1_US1_1("db-gun-rs-js");
    const v66_1: any = <>
        Rust -> JavaScript
    </>;
    v62.l55 = US8_US8_1(v66_1);
    const v68_1: () => any[] = (): any[] => closure139(void 0, void 0);
    v62.l9 = US5_US5_1(v68_1);
    return v62;
}

export function closure143(unitVar: void, v0_1: Mut1): void {
    const v2: [US2, US2][] = v0_1.l5;
    const v5: [US2, US2][] = [[US2_US2_1(), US2_US2_0()]];
    const v6: int32 = v2.length | 0;
    const v8: int32 = (v6 + v5.length) | 0;
    const v9: [US2, US2][] = fill(new Array(v8), 0, v8, null);
    const v10: Mut5 = new Mut5(0);
    while (method19(v8, v10)) {
        const v12: int32 = v10.l0 | 0;
        let patternInput_3: [US2, US2];
        if (v12 < v6) {
            const patternInput_1: [US2, US2] = v2[v12];
            patternInput_3 = [patternInput_1[0], patternInput_1[1]];
        }
        else {
            const v16: int32 = (v12 - v6) | 0;
            const patternInput_2: [US2, US2] = v5[v16];
            patternInput_3 = [patternInput_2[0], patternInput_2[1]];
        }
        v9[v12] = [patternInput_3[0], patternInput_3[1]];
        const v21: int32 = (v12 + 1) | 0;
        v10.l0 = (v21 | 0);
    }
    v0_1.l5 = v9;
}

export function closure142(unitVar: void, v0_1: Mut1): (arg0: Mut1) => void {
    return (v: Mut1): void => {
        closure143(void 0, v);
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

export function closure144(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut8) => any = (v: Mut8): any => closure115(void 0, v);
    const v2: Mut8 = new Mut8(US2_US2_0());
    const v4: (arg0: any) => any = v0_1;
    const v7: any = createComponent;
    return [v7(v4, v2)];
}

export function method94(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    v62.l25 = US1_US1_1("db-gun-js-js");
    const v66_1: any = <>
        JavaScript -> JavaScript
    </>;
    v62.l55 = US8_US8_1(v66_1);
    const v68_1: () => any[] = (): any[] => closure144(void 0, void 0);
    v62.l9 = US5_US5_1(v68_1);
    return v62;
}

export function closure148(unitVar: void, v0_1: Mut1): void {
    const v2: [US2, US2][] = v0_1.l5;
    const v5: [US2, US2][] = [[US2_US2_0(), US2_US2_0()]];
    const v6: int32 = v2.length | 0;
    const v8: int32 = (v6 + v5.length) | 0;
    const v9: [US2, US2][] = fill(new Array(v8), 0, v8, null);
    const v10: Mut5 = new Mut5(0);
    while (method19(v8, v10)) {
        const v12: int32 = v10.l0 | 0;
        let patternInput_3: [US2, US2];
        if (v12 < v6) {
            const patternInput_1: [US2, US2] = v2[v12];
            patternInput_3 = [patternInput_1[0], patternInput_1[1]];
        }
        else {
            const v16: int32 = (v12 - v6) | 0;
            const patternInput_2: [US2, US2] = v5[v16];
            patternInput_3 = [patternInput_2[0], patternInput_2[1]];
        }
        v9[v12] = [patternInput_3[0], patternInput_3[1]];
        const v21: int32 = (v12 + 1) | 0;
        v10.l0 = (v21 | 0);
    }
    v0_1.l5 = v9;
}

export function closure147(unitVar: void, v0_1: Mut1): (arg0: Mut1) => void {
    return (v: Mut1): void => {
        closure148(void 0, v);
    };
}

export function closure146(unitVar: void, v0_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void): void {
    const v1_1: (arg0: Mut1, arg1: Mut1) => void = (v: Mut1): (arg0: Mut1) => void => closure147(void 0, v);
    v0_1(v1_1);
}

export function closure145(unitVar: void, v0_1: Mut1): (arg0: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void {
    return (v: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void): void => {
        closure146(void 0, v);
    };
}

export function closure149(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut8) => any = (v: Mut8): any => closure115(void 0, v);
    const v2: Mut8 = new Mut8(US2_US2_1());
    const v4: (arg0: any) => any = v0_1;
    const v7: any = createComponent;
    return [v7(v4, v2)];
}

export function method95(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    v62.l25 = US1_US1_1("db-gun-js-rs");
    const v66_1: any = <>
        JavaScript -> Rust
    </>;
    v62.l55 = US8_US8_1(v66_1);
    const v68_1: () => any[] = (): any[] => closure149(void 0, void 0);
    v62.l9 = US5_US5_1(v68_1);
    return v62;
}

export function closure153(unitVar: void, v0_1: Mut1): void {
    const v2: [US2, US2][] = v0_1.l5;
    const v5: [US2, US2][] = [[US2_US2_0(), US2_US2_1()]];
    const v6: int32 = v2.length | 0;
    const v8: int32 = (v6 + v5.length) | 0;
    const v9: [US2, US2][] = fill(new Array(v8), 0, v8, null);
    const v10: Mut5 = new Mut5(0);
    while (method19(v8, v10)) {
        const v12: int32 = v10.l0 | 0;
        let patternInput_3: [US2, US2];
        if (v12 < v6) {
            const patternInput_1: [US2, US2] = v2[v12];
            patternInput_3 = [patternInput_1[0], patternInput_1[1]];
        }
        else {
            const v16: int32 = (v12 - v6) | 0;
            const patternInput_2: [US2, US2] = v5[v16];
            patternInput_3 = [patternInput_2[0], patternInput_2[1]];
        }
        v9[v12] = [patternInput_3[0], patternInput_3[1]];
        const v21: int32 = (v12 + 1) | 0;
        v10.l0 = (v21 | 0);
    }
    v0_1.l5 = v9;
}

export function closure152(unitVar: void, v0_1: Mut1): (arg0: Mut1) => void {
    return (v: Mut1): void => {
        closure153(void 0, v);
    };
}

export function closure151(unitVar: void, v0_1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void): void {
    const v1_1: (arg0: Mut1, arg1: Mut1) => void = (v: Mut1): (arg0: Mut1) => void => closure152(void 0, v);
    v0_1(v1_1);
}

export function closure150(unitVar: void, v0_1: Mut1): (arg0: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void {
    return (v: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void): void => {
        closure151(void 0, v);
    };
}

export function closure113(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut3) => any = (v: Mut3): any => closure10(void 0, v);
    const v2: (arg0: Mut1, arg1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void = (v_1: Mut1): (arg0: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void => closure135(void 0, v_1);
    const v5: Mut3 = new Mut3(US11_US11_1(uncurry(2, v2)), method85(), US12_US12_0());
    const v7: (arg0: any) => any = v0_1;
    const v10: any = createComponent;
    const v11: any = v10(v7, v5);
    const v13: (arg0: Mut1, arg1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void = (v_2: Mut1): (arg0: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void => closure140(void 0, v_2);
    const v16: Mut3 = new Mut3(US11_US11_1(uncurry(2, v13)), method93(), US12_US12_0());
    const v18: (arg0: any) => any = v0_1;
    const v19: any = createComponent;
    const v20: any = v19(v18, v16);
    const v22: (arg0: Mut1, arg1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void = (v_3: Mut1): (arg0: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void => closure145(void 0, v_3);
    const v25: Mut3 = new Mut3(US11_US11_1(uncurry(2, v22)), method94(), US12_US12_0());
    const v27: (arg0: any) => any = v0_1;
    const v28: any = createComponent;
    const v29: any = v28(v27, v25);
    const v31: (arg0: Mut1, arg1: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void = (v_4: Mut1): (arg0: (arg0: (arg0: Mut1, arg1: Mut1) => void) => void) => void => closure150(void 0, v_4);
    const v34: Mut3 = new Mut3(US11_US11_1(uncurry(2, v31)), method95(), US12_US12_0());
    const v36: (arg0: any) => any = v0_1;
    const v37: any = createComponent;
    return [v11, v20, v29, v37(v36, v34)];
}

export function closure112(unitVar: void, v0_1: Mut2): any {
    const v1_1: (arg0: Mut2) => any = (v: Mut2): any => closure6(void 0, v);
    const v3: () => any[] = (): any[] => closure113(void 0, void 0);
    const v4: Mut2 = method6(v3, method84());
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = [v4.l0, v4.l1, v4.l2, v4.l3, v4.l4, v4.l5, v4.l6, v4.l7, v4.l8, v4.l9, v4.l10, v4.l11, v4.l12, v4.l13, v4.l14, v4.l15, v4.l16, v4.l17, v4.l18, v4.l19, v4.l20, v4.l21, v4.l22, v4.l23, v4.l24, v4.l25, v4.l26, v4.l27, v4.l28, v4.l29, v4.l30, v4.l31, v4.l32, v4.l33, v4.l34, v4.l35, v4.l36, v4.l37, v4.l38, v4.l39, v4.l40, v4.l41, v4.l42, v4.l43, v4.l44, v4.l45, v4.l46, v4.l47, v4.l48, v4.l49, v4.l50, v4.l51, v4.l52, v4.l53, v4.l54, v4.l55, v4.l56, v4.l57, v4.l58, v4.l59, v4.l60, v4.l61];
    const v67_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v69_1: (arg0: any) => any = v1_1;
    const v72_1: any = createComponent;
    return v72_1(v69_1, v67_1);
}

export function method96(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    return new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
}

export function closure154(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure111(unitVar: void, unitVar_1: void): any[] {
    const v0_1: (arg0: Mut2) => any = (v: Mut2): any => closure112(void 0, v);
    const v2: () => any[] = (): any[] => closure154(void 0, void 0);
    const v3: Mut2 = method6(v2, method96());
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = [v3.l0, v3.l1, v3.l2, v3.l3, v3.l4, v3.l5, v3.l6, v3.l7, v3.l8, v3.l9, v3.l10, v3.l11, v3.l12, v3.l13, v3.l14, v3.l15, v3.l16, v3.l17, v3.l18, v3.l19, v3.l20, v3.l21, v3.l22, v3.l23, v3.l24, v3.l25, v3.l26, v3.l27, v3.l28, v3.l29, v3.l30, v3.l31, v3.l32, v3.l33, v3.l34, v3.l35, v3.l36, v3.l37, v3.l38, v3.l39, v3.l40, v3.l41, v3.l42, v3.l43, v3.l44, v3.l45, v3.l46, v3.l47, v3.l48, v3.l49, v3.l50, v3.l51, v3.l52, v3.l53, v3.l54, v3.l55, v3.l56, v3.l57, v3.l58, v3.l59, v3.l60, v3.l61];
    const v66_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v68_1: (arg0: any) => any = v0_1;
    const v71_1: any = createComponent;
    return [v71_1(v68_1, v66_1)];
}

export function method83(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    v62.l25 = US1_US1_1("db");
    const v66_1: any = <>
        Database
    </>;
    v62.l55 = US8_US8_1(v66_1);
    const v68_1: () => any[] = (): any[] => closure111(void 0, void 0);
    v62.l9 = US5_US5_1(v68_1);
    return v62;
}

export function method97(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    return new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
}

export function method99(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    return new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
}

export function closure158(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function method100(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    return new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
}

export function closure157(unitVar: void, v0_1: Mut2): any {
    const v3: any = Box;
    const v4: () => any[] = (): any[] => closure158(void 0, void 0);
    const v8: any = createObj(method7(method6(v4, method100())));
    const v9: (arg0: any) => any = v3;
    const v12: any = createComponent;
    return v12(v9, v8);
}

export function method101(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    return new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
}

export function closure159(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure161(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function method102(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    return new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
}

export function closure160(unitVar: void, v0_1: Mut2): any {
    const v3: any = Box;
    const v4: () => any[] = (): any[] => closure161(void 0, void 0);
    const v8: any = createObj(method7(method6(v4, method102())));
    const v9: (arg0: any) => any = v3;
    const v12: any = createComponent;
    return v12(v9, v8);
}

export function method103(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    return new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
}

export function closure162(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure164(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function method104(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    return new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
}

export function closure163(unitVar: void, v0_1: Mut2): any {
    const v3: any = Box;
    const v4: () => any[] = (): any[] => closure164(void 0, void 0);
    const v8: any = createObj(method7(method6(v4, method104())));
    const v9: (arg0: any) => any = v3;
    const v12: any = createComponent;
    return v12(v9, v8);
}

export function method105(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    return new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
}

export function closure165(unitVar: void, unitVar_1: void): any[] {
    return [];
}

export function closure156(v0_1: any, v1_1: string, v2: boolean, unitVar: void): any[] {
    const v3: (arg0: Mut2) => any = (v: Mut2): any => closure157(void 0, v);
    const v5: () => any[] = (): any[] => closure159(void 0, void 0);
    const v6: Mut2 = method6(v5, method101());
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = [v6.l0, v6.l1, v6.l2, v6.l3, v6.l4, v6.l5, v6.l6, v6.l7, v6.l8, v6.l9, v6.l10, v6.l11, v6.l12, v6.l13, v6.l14, v6.l15, v6.l16, v6.l17, v6.l18, v6.l19, v6.l20, v6.l21, v6.l22, v6.l23, v6.l24, v6.l25, v6.l26, v6.l27, v6.l28, v6.l29, v6.l30, v6.l31, v6.l32, v6.l33, v6.l34, v6.l35, v6.l36, v6.l37, v6.l38, v6.l39, v6.l40, v6.l41, v6.l42, v6.l43, v6.l44, v6.l45, v6.l46, v6.l47, v6.l48, v6.l49, v6.l50, v6.l51, v6.l52, v6.l53, v6.l54, v6.l55, v6.l56, v6.l57, v6.l58, v6.l59, v6.l60, v6.l61];
    const v69_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v71_1: (arg0: any) => any = v3;
    const v74_1: any = createComponent;
    const v75_1: any = v74_1(v71_1, v69_1);
    const v76_1: (arg0: Mut2) => any = (v_1: Mut2): any => closure160(void 0, v_1);
    const v78_1: () => any[] = (): any[] => closure162(void 0, void 0);
    const v79_1: Mut2 = method6(v78_1, method103());
    const patternInput_1: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = [v79_1.l0, v79_1.l1, v79_1.l2, v79_1.l3, v79_1.l4, v79_1.l5, v79_1.l6, v79_1.l7, v79_1.l8, v79_1.l9, v79_1.l10, v79_1.l11, v79_1.l12, v79_1.l13, v79_1.l14, v79_1.l15, v79_1.l16, v79_1.l17, v79_1.l18, v79_1.l19, v79_1.l20, v79_1.l21, v79_1.l22, v79_1.l23, v79_1.l24, v79_1.l25, v79_1.l26, v79_1.l27, v79_1.l28, v79_1.l29, v79_1.l30, v79_1.l31, v79_1.l32, v79_1.l33, v79_1.l34, v79_1.l35, v79_1.l36, v79_1.l37, v79_1.l38, v79_1.l39, v79_1.l40, v79_1.l41, v79_1.l42, v79_1.l43, v79_1.l44, v79_1.l45, v79_1.l46, v79_1.l47, v79_1.l48, v79_1.l49, v79_1.l50, v79_1.l51, v79_1.l52, v79_1.l53, v79_1.l54, v79_1.l55, v79_1.l56, v79_1.l57, v79_1.l58, v79_1.l59, v79_1.l60, v79_1.l61];
    const v142: Mut2 = new Mut2(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6], patternInput_1[7], patternInput_1[8], patternInput_1[9], patternInput_1[10], patternInput_1[11], patternInput_1[12], patternInput_1[13], patternInput_1[14], patternInput_1[15], patternInput_1[16], patternInput_1[17], patternInput_1[18], patternInput_1[19], patternInput_1[20], patternInput_1[21], patternInput_1[22], patternInput_1[23], patternInput_1[24], patternInput_1[25], patternInput_1[26], patternInput_1[27], patternInput_1[28], patternInput_1[29], patternInput_1[30], patternInput_1[31], patternInput_1[32], patternInput_1[33], patternInput_1[34], patternInput_1[35], patternInput_1[36], patternInput_1[37], patternInput_1[38], patternInput_1[39], patternInput_1[40], patternInput_1[41], patternInput_1[42], patternInput_1[43], patternInput_1[44], patternInput_1[45], patternInput_1[46], patternInput_1[47], patternInput_1[48], patternInput_1[49], patternInput_1[50], patternInput_1[51], patternInput_1[52], patternInput_1[53], patternInput_1[54], patternInput_1[55], patternInput_1[56], patternInput_1[57], patternInput_1[58], patternInput_1[59], patternInput_1[60], patternInput_1[61]);
    const v144: (arg0: any) => any = v76_1;
    const v145: any = createComponent;
    const v149: boolean = (v1_1 === "") !== true;
    const v151: any = v149 ? (v145(v144, v142)) : <></>;
    const v152: (arg0: Mut2) => any = (v_2: Mut2): any => closure163(void 0, v_2);
    const v154: () => any[] = (): any[] => closure165(void 0, void 0);
    const v155: Mut2 = method6(v154, method105());
    const patternInput_2: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = [v155.l0, v155.l1, v155.l2, v155.l3, v155.l4, v155.l5, v155.l6, v155.l7, v155.l8, v155.l9, v155.l10, v155.l11, v155.l12, v155.l13, v155.l14, v155.l15, v155.l16, v155.l17, v155.l18, v155.l19, v155.l20, v155.l21, v155.l22, v155.l23, v155.l24, v155.l25, v155.l26, v155.l27, v155.l28, v155.l29, v155.l30, v155.l31, v155.l32, v155.l33, v155.l34, v155.l35, v155.l36, v155.l37, v155.l38, v155.l39, v155.l40, v155.l41, v155.l42, v155.l43, v155.l44, v155.l45, v155.l46, v155.l47, v155.l48, v155.l49, v155.l50, v155.l51, v155.l52, v155.l53, v155.l54, v155.l55, v155.l56, v155.l57, v155.l58, v155.l59, v155.l60, v155.l61];
    const v218: Mut2 = new Mut2(patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5], patternInput_2[6], patternInput_2[7], patternInput_2[8], patternInput_2[9], patternInput_2[10], patternInput_2[11], patternInput_2[12], patternInput_2[13], patternInput_2[14], patternInput_2[15], patternInput_2[16], patternInput_2[17], patternInput_2[18], patternInput_2[19], patternInput_2[20], patternInput_2[21], patternInput_2[22], patternInput_2[23], patternInput_2[24], patternInput_2[25], patternInput_2[26], patternInput_2[27], patternInput_2[28], patternInput_2[29], patternInput_2[30], patternInput_2[31], patternInput_2[32], patternInput_2[33], patternInput_2[34], patternInput_2[35], patternInput_2[36], patternInput_2[37], patternInput_2[38], patternInput_2[39], patternInput_2[40], patternInput_2[41], patternInput_2[42], patternInput_2[43], patternInput_2[44], patternInput_2[45], patternInput_2[46], patternInput_2[47], patternInput_2[48], patternInput_2[49], patternInput_2[50], patternInput_2[51], patternInput_2[52], patternInput_2[53], patternInput_2[54], patternInput_2[55], patternInput_2[56], patternInput_2[57], patternInput_2[58], patternInput_2[59], patternInput_2[60], patternInput_2[61]);
    const v220: (arg0: any) => any = v152;
    const v221: any = createComponent;
    return [v75_1, v151, v149 ? (v221(v220, v218)) : <></>];
}

export function closure155(v0_1: any, v1_1: string, v2: boolean, unitVar: void): any[] {
    const v3: (arg0: Mut2) => any = (v: Mut2): any => closure6(void 0, v);
    const v5: () => any[] = (): any[] => closure156(v0_1, v1_1, v2, void 0);
    const v6: Mut2 = method6(v5, method99());
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = [v6.l0, v6.l1, v6.l2, v6.l3, v6.l4, v6.l5, v6.l6, v6.l7, v6.l8, v6.l9, v6.l10, v6.l11, v6.l12, v6.l13, v6.l14, v6.l15, v6.l16, v6.l17, v6.l18, v6.l19, v6.l20, v6.l21, v6.l22, v6.l23, v6.l24, v6.l25, v6.l26, v6.l27, v6.l28, v6.l29, v6.l30, v6.l31, v6.l32, v6.l33, v6.l34, v6.l35, v6.l36, v6.l37, v6.l38, v6.l39, v6.l40, v6.l41, v6.l42, v6.l43, v6.l44, v6.l45, v6.l46, v6.l47, v6.l48, v6.l49, v6.l50, v6.l51, v6.l52, v6.l53, v6.l54, v6.l55, v6.l56, v6.l57, v6.l58, v6.l59, v6.l60, v6.l61];
    const v69_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v71_1: (arg0: any) => any = v3;
    const v74_1: any = createComponent;
    return [v74_1(v71_1, v69_1)];
}

export function method98(v0_1: any, v1_1: string, v2: boolean): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v65_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v67_1: any = <>
        Profile
    </>;
    v65_1.l55 = US8_US8_1(v67_1);
    const v69_1: () => any[] = (): any[] => closure155(v0_1, v1_1, v2, void 0);
    v65_1.l9 = US5_US5_1(v69_1);
    return v65_1;
}

export function closure9(v0_1: any, v1_1: string, v2: boolean, unitVar: void): any[] {
    const v3: (arg0: Mut3) => any = (v: Mut3): any => closure10(void 0, v);
    const v7: Mut3 = new Mut3(US11_US11_0(), method38(), US12_US12_2());
    const v9: (arg0: any) => any = v3;
    const v12: any = createComponent;
    const v13: any = v12(v9, v7);
    const v17: Mut3 = new Mut3(US11_US11_0(), method51(), US12_US12_2());
    const v19: (arg0: any) => any = v3;
    const v20: any = createComponent;
    const v21: any = v20(v19, v17);
    const v25: Mut3 = new Mut3(US11_US11_0(), method52(), US12_US12_2());
    const v27: (arg0: any) => any = v3;
    const v28: any = createComponent;
    const v29: any = v28(v27, v25);
    const v33: Mut3 = new Mut3(US11_US11_0(), method60(), US12_US12_2());
    const v35: (arg0: any) => any = v3;
    const v36: any = createComponent;
    const v37: any = v36(v35, v33);
    const v41: Mut3 = new Mut3(US11_US11_0(), method61(), US12_US12_0());
    const v43: (arg0: any) => any = v3;
    const v44: any = createComponent;
    const v45: any = v44(v43, v41);
    const v49: Mut3 = new Mut3(US11_US11_0(), method82(), US12_US12_2());
    const v51: (arg0: any) => any = v3;
    const v52: any = createComponent;
    const v53: any = v52(v51, v49);
    const v57: Mut3 = new Mut3(US11_US11_0(), method83(), US12_US12_0());
    const v59: (arg0: any) => any = v3;
    const v60: any = createComponent;
    const v61: any = v60(v59, v57);
    const v65_1: Mut3 = new Mut3(US11_US11_0(), method97(), US12_US12_2());
    const v67_1: (arg0: any) => any = v3;
    const v68_1: any = createComponent;
    const v69_1: any = v68_1(v67_1, v65_1);
    const v73_1: Mut3 = new Mut3(US11_US11_0(), method98(v0_1, v1_1, v2), US12_US12_2());
    const v75_1: (arg0: any) => any = v3;
    const v76_1: any = createComponent;
    return [v13, v21, v29, v37, v45, v53, v61, v69_1, v76_1(v75_1, v73_1)];
}

export function closure5(v0_1: any, v1_1: string, v2: boolean, unitVar: void): any[] {
    const v3: (arg0: Mut2) => any = (v: Mut2): any => closure6(void 0, v);
    const v5: () => any[] = (): any[] => closure9(v0_1, v1_1, v2, void 0);
    const v6: Mut2 = method6(v5, method12());
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = [v6.l0, v6.l1, v6.l2, v6.l3, v6.l4, v6.l5, v6.l6, v6.l7, v6.l8, v6.l9, v6.l10, v6.l11, v6.l12, v6.l13, v6.l14, v6.l15, v6.l16, v6.l17, v6.l18, v6.l19, v6.l20, v6.l21, v6.l22, v6.l23, v6.l24, v6.l25, v6.l26, v6.l27, v6.l28, v6.l29, v6.l30, v6.l31, v6.l32, v6.l33, v6.l34, v6.l35, v6.l36, v6.l37, v6.l38, v6.l39, v6.l40, v6.l41, v6.l42, v6.l43, v6.l44, v6.l45, v6.l46, v6.l47, v6.l48, v6.l49, v6.l50, v6.l51, v6.l52, v6.l53, v6.l54, v6.l55, v6.l56, v6.l57, v6.l58, v6.l59, v6.l60, v6.l61];
    const v69_1: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    const v71_1: (arg0: any) => any = v3;
    const v74_1: any = createComponent;
    return [v74_1(v71_1, v69_1)];
}

export function method106(): Mut2 {
    const patternInput: [US1, US3, US1, US1, US1, US1, US1, US1, US4, US5, US1, US1, US4, US6, US1, US1, US1, US7, US4, US1, US1, US1, US1, US1, US8, US1, US1, US1, US6, US1, US1, US1, US1, US1, US1, US1, US1, US9, US10, US9, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US1, US8, US1, US1, US6, US1, US0, US1] = method5();
    const v62: Mut2 = new Mut2(patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54], patternInput[55], patternInput[56], patternInput[57], patternInput[58], patternInput[59], patternInput[60], patternInput[61]);
    v62.l16 = US1_US1_1("flex");
    v62.l19 = US1_US1_1("1");
    v62.l20 = US1_US1_1("column");
    v62.l36 = US1_US1_1("100vw");
    v62.l22 = US1_US1_1("100vh");
    v62.l2 = US1_US1_1("$bg");
    v62.l21 = US1_US1_1("$sm");
    v62.l10 = US1_US1_1("$text1");
    v62.l43 = US1_US1_1("1px");
    return v62;
}

export function closure4(unitVar: void, v0_1: Mut2): any {
    const patternInput: [any, string, boolean] = method2();
    const v6: any = Box;
    const v7: () => any[] = (): any[] => closure5(patternInput[0], patternInput[1], patternInput[2], void 0);
    const v11: any = createObj(method7(method6(v7, method106())));
    const v12: (arg0: any) => any = v6;
    const v15: any = createComponent;
    return v15(v12, v11);
}

export const v0 = void 0;

export const v1 = new Mut0(v0);

export const patternInput$00404617 = method0();

export const v71 = patternInput$00404617[7];

export const v70 = patternInput$00404617[6];

export const v69 = patternInput$00404617[5];

export const v68 = patternInput$00404617[4];

export const v67 = patternInput$00404617[3];

export const v66 = patternInput$00404617[2];

export const v65 = patternInput$00404617[1];

export const v64 = patternInput$00404617[0];

export const v72 = new Mut1(v64, v65, v66, v67, v68, v69, v70, v71);

export const v73 = v72;

export const v74 = method1();

export const v75 = v74(v73);

export const v76 = nonSeeded().Next0();

export const v77 = "db_listener";

export const v78 = (v: Mut2): any => closure2(v75, v);

export const v79 = [v77, v78];

export const v80 = "content";

export const v81 = (v: Mut2): any => closure4(void 0, v);

export const v82 = [v80, v81];

export const v83 = "store";

export const v84 = [v83, v75];

export const v85 = "run_id";

export const v86 = [v85, v76];

export const v87 = process.env;

export const v88 = "env";

export const v89 = [v88, v87];

export const v90 = [v79, v82, v84, v86, v89];

export const v91 = createObj(v90);

v1.l0 = v91;

window.components_spi = v91;


