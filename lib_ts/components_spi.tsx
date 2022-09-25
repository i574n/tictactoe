import { Union, Record } from "./fable_modules/fable-library.4.0.0-theta-003/Types.js";
import { tuple_type, array_type, class_type, string_type, lambda_type, unit_type, bool_type, union_type, int32_type, record_type, obj_type, TypeInfo } from "./fable_modules/fable-library.4.0.0-theta-003/Reflection.js";
import { int32 } from "./fable_modules/fable-library.4.0.0-theta-003/Int32.js";
import { createStoreon } from "storeon";
import { fill } from "./fable_modules/fable-library.4.0.0-theta-003/Array.js";
import { uncurry, equals, createObj } from "./fable_modules/fable-library.4.0.0-theta-003/Util.js";
import { createEffect, on, createSignal, createComponent } from "solid-js";
import { Tr, Td, Stack, IconButton, Checkbox, Box, Icon, Anchor, Table, Tbody, Button } from "@hope-ui/solid";
import { BiRegularUndo, BiRegularUpArrow, BiRegularDownArrow, BiRegularRefresh, BiRegularLinkExternal } from "solid-icons/bi";
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
        return ["US1_0", "US1_1"];
    }
}

export function US1$reflection(): TypeInfo {
    return union_type("Components_spi.US1", [], US1, () => [[], [["f1_0", bool_type]]]);
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
    return union_type("Components_spi.US2", [], US2, () => [[], [["f1_0", lambda_type(obj_type, lambda_type(lambda_type(obj_type, unit_type), unit_type))]]]);
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
    return union_type("Components_spi.US3", [], US3, () => [[], [["f1_0", string_type]]]);
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
    return union_type("Components_spi.US4", [], US4, () => [[], [["f1_0", class_type("Fable.Core.JS.Function")]]]);
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
    return union_type("Components_spi.US5", [], US5, () => [[], [["f1_0", lambda_type(unit_type, array_type(class_type("Fable.Core.JSX.Element")))]]]);
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
    return union_type("Components_spi.US6", [], US6, () => [[], [["f1_0", class_type("Fable.Core.JSX.Element")]]]);
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
    return union_type("Components_spi.US7", [], US7, () => [[], [["f1_0", obj_type]]]);
}

export class US8 extends Union {
    tag: int32;
    fields: Array<any>;
    constructor(tag: int32, ...fields: Array<any>) {
        super();
        this.tag = (tag | 0);
        this.fields = fields;
    }
    cases() {
        return ["US8_0", "US8_1"];
    }
}

export function US8$reflection(): TypeInfo {
    return union_type("Components_spi.US8", [], US8, () => [[], [["f1_0", lambda_type(obj_type, unit_type)]]]);
}

export class US9 extends Union {
    tag: int32;
    fields: Array<any>;
    constructor(tag: int32, ...fields: Array<any>) {
        super();
        this.tag = (tag | 0);
        this.fields = fields;
    }
    cases() {
        return ["US9_0", "US9_1"];
    }
}

export function US9$reflection(): TypeInfo {
    return union_type("Components_spi.US9", [], US9, () => [[], [["f1_0", lambda_type(unit_type, unit_type)]]]);
}

export class Heap1 extends Record {
    l0: US1;
    l1: US1;
    l2: US2;
    l3: US3;
    l4: US4;
    l5: US3;
    l6: US3;
    l7: US3;
    l8: US3;
    l9: US3;
    l10: US3;
    l11: US1;
    l12: US5;
    l13: US3;
    l14: US3;
    l15: US1;
    l16: US3;
    l17: US3;
    l18: US1;
    l19: US3;
    l20: US3;
    l21: US3;
    l22: US3;
    l23: US3;
    l24: US6;
    l25: US3;
    l26: US3;
    l27: US3;
    l28: US7;
    l29: US3;
    l30: US3;
    l31: US3;
    l32: US3;
    l33: US3;
    l34: US8;
    l35: US9;
    l36: US3;
    l37: US3;
    l38: US3;
    l39: US3;
    l40: US3;
    l41: US3;
    l42: US3;
    l43: US3;
    l44: US3;
    l45: US3;
    l46: US3;
    l47: US3;
    l48: US1;
    l49: US3;
    l50: US3;
    l51: US6;
    l52: US3;
    l53: US3;
    l54: US0;
    constructor(l0: US1, l1: US1, l2: US2, l3: US3, l4: US4, l5: US3, l6: US3, l7: US3, l8: US3, l9: US3, l10: US3, l11: US1, l12: US5, l13: US3, l14: US3, l15: US1, l16: US3, l17: US3, l18: US1, l19: US3, l20: US3, l21: US3, l22: US3, l23: US3, l24: US6, l25: US3, l26: US3, l27: US3, l28: US7, l29: US3, l30: US3, l31: US3, l32: US3, l33: US3, l34: US8, l35: US9, l36: US3, l37: US3, l38: US3, l39: US3, l40: US3, l41: US3, l42: US3, l43: US3, l44: US3, l45: US3, l46: US3, l47: US3, l48: US1, l49: US3, l50: US3, l51: US6, l52: US3, l53: US3, l54: US0) {
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
    }
}

export function Heap1$reflection(): TypeInfo {
    return record_type("Components_spi.Heap1", [], Heap1, () => [["l0", US1$reflection()], ["l1", US1$reflection()], ["l2", US2$reflection()], ["l3", US3$reflection()], ["l4", US4$reflection()], ["l5", US3$reflection()], ["l6", US3$reflection()], ["l7", US3$reflection()], ["l8", US3$reflection()], ["l9", US3$reflection()], ["l10", US3$reflection()], ["l11", US1$reflection()], ["l12", US5$reflection()], ["l13", US3$reflection()], ["l14", US3$reflection()], ["l15", US1$reflection()], ["l16", US3$reflection()], ["l17", US3$reflection()], ["l18", US1$reflection()], ["l19", US3$reflection()], ["l20", US3$reflection()], ["l21", US3$reflection()], ["l22", US3$reflection()], ["l23", US3$reflection()], ["l24", US6$reflection()], ["l25", US3$reflection()], ["l26", US3$reflection()], ["l27", US3$reflection()], ["l28", US7$reflection()], ["l29", US3$reflection()], ["l30", US3$reflection()], ["l31", US3$reflection()], ["l32", US3$reflection()], ["l33", US3$reflection()], ["l34", US8$reflection()], ["l35", US9$reflection()], ["l36", US3$reflection()], ["l37", US3$reflection()], ["l38", US3$reflection()], ["l39", US3$reflection()], ["l40", US3$reflection()], ["l41", US3$reflection()], ["l42", US3$reflection()], ["l43", US3$reflection()], ["l44", US3$reflection()], ["l45", US3$reflection()], ["l46", US3$reflection()], ["l47", US3$reflection()], ["l48", US1$reflection()], ["l49", US3$reflection()], ["l50", US3$reflection()], ["l51", US6$reflection()], ["l52", US3$reflection()], ["l53", US3$reflection()], ["l54", US0$reflection()]]);
}

export class US10 extends Union {
    tag: int32;
    fields: Array<any>;
    constructor(tag: int32, ...fields: Array<any>) {
        super();
        this.tag = (tag | 0);
        this.fields = fields;
    }
    cases() {
        return ["US10_0", "US10_1"];
    }
}

export function US10$reflection(): TypeInfo {
    return union_type("Components_spi.US10", [], US10, () => [[], [["f1_0", tuple_type(string_type, obj_type)]]]);
}

export class Mut1 extends Record {
    l0: int32;
    l1: int32;
    constructor(l0: int32, l1: int32) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = (l1 | 0);
    }
}

export function Mut1$reflection(): TypeInfo {
    return record_type("Components_spi.Mut1", [], Mut1, () => [["l0", int32_type], ["l1", int32_type]]);
}

export class Mut2 extends Record {
    l0: int32;
    constructor(l0: int32) {
        super();
        this.l0 = (l0 | 0);
    }
}

export function Mut2$reflection(): TypeInfo {
    return record_type("Components_spi.Mut2", [], Mut2, () => [["l0", int32_type]]);
}

export class Mut3 extends Record {
    l0: int32;
    l1: US1;
    l2: US1;
    l3: US2;
    l4: US3;
    l5: US4;
    l6: US3;
    l7: US3;
    l8: US3;
    l9: US3;
    l10: US3;
    l11: US3;
    l12: US1;
    l13: US5;
    l14: US3;
    l15: US3;
    l16: US1;
    l17: US3;
    l18: US3;
    l19: US1;
    l20: US3;
    l21: US3;
    l22: US3;
    l23: US3;
    l24: US3;
    l25: US6;
    l26: US3;
    l27: US3;
    l28: US3;
    l29: US7;
    l30: US3;
    l31: US3;
    l32: US3;
    l33: US3;
    l34: US3;
    l35: US8;
    l36: US9;
    l37: US3;
    l38: US3;
    l39: US3;
    l40: US3;
    l41: US3;
    l42: US3;
    l43: US3;
    l44: US3;
    l45: US3;
    l46: US3;
    l47: US3;
    l48: US3;
    l49: US1;
    l50: US3;
    l51: US3;
    l52: US6;
    l53: US3;
    l54: US3;
    l55: US0;
    constructor(l0: int32, l1: US1, l2: US1, l3: US2, l4: US3, l5: US4, l6: US3, l7: US3, l8: US3, l9: US3, l10: US3, l11: US3, l12: US1, l13: US5, l14: US3, l15: US3, l16: US1, l17: US3, l18: US3, l19: US1, l20: US3, l21: US3, l22: US3, l23: US3, l24: US3, l25: US6, l26: US3, l27: US3, l28: US3, l29: US7, l30: US3, l31: US3, l32: US3, l33: US3, l34: US3, l35: US8, l36: US9, l37: US3, l38: US3, l39: US3, l40: US3, l41: US3, l42: US3, l43: US3, l44: US3, l45: US3, l46: US3, l47: US3, l48: US3, l49: US1, l50: US3, l51: US3, l52: US6, l53: US3, l54: US3, l55: US0) {
        super();
        this.l0 = (l0 | 0);
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
    }
}

export function Mut3$reflection(): TypeInfo {
    return record_type("Components_spi.Mut3", [], Mut3, () => [["l0", int32_type], ["l1", US1$reflection()], ["l2", US1$reflection()], ["l3", US2$reflection()], ["l4", US3$reflection()], ["l5", US4$reflection()], ["l6", US3$reflection()], ["l7", US3$reflection()], ["l8", US3$reflection()], ["l9", US3$reflection()], ["l10", US3$reflection()], ["l11", US3$reflection()], ["l12", US1$reflection()], ["l13", US5$reflection()], ["l14", US3$reflection()], ["l15", US3$reflection()], ["l16", US1$reflection()], ["l17", US3$reflection()], ["l18", US3$reflection()], ["l19", US1$reflection()], ["l20", US3$reflection()], ["l21", US3$reflection()], ["l22", US3$reflection()], ["l23", US3$reflection()], ["l24", US3$reflection()], ["l25", US6$reflection()], ["l26", US3$reflection()], ["l27", US3$reflection()], ["l28", US3$reflection()], ["l29", US7$reflection()], ["l30", US3$reflection()], ["l31", US3$reflection()], ["l32", US3$reflection()], ["l33", US3$reflection()], ["l34", US3$reflection()], ["l35", US8$reflection()], ["l36", US9$reflection()], ["l37", US3$reflection()], ["l38", US3$reflection()], ["l39", US3$reflection()], ["l40", US3$reflection()], ["l41", US3$reflection()], ["l42", US3$reflection()], ["l43", US3$reflection()], ["l44", US3$reflection()], ["l45", US3$reflection()], ["l46", US3$reflection()], ["l47", US3$reflection()], ["l48", US3$reflection()], ["l49", US1$reflection()], ["l50", US3$reflection()], ["l51", US3$reflection()], ["l52", US6$reflection()], ["l53", US3$reflection()], ["l54", US3$reflection()], ["l55", US0$reflection()]]);
}

export function method0(): US0 {
    return new US0(0);
}

export function closure0(v0_1: any, v1_1: any): void {
    const v2_1 = v1_1.on;
    v2_1("@init", ((): any => v0_1));
    v2_1("set", ((_, state) => state));
}

export function method1(v0_1: any): any {
    const v3_1 = createStoreon;
    const v4_1 = (v: any): void => {
        closure0(v0_1, v);
    };
    return v3_1([v4_1]);
}

export function method3(): [US1, US1, US2, US3, US4, US3, US3, US3, US3, US3, US3, US1, US5, US3, US3, US1, US3, US3, US1, US3, US3, US3, US3, US3, US6, US3, US3, US3, US7, US3, US3, US3, US3, US3, US8, US9, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US3, US1, US3, US3, US6, US3, US3, US0] {
    return [new US1(0), new US1(0), new US2(0), new US3(0), new US4(0), new US3(0), new US3(0), new US3(0), new US3(0), new US3(0), new US3(0), new US1(0), new US5(0), new US3(0), new US3(0), new US1(0), new US3(0), new US3(0), new US1(0), new US3(0), new US3(0), new US3(0), new US3(0), new US3(0), new US6(0), new US3(0), new US3(0), new US3(0), new US7(0), new US3(0), new US3(0), new US3(0), new US3(0), new US3(0), new US8(0), new US9(0), new US3(0), new US3(0), new US3(0), new US3(0), new US3(0), new US3(0), new US3(0), new US3(0), new US3(0), new US3(0), new US3(0), new US3(0), new US1(0), new US3(0), new US3(0), new US6(0), new US3(0), new US3(0), new US0(0)];
}

export function method4(v0_1: Heap1, v1_1: US1, v2_1: US1, v3_1: US2, v4_1: US3, v5_1: US4, v6_1: US3, v7_1: US3, v8_1: US3, v9_1: US3, v10_1: US3, v11_1: US3, v12_1: US1, v13_1: US5, v14_1: US3, v15_1: US3, v16_1: US1, v17_1: US3, v18_1: US3, v19_1: US1, v20_1: US3, v21_1: US3, v22_1: US3, v23_1: US3, v24_1: US3, v25_1: US6, v26_1: US3, v27_1: US3, v28_1: US3, v29_1: US7, v30_1: US3, v31_1: US3, v32_1: US3, v33_1: US3, v34: US3, v35: US8, v36: US9, v37: US3, v38: US3, v39: US3, v40: US3, v41: US3, v42: US3, v43: US3, v44: US3, v45: US3, v46: US3, v47: US3, v48: US3, v49: US1, v50: US3, v51: US3, v52: US6, v53: US3, v54: US3, v55: US0): Heap1 {
    const v56 = new Heap1(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55);
    const v57 = v0_1.l0;
    const v58 = v56.l0;
    const v65 = (v58.tag === 1) ? (new US1(1, v58.fields[0])) : ((v57.tag === 1) ? (new US1(1, v57.fields[0])) : (new US1(0)));
    const v66 = v0_1.l1;
    const v67 = v56.l1;
    const v74 = (v67.tag === 1) ? (new US1(1, v67.fields[0])) : ((v66.tag === 1) ? (new US1(1, v66.fields[0])) : (new US1(0)));
    const v75 = v0_1.l2;
    const v76 = v56.l2;
    const v83 = (v76.tag === 1) ? (new US2(1, v76.fields[0])) : ((v75.tag === 1) ? (new US2(1, v75.fields[0])) : (new US2(0)));
    const v84 = v0_1.l3;
    const v85 = v56.l3;
    const v92 = (v85.tag === 1) ? (new US3(1, v85.fields[0])) : ((v84.tag === 1) ? (new US3(1, v84.fields[0])) : (new US3(0)));
    const v93 = v0_1.l4;
    const v94 = v56.l4;
    const v101 = (v94.tag === 1) ? (new US4(1, v94.fields[0])) : ((v93.tag === 1) ? (new US4(1, v93.fields[0])) : (new US4(0)));
    const v102 = v0_1.l5;
    const v103 = v56.l5;
    const v110 = (v103.tag === 1) ? (new US3(1, v103.fields[0])) : ((v102.tag === 1) ? (new US3(1, v102.fields[0])) : (new US3(0)));
    const v111 = v0_1.l6;
    const v112 = v56.l6;
    const v119 = (v112.tag === 1) ? (new US3(1, v112.fields[0])) : ((v111.tag === 1) ? (new US3(1, v111.fields[0])) : (new US3(0)));
    const v120 = v0_1.l9;
    const v121 = v56.l9;
    const v128 = (v121.tag === 1) ? (new US3(1, v121.fields[0])) : ((v120.tag === 1) ? (new US3(1, v120.fields[0])) : (new US3(0)));
    const v129 = v0_1.l7;
    const v130 = v56.l7;
    const v137 = (v130.tag === 1) ? (new US3(1, v130.fields[0])) : ((v129.tag === 1) ? (new US3(1, v129.fields[0])) : (new US3(0)));
    const v138 = v0_1.l8;
    const v139 = v56.l8;
    const v146 = (v139.tag === 1) ? (new US3(1, v139.fields[0])) : ((v138.tag === 1) ? (new US3(1, v138.fields[0])) : (new US3(0)));
    const v147 = v0_1.l10;
    const v148 = v56.l10;
    const v155 = (v148.tag === 1) ? (new US3(1, v148.fields[0])) : ((v147.tag === 1) ? (new US3(1, v147.fields[0])) : (new US3(0)));
    const v156 = v0_1.l13;
    const v157 = v56.l13;
    const v164 = (v157.tag === 1) ? (new US3(1, v157.fields[0])) : ((v156.tag === 1) ? (new US3(1, v156.fields[0])) : (new US3(0)));
    const v165 = v0_1.l11;
    const v166 = v56.l11;
    const v173 = (v166.tag === 1) ? (new US1(1, v166.fields[0])) : ((v165.tag === 1) ? (new US1(1, v165.fields[0])) : (new US1(0)));
    const v174 = v0_1.l12;
    const v175 = v56.l12;
    const v182 = (v175.tag === 1) ? (new US5(1, v175.fields[0])) : ((v174.tag === 1) ? (new US5(1, v174.fields[0])) : (new US5(0)));
    const v183 = v0_1.l14;
    const v184 = v56.l14;
    const v191 = (v184.tag === 1) ? (new US3(1, v184.fields[0])) : ((v183.tag === 1) ? (new US3(1, v183.fields[0])) : (new US3(0)));
    const v192 = v0_1.l15;
    const v193 = v56.l15;
    const v200 = (v193.tag === 1) ? (new US1(1, v193.fields[0])) : ((v192.tag === 1) ? (new US1(1, v192.fields[0])) : (new US1(0)));
    const v201 = v0_1.l16;
    const v202 = v56.l16;
    const v209 = (v202.tag === 1) ? (new US3(1, v202.fields[0])) : ((v201.tag === 1) ? (new US3(1, v201.fields[0])) : (new US3(0)));
    const v210 = v0_1.l17;
    const v211 = v56.l17;
    const v218 = (v211.tag === 1) ? (new US3(1, v211.fields[0])) : ((v210.tag === 1) ? (new US3(1, v210.fields[0])) : (new US3(0)));
    const v219 = v0_1.l18;
    const v220 = v56.l18;
    const v227 = (v220.tag === 1) ? (new US1(1, v220.fields[0])) : ((v219.tag === 1) ? (new US1(1, v219.fields[0])) : (new US1(0)));
    const v228 = v0_1.l19;
    const v229 = v56.l19;
    const v236 = (v229.tag === 1) ? (new US3(1, v229.fields[0])) : ((v228.tag === 1) ? (new US3(1, v228.fields[0])) : (new US3(0)));
    const v237 = v0_1.l20;
    const v238 = v56.l20;
    const v245 = (v238.tag === 1) ? (new US3(1, v238.fields[0])) : ((v237.tag === 1) ? (new US3(1, v237.fields[0])) : (new US3(0)));
    const v246 = v0_1.l21;
    const v247 = v56.l21;
    const v254 = (v247.tag === 1) ? (new US3(1, v247.fields[0])) : ((v246.tag === 1) ? (new US3(1, v246.fields[0])) : (new US3(0)));
    const v255 = v0_1.l22;
    const v256 = v56.l22;
    const v263 = (v256.tag === 1) ? (new US3(1, v256.fields[0])) : ((v255.tag === 1) ? (new US3(1, v255.fields[0])) : (new US3(0)));
    const v264 = v0_1.l23;
    const v265 = v56.l23;
    const v272 = (v265.tag === 1) ? (new US3(1, v265.fields[0])) : ((v264.tag === 1) ? (new US3(1, v264.fields[0])) : (new US3(0)));
    const v273 = v0_1.l24;
    const v274 = v56.l24;
    const v281 = (v274.tag === 1) ? (new US6(1, v274.fields[0])) : ((v273.tag === 1) ? (new US6(1, v273.fields[0])) : (new US6(0)));
    const v282 = v0_1.l25;
    const v283 = v56.l25;
    const v290 = (v283.tag === 1) ? (new US3(1, v283.fields[0])) : ((v282.tag === 1) ? (new US3(1, v282.fields[0])) : (new US3(0)));
    const v291 = v0_1.l48;
    const v292 = v56.l48;
    const v299 = (v292.tag === 1) ? (new US1(1, v292.fields[0])) : ((v291.tag === 1) ? (new US1(1, v291.fields[0])) : (new US1(0)));
    const v300 = v0_1.l26;
    const v301 = v56.l26;
    const v308 = (v301.tag === 1) ? (new US3(1, v301.fields[0])) : ((v300.tag === 1) ? (new US3(1, v300.fields[0])) : (new US3(0)));
    const v309 = v0_1.l27;
    const v310 = v56.l27;
    const v317 = (v310.tag === 1) ? (new US3(1, v310.fields[0])) : ((v309.tag === 1) ? (new US3(1, v309.fields[0])) : (new US3(0)));
    const v318 = v0_1.l28;
    const v319 = v56.l28;
    const v326 = (v319.tag === 1) ? (new US7(1, v319.fields[0])) : ((v318.tag === 1) ? (new US7(1, v318.fields[0])) : (new US7(0)));
    const v327 = v0_1.l29;
    const v328 = v56.l29;
    const v335 = (v328.tag === 1) ? (new US3(1, v328.fields[0])) : ((v327.tag === 1) ? (new US3(1, v327.fields[0])) : (new US3(0)));
    const v336 = v0_1.l30;
    const v337 = v56.l30;
    const v344 = (v337.tag === 1) ? (new US3(1, v337.fields[0])) : ((v336.tag === 1) ? (new US3(1, v336.fields[0])) : (new US3(0)));
    const v345 = v0_1.l31;
    const v346 = v56.l31;
    const v353 = (v346.tag === 1) ? (new US3(1, v346.fields[0])) : ((v345.tag === 1) ? (new US3(1, v345.fields[0])) : (new US3(0)));
    const v354 = v0_1.l32;
    const v355 = v56.l32;
    const v362 = (v355.tag === 1) ? (new US3(1, v355.fields[0])) : ((v354.tag === 1) ? (new US3(1, v354.fields[0])) : (new US3(0)));
    const v363 = v0_1.l33;
    const v364 = v56.l33;
    const v371 = (v364.tag === 1) ? (new US3(1, v364.fields[0])) : ((v363.tag === 1) ? (new US3(1, v363.fields[0])) : (new US3(0)));
    const v372 = v0_1.l34;
    const v373 = v56.l34;
    const v380 = (v373.tag === 1) ? (new US8(1, v373.fields[0])) : ((v372.tag === 1) ? (new US8(1, v372.fields[0])) : (new US8(0)));
    const v381 = v0_1.l35;
    const v382 = v56.l35;
    const v389 = (v382.tag === 1) ? (new US9(1, v382.fields[0])) : ((v381.tag === 1) ? (new US9(1, v381.fields[0])) : (new US9(0)));
    const v390 = v0_1.l36;
    const v391 = v56.l36;
    const v398 = (v391.tag === 1) ? (new US3(1, v391.fields[0])) : ((v390.tag === 1) ? (new US3(1, v390.fields[0])) : (new US3(0)));
    const v399 = v0_1.l37;
    const v400 = v56.l37;
    const v407 = (v400.tag === 1) ? (new US3(1, v400.fields[0])) : ((v399.tag === 1) ? (new US3(1, v399.fields[0])) : (new US3(0)));
    const v408 = v0_1.l38;
    const v409 = v56.l38;
    const v416 = (v409.tag === 1) ? (new US3(1, v409.fields[0])) : ((v408.tag === 1) ? (new US3(1, v408.fields[0])) : (new US3(0)));
    const v417 = v0_1.l39;
    const v418 = v56.l39;
    const v425 = (v418.tag === 1) ? (new US3(1, v418.fields[0])) : ((v417.tag === 1) ? (new US3(1, v417.fields[0])) : (new US3(0)));
    const v426 = v0_1.l43;
    const v427 = v56.l43;
    const v434 = (v427.tag === 1) ? (new US3(1, v427.fields[0])) : ((v426.tag === 1) ? (new US3(1, v426.fields[0])) : (new US3(0)));
    const v435 = v0_1.l42;
    const v436 = v56.l42;
    const v443 = (v436.tag === 1) ? (new US3(1, v436.fields[0])) : ((v435.tag === 1) ? (new US3(1, v435.fields[0])) : (new US3(0)));
    const v444 = v0_1.l40;
    const v445 = v56.l40;
    const v453 = v0_1.l41;
    const v454 = v56.l41;
    const v462 = v0_1.l44;
    const v463 = v56.l44;
    const v471 = v0_1.l45;
    const v472 = v56.l45;
    const v480 = v0_1.l46;
    const v481 = v56.l46;
    const v489 = v0_1.l47;
    const v490 = v56.l47;
    const v498 = v0_1.l49;
    const v499 = v56.l49;
    const v507 = v0_1.l50;
    const v508 = v56.l50;
    const v516 = v0_1.l51;
    const v517 = v56.l51;
    const v525 = v0_1.l52;
    const v526 = v56.l52;
    const v534 = v0_1.l53;
    const v535 = v56.l53;
    const v543 = v0_1.l54;
    const v544 = v56.l54;
    return new Heap1(v65, v74, v83, v92, v101, v110, v119, v137, v146, v128, v155, v173, v182, v164, v191, v200, v209, v218, v227, v236, v245, v254, v263, v272, v281, v290, v308, v317, v326, v335, v344, v353, v362, v371, v380, v389, v398, v407, v416, v425, (v445.tag === 1) ? (new US3(1, v445.fields[0])) : ((v444.tag === 1) ? (new US3(1, v444.fields[0])) : (new US3(0))), (v454.tag === 1) ? (new US3(1, v454.fields[0])) : ((v453.tag === 1) ? (new US3(1, v453.fields[0])) : (new US3(0))), v443, v434, (v463.tag === 1) ? (new US3(1, v463.fields[0])) : ((v462.tag === 1) ? (new US3(1, v462.fields[0])) : (new US3(0))), (v472.tag === 1) ? (new US3(1, v472.fields[0])) : ((v471.tag === 1) ? (new US3(1, v471.fields[0])) : (new US3(0))), (v481.tag === 1) ? (new US3(1, v481.fields[0])) : ((v480.tag === 1) ? (new US3(1, v480.fields[0])) : (new US3(0))), (v490.tag === 1) ? (new US3(1, v490.fields[0])) : ((v489.tag === 1) ? (new US3(1, v489.fields[0])) : (new US3(0))), v299, (v499.tag === 1) ? (new US3(1, v499.fields[0])) : ((v498.tag === 1) ? (new US3(1, v498.fields[0])) : (new US3(0))), (v508.tag === 1) ? (new US3(1, v508.fields[0])) : ((v507.tag === 1) ? (new US3(1, v507.fields[0])) : (new US3(0))), (v517.tag === 1) ? (new US6(1, v517.fields[0])) : ((v516.tag === 1) ? (new US6(1, v516.fields[0])) : (new US6(0))), (v526.tag === 1) ? (new US3(1, v526.fields[0])) : ((v525.tag === 1) ? (new US3(1, v525.fields[0])) : (new US3(0))), (v535.tag === 1) ? (new US3(1, v535.fields[0])) : ((v534.tag === 1) ? (new US3(1, v534.fields[0])) : (new US3(0))), (v544.tag === 1) ? (new US0(1, v544.fields[0])) : ((v543.tag === 1) ? (new US0(1, v543.fields[0])) : (new US0(0))));
}

export function method6(v0_1: string, v1_1: US3): US10 {
    if (v1_1.tag === 1) {
        return new US10(1, [v0_1, v1_1.fields[0]]);
    }
    else {
        return new US10(0);
    }
}

export function method7(v0_1: string, v1_1: US4): US10 {
    if (v1_1.tag === 1) {
        return new US10(1, [v0_1, v1_1.fields[0]]);
    }
    else {
        return new US10(0);
    }
}

export function method8(v0_1: string, v1_1: US1): US10 {
    if (v1_1.tag === 1) {
        return new US10(1, [v0_1, v1_1.fields[0]]);
    }
    else {
        return new US10(0);
    }
}

export function method9(v0_1: string, v1_1: US5): US10 {
    if (v1_1.tag === 1) {
        return new US10(1, [v0_1, v1_1.fields[0]]);
    }
    else {
        return new US10(0);
    }
}

export function method10(v0_1: string, v1_1: US6): US10 {
    if (v1_1.tag === 1) {
        return new US10(1, [v0_1, v1_1.fields[0]]);
    }
    else {
        return new US10(0);
    }
}

export function method11(v0_1: string, v1_1: US7): US10 {
    if (v1_1.tag === 1) {
        return new US10(1, [v0_1, v1_1.fields[0]]);
    }
    else {
        return new US10(0);
    }
}

export function method12(v0_1: string, v1_1: US8): US10 {
    if (v1_1.tag === 1) {
        return new US10(1, [v0_1, v1_1.fields[0]]);
    }
    else {
        return new US10(0);
    }
}

export function method13(v0_1: string, v1_1: US9): US10 {
    if (v1_1.tag === 1) {
        return new US10(1, [v0_1, v1_1.fields[0]]);
    }
    else {
        return new US10(0);
    }
}

export function method14(v0_1: string, v1_1: US0): US10 {
    if (v1_1.tag === 1) {
        return new US10(1, [v0_1, v1_1.fields[0]]);
    }
    else {
        return new US10(0);
    }
}

export function method15(v0_1: int32, v1_1: Mut1): boolean {
    return v1_1.l0 < v0_1;
}

export function method16(v0_1: int32, v1_1: Mut2): boolean {
    return v1_1.l0 < v0_1;
}

export function method5(v0_1: Heap1): Array<[string, any]> {
    const v157 = [method6("aria-label", v0_1.l3), method7("as", v0_1.l4), method6("backgroundColor", v0_1.l5), method6("border", v0_1.l6), method6("borderWidth", v0_1.l9), method6("borderBottomWidth", v0_1.l7), method6("borderColor", v0_1.l8), method6("bottom", v0_1.l10), method6("color", v0_1.l13), method8("checked", v0_1.l11), method9("children", v0_1.l12), method6("colorScheme", v0_1.l14), method8("compact", v0_1.l15), method6("display", v0_1.l17), method6("direction", v0_1.l16), method8("external", v0_1.l18), method6("flex", v0_1.l19), method6("flexDirection", v0_1.l20), method6("fontSize", v0_1.l21), method6("height", v0_1.l22), method6("href", v0_1.l23), method10("icon", v0_1.l24), method6("id", v0_1.l25), method6("justifyContent", v0_1.l26), method6("left", v0_1.l27), method11("leftIcon", v0_1.l28), method6("lineHeight", v0_1.l29), method6("margin", v0_1.l30), method6("marginBottom", v0_1.l31), method6("marginTop", v0_1.l32), method6("maxHeight", v0_1.l33), method12("onChange", v0_1.l34), method13("onClick", v0_1.l35), method6("outline", v0_1.l36), method6("overflowX", v0_1.l37), method6("overflowY", v0_1.l38), method6("padding", v0_1.l39), method6("paddingTop", v0_1.l43), method6("paddingRight", v0_1.l42), method6("paddingBottom", v0_1.l40), method6("paddingLeft", v0_1.l41), method6("position", v0_1.l44), method6("right", v0_1.l45), method6("size", v0_1.l46), method6("spacing", v0_1.l47), method8("status", v0_1.l48), method6("striped", v0_1.l49), method6("thickness", v0_1.l50), method10("title", v0_1.l51), method6("top", v0_1.l52), method6("width", v0_1.l53), method14("zIndex", v0_1.l54)];
    const v158 = v157.length | 0;
    const v159 = fill(new Array(v158), 0, v158, null);
    const v160 = new Mut1(0, 0);
    while (method15(v158, v160)) {
        const v162 = v160.l0 | 0;
        const v163 = v160.l1 | 0;
        const v164 = v157[v162];
        let v168;
        if (v164.tag === 1) {
            v159[v163] = v164;
            v168 = (v163 + 1);
        }
        else {
            v168 = v163;
        }
        const v169 = (v162 + 1) | 0;
        v160.l0 = (v169 | 0);
        v160.l1 = (v168 | 0);
    }
    const v170 = v160.l1 | 0;
    const v171 = fill(new Array(v170), 0, v170, null);
    const v172 = new Mut2(0);
    while (method16(v170, v172)) {
        const v174 = v172.l0 | 0;
        const v175 = v159[v174];
        v171[v174] = v175;
        const v176 = (v174 + 1) | 0;
        v172.l0 = (v176 | 0);
    }
    const v177 = v171.length | 0;
    const v178 = fill(new Array(v177), 0, v177, null);
    const v179 = new Mut2(0);
    while (method16(v177, v179)) {
        const v181 = v179.l0 | 0;
        const v182 = v171[v181];
        let v185;
        if (v182.tag === 1) {
            v185 = v182.fields[0];
        }
        else {
            throw new Error("Option does not have a value.");
        }
        v178[v181] = v185;
        const v186 = (v181 + 1) | 0;
        v179.l0 = (v186 | 0);
    }
    return v178;
}

export function method2(v0_1: Heap1): any {
    const patternInput = method3();
    const v66 = createObj(method5(method4(v0_1, patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], new US3(1, "neutral"), new US1(1, true), patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], new US3(1, "left"), patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], new US3(1, "xs"), patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54])));
    const v69 = createComponent;
    return v69(Button, v66);
}

export function closure1(unitVar: void, v0_1: Heap1): any {
    return method2(v0_1);
}

export function closure3(v0_1: Heap1, v1_1: US1, v2_1: US1, v3_1: US2, v4_1: US3, v5_1: US4, v6_1: US3, v7_1: US3, v8_1: US3, v9_1: US3, v10_1: US3, v11_1: US3, v12_1: US1, v13_1: US5, v14_1: US3, v15_1: US3, v16_1: US1, v17_1: US3, v18_1: US3, v19_1: US1, v20_1: US3, v21_1: US3, v22_1: US3, v23_1: US3, v24_1: US3, v25_1: US6, v26_1: US3, v27_1: US3, v28_1: US3, v29_1: US7, v30_1: US3, v31_1: US3, v32_1: US3, v33_1: US3, v34: US3, v35: US8, v36: US9, v37: US3, v38: US3, v39: US3, v40: US3, v41: US3, v42: US3, v43: US3, v44: US3, v45: US3, v46: US3, v47: US3, v48: US3, v49: US1, v50: US3, v51: US3, v52: US6, v53: US3, v54: US3, v55: US0, unitVar: void): Array<any> {
    const v67 = createObj(method5(new Heap1(v1_1, v2_1, v3_1, v4_1, v5_1, new US3(1, "$blackAlpha3"), v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v0_1.l12, v14_1, v15_1, v16_1, v17_1, new US3(1, "flex"), v19_1, v20_1, new US3(1, "column"), v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, new US3(1, "-1px"), v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55)));
    const v70 = createComponent;
    return [v70(Tbody, v67)];
}

export function method17(v0_1: Heap1): any {
    const patternInput = method3();
    const v9_1 = patternInput[8];
    const v8_1 = patternInput[7];
    const v7_1 = patternInput[6];
    const v6_1 = patternInput[5];
    const v55 = patternInput[54];
    const v54 = patternInput[53];
    const v53 = patternInput[52];
    const v52 = patternInput[51];
    const v51 = patternInput[50];
    const v50 = patternInput[49];
    const v5_1 = patternInput[4];
    const v49 = patternInput[48];
    const v48 = patternInput[47];
    const v47 = patternInput[46];
    const v46 = patternInput[45];
    const v45 = patternInput[44];
    const v44 = patternInput[43];
    const v43 = patternInput[42];
    const v42 = patternInput[41];
    const v41 = patternInput[40];
    const v40 = patternInput[39];
    const v4_1 = patternInput[3];
    const v37 = patternInput[36];
    const v36 = patternInput[35];
    const v35 = patternInput[34];
    const v34 = patternInput[33];
    const v33_1 = patternInput[32];
    const v32_1 = patternInput[31];
    const v31_1 = patternInput[30];
    const v30_1 = patternInput[29];
    const v3_1 = patternInput[2];
    const v29_1 = patternInput[28];
    const v28_1 = patternInput[27];
    const v27_1 = patternInput[26];
    const v26_1 = patternInput[25];
    const v25_1 = patternInput[24];
    const v24_1 = patternInput[23];
    const v23_1 = patternInput[22];
    const v22_1 = patternInput[21];
    const v2_1 = patternInput[1];
    const v19_1 = patternInput[18];
    const v17_1 = patternInput[16];
    const v16_1 = patternInput[15];
    const v15_1 = patternInput[14];
    const v14_1 = patternInput[13];
    const v12_1 = patternInput[11];
    const v11_1 = patternInput[10];
    const v10_1 = patternInput[9];
    const v1_1 = patternInput[0];
    const v56 = v0_1.l38;
    const v60 = (): Array<any> => closure3(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, patternInput[12], v14_1, v15_1, v16_1, v17_1, patternInput[17], v19_1, patternInput[19], patternInput[20], v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, patternInput[37], patternInput[38], v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, void 0);
    const v73 = createObj(method5(new Heap1(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, new US5(1, v60), v14_1, v15_1, v16_1, v17_1, new US3(1, "flex"), v19_1, new US3(1, "1"), new US3(1, "column"), v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, new US3(1, "hidden"), new US3(1, (v56.tag === 1) ? v56.fields[0] : "hidden"), v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55)));
    const v76 = createComponent;
    return v76(Table, v73);
}

export function closure2(unitVar: void, v0_1: Heap1): any {
    return method17(v0_1);
}

export function method19(v0_1: int32, v1_1: Mut3): boolean {
    return v1_1.l0 < v0_1;
}

export function method18(v0_1: Array<[string, any]>): Heap1 {
    const patternInput = method3();
    const v56 = v0_1.length | 0;
    const v57 = new Mut3(0, patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46], patternInput[47], patternInput[48], patternInput[49], patternInput[50], patternInput[51], patternInput[52], patternInput[53], patternInput[54]);
    while (method19(v56, v57)) {
        const v59 = v57.l0 | 0;
        const patternInput_1 = [v57.l1, v57.l2, v57.l3, v57.l4, v57.l5, v57.l6, v57.l7, v57.l8, v57.l9, v57.l10, v57.l11, v57.l12, v57.l13, v57.l14, v57.l15, v57.l16, v57.l17, v57.l18, v57.l19, v57.l20, v57.l21, v57.l22, v57.l23, v57.l24, v57.l25, v57.l26, v57.l27, v57.l28, v57.l29, v57.l30, v57.l31, v57.l32, v57.l33, v57.l34, v57.l35, v57.l36, v57.l37, v57.l38, v57.l39, v57.l40, v57.l41, v57.l42, v57.l43, v57.l44, v57.l45, v57.l46, v57.l47, v57.l48, v57.l49, v57.l50, v57.l51, v57.l52, v57.l53, v57.l54, v57.l55];
        const v99 = patternInput_1[39];
        const v98 = patternInput_1[38];
        const v97 = patternInput_1[37];
        const v96 = patternInput_1[36];
        const v95 = patternInput_1[35];
        const v94 = patternInput_1[34];
        const v93 = patternInput_1[33];
        const v92 = patternInput_1[32];
        const v91 = patternInput_1[31];
        const v90 = patternInput_1[30];
        const v89 = patternInput_1[29];
        const v88 = patternInput_1[28];
        const v87 = patternInput_1[27];
        const v86 = patternInput_1[26];
        const v85 = patternInput_1[25];
        const v84 = patternInput_1[24];
        const v83 = patternInput_1[23];
        const v82 = patternInput_1[22];
        const v81 = patternInput_1[21];
        const v80 = patternInput_1[20];
        const v79 = patternInput_1[19];
        const v78 = patternInput_1[18];
        const v77 = patternInput_1[17];
        const v76 = patternInput_1[16];
        const v75 = patternInput_1[15];
        const v74 = patternInput_1[14];
        const v73 = patternInput_1[13];
        const v72 = patternInput_1[12];
        const v71 = patternInput_1[11];
        const v70 = patternInput_1[10];
        const v69 = patternInput_1[9];
        const v68 = patternInput_1[8];
        const v67 = patternInput_1[7];
        const v66 = patternInput_1[6];
        const v65 = patternInput_1[5];
        const v64 = patternInput_1[4];
        const v63 = patternInput_1[3];
        const v62 = patternInput_1[2];
        const v61 = patternInput_1[1];
        const v60 = patternInput_1[0];
        const v114 = patternInput_1[54];
        const v113 = patternInput_1[53];
        const v112 = patternInput_1[52];
        const v111 = patternInput_1[51];
        const v110 = patternInput_1[50];
        const v109 = patternInput_1[49];
        const v108 = patternInput_1[48];
        const v107 = patternInput_1[47];
        const v106 = patternInput_1[46];
        const v105 = patternInput_1[45];
        const v104 = patternInput_1[44];
        const v103 = patternInput_1[43];
        const v102 = patternInput_1[42];
        const v101 = patternInput_1[41];
        const v100 = patternInput_1[40];
        const patternInput_2 = v0_1[v59];
        const v116 = patternInput_2[1];
        const v115 = patternInput_2[0];
        let patternInput_3;
        if (equals(v116, void 0)) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("_loaded" === v115) {
            patternInput_3 = [new US1(1, v116), v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("_modal" === v115) {
            patternInput_3 = [v60, new US1(1, v116), v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("_on_load" === v115) {
            patternInput_3 = [v60, v61, new US2(1, uncurry(2, v116)), v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("aria-label" === v115) {
            patternInput_3 = [v60, v61, v62, new US3(1, v116), v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("as" === v115) {
            patternInput_3 = [v60, v61, v62, v63, new US4(1, v116), v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("backgroundColor" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, new US3(1, v116), v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("border" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, new US3(1, v116), v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("borderWidth" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, new US3(1, v116), v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("borderBottomWidth" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, new US3(1, v116), v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("borderColor" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, new US3(1, v116), v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("bottom" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, new US3(1, v116), v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("color" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, new US3(1, v116), v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("checked" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, new US1(1, v116), v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("children" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, new US5(1, v116), v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("colorScheme" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, new US3(1, v116), v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("compact" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, new US1(1, v116), v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("display" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, new US3(1, v116), v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("direction" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, new US3(1, v116), v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("external" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, new US1(1, v116), v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("flex" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, new US3(1, v116), v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("flexDirection" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, new US3(1, v116), v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("fontSize" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, new US3(1, v116), v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("height" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, new US3(1, v116), v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("href" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, new US3(1, v116), v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("icon" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, new US6(1, v116), v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("id" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, new US3(1, v116), v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("justifyContent" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, new US3(1, v116), v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("left" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, new US3(1, v116), v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("leftIcon" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, new US7(1, v116), v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("lineHeight" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, new US3(1, v116), v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("margin" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, new US3(1, v116), v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("marginBottom" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, new US3(1, v116), v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("marginTop" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, new US3(1, v116), v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("maxHeight" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, new US3(1, v116), v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("onChange" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, new US8(1, v116), v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("onClick" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, new US9(1, v116), v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("outline" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, new US3(1, v116), v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("overflowX" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, new US3(1, v116), v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("overflowY" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, new US3(1, v116), v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("padding" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, new US3(1, v116), v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("paddingTop" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, new US3(1, v116), v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("paddingRight" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, new US3(1, v116), v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("paddingBottom" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, new US3(1, v116), v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("paddingLeft" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, new US3(1, v116), v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("position" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, new US3(1, v116), v105, v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("right" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, new US3(1, v116), v106, v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("size" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, new US3(1, v116), v107, v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("spacing" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, new US3(1, v116), v108, v109, v110, v111, v112, v113, v114];
        }
        else if ("status" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, new US1(1, v116), v109, v110, v111, v112, v113, v114];
        }
        else if ("striped" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, new US3(1, v116), v110, v111, v112, v113, v114];
        }
        else if ("thickness" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, new US3(1, v116), v111, v112, v113, v114];
        }
        else if ("title" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, new US6(1, v116), v112, v113, v114];
        }
        else if ("top" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, new US3(1, v116), v113, v114];
        }
        else if ("width" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, new US3(1, v116), v114];
        }
        else if ("zIndex" === v115) {
            patternInput_3 = [v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100, v101, v102, v103, v104, v105, v106, v107, v108, v109, v110, v111, v112, v113, new US0(1, v116)];
        }
        else {
            throw new Error(`unknown prop: ${v115} = ${v116}`);
        }
        const v3419 = (v59 + 1) | 0;
        v57.l0 = (v3419 | 0);
        v57.l1 = patternInput_3[0];
        v57.l2 = patternInput_3[1];
        v57.l3 = patternInput_3[2];
        v57.l4 = patternInput_3[3];
        v57.l5 = patternInput_3[4];
        v57.l6 = patternInput_3[5];
        v57.l7 = patternInput_3[6];
        v57.l8 = patternInput_3[7];
        v57.l9 = patternInput_3[8];
        v57.l10 = patternInput_3[9];
        v57.l11 = patternInput_3[10];
        v57.l12 = patternInput_3[11];
        v57.l13 = patternInput_3[12];
        v57.l14 = patternInput_3[13];
        v57.l15 = patternInput_3[14];
        v57.l16 = patternInput_3[15];
        v57.l17 = patternInput_3[16];
        v57.l18 = patternInput_3[17];
        v57.l19 = patternInput_3[18];
        v57.l20 = patternInput_3[19];
        v57.l21 = patternInput_3[20];
        v57.l22 = patternInput_3[21];
        v57.l23 = patternInput_3[22];
        v57.l24 = patternInput_3[23];
        v57.l25 = patternInput_3[24];
        v57.l26 = patternInput_3[25];
        v57.l27 = patternInput_3[26];
        v57.l28 = patternInput_3[27];
        v57.l29 = patternInput_3[28];
        v57.l30 = patternInput_3[29];
        v57.l31 = patternInput_3[30];
        v57.l32 = patternInput_3[31];
        v57.l33 = patternInput_3[32];
        v57.l34 = patternInput_3[33];
        v57.l35 = patternInput_3[34];
        v57.l36 = patternInput_3[35];
        v57.l37 = patternInput_3[36];
        v57.l38 = patternInput_3[37];
        v57.l39 = patternInput_3[38];
        v57.l40 = patternInput_3[39];
        v57.l41 = patternInput_3[40];
        v57.l42 = patternInput_3[41];
        v57.l43 = patternInput_3[42];
        v57.l44 = patternInput_3[43];
        v57.l45 = patternInput_3[44];
        v57.l46 = patternInput_3[45];
        v57.l47 = patternInput_3[46];
        v57.l48 = patternInput_3[47];
        v57.l49 = patternInput_3[48];
        v57.l50 = patternInput_3[49];
        v57.l51 = patternInput_3[50];
        v57.l52 = patternInput_3[51];
        v57.l53 = patternInput_3[52];
        v57.l54 = patternInput_3[53];
        v57.l55 = patternInput_3[54];
    }
    const patternInput_4 = [v57.l1, v57.l2, v57.l3, v57.l4, v57.l5, v57.l6, v57.l7, v57.l8, v57.l9, v57.l10, v57.l11, v57.l12, v57.l13, v57.l14, v57.l15, v57.l16, v57.l17, v57.l18, v57.l19, v57.l20, v57.l21, v57.l22, v57.l23, v57.l24, v57.l25, v57.l26, v57.l27, v57.l28, v57.l29, v57.l30, v57.l31, v57.l32, v57.l33, v57.l34, v57.l35, v57.l36, v57.l37, v57.l38, v57.l39, v57.l40, v57.l41, v57.l42, v57.l43, v57.l44, v57.l45, v57.l46, v57.l47, v57.l48, v57.l49, v57.l50, v57.l51, v57.l52, v57.l53, v57.l54, v57.l55];
    return new Heap1(patternInput_4[0], patternInput_4[1], patternInput_4[2], patternInput_4[3], patternInput_4[4], patternInput_4[5], patternInput_4[6], patternInput_4[7], patternInput_4[8], patternInput_4[9], patternInput_4[10], patternInput_4[11], patternInput_4[12], patternInput_4[13], patternInput_4[14], patternInput_4[15], patternInput_4[16], patternInput_4[17], patternInput_4[18], patternInput_4[19], patternInput_4[20], patternInput_4[21], patternInput_4[22], patternInput_4[23], patternInput_4[24], patternInput_4[25], patternInput_4[26], patternInput_4[27], patternInput_4[28], patternInput_4[29], patternInput_4[30], patternInput_4[31], patternInput_4[32], patternInput_4[33], patternInput_4[34], patternInput_4[35], patternInput_4[36], patternInput_4[37], patternInput_4[38], patternInput_4[39], patternInput_4[40], patternInput_4[41], patternInput_4[42], patternInput_4[43], patternInput_4[44], patternInput_4[45], patternInput_4[46], patternInput_4[47], patternInput_4[48], patternInput_4[49], patternInput_4[50], patternInput_4[51], patternInput_4[52], patternInput_4[53], patternInput_4[54]);
}

export function closure4(unitVar: void, v0_1: Array<[string, any]>): Heap1 {
    return method18(v0_1);
}

export function closure5(unitVar: void, v0_1: any): any {
    return method1(v0_1);
}

export function closure8(v0_1: Heap1, unitVar: void): Array<any> {
    const v1_1 = v0_1.l23;
    return [<>
        {(v1_1.tag === 1) ? v1_1.fields[0] : ""}
    </>];
}

export function closure7(v0_1: Heap1, v1_1: US1, v2_1: US1, v3_1: US2, v4_1: US3, v5_1: US4, v6_1: US3, v7_1: US3, v8_1: US3, v9_1: US3, v10_1: US3, v11_1: US3, v12_1: US1, v13_1: US5, v14_1: US3, v15_1: US3, v16_1: US1, v17_1: US3, v18_1: US3, v19_1: US1, v20_1: US3, v21_1: US3, v22_1: US3, v23_1: US3, v24_1: US3, v25_1: US6, v26_1: US3, v27_1: US3, v28_1: US3, v29_1: US7, v30_1: US3, v31_1: US3, v32_1: US3, v33_1: US3, v34: US3, v35: US8, v36: US9, v37: US3, v38: US3, v39: US3, v40: US3, v41: US3, v42: US3, v43: US3, v44: US3, v45: US3, v46: US3, v47: US3, v48: US3, v49: US1, v50: US3, v51: US3, v52: US6, v53: US3, v54: US3, v55: US0, unitVar: void): Array<any> {
    const v56 = (): Array<any> => closure8(v0_1, void 0);
    const v62 = createObj(method5(method4(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, new US5(1, v56), v14_1, v15_1, v16_1, v17_1, v18_1, new US1(1, true), v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55)));
    const v65 = createComponent;
    const v68 = v65(Anchor, v62);
    const v70 = <>
        &nbsp;
    </>;
    const v73 = BiRegularLinkExternal;
    const v77 = createObj(method5(new Heap1(v1_1, v2_1, v3_1, v4_1, new US4(1, v73), v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55)));
    const v78 = createComponent;
    return [v68, v70, v78(Icon, v77)];
}

export function method20(v0_1: Heap1): any {
    const patternInput = method3();
    const v9_1 = patternInput[8];
    const v8_1 = patternInput[7];
    const v7_1 = patternInput[6];
    const v6_1 = patternInput[5];
    const v55 = patternInput[54];
    const v54 = patternInput[53];
    const v53 = patternInput[52];
    const v52 = patternInput[51];
    const v51 = patternInput[50];
    const v50 = patternInput[49];
    const v5_1 = patternInput[4];
    const v49 = patternInput[48];
    const v48 = patternInput[47];
    const v47 = patternInput[46];
    const v46 = patternInput[45];
    const v45 = patternInput[44];
    const v44 = patternInput[43];
    const v43 = patternInput[42];
    const v42 = patternInput[41];
    const v41 = patternInput[40];
    const v40 = patternInput[39];
    const v4_1 = patternInput[3];
    const v39 = patternInput[38];
    const v38 = patternInput[37];
    const v37 = patternInput[36];
    const v36 = patternInput[35];
    const v35 = patternInput[34];
    const v34 = patternInput[33];
    const v33_1 = patternInput[32];
    const v32_1 = patternInput[31];
    const v31_1 = patternInput[30];
    const v30_1 = patternInput[29];
    const v3_1 = patternInput[2];
    const v29_1 = patternInput[28];
    const v28_1 = patternInput[27];
    const v27_1 = patternInput[26];
    const v26_1 = patternInput[25];
    const v25_1 = patternInput[24];
    const v24_1 = patternInput[23];
    const v23_1 = patternInput[22];
    const v22_1 = patternInput[21];
    const v21_1 = patternInput[20];
    const v20_1 = patternInput[19];
    const v2_1 = patternInput[1];
    const v19_1 = patternInput[18];
    const v18_1 = patternInput[17];
    const v17_1 = patternInput[16];
    const v16_1 = patternInput[15];
    const v15_1 = patternInput[14];
    const v14_1 = patternInput[13];
    const v12_1 = patternInput[11];
    const v11_1 = patternInput[10];
    const v10_1 = patternInput[9];
    const v1_1 = patternInput[0];
    const v56 = (): Array<any> => closure7(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, patternInput[12], v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, void 0);
    const v60 = createObj(method5(new Heap1(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, new US5(1, v56), v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55)));
    const v63 = createComponent;
    return v63(Box, v60);
}

export function closure6(unitVar: void, v0_1: Heap1): any {
    return method20(v0_1);
}

export function closure15(v0_1: any, unitVar: void): Array<any> {
    return [v0_1];
}

export function closure14(v0_1: US1, v1_1: US1, v2_1: US2, v3_1: US3, v4_1: US4, v5_1: US3, v6_1: US3, v7_1: US3, v8_1: US3, v9_1: US3, v10_1: US3, v11_1: US1, v12_1: US5, v13_1: US3, v14_1: US3, v15_1: US1, v16_1: US3, v17_1: US3, v18_1: US1, v19_1: US3, v20_1: US3, v21_1: US3, v22_1: US3, v23_1: US3, v24_1: US6, v25_1: US3, v26_1: US3, v27_1: US3, v28_1: US7, v29_1: US3, v30_1: US3, v31_1: US3, v32_1: US3, v33_1: US3, v34: US8, v35: US9, v36: US3, v37: US3, v38: US3, v39: US3, v40: US3, v41: US3, v42: US3, v43: US3, v44: US3, v45: US3, v46: US3, v47: US3, v48: US1, v49: US3, v50: US3, v51: US6, v52: US3, v53: US3, v54: US0, v55: any, unitVar: void): Array<any> {
    const v56 = (): Array<any> => closure15(v55, void 0);
    const v62 = createObj(method5(new Heap1(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, new US5(1, v56), v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, new US3(1, "2px"), v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54)));
    const v65 = createComponent;
    return [v65(Box, v62)];
}

export function closure16(v0_1: (arg0: boolean) => void, v1_1: any): void {
    v0_1(v1_1.target.checked);
}

export function closure13(v0_1: Heap1, v1_1: US1, v2_1: US1, v3_1: US2, v4_1: US3, v5_1: US4, v6_1: US3, v7_1: US3, v8_1: US3, v9_1: US3, v10_1: US3, v11_1: US3, v12_1: US1, v13_1: US5, v14_1: US3, v15_1: US3, v16_1: US1, v17_1: US3, v18_1: US3, v19_1: US1, v20_1: US3, v21_1: US3, v22_1: US3, v23_1: US3, v24_1: US3, v25_1: US6, v26_1: US3, v27_1: US3, v28_1: US3, v29_1: US7, v30_1: US3, v31_1: US3, v32_1: US3, v33_1: US3, v34: US3, v35: US8, v36: US9, v37: US3, v38: US3, v39: US3, v40: US3, v41: US3, v42: US3, v43: US3, v44: US3, v45: US3, v46: US3, v47: US3, v48: US3, v49: US1, v50: US3, v51: US3, v52: US6, v53: US3, v54: US3, v55: US0, v56: (arg0: boolean) => void, v57: (arg0: void) => boolean, v58: any, unitVar: void): Array<any> {
    let v63: (arg0: void) => Array<any>, v69: (arg0: any) => void, v75: any, v78: any;
    return [(v0_1.l48.tag === 1) ? ((v63 = ((): Array<any> => closure14(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v58, void 0)), (v69 = ((v: any): void => {
        closure16(v56, v);
    }), (v75 = createObj(method5(new Heap1(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, new US1(1, v57()), new US5(1, v63), v14_1, new US3(1, "neutral"), v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, new US3(1, "2px"), v33_1, v34, new US8(1, v69), v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, new US3(1, "sm"), v48, v49, v50, v51, v52, v53, v54, v55))), (v78 = createComponent, v78(Checkbox, v75)))))) : v58];
}

export function closure17(unitVar: void, unitVar_1: void): Array<any> {
    return [<>
        &nbsp;
    </>];
}

export function closure20(v0_1: (arg0: void) => boolean, unitVar: void): Array<boolean> {
    return [v0_1()];
}

export function closure21(v0_1: (arg0: boolean) => void, v1_1: (arg0: void) => boolean, unitVar: void): void {
    if (v1_1()) {
        v0_1(false);
    }
}

export function closure22(v0_1: any, v1_1: any): void {
    v0_1("set", v1_1);
}

export function closure25(unitVar: void, unitVar_1: void): Array<any> {
    return [<>
        Load
    </>];
}

export function closure26(v0_1: (arg0: boolean) => void, v1_1: Heap1, v2_1: any, v3_1: any, unitVar: void): void {
    const v4_1 = v1_1.l2;
    if (v4_1.tag === 1) {
        const v7_1 = (v: any): void => {
            closure22(v2_1, v);
        };
        v4_1.fields[0](v3_1, v7_1);
    }
    v0_1(true);
}

export function closure24(v0_1: US1, v1_1: US1, v2_1: US2, v3_1: US3, v4_1: US4, v5_1: US3, v6_1: US3, v7_1: US3, v8_1: US3, v9_1: US3, v10_1: US3, v11_1: US1, v12_1: US5, v13_1: US3, v14_1: US3, v15_1: US1, v16_1: US3, v17_1: US3, v18_1: US1, v19_1: US3, v20_1: US3, v21_1: US3, v22_1: US3, v23_1: US3, v24_1: US6, v25_1: US3, v26_1: US3, v27_1: US3, v28_1: US7, v29_1: US3, v30_1: US3, v31_1: US3, v32_1: US3, v33_1: US3, v34: US8, v35: US9, v36: US3, v37: US3, v38: US3, v39: US3, v40: US3, v41: US3, v42: US3, v43: US3, v44: US3, v45: US3, v46: US3, v47: US3, v48: US1, v49: US3, v50: US3, v51: US6, v52: US3, v53: US3, v54: US0, v55: (arg0: boolean) => void, v56: Heap1, v57: any, v58: any, unitVar: void): Array<any> {
    const v59 = (v: Heap1): any => closure1(void 0, v);
    const v61 = (): Array<any> => closure25(void 0, void 0);
    const v63 = (): void => {
        closure26(v55, v56, v57, v58, void 0);
    };
    const v65 = new Heap1(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, new US5(1, v61), v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, new US9(1, v63), v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);
    const v68 = createComponent;
    return [v68(v59, v65)];
}

export function closure30(v0_1: (arg0: boolean) => void, unitVar: void): void {
    v0_1(true);
}

export function method24(v0_1: US0): Array<[string, any]> {
    const v3_1 = [method14("ui_modal", v0_1)];
    const v4_1 = v3_1.length | 0;
    const v5_1 = fill(new Array(v4_1), 0, v4_1, null);
    const v6_1 = new Mut1(0, 0);
    while (method15(v4_1, v6_1)) {
        const v8_1 = v6_1.l0 | 0;
        const v9_1 = v6_1.l1 | 0;
        const v10_1 = v3_1[v8_1];
        let v14_1;
        if (v10_1.tag === 1) {
            v5_1[v9_1] = v10_1;
            v14_1 = (v9_1 + 1);
        }
        else {
            v14_1 = v9_1;
        }
        const v15_1 = (v8_1 + 1) | 0;
        v6_1.l0 = (v15_1 | 0);
        v6_1.l1 = (v14_1 | 0);
    }
    const v16_1 = v6_1.l1 | 0;
    const v17_1 = fill(new Array(v16_1), 0, v16_1, null);
    const v18_1 = new Mut2(0);
    while (method16(v16_1, v18_1)) {
        const v20_1 = v18_1.l0 | 0;
        const v21_1 = v5_1[v20_1];
        v17_1[v20_1] = v21_1;
        const v22_1 = (v20_1 + 1) | 0;
        v18_1.l0 = (v22_1 | 0);
    }
    const v23_1 = v17_1.length | 0;
    const v24_1 = fill(new Array(v23_1), 0, v23_1, null);
    const v25_1 = new Mut2(0);
    while (method16(v23_1, v25_1)) {
        const v27_1 = v25_1.l0 | 0;
        const v28_1 = v17_1[v27_1];
        let v31_1;
        if (v28_1.tag === 1) {
            v31_1 = v28_1.fields[0];
        }
        else {
            throw new Error("Option does not have a value.");
        }
        v24_1[v27_1] = v31_1;
        const v32_1 = (v27_1 + 1) | 0;
        v25_1.l0 = (v32_1 | 0);
    }
    return v24_1;
}

export function closure31(v0_1: any, v1_1: int32, v2_1: (arg0: boolean) => void, v3_1: (arg0: void) => boolean, unitVar: void): void {
    const v5_1 = v3_1() === false;
    v2_1(v5_1);
    const v10_1 = createObj(method24(v5_1 ? (new US0(1, v1_1)) : (new US0(1, -3))));
    v0_1("set", v10_1);
}

export function closure32(v0_1: (arg0: boolean) => void, unitVar: void): void {
    v0_1(false);
}

export function closure29(v0_1: US1, v1_1: US1, v2_1: US2, v3_1: US3, v4_1: US4, v5_1: US3, v6_1: US3, v7_1: US3, v8_1: US3, v9_1: US3, v10_1: US3, v11_1: US1, v12_1: US5, v13_1: US3, v14_1: US3, v15_1: US1, v16_1: US3, v17_1: US3, v18_1: US1, v19_1: US3, v20_1: US3, v21_1: US3, v22_1: US3, v23_1: US3, v24_1: US6, v25_1: US3, v26_1: US3, v27_1: US3, v28_1: US7, v29_1: US3, v30_1: US3, v31_1: US3, v32_1: US3, v33_1: US3, v34: US8, v35: US9, v36: US3, v37: US3, v38: US3, v39: US3, v40: US3, v41: US3, v42: US3, v43: US3, v44: US3, v45: US3, v46: US3, v47: US3, v48: US1, v49: US3, v50: US3, v51: US6, v52: US3, v53: US3, v54: US0, v55: any, v56: int32, v57: (arg0: boolean) => void, v58: (arg0: boolean) => void, v59: (arg0: boolean) => void, v60: (arg0: void) => boolean, unitVar: void): Array<any> {
    let v96: any, v98: any;
    const v63 = BiRegularRefresh;
    const v65 = "14px";
    const v67 = new Heap1(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, new US3(1, v65), v47, v48, v49, v50, v51, v52, v53, v54);
    const v70 = createComponent;
    const v74 = "neutral";
    const v76 = "20px";
    const v79 = (): void => {
        closure30(v58, void 0);
    };
    const v81 = "xs";
    const v85 = createObj(method5(new Heap1(v0_1, v1_1, v2_1, new US3(1, "Refresh"), v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, new US3(1, v74), v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, new US3(1, v76), v23_1, new US6(1, v70(v63, v67)), v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, new US9(1, v79), v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, new US3(1, v81), v47, v48, v49, v50, v51, v52, v53, v54)));
    const v86 = createComponent;
    const v89 = v86(IconButton, v85);
    const v93 = v60() ? "Restore" : "Maximize";
    let v100;
    v100 = (v60() ? ((v96 = BiRegularDownArrow, v96)) : ((v98 = BiRegularUpArrow, v98)));
    const v102 = new Heap1(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, new US3(1, v65), v47, v48, v49, v50, v51, v52, v53, v54);
    const v103 = createComponent;
    const v109 = (): void => {
        closure31(v55, v56, v59, v60, void 0);
    };
    const v114 = createObj(method5(new Heap1(v0_1, v1_1, v2_1, new US3(1, v93), v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, new US3(1, v74), v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, new US3(1, v76), v23_1, new US6(1, v103(v100, v102)), v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, new US9(1, v109), v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, new US3(1, v81), v47, v48, v49, v50, v51, v52, v53, v54)));
    const v115 = createComponent;
    const v116 = v115(IconButton, v114);
    const v118 = BiRegularUndo;
    const v121 = new Heap1(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, new US3(1, v65), v47, v48, v49, v50, v51, v52, v53, v54);
    const v122 = createComponent;
    const v129 = (): void => {
        closure32(v57, void 0);
    };
    const v134 = createObj(method5(new Heap1(v0_1, v1_1, v2_1, new US3(1, "Unload"), v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, new US3(1, v74), v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, new US3(1, v76), v23_1, new US6(1, v122(v118, v121)), v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, new US9(1, v129), v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, new US3(1, v81), v47, v48, v49, v50, v51, v52, v53, v54)));
    const v135 = createComponent;
    return [v89, v116, v135(IconButton, v134)];
}

export function closure28(v0_1: US1, v1_1: US1, v2_1: US2, v3_1: US3, v4_1: US4, v5_1: US3, v6_1: US3, v7_1: US3, v8_1: US3, v9_1: US3, v10_1: US3, v11_1: US1, v12_1: US5, v13_1: US3, v14_1: US3, v15_1: US1, v16_1: US3, v17_1: US3, v18_1: US1, v19_1: US3, v20_1: US3, v21_1: US3, v22_1: US3, v23_1: US3, v24_1: US6, v25_1: US3, v26_1: US3, v27_1: US3, v28_1: US7, v29_1: US3, v30_1: US3, v31_1: US3, v32_1: US3, v33_1: US3, v34: US8, v35: US9, v36: US3, v37: US3, v38: US3, v39: US3, v40: US3, v41: US3, v42: US3, v43: US3, v44: US3, v45: US3, v46: US3, v47: US3, v48: US1, v49: US3, v50: US3, v51: US6, v52: US3, v53: US3, v54: US0, v55: any, v56: int32, v57: (arg0: boolean) => void, v58: (arg0: boolean) => void, v59: (arg0: void) => boolean, v60: (arg0: boolean) => void, v61: (arg0: void) => boolean, v62: any, v63: (arg0: void) => Array<any>, unitVar: void): Array<any> {
    let v64;
    const matchValue = v62.ui_modal | 0;
    v64 = ((matchValue === (void 0)) ? -2 : matchValue);
    const v73 = (): Array<any> => closure29(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v60, v61, void 0);
    const v79 = "6px";
    const v87 = createObj(method5(new Heap1(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, new US5(1, v73), v13_1, v14_1, v15_1, new US3(1, "row"), ((v64 > 0) && ((v64 === v56) !== true)) ? (new US3(1, "none")) : (new US3(0)), v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, new US3(1, "absolute"), new US3(1, v79), v46, new US3(1, "3px"), v48, v49, v50, v51, new US3(1, v79), v53, new US0(1, 1))));
    const v90 = createComponent;
    return [v90(Stack, v87), v59() ? <></> : v63];
}

export function closure27(v0_1: Heap1, v1_1: US1, v2_1: US1, v3_1: US2, v4_1: US3, v5_1: US4, v6_1: US3, v7_1: US3, v8_1: US3, v9_1: US3, v10_1: US3, v11_1: US3, v12_1: US1, v13_1: US5, v14_1: US3, v15_1: US3, v16_1: US1, v17_1: US3, v18_1: US3, v19_1: US1, v20_1: US3, v21_1: US3, v22_1: US3, v23_1: US3, v24_1: US3, v25_1: US6, v26_1: US3, v27_1: US3, v28_1: US3, v29_1: US7, v30_1: US3, v31_1: US3, v32_1: US3, v33_1: US3, v34: US3, v35: US8, v36: US9, v37: US3, v38: US3, v39: US3, v40: US3, v41: US3, v42: US3, v43: US3, v44: US3, v45: US3, v46: US3, v47: US3, v48: US3, v49: US1, v50: US3, v51: US3, v52: US6, v53: US3, v54: US3, v55: US0, v56: any, v57: int32, v58: (arg0: boolean) => void, v59: (arg0: boolean) => void, v60: (arg0: void) => boolean, v61: (arg0: boolean) => void, v62: (arg0: void) => boolean, v63: any, unitVar: void): Array<any> {
    let v73: (arg0: void) => Array<any>, v81: any, matchValue: int32, v84: any;
    const v64 = v0_1.l12;
    return [(v64.tag === 1) ? ((v73 = ((): Array<any> => closure28(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64.fields[0], void 0)), (v81 = createObj(method5(new Heap1(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, new US5(1, v73), v14_1, v15_1, v16_1, v17_1, new US3(1, "flex"), v19_1, new US3(1, "1"), v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, (((matchValue = (v63.ui_modal | 0), (matchValue === (void 0)) ? -2 : matchValue)) <= 0) ? (new US3(1, "relative")) : (new US3(0)), v46, v47, v48, v49, v50, v51, v52, v53, v54, v55))), (v84 = createComponent, v84(Box, v81))))) : <></>];
}

export function closure23(v0_1: Heap1, v1_1: US1, v2_1: US1, v3_1: US2, v4_1: US3, v5_1: US4, v6_1: US3, v7_1: US3, v8_1: US3, v9_1: US3, v10_1: US3, v11_1: US3, v12_1: US1, v13_1: US5, v14_1: US3, v15_1: US3, v16_1: US1, v17_1: US3, v18_1: US3, v19_1: US1, v20_1: US3, v21_1: US3, v22_1: US3, v23_1: US3, v24_1: US3, v25_1: US6, v26_1: US3, v27_1: US3, v28_1: US3, v29_1: US7, v30_1: US3, v31_1: US3, v32_1: US3, v33_1: US3, v34: US3, v35: US8, v36: US9, v37: US3, v38: US3, v39: US3, v40: US3, v41: US3, v42: US3, v43: US3, v44: US3, v45: US3, v46: US3, v47: US3, v48: US3, v49: US1, v50: US3, v51: US3, v52: US6, v53: US3, v54: US3, v55: US0, v56: any, v57: int32, v58: (arg0: boolean) => void, v59: (arg0: void) => boolean, v60: (arg0: boolean) => void, v61: (arg0: void) => boolean, v62: (arg0: boolean) => void, v63: (arg0: void) => boolean, v64: any, unitVar: void): Array<any> {
    let v67: (arg0: void) => Array<any>, v73: any, v76: any, v83: US0, v88: US3, v93: US3, v98: US3, v103: US3, v108: US3, v114: (arg0: void) => Array<any>, v122: any, v125: any;
    return [(v59() === false) ? ((v67 = ((): Array<any> => closure24(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v58, v0_1, v56, v64, void 0)), (v73 = createObj(method5(new Heap1(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, new US5(1, v67), v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, new US3(1, "4px 0"), v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55))), (v76 = createComponent, v76(Box, v73))))) : ((v83 = (v63() ? (new US0(1, 1)) : (new US0(0))), (v88 = (v63() ? (new US3(1, "absolute")) : (new US3(0))), (v93 = (v63() ? (new US3(1, "0")) : (new US3(0))), (v98 = (v63() ? (new US3(1, "0")) : (new US3(0))), (v103 = (v63() ? (new US3(1, "0")) : (new US3(0))), (v108 = (v63() ? (new US3(1, "0")) : (new US3(0))), (v114 = ((): Array<any> => closure27(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v60, v61, v62, v63, v64, void 0)), (v122 = createObj(method5(new Heap1(v1_1, v2_1, v3_1, v4_1, v5_1, v63() ? (new US3(1, "$bg")) : (new US3(0)), v7_1, v8_1, v9_1, v10_1, v103, v12_1, new US5(1, v114), v14_1, v15_1, v16_1, v17_1, new US3(1, "flex"), v19_1, new US3(1, "1"), v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v108, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v88, v98, v47, v48, v49, v50, v51, v52, v93, v54, v83))), (v125 = createComponent, v125(Box, v122)))))))))))];
}

export function method23(v0_1: Heap1): any {
    const patternInput = method3();
    const v9_1 = patternInput[8];
    const v8_1 = patternInput[7];
    const v7_1 = patternInput[6];
    const v6_1 = patternInput[5];
    const v55 = patternInput[54];
    const v54 = patternInput[53];
    const v53 = patternInput[52];
    const v52 = patternInput[51];
    const v51 = patternInput[50];
    const v50 = patternInput[49];
    const v5_1 = patternInput[4];
    const v49 = patternInput[48];
    const v48 = patternInput[47];
    const v47 = patternInput[46];
    const v46 = patternInput[45];
    const v45 = patternInput[44];
    const v44 = patternInput[43];
    const v43 = patternInput[42];
    const v42 = patternInput[41];
    const v41 = patternInput[40];
    const v40 = patternInput[39];
    const v4_1 = patternInput[3];
    const v39 = patternInput[38];
    const v38 = patternInput[37];
    const v37 = patternInput[36];
    const v36 = patternInput[35];
    const v35 = patternInput[34];
    const v34 = patternInput[33];
    const v33_1 = patternInput[32];
    const v32_1 = patternInput[31];
    const v31_1 = patternInput[30];
    const v30_1 = patternInput[29];
    const v3_1 = patternInput[2];
    const v29_1 = patternInput[28];
    const v28_1 = patternInput[27];
    const v27_1 = patternInput[26];
    const v25_1 = patternInput[24];
    const v24_1 = patternInput[23];
    const v23_1 = patternInput[22];
    const v22_1 = patternInput[21];
    const v21_1 = patternInput[20];
    const v2_1 = patternInput[1];
    const v19_1 = patternInput[18];
    const v17_1 = patternInput[16];
    const v16_1 = patternInput[15];
    const v15_1 = patternInput[14];
    const v14_1 = patternInput[13];
    const v12_1 = patternInput[11];
    const v11_1 = patternInput[10];
    const v10_1 = patternInput[9];
    const v1_1 = patternInput[0];
    const v58 = useStoreon;
    const v59 = v58();
    const v60 = v59[0];
    const v61 = v59[1];
    const v62 = nonSeeded().Next0() | 0;
    const v63 = v0_1.l0;
    const v65 = (v63.tag === 1) && v63.fields[0];
    const v68 = createSignal;
    const v69 = v68(v65);
    let v70;
    const value_4 = v69[0];
    v70 = (value_4);
    let v71;
    const value_5 = v69[1];
    v71 = ((arg_1: boolean): void => {
        value_5(arg_1);
    });
    const v72 = createSignal;
    const v73 = v72(false);
    let v74;
    const value_7 = v73[0];
    v74 = (value_7);
    let v75;
    const value_8 = v73[1];
    v75 = ((arg_3: boolean): void => {
        value_8(arg_3);
    });
    const v76 = v0_1.l1;
    const v78 = (v76.tag === 1) && v76.fields[0];
    const v79 = createSignal;
    const v80 = v79(v78);
    let v81;
    const value_10 = v80[0];
    v81 = (value_10);
    let v82;
    const value_11 = v80[1];
    v82 = ((arg_5: boolean): void => {
        value_11(arg_5);
    });
    const v84 = on;
    const v85 = (): Array<boolean> => closure20(v74, void 0);
    const v86 = (): void => {
        closure21(v75, v74, void 0);
    };
    const v87 = v84(v85, v86);
    const v89 = createEffect;
    v89(v87);
    if ((v63.tag === 1) && (v63.fields[0] === true)) {
        const v94 = v0_1.l2;
        if (v94.tag === 1) {
            const v97 = (v: any): void => {
                closure22(v61, v);
            };
            v94.fields[0](v60, v97);
        }
    }
    const v99 = (): Array<any> => closure23(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, patternInput[12], v14_1, v15_1, v16_1, v17_1, patternInput[17], v19_1, patternInput[19], v21_1, v22_1, v23_1, v24_1, v25_1, patternInput[25], v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v61, v62, v71, v70, v75, v74, v82, v81, v60, void 0);
    const v107 = createObj(method5(new Heap1(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, new US5(1, v99), v14_1, v15_1, v16_1, v17_1, new US3(1, "flex"), v19_1, new US3(1, "1"), v21_1, v22_1, v23_1, v24_1, v25_1, v0_1.l25, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55)));
    const v109 = createComponent;
    return v109(Box, v107);
}

export function closure19(unitVar: void, v0_1: Heap1): any {
    return method23(v0_1);
}

export function closure18(v0_1: Heap1, v1_1: US1, v2_1: US1, v3_1: US2, v4_1: US3, v5_1: US4, v6_1: US3, v7_1: US3, v8_1: US3, v9_1: US3, v10_1: US3, v11_1: US3, v12_1: US1, v13_1: US5, v14_1: US3, v15_1: US3, v16_1: US1, v17_1: US3, v18_1: US3, v19_1: US1, v20_1: US3, v21_1: US3, v22_1: US3, v23_1: US3, v24_1: US3, v25_1: US6, v26_1: US3, v27_1: US3, v28_1: US3, v29_1: US7, v30_1: US3, v31_1: US3, v32_1: US3, v33_1: US3, v34: US3, v35: US8, v36: US9, v37: US3, v38: US3, v39: US3, v40: US3, v41: US3, v42: US3, v43: US3, v44: US3, v45: US3, v46: US3, v47: US3, v48: US3, v49: US1, v50: US3, v51: US3, v52: US6, v53: US3, v54: US3, v55: US0, v56: (arg0: void) => boolean, v57: (arg0: void) => Array<any>, unitVar: void): Array<any> {
    let v63: (arg0: Heap1) => any, v67: Heap1, v70: any;
    return [(v0_1.l48.tag === 1) ? (v56() ? ((v63 = ((v: Heap1): any => closure19(void 0, v)), (v67 = (new Heap1(new US1(1, true), v2_1, v0_1.l2, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, new US5(1, v57), v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55)), (v70 = createComponent, v70(v63, v67))))) : <></>) : v57];
}

export function closure12(v0_1: Heap1, v1_1: US1, v2_1: US1, v3_1: US2, v4_1: US3, v5_1: US4, v6_1: US3, v7_1: US3, v8_1: US3, v9_1: US3, v10_1: US3, v11_1: US3, v12_1: US1, v13_1: US5, v14_1: US3, v15_1: US3, v16_1: US1, v17_1: US3, v18_1: US3, v19_1: US1, v20_1: US3, v21_1: US3, v22_1: US3, v23_1: US3, v24_1: US3, v25_1: US6, v26_1: US3, v27_1: US3, v28_1: US3, v29_1: US7, v30_1: US3, v31_1: US3, v32_1: US3, v33_1: US3, v34: US3, v35: US8, v36: US9, v37: US3, v38: US3, v39: US3, v40: US3, v41: US3, v42: US3, v43: US3, v44: US3, v45: US3, v46: US3, v47: US3, v48: US3, v49: US1, v50: US3, v51: US3, v52: US6, v53: US3, v54: US3, v55: US0, v56: (arg0: boolean) => void, v57: (arg0: void) => boolean, unitVar: void): Array<any> {
    let v75: (arg0: void) => Array<any>, v89: any, v92: any, v115: US3, v119: string, v121: (arg0: void) => Array<any>, v142: any, v145: any, v98: string, v100: (arg0: void) => Array<any>, v107: any, v110: any;
    const v58 = v0_1.l51;
    const v97 = v0_1.l12;
    return [(v58.tag === 1) ? ((v75 = ((): Array<any> => closure13(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58.fields[0], void 0)), (v89 = createObj(method5(new Heap1(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, ((v0_1.l48.tag === 0) ? true : v57()) ? (new US3(1, {
        "@initial": "2px !important",
        "@sm": "0px !important",
    })) : (new US3(1, "0px !important")), new US3(1, "$neutral5"), v10_1, v11_1, v12_1, new US5(1, v75), new US3(1, "$neutral9"), v15_1, v16_1, v17_1, new US3(1, "flex"), v19_1, v20_1, new US3(1, "column"), new US3(1, "$sm"), v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, new US3(1, "3px 20px 0 8px"), v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55))), (v92 = createComponent, v92(Td, v89))))) : <></>, (v97.tag === 1) ? ((v115 = v0_1.l39, (v119 = "0", (v121 = ((): Array<any> => closure18(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v57, v97.fields[0], void 0)), (v142 = createObj(method5(new Heap1(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, new US3(1, v119), v8_1, v9_1, v10_1, v11_1, v12_1, new US5(1, v121), v14_1, v15_1, v16_1, v17_1, new US3(1, "flex"), v19_1, new US3(1, "6"), new US3(1, "column"), new US3(1, "$sm"), v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, new US3(1, "$base"), new US3(1, v119), v32_1, v33_1, new US3(1, "85vh"), v35, v36, new US3(1, v119), v38, new US3(1, "auto"), new US3(1, (v115.tag === 1) ? v115.fields[0] : "0"), v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55))), (v145 = createComponent, v145(Td, v142))))))) : ((v98 = "0", (v100 = ((): Array<any> => closure17(void 0, void 0)), (v107 = createObj(method5(new Heap1(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, new US3(1, v98), v8_1, v9_1, v10_1, v11_1, v12_1, new US5(1, v100), v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, new US3(1, "9px"), v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, new US3(1, v98), v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55))), (v110 = createComponent, v110(Td, v107))))))];
}

export function method22(v0_1: Heap1): any {
    const patternInput = method3();
    const v8_1 = patternInput[7];
    const v7_1 = patternInput[6];
    const v6_1 = patternInput[5];
    const v55 = patternInput[54];
    const v54 = patternInput[53];
    const v53 = patternInput[52];
    const v52 = patternInput[51];
    const v51 = patternInput[50];
    const v50 = patternInput[49];
    const v5_1 = patternInput[4];
    const v49 = patternInput[48];
    const v48 = patternInput[47];
    const v47 = patternInput[46];
    const v46 = patternInput[45];
    const v45 = patternInput[44];
    const v44 = patternInput[43];
    const v43 = patternInput[42];
    const v42 = patternInput[41];
    const v41 = patternInput[40];
    const v40 = patternInput[39];
    const v4_1 = patternInput[3];
    const v39 = patternInput[38];
    const v38 = patternInput[37];
    const v37 = patternInput[36];
    const v36 = patternInput[35];
    const v35 = patternInput[34];
    const v34 = patternInput[33];
    const v33_1 = patternInput[32];
    const v32_1 = patternInput[31];
    const v31_1 = patternInput[30];
    const v30_1 = patternInput[29];
    const v3_1 = patternInput[2];
    const v29_1 = patternInput[28];
    const v28_1 = patternInput[27];
    const v27_1 = patternInput[26];
    const v25_1 = patternInput[24];
    const v24_1 = patternInput[23];
    const v23_1 = patternInput[22];
    const v22_1 = patternInput[21];
    const v2_1 = patternInput[1];
    const v19_1 = patternInput[18];
    const v17_1 = patternInput[16];
    const v16_1 = patternInput[15];
    const v15_1 = patternInput[14];
    const v14_1 = patternInput[13];
    const v12_1 = patternInput[11];
    const v11_1 = patternInput[10];
    const v1_1 = patternInput[0];
    const v56 = v0_1.l48;
    const v61 = ((v56.tag === 1) && (v56.fields[0] === false)) !== true;
    const v64 = createSignal;
    const v65 = v64(v61);
    let v66;
    const value_1 = v65[0];
    v66 = (value_1);
    let v67;
    const value_2 = v65[1];
    v67 = ((arg_1: boolean): void => {
        value_2(arg_1);
    });
    const v76 = (): Array<any> => closure12(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, patternInput[8], patternInput[9], v11_1, v12_1, patternInput[12], v14_1, v15_1, v16_1, v17_1, patternInput[17], v19_1, patternInput[19], patternInput[20], v22_1, v23_1, v24_1, v25_1, patternInput[25], v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v67, v66, void 0);
    const v85 = createObj(method5(new Heap1(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, new US3(1, "$neutral5"), new US3(1, "1px 2px"), v11_1, v12_1, new US5(1, v76), v14_1, v15_1, v16_1, v17_1, new US3(1, "flex"), v19_1, new US3(1, "1"), new US3(1, {
        "@initial": "column",
        "@sm": "row",
    }), v22_1, v23_1, v24_1, v25_1, v0_1.l25, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55)));
    const v87 = createComponent;
    return v87(Tr, v85);
}

export function closure11(unitVar: void, v0_1: Heap1): any {
    return method22(v0_1);
}

export function closure33(v0_1: US1, v1_1: US1, v2_1: US2, v3_1: US3, v4_1: US4, v5_1: US3, v6_1: US3, v7_1: US3, v8_1: US3, v9_1: US3, v10_1: US3, v11_1: US1, v12_1: US5, v13_1: US3, v14_1: US3, v15_1: US1, v16_1: US3, v17_1: US3, v18_1: US1, v19_1: US3, v20_1: US3, v21_1: US3, v22_1: US3, v23_1: US3, v24_1: US6, v25_1: US3, v26_1: US3, v27_1: US3, v28_1: US7, v29_1: US3, v30_1: US3, v31_1: US3, v32_1: US3, v33_1: US3, v34: US8, v35: US9, v36: US3, v37: US3, v38: US3, v39: US3, v40: US3, v41: US3, v42: US3, v43: US3, v44: US3, v45: US3, v46: US3, v47: US3, v48: US1, v49: US3, v50: US3, v51: US6, v52: US3, v53: US3, v54: US0, unitVar: void): Array<any> {
    const v55 = (v: Heap1): any => closure6(void 0, v);
    const v59 = new Heap1(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, new US3(1, "https://github.com/fc1943s/tictactoe_spiral"), v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);
    const v62 = createComponent;
    return [v62(v55, v59)];
}

export function closure34(v0_1: US1, v1_1: US1, v2_1: US2, v3_1: US3, v4_1: US4, v5_1: US3, v6_1: US3, v7_1: US3, v8_1: US3, v9_1: US3, v10_1: US3, v11_1: US1, v12_1: US5, v13_1: US3, v14_1: US3, v15_1: US1, v16_1: US3, v17_1: US3, v18_1: US1, v19_1: US3, v20_1: US3, v21_1: US3, v22_1: US3, v23_1: US3, v24_1: US6, v25_1: US3, v26_1: US3, v27_1: US3, v28_1: US7, v29_1: US3, v30_1: US3, v31_1: US3, v32_1: US3, v33_1: US3, v34: US8, v35: US9, v36: US3, v37: US3, v38: US3, v39: US3, v40: US3, v41: US3, v42: US3, v43: US3, v44: US3, v45: US3, v46: US3, v47: US3, v48: US1, v49: US3, v50: US3, v51: US6, v52: US3, v53: US3, v54: US0, unitVar: void): Array<any> {
    const v55 = (v: Heap1): any => closure6(void 0, v);
    const v59 = new Heap1(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, new US3(1, "https://fc1943s.github.io/tictactoe_spiral"), v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);
    const v62 = createComponent;
    return [v62(v55, v59)];
}

export function closure35(v0_1: US1, v1_1: US1, v2_1: US2, v3_1: US3, v4_1: US4, v5_1: US3, v6_1: US3, v7_1: US3, v8_1: US3, v9_1: US3, v10_1: US3, v11_1: US1, v12_1: US5, v13_1: US3, v14_1: US3, v15_1: US1, v16_1: US3, v17_1: US3, v18_1: US1, v19_1: US3, v20_1: US3, v21_1: US3, v22_1: US3, v23_1: US3, v24_1: US6, v25_1: US3, v26_1: US3, v27_1: US3, v28_1: US7, v29_1: US3, v30_1: US3, v31_1: US3, v32_1: US3, v33_1: US3, v34: US8, v35: US9, v36: US3, v37: US3, v38: US3, v39: US3, v40: US3, v41: US3, v42: US3, v43: US3, v44: US3, v45: US3, v46: US3, v47: US3, v48: US1, v49: US3, v50: US3, v51: US6, v52: US3, v53: US3, v54: US0, unitVar: void): Array<any> {
    const v55 = (v: Heap1): any => closure6(void 0, v);
    const v59 = new Heap1(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, new US3(1, "https://fc1943s.github.io/tictactoe_spiral/docs"), v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);
    const v62 = createComponent;
    return [v62(v55, v59)];
}

export function closure10(v0_1: US1, v1_1: US1, v2_1: US2, v3_1: US3, v4_1: US4, v5_1: US3, v6_1: US3, v7_1: US3, v8_1: US3, v9_1: US3, v10_1: US3, v11_1: US1, v12_1: US5, v13_1: US3, v14_1: US3, v15_1: US1, v16_1: US3, v17_1: US3, v18_1: US1, v19_1: US3, v20_1: US3, v21_1: US3, v22_1: US3, v23_1: US3, v24_1: US6, v25_1: US3, v26_1: US3, v27_1: US3, v28_1: US7, v29_1: US3, v30_1: US3, v31_1: US3, v32_1: US3, v33_1: US3, v34: US8, v35: US9, v36: US3, v37: US3, v38: US3, v39: US3, v40: US3, v41: US3, v42: US3, v43: US3, v44: US3, v45: US3, v46: US3, v47: US3, v48: US1, v49: US3, v50: US3, v51: US6, v52: US3, v53: US3, v54: US0, unitVar: void): Array<any> {
    const v55 = (v: Heap1): any => closure11(void 0, v);
    const v57 = (): Array<any> => closure33(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, void 0);
    const v59 = "1px 6px";
    const v61 = new Heap1(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, new US5(1, v57), v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, new US3(1, v59), v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);
    const v64 = createComponent;
    const v67 = (): Array<any> => closure34(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, void 0);
    const v70 = new Heap1(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, new US5(1, v67), v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, new US3(1, v59), v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);
    const v71 = createComponent;
    const v74 = (): Array<any> => closure35(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, void 0);
    const v77 = new Heap1(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, new US5(1, v74), v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, new US3(1, v59), v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);
    const v78 = createComponent;
    return [v64(v55, v61), v71(v55, v70), v78(v55, v77)];
}

export function method21(): any {
    const patternInput = method3();
    const v9_1 = patternInput[9];
    const v8_1 = patternInput[8];
    const v7_1 = patternInput[7];
    const v6_1 = patternInput[6];
    const v54 = patternInput[54];
    const v53 = patternInput[53];
    const v52 = patternInput[52];
    const v51 = patternInput[51];
    const v50 = patternInput[50];
    const v5_1 = patternInput[5];
    const v49 = patternInput[49];
    const v48 = patternInput[48];
    const v47 = patternInput[47];
    const v46 = patternInput[46];
    const v45 = patternInput[45];
    const v44 = patternInput[44];
    const v43 = patternInput[43];
    const v42 = patternInput[42];
    const v41 = patternInput[41];
    const v40 = patternInput[40];
    const v4_1 = patternInput[4];
    const v39 = patternInput[39];
    const v38 = patternInput[38];
    const v37 = patternInput[37];
    const v36 = patternInput[36];
    const v35 = patternInput[35];
    const v34 = patternInput[34];
    const v33_1 = patternInput[33];
    const v32_1 = patternInput[32];
    const v31_1 = patternInput[31];
    const v30_1 = patternInput[30];
    const v3_1 = patternInput[3];
    const v29_1 = patternInput[29];
    const v28_1 = patternInput[28];
    const v27_1 = patternInput[27];
    const v26_1 = patternInput[26];
    const v25_1 = patternInput[25];
    const v24_1 = patternInput[24];
    const v23_1 = patternInput[23];
    const v22_1 = patternInput[22];
    const v21_1 = patternInput[21];
    const v20_1 = patternInput[20];
    const v2_1 = patternInput[2];
    const v19_1 = patternInput[19];
    const v18_1 = patternInput[18];
    const v17_1 = patternInput[17];
    const v16_1 = patternInput[16];
    const v15_1 = patternInput[15];
    const v14_1 = patternInput[14];
    const v13_1 = patternInput[13];
    const v11_1 = patternInput[11];
    const v10_1 = patternInput[10];
    const v1_1 = patternInput[1];
    const v0_1 = patternInput[0];
    const v55 = (v: Heap1): any => closure2(void 0, v);
    const v57 = (): Array<any> => closure10(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, patternInput[12], v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, void 0);
    const v59 = new Heap1(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, new US5(1, v57), v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);
    const v62 = createComponent;
    return v62(v55, v59);
}

export function closure9(unitVar: void, unitVar_1: void): any {
    return method21();
}

export const v0 = void 0;

export const v1 = new Mut0(v0);

export const v2 = method0();

export const v3 = new Heap0(v2);

export const v4 = v3;

export const v5 = method1(v4);

export const v6 = "base_button";

export const v7 = (v: Heap1): any => closure1(void 0, v);

export const v8 = [v6, v7];

export const v9 = "base_table";

export const v10 = (v: Heap1): any => closure2(void 0, v);

export const v11 = [v9, v10];

export const v12 = "create_obj_props";

export const v13 = (v: Array<[string, any]>): Heap1 => closure4(void 0, v);

export const v14 = [v12, v13];

export const v15 = "create_storeon";

export const v16 = (v: any): any => closure5(void 0, v);

export const v17 = [v15, v16];

export const v18 = "external_link";

export const v19 = (v: Heap1): any => closure6(void 0, v);

export const v20 = [v18, v19];

export const v21 = "links";

export const v22 = (): any => closure9(void 0, void 0);

export const v23 = [v21, v22];

export const v24 = "loader";

export const v25 = (v: Heap1): any => closure19(void 0, v);

export const v26 = [v24, v25];

export const v27 = "row";

export const v28 = (v: Heap1): any => closure11(void 0, v);

export const v29 = [v27, v28];

export const v30 = "store";

export const v31 = [v30, v5];

export const v32 = [v8, v11, v14, v17, v20, v23, v26, v29, v31];

export const v33 = createObj(v32);

v1.l0 = v33;


