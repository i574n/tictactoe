import { Union, Record } from "./fable_modules/fable-library.4.0.0-theta-003/Types.js";
import { tuple_type, lambda_type, array_type, unit_type, bool_type, class_type, string_type, union_type, int32_type, record_type, obj_type, TypeInfo } from "./fable_modules/fable-library.4.0.0-theta-003/Reflection.js";
import { int32 } from "./fable_modules/fable-library.4.0.0-theta-003/Int32.js";
import { createStoreon } from "storeon";
import { uncurry, equals, createObj, curry } from "./fable_modules/fable-library.4.0.0-theta-003/Util.js";
import { fill } from "./fable_modules/fable-library.4.0.0-theta-003/Array.js";
import { Tr, Td, Stack, IconButton, Checkbox, Box, Icon, Anchor, Table, Tbody, Button } from "@hope-ui/solid";
import { createEffect, on, createSignal, createComponent } from "solid-js";
import { BiRegularUndo, BiRegularRefresh, BiRegularUpArrow, BiRegularDownArrow, BiRegularLinkExternal } from "solid-icons/bi";
import { useStoreon } from "@storeon/solidjs";
import { nonSeeded } from "./fable_modules/fable-library.4.0.0-theta-003/Random.js";

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

export class US0 extends Union {
    tag: int32;
    fields: Array<any>;
    constructor(tag: int32, ...fields: Array<any>) {
        super();
        this.tag = (tag | 0);
        this.fields = fields;
    }
    cases() {
        return ["US0_0", "US0_1"];
    }
}

export function US0$reflection(): TypeInfo {
    return union_type("Components_spi.US0", [], US0, () => [[], [["f1_0", int32_type]]]);
}

export class Heap0 extends Record {
    l0: US0;
    constructor(l0: US0) {
        super();
        this.l0 = l0;
    }
}

export function Heap0$reflection(): TypeInfo {
    return record_type("Components_spi.Heap0", [], Heap0, () => [["l0", US0$reflection()]]);
}

export class US1 extends Union {
    tag: int32;
    fields: Array<any>;
    constructor(tag: int32, ...fields: Array<any>) {
        super();
        this.tag = (tag | 0);
        this.fields = fields;
    }
    cases() {
        return ["US1_0", "US1_1", "US1_2", "US1_3", "US1_4", "US1_5", "US1_6", "US1_7", "US1_8", "US1_9", "US1_10", "US1_11", "US1_12", "US1_13", "US1_14", "US1_15", "US1_16", "US1_17", "US1_18", "US1_19", "US1_20", "US1_21", "US1_22", "US1_23", "US1_24", "US1_25", "US1_26", "US1_27", "US1_28", "US1_29", "US1_30", "US1_31", "US1_32", "US1_33", "US1_34", "US1_35", "US1_36", "US1_37", "US1_38", "US1_39", "US1_40", "US1_41", "US1_42", "US1_43", "US1_44", "US1_45", "US1_46", "US1_47", "US1_48", "US1_49", "US1_50", "US1_51", "US1_52", "US1_53", "US1_54"];
    }
}

export function US1$reflection(): TypeInfo {
    return union_type("Components_spi.US1", [], US1, () => [[["f0_0", string_type]], [["f1_0", class_type("Fable.Core.JS.Function")]], [["f2_0", string_type]], [["f3_0", string_type]], [["f4_0", string_type]], [["f5_0", string_type]], [["f6_0", string_type]], [["f7_0", string_type]], [["f8_0", bool_type]], [["f9_0", lambda_type(unit_type, array_type(class_type("Fable.Core.JSX.Element")))]], [["f10_0", string_type]], [["f11_0", string_type]], [["f12_0", bool_type]], [["f13_0", string_type]], [["f14_0", string_type]], [["f15_0", bool_type]], [["f16_0", string_type]], [["f17_0", string_type]], [["f18_0", string_type]], [["f19_0", string_type]], [["f20_0", string_type]], [["f21_0", class_type("Fable.Core.JSX.Element")]], [["f22_0", string_type]], [["f23_0", string_type]], [["f24_0", string_type]], [["f25_0", obj_type]], [["f26_0", string_type]], [["f27_0", bool_type]], [["f28_0", string_type]], [["f29_0", string_type]], [["f30_0", string_type]], [["f31_0", string_type]], [["f32_0", bool_type]], [["f33_0", lambda_type(obj_type, unit_type)]], [["f34_0", lambda_type(unit_type, unit_type)]], [["f35_0", lambda_type(obj_type, lambda_type(lambda_type(obj_type, unit_type), unit_type))]], [["f36_0", string_type]], [["f37_0", string_type]], [["f38_0", string_type]], [["f39_0", string_type]], [["f40_0", string_type]], [["f41_0", string_type]], [["f42_0", string_type]], [["f43_0", string_type]], [["f44_0", string_type]], [["f45_0", string_type]], [["f46_0", string_type]], [["f47_0", string_type]], [["f48_0", bool_type]], [["f49_0", string_type]], [["f50_0", string_type]], [["f51_0", class_type("Fable.Core.JSX.Element")]], [["f52_0", string_type]], [["f53_0", string_type]], [["f54_0", int32_type]]]);
}

export class UH0 extends Union {
    tag: int32;
    fields: Array<any>;
    constructor(tag: int32, ...fields: Array<any>) {
        super();
        this.tag = (tag | 0);
        this.fields = fields;
    }
    cases() {
        return ["UH0_0", "UH0_1"];
    }
}

export function UH0$reflection(): TypeInfo {
    return union_type("Components_spi.UH0", [], UH0, () => [[["Item1", US1$reflection()], ["Item2", UH0$reflection()]], []]);
}

export class UH1 extends Union {
    tag: int32;
    fields: Array<any>;
    constructor(tag: int32, ...fields: Array<any>) {
        super();
        this.tag = (tag | 0);
        this.fields = fields;
    }
    cases() {
        return ["UH1_0", "UH1_1"];
    }
}

export function UH1$reflection(): TypeInfo {
    return union_type("Components_spi.UH1", [], UH1, () => [[["Item1", tuple_type(string_type, obj_type)], ["Item2", UH1$reflection()]], []]);
}

export class US2 extends Union {
    tag: int32;
    fields: Array<any>;
    constructor(tag: int32, ...fields: Array<any>) {
        super();
        this.tag = (tag | 0);
        this.fields = fields;
    }
    cases() {
        return ["US2_0", "US2_1"];
    }
}

export function US2$reflection(): TypeInfo {
    return union_type("Components_spi.US2", [], US2, () => [[], [["f1_0", string_type]]]);
}

export class US3 extends Union {
    tag: int32;
    fields: Array<any>;
    constructor(tag: int32, ...fields: Array<any>) {
        super();
        this.tag = (tag | 0);
        this.fields = fields;
    }
    cases() {
        return ["US3_0", "US3_1"];
    }
}

export function US3$reflection(): TypeInfo {
    return union_type("Components_spi.US3", [], US3, () => [[], [["f1_0", lambda_type(unit_type, array_type(class_type("Fable.Core.JSX.Element")))]]]);
}

export class Mut1 extends Record {
    l0: int32;
    l1: UH0;
    constructor(l0: int32, l1: UH0) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = l1;
    }
}

export function Mut1$reflection(): TypeInfo {
    return record_type("Components_spi.Mut1", [], Mut1, () => [["l0", int32_type], ["l1", UH0$reflection()]]);
}

export class US4 extends Union {
    tag: int32;
    fields: Array<any>;
    constructor(tag: int32, ...fields: Array<any>) {
        super();
        this.tag = (tag | 0);
        this.fields = fields;
    }
    cases() {
        return ["US4_0", "US4_1"];
    }
}

export function US4$reflection(): TypeInfo {
    return union_type("Components_spi.US4", [], US4, () => [[], [["f1_0", bool_type]]]);
}

export class US5 extends Union {
    tag: int32;
    fields: Array<any>;
    constructor(tag: int32, ...fields: Array<any>) {
        super();
        this.tag = (tag | 0);
        this.fields = fields;
    }
    cases() {
        return ["US5_0", "US5_1"];
    }
}

export function US5$reflection(): TypeInfo {
    return union_type("Components_spi.US5", [], US5, () => [[], [["f1_0", class_type("Fable.Core.JSX.Element")]]]);
}

export class US6 extends Union {
    tag: int32;
    fields: Array<any>;
    constructor(tag: int32, ...fields: Array<any>) {
        super();
        this.tag = (tag | 0);
        this.fields = fields;
    }
    cases() {
        return ["US6_0", "US6_1"];
    }
}

export function US6$reflection(): TypeInfo {
    return union_type("Components_spi.US6", [], US6, () => [[], [["f1_0", lambda_type(obj_type, lambda_type(lambda_type(obj_type, unit_type), unit_type))]]]);
}

export class US7 extends Union {
    tag: int32;
    fields: Array<any>;
    constructor(tag: int32, ...fields: Array<any>) {
        super();
        this.tag = (tag | 0);
        this.fields = fields;
    }
    cases() {
        return ["US7_0", "US7_1"];
    }
}

export function US7$reflection(): TypeInfo {
    return union_type("Components_spi.US7", [], US7, () => [[], [["f1_0", tuple_type(string_type, obj_type)]]]);
}

export class Mut2 extends Record {
    l0: int32;
    l1: int32;
    constructor(l0: int32, l1: int32) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = (l1 | 0);
    }
}

export function Mut2$reflection(): TypeInfo {
    return record_type("Components_spi.Mut2", [], Mut2, () => [["l0", int32_type], ["l1", int32_type]]);
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

export function method0(): US0 {
    return new US0(0);
}

export function closure0(v0_1: any, v1_1: any): void {
    const v2 = v1_1.on;
    v2("@init", ((): any => v0_1));
    v2("set", ((_, state) => state));
}

export function method1(v0_1: any): any {
    const v3 = createStoreon;
    const v4 = (v: any): void => {
        closure0(v0_1, v);
    };
    return v3([v4]);
}

export function method3(v0_1: UH0, v1_1: UH0): UH0 {
    if (v0_1.tag === 1) {
        return v1_1;
    }
    else {
        return new UH0(0, v0_1.fields[0], method3(v0_1.fields[1], v1_1));
    }
}

export function method4(v0_1: UH0, v1_1: UH1): UH1 {
    if (v0_1.tag === 1) {
        return v1_1;
    }
    else {
        const v2 = v0_1.fields[0];
        const v4 = method4(v0_1.fields[1], v1_1);
        return new UH1(0, (v2.tag === 1) ? ["as", v2.fields[0]] : ((v2.tag === 2) ? ["backgroundColor", v2.fields[0]] : ((v2.tag === 3) ? ["border", v2.fields[0]] : ((v2.tag === 4) ? ["borderBottomWidth", v2.fields[0]] : ((v2.tag === 5) ? ["borderColor", v2.fields[0]] : ((v2.tag === 6) ? ["borderWidth", v2.fields[0]] : ((v2.tag === 7) ? ["bottom", v2.fields[0]] : ((v2.tag === 8) ? ["checked", v2.fields[0]] : ((v2.tag === 9) ? ["children", v2.fields[0]] : ((v2.tag === 10) ? ["color", v2.fields[0]] : ((v2.tag === 11) ? ["colorScheme", v2.fields[0]] : ((v2.tag === 12) ? ["compact", v2.fields[0]] : ((v2.tag === 13) ? ["direction", v2.fields[0]] : ((v2.tag === 14) ? ["display", v2.fields[0]] : ((v2.tag === 15) ? ["external", v2.fields[0]] : ((v2.tag === 16) ? ["flex", v2.fields[0]] : ((v2.tag === 17) ? ["flexDirection", v2.fields[0]] : ((v2.tag === 18) ? ["fontSize", v2.fields[0]] : ((v2.tag === 19) ? ["height", v2.fields[0]] : ((v2.tag === 20) ? ["href", v2.fields[0]] : ((v2.tag === 21) ? ["icon", v2.fields[0]] : ((v2.tag === 22) ? ["id", v2.fields[0]] : ((v2.tag === 23) ? ["justifyContent", v2.fields[0]] : ((v2.tag === 24) ? ["left", v2.fields[0]] : ((v2.tag === 25) ? ["leftIcon", v2.fields[0]] : ((v2.tag === 26) ? ["lineHeight", v2.fields[0]] : ((v2.tag === 27) ? ["loaded__", v2.fields[0]] : ((v2.tag === 28) ? ["margin", v2.fields[0]] : ((v2.tag === 29) ? ["marginBottom", v2.fields[0]] : ((v2.tag === 30) ? ["marginTop", v2.fields[0]] : ((v2.tag === 31) ? ["maxHeight", v2.fields[0]] : ((v2.tag === 32) ? ["modal__", v2.fields[0]] : ((v2.tag === 33) ? ["onChange", v2.fields[0]] : ((v2.tag === 34) ? ["onClick", v2.fields[0]] : ((v2.tag === 35) ? ["onLoad__", curry(2, v2.fields[0])] : ((v2.tag === 36) ? ["outline", v2.fields[0]] : ((v2.tag === 37) ? ["overflowX", v2.fields[0]] : ((v2.tag === 38) ? ["overflowY", v2.fields[0]] : ((v2.tag === 39) ? ["padding", v2.fields[0]] : ((v2.tag === 40) ? ["paddingBottom", v2.fields[0]] : ((v2.tag === 41) ? ["paddingLeft", v2.fields[0]] : ((v2.tag === 42) ? ["paddingRight", v2.fields[0]] : ((v2.tag === 43) ? ["paddingTop", v2.fields[0]] : ((v2.tag === 44) ? ["position", v2.fields[0]] : ((v2.tag === 45) ? ["right", v2.fields[0]] : ((v2.tag === 46) ? ["size", v2.fields[0]] : ((v2.tag === 47) ? ["spacing", v2.fields[0]] : ((v2.tag === 48) ? ["status", v2.fields[0]] : ((v2.tag === 49) ? ["striped", v2.fields[0]] : ((v2.tag === 50) ? ["thickness", v2.fields[0]] : ((v2.tag === 51) ? ["title", v2.fields[0]] : ((v2.tag === 52) ? ["top", v2.fields[0]] : ((v2.tag === 53) ? ["width", v2.fields[0]] : ((v2.tag === 54) ? ["zIndex", v2.fields[0]] : ["aria-label", v2.fields[0]]))))))))))))))))))))))))))))))))))))))))))))))))))))), v4);
    }
}

export function method6(v0_1_mut: UH1, v1_1_mut: int32): int32 {
    method6:
    while (true) {
        const v0_1: UH1 = v0_1_mut, v1_1: int32 = v1_1_mut;
        if (v0_1.tag === 1) {
            return v1_1 | 0;
        }
        else {
            v0_1_mut = v0_1.fields[1];
            v1_1_mut = (v1_1 + 1);
            continue method6;
        }
        break;
    }
}

export function method7(v0_1_mut: Array<[string, any]>, v1_1_mut: UH1, v2_mut: int32): int32 {
    method7:
    while (true) {
        const v0_1: Array<[string, any]> = v0_1_mut, v1_1: UH1 = v1_1_mut, v2: int32 = v2_mut;
        if (v1_1.tag === 1) {
            return v2 | 0;
        }
        else {
            v0_1[v2] = v1_1.fields[0];
            v0_1_mut = v0_1;
            v1_1_mut = v1_1.fields[1];
            v2_mut = (v2 + 1);
            continue method7;
        }
        break;
    }
}

export function method5(v0_1: UH1): Array<[string, any]> {
    const v2 = method6(v0_1, 0) | 0;
    const v3 = fill(new Array(v2), 0, v2, null);
    const v5 = method7(v3, v0_1, 0) | 0;
    return v3;
}

export function method2(v0_1: UH0): any {
    const v17 = Button;
    const v22 = createObj(method5(method4(method3(v0_1, new UH0(0, new US1(46, "xs"), new UH0(0, new US1(23, "left"), new UH0(0, new US1(12, true), new UH0(0, new US1(11, "neutral"), new UH0(1)))))), new UH1(1))));
    const v25 = createComponent;
    return v25(v17, v22);
}

export function closure1(unitVar: void, v0_1: UH0): any {
    return method2(v0_1);
}

export function method9(v0_1: UH0, v1_1: US2): US2 {
    if (v0_1.tag === 1) {
        return v1_1;
    }
    else {
        const v2 = v0_1.fields[0];
        const v4 = method9(v0_1.fields[1], v1_1);
        if (v4.tag === 1) {
            return v4;
        }
        else {
            switch (v2.tag) {
                case 1: {
                    return v4;
                }
                case 2: {
                    return v4;
                }
                case 3: {
                    return v4;
                }
                case 4: {
                    return v4;
                }
                case 5: {
                    return v4;
                }
                case 6: {
                    return v4;
                }
                case 7: {
                    return v4;
                }
                case 8: {
                    return v4;
                }
                case 9: {
                    return v4;
                }
                case 10: {
                    return v4;
                }
                case 11: {
                    return v4;
                }
                case 12: {
                    return v4;
                }
                case 13: {
                    return v4;
                }
                case 14: {
                    return v4;
                }
                case 15: {
                    return v4;
                }
                case 16: {
                    return v4;
                }
                case 17: {
                    return v4;
                }
                case 18: {
                    return v4;
                }
                case 19: {
                    return v4;
                }
                case 20: {
                    return v4;
                }
                case 21: {
                    return v4;
                }
                case 22: {
                    return v4;
                }
                case 23: {
                    return v4;
                }
                case 24: {
                    return v4;
                }
                case 25: {
                    return v4;
                }
                case 26: {
                    return v4;
                }
                case 27: {
                    return v4;
                }
                case 28: {
                    return v4;
                }
                case 29: {
                    return v4;
                }
                case 30: {
                    return v4;
                }
                case 31: {
                    return v4;
                }
                case 32: {
                    return v4;
                }
                case 33: {
                    return v4;
                }
                case 34: {
                    return v4;
                }
                case 35: {
                    return v4;
                }
                case 36: {
                    return v4;
                }
                case 37: {
                    return v4;
                }
                case 38: {
                    return new US2(1, v2.fields[0]);
                }
                case 39: {
                    return v4;
                }
                case 40: {
                    return v4;
                }
                case 41: {
                    return v4;
                }
                case 42: {
                    return v4;
                }
                case 43: {
                    return v4;
                }
                case 44: {
                    return v4;
                }
                case 45: {
                    return v4;
                }
                case 46: {
                    return v4;
                }
                case 47: {
                    return v4;
                }
                case 48: {
                    return v4;
                }
                case 49: {
                    return v4;
                }
                case 50: {
                    return v4;
                }
                case 51: {
                    return v4;
                }
                case 52: {
                    return v4;
                }
                case 53: {
                    return v4;
                }
                case 54: {
                    return v4;
                }
                default: {
                    return v4;
                }
            }
        }
    }
}

export function method10(v0_1: UH0, v1_1: US3): US3 {
    if (v0_1.tag === 1) {
        return v1_1;
    }
    else {
        const v2 = v0_1.fields[0];
        const v4 = method10(v0_1.fields[1], v1_1);
        if (v4.tag === 1) {
            return v4;
        }
        else {
            switch (v2.tag) {
                case 1: {
                    return v4;
                }
                case 2: {
                    return v4;
                }
                case 3: {
                    return v4;
                }
                case 4: {
                    return v4;
                }
                case 5: {
                    return v4;
                }
                case 6: {
                    return v4;
                }
                case 7: {
                    return v4;
                }
                case 8: {
                    return v4;
                }
                case 9: {
                    return new US3(1, v2.fields[0]);
                }
                case 10: {
                    return v4;
                }
                case 11: {
                    return v4;
                }
                case 12: {
                    return v4;
                }
                case 13: {
                    return v4;
                }
                case 14: {
                    return v4;
                }
                case 15: {
                    return v4;
                }
                case 16: {
                    return v4;
                }
                case 17: {
                    return v4;
                }
                case 18: {
                    return v4;
                }
                case 19: {
                    return v4;
                }
                case 20: {
                    return v4;
                }
                case 21: {
                    return v4;
                }
                case 22: {
                    return v4;
                }
                case 23: {
                    return v4;
                }
                case 24: {
                    return v4;
                }
                case 25: {
                    return v4;
                }
                case 26: {
                    return v4;
                }
                case 27: {
                    return v4;
                }
                case 28: {
                    return v4;
                }
                case 29: {
                    return v4;
                }
                case 30: {
                    return v4;
                }
                case 31: {
                    return v4;
                }
                case 32: {
                    return v4;
                }
                case 33: {
                    return v4;
                }
                case 34: {
                    return v4;
                }
                case 35: {
                    return v4;
                }
                case 36: {
                    return v4;
                }
                case 37: {
                    return v4;
                }
                case 38: {
                    return v4;
                }
                case 39: {
                    return v4;
                }
                case 40: {
                    return v4;
                }
                case 41: {
                    return v4;
                }
                case 42: {
                    return v4;
                }
                case 43: {
                    return v4;
                }
                case 44: {
                    return v4;
                }
                case 45: {
                    return v4;
                }
                case 46: {
                    return v4;
                }
                case 47: {
                    return v4;
                }
                case 48: {
                    return v4;
                }
                case 49: {
                    return v4;
                }
                case 50: {
                    return v4;
                }
                case 51: {
                    return v4;
                }
                case 52: {
                    return v4;
                }
                case 53: {
                    return v4;
                }
                case 54: {
                    return v4;
                }
                default: {
                    return v4;
                }
            }
        }
    }
}

export function closure4(unitVar: void, unitVar_1: void): Array<any> {
    return [];
}

export function closure3(v0_1: UH0, unitVar: void): Array<any> {
    const v3 = method10(v0_1, new US3(0));
    const v9 = Tbody;
    const v37 = createObj(method5(new UH1(0, ["display", "flex"], new UH1(0, ["flexDirection", "column"], new UH1(0, ["backgroundColor", "$blackAlpha3"], new UH1(0, ["margin", "-1px"], new UH1(0, ["children", (v3.tag === 1) ? v3.fields[0] : ((): Array<any> => closure4(void 0, void 0))], new UH1(1))))))));
    const v40 = createComponent;
    return [v40(v9, v37)];
}

export function method8(v0_1: UH0): any {
    const v3 = method9(v0_1, new US2(0));
    const v9 = Table;
    const v10 = (): Array<any> => closure3(v0_1, void 0);
    const v27 = "flex";
    const v41 = createObj(method5(new UH1(0, ["display", v27], new UH1(0, [v27, "1"], new UH1(0, ["flexDirection", "column"], new UH1(0, ["overflowX", "hidden"], new UH1(0, ["overflowY", (v3.tag === 1) ? v3.fields[0] : "hidden"], new UH1(0, ["children", v10], new UH1(1)))))))));
    const v44 = createComponent;
    return v44(v9, v41);
}

export function closure2(unitVar: void, v0_1: UH0): any {
    return method8(v0_1);
}

export function method12(v0_1: int32, v1_1: Mut1): boolean {
    return v1_1.l0 < v0_1;
}

export function method11(v0_1: Array<[string, any]>): UH0 {
    const v1_1 = v0_1.length | 0;
    const v3 = new Mut1(0, new UH0(1));
    while (method12(v1_1, v3)) {
        const v5 = v3.l0 | 0;
        const v6 = v3.l1;
        const patternInput = v0_1[v5];
        const v8 = patternInput[1];
        const v7 = patternInput[0];
        let v287;
        if (equals(v8, void 0)) {
            v287 = v6;
        }
        else if ("loaded__" === v7) {
            v287 = (new UH0(0, new US1(27, v8), v6));
        }
        else if ("modal__" === v7) {
            v287 = (new UH0(0, new US1(32, v8), v6));
        }
        else if ("onLoad__" === v7) {
            v287 = (new UH0(0, new US1(35, uncurry(2, v8)), v6));
        }
        else if ("aria-label" === v7) {
            v287 = (new UH0(0, new US1(0, v8), v6));
        }
        else if ("as" === v7) {
            v287 = (new UH0(0, new US1(1, v8), v6));
        }
        else if ("backgroundColor" === v7) {
            v287 = (new UH0(0, new US1(2, v8), v6));
        }
        else if ("border" === v7) {
            v287 = (new UH0(0, new US1(3, v8), v6));
        }
        else if ("borderWidth" === v7) {
            v287 = (new UH0(0, new US1(6, v8), v6));
        }
        else if ("borderBottomWidth" === v7) {
            v287 = (new UH0(0, new US1(4, v8), v6));
        }
        else if ("borderColor" === v7) {
            v287 = (new UH0(0, new US1(5, v8), v6));
        }
        else if ("bottom" === v7) {
            v287 = (new UH0(0, new US1(7, v8), v6));
        }
        else if ("color" === v7) {
            v287 = (new UH0(0, new US1(10, v8), v6));
        }
        else if ("checked" === v7) {
            v287 = (new UH0(0, new US1(8, v8), v6));
        }
        else if ("children" === v7) {
            v287 = (new UH0(0, new US1(9, v8), v6));
        }
        else if ("colorScheme" === v7) {
            v287 = (new UH0(0, new US1(11, v8), v6));
        }
        else if ("compact" === v7) {
            v287 = (new UH0(0, new US1(12, v8), v6));
        }
        else if ("direction" === v7) {
            v287 = (new UH0(0, new US1(13, v8), v6));
        }
        else if ("display" === v7) {
            v287 = (new UH0(0, new US1(14, v8), v6));
        }
        else if ("external" === v7) {
            v287 = (new UH0(0, new US1(15, v8), v6));
        }
        else if ("flex" === v7) {
            v287 = (new UH0(0, new US1(16, v8), v6));
        }
        else if ("flexDirection" === v7) {
            v287 = (new UH0(0, new US1(17, v8), v6));
        }
        else if ("fontSize" === v7) {
            v287 = (new UH0(0, new US1(18, v8), v6));
        }
        else if ("height" === v7) {
            v287 = (new UH0(0, new US1(19, v8), v6));
        }
        else if ("href" === v7) {
            v287 = (new UH0(0, new US1(20, v8), v6));
        }
        else if ("icon" === v7) {
            v287 = (new UH0(0, new US1(21, v8), v6));
        }
        else if ("id" === v7) {
            v287 = (new UH0(0, new US1(22, v8), v6));
        }
        else if ("justifyContent" === v7) {
            v287 = (new UH0(0, new US1(23, v8), v6));
        }
        else if ("left" === v7) {
            v287 = (new UH0(0, new US1(24, v8), v6));
        }
        else if ("leftIcon" === v7) {
            v287 = (new UH0(0, new US1(25, v8), v6));
        }
        else if ("lineHeight" === v7) {
            v287 = (new UH0(0, new US1(26, v8), v6));
        }
        else if ("margin" === v7) {
            v287 = (new UH0(0, new US1(28, v8), v6));
        }
        else if ("marginBottom" === v7) {
            v287 = (new UH0(0, new US1(29, v8), v6));
        }
        else if ("marginTop" === v7) {
            v287 = (new UH0(0, new US1(30, v8), v6));
        }
        else if ("maxHeight" === v7) {
            v287 = (new UH0(0, new US1(31, v8), v6));
        }
        else if ("onChange" === v7) {
            v287 = (new UH0(0, new US1(33, v8), v6));
        }
        else if ("onClick" === v7) {
            v287 = (new UH0(0, new US1(34, v8), v6));
        }
        else if ("outline" === v7) {
            v287 = (new UH0(0, new US1(36, v8), v6));
        }
        else if ("overflowX" === v7) {
            v287 = (new UH0(0, new US1(37, v8), v6));
        }
        else if ("overflowY" === v7) {
            v287 = (new UH0(0, new US1(38, v8), v6));
        }
        else if ("padding" === v7) {
            v287 = (new UH0(0, new US1(39, v8), v6));
        }
        else if ("paddingTop" === v7) {
            v287 = (new UH0(0, new US1(43, v8), v6));
        }
        else if ("paddingRight" === v7) {
            v287 = (new UH0(0, new US1(42, v8), v6));
        }
        else if ("paddingBottom" === v7) {
            v287 = (new UH0(0, new US1(40, v8), v6));
        }
        else if ("paddingLeft" === v7) {
            v287 = (new UH0(0, new US1(41, v8), v6));
        }
        else if ("position" === v7) {
            v287 = (new UH0(0, new US1(44, v8), v6));
        }
        else if ("right" === v7) {
            v287 = (new UH0(0, new US1(45, v8), v6));
        }
        else if ("size" === v7) {
            v287 = (new UH0(0, new US1(46, v8), v6));
        }
        else if ("spacing" === v7) {
            v287 = (new UH0(0, new US1(47, v8), v6));
        }
        else if ("status" === v7) {
            v287 = (new UH0(0, new US1(48, v8), v6));
        }
        else if ("striped" === v7) {
            v287 = (new UH0(0, new US1(49, v8), v6));
        }
        else if ("thickness" === v7) {
            v287 = (new UH0(0, new US1(50, v8), v6));
        }
        else if ("title" === v7) {
            v287 = (new UH0(0, new US1(51, v8), v6));
        }
        else if ("top" === v7) {
            v287 = (new UH0(0, new US1(52, v8), v6));
        }
        else if ("width" === v7) {
            v287 = (new UH0(0, new US1(53, v8), v6));
        }
        else if ("zIndex" === v7) {
            v287 = (new UH0(0, new US1(54, v8), v6));
        }
        else {
            throw new Error(`unknown prop: ${v7} = ${v8}`);
        }
        const v288 = (v5 + 1) | 0;
        v3.l0 = (v288 | 0);
        v3.l1 = v287;
    }
    return v3.l1;
}

export function closure5(unitVar: void, v0_1: Array<[string, any]>): UH0 {
    return method11(v0_1);
}

export function closure6(unitVar: void, v0_1: any): any {
    return method1(v0_1);
}

export function method14(v0_1: UH0, v1_1: US2): US2 {
    if (v0_1.tag === 1) {
        return v1_1;
    }
    else {
        const v2 = v0_1.fields[0];
        const v4 = method14(v0_1.fields[1], v1_1);
        if (v4.tag === 1) {
            return v4;
        }
        else {
            switch (v2.tag) {
                case 1: {
                    return v4;
                }
                case 2: {
                    return v4;
                }
                case 3: {
                    return v4;
                }
                case 4: {
                    return v4;
                }
                case 5: {
                    return v4;
                }
                case 6: {
                    return v4;
                }
                case 7: {
                    return v4;
                }
                case 8: {
                    return v4;
                }
                case 9: {
                    return v4;
                }
                case 10: {
                    return v4;
                }
                case 11: {
                    return v4;
                }
                case 12: {
                    return v4;
                }
                case 13: {
                    return v4;
                }
                case 14: {
                    return v4;
                }
                case 15: {
                    return v4;
                }
                case 16: {
                    return v4;
                }
                case 17: {
                    return v4;
                }
                case 18: {
                    return v4;
                }
                case 19: {
                    return v4;
                }
                case 20: {
                    return new US2(1, v2.fields[0]);
                }
                case 21: {
                    return v4;
                }
                case 22: {
                    return v4;
                }
                case 23: {
                    return v4;
                }
                case 24: {
                    return v4;
                }
                case 25: {
                    return v4;
                }
                case 26: {
                    return v4;
                }
                case 27: {
                    return v4;
                }
                case 28: {
                    return v4;
                }
                case 29: {
                    return v4;
                }
                case 30: {
                    return v4;
                }
                case 31: {
                    return v4;
                }
                case 32: {
                    return v4;
                }
                case 33: {
                    return v4;
                }
                case 34: {
                    return v4;
                }
                case 35: {
                    return v4;
                }
                case 36: {
                    return v4;
                }
                case 37: {
                    return v4;
                }
                case 38: {
                    return v4;
                }
                case 39: {
                    return v4;
                }
                case 40: {
                    return v4;
                }
                case 41: {
                    return v4;
                }
                case 42: {
                    return v4;
                }
                case 43: {
                    return v4;
                }
                case 44: {
                    return v4;
                }
                case 45: {
                    return v4;
                }
                case 46: {
                    return v4;
                }
                case 47: {
                    return v4;
                }
                case 48: {
                    return v4;
                }
                case 49: {
                    return v4;
                }
                case 50: {
                    return v4;
                }
                case 51: {
                    return v4;
                }
                case 52: {
                    return v4;
                }
                case 53: {
                    return v4;
                }
                case 54: {
                    return v4;
                }
                default: {
                    return v4;
                }
            }
        }
    }
}

export function closure9(v0_1: UH0, unitVar: void): Array<any> {
    const v3 = method14(v0_1, new US2(0));
    return [<>
        {(v3.tag === 1) ? v3.fields[0] : ""}
    </>];
}

export function closure8(v0_1: UH0, unitVar: void): Array<any> {
    const v3 = (): Array<any> => closure9(v0_1, void 0);
    const v11 = Anchor;
    const v16 = createObj(method5(method4(method3(v0_1, new UH0(0, new US1(15, true), new UH0(0, new US1(9, v3), new UH0(1)))), new UH1(1))));
    const v19 = createComponent;
    const v20 = v19(v11, v16);
    const v22 = <>
        &nbsp;
    </>;
    const v25 = BiRegularLinkExternal;
    const v27 = Icon;
    const v35 = createObj(method5(new UH1(0, ["as", v25], new UH1(1))));
    const v36 = createComponent;
    return [v20, v22, v36(v27, v35)];
}

export function method13(v0_1: UH0): any {
    const v3 = Box;
    const v4 = (): Array<any> => closure8(v0_1, void 0);
    const v12 = createObj(method5(new UH1(0, ["children", v4], new UH1(1))));
    const v15 = createComponent;
    return v15(v3, v12);
}

export function closure7(unitVar: void, v0_1: UH0): any {
    return method13(v0_1);
}

export function method17(v0_1: UH0, v1_1: US4): US4 {
    if (v0_1.tag === 1) {
        return v1_1;
    }
    else {
        const v2 = v0_1.fields[0];
        const v4 = method17(v0_1.fields[1], v1_1);
        if (v4.tag === 1) {
            return v4;
        }
        else {
            switch (v2.tag) {
                case 1: {
                    return v4;
                }
                case 2: {
                    return v4;
                }
                case 3: {
                    return v4;
                }
                case 4: {
                    return v4;
                }
                case 5: {
                    return v4;
                }
                case 6: {
                    return v4;
                }
                case 7: {
                    return v4;
                }
                case 8: {
                    return v4;
                }
                case 9: {
                    return v4;
                }
                case 10: {
                    return v4;
                }
                case 11: {
                    return v4;
                }
                case 12: {
                    return v4;
                }
                case 13: {
                    return v4;
                }
                case 14: {
                    return v4;
                }
                case 15: {
                    return v4;
                }
                case 16: {
                    return v4;
                }
                case 17: {
                    return v4;
                }
                case 18: {
                    return v4;
                }
                case 19: {
                    return v4;
                }
                case 20: {
                    return v4;
                }
                case 21: {
                    return v4;
                }
                case 22: {
                    return v4;
                }
                case 23: {
                    return v4;
                }
                case 24: {
                    return v4;
                }
                case 25: {
                    return v4;
                }
                case 26: {
                    return v4;
                }
                case 27: {
                    return v4;
                }
                case 28: {
                    return v4;
                }
                case 29: {
                    return v4;
                }
                case 30: {
                    return v4;
                }
                case 31: {
                    return v4;
                }
                case 32: {
                    return v4;
                }
                case 33: {
                    return v4;
                }
                case 34: {
                    return v4;
                }
                case 35: {
                    return v4;
                }
                case 36: {
                    return v4;
                }
                case 37: {
                    return v4;
                }
                case 38: {
                    return v4;
                }
                case 39: {
                    return v4;
                }
                case 40: {
                    return v4;
                }
                case 41: {
                    return v4;
                }
                case 42: {
                    return v4;
                }
                case 43: {
                    return v4;
                }
                case 44: {
                    return v4;
                }
                case 45: {
                    return v4;
                }
                case 46: {
                    return v4;
                }
                case 47: {
                    return v4;
                }
                case 48: {
                    return new US4(1, v2.fields[0]);
                }
                case 49: {
                    return v4;
                }
                case 50: {
                    return v4;
                }
                case 51: {
                    return v4;
                }
                case 52: {
                    return v4;
                }
                case 53: {
                    return v4;
                }
                case 54: {
                    return v4;
                }
                default: {
                    return v4;
                }
            }
        }
    }
}

export function method18(v0_1: UH0, v1_1: US2): US2 {
    if (v0_1.tag === 1) {
        return v1_1;
    }
    else {
        const v2 = v0_1.fields[0];
        const v4 = method18(v0_1.fields[1], v1_1);
        if (v4.tag === 1) {
            return v4;
        }
        else {
            switch (v2.tag) {
                case 1: {
                    return v4;
                }
                case 2: {
                    return v4;
                }
                case 3: {
                    return v4;
                }
                case 4: {
                    return v4;
                }
                case 5: {
                    return v4;
                }
                case 6: {
                    return v4;
                }
                case 7: {
                    return v4;
                }
                case 8: {
                    return v4;
                }
                case 9: {
                    return v4;
                }
                case 10: {
                    return v4;
                }
                case 11: {
                    return v4;
                }
                case 12: {
                    return v4;
                }
                case 13: {
                    return v4;
                }
                case 14: {
                    return v4;
                }
                case 15: {
                    return v4;
                }
                case 16: {
                    return v4;
                }
                case 17: {
                    return v4;
                }
                case 18: {
                    return v4;
                }
                case 19: {
                    return v4;
                }
                case 20: {
                    return v4;
                }
                case 21: {
                    return v4;
                }
                case 22: {
                    return new US2(1, v2.fields[0]);
                }
                case 23: {
                    return v4;
                }
                case 24: {
                    return v4;
                }
                case 25: {
                    return v4;
                }
                case 26: {
                    return v4;
                }
                case 27: {
                    return v4;
                }
                case 28: {
                    return v4;
                }
                case 29: {
                    return v4;
                }
                case 30: {
                    return v4;
                }
                case 31: {
                    return v4;
                }
                case 32: {
                    return v4;
                }
                case 33: {
                    return v4;
                }
                case 34: {
                    return v4;
                }
                case 35: {
                    return v4;
                }
                case 36: {
                    return v4;
                }
                case 37: {
                    return v4;
                }
                case 38: {
                    return v4;
                }
                case 39: {
                    return v4;
                }
                case 40: {
                    return v4;
                }
                case 41: {
                    return v4;
                }
                case 42: {
                    return v4;
                }
                case 43: {
                    return v4;
                }
                case 44: {
                    return v4;
                }
                case 45: {
                    return v4;
                }
                case 46: {
                    return v4;
                }
                case 47: {
                    return v4;
                }
                case 48: {
                    return v4;
                }
                case 49: {
                    return v4;
                }
                case 50: {
                    return v4;
                }
                case 51: {
                    return v4;
                }
                case 52: {
                    return v4;
                }
                case 53: {
                    return v4;
                }
                case 54: {
                    return v4;
                }
                default: {
                    return v4;
                }
            }
        }
    }
}

export function method19(v0_1: UH0, v1_1: US5): US5 {
    if (v0_1.tag === 1) {
        return v1_1;
    }
    else {
        const v2 = v0_1.fields[0];
        const v4 = method19(v0_1.fields[1], v1_1);
        if (v4.tag === 1) {
            return v4;
        }
        else {
            switch (v2.tag) {
                case 1: {
                    return v4;
                }
                case 2: {
                    return v4;
                }
                case 3: {
                    return v4;
                }
                case 4: {
                    return v4;
                }
                case 5: {
                    return v4;
                }
                case 6: {
                    return v4;
                }
                case 7: {
                    return v4;
                }
                case 8: {
                    return v4;
                }
                case 9: {
                    return v4;
                }
                case 10: {
                    return v4;
                }
                case 11: {
                    return v4;
                }
                case 12: {
                    return v4;
                }
                case 13: {
                    return v4;
                }
                case 14: {
                    return v4;
                }
                case 15: {
                    return v4;
                }
                case 16: {
                    return v4;
                }
                case 17: {
                    return v4;
                }
                case 18: {
                    return v4;
                }
                case 19: {
                    return v4;
                }
                case 20: {
                    return v4;
                }
                case 21: {
                    return v4;
                }
                case 22: {
                    return v4;
                }
                case 23: {
                    return v4;
                }
                case 24: {
                    return v4;
                }
                case 25: {
                    return v4;
                }
                case 26: {
                    return v4;
                }
                case 27: {
                    return v4;
                }
                case 28: {
                    return v4;
                }
                case 29: {
                    return v4;
                }
                case 30: {
                    return v4;
                }
                case 31: {
                    return v4;
                }
                case 32: {
                    return v4;
                }
                case 33: {
                    return v4;
                }
                case 34: {
                    return v4;
                }
                case 35: {
                    return v4;
                }
                case 36: {
                    return v4;
                }
                case 37: {
                    return v4;
                }
                case 38: {
                    return v4;
                }
                case 39: {
                    return v4;
                }
                case 40: {
                    return v4;
                }
                case 41: {
                    return v4;
                }
                case 42: {
                    return v4;
                }
                case 43: {
                    return v4;
                }
                case 44: {
                    return v4;
                }
                case 45: {
                    return v4;
                }
                case 46: {
                    return v4;
                }
                case 47: {
                    return v4;
                }
                case 48: {
                    return v4;
                }
                case 49: {
                    return v4;
                }
                case 50: {
                    return v4;
                }
                case 51: {
                    return new US5(1, v2.fields[0]);
                }
                case 52: {
                    return v4;
                }
                case 53: {
                    return v4;
                }
                case 54: {
                    return v4;
                }
                default: {
                    return v4;
                }
            }
        }
    }
}

export function closure16(v0_1: any, unitVar: void): Array<any> {
    return [v0_1];
}

export function closure15(v0_1: any, unitVar: void): Array<any> {
    const v3 = Box;
    const v4 = (): Array<any> => closure16(v0_1, void 0);
    const v17 = createObj(method5(new UH1(0, ["paddingTop", "2px"], new UH1(0, ["children", v4], new UH1(1)))));
    const v20 = createComponent;
    return [v20(v3, v17)];
}

export function closure17(v0_1: (arg0: boolean) => void, v1_1: any): void {
    v0_1(v1_1.target.checked);
}

export function closure14(v0_1: UH0, v1_1: (arg0: boolean) => void, v2: (arg0: void) => boolean, v3: any, unitVar: void): Array<any> {
    let v11: any, v12: (arg0: void) => Array<any>, v16: (arg0: any) => void, v44: UH0, v47: any;
    const v6 = method17(v0_1, new US4(0));
    return [(v6.tag === 1) ? ((v11 = Checkbox, (v12 = ((): Array<any> => closure15(v3, void 0)), (v16 = ((v: any): void => {
        closure17(v1_1, v);
    }), (v44 = createObj(method5(new UH1(0, ["size", "sm"], new UH1(0, ["marginBottom", "2px"], new UH1(0, ["checked", v2()], new UH1(0, ["colorScheme", "neutral"], new UH1(0, ["onChange", v16], new UH1(0, ["children", v12], new UH1(1))))))))), (v47 = createComponent, v47(v11, v44))))))) : v3];
}

export function closure18(unitVar: void, unitVar_1: void): Array<any> {
    return [<>
        &nbsp;
    </>];
}

export function method20(v0_1: UH0, v1_1: US2): US2 {
    if (v0_1.tag === 1) {
        return v1_1;
    }
    else {
        const v2 = v0_1.fields[0];
        const v4 = method20(v0_1.fields[1], v1_1);
        if (v4.tag === 1) {
            return v4;
        }
        else {
            switch (v2.tag) {
                case 1: {
                    return v4;
                }
                case 2: {
                    return v4;
                }
                case 3: {
                    return v4;
                }
                case 4: {
                    return v4;
                }
                case 5: {
                    return v4;
                }
                case 6: {
                    return v4;
                }
                case 7: {
                    return v4;
                }
                case 8: {
                    return v4;
                }
                case 9: {
                    return v4;
                }
                case 10: {
                    return v4;
                }
                case 11: {
                    return v4;
                }
                case 12: {
                    return v4;
                }
                case 13: {
                    return v4;
                }
                case 14: {
                    return v4;
                }
                case 15: {
                    return v4;
                }
                case 16: {
                    return v4;
                }
                case 17: {
                    return v4;
                }
                case 18: {
                    return v4;
                }
                case 19: {
                    return v4;
                }
                case 20: {
                    return v4;
                }
                case 21: {
                    return v4;
                }
                case 22: {
                    return v4;
                }
                case 23: {
                    return v4;
                }
                case 24: {
                    return v4;
                }
                case 25: {
                    return v4;
                }
                case 26: {
                    return v4;
                }
                case 27: {
                    return v4;
                }
                case 28: {
                    return v4;
                }
                case 29: {
                    return v4;
                }
                case 30: {
                    return v4;
                }
                case 31: {
                    return v4;
                }
                case 32: {
                    return v4;
                }
                case 33: {
                    return v4;
                }
                case 34: {
                    return v4;
                }
                case 35: {
                    return v4;
                }
                case 36: {
                    return v4;
                }
                case 37: {
                    return v4;
                }
                case 38: {
                    return v4;
                }
                case 39: {
                    return new US2(1, v2.fields[0]);
                }
                case 40: {
                    return v4;
                }
                case 41: {
                    return v4;
                }
                case 42: {
                    return v4;
                }
                case 43: {
                    return v4;
                }
                case 44: {
                    return v4;
                }
                case 45: {
                    return v4;
                }
                case 46: {
                    return v4;
                }
                case 47: {
                    return v4;
                }
                case 48: {
                    return v4;
                }
                case 49: {
                    return v4;
                }
                case 50: {
                    return v4;
                }
                case 51: {
                    return v4;
                }
                case 52: {
                    return v4;
                }
                case 53: {
                    return v4;
                }
                case 54: {
                    return v4;
                }
                default: {
                    return v4;
                }
            }
        }
    }
}

export function method21(v0_1: UH0, v1_1: US6): US6 {
    if (v0_1.tag === 1) {
        return v1_1;
    }
    else {
        const v2 = v0_1.fields[0];
        const v4 = method21(v0_1.fields[1], v1_1);
        if (v4.tag === 1) {
            return v4;
        }
        else {
            switch (v2.tag) {
                case 1: {
                    return v4;
                }
                case 2: {
                    return v4;
                }
                case 3: {
                    return v4;
                }
                case 4: {
                    return v4;
                }
                case 5: {
                    return v4;
                }
                case 6: {
                    return v4;
                }
                case 7: {
                    return v4;
                }
                case 8: {
                    return v4;
                }
                case 9: {
                    return v4;
                }
                case 10: {
                    return v4;
                }
                case 11: {
                    return v4;
                }
                case 12: {
                    return v4;
                }
                case 13: {
                    return v4;
                }
                case 14: {
                    return v4;
                }
                case 15: {
                    return v4;
                }
                case 16: {
                    return v4;
                }
                case 17: {
                    return v4;
                }
                case 18: {
                    return v4;
                }
                case 19: {
                    return v4;
                }
                case 20: {
                    return v4;
                }
                case 21: {
                    return v4;
                }
                case 22: {
                    return v4;
                }
                case 23: {
                    return v4;
                }
                case 24: {
                    return v4;
                }
                case 25: {
                    return v4;
                }
                case 26: {
                    return v4;
                }
                case 27: {
                    return v4;
                }
                case 28: {
                    return v4;
                }
                case 29: {
                    return v4;
                }
                case 30: {
                    return v4;
                }
                case 31: {
                    return v4;
                }
                case 32: {
                    return v4;
                }
                case 33: {
                    return v4;
                }
                case 34: {
                    return v4;
                }
                case 35: {
                    return new US6(1, v2.fields[0]);
                }
                case 36: {
                    return v4;
                }
                case 37: {
                    return v4;
                }
                case 38: {
                    return v4;
                }
                case 39: {
                    return v4;
                }
                case 40: {
                    return v4;
                }
                case 41: {
                    return v4;
                }
                case 42: {
                    return v4;
                }
                case 43: {
                    return v4;
                }
                case 44: {
                    return v4;
                }
                case 45: {
                    return v4;
                }
                case 46: {
                    return v4;
                }
                case 47: {
                    return v4;
                }
                case 48: {
                    return v4;
                }
                case 49: {
                    return v4;
                }
                case 50: {
                    return v4;
                }
                case 51: {
                    return v4;
                }
                case 52: {
                    return v4;
                }
                case 53: {
                    return v4;
                }
                case 54: {
                    return v4;
                }
                default: {
                    return v4;
                }
            }
        }
    }
}

export function method23(v0_1: UH0, v1_1: US4): US4 {
    if (v0_1.tag === 1) {
        return v1_1;
    }
    else {
        const v2 = v0_1.fields[0];
        const v4 = method23(v0_1.fields[1], v1_1);
        if (v4.tag === 1) {
            return v4;
        }
        else {
            switch (v2.tag) {
                case 1: {
                    return v4;
                }
                case 2: {
                    return v4;
                }
                case 3: {
                    return v4;
                }
                case 4: {
                    return v4;
                }
                case 5: {
                    return v4;
                }
                case 6: {
                    return v4;
                }
                case 7: {
                    return v4;
                }
                case 8: {
                    return v4;
                }
                case 9: {
                    return v4;
                }
                case 10: {
                    return v4;
                }
                case 11: {
                    return v4;
                }
                case 12: {
                    return v4;
                }
                case 13: {
                    return v4;
                }
                case 14: {
                    return v4;
                }
                case 15: {
                    return v4;
                }
                case 16: {
                    return v4;
                }
                case 17: {
                    return v4;
                }
                case 18: {
                    return v4;
                }
                case 19: {
                    return v4;
                }
                case 20: {
                    return v4;
                }
                case 21: {
                    return v4;
                }
                case 22: {
                    return v4;
                }
                case 23: {
                    return v4;
                }
                case 24: {
                    return v4;
                }
                case 25: {
                    return v4;
                }
                case 26: {
                    return v4;
                }
                case 27: {
                    return new US4(1, v2.fields[0]);
                }
                case 28: {
                    return v4;
                }
                case 29: {
                    return v4;
                }
                case 30: {
                    return v4;
                }
                case 31: {
                    return v4;
                }
                case 32: {
                    return v4;
                }
                case 33: {
                    return v4;
                }
                case 34: {
                    return v4;
                }
                case 35: {
                    return v4;
                }
                case 36: {
                    return v4;
                }
                case 37: {
                    return v4;
                }
                case 38: {
                    return v4;
                }
                case 39: {
                    return v4;
                }
                case 40: {
                    return v4;
                }
                case 41: {
                    return v4;
                }
                case 42: {
                    return v4;
                }
                case 43: {
                    return v4;
                }
                case 44: {
                    return v4;
                }
                case 45: {
                    return v4;
                }
                case 46: {
                    return v4;
                }
                case 47: {
                    return v4;
                }
                case 48: {
                    return v4;
                }
                case 49: {
                    return v4;
                }
                case 50: {
                    return v4;
                }
                case 51: {
                    return v4;
                }
                case 52: {
                    return v4;
                }
                case 53: {
                    return v4;
                }
                case 54: {
                    return v4;
                }
                default: {
                    return v4;
                }
            }
        }
    }
}

export function method24(v0_1: UH0, v1_1: US4): US4 {
    if (v0_1.tag === 1) {
        return v1_1;
    }
    else {
        const v2 = v0_1.fields[0];
        const v4 = method24(v0_1.fields[1], v1_1);
        if (v4.tag === 1) {
            return v4;
        }
        else {
            switch (v2.tag) {
                case 1: {
                    return v4;
                }
                case 2: {
                    return v4;
                }
                case 3: {
                    return v4;
                }
                case 4: {
                    return v4;
                }
                case 5: {
                    return v4;
                }
                case 6: {
                    return v4;
                }
                case 7: {
                    return v4;
                }
                case 8: {
                    return v4;
                }
                case 9: {
                    return v4;
                }
                case 10: {
                    return v4;
                }
                case 11: {
                    return v4;
                }
                case 12: {
                    return v4;
                }
                case 13: {
                    return v4;
                }
                case 14: {
                    return v4;
                }
                case 15: {
                    return v4;
                }
                case 16: {
                    return v4;
                }
                case 17: {
                    return v4;
                }
                case 18: {
                    return v4;
                }
                case 19: {
                    return v4;
                }
                case 20: {
                    return v4;
                }
                case 21: {
                    return v4;
                }
                case 22: {
                    return v4;
                }
                case 23: {
                    return v4;
                }
                case 24: {
                    return v4;
                }
                case 25: {
                    return v4;
                }
                case 26: {
                    return v4;
                }
                case 27: {
                    return v4;
                }
                case 28: {
                    return v4;
                }
                case 29: {
                    return v4;
                }
                case 30: {
                    return v4;
                }
                case 31: {
                    return v4;
                }
                case 32: {
                    return new US4(1, v2.fields[0]);
                }
                case 33: {
                    return v4;
                }
                case 34: {
                    return v4;
                }
                case 35: {
                    return v4;
                }
                case 36: {
                    return v4;
                }
                case 37: {
                    return v4;
                }
                case 38: {
                    return v4;
                }
                case 39: {
                    return v4;
                }
                case 40: {
                    return v4;
                }
                case 41: {
                    return v4;
                }
                case 42: {
                    return v4;
                }
                case 43: {
                    return v4;
                }
                case 44: {
                    return v4;
                }
                case 45: {
                    return v4;
                }
                case 46: {
                    return v4;
                }
                case 47: {
                    return v4;
                }
                case 48: {
                    return v4;
                }
                case 49: {
                    return v4;
                }
                case 50: {
                    return v4;
                }
                case 51: {
                    return v4;
                }
                case 52: {
                    return v4;
                }
                case 53: {
                    return v4;
                }
                case 54: {
                    return v4;
                }
                default: {
                    return v4;
                }
            }
        }
    }
}

export function closure21(v0_1: (arg0: void) => boolean, unitVar: void): Array<boolean> {
    return [v0_1()];
}

export function closure22(v0_1: (arg0: boolean) => void, v1_1: (arg0: void) => boolean, unitVar: void): void {
    if (v1_1()) {
        v0_1(false);
    }
}

export function closure23(v0_1: any, v1_1: any): void {
    v0_1("set", v1_1);
}

export function closure26(v0_1: (arg0: boolean) => void, v1_1: UH0, v2: any, v3: any, unitVar: void): void {
    const v6 = method21(v1_1, new US6(0));
    if (v6.tag === 1) {
        const v9 = (v: any): void => {
            closure23(v2, v);
        };
        v6.fields[0](v3, v9);
    }
    v0_1(true);
}

export function closure27(unitVar: void, unitVar_1: void): Array<any> {
    return [<>
        Load
    </>];
}

export function closure25(v0_1: (arg0: boolean) => void, v1_1: UH0, v2: any, v3: any, unitVar: void): Array<any> {
    const v6 = createComponent;
    const v7 = (v: UH0): any => closure1(void 0, v);
    const v8 = (): void => {
        closure26(v0_1, v1_1, v2, v3, void 0);
    };
    const v10 = (): Array<any> => closure27(void 0, void 0);
    return [v6(v7, (new UH0(0, new US1(34, v8), new UH0(0, new US1(9, v10), new UH0(1)))))];
}

export function closure31(v0_1: (arg0: boolean) => void, unitVar: void): void {
    v0_1(true);
}

export function closure32(unitVar: void, v0_1: UH0): any {
    const v3 = BiRegularDownArrow;
    const v8 = createObj(method5(method4(v0_1, new UH1(1))));
    const v11 = createComponent;
    return v11(v3, v8);
}

export function closure33(unitVar: void, v0_1: UH0): any {
    const v3 = BiRegularUpArrow;
    const v8 = createObj(method5(method4(v0_1, new UH1(1))));
    const v11 = createComponent;
    return v11(v3, v8);
}

export function method26(v0_1: string, v1_1: US0): US7 {
    if (v1_1.tag === 1) {
        return new US7(1, [v0_1, v1_1.fields[0]]);
    }
    else {
        return new US7(0);
    }
}

export function method27(v0_1: int32, v1_1: Mut2): boolean {
    return v1_1.l0 < v0_1;
}

export function method28(v0_1: int32, v1_1: Mut3): boolean {
    return v1_1.l0 < v0_1;
}

export function method25(v0_1: US0): Array<[string, any]> {
    const v3 = [method26("ui_modal", v0_1)];
    const v4 = v3.length | 0;
    const v5 = fill(new Array(v4), 0, v4, null);
    const v6 = new Mut2(0, 0);
    while (method27(v4, v6)) {
        const v8 = v6.l0 | 0;
        const v9 = v6.l1 | 0;
        const v10 = v3[v8];
        let v14;
        if (v10.tag === 1) {
            v5[v9] = v10;
            v14 = (v9 + 1);
        }
        else {
            v14 = v9;
        }
        const v15 = (v8 + 1) | 0;
        v6.l0 = (v15 | 0);
        v6.l1 = (v14 | 0);
    }
    const v16 = v6.l1 | 0;
    const v17 = fill(new Array(v16), 0, v16, null);
    const v18 = new Mut3(0);
    while (method28(v16, v18)) {
        const v20 = v18.l0 | 0;
        const v21 = v5[v20];
        v17[v20] = v21;
        const v22 = (v20 + 1) | 0;
        v18.l0 = (v22 | 0);
    }
    const v23 = v17.length | 0;
    const v24 = fill(new Array(v23), 0, v23, null);
    const v25 = new Mut3(0);
    while (method28(v23, v25)) {
        const v27 = v25.l0 | 0;
        const v28 = v17[v27];
        let v31;
        if (v28.tag === 1) {
            v31 = v28.fields[0];
        }
        else {
            throw new Error("Option does not have a value.");
        }
        v24[v27] = v31;
        const v32 = (v27 + 1) | 0;
        v25.l0 = (v32 | 0);
    }
    return v24;
}

export function closure34(v0_1: any, v1_1: int32, v2: (arg0: boolean) => void, v3: (arg0: void) => boolean, unitVar: void): void {
    const v5 = v3() === false;
    v2(v5);
    const v10 = createObj(method25(v5 ? (new US0(1, v1_1)) : (new US0(1, -3))));
    v0_1("set", v10);
}

export function closure35(v0_1: (arg0: boolean) => void, unitVar: void): void {
    v0_1(false);
}

export function closure30(v0_1: any, v1_1: int32, v2: (arg0: boolean) => void, v3: (arg0: boolean) => void, v4: (arg0: boolean) => void, v5: (arg0: void) => boolean, unitVar: void): Array<any> {
    const v8 = BiRegularRefresh;
    const v9 = "14px";
    const v11 = "size";
    const v17 = createObj(method5(new UH1(0, [v11, v9], new UH1(1))));
    const v20 = createComponent;
    const v24 = IconButton;
    const v26 = "icon";
    const v28 = (): void => {
        closure31(v3, void 0);
    };
    const v30 = "onClick";
    const v32 = "neutral";
    const v34 = "colorScheme";
    const v36 = "20px";
    const v38 = "height";
    const v40 = "xs";
    const v45 = "aria-label";
    const v56 = createObj(method5(new UH1(0, [v45, "Refresh"], new UH1(0, [v11, v40], new UH1(0, [v38, v36], new UH1(0, [v34, v32], new UH1(0, [v30, v28], new UH1(0, [v26, v20(v8, v17)], new UH1(1)))))))));
    const v57_1 = createComponent;
    const v58_1 = v57_1(v24, v56);
    const v71_1 = IconButton;
    const v74_1 = (): void => {
        closure34(v0_1, v1_1, v4, v5, void 0);
    };
    const v94 = createObj(method5(new UH1(0, [v45, v5() ? "Restore" : "Maximize"], new UH1(0, [v11, v40], new UH1(0, [v38, v36], new UH1(0, [v34, v32], new UH1(0, [v30, v74_1], new UH1(0, [v26, (v5() ? ((v: UH0): any => closure32(void 0, v)) : ((v_1: UH0): any => closure33(void 0, v_1)))(new UH0(0, new US1(46, v9), new UH0(1)))], new UH1(1)))))))));
    const v95 = createComponent;
    const v96 = v95(v71_1, v94);
    const v98 = BiRegularUndo;
    const v105 = createObj(method5(new UH1(0, [v11, v9], new UH1(1))));
    const v106 = createComponent;
    const v108 = IconButton;
    const v111 = (): void => {
        closure35(v2, void 0);
    };
    const v132 = createObj(method5(new UH1(0, [v45, "Unload"], new UH1(0, [v11, v40], new UH1(0, [v38, v36], new UH1(0, [v34, v32], new UH1(0, [v30, v111], new UH1(0, [v26, v106(v98, v105)], new UH1(1)))))))));
    const v133 = createComponent;
    return [v58_1, v96, v133(v108, v132)];
}

export function closure29(v0_1: any, v1_1: any, v2: int32, v3: (arg0: boolean) => void, v4: (arg0: boolean) => void, v5: (arg0: void) => boolean, v6: (arg0: boolean) => void, v7: (arg0: void) => boolean, v8: (arg0: void) => Array<any>, unitVar: void): Array<any> {
    let v9;
    const matchValue = v1_1.ui_modal | 0;
    v9 = ((matchValue === (void 0)) ? -2 : matchValue);
    const v26 = "6px";
    const v31 = (): Array<any> => closure30(v0_1, v2, v3, v4, v6, v7, void 0);
    const v44 = Stack;
    const v49 = createObj(method5(method4(method3(((v9 > 0) && ((v9 === v2) !== true)) ? (new UH0(0, new US1(14, "none"), new UH0(1))) : (new UH0(1)), new UH0(0, new US1(13, "row"), new UH0(0, new US1(47, "3px"), new UH0(0, new US1(44, "absolute"), new UH0(0, new US1(52, v26), new UH0(0, new US1(45, v26), new UH0(0, new US1(54, 1), new UH0(0, new US1(9, v31), new UH0(1))))))))), new UH1(1))));
    const v52 = createComponent;
    return [v52(v44, v49), v5() ? <></> : v8];
}

export function closure28(v0_1: UH0, v1_1: any, v2: any, v3: int32, v4: (arg0: boolean) => void, v5: (arg0: boolean) => void, v6: (arg0: void) => boolean, v7: (arg0: boolean) => void, v8: (arg0: void) => boolean, unitVar: void): Array<any> {
    let v26: (arg0: void) => Array<any>, v35: any, v40: UH0, matchValue: int32, v43: any;
    const v11 = method10(v0_1, new US3(0));
    return [(v11.tag === 1) ? ((v26 = ((): Array<any> => closure29(v1_1, v2, v3, v4, v5, v6, v7, v8, v11.fields[0], void 0)), (v35 = Box, (v40 = createObj(method5(method4(method3((((matchValue = (v2.ui_modal | 0), (matchValue === (void 0)) ? -2 : matchValue)) <= 0) ? (new UH0(0, new US1(44, "relative"), new UH0(1))) : (new UH0(1)), new UH0(0, new US1(16, "1"), new UH0(0, new US1(14, "flex"), new UH0(0, new US1(9, v26), new UH0(1))))), new UH1(1)))), (v43 = createComponent, v43(v35, v40)))))) : <></>];
}

export function closure24(v0_1: UH0, v1_1: any, v2: any, v3: int32, v4: (arg0: boolean) => void, v5: (arg0: void) => boolean, v6: (arg0: boolean) => void, v7: (arg0: void) => boolean, v8: (arg0: boolean) => void, v9: (arg0: void) => boolean, unitVar: void): Array<any> {
    let v14: any, v15: (arg0: void) => Array<any>, v28: UH0, v31: any, v58_1: (arg0: void) => Array<any>, v67_1: any, v72_1: UH0, v37: string, v75_1: any;
    return [(v5() === false) ? ((v14 = Box, (v15 = ((): Array<any> => closure25(v4, v0_1, v1_1, v2, void 0)), (v28 = createObj(method5(new UH1(0, ["padding", "4px 0"], new UH1(0, ["children", v15], new UH1(1))))), (v31 = createComponent, v31(v14, v28)))))) : ((v58_1 = ((): Array<any> => closure28(v0_1, v1_1, v2, v3, v4, v6, v7, v8, v9, void 0)), (v67_1 = Box, (v72_1 = createObj(method5(method4(method3(v9() ? ((v37 = "0", new UH0(0, new US1(54, 1), new UH0(0, new US1(44, "absolute"), new UH0(0, new US1(52, v37), new UH0(0, new US1(45, v37), new UH0(0, new US1(7, v37), new UH0(0, new US1(24, v37), new UH0(0, new US1(2, "$bg"), new UH0(1)))))))))) : (new UH0(1)), new UH0(0, new US1(14, "flex"), new UH0(0, new US1(16, "1"), new UH0(0, new US1(9, v58_1), new UH0(1))))), new UH1(1)))), (v75_1 = createComponent, v75_1(v67_1, v72_1))))))];
}

export function method22(v0_1: UH0): any {
    const v3 = useStoreon;
    const v4 = v3();
    const v5 = v4[0];
    const v6 = v4[1];
    const v7 = nonSeeded().Next0() | 0;
    const v10 = method23(v0_1, new US4(0));
    const v12 = (v10.tag === 1) && v10.fields[0];
    const v15 = createSignal;
    const v16 = v15(v12);
    let v17;
    const value_4 = v16[0];
    v17 = (value_4);
    let v18;
    const value_5 = v16[1];
    v18 = ((arg_1: boolean): void => {
        value_5(arg_1);
    });
    const v19 = createSignal;
    const v20 = v19(false);
    let v21;
    const value_7 = v20[0];
    v21 = (value_7);
    let v22;
    const value_8 = v20[1];
    v22 = ((arg_3: boolean): void => {
        value_8(arg_3);
    });
    const v25 = method24(v0_1, new US4(0));
    const v27 = (v25.tag === 1) && v25.fields[0];
    const v28 = createSignal;
    const v29 = v28(v27);
    let v30;
    const value_10 = v29[0];
    v30 = (value_10);
    let v31;
    const value_11 = v29[1];
    v31 = ((arg_5: boolean): void => {
        value_11(arg_5);
    });
    const v33 = on;
    const v34 = (): Array<boolean> => closure21(v21, void 0);
    const v35 = (): void => {
        closure22(v22, v21, void 0);
    };
    const v36 = v33(v34, v35);
    const v38 = createEffect;
    v38(v36);
    const v41 = method23(v0_1, new US4(0));
    if ((v41.tag === 1) && (v41.fields[0] === true)) {
        const v48 = method21(v0_1, new US6(0));
        if (v48.tag === 1) {
            const v51 = (v: any): void => {
                closure23(v6, v);
            };
            v48.fields[0](v5, v51);
        }
    }
    const v54 = method18(v0_1, new US2(0));
    const v65_1 = (): Array<any> => closure24(v0_1, v6, v5, v7, v18, v17, v22, v21, v31, v30, void 0);
    const v74_1 = Box;
    const v79_1 = createObj(method5(method4(method3((v54.tag === 1) ? (new UH0(0, new US1(22, v54.fields[0]), new UH0(1))) : (new UH0(1)), new UH0(0, new US1(14, "flex"), new UH0(0, new US1(16, "1"), new UH0(0, new US1(9, v65_1), new UH0(1))))), new UH1(1))));
    const v81_1 = createComponent;
    return v81_1(v74_1, v79_1);
}

export function closure20(unitVar: void, v0_1: UH0): any {
    return method22(v0_1);
}

export function closure19(v0_1: UH0, v1_1: (arg0: void) => boolean, v2: (arg0: void) => Array<any>, unitVar: void): Array<any> {
    let v11: US6, v24: UH0, v27: any, v28: (arg0: UH0) => any;
    const v5 = method17(v0_1, new US4(0));
    return [(v5.tag === 1) ? (v1_1() ? ((v11 = method21(v0_1, new US6(0)), (v24 = method3((v11.tag === 1) ? (new UH0(0, new US1(35, v11.fields[0]), new UH0(1))) : (new UH0(1)), new UH0(0, new US1(27, true), new UH0(0, new US1(9, v2), new UH0(1)))), (v27 = createComponent, (v28 = ((v: UH0): any => closure20(void 0, v)), v27(v28, v24)))))) : <></>) : v2];
}

export function closure13(v0_1: UH0, v1_1: (arg0: boolean) => void, v2: (arg0: void) => boolean, unitVar: void): Array<any> {
    let v107: US2, v113: any, v114: (arg0: void) => Array<any>, v140: string, v148: string, v173: UH0, v176: any, v76_1: any, v77_1: (arg0: void) => Array<any>, v85_1: string, v99: UH0, v102: any;
    const v5 = method19(v0_1, new US5(0));
    let v70_1;
    if (v5.tag === 1) {
        const v22 = Td;
        const v23 = (): Array<any> => closure14(v0_1, v1_1, v2, v5.fields[0], void 0);
        const v65_1 = createObj(method5(new UH1(0, ["borderBottomWidth", ((method17(v0_1, new US4(0)).tag === 0) ? true : v2()) ? {
            "@initial": "2px !important",
            "@sm": "0px !important",
        } : "0px !important"], new UH1(0, ["borderColor", "$neutral5"], new UH1(0, ["color", "$neutral9"], new UH1(0, ["display", "flex"], new UH1(0, ["flexDirection", "column"], new UH1(0, ["fontSize", "$sm"], new UH1(0, ["padding", "3px 20px 0 8px"], new UH1(0, ["children", v23], new UH1(1)))))))))));
        const v68_1 = createComponent;
        v70_1 = (v68_1(v22, v65_1));
    }
    else {
        v70_1 = <></>;
    }
    const v73_1 = method10(v0_1, new US3(0));
    return [v70_1, (v73_1.tag === 1) ? ((v107 = method20(v0_1, new US2(0)), (v113 = Td, (v114 = ((): Array<any> => closure19(v0_1, v2, v73_1.fields[0], void 0)), (v140 = "flex", (v148 = "0", (v173 = createObj(method5(new UH1(0, ["border", v148], new UH1(0, ["outline", v148], new UH1(0, ["margin", v148], new UH1(0, ["padding", (v107.tag === 1) ? v107.fields[0] : "0"], new UH1(0, ["display", v140], new UH1(0, [v140, "6"], new UH1(0, ["lineHeight", "$base"], new UH1(0, ["flexDirection", "column"], new UH1(0, ["fontSize", "$sm"], new UH1(0, ["maxHeight", "85vh"], new UH1(0, ["overflowY", "auto"], new UH1(0, ["children", v114], new UH1(1))))))))))))))), (v176 = createComponent, v176(v113, v173))))))))) : ((v76_1 = Td, (v77_1 = ((): Array<any> => closure18(void 0, void 0)), (v85_1 = "0", (v99 = createObj(method5(new UH1(0, ["border", v85_1], new UH1(0, ["padding", v85_1], new UH1(0, ["lineHeight", "9px"], new UH1(0, ["children", v77_1], new UH1(1))))))), (v102 = createComponent, v102(v76_1, v99)))))))];
}

export function method16(v0_1: UH0): any {
    const v3 = method17(v0_1, new US4(0));
    const v8 = ((v3.tag === 1) && (v3.fields[0] === false)) !== true;
    const v11 = createSignal;
    const v12 = v11(v8);
    let v13;
    const value_1 = v12[0];
    v13 = (value_1);
    let v14;
    const value_2 = v12[1];
    v14 = ((arg_1: boolean): void => {
        value_2(arg_1);
    });
    const v17 = method18(v0_1, new US2(0));
    const v36 = (): Array<any> => closure13(v0_1, v14, v13, void 0);
    const v48 = Tr;
    const v53 = createObj(method5(method4(method3((v17.tag === 1) ? (new UH0(0, new US1(22, v17.fields[0]), new UH0(1))) : (new UH0(1)), new UH0(0, new US1(14, "flex"), new UH0(0, new US1(16, "1"), new UH0(0, new US1(6, "1px 2px"), new UH0(0, new US1(5, "$neutral5"), new UH0(0, new US1(17, {
        "@initial": "column",
        "@sm": "row",
    }), new UH0(0, new US1(9, v36), new UH0(1)))))))), new UH1(1))));
    const v55 = createComponent;
    return v55(v48, v53);
}

export function closure12(unitVar: void, v0_1: UH0): any {
    return method16(v0_1);
}

export function closure36(unitVar: void, unitVar_1: void): Array<any> {
    const v2 = createComponent;
    const v3 = (v: UH0): any => closure7(void 0, v);
    return [v2(v3, (new UH0(0, new US1(20, "https://github.com/fc1943s/tictactoe_spiral"), new UH0(1))))];
}

export function closure37(unitVar: void, unitVar_1: void): Array<any> {
    const v2 = createComponent;
    const v3 = (v: UH0): any => closure7(void 0, v);
    return [v2(v3, (new UH0(0, new US1(20, "https://fc1943s.github.io/tictactoe_spiral"), new UH0(1))))];
}

export function closure38(unitVar: void, unitVar_1: void): Array<any> {
    const v2 = createComponent;
    const v3 = (v: UH0): any => closure7(void 0, v);
    return [v2(v3, (new UH0(0, new US1(20, "https://fc1943s.github.io/tictactoe_spiral/docs"), new UH0(1))))];
}

export function closure11(unitVar: void, unitVar_1: void): Array<any> {
    const v2 = createComponent;
    const v3 = (v: UH0): any => closure12(void 0, v);
    const v4 = "1px 6px";
    const v6 = (): Array<any> => closure36(void 0, void 0);
    const v12 = createComponent;
    const v14 = (): Array<any> => closure37(void 0, void 0);
    const v20 = createComponent;
    const v22 = (): Array<any> => closure38(void 0, void 0);
    return [v2(v3, (new UH0(0, new US1(39, v4), new UH0(0, new US1(9, v6), new UH0(1))))), v12(v3, (new UH0(0, new US1(39, v4), new UH0(0, new US1(9, v14), new UH0(1))))), v20(v3, (new UH0(0, new US1(39, v4), new UH0(0, new US1(9, v22), new UH0(1)))))];
}

export function method15(): any {
    const v2 = createComponent;
    const v3 = (v: UH0): any => closure2(void 0, v);
    const v4 = (): Array<any> => closure11(void 0, void 0);
    return v2(v3, (new UH0(0, new US1(9, v4), new UH0(1))));
}

export function closure10(unitVar: void, unitVar_1: void): any {
    return method15();
}

export const v0 = void 0;

export const v1 = new Mut0(v0);

export const v57 = method0();

export const v58 = new Heap0(v57);

export const v59 = v58;

export const v60 = method1(v59);

export const v61 = "base_button";

export const v62 = (v: UH0): any => closure1(void 0, v);

export const v63 = [v61, v62];

export const v64 = "base_table";

export const v65 = (v: UH0): any => closure2(void 0, v);

export const v66 = [v64, v65];

export const v67 = "create_obj_props";

export const v68 = (v: Array<[string, any]>): UH0 => closure5(void 0, v);

export const v69 = [v67, v68];

export const v70 = "create_storeon";

export const v71 = (v: any): any => closure6(void 0, v);

export const v72 = [v70, v71];

export const v73 = "external_link";

export const v74 = (v: UH0): any => closure7(void 0, v);

export const v75 = [v73, v74];

export const v76 = "links";

export const v77 = (): any => closure10(void 0, void 0);

export const v78 = [v76, v77];

export const v79 = "loader";

export const v80 = (v: UH0): any => closure20(void 0, v);

export const v81 = [v79, v80];

export const v82 = "row";

export const v83 = (v: UH0): any => closure12(void 0, v);

export const v84 = [v82, v83];

export const v85 = "store";

export const v86 = [v85, v60];

export const v87 = [v63, v66, v69, v72, v75, v78, v81, v84, v86];

export const v88 = createObj(v87);

v1.l0 = v88;


