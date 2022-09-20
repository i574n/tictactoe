import { Union, Record } from "./fable_modules/fable-library.4.0.0-theta-003/Types.js";
import { tuple_type, class_type, string_type, lambda_type, unit_type, bool_type, union_type, int32_type, record_type, obj_type, TypeInfo } from "./fable_modules/fable-library.4.0.0-theta-003/Reflection.js";
import { int32 } from "./fable_modules/fable-library.4.0.0-theta-003/Int32.js";
import { createStoreon } from "storeon";
import { fill } from "./fable_modules/fable-library.4.0.0-theta-003/Array.js";
import { uncurry, equals, createObj } from "./fable_modules/fable-library.4.0.0-theta-003/Util.js";
import { createEffect, on, createSignal, createComponent } from "solid-js";
import { Tr, Td, Stack, IconButton, Checkbox, Box, Anchor, Icon, Table, Tbody, Button } from "@hope-ui/solid";
import { BiRegularUndo, BiRegularUpArrow, BiRegularDownArrow, BiRegularRefresh, BiRegularLinkExternal } from "solid-icons/bi";
import { useStoreon } from "@storeon/solidjs";
import { nonSeeded } from "./fable_modules/fable-library.4.0.0-theta-003/Random.js";
import { defaultArg } from "./fable_modules/fable-library.4.0.0-theta-003/Option.js";

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
    return union_type("Components_spi.US5", [], US5, () => [[], [["f1_0", lambda_type(unit_type, class_type("Fable.Core.JSX.Element"))]]]);
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
    l8: US1;
    l9: US5;
    l10: US3;
    l11: US3;
    l12: US1;
    l13: US3;
    l14: US3;
    l15: US1;
    l16: US0;
    l17: US3;
    l18: US3;
    l19: US3;
    l20: US3;
    l21: US6;
    l22: US3;
    l23: US3;
    l24: US3;
    l25: US7;
    l26: US3;
    l27: US3;
    l28: US3;
    l29: US3;
    l30: US8;
    l31: US9;
    l32: US3;
    l33: US3;
    l34: US3;
    l35: US3;
    l36: US3;
    l37: US3;
    l38: US3;
    l39: US3;
    l40: US1;
    l41: US3;
    l42: US3;
    l43: US6;
    l44: US3;
    l45: US3;
    l46: US0;
    constructor(l0: US1, l1: US1, l2: US2, l3: US3, l4: US4, l5: US3, l6: US3, l7: US3, l8: US1, l9: US5, l10: US3, l11: US3, l12: US1, l13: US3, l14: US3, l15: US1, l16: US0, l17: US3, l18: US3, l19: US3, l20: US3, l21: US6, l22: US3, l23: US3, l24: US3, l25: US7, l26: US3, l27: US3, l28: US3, l29: US3, l30: US8, l31: US9, l32: US3, l33: US3, l34: US3, l35: US3, l36: US3, l37: US3, l38: US3, l39: US3, l40: US1, l41: US3, l42: US3, l43: US6, l44: US3, l45: US3, l46: US0) {
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
    }
}

export function Heap1$reflection(): TypeInfo {
    return record_type("Components_spi.Heap1", [], Heap1, () => [["l0", US1$reflection()], ["l1", US1$reflection()], ["l2", US2$reflection()], ["l3", US3$reflection()], ["l4", US4$reflection()], ["l5", US3$reflection()], ["l6", US3$reflection()], ["l7", US3$reflection()], ["l8", US1$reflection()], ["l9", US5$reflection()], ["l10", US3$reflection()], ["l11", US3$reflection()], ["l12", US1$reflection()], ["l13", US3$reflection()], ["l14", US3$reflection()], ["l15", US1$reflection()], ["l16", US0$reflection()], ["l17", US3$reflection()], ["l18", US3$reflection()], ["l19", US3$reflection()], ["l20", US3$reflection()], ["l21", US6$reflection()], ["l22", US3$reflection()], ["l23", US3$reflection()], ["l24", US3$reflection()], ["l25", US7$reflection()], ["l26", US3$reflection()], ["l27", US3$reflection()], ["l28", US3$reflection()], ["l29", US3$reflection()], ["l30", US8$reflection()], ["l31", US9$reflection()], ["l32", US3$reflection()], ["l33", US3$reflection()], ["l34", US3$reflection()], ["l35", US3$reflection()], ["l36", US3$reflection()], ["l37", US3$reflection()], ["l38", US3$reflection()], ["l39", US3$reflection()], ["l40", US1$reflection()], ["l41", US3$reflection()], ["l42", US3$reflection()], ["l43", US6$reflection()], ["l44", US3$reflection()], ["l45", US3$reflection()], ["l46", US0$reflection()]]);
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
    l9: US1;
    l10: US5;
    l11: US3;
    l12: US3;
    l13: US1;
    l14: US3;
    l15: US3;
    l16: US1;
    l17: US0;
    l18: US3;
    l19: US3;
    l20: US3;
    l21: US3;
    l22: US6;
    l23: US3;
    l24: US3;
    l25: US3;
    l26: US7;
    l27: US3;
    l28: US3;
    l29: US3;
    l30: US3;
    l31: US8;
    l32: US9;
    l33: US3;
    l34: US3;
    l35: US3;
    l36: US3;
    l37: US3;
    l38: US3;
    l39: US3;
    l40: US3;
    l41: US1;
    l42: US3;
    l43: US3;
    l44: US6;
    l45: US3;
    l46: US3;
    l47: US0;
    constructor(l0: int32, l1: US1, l2: US1, l3: US2, l4: US3, l5: US4, l6: US3, l7: US3, l8: US3, l9: US1, l10: US5, l11: US3, l12: US3, l13: US1, l14: US3, l15: US3, l16: US1, l17: US0, l18: US3, l19: US3, l20: US3, l21: US3, l22: US6, l23: US3, l24: US3, l25: US3, l26: US7, l27: US3, l28: US3, l29: US3, l30: US3, l31: US8, l32: US9, l33: US3, l34: US3, l35: US3, l36: US3, l37: US3, l38: US3, l39: US3, l40: US3, l41: US1, l42: US3, l43: US3, l44: US6, l45: US3, l46: US3, l47: US0) {
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
    }
}

export function Mut3$reflection(): TypeInfo {
    return record_type("Components_spi.Mut3", [], Mut3, () => [["l0", int32_type], ["l1", US1$reflection()], ["l2", US1$reflection()], ["l3", US2$reflection()], ["l4", US3$reflection()], ["l5", US4$reflection()], ["l6", US3$reflection()], ["l7", US3$reflection()], ["l8", US3$reflection()], ["l9", US1$reflection()], ["l10", US5$reflection()], ["l11", US3$reflection()], ["l12", US3$reflection()], ["l13", US1$reflection()], ["l14", US3$reflection()], ["l15", US3$reflection()], ["l16", US1$reflection()], ["l17", US0$reflection()], ["l18", US3$reflection()], ["l19", US3$reflection()], ["l20", US3$reflection()], ["l21", US3$reflection()], ["l22", US6$reflection()], ["l23", US3$reflection()], ["l24", US3$reflection()], ["l25", US3$reflection()], ["l26", US7$reflection()], ["l27", US3$reflection()], ["l28", US3$reflection()], ["l29", US3$reflection()], ["l30", US3$reflection()], ["l31", US8$reflection()], ["l32", US9$reflection()], ["l33", US3$reflection()], ["l34", US3$reflection()], ["l35", US3$reflection()], ["l36", US3$reflection()], ["l37", US3$reflection()], ["l38", US3$reflection()], ["l39", US3$reflection()], ["l40", US3$reflection()], ["l41", US1$reflection()], ["l42", US3$reflection()], ["l43", US3$reflection()], ["l44", US6$reflection()], ["l45", US3$reflection()], ["l46", US3$reflection()], ["l47", US0$reflection()]]);
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

export function method3(): [US1, US1, US2, US3, US4, US3, US3, US3, US1, US5, US3, US3, US1, US3, US3, US1, US0, US3, US3, US3, US3, US6, US3, US3, US3, US7, US3, US3, US3, US3, US8, US9, US3, US3, US3, US3, US3, US3, US3, US3, US1, US3, US3, US6, US3, US3, US0] {
    return [new US1(0), new US1(0), new US2(0), new US3(0), new US4(0), new US3(0), new US3(0), new US3(0), new US1(0), new US5(0), new US3(0), new US3(0), new US1(0), new US3(0), new US3(0), new US1(0), new US0(0), new US3(0), new US3(0), new US3(0), new US3(0), new US6(0), new US3(0), new US3(0), new US3(0), new US7(0), new US3(0), new US3(0), new US3(0), new US3(0), new US8(0), new US9(0), new US3(0), new US3(0), new US3(0), new US3(0), new US3(0), new US3(0), new US3(0), new US3(0), new US1(0), new US3(0), new US3(0), new US6(0), new US3(0), new US3(0), new US0(0)];
}

export function method4(v0_1: Heap1, v1_1: US1, v2_1: US1, v3_1: US2, v4_1: US3, v5_1: US4, v6_1: US3, v7_1: US3, v8_1: US3, v9_1: US1, v10_1: US5, v11_1: US3, v12_1: US3, v13_1: US1, v14_1: US3, v15_1: US3, v16_1: US1, v17_1: US0, v18_1: US3, v19_1: US3, v20_1: US3, v21_1: US3, v22_1: US6, v23_1: US3, v24_1: US3, v25_1: US3, v26_1: US7, v27_1: US3, v28_1: US3, v29_1: US3, v30_1: US3, v31_1: US8, v32_1: US9, v33_1: US3, v34: US3, v35: US3, v36: US3, v37: US3, v38: US3, v39: US3, v40: US3, v41: US1, v42: US3, v43: US3, v44: US6, v45: US3, v46: US3, v47: US0): Heap1 {
    const v48 = new Heap1(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);
    const v49 = v0_1.l0;
    const v50 = v48.l0;
    const v57 = (v50.tag === 1) ? (new US1(1, v50.fields[0])) : ((v49.tag === 1) ? (new US1(1, v49.fields[0])) : (new US1(0)));
    const v58 = v0_1.l1;
    const v59 = v48.l1;
    const v66 = (v59.tag === 1) ? (new US1(1, v59.fields[0])) : ((v58.tag === 1) ? (new US1(1, v58.fields[0])) : (new US1(0)));
    const v67 = v0_1.l2;
    const v68 = v48.l2;
    const v75 = (v68.tag === 1) ? (new US2(1, v68.fields[0])) : ((v67.tag === 1) ? (new US2(1, v67.fields[0])) : (new US2(0)));
    const v76 = v0_1.l3;
    const v77 = v48.l3;
    const v84 = (v77.tag === 1) ? (new US3(1, v77.fields[0])) : ((v76.tag === 1) ? (new US3(1, v76.fields[0])) : (new US3(0)));
    const v85 = v0_1.l4;
    const v86 = v48.l4;
    const v93 = (v86.tag === 1) ? (new US4(1, v86.fields[0])) : ((v85.tag === 1) ? (new US4(1, v85.fields[0])) : (new US4(0)));
    const v94 = v0_1.l5;
    const v95 = v48.l5;
    const v102 = (v95.tag === 1) ? (new US3(1, v95.fields[0])) : ((v94.tag === 1) ? (new US3(1, v94.fields[0])) : (new US3(0)));
    const v103 = v0_1.l6;
    const v104 = v48.l6;
    const v111 = (v104.tag === 1) ? (new US3(1, v104.fields[0])) : ((v103.tag === 1) ? (new US3(1, v103.fields[0])) : (new US3(0)));
    const v112 = v0_1.l7;
    const v113 = v48.l7;
    const v120 = (v113.tag === 1) ? (new US3(1, v113.fields[0])) : ((v112.tag === 1) ? (new US3(1, v112.fields[0])) : (new US3(0)));
    const v121 = v0_1.l10;
    const v122 = v48.l10;
    const v129 = (v122.tag === 1) ? (new US3(1, v122.fields[0])) : ((v121.tag === 1) ? (new US3(1, v121.fields[0])) : (new US3(0)));
    const v130 = v0_1.l8;
    const v131 = v48.l8;
    const v138 = (v131.tag === 1) ? (new US1(1, v131.fields[0])) : ((v130.tag === 1) ? (new US1(1, v130.fields[0])) : (new US1(0)));
    const v139 = v0_1.l9;
    const v140 = v48.l9;
    const v147 = (v140.tag === 1) ? (new US5(1, v140.fields[0])) : ((v139.tag === 1) ? (new US5(1, v139.fields[0])) : (new US5(0)));
    const v148 = v0_1.l11;
    const v149 = v48.l11;
    const v156 = (v149.tag === 1) ? (new US3(1, v149.fields[0])) : ((v148.tag === 1) ? (new US3(1, v148.fields[0])) : (new US3(0)));
    const v157 = v0_1.l12;
    const v158 = v48.l12;
    const v165 = (v158.tag === 1) ? (new US1(1, v158.fields[0])) : ((v157.tag === 1) ? (new US1(1, v157.fields[0])) : (new US1(0)));
    const v166 = v0_1.l13;
    const v167 = v48.l13;
    const v174 = (v167.tag === 1) ? (new US3(1, v167.fields[0])) : ((v166.tag === 1) ? (new US3(1, v166.fields[0])) : (new US3(0)));
    const v175 = v0_1.l14;
    const v176 = v48.l14;
    const v183 = (v176.tag === 1) ? (new US3(1, v176.fields[0])) : ((v175.tag === 1) ? (new US3(1, v175.fields[0])) : (new US3(0)));
    const v184 = v0_1.l15;
    const v185 = v48.l15;
    const v192 = (v185.tag === 1) ? (new US1(1, v185.fields[0])) : ((v184.tag === 1) ? (new US1(1, v184.fields[0])) : (new US1(0)));
    const v193 = v0_1.l16;
    const v194 = v48.l16;
    const v201 = (v194.tag === 1) ? (new US0(1, v194.fields[0])) : ((v193.tag === 1) ? (new US0(1, v193.fields[0])) : (new US0(0)));
    const v202 = v0_1.l17;
    const v203 = v48.l17;
    const v210 = (v203.tag === 1) ? (new US3(1, v203.fields[0])) : ((v202.tag === 1) ? (new US3(1, v202.fields[0])) : (new US3(0)));
    const v211 = v0_1.l18;
    const v212 = v48.l18;
    const v219 = (v212.tag === 1) ? (new US3(1, v212.fields[0])) : ((v211.tag === 1) ? (new US3(1, v211.fields[0])) : (new US3(0)));
    const v220 = v0_1.l19;
    const v221 = v48.l19;
    const v228 = (v221.tag === 1) ? (new US3(1, v221.fields[0])) : ((v220.tag === 1) ? (new US3(1, v220.fields[0])) : (new US3(0)));
    const v229 = v0_1.l20;
    const v230 = v48.l20;
    const v237 = (v230.tag === 1) ? (new US3(1, v230.fields[0])) : ((v229.tag === 1) ? (new US3(1, v229.fields[0])) : (new US3(0)));
    const v238 = v0_1.l21;
    const v239 = v48.l21;
    const v246 = (v239.tag === 1) ? (new US6(1, v239.fields[0])) : ((v238.tag === 1) ? (new US6(1, v238.fields[0])) : (new US6(0)));
    const v247 = v0_1.l22;
    const v248 = v48.l22;
    const v255 = (v248.tag === 1) ? (new US3(1, v248.fields[0])) : ((v247.tag === 1) ? (new US3(1, v247.fields[0])) : (new US3(0)));
    const v256 = v0_1.l40;
    const v257 = v48.l40;
    const v264 = (v257.tag === 1) ? (new US1(1, v257.fields[0])) : ((v256.tag === 1) ? (new US1(1, v256.fields[0])) : (new US1(0)));
    const v265 = v0_1.l23;
    const v266 = v48.l23;
    const v274 = v0_1.l24;
    const v275 = v48.l24;
    const v283 = v0_1.l25;
    const v284 = v48.l25;
    const v292 = v0_1.l26;
    const v293 = v48.l26;
    const v301 = v0_1.l27;
    const v302 = v48.l27;
    const v310 = v0_1.l28;
    const v311 = v48.l28;
    const v319 = v0_1.l29;
    const v320 = v48.l29;
    const v328 = v0_1.l30;
    const v329 = v48.l30;
    const v337 = v0_1.l31;
    const v338 = v48.l31;
    const v346 = v0_1.l32;
    const v347 = v48.l32;
    const v355 = v0_1.l33;
    const v356 = v48.l33;
    const v364 = v0_1.l34;
    const v365 = v48.l34;
    const v373 = v0_1.l35;
    const v374 = v48.l35;
    const v382 = v0_1.l36;
    const v383 = v48.l36;
    const v391 = v0_1.l37;
    const v392 = v48.l37;
    const v400 = v0_1.l38;
    const v401 = v48.l38;
    const v409 = v0_1.l39;
    const v410 = v48.l39;
    const v418 = v0_1.l41;
    const v419 = v48.l41;
    const v427 = v0_1.l42;
    const v428 = v48.l42;
    const v436 = v0_1.l43;
    const v437 = v48.l43;
    const v445 = v0_1.l44;
    const v446 = v48.l44;
    const v454 = v0_1.l45;
    const v455 = v48.l45;
    const v463 = v0_1.l46;
    const v464 = v48.l46;
    return new Heap1(v57, v66, v75, v84, v93, v102, v111, v120, v138, v147, v129, v156, v165, v174, v183, v192, v201, v210, v219, v228, v237, v246, v255, (v266.tag === 1) ? (new US3(1, v266.fields[0])) : ((v265.tag === 1) ? (new US3(1, v265.fields[0])) : (new US3(0))), (v275.tag === 1) ? (new US3(1, v275.fields[0])) : ((v274.tag === 1) ? (new US3(1, v274.fields[0])) : (new US3(0))), (v284.tag === 1) ? (new US7(1, v284.fields[0])) : ((v283.tag === 1) ? (new US7(1, v283.fields[0])) : (new US7(0))), (v293.tag === 1) ? (new US3(1, v293.fields[0])) : ((v292.tag === 1) ? (new US3(1, v292.fields[0])) : (new US3(0))), (v302.tag === 1) ? (new US3(1, v302.fields[0])) : ((v301.tag === 1) ? (new US3(1, v301.fields[0])) : (new US3(0))), (v311.tag === 1) ? (new US3(1, v311.fields[0])) : ((v310.tag === 1) ? (new US3(1, v310.fields[0])) : (new US3(0))), (v320.tag === 1) ? (new US3(1, v320.fields[0])) : ((v319.tag === 1) ? (new US3(1, v319.fields[0])) : (new US3(0))), (v329.tag === 1) ? (new US8(1, v329.fields[0])) : ((v328.tag === 1) ? (new US8(1, v328.fields[0])) : (new US8(0))), (v338.tag === 1) ? (new US9(1, v338.fields[0])) : ((v337.tag === 1) ? (new US9(1, v337.fields[0])) : (new US9(0))), (v347.tag === 1) ? (new US3(1, v347.fields[0])) : ((v346.tag === 1) ? (new US3(1, v346.fields[0])) : (new US3(0))), (v356.tag === 1) ? (new US3(1, v356.fields[0])) : ((v355.tag === 1) ? (new US3(1, v355.fields[0])) : (new US3(0))), (v365.tag === 1) ? (new US3(1, v365.fields[0])) : ((v364.tag === 1) ? (new US3(1, v364.fields[0])) : (new US3(0))), (v374.tag === 1) ? (new US3(1, v374.fields[0])) : ((v373.tag === 1) ? (new US3(1, v373.fields[0])) : (new US3(0))), (v383.tag === 1) ? (new US3(1, v383.fields[0])) : ((v382.tag === 1) ? (new US3(1, v382.fields[0])) : (new US3(0))), (v392.tag === 1) ? (new US3(1, v392.fields[0])) : ((v391.tag === 1) ? (new US3(1, v391.fields[0])) : (new US3(0))), (v401.tag === 1) ? (new US3(1, v401.fields[0])) : ((v400.tag === 1) ? (new US3(1, v400.fields[0])) : (new US3(0))), (v410.tag === 1) ? (new US3(1, v410.fields[0])) : ((v409.tag === 1) ? (new US3(1, v409.fields[0])) : (new US3(0))), v264, (v419.tag === 1) ? (new US3(1, v419.fields[0])) : ((v418.tag === 1) ? (new US3(1, v418.fields[0])) : (new US3(0))), (v428.tag === 1) ? (new US3(1, v428.fields[0])) : ((v427.tag === 1) ? (new US3(1, v427.fields[0])) : (new US3(0))), (v437.tag === 1) ? (new US6(1, v437.fields[0])) : ((v436.tag === 1) ? (new US6(1, v436.fields[0])) : (new US6(0))), (v446.tag === 1) ? (new US3(1, v446.fields[0])) : ((v445.tag === 1) ? (new US3(1, v445.fields[0])) : (new US3(0))), (v455.tag === 1) ? (new US3(1, v455.fields[0])) : ((v454.tag === 1) ? (new US3(1, v454.fields[0])) : (new US3(0))), (v464.tag === 1) ? (new US0(1, v464.fields[0])) : ((v463.tag === 1) ? (new US0(1, v463.fields[0])) : (new US0(0))));
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

export function method10(v0_1: string, v1_1: US0): US10 {
    if (v1_1.tag === 1) {
        return new US10(1, [v0_1, v1_1.fields[0]]);
    }
    else {
        return new US10(0);
    }
}

export function method11(v0_1: string, v1_1: US6): US10 {
    if (v1_1.tag === 1) {
        return new US10(1, [v0_1, v1_1.fields[0]]);
    }
    else {
        return new US10(0);
    }
}

export function method12(v0_1: string, v1_1: US7): US10 {
    if (v1_1.tag === 1) {
        return new US10(1, [v0_1, v1_1.fields[0]]);
    }
    else {
        return new US10(0);
    }
}

export function method13(v0_1: string, v1_1: US8): US10 {
    if (v1_1.tag === 1) {
        return new US10(1, [v0_1, v1_1.fields[0]]);
    }
    else {
        return new US10(0);
    }
}

export function method14(v0_1: string, v1_1: US9): US10 {
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
    const v133 = [method6("aria-label", v0_1.l3), method7("as", v0_1.l4), method6("backgroundColor", v0_1.l5), method6("border", v0_1.l6), method6("bottom", v0_1.l7), method6("color", v0_1.l10), method8("checked", v0_1.l8), method9("children", v0_1.l9), method6("colorScheme", v0_1.l11), method8("compact", v0_1.l12), method6("display", v0_1.l14), method6("direction", v0_1.l13), method8("external", v0_1.l15), method10("flex", v0_1.l16), method6("flexDirection", v0_1.l17), method6("fontSize", v0_1.l18), method6("height", v0_1.l19), method6("href", v0_1.l20), method11("icon", v0_1.l21), method6("id", v0_1.l22), method6("justifyContent", v0_1.l23), method6("left", v0_1.l24), method12("leftIcon", v0_1.l25), method6("lineHeight", v0_1.l26), method6("margin", v0_1.l27), method6("marginBottom", v0_1.l28), method6("maxHeight", v0_1.l29), method13("onChange", v0_1.l30), method14("onClick", v0_1.l31), method6("outline", v0_1.l32), method6("overflowY", v0_1.l33), method6("padding", v0_1.l34), method6("paddingTop", v0_1.l35), method6("position", v0_1.l36), method6("right", v0_1.l37), method6("size", v0_1.l38), method6("spacing", v0_1.l39), method8("status", v0_1.l40), method6("striped", v0_1.l41), method6("thickness", v0_1.l42), method11("title", v0_1.l43), method6("top", v0_1.l44), method6("width", v0_1.l45), method10("zIndex", v0_1.l46)];
    const v134 = v133.length | 0;
    const v135 = fill(new Array(v134), 0, v134, null);
    const v136 = new Mut1(0, 0);
    while (method15(v134, v136)) {
        const v138 = v136.l0 | 0;
        const v139 = v136.l1 | 0;
        const v140 = v133[v138];
        let v144;
        if (v140.tag === 1) {
            v135[v139] = v140;
            v144 = (v139 + 1);
        }
        else {
            v144 = v139;
        }
        const v145 = (v138 + 1) | 0;
        v136.l0 = (v145 | 0);
        v136.l1 = (v144 | 0);
    }
    const v146 = v136.l1 | 0;
    const v147 = fill(new Array(v146), 0, v146, null);
    const v148 = new Mut2(0);
    while (method16(v146, v148)) {
        const v150 = v148.l0 | 0;
        const v151 = v135[v150];
        v147[v150] = v151;
        const v152 = (v150 + 1) | 0;
        v148.l0 = (v152 | 0);
    }
    const v153 = v147.length | 0;
    const v154 = fill(new Array(v153), 0, v153, null);
    const v155 = new Mut2(0);
    while (method16(v153, v155)) {
        const v157 = v155.l0 | 0;
        const v158 = v147[v157];
        let v161;
        if (v158.tag === 1) {
            v161 = v158.fields[0];
        }
        else {
            throw new Error("Option does not have a value.");
        }
        v154[v157] = v161;
        const v162 = (v157 + 1) | 0;
        v155.l0 = (v162 | 0);
    }
    return v154;
}

export function method2(v0_1: Heap1): any {
    const patternInput = method3();
    const v58 = createObj(method5(method4(v0_1, patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], new US3(1, "neutral"), new US1(1, true), patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], new US3(1, "left"), patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], new US3(1, "xs"), patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46])));
    const v61 = createComponent;
    return v61(Button, v58);
}

export function closure1(unitVar: void, v0_1: Heap1): any {
    return method2(v0_1);
}

export function closure3(v0_1: Heap1, v1_1: US1, v2_1: US1, v3_1: US2, v4_1: US3, v5_1: US4, v6_1: US3, v7_1: US3, v8_1: US3, v9_1: US1, v10_1: US5, v11_1: US3, v12_1: US3, v13_1: US1, v14_1: US3, v15_1: US3, v16_1: US1, v17_1: US0, v18_1: US3, v19_1: US3, v20_1: US3, v21_1: US3, v22_1: US6, v23_1: US3, v24_1: US3, v25_1: US3, v26_1: US7, v27_1: US3, v28_1: US3, v29_1: US3, v30_1: US3, v31_1: US8, v32_1: US9, v33_1: US3, v34: US3, v35: US3, v36: US3, v37: US3, v38: US3, v39: US3, v40: US3, v41: US1, v42: US3, v43: US3, v44: US6, v45: US3, v46: US3, v47: US0, unitVar: void): any {
    const v55 = createObj(method5(new Heap1(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v0_1.l9, v11_1, v12_1, v13_1, v14_1, new US3(1, "flex"), v16_1, v17_1, new US3(1, "column"), v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47)));
    const v58 = createComponent;
    return [v58(Tbody, v55)];
}

export function method17(v0_1: Heap1): any {
    const patternInput = method3();
    const v9_1 = patternInput[8];
    const v8_1 = patternInput[7];
    const v7_1 = patternInput[6];
    const v6_1 = patternInput[5];
    const v5_1 = patternInput[4];
    const v47 = patternInput[46];
    const v46 = patternInput[45];
    const v45 = patternInput[44];
    const v44 = patternInput[43];
    const v43 = patternInput[42];
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
    const v16_1 = patternInput[15];
    const v14_1 = patternInput[13];
    const v13_1 = patternInput[12];
    const v12_1 = patternInput[11];
    const v11_1 = patternInput[10];
    const v1_1 = patternInput[0];
    const v48 = (): any => closure3(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, patternInput[9], v11_1, v12_1, v13_1, v14_1, patternInput[14], v16_1, patternInput[16], patternInput[17], v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, patternInput[41], v43, v44, v45, v46, v47, void 0);
    const v59 = createObj(method5(new Heap1(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, new US5(1, v48), v11_1, v12_1, v13_1, v14_1, new US3(1, "flex"), v16_1, new US0(1, 1), new US3(1, "column"), v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, new US3(1, "odd"), v43, v44, v45, v46, v47)));
    const v62 = createComponent;
    return v62(Table, v59);
}

export function closure2(unitVar: void, v0_1: Heap1): any {
    return method17(v0_1);
}

export function method19(v0_1: int32, v1_1: Mut3): boolean {
    return v1_1.l0 < v0_1;
}

export function method18(v0_1: Array<[string, any]>): Heap1 {
    const patternInput = method3();
    const v48 = v0_1.length | 0;
    const v49 = new Mut3(0, patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43], patternInput[44], patternInput[45], patternInput[46]);
    while (method19(v48, v49)) {
        const v51 = v49.l0 | 0;
        const patternInput_1 = [v49.l1, v49.l2, v49.l3, v49.l4, v49.l5, v49.l6, v49.l7, v49.l8, v49.l9, v49.l10, v49.l11, v49.l12, v49.l13, v49.l14, v49.l15, v49.l16, v49.l17, v49.l18, v49.l19, v49.l20, v49.l21, v49.l22, v49.l23, v49.l24, v49.l25, v49.l26, v49.l27, v49.l28, v49.l29, v49.l30, v49.l31, v49.l32, v49.l33, v49.l34, v49.l35, v49.l36, v49.l37, v49.l38, v49.l39, v49.l40, v49.l41, v49.l42, v49.l43, v49.l44, v49.l45, v49.l46, v49.l47];
        const v98 = patternInput_1[46];
        const v97 = patternInput_1[45];
        const v96 = patternInput_1[44];
        const v95 = patternInput_1[43];
        const v94 = patternInput_1[42];
        const v93 = patternInput_1[41];
        const v92 = patternInput_1[40];
        const v91 = patternInput_1[39];
        const v90 = patternInput_1[38];
        const v89 = patternInput_1[37];
        const v88 = patternInput_1[36];
        const v87 = patternInput_1[35];
        const v86 = patternInput_1[34];
        const v85 = patternInput_1[33];
        const v84 = patternInput_1[32];
        const v83 = patternInput_1[31];
        const v82 = patternInput_1[30];
        const v81 = patternInput_1[29];
        const v80 = patternInput_1[28];
        const v79 = patternInput_1[27];
        const v78 = patternInput_1[26];
        const v77 = patternInput_1[25];
        const v76 = patternInput_1[24];
        const v75 = patternInput_1[23];
        const v74 = patternInput_1[22];
        const v73 = patternInput_1[21];
        const v72 = patternInput_1[20];
        const v71 = patternInput_1[19];
        const v70 = patternInput_1[18];
        const v69 = patternInput_1[17];
        const v68 = patternInput_1[16];
        const v67 = patternInput_1[15];
        const v66 = patternInput_1[14];
        const v65 = patternInput_1[13];
        const v64 = patternInput_1[12];
        const v63 = patternInput_1[11];
        const v62 = patternInput_1[10];
        const v61 = patternInput_1[9];
        const v60 = patternInput_1[8];
        const v59 = patternInput_1[7];
        const v58 = patternInput_1[6];
        const v57 = patternInput_1[5];
        const v56 = patternInput_1[4];
        const v55 = patternInput_1[3];
        const v54 = patternInput_1[2];
        const v53 = patternInput_1[1];
        const v52 = patternInput_1[0];
        const patternInput_2 = v0_1[v51];
        const v99 = patternInput_2[0];
        const v100 = patternInput_2[1];
        let patternInput_3;
        if (equals(v100, void 0)) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("_loaded" === v99) {
            patternInput_3 = [new US1(1, v100), v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("_modal" === v99) {
            patternInput_3 = [v52, new US1(1, v100), v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("_on_load" === v99) {
            patternInput_3 = [v52, v53, new US2(1, uncurry(2, v100)), v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("aria-label" === v99) {
            patternInput_3 = [v52, v53, v54, new US3(1, v100), v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("as" === v99) {
            patternInput_3 = [v52, v53, v54, v55, new US4(1, v100), v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("backgroundColor" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, new US3(1, v100), v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("border" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, new US3(1, v100), v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("bottom" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, new US3(1, v100), v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("color" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, new US3(1, v100), v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("checked" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, new US1(1, v100), v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("children" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, new US5(1, v100), v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("colorScheme" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, new US3(1, v100), v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("compact" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, new US1(1, v100), v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("display" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, new US3(1, v100), v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("direction" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, new US3(1, v100), v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("external" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, new US1(1, v100), v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("flex" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, new US0(1, v100), v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("flexDirection" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, new US3(1, v100), v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("fontSize" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, new US3(1, v100), v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("height" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, new US3(1, v100), v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("href" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, new US3(1, v100), v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("icon" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, new US6(1, v100), v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("id" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, new US3(1, v100), v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("justifyContent" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, new US3(1, v100), v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("left" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, new US3(1, v100), v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("leftIcon" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, new US7(1, v100), v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("lineHeight" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, new US3(1, v100), v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("margin" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, new US3(1, v100), v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("marginBottom" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, new US3(1, v100), v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("maxHeight" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, new US3(1, v100), v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("onChange" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, new US8(1, v100), v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("onClick" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, new US9(1, v100), v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("outline" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, new US3(1, v100), v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("overflowY" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, new US3(1, v100), v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("padding" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, new US3(1, v100), v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("paddingTop" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, new US3(1, v100), v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("position" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, new US3(1, v100), v89, v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("right" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, new US3(1, v100), v90, v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("size" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, new US3(1, v100), v91, v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("spacing" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, new US3(1, v100), v92, v93, v94, v95, v96, v97, v98];
        }
        else if ("status" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, new US1(1, v100), v93, v94, v95, v96, v97, v98];
        }
        else if ("striped" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, new US3(1, v100), v94, v95, v96, v97, v98];
        }
        else if ("thickness" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, new US3(1, v100), v95, v96, v97, v98];
        }
        else if ("title" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, new US6(1, v100), v96, v97, v98];
        }
        else if ("top" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, new US3(1, v100), v97, v98];
        }
        else if ("width" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, new US3(1, v100), v98];
        }
        else if ("zIndex" === v99) {
            patternInput_3 = [v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, new US0(1, v100)];
        }
        else {
            throw new Error(`unknown prop: ${v99} = ${v100}`);
        }
        const v2547 = (v51 + 1) | 0;
        v49.l0 = (v2547 | 0);
        v49.l1 = patternInput_3[0];
        v49.l2 = patternInput_3[1];
        v49.l3 = patternInput_3[2];
        v49.l4 = patternInput_3[3];
        v49.l5 = patternInput_3[4];
        v49.l6 = patternInput_3[5];
        v49.l7 = patternInput_3[6];
        v49.l8 = patternInput_3[7];
        v49.l9 = patternInput_3[8];
        v49.l10 = patternInput_3[9];
        v49.l11 = patternInput_3[10];
        v49.l12 = patternInput_3[11];
        v49.l13 = patternInput_3[12];
        v49.l14 = patternInput_3[13];
        v49.l15 = patternInput_3[14];
        v49.l16 = patternInput_3[15];
        v49.l17 = patternInput_3[16];
        v49.l18 = patternInput_3[17];
        v49.l19 = patternInput_3[18];
        v49.l20 = patternInput_3[19];
        v49.l21 = patternInput_3[20];
        v49.l22 = patternInput_3[21];
        v49.l23 = patternInput_3[22];
        v49.l24 = patternInput_3[23];
        v49.l25 = patternInput_3[24];
        v49.l26 = patternInput_3[25];
        v49.l27 = patternInput_3[26];
        v49.l28 = patternInput_3[27];
        v49.l29 = patternInput_3[28];
        v49.l30 = patternInput_3[29];
        v49.l31 = patternInput_3[30];
        v49.l32 = patternInput_3[31];
        v49.l33 = patternInput_3[32];
        v49.l34 = patternInput_3[33];
        v49.l35 = patternInput_3[34];
        v49.l36 = patternInput_3[35];
        v49.l37 = patternInput_3[36];
        v49.l38 = patternInput_3[37];
        v49.l39 = patternInput_3[38];
        v49.l40 = patternInput_3[39];
        v49.l41 = patternInput_3[40];
        v49.l42 = patternInput_3[41];
        v49.l43 = patternInput_3[42];
        v49.l44 = patternInput_3[43];
        v49.l45 = patternInput_3[44];
        v49.l46 = patternInput_3[45];
        v49.l47 = patternInput_3[46];
    }
    const patternInput_4 = [v49.l1, v49.l2, v49.l3, v49.l4, v49.l5, v49.l6, v49.l7, v49.l8, v49.l9, v49.l10, v49.l11, v49.l12, v49.l13, v49.l14, v49.l15, v49.l16, v49.l17, v49.l18, v49.l19, v49.l20, v49.l21, v49.l22, v49.l23, v49.l24, v49.l25, v49.l26, v49.l27, v49.l28, v49.l29, v49.l30, v49.l31, v49.l32, v49.l33, v49.l34, v49.l35, v49.l36, v49.l37, v49.l38, v49.l39, v49.l40, v49.l41, v49.l42, v49.l43, v49.l44, v49.l45, v49.l46, v49.l47];
    return new Heap1(patternInput_4[0], patternInput_4[1], patternInput_4[2], patternInput_4[3], patternInput_4[4], patternInput_4[5], patternInput_4[6], patternInput_4[7], patternInput_4[8], patternInput_4[9], patternInput_4[10], patternInput_4[11], patternInput_4[12], patternInput_4[13], patternInput_4[14], patternInput_4[15], patternInput_4[16], patternInput_4[17], patternInput_4[18], patternInput_4[19], patternInput_4[20], patternInput_4[21], patternInput_4[22], patternInput_4[23], patternInput_4[24], patternInput_4[25], patternInput_4[26], patternInput_4[27], patternInput_4[28], patternInput_4[29], patternInput_4[30], patternInput_4[31], patternInput_4[32], patternInput_4[33], patternInput_4[34], patternInput_4[35], patternInput_4[36], patternInput_4[37], patternInput_4[38], patternInput_4[39], patternInput_4[40], patternInput_4[41], patternInput_4[42], patternInput_4[43], patternInput_4[44], patternInput_4[45], patternInput_4[46]);
}

export function closure4(unitVar: void, v0_1: Array<[string, any]>): Heap1 {
    return method18(v0_1);
}

export function closure5(unitVar: void, v0_1: any): any {
    return method1(v0_1);
}

export function closure7(v0_1: Heap1, v1_1: US1, v2_1: US1, v3_1: US2, v4_1: US3, v5_1: US4, v6_1: US3, v7_1: US3, v8_1: US3, v9_1: US1, v10_1: US5, v11_1: US3, v12_1: US3, v13_1: US1, v14_1: US3, v15_1: US3, v16_1: US1, v17_1: US0, v18_1: US3, v19_1: US3, v20_1: US3, v21_1: US3, v22_1: US6, v23_1: US3, v24_1: US3, v25_1: US3, v26_1: US7, v27_1: US3, v28_1: US3, v29_1: US3, v30_1: US3, v31_1: US8, v32_1: US9, v33_1: US3, v34: US3, v35: US3, v36: US3, v37: US3, v38: US3, v39: US3, v40: US3, v41: US1, v42: US3, v43: US3, v44: US6, v45: US3, v46: US3, v47: US0, unitVar: void): any {
    const v48 = v0_1.l20;
    const v52 = <>
        {(v48.tag === 1) ? v48.fields[0] : ""}
    </>;
    const v54 = <>
        &nbsp;
    </>;
    const v57 = BiRegularLinkExternal;
    const v61 = createObj(method5(new Heap1(v1_1, v2_1, v3_1, v4_1, new US4(1, v57), v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47)));
    const v64 = createComponent;
    return [v52, v54, v64(Icon, v61)];
}

export function method20(v0_1: Heap1): any {
    const patternInput = method3();
    const v9_1 = patternInput[8];
    const v8_1 = patternInput[7];
    const v7_1 = patternInput[6];
    const v6_1 = patternInput[5];
    const v5_1 = patternInput[4];
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
    const v15_1 = patternInput[14];
    const v14_1 = patternInput[13];
    const v13_1 = patternInput[12];
    const v12_1 = patternInput[11];
    const v11_1 = patternInput[10];
    const v1_1 = patternInput[0];
    const v48 = (): any => closure7(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, patternInput[9], v11_1, v12_1, v13_1, v14_1, v15_1, patternInput[15], v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, void 0);
    const v54 = createObj(method5(method4(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, new US5(1, v48), v11_1, v12_1, v13_1, v14_1, v15_1, new US1(1, true), v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47)));
    const v57 = createComponent;
    return v57(Anchor, v54);
}

export function closure6(unitVar: void, v0_1: Heap1): any {
    return method20(v0_1);
}

export function method23(v0_1: boolean): [(arg0: void) => boolean, (arg0: boolean) => void] {
    let value_1: any, value_2: any;
    const v3_1 = createSignal;
    const v4_1 = v3_1(v0_1);
    return [(value_1 = v4_1[0], value_1), (value_2 = v4_1[1], (arg_1: boolean): void => {
        value_2(arg_1);
    })];
}

export function closure14(v0_1: any, unitVar: void): any {
    return [v0_1];
}

export function closure13(v0_1: US1, v1_1: US1, v2_1: US2, v3_1: US3, v4_1: US4, v5_1: US3, v6_1: US3, v7_1: US3, v8_1: US1, v9_1: US5, v10_1: US3, v11_1: US3, v12_1: US1, v13_1: US3, v14_1: US3, v15_1: US1, v16_1: US0, v17_1: US3, v18_1: US3, v19_1: US3, v20_1: US3, v21_1: US6, v22_1: US3, v23_1: US3, v24_1: US3, v25_1: US7, v26_1: US3, v27_1: US3, v28_1: US3, v29_1: US3, v30_1: US8, v31_1: US9, v32_1: US3, v33_1: US3, v34: US3, v35: US3, v36: US3, v37: US3, v38: US3, v39: US3, v40: US1, v41: US3, v42: US3, v43: US6, v44: US3, v45: US3, v46: US0, v47: any, unitVar: void): any {
    const v48 = (): any => closure14(v47, void 0);
    const v54 = createObj(method5(new Heap1(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, new US5(1, v48), v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, new US3(1, "2px"), v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46)));
    const v57 = createComponent;
    return [v57(Box, v54)];
}

export function closure15(v0_1: (arg0: boolean) => void, v1_1: any): void {
    v0_1(v1_1.target.checked);
}

export function closure12(v0_1: Heap1, v1_1: US1, v2_1: US1, v3_1: US2, v4_1: US3, v5_1: US4, v6_1: US3, v7_1: US3, v8_1: US3, v9_1: US1, v10_1: US5, v11_1: US3, v12_1: US3, v13_1: US1, v14_1: US3, v15_1: US3, v16_1: US1, v17_1: US0, v18_1: US3, v19_1: US3, v20_1: US3, v21_1: US3, v22_1: US6, v23_1: US3, v24_1: US3, v25_1: US3, v26_1: US7, v27_1: US3, v28_1: US3, v29_1: US3, v30_1: US3, v31_1: US8, v32_1: US9, v33_1: US3, v34: US3, v35: US3, v36: US3, v37: US3, v38: US3, v39: US3, v40: US3, v41: US1, v42: US3, v43: US3, v44: US6, v45: US3, v46: US3, v47: US0, v48: (arg0: boolean) => void, v49: (arg0: void) => boolean, v50: any, unitVar: void): any {
    let v55: (arg0: void) => any, v61: (arg0: any) => void, v67: any, v70: any;
    return [(v0_1.l40.tag === 1) ? ((v55 = ((): any => closure13(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v50, void 0)), (v61 = ((v: any): void => {
        closure15(v48, v);
    }), (v67 = createObj(method5(new Heap1(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, new US1(1, v49()), new US5(1, v55), v11_1, new US3(1, "neutral"), v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, new US3(1, "2px"), v30_1, new US8(1, v61), v32_1, v33_1, v34, v35, v36, v37, v38, new US3(1, "sm"), v40, v41, v42, v43, v44, v45, v46, v47))), (v70 = createComponent, v70(Checkbox, v67)))))) : v50];
}

export function closure16(unitVar: void, unitVar_1: void): any {
    return [<>
        &nbsp;
    </>];
}

export function closure18(unitVar: void, unitVar_1: void): any {
    return <></>;
}

export function closure20(v0_1: any, v1_1: any): void {
    v0_1("set", v1_1);
}

export function method25(): [any, (arg0: any) => void] {
    const v2_1 = useStoreon;
    const v3_1 = v2_1();
    const v4_1 = v3_1[0];
    const v5_1 = v3_1[1];
    const v6_1 = (v: any): void => {
        closure20(v5_1, v);
    };
    return [v4_1, v6_1];
}

export function closure21(v0_1: (arg0: void) => boolean, unitVar: void): Array<boolean> {
    return [v0_1()];
}

export function closure22(v0_1: (arg0: boolean) => void, v1_1: (arg0: void) => boolean, unitVar: void): void {
    if (v1_1()) {
        v0_1(false);
    }
}

export function closure25(unitVar: void, unitVar_1: void): any {
    return [<>
        Load
    </>];
}

export function closure26(v0_1: (arg0: boolean) => void, v1_1: Heap1, v2_1: (arg0: any) => void, v3_1: any, unitVar: void): void {
    const v4_1 = v1_1.l2;
    if (v4_1.tag === 1) {
        v4_1.fields[0](v3_1, v2_1);
    }
    v0_1(true);
}

export function method26(v0_1: (arg0: Heap1) => any, v1_1: US1, v2_1: US1, v3_1: US2, v4_1: US3, v5_1: US4, v6_1: US3, v7_1: US3, v8_1: US3, v9_1: US1, v10_1: US5, v11_1: US3, v12_1: US3, v13_1: US1, v14_1: US3, v15_1: US3, v16_1: US1, v17_1: US0, v18_1: US3, v19_1: US3, v20_1: US3, v21_1: US3, v22_1: US6, v23_1: US3, v24_1: US3, v25_1: US3, v26_1: US7, v27_1: US3, v28_1: US3, v29_1: US3, v30_1: US3, v31_1: US8, v32_1: US9, v33_1: US3, v34: US3, v35: US3, v36: US3, v37: US3, v38: US3, v39: US3, v40: US3, v41: US1, v42: US3, v43: US3, v44: US6, v45: US3, v46: US3, v47: US0): any {
    const v49 = new Heap1(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);
    const v52 = createComponent;
    return v52(v0_1, v49);
}

export function closure24(v0_1: US1, v1_1: US1, v2_1: US2, v3_1: US3, v4_1: US4, v5_1: US3, v6_1: US3, v7_1: US3, v8_1: US1, v9_1: US5, v10_1: US3, v11_1: US3, v12_1: US1, v13_1: US3, v14_1: US3, v15_1: US1, v16_1: US0, v17_1: US3, v18_1: US3, v19_1: US3, v20_1: US3, v21_1: US6, v22_1: US3, v23_1: US3, v24_1: US3, v25_1: US7, v26_1: US3, v27_1: US3, v28_1: US3, v29_1: US3, v30_1: US8, v31_1: US9, v32_1: US3, v33_1: US3, v34: US3, v35: US3, v36: US3, v37: US3, v38: US3, v39: US3, v40: US1, v41: US3, v42: US3, v43: US6, v44: US3, v45: US3, v46: US0, v47: (arg0: boolean) => void, v48: Heap1, v49: (arg0: any) => void, v50: any, unitVar: void): any {
    const v51 = (v: Heap1): any => closure1(void 0, v);
    const v52 = (): any => closure25(void 0, void 0);
    const v54 = (): void => {
        closure26(v47, v48, v49, v50, void 0);
    };
    return [method26(v51, v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, new US5(1, v52), v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, new US9(1, v54), v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46)];
}

export function method27(v0_1: any, v1_1: US1, v2_1: US1, v3_1: US2, v4_1: US3, v5_1: US4, v6_1: US3, v7_1: US3, v8_1: US3, v9_1: US1, v10_1: US5, v11_1: US3, v12_1: US3, v13_1: US1, v14_1: US3, v15_1: US3, v16_1: US1, v17_1: US0, v18_1: US3, v19_1: US3, v20_1: US3, v21_1: US3, v22_1: US6, v23_1: US3, v24_1: US3, v25_1: US3, v26_1: US7, v27_1: US3, v28_1: US3, v29_1: US3, v30_1: US3, v31_1: US8, v32_1: US9, v33_1: US3, v34: US3, v35: US3, v36: US3, v37: US3, v38: US3, v39: US3, v40: US3, v41: US1, v42: US3, v43: US3, v44: US6, v45: US3, v46: US3, v47: US0): any {
    const v49 = new Heap1(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);
    const v52 = createComponent;
    return v52(v0_1, v49);
}

export function closure30(v0_1: (arg0: boolean) => void, unitVar: void): void {
    v0_1(true);
}

export function method28(v0_1: US0): Array<[string, any]> {
    const v3_1 = [method10("ui_modal", v0_1)];
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

export function closure31(v0_1: (arg0: any) => void, v1_1: int32, v2_1: (arg0: boolean) => void, v3_1: (arg0: void) => boolean, unitVar: void): void {
    const v5_1 = v3_1() === false;
    v2_1(v5_1);
    v0_1(createObj(method28(v5_1 ? (new US0(1, v1_1)) : (new US0(1, -3)))));
}

export function closure32(v0_1: (arg0: boolean) => void, unitVar: void): void {
    v0_1(false);
}

export function closure29(v0_1: US1, v1_1: US1, v2_1: US2, v3_1: US3, v4_1: US4, v5_1: US3, v6_1: US3, v7_1: US3, v8_1: US1, v9_1: US5, v10_1: US3, v11_1: US3, v12_1: US1, v13_1: US3, v14_1: US3, v15_1: US1, v16_1: US0, v17_1: US3, v18_1: US3, v19_1: US3, v20_1: US3, v21_1: US6, v22_1: US3, v23_1: US3, v24_1: US3, v25_1: US7, v26_1: US3, v27_1: US3, v28_1: US3, v29_1: US3, v30_1: US8, v31_1: US9, v32_1: US3, v33_1: US3, v34: US3, v35: US3, v36: US3, v37: US3, v38: US3, v39: US3, v40: US1, v41: US3, v42: US3, v43: US6, v44: US3, v45: US3, v46: US0, v47: (arg0: any) => void, v48: int32, v49: (arg0: boolean) => void, v50: (arg0: boolean) => void, v51: (arg0: boolean) => void, v52: (arg0: void) => boolean, unitVar: void): any {
    let v85: any, v87: any;
    const v55 = BiRegularRefresh;
    const v56 = "14px";
    const v61 = "neutral";
    const v63 = "20px";
    const v66 = (): void => {
        closure30(v50, void 0);
    };
    const v68 = "xs";
    const v72 = createObj(method5(new Heap1(v0_1, v1_1, v2_1, new US3(1, "Refresh"), v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, new US3(1, v61), v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, new US3(1, v63), v20_1, new US6(1, method27(v55, v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, new US3(1, v56), v39, v40, v41, v42, v43, v44, v45, v46)), v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, new US9(1, v66), v32_1, v33_1, v34, v35, v36, v37, new US3(1, v68), v39, v40, v41, v42, v43, v44, v45, v46)));
    const v75 = createComponent;
    const v78 = v75(IconButton, v72);
    const v95 = (): void => {
        closure31(v47, v48, v51, v52, void 0);
    };
    const v100 = createObj(method5(new Heap1(v0_1, v1_1, v2_1, new US3(1, v52() ? "Restore" : "Maximize"), v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, new US3(1, v61), v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, new US3(1, v63), v20_1, new US6(1, method27(v52() ? ((v85 = BiRegularDownArrow, v85)) : ((v87 = BiRegularUpArrow, v87)), v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, new US3(1, v56), v39, v40, v41, v42, v43, v44, v45, v46)), v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, new US9(1, v95), v32_1, v33_1, v34, v35, v36, v37, new US3(1, v68), v39, v40, v41, v42, v43, v44, v45, v46)));
    const v101 = createComponent;
    const v102 = v101(IconButton, v100);
    const v104 = BiRegularUndo;
    const v112 = (): void => {
        closure32(v49, void 0);
    };
    const v117 = createObj(method5(new Heap1(v0_1, v1_1, v2_1, new US3(1, "Unload"), v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, new US3(1, v61), v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, new US3(1, v63), v20_1, new US6(1, method27(v104, v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, new US3(1, v56), v39, v40, v41, v42, v43, v44, v45, v46)), v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, new US9(1, v112), v32_1, v33_1, v34, v35, v36, v37, new US3(1, v68), v39, v40, v41, v42, v43, v44, v45, v46)));
    const v118 = createComponent;
    return [v78, v102, v118(IconButton, v117)];
}

export function closure28(v0_1: US1, v1_1: US1, v2_1: US2, v3_1: US3, v4_1: US4, v5_1: US3, v6_1: US3, v7_1: US3, v8_1: US1, v9_1: US5, v10_1: US3, v11_1: US3, v12_1: US1, v13_1: US3, v14_1: US3, v15_1: US1, v16_1: US0, v17_1: US3, v18_1: US3, v19_1: US3, v20_1: US3, v21_1: US6, v22_1: US3, v23_1: US3, v24_1: US3, v25_1: US7, v26_1: US3, v27_1: US3, v28_1: US3, v29_1: US3, v30_1: US8, v31_1: US9, v32_1: US3, v33_1: US3, v34: US3, v35: US3, v36: US3, v37: US3, v38: US3, v39: US3, v40: US1, v41: US3, v42: US3, v43: US6, v44: US3, v45: US3, v46: US0, v47: (arg0: any) => void, v48: int32, v49: (arg0: boolean) => void, v50: (arg0: boolean) => void, v51: (arg0: void) => boolean, v52: (arg0: boolean) => void, v53: (arg0: void) => boolean, v54: any, v55: (arg0: void) => any, unitVar: void): any {
    let v56;
    const matchValue = v54.ui_modal | 0;
    v56 = ((matchValue === (void 0)) ? -2 : matchValue);
    const v65 = (): any => closure29(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v52, v53, void 0);
    const v71 = "6px";
    const v79 = createObj(method5(new Heap1(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, new US5(1, v65), v10_1, v11_1, v12_1, new US3(1, "row"), ((v56 > 0) && ((v56 === v48) !== true)) ? (new US3(1, "none")) : (new US3(0)), v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, new US3(1, "absolute"), new US3(1, v71), v38, new US3(1, "3px"), v40, v41, v42, v43, new US3(1, v71), v45, new US0(1, 1))));
    const v82 = createComponent;
    return [v82(Stack, v79), (v51() === false) ? v55() : <></>];
}

export function closure27(v0_1: Heap1, v1_1: US1, v2_1: US1, v3_1: US2, v4_1: US3, v5_1: US4, v6_1: US3, v7_1: US3, v8_1: US3, v9_1: US1, v10_1: US5, v11_1: US3, v12_1: US3, v13_1: US1, v14_1: US3, v15_1: US3, v16_1: US1, v17_1: US0, v18_1: US3, v19_1: US3, v20_1: US3, v21_1: US3, v22_1: US6, v23_1: US3, v24_1: US3, v25_1: US3, v26_1: US7, v27_1: US3, v28_1: US3, v29_1: US3, v30_1: US3, v31_1: US8, v32_1: US9, v33_1: US3, v34: US3, v35: US3, v36: US3, v37: US3, v38: US3, v39: US3, v40: US3, v41: US1, v42: US3, v43: US3, v44: US6, v45: US3, v46: US3, v47: US0, v48: (arg0: any) => void, v49: int32, v50: (arg0: boolean) => void, v51: (arg0: boolean) => void, v52: (arg0: void) => boolean, v53: (arg0: boolean) => void, v54: (arg0: void) => boolean, v55: any, unitVar: void): any {
    let v65: (arg0: void) => any, v72: any, matchValue: int32, v75: any;
    const v56 = v0_1.l9;
    return [(v56.tag === 1) ? ((v65 = ((): any => closure28(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56.fields[0], void 0)), (v72 = createObj(method5(new Heap1(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, new US5(1, v65), v11_1, v12_1, v13_1, v14_1, new US3(1, "flex"), v16_1, new US0(1, 1), v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, (((matchValue = (v55.ui_modal | 0), (matchValue === (void 0)) ? -2 : matchValue)) <= 0) ? (new US3(1, "relative")) : (new US3(0)), v38, v39, v40, v41, v42, v43, v44, v45, v46, v47))), (v75 = createComponent, v75(Box, v72))))) : <></>];
}

export function closure23(v0_1: Heap1, v1_1: US1, v2_1: US1, v3_1: US2, v4_1: US3, v5_1: US4, v6_1: US3, v7_1: US3, v8_1: US3, v9_1: US1, v10_1: US5, v11_1: US3, v12_1: US3, v13_1: US1, v14_1: US3, v15_1: US3, v16_1: US1, v17_1: US0, v18_1: US3, v19_1: US3, v20_1: US3, v21_1: US3, v22_1: US6, v23_1: US3, v24_1: US3, v25_1: US3, v26_1: US7, v27_1: US3, v28_1: US3, v29_1: US3, v30_1: US3, v31_1: US8, v32_1: US9, v33_1: US3, v34: US3, v35: US3, v36: US3, v37: US3, v38: US3, v39: US3, v40: US3, v41: US1, v42: US3, v43: US3, v44: US6, v45: US3, v46: US3, v47: US0, v48: (arg0: any) => void, v49: int32, v50: (arg0: boolean) => void, v51: (arg0: void) => boolean, v52: (arg0: boolean) => void, v53: (arg0: void) => boolean, v54: (arg0: boolean) => void, v55: (arg0: void) => boolean, v56: any, unitVar: void): any {
    let v59: (arg0: void) => any, v65: any, v68: any, v75: US0, v80: US3, v85: US3, v90: US3, v95: US3, v100: US3, v106: (arg0: void) => any, v113: any, v116: any;
    return [(v51() === false) ? ((v59 = ((): any => closure24(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v50, v0_1, v48, v56, void 0)), (v65 = createObj(method5(new Heap1(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, new US5(1, v59), v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, new US3(1, "4px 0"), v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47))), (v68 = createComponent, v68(Box, v65))))) : ((v75 = (v55() ? (new US0(1, 1)) : (new US0(0))), (v80 = (v55() ? (new US3(1, "absolute")) : (new US3(0))), (v85 = (v55() ? (new US3(1, "0")) : (new US3(0))), (v90 = (v55() ? (new US3(1, "0")) : (new US3(0))), (v95 = (v55() ? (new US3(1, "0")) : (new US3(0))), (v100 = (v55() ? (new US3(1, "0")) : (new US3(0))), (v106 = ((): any => closure27(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v52, v53, v54, v55, v56, void 0)), (v113 = createObj(method5(new Heap1(v1_1, v2_1, v3_1, v4_1, v5_1, v55() ? (new US3(1, "$bg")) : (new US3(0)), v7_1, v95, v9_1, new US5(1, v106), v11_1, v12_1, v13_1, v14_1, new US3(1, "flex"), v16_1, new US0(1, 1), v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v100, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v80, v90, v39, v40, v41, v42, v43, v44, v85, v46, v75))), (v116 = createComponent, v116(Box, v113)))))))))))];
}

export function method24(v0_1: Heap1): any {
    const patternInput = method3();
    const v9_1 = patternInput[8];
    const v8_1 = patternInput[7];
    const v7_1 = patternInput[6];
    const v6_1 = patternInput[5];
    const v5_1 = patternInput[4];
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
    const v22_1 = patternInput[21];
    const v21_1 = patternInput[20];
    const v20_1 = patternInput[19];
    const v2_1 = patternInput[1];
    const v19_1 = patternInput[18];
    const v18_1 = patternInput[17];
    const v16_1 = patternInput[15];
    const v14_1 = patternInput[13];
    const v13_1 = patternInput[12];
    const v12_1 = patternInput[11];
    const v11_1 = patternInput[10];
    const v1_1 = patternInput[0];
    const patternInput_1 = method25();
    const v49 = patternInput_1[1];
    const v48 = patternInput_1[0];
    const v50 = nonSeeded().Next0() | 0;
    const v51 = v0_1.l0;
    const patternInput_2 = method23((v51.tag === 1) && v51.fields[0]);
    const patternInput_3 = method23(false);
    const v58 = patternInput_3[1];
    const v57 = patternInput_3[0];
    const v59 = v0_1.l1;
    const patternInput_4 = method23((v59.tag === 1) && v59.fields[0]);
    const v66 = on;
    const v67 = (): Array<boolean> => closure21(v57, void 0);
    const v68 = (): void => {
        closure22(v58, v57, void 0);
    };
    const v69 = v66(v67, v68);
    const v71 = createEffect;
    v71(v69);
    if ((v51.tag === 1) && (v51.fields[0] === true)) {
        const v76 = v0_1.l2;
        if (v76.tag === 1) {
            v76.fields[0](v48, v49);
        }
    }
    const v80 = (): any => closure23(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, patternInput[9], v11_1, v12_1, v13_1, v14_1, patternInput[14], v16_1, patternInput[16], v18_1, v19_1, v20_1, v21_1, v22_1, patternInput[22], v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v49, v50, patternInput_2[1], patternInput_2[0], v58, v57, patternInput_4[1], patternInput_4[0], v48, void 0);
    const v87 = createObj(method5(new Heap1(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, new US5(1, v80), v11_1, v12_1, v13_1, v14_1, new US3(1, "flex"), v16_1, new US0(1, 1), v18_1, v19_1, v20_1, v21_1, v22_1, v0_1.l22, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47)));
    const v89 = createComponent;
    return v89(Box, v87);
}

export function closure19(unitVar: void, v0_1: Heap1): any {
    return method24(v0_1);
}

export function closure33(v0_1: (arg0: void) => any, unitVar: void): any {
    return [v0_1()];
}

export function closure17(v0_1: Heap1, v1_1: US1, v2_1: US1, v3_1: US2, v4_1: US3, v5_1: US4, v6_1: US3, v7_1: US3, v8_1: US3, v9_1: US1, v10_1: US5, v11_1: US3, v12_1: US3, v13_1: US1, v14_1: US3, v15_1: US3, v16_1: US1, v17_1: US0, v18_1: US3, v19_1: US3, v20_1: US3, v21_1: US3, v22_1: US6, v23_1: US3, v24_1: US3, v25_1: US3, v26_1: US7, v27_1: US3, v28_1: US3, v29_1: US3, v30_1: US3, v31_1: US8, v32_1: US9, v33_1: US3, v34: US3, v35: US3, v36: US3, v37: US3, v38: US3, v39: US3, v40: US3, v41: US1, v42: US3, v43: US3, v44: US6, v45: US3, v46: US3, v47: US0, v48: (arg0: void) => boolean, v49: (arg0: void) => any, unitVar: void): any {
    let v56: (arg0: Heap1) => any, v60: (arg0: void) => any, v51: (arg0: void) => any;
    return [(v0_1.l40.tag === 1) ? (v48() ? ((v56 = ((v: Heap1): any => closure19(void 0, v)), (v60 = ((): any => closure33(v49, void 0)), method26(v56, new US1(1, true), v2_1, v0_1.l2, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, new US5(1, v60), v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47)))) : <></>) : ((v51 = ((): any => closure18(void 0, void 0)), defaultArg(v49, v51)()))];
}

export function closure11(v0_1: Heap1, v1_1: US1, v2_1: US1, v3_1: US2, v4_1: US3, v5_1: US4, v6_1: US3, v7_1: US3, v8_1: US3, v9_1: US1, v10_1: US5, v11_1: US3, v12_1: US3, v13_1: US1, v14_1: US3, v15_1: US3, v16_1: US1, v17_1: US0, v18_1: US3, v19_1: US3, v20_1: US3, v21_1: US3, v22_1: US6, v23_1: US3, v24_1: US3, v25_1: US3, v26_1: US7, v27_1: US3, v28_1: US3, v29_1: US3, v30_1: US3, v31_1: US8, v32_1: US9, v33_1: US3, v34: US3, v35: US3, v36: US3, v37: US3, v38: US3, v39: US3, v40: US3, v41: US1, v42: US3, v43: US3, v44: US6, v45: US3, v46: US3, v47: US0, v48: (arg0: boolean) => void, v49: (arg0: void) => boolean, unitVar: void): any {
    let v55: (arg0: void) => any, v71: any, v74: any, v96: US3, v102: (arg0: void) => any, v111: string, v121: any, v124: any, v80: (arg0: void) => any, v88: any, v91: any;
    const v50 = v0_1.l43;
    const v79 = v0_1.l9;
    return [(v50.tag === 1) ? ((v55 = ((): any => closure12(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50.fields[0], void 0)), (v71 = createObj(method5(new Heap1(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, new US3(1, "0 !important"), v8_1, v9_1, new US5(1, v55), new US3(1, "$neutral9"), v12_1, v13_1, v14_1, new US3(1, "flex"), v16_1, v17_1, new US3(1, "column"), new US3(1, "$sm"), v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, new US3(1, "1px solid $neutral5"), v34, new US3(1, "3px 20px 0 8px"), v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47))), (v74 = createComponent, v74(Td, v71))))) : <></>, (v79.tag === 1) ? ((v96 = v0_1.l34, (v102 = ((): any => closure17(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v49, v79.fields[0], void 0)), (v111 = "0", (v121 = createObj(method5(new Heap1(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, new US3(1, "0 !important"), v8_1, v9_1, new US5(1, v102), v11_1, v12_1, v13_1, v14_1, new US3(1, "flex"), v16_1, new US0(1, 6), new US3(1, "column"), new US3(1, "$sm"), v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, new US3(1, v111), v29_1, new US3(1, "85vh"), v31_1, v32_1, new US3(1, v111), new US3(1, "auto"), new US3(1, (v96.tag === 1) ? v96.fields[0] : "0"), v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47))), (v124 = createComponent, v124(Td, v121))))))) : ((v80 = ((): any => closure16(void 0, void 0)), (v88 = createObj(method5(new Heap1(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, new US5(1, v80), v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, new US3(1, "9px"), v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, new US3(1, "0"), v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47))), (v91 = createComponent, v91(Td, v88)))))];
}

export function method22(v0_1: Heap1): any {
    const patternInput = method3();
    const v9_1 = patternInput[8];
    const v8_1 = patternInput[7];
    const v6_1 = patternInput[5];
    const v5_1 = patternInput[4];
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
    const v22_1 = patternInput[21];
    const v21_1 = patternInput[20];
    const v20_1 = patternInput[19];
    const v2_1 = patternInput[1];
    const v19_1 = patternInput[18];
    const v16_1 = patternInput[15];
    const v14_1 = patternInput[13];
    const v13_1 = patternInput[12];
    const v12_1 = patternInput[11];
    const v11_1 = patternInput[10];
    const v1_1 = patternInput[0];
    const v48 = v0_1.l40;
    const patternInput_1 = method23(((v48.tag === 1) && (v48.fields[0] === false)) !== true);
    const v60 = (): any => closure11(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, patternInput[6], v8_1, v9_1, patternInput[9], v11_1, v12_1, v13_1, v14_1, patternInput[14], v16_1, patternInput[16], patternInput[17], v19_1, v20_1, v21_1, v22_1, patternInput[22], v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, patternInput_1[1], patternInput_1[0], void 0);
    const v68 = createObj(method5(new Heap1(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, new US3(1, "1px solid $neutral5"), v8_1, v9_1, new US5(1, v60), v11_1, v12_1, v13_1, v14_1, new US3(1, "flex"), v16_1, new US0(1, 1), new US3(1, {
        "@initial": "column",
        "@sm": "row",
    }), v19_1, v20_1, v21_1, v22_1, v0_1.l22, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47)));
    const v71 = createComponent;
    return v71(Tr, v68);
}

export function closure10(unitVar: void, v0_1: Heap1): any {
    return method22(v0_1);
}

export function closure34(v0_1: US1, v1_1: US1, v2_1: US2, v3_1: US3, v4_1: US4, v5_1: US3, v6_1: US3, v7_1: US3, v8_1: US1, v9_1: US5, v10_1: US3, v11_1: US3, v12_1: US1, v13_1: US3, v14_1: US3, v15_1: US1, v16_1: US0, v17_1: US3, v18_1: US3, v19_1: US3, v20_1: US3, v21_1: US6, v22_1: US3, v23_1: US3, v24_1: US3, v25_1: US7, v26_1: US3, v27_1: US3, v28_1: US3, v29_1: US3, v30_1: US8, v31_1: US9, v32_1: US3, v33_1: US3, v34: US3, v35: US3, v36: US3, v37: US3, v38: US3, v39: US3, v40: US1, v41: US3, v42: US3, v43: US6, v44: US3, v45: US3, v46: US0, unitVar: void): any {
    const v47 = (v: Heap1): any => closure6(void 0, v);
    return [method26(v47, v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, new US3(1, "https://github.com/fc1943s/tictactoe_spiral"), v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46)];
}

export function closure35(v0_1: US1, v1_1: US1, v2_1: US2, v3_1: US3, v4_1: US4, v5_1: US3, v6_1: US3, v7_1: US3, v8_1: US1, v9_1: US5, v10_1: US3, v11_1: US3, v12_1: US1, v13_1: US3, v14_1: US3, v15_1: US1, v16_1: US0, v17_1: US3, v18_1: US3, v19_1: US3, v20_1: US3, v21_1: US6, v22_1: US3, v23_1: US3, v24_1: US3, v25_1: US7, v26_1: US3, v27_1: US3, v28_1: US3, v29_1: US3, v30_1: US8, v31_1: US9, v32_1: US3, v33_1: US3, v34: US3, v35: US3, v36: US3, v37: US3, v38: US3, v39: US3, v40: US1, v41: US3, v42: US3, v43: US6, v44: US3, v45: US3, v46: US0, unitVar: void): any {
    const v47 = (v: Heap1): any => closure6(void 0, v);
    return [method26(v47, v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, new US3(1, "https://fc1943s.github.io/tictactoe_spiral"), v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46)];
}

export function closure36(v0_1: US1, v1_1: US1, v2_1: US2, v3_1: US3, v4_1: US4, v5_1: US3, v6_1: US3, v7_1: US3, v8_1: US1, v9_1: US5, v10_1: US3, v11_1: US3, v12_1: US1, v13_1: US3, v14_1: US3, v15_1: US1, v16_1: US0, v17_1: US3, v18_1: US3, v19_1: US3, v20_1: US3, v21_1: US6, v22_1: US3, v23_1: US3, v24_1: US3, v25_1: US7, v26_1: US3, v27_1: US3, v28_1: US3, v29_1: US3, v30_1: US8, v31_1: US9, v32_1: US3, v33_1: US3, v34: US3, v35: US3, v36: US3, v37: US3, v38: US3, v39: US3, v40: US1, v41: US3, v42: US3, v43: US6, v44: US3, v45: US3, v46: US0, unitVar: void): any {
    const v47 = (v: Heap1): any => closure6(void 0, v);
    return [method26(v47, v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, new US3(1, "https://fc1943s.github.io/tictactoe_spiral/docs"), v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46)];
}

export function closure9(v0_1: US1, v1_1: US1, v2_1: US2, v3_1: US3, v4_1: US4, v5_1: US3, v6_1: US3, v7_1: US3, v8_1: US1, v9_1: US5, v10_1: US3, v11_1: US3, v12_1: US1, v13_1: US3, v14_1: US3, v15_1: US1, v16_1: US0, v17_1: US3, v18_1: US3, v19_1: US3, v20_1: US3, v21_1: US6, v22_1: US3, v23_1: US3, v24_1: US3, v25_1: US7, v26_1: US3, v27_1: US3, v28_1: US3, v29_1: US3, v30_1: US8, v31_1: US9, v32_1: US3, v33_1: US3, v34: US3, v35: US3, v36: US3, v37: US3, v38: US3, v39: US3, v40: US1, v41: US3, v42: US3, v43: US6, v44: US3, v45: US3, v46: US0, unitVar: void): any {
    const v47 = (v: Heap1): any => closure10(void 0, v);
    const v48 = (): any => closure34(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, void 0);
    const v50 = "1px 6px";
    const v53 = (): any => closure35(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, void 0);
    const v57 = (): any => closure36(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, void 0);
    return [method26(v47, v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, new US5(1, v48), v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, new US3(1, v50), v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46), method26(v47, v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, new US5(1, v53), v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, new US3(1, v50), v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46), method26(v47, v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, new US5(1, v57), v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, new US3(1, v50), v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46)];
}

export function method21(): any {
    const patternInput = method3();
    const v8_1 = patternInput[8];
    const v7_1 = patternInput[7];
    const v6_1 = patternInput[6];
    const v5_1 = patternInput[5];
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
    const v12_1 = patternInput[12];
    const v11_1 = patternInput[11];
    const v10_1 = patternInput[10];
    const v1_1 = patternInput[1];
    const v0_1 = patternInput[0];
    const v47 = (v: Heap1): any => closure2(void 0, v);
    const v48 = (): any => closure9(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, patternInput[9], v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, void 0);
    return method26(v47, v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, new US5(1, v48), v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, v27_1, v28_1, v29_1, v30_1, v31_1, v32_1, v33_1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);
}

export function closure8(unitVar: void, unitVar_1: void): any {
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

export const v22 = (): any => closure8(void 0, void 0);

export const v23 = [v21, v22];

export const v24 = "loader";

export const v25 = (v: Heap1): any => closure19(void 0, v);

export const v26 = [v24, v25];

export const v27 = "row";

export const v28 = (v: Heap1): any => closure10(void 0, v);

export const v29 = [v27, v28];

export const v30 = "store";

export const v31 = [v30, v5];

export const v32 = [v8, v11, v14, v17, v20, v23, v26, v29, v31];

export const v33 = createObj(v32);

v1.l0 = v33;


