import { int32 } from "./fable_modules/fable-library.4.0.0-theta-003/Int32.js";
import { Record, Union } from "./fable_modules/fable-library.4.0.0-theta-003/Types.js";
import { tuple_type, record_type, obj_type, int32_type, lambda_type, unit_type, bool_type, class_type, union_type, string_type, TypeInfo } from "./fable_modules/fable-library.4.0.0-theta-003/Reflection.js";
import { fill } from "./fable_modules/fable-library.4.0.0-theta-003/Array.js";
import { equals, createObj } from "./fable_modules/fable-library.4.0.0-theta-003/Util.js";
import { createEffect, on, createSignal, createComponent } from "solid-js";
import { IconButton, Stack, Checkbox, Box, Td, Tr, Anchor, Icon, Tbody, Table, Button } from "@hope-ui/solid";
import { BiRegularUndo, BiRegularUpArrow, BiRegularDownArrow, BiRegularRefresh, BiRegularLinkExternal } from "solid-icons/bi";
import { useStoreon } from "@storeon/solidjs";
import { interpolate, toConsole } from "./fable_modules/fable-library.4.0.0-theta-003/String.js";
import { nonSeeded } from "./fable_modules/fable-library.4.0.0-theta-003/Random.js";

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
    return union_type("Components_spi.US0", [], US0, () => [[], [["f1_0", string_type]]]);
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
    return union_type("Components_spi.US1", [], US1, () => [[], [["f1_0", class_type("Fable.Core.JS.Function")]]]);
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
    return union_type("Components_spi.US2", [], US2, () => [[], [["f1_0", bool_type]]]);
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
    return union_type("Components_spi.US3", [], US3, () => [[], [["f1_0", lambda_type(unit_type, class_type("Fable.Core.JSX.Element"))]]]);
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
    return union_type("Components_spi.US4", [], US4, () => [[], [["f1_0", int32_type]]]);
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
    return union_type("Components_spi.US6", [], US6, () => [[], [["f1_0", obj_type]]]);
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
    return union_type("Components_spi.US7", [], US7, () => [[], [["f1_0", lambda_type(obj_type, unit_type)]]]);
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
    return union_type("Components_spi.US8", [], US8, () => [[], [["f1_0", lambda_type(unit_type, unit_type)]]]);
}

export class Heap0 extends Record {
    l0: US0;
    l1: US1;
    l2: US0;
    l3: US0;
    l4: US0;
    l5: US2;
    l6: US3;
    l7: US0;
    l8: US0;
    l9: US2;
    l10: US0;
    l11: US0;
    l12: US2;
    l13: US4;
    l14: US0;
    l15: US0;
    l16: US0;
    l17: US0;
    l18: US5;
    l19: US0;
    l20: US0;
    l21: US0;
    l22: US6;
    l23: US0;
    l24: US0;
    l25: US0;
    l26: US0;
    l27: US7;
    l28: US8;
    l29: US0;
    l30: US0;
    l31: US0;
    l32: US0;
    l33: US0;
    l34: US0;
    l35: US0;
    l36: US0;
    l37: US2;
    l38: US0;
    l39: US0;
    l40: US5;
    l41: US0;
    l42: US0;
    l43: US4;
    constructor(l0: US0, l1: US1, l2: US0, l3: US0, l4: US0, l5: US2, l6: US3, l7: US0, l8: US0, l9: US2, l10: US0, l11: US0, l12: US2, l13: US4, l14: US0, l15: US0, l16: US0, l17: US0, l18: US5, l19: US0, l20: US0, l21: US0, l22: US6, l23: US0, l24: US0, l25: US0, l26: US0, l27: US7, l28: US8, l29: US0, l30: US0, l31: US0, l32: US0, l33: US0, l34: US0, l35: US0, l36: US0, l37: US2, l38: US0, l39: US0, l40: US5, l41: US0, l42: US0, l43: US4) {
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
    }
}

export function Heap0$reflection(): TypeInfo {
    return record_type("Components_spi.Heap0", [], Heap0, () => [["l0", US0$reflection()], ["l1", US1$reflection()], ["l2", US0$reflection()], ["l3", US0$reflection()], ["l4", US0$reflection()], ["l5", US2$reflection()], ["l6", US3$reflection()], ["l7", US0$reflection()], ["l8", US0$reflection()], ["l9", US2$reflection()], ["l10", US0$reflection()], ["l11", US0$reflection()], ["l12", US2$reflection()], ["l13", US4$reflection()], ["l14", US0$reflection()], ["l15", US0$reflection()], ["l16", US0$reflection()], ["l17", US0$reflection()], ["l18", US5$reflection()], ["l19", US0$reflection()], ["l20", US0$reflection()], ["l21", US0$reflection()], ["l22", US6$reflection()], ["l23", US0$reflection()], ["l24", US0$reflection()], ["l25", US0$reflection()], ["l26", US0$reflection()], ["l27", US7$reflection()], ["l28", US8$reflection()], ["l29", US0$reflection()], ["l30", US0$reflection()], ["l31", US0$reflection()], ["l32", US0$reflection()], ["l33", US0$reflection()], ["l34", US0$reflection()], ["l35", US0$reflection()], ["l36", US0$reflection()], ["l37", US2$reflection()], ["l38", US0$reflection()], ["l39", US0$reflection()], ["l40", US5$reflection()], ["l41", US0$reflection()], ["l42", US0$reflection()], ["l43", US4$reflection()]]);
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
    return union_type("Components_spi.US9", [], US9, () => [[], [["f1_0", tuple_type(string_type, obj_type)]]]);
}

export class Mut0 extends Record {
    l0: int32;
    l1: int32;
    constructor(l0: int32, l1: int32) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = (l1 | 0);
    }
}

export function Mut0$reflection(): TypeInfo {
    return record_type("Components_spi.Mut0", [], Mut0, () => [["l0", int32_type], ["l1", int32_type]]);
}

export class Mut1 extends Record {
    l0: int32;
    constructor(l0: int32) {
        super();
        this.l0 = (l0 | 0);
    }
}

export function Mut1$reflection(): TypeInfo {
    return record_type("Components_spi.Mut1", [], Mut1, () => [["l0", int32_type]]);
}

export class Mut2 extends Record {
    l0: int32;
    l1: US0;
    l2: US1;
    l3: US0;
    l4: US0;
    l5: US0;
    l6: US2;
    l7: US3;
    l8: US0;
    l9: US0;
    l10: US2;
    l11: US0;
    l12: US0;
    l13: US2;
    l14: US4;
    l15: US0;
    l16: US0;
    l17: US0;
    l18: US0;
    l19: US5;
    l20: US0;
    l21: US0;
    l22: US0;
    l23: US6;
    l24: US0;
    l25: US0;
    l26: US0;
    l27: US0;
    l28: US7;
    l29: US8;
    l30: US0;
    l31: US0;
    l32: US0;
    l33: US0;
    l34: US0;
    l35: US0;
    l36: US0;
    l37: US0;
    l38: US2;
    l39: US0;
    l40: US0;
    l41: US5;
    l42: US0;
    l43: US0;
    l44: US4;
    constructor(l0: int32, l1: US0, l2: US1, l3: US0, l4: US0, l5: US0, l6: US2, l7: US3, l8: US0, l9: US0, l10: US2, l11: US0, l12: US0, l13: US2, l14: US4, l15: US0, l16: US0, l17: US0, l18: US0, l19: US5, l20: US0, l21: US0, l22: US0, l23: US6, l24: US0, l25: US0, l26: US0, l27: US0, l28: US7, l29: US8, l30: US0, l31: US0, l32: US0, l33: US0, l34: US0, l35: US0, l36: US0, l37: US0, l38: US2, l39: US0, l40: US0, l41: US5, l42: US0, l43: US0, l44: US4) {
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
    }
}

export function Mut2$reflection(): TypeInfo {
    return record_type("Components_spi.Mut2", [], Mut2, () => [["l0", int32_type], ["l1", US0$reflection()], ["l2", US1$reflection()], ["l3", US0$reflection()], ["l4", US0$reflection()], ["l5", US0$reflection()], ["l6", US2$reflection()], ["l7", US3$reflection()], ["l8", US0$reflection()], ["l9", US0$reflection()], ["l10", US2$reflection()], ["l11", US0$reflection()], ["l12", US0$reflection()], ["l13", US2$reflection()], ["l14", US4$reflection()], ["l15", US0$reflection()], ["l16", US0$reflection()], ["l17", US0$reflection()], ["l18", US0$reflection()], ["l19", US5$reflection()], ["l20", US0$reflection()], ["l21", US0$reflection()], ["l22", US0$reflection()], ["l23", US6$reflection()], ["l24", US0$reflection()], ["l25", US0$reflection()], ["l26", US0$reflection()], ["l27", US0$reflection()], ["l28", US7$reflection()], ["l29", US8$reflection()], ["l30", US0$reflection()], ["l31", US0$reflection()], ["l32", US0$reflection()], ["l33", US0$reflection()], ["l34", US0$reflection()], ["l35", US0$reflection()], ["l36", US0$reflection()], ["l37", US0$reflection()], ["l38", US2$reflection()], ["l39", US0$reflection()], ["l40", US0$reflection()], ["l41", US5$reflection()], ["l42", US0$reflection()], ["l43", US0$reflection()], ["l44", US4$reflection()]]);
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
    return union_type("Components_spi.US10", [], US10, () => [[], [["f1_0", lambda_type(Mut3$reflection(), lambda_type(lambda_type(Mut3$reflection(), unit_type), unit_type))]]]);
}

export function method0(): [US0, US1, US0, US0, US0, US2, US3, US0, US0, US2, US0, US0, US2, US4, US0, US0, US0, US0, US5, US0, US0, US0, US6, US0, US0, US0, US0, US7, US8, US0, US0, US0, US0, US0, US0, US0, US0, US2, US0, US0, US5, US0, US0, US4] {
    return [new US0(0), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), new US3(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US2(0), new US4(0), new US0(0), new US0(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US0(0), new US6(0), new US0(0), new US0(0), new US0(0), new US0(0), new US7(0), new US8(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0)];
}

export function method1(v0_1: Heap0, v1_1: US0, v2_1: US1, v3_1: US0, v4_1: US0, v5_1: US0, v6_1: US2, v7_1: US3, v8_1: US0, v9_1: US0, v10_1: US2, v11_1: US0, v12_1: US0, v13_1: US2, v14_1: US4, v15_1: US0, v16_1: US0, v17_1: US0, v18_1: US0, v19_1: US5, v20_1: US0, v21_1: US0, v22_1: US0, v23: US6, v24: US0, v25: US0, v26: US0, v27: US0, v28: US7, v29: US8, v30: US0, v31: US0, v32: US0, v33: US0, v34: US0, v35: US0, v36: US0, v37: US0, v38: US2, v39: US0, v40: US0, v41: US5, v42: US0, v43: US0, v44: US4): Heap0 {
    const v45 = new Heap0(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);
    const v46 = v0_1.l0;
    const v47 = v45.l0;
    const v54 = (v47.tag === 1) ? (new US0(1, v47.fields[0])) : ((v46.tag === 1) ? (new US0(1, v46.fields[0])) : (new US0(0)));
    const v55 = v0_1.l1;
    const v56 = v45.l1;
    const v63 = (v56.tag === 1) ? (new US1(1, v56.fields[0])) : ((v55.tag === 1) ? (new US1(1, v55.fields[0])) : (new US1(0)));
    const v64 = v0_1.l2;
    const v65 = v45.l2;
    const v72 = (v65.tag === 1) ? (new US0(1, v65.fields[0])) : ((v64.tag === 1) ? (new US0(1, v64.fields[0])) : (new US0(0)));
    const v73 = v0_1.l3;
    const v74 = v45.l3;
    const v81 = (v74.tag === 1) ? (new US0(1, v74.fields[0])) : ((v73.tag === 1) ? (new US0(1, v73.fields[0])) : (new US0(0)));
    const v82 = v0_1.l4;
    const v83 = v45.l4;
    const v90 = (v83.tag === 1) ? (new US0(1, v83.fields[0])) : ((v82.tag === 1) ? (new US0(1, v82.fields[0])) : (new US0(0)));
    const v91 = v0_1.l7;
    const v92 = v45.l7;
    const v99 = (v92.tag === 1) ? (new US0(1, v92.fields[0])) : ((v91.tag === 1) ? (new US0(1, v91.fields[0])) : (new US0(0)));
    const v100 = v0_1.l5;
    const v101 = v45.l5;
    const v108 = (v101.tag === 1) ? (new US2(1, v101.fields[0])) : ((v100.tag === 1) ? (new US2(1, v100.fields[0])) : (new US2(0)));
    const v109 = v0_1.l6;
    const v110 = v45.l6;
    const v117 = (v110.tag === 1) ? (new US3(1, v110.fields[0])) : ((v109.tag === 1) ? (new US3(1, v109.fields[0])) : (new US3(0)));
    const v118 = v0_1.l8;
    const v119 = v45.l8;
    const v126 = (v119.tag === 1) ? (new US0(1, v119.fields[0])) : ((v118.tag === 1) ? (new US0(1, v118.fields[0])) : (new US0(0)));
    const v127 = v0_1.l9;
    const v128 = v45.l9;
    const v135 = (v128.tag === 1) ? (new US2(1, v128.fields[0])) : ((v127.tag === 1) ? (new US2(1, v127.fields[0])) : (new US2(0)));
    const v136 = v0_1.l10;
    const v137 = v45.l10;
    const v144 = (v137.tag === 1) ? (new US0(1, v137.fields[0])) : ((v136.tag === 1) ? (new US0(1, v136.fields[0])) : (new US0(0)));
    const v145 = v0_1.l11;
    const v146 = v45.l11;
    const v153 = (v146.tag === 1) ? (new US0(1, v146.fields[0])) : ((v145.tag === 1) ? (new US0(1, v145.fields[0])) : (new US0(0)));
    const v154 = v0_1.l12;
    const v155 = v45.l12;
    const v162 = (v155.tag === 1) ? (new US2(1, v155.fields[0])) : ((v154.tag === 1) ? (new US2(1, v154.fields[0])) : (new US2(0)));
    const v163 = v0_1.l13;
    const v164 = v45.l13;
    const v171 = (v164.tag === 1) ? (new US4(1, v164.fields[0])) : ((v163.tag === 1) ? (new US4(1, v163.fields[0])) : (new US4(0)));
    const v172 = v0_1.l14;
    const v173 = v45.l14;
    const v180 = (v173.tag === 1) ? (new US0(1, v173.fields[0])) : ((v172.tag === 1) ? (new US0(1, v172.fields[0])) : (new US0(0)));
    const v181 = v0_1.l15;
    const v182 = v45.l15;
    const v189 = (v182.tag === 1) ? (new US0(1, v182.fields[0])) : ((v181.tag === 1) ? (new US0(1, v181.fields[0])) : (new US0(0)));
    const v190 = v0_1.l16;
    const v191 = v45.l16;
    const v198 = (v191.tag === 1) ? (new US0(1, v191.fields[0])) : ((v190.tag === 1) ? (new US0(1, v190.fields[0])) : (new US0(0)));
    const v199 = v0_1.l17;
    const v200 = v45.l17;
    const v207 = (v200.tag === 1) ? (new US0(1, v200.fields[0])) : ((v199.tag === 1) ? (new US0(1, v199.fields[0])) : (new US0(0)));
    const v208 = v0_1.l18;
    const v209 = v45.l18;
    const v216 = (v209.tag === 1) ? (new US5(1, v209.fields[0])) : ((v208.tag === 1) ? (new US5(1, v208.fields[0])) : (new US5(0)));
    const v217 = v0_1.l19;
    const v218 = v45.l19;
    const v225 = (v218.tag === 1) ? (new US0(1, v218.fields[0])) : ((v217.tag === 1) ? (new US0(1, v217.fields[0])) : (new US0(0)));
    const v226 = v0_1.l37;
    const v227 = v45.l37;
    const v234 = (v227.tag === 1) ? (new US2(1, v227.fields[0])) : ((v226.tag === 1) ? (new US2(1, v226.fields[0])) : (new US2(0)));
    const v235 = v0_1.l20;
    const v236 = v45.l20;
    const v244 = v0_1.l21;
    const v245 = v45.l21;
    const v253 = v0_1.l22;
    const v254 = v45.l22;
    const v262 = v0_1.l23;
    const v263 = v45.l23;
    const v271 = v0_1.l24;
    const v272 = v45.l24;
    const v280 = v0_1.l25;
    const v281 = v45.l25;
    const v289 = v0_1.l26;
    const v290 = v45.l26;
    const v298 = v0_1.l27;
    const v299 = v45.l27;
    const v307 = v0_1.l28;
    const v308 = v45.l28;
    const v316 = v0_1.l29;
    const v317 = v45.l29;
    const v325 = v0_1.l30;
    const v326 = v45.l30;
    const v334 = v0_1.l31;
    const v335 = v45.l31;
    const v343 = v0_1.l32;
    const v344 = v45.l32;
    const v352 = v0_1.l33;
    const v353 = v45.l33;
    const v361 = v0_1.l34;
    const v362 = v45.l34;
    const v370 = v0_1.l35;
    const v371 = v45.l35;
    const v379 = v0_1.l36;
    const v380 = v45.l36;
    const v388 = v0_1.l38;
    const v389 = v45.l38;
    const v397 = v0_1.l39;
    const v398 = v45.l39;
    const v406 = v0_1.l40;
    const v407 = v45.l40;
    const v415 = v0_1.l41;
    const v416 = v45.l41;
    const v424 = v0_1.l42;
    const v425 = v45.l42;
    const v433 = v0_1.l43;
    const v434 = v45.l43;
    return new Heap0(v54, v63, v72, v81, v90, v108, v117, v99, v126, v135, v144, v153, v162, v171, v180, v189, v198, v207, v216, v225, (v236.tag === 1) ? (new US0(1, v236.fields[0])) : ((v235.tag === 1) ? (new US0(1, v235.fields[0])) : (new US0(0))), (v245.tag === 1) ? (new US0(1, v245.fields[0])) : ((v244.tag === 1) ? (new US0(1, v244.fields[0])) : (new US0(0))), (v254.tag === 1) ? (new US6(1, v254.fields[0])) : ((v253.tag === 1) ? (new US6(1, v253.fields[0])) : (new US6(0))), (v263.tag === 1) ? (new US0(1, v263.fields[0])) : ((v262.tag === 1) ? (new US0(1, v262.fields[0])) : (new US0(0))), (v272.tag === 1) ? (new US0(1, v272.fields[0])) : ((v271.tag === 1) ? (new US0(1, v271.fields[0])) : (new US0(0))), (v281.tag === 1) ? (new US0(1, v281.fields[0])) : ((v280.tag === 1) ? (new US0(1, v280.fields[0])) : (new US0(0))), (v290.tag === 1) ? (new US0(1, v290.fields[0])) : ((v289.tag === 1) ? (new US0(1, v289.fields[0])) : (new US0(0))), (v299.tag === 1) ? (new US7(1, v299.fields[0])) : ((v298.tag === 1) ? (new US7(1, v298.fields[0])) : (new US7(0))), (v308.tag === 1) ? (new US8(1, v308.fields[0])) : ((v307.tag === 1) ? (new US8(1, v307.fields[0])) : (new US8(0))), (v317.tag === 1) ? (new US0(1, v317.fields[0])) : ((v316.tag === 1) ? (new US0(1, v316.fields[0])) : (new US0(0))), (v326.tag === 1) ? (new US0(1, v326.fields[0])) : ((v325.tag === 1) ? (new US0(1, v325.fields[0])) : (new US0(0))), (v335.tag === 1) ? (new US0(1, v335.fields[0])) : ((v334.tag === 1) ? (new US0(1, v334.fields[0])) : (new US0(0))), (v344.tag === 1) ? (new US0(1, v344.fields[0])) : ((v343.tag === 1) ? (new US0(1, v343.fields[0])) : (new US0(0))), (v353.tag === 1) ? (new US0(1, v353.fields[0])) : ((v352.tag === 1) ? (new US0(1, v352.fields[0])) : (new US0(0))), (v362.tag === 1) ? (new US0(1, v362.fields[0])) : ((v361.tag === 1) ? (new US0(1, v361.fields[0])) : (new US0(0))), (v371.tag === 1) ? (new US0(1, v371.fields[0])) : ((v370.tag === 1) ? (new US0(1, v370.fields[0])) : (new US0(0))), (v380.tag === 1) ? (new US0(1, v380.fields[0])) : ((v379.tag === 1) ? (new US0(1, v379.fields[0])) : (new US0(0))), v234, (v389.tag === 1) ? (new US0(1, v389.fields[0])) : ((v388.tag === 1) ? (new US0(1, v388.fields[0])) : (new US0(0))), (v398.tag === 1) ? (new US0(1, v398.fields[0])) : ((v397.tag === 1) ? (new US0(1, v397.fields[0])) : (new US0(0))), (v407.tag === 1) ? (new US5(1, v407.fields[0])) : ((v406.tag === 1) ? (new US5(1, v406.fields[0])) : (new US5(0))), (v416.tag === 1) ? (new US0(1, v416.fields[0])) : ((v415.tag === 1) ? (new US0(1, v415.fields[0])) : (new US0(0))), (v425.tag === 1) ? (new US0(1, v425.fields[0])) : ((v424.tag === 1) ? (new US0(1, v424.fields[0])) : (new US0(0))), (v434.tag === 1) ? (new US4(1, v434.fields[0])) : ((v433.tag === 1) ? (new US4(1, v433.fields[0])) : (new US4(0))));
}

export function method3(v0_1: string, v1_1: US0): US9 {
    if (v1_1.tag === 1) {
        return new US9(1, [v0_1, v1_1.fields[0]]);
    }
    else {
        return new US9(0);
    }
}

export function method4(v0_1: string, v1_1: US1): US9 {
    if (v1_1.tag === 1) {
        return new US9(1, [v0_1, v1_1.fields[0]]);
    }
    else {
        return new US9(0);
    }
}

export function method5(v0_1: string, v1_1: US2): US9 {
    if (v1_1.tag === 1) {
        return new US9(1, [v0_1, v1_1.fields[0]]);
    }
    else {
        return new US9(0);
    }
}

export function method6(v0_1: string, v1_1: US3): US9 {
    if (v1_1.tag === 1) {
        return new US9(1, [v0_1, v1_1.fields[0]]);
    }
    else {
        return new US9(0);
    }
}

export function method7(v0_1: string, v1_1: US4): US9 {
    if (v1_1.tag === 1) {
        return new US9(1, [v0_1, v1_1.fields[0]]);
    }
    else {
        return new US9(0);
    }
}

export function method8(v0_1: string, v1_1: US5): US9 {
    if (v1_1.tag === 1) {
        return new US9(1, [v0_1, v1_1.fields[0]]);
    }
    else {
        return new US9(0);
    }
}

export function method9(v0_1: string, v1_1: US6): US9 {
    if (v1_1.tag === 1) {
        return new US9(1, [v0_1, v1_1.fields[0]]);
    }
    else {
        return new US9(0);
    }
}

export function method10(v0_1: string, v1_1: US7): US9 {
    if (v1_1.tag === 1) {
        return new US9(1, [v0_1, v1_1.fields[0]]);
    }
    else {
        return new US9(0);
    }
}

export function method11(v0_1: string, v1_1: US8): US9 {
    if (v1_1.tag === 1) {
        return new US9(1, [v0_1, v1_1.fields[0]]);
    }
    else {
        return new US9(0);
    }
}

export function method12(v0_1: int32, v1_1: Mut0): boolean {
    return v1_1.l0 < v0_1;
}

export function method13(v0_1: int32, v1_1: Mut1): boolean {
    return v1_1.l0 < v0_1;
}

export function method2(v0_1: Heap0): Array<[string, any]> {
    const v133 = [method3("aria-label", v0_1.l0), method4("as", v0_1.l1), method3("backgroundColor", v0_1.l2), method3("border", v0_1.l3), method3("bottom", v0_1.l4), method3("color", v0_1.l7), method5("checked", v0_1.l5), method6("children", v0_1.l6), method3("colorScheme", v0_1.l8), method5("compact", v0_1.l9), method3("display", v0_1.l11), method3("direction", v0_1.l10), method5("external", v0_1.l12), method7("flex", v0_1.l13), method3("flexDirection", v0_1.l14), method3("fontSize", v0_1.l15), method3("height", v0_1.l16), method3("href", v0_1.l17), method8("icon", v0_1.l18), method3("id", v0_1.l19), method3("justifyContent", v0_1.l20), method3("left", v0_1.l21), method9("leftIcon", v0_1.l22), method3("lineHeight", v0_1.l23), method3("margin", v0_1.l24), method3("marginBottom", v0_1.l25), method3("maxHeight", v0_1.l26), method10("onChange", v0_1.l27), method11("onClick", v0_1.l28), method3("outline", v0_1.l29), method3("overflowY", v0_1.l30), method3("padding", v0_1.l31), method3("paddingTop", v0_1.l32), method3("position", v0_1.l33), method3("right", v0_1.l34), method3("size", v0_1.l35), method3("spacing", v0_1.l36), method5("status", v0_1.l37), method3("striped", v0_1.l38), method3("thickness", v0_1.l39), method8("title", v0_1.l40), method3("top", v0_1.l41), method3("width", v0_1.l42), method7("zIndex", v0_1.l43)];
    const v134 = v133.length | 0;
    const v135 = fill(new Array(v134), 0, v134, null);
    const v136 = new Mut0(0, 0);
    while (method12(v134, v136)) {
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
    const v148 = new Mut1(0);
    while (method13(v146, v148)) {
        const v150 = v148.l0 | 0;
        const v151 = v135[v150];
        v147[v150] = v151;
        const v152 = (v150 + 1) | 0;
        v148.l0 = (v152 | 0);
    }
    const v153 = v147.length | 0;
    const v154 = fill(new Array(v153), 0, v153, null);
    const v155 = new Mut1(0);
    while (method13(v153, v155)) {
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

export function closure0(unitVar: void, v0_1: Heap0): any {
    const patternInput = method0();
    const v55 = createObj(method2(method1(v0_1, patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], new US0(1, "neutral"), new US2(1, true), patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], new US0(1, "left"), patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], new US0(1, "xs"), patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43])));
    const v58 = createComponent;
    return v58(Button, v55);
}

export function closure2(unitVar: void, v0_1: Heap0): any {
    const v2_1 = createObj(method2(v0_1));
    const v5_1 = createComponent;
    return v5_1(Table, v2_1);
}

export function closure4(unitVar: void, v0_1: Heap0): any {
    const v2_1 = createObj(method2(v0_1));
    const v5_1 = createComponent;
    return v5_1(Tbody, v2_1);
}

export function method14(v0_1: (arg0: Heap0) => any, v1_1: Heap0): any {
    const v5_1 = createComponent;
    return v5_1(v0_1, v1_1);
}

export function closure3(v0_1: Heap0, v1_1: US0, v2_1: US1, v3_1: US0, v4_1: US0, v5_1: US0, v6_1: US2, v7_1: US3, v8_1: US0, v9_1: US0, v10_1: US2, v11_1: US0, v12_1: US0, v13_1: US2, v14_1: US4, v15_1: US0, v16_1: US0, v17_1: US0, v18_1: US0, v19_1: US5, v20_1: US0, v21_1: US0, v22_1: US0, v23: US6, v24: US0, v25: US0, v26: US0, v27: US0, v28: US7, v29: US8, v30: US0, v31: US0, v32: US0, v33: US0, v34: US0, v35: US0, v36: US0, v37: US0, v38: US2, v39: US0, v40: US0, v41: US5, v42: US0, v43: US0, v44: US4, unitVar: void): any {
    const v45 = (v: Heap0): any => closure4(void 0, v);
    return [method14(v45, new Heap0(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v0_1.l6, v8_1, v9_1, v10_1, v11_1, new US0(1, "flex"), v13_1, v14_1, new US0(1, "column"), v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44))];
}

export function closure1(unitVar: void, v0_1: Heap0): any {
    const patternInput = method0();
    const v9_1 = patternInput[8];
    const v8_1 = patternInput[7];
    const v6_1 = patternInput[5];
    const v5_1 = patternInput[4];
    const v44 = patternInput[43];
    const v43 = patternInput[42];
    const v42 = patternInput[41];
    const v41 = patternInput[40];
    const v40 = patternInput[39];
    const v4_1 = patternInput[3];
    const v38 = patternInput[37];
    const v37 = patternInput[36];
    const v36 = patternInput[35];
    const v35 = patternInput[34];
    const v34 = patternInput[33];
    const v33 = patternInput[32];
    const v32 = patternInput[31];
    const v31 = patternInput[30];
    const v30 = patternInput[29];
    const v3_1 = patternInput[2];
    const v29 = patternInput[28];
    const v28 = patternInput[27];
    const v27 = patternInput[26];
    const v26 = patternInput[25];
    const v25 = patternInput[24];
    const v24 = patternInput[23];
    const v23 = patternInput[22];
    const v22_1 = patternInput[21];
    const v21_1 = patternInput[20];
    const v20_1 = patternInput[19];
    const v2_1 = patternInput[1];
    const v19_1 = patternInput[18];
    const v18_1 = patternInput[17];
    const v17_1 = patternInput[16];
    const v16_1 = patternInput[15];
    const v13_1 = patternInput[12];
    const v11_1 = patternInput[10];
    const v10_1 = patternInput[9];
    const v1_1 = patternInput[0];
    const v45 = (v: Heap0): any => closure2(void 0, v);
    const v46 = (): any => closure3(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, patternInput[6], v8_1, v9_1, v10_1, v11_1, patternInput[11], v13_1, patternInput[13], patternInput[14], v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, patternInput[38], v40, v41, v42, v43, v44, void 0);
    return method14(v45, new Heap0(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, new US3(1, v46), v8_1, v9_1, v10_1, v11_1, new US0(1, "flex"), v13_1, new US4(1, 1), new US0(1, "column"), v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, new US0(1, "odd"), v40, v41, v42, v43, v44));
}

export function method16(v0_1: int32, v1_1: Mut2): boolean {
    return v1_1.l0 < v0_1;
}

export function method15(v0_1: Array<[string, any]>): Heap0 {
    const patternInput = method0();
    const v45 = v0_1.length | 0;
    const v46 = new Mut2(0, patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5], patternInput[6], patternInput[7], patternInput[8], patternInput[9], patternInput[10], patternInput[11], patternInput[12], patternInput[13], patternInput[14], patternInput[15], patternInput[16], patternInput[17], patternInput[18], patternInput[19], patternInput[20], patternInput[21], patternInput[22], patternInput[23], patternInput[24], patternInput[25], patternInput[26], patternInput[27], patternInput[28], patternInput[29], patternInput[30], patternInput[31], patternInput[32], patternInput[33], patternInput[34], patternInput[35], patternInput[36], patternInput[37], patternInput[38], patternInput[39], patternInput[40], patternInput[41], patternInput[42], patternInput[43]);
    while (method16(v45, v46)) {
        const v48 = v46.l0 | 0;
        const patternInput_1 = [v46.l1, v46.l2, v46.l3, v46.l4, v46.l5, v46.l6, v46.l7, v46.l8, v46.l9, v46.l10, v46.l11, v46.l12, v46.l13, v46.l14, v46.l15, v46.l16, v46.l17, v46.l18, v46.l19, v46.l20, v46.l21, v46.l22, v46.l23, v46.l24, v46.l25, v46.l26, v46.l27, v46.l28, v46.l29, v46.l30, v46.l31, v46.l32, v46.l33, v46.l34, v46.l35, v46.l36, v46.l37, v46.l38, v46.l39, v46.l40, v46.l41, v46.l42, v46.l43, v46.l44];
        const v92 = patternInput_1[43];
        const v91 = patternInput_1[42];
        const v90 = patternInput_1[41];
        const v89 = patternInput_1[40];
        const v88 = patternInput_1[39];
        const v87 = patternInput_1[38];
        const v86 = patternInput_1[37];
        const v85 = patternInput_1[36];
        const v84 = patternInput_1[35];
        const v83 = patternInput_1[34];
        const v82 = patternInput_1[33];
        const v81 = patternInput_1[32];
        const v80 = patternInput_1[31];
        const v79 = patternInput_1[30];
        const v78 = patternInput_1[29];
        const v77 = patternInput_1[28];
        const v76 = patternInput_1[27];
        const v75 = patternInput_1[26];
        const v74 = patternInput_1[25];
        const v73 = patternInput_1[24];
        const v72 = patternInput_1[23];
        const v71 = patternInput_1[22];
        const v70 = patternInput_1[21];
        const v69 = patternInput_1[20];
        const v68 = patternInput_1[19];
        const v67 = patternInput_1[18];
        const v66 = patternInput_1[17];
        const v65 = patternInput_1[16];
        const v64 = patternInput_1[15];
        const v63 = patternInput_1[14];
        const v62 = patternInput_1[13];
        const v61 = patternInput_1[12];
        const v60 = patternInput_1[11];
        const v59 = patternInput_1[10];
        const v58 = patternInput_1[9];
        const v57 = patternInput_1[8];
        const v56 = patternInput_1[7];
        const v55 = patternInput_1[6];
        const v54 = patternInput_1[5];
        const v53 = patternInput_1[4];
        const v52 = patternInput_1[3];
        const v51 = patternInput_1[2];
        const v50 = patternInput_1[1];
        const v49 = patternInput_1[0];
        const patternInput_2 = v0_1[v48];
        const v94 = patternInput_2[1];
        const v93 = patternInput_2[0];
        let patternInput_3;
        if (equals(v94, void 0)) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("aria-label" === v93) {
            patternInput_3 = [new US0(1, v94), v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("as" === v93) {
            patternInput_3 = [v49, new US1(1, v94), v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("backgroundColor" === v93) {
            patternInput_3 = [v49, v50, new US0(1, v94), v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("border" === v93) {
            patternInput_3 = [v49, v50, v51, new US0(1, v94), v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("bottom" === v93) {
            patternInput_3 = [v49, v50, v51, v52, new US0(1, v94), v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("color" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, new US0(1, v94), v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("checked" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, new US2(1, v94), v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("children" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, new US3(1, v94), v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("colorScheme" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, new US0(1, v94), v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("compact" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, new US2(1, v94), v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("display" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, new US0(1, v94), v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("direction" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, new US0(1, v94), v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("external" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, new US2(1, v94), v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("flex" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, new US4(1, v94), v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("flexDirection" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, new US0(1, v94), v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("fontSize" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, new US0(1, v94), v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("height" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, new US0(1, v94), v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("href" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, new US0(1, v94), v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("icon" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, new US5(1, v94), v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("id" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, new US0(1, v94), v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("justifyContent" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, new US0(1, v94), v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("left" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, new US0(1, v94), v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("leftIcon" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, new US6(1, v94), v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("lineHeight" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, new US0(1, v94), v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("margin" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, new US0(1, v94), v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("marginBottom" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, new US0(1, v94), v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("maxHeight" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, new US0(1, v94), v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("onChange" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, new US7(1, v94), v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("onClick" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, new US8(1, v94), v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("outline" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, new US0(1, v94), v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("overflowY" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, new US0(1, v94), v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("padding" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, new US0(1, v94), v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("paddingTop" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, new US0(1, v94), v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("position" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, new US0(1, v94), v83, v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("right" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, new US0(1, v94), v84, v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("size" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, new US0(1, v94), v85, v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("spacing" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, new US0(1, v94), v86, v87, v88, v89, v90, v91, v92];
        }
        else if ("status" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, new US2(1, v94), v87, v88, v89, v90, v91, v92];
        }
        else if ("striped" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, new US0(1, v94), v88, v89, v90, v91, v92];
        }
        else if ("thickness" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, new US0(1, v94), v89, v90, v91, v92];
        }
        else if ("title" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, new US5(1, v94), v90, v91, v92];
        }
        else if ("top" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, new US0(1, v94), v91, v92];
        }
        else if ("width" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, new US0(1, v94), v92];
        }
        else if ("zIndex" === v93) {
            patternInput_3 = [v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, new US4(1, v94)];
        }
        else {
            throw new Error(`unknown prop: ${v93} = ${v94}`);
        }
        const v2253 = (v48 + 1) | 0;
        v46.l0 = (v2253 | 0);
        v46.l1 = patternInput_3[0];
        v46.l2 = patternInput_3[1];
        v46.l3 = patternInput_3[2];
        v46.l4 = patternInput_3[3];
        v46.l5 = patternInput_3[4];
        v46.l6 = patternInput_3[5];
        v46.l7 = patternInput_3[6];
        v46.l8 = patternInput_3[7];
        v46.l9 = patternInput_3[8];
        v46.l10 = patternInput_3[9];
        v46.l11 = patternInput_3[10];
        v46.l12 = patternInput_3[11];
        v46.l13 = patternInput_3[12];
        v46.l14 = patternInput_3[13];
        v46.l15 = patternInput_3[14];
        v46.l16 = patternInput_3[15];
        v46.l17 = patternInput_3[16];
        v46.l18 = patternInput_3[17];
        v46.l19 = patternInput_3[18];
        v46.l20 = patternInput_3[19];
        v46.l21 = patternInput_3[20];
        v46.l22 = patternInput_3[21];
        v46.l23 = patternInput_3[22];
        v46.l24 = patternInput_3[23];
        v46.l25 = patternInput_3[24];
        v46.l26 = patternInput_3[25];
        v46.l27 = patternInput_3[26];
        v46.l28 = patternInput_3[27];
        v46.l29 = patternInput_3[28];
        v46.l30 = patternInput_3[29];
        v46.l31 = patternInput_3[30];
        v46.l32 = patternInput_3[31];
        v46.l33 = patternInput_3[32];
        v46.l34 = patternInput_3[33];
        v46.l35 = patternInput_3[34];
        v46.l36 = patternInput_3[35];
        v46.l37 = patternInput_3[36];
        v46.l38 = patternInput_3[37];
        v46.l39 = patternInput_3[38];
        v46.l40 = patternInput_3[39];
        v46.l41 = patternInput_3[40];
        v46.l42 = patternInput_3[41];
        v46.l43 = patternInput_3[42];
        v46.l44 = patternInput_3[43];
    }
    const patternInput_4 = [v46.l1, v46.l2, v46.l3, v46.l4, v46.l5, v46.l6, v46.l7, v46.l8, v46.l9, v46.l10, v46.l11, v46.l12, v46.l13, v46.l14, v46.l15, v46.l16, v46.l17, v46.l18, v46.l19, v46.l20, v46.l21, v46.l22, v46.l23, v46.l24, v46.l25, v46.l26, v46.l27, v46.l28, v46.l29, v46.l30, v46.l31, v46.l32, v46.l33, v46.l34, v46.l35, v46.l36, v46.l37, v46.l38, v46.l39, v46.l40, v46.l41, v46.l42, v46.l43, v46.l44];
    return new Heap0(patternInput_4[0], patternInput_4[1], patternInput_4[2], patternInput_4[3], patternInput_4[4], patternInput_4[5], patternInput_4[6], patternInput_4[7], patternInput_4[8], patternInput_4[9], patternInput_4[10], patternInput_4[11], patternInput_4[12], patternInput_4[13], patternInput_4[14], patternInput_4[15], patternInput_4[16], patternInput_4[17], patternInput_4[18], patternInput_4[19], patternInput_4[20], patternInput_4[21], patternInput_4[22], patternInput_4[23], patternInput_4[24], patternInput_4[25], patternInput_4[26], patternInput_4[27], patternInput_4[28], patternInput_4[29], patternInput_4[30], patternInput_4[31], patternInput_4[32], patternInput_4[33], patternInput_4[34], patternInput_4[35], patternInput_4[36], patternInput_4[37], patternInput_4[38], patternInput_4[39], patternInput_4[40], patternInput_4[41], patternInput_4[42], patternInput_4[43]);
}

export function closure5(unitVar: void, v0_1: Array<[string, any]>): Heap0 {
    return method15(v0_1);
}

export function closure7(v0_1: Heap0, v1_1: US0, v2_1: US1, v3_1: US0, v4_1: US0, v5_1: US0, v6_1: US2, v7_1: US3, v8_1: US0, v9_1: US0, v10_1: US2, v11_1: US0, v12_1: US0, v13_1: US2, v14_1: US4, v15_1: US0, v16_1: US0, v17_1: US0, v18_1: US0, v19_1: US5, v20_1: US0, v21_1: US0, v22_1: US0, v23: US6, v24: US0, v25: US0, v26: US0, v27: US0, v28: US7, v29: US8, v30: US0, v31: US0, v32: US0, v33: US0, v34: US0, v35: US0, v36: US0, v37: US0, v38: US2, v39: US0, v40: US0, v41: US5, v42: US0, v43: US0, v44: US4, unitVar: void): any {
    const v45 = v0_1.l17;
    const v49 = <>
        {(v45.tag === 1) ? v45.fields[0] : ""}
    </>;
    const v51 = <>
        &nbsp;
    </>;
    const v54 = BiRegularLinkExternal;
    const v58 = createObj(method2(new Heap0(v1_1, new US1(1, v54), v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44)));
    const v61 = createComponent;
    return [v49, v51, v61(Icon, v58)];
}

export function closure6(unitVar: void, v0_1: Heap0): any {
    const patternInput = method0();
    const v9_1 = patternInput[8];
    const v8_1 = patternInput[7];
    const v6_1 = patternInput[5];
    const v5_1 = patternInput[4];
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
    const v33 = patternInput[32];
    const v32 = patternInput[31];
    const v31 = patternInput[30];
    const v30 = patternInput[29];
    const v3_1 = patternInput[2];
    const v29 = patternInput[28];
    const v28 = patternInput[27];
    const v27 = patternInput[26];
    const v26 = patternInput[25];
    const v25 = patternInput[24];
    const v24 = patternInput[23];
    const v23 = patternInput[22];
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
    const v45 = (): any => closure7(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, patternInput[6], v8_1, v9_1, v10_1, v11_1, v12_1, patternInput[12], v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, void 0);
    const v51 = createObj(method2(method1(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, new US3(1, v45), v8_1, v9_1, v10_1, v11_1, v12_1, new US2(1, true), v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44)));
    const v54 = createComponent;
    return v54(Anchor, v51);
}

export function closure10(v0_1: US0, v1_1: US1, v2_1: US0, v3_1: US0, v4_1: US0, v5_1: US2, v6_1: US3, v7_1: US0, v8_1: US0, v9_1: US2, v10_1: US0, v11_1: US0, v12_1: US2, v13_1: US4, v14_1: US0, v15_1: US0, v16_1: US0, v17_1: US0, v18_1: US5, v19_1: US0, v20_1: US0, v21_1: US0, v22_1: US6, v23: US0, v24: US0, v25: US0, v26: US0, v27: US7, v28: US8, v29: US0, v30: US0, v31: US0, v32: US0, v33: US0, v34: US0, v35: US0, v36: US0, v37: US2, v38: US0, v39: US0, v40: US5, v41: US0, v42: US0, v43: US4, unitVar: void): any {
    const v44 = (v: Heap0): any => closure6(void 0, v);
    return [method14(v44, new Heap0(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, new US0(1, "https://github.com/fc1943s/tictactoe_spiral"), v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43))];
}

export function method17(v0_1: boolean): [(arg0: void) => boolean, (arg0: boolean) => void] {
    let value_1: any, value_2: any;
    const v3_1 = createSignal;
    const v4_1 = v3_1(v0_1);
    return [(value_1 = v4_1[0], value_1), (value_2 = v4_1[1], (arg_1: boolean): void => {
        value_2(arg_1);
    })];
}

export function closure11(unitVar: void, v0_1: Heap0): any {
    const v2_1 = createObj(method2(v0_1));
    const v5_1 = createComponent;
    return v5_1(Tr, v2_1);
}

export function closure13(unitVar: void, v0_1: Heap0): any {
    const v2_1 = createObj(method2(v0_1));
    const v5_1 = createComponent;
    return v5_1(Td, v2_1);
}

export function closure16(v0_1: any, unitVar: void): any {
    return [v0_1];
}

export function closure15(v0_1: US0, v1_1: US1, v2_1: US0, v3_1: US0, v4_1: US0, v5_1: US2, v6_1: US3, v7_1: US0, v8_1: US0, v9_1: US2, v10_1: US0, v11_1: US0, v12_1: US2, v13_1: US4, v14_1: US0, v15_1: US0, v16_1: US0, v17_1: US0, v18_1: US5, v19_1: US0, v20_1: US0, v21_1: US0, v22_1: US6, v23: US0, v24: US0, v25: US0, v26: US0, v27: US7, v28: US8, v29: US0, v30: US0, v31: US0, v32: US0, v33: US0, v34: US0, v35: US0, v36: US0, v37: US2, v38: US0, v39: US0, v40: US5, v41: US0, v42: US0, v43: US4, v44: any, unitVar: void): any {
    const v45 = (): any => closure16(v44, void 0);
    const v51 = createObj(method2(new Heap0(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, new US3(1, v45), v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, new US0(1, "2px"), v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43)));
    const v54 = createComponent;
    return [v54(Box, v51)];
}

export function closure17(v0_1: (arg0: boolean) => void, v1_1: any): void {
    v0_1(v1_1.target.checked);
}

export function closure14(v0_1: Heap0, v1_1: US0, v2_1: US1, v3_1: US0, v4_1: US0, v5_1: US0, v6_1: US2, v7_1: US3, v8_1: US0, v9_1: US0, v10_1: US2, v11_1: US0, v12_1: US0, v13_1: US2, v14_1: US4, v15_1: US0, v16_1: US0, v17_1: US0, v18_1: US0, v19_1: US5, v20_1: US0, v21_1: US0, v22_1: US0, v23: US6, v24: US0, v25: US0, v26: US0, v27: US0, v28: US7, v29: US8, v30: US0, v31: US0, v32: US0, v33: US0, v34: US0, v35: US0, v36: US0, v37: US0, v38: US2, v39: US0, v40: US0, v41: US5, v42: US0, v43: US0, v44: US4, v45: (arg0: boolean) => void, v46: (arg0: void) => boolean, v47: any, unitVar: void): any {
    let v52: (arg0: void) => any, v58: (arg0: any) => void, v64: any, v67: any;
    return [(v0_1.l37.tag === 1) ? ((v52 = ((): any => closure15(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v47, void 0)), (v58 = ((v: any): void => {
        closure17(v45, v);
    }), (v64 = createObj(method2(new Heap0(v1_1, v2_1, v3_1, v4_1, v5_1, new US2(1, v46()), new US3(1, v52), v8_1, new US0(1, "neutral"), v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, new US0(1, "2px"), v27, new US7(1, v58), v29, v30, v31, v32, v33, v34, v35, new US0(1, "sm"), v37, v38, v39, v40, v41, v42, v43, v44))), (v67 = createComponent, v67(Checkbox, v64)))))) : v47];
}

export function closure18(unitVar: void, unitVar_1: void): any {
    return [<>
        &nbsp;
    </>];
}

export function closure20(v0_1: (arg0: void) => any, unitVar: void): any {
    return [v0_1()];
}

export function closure21(v0_1: any, v1_1: Mut3): void {
    v0_1("set", v1_1);
}

export function method18(): [Mut3, (arg0: Mut3) => void] {
    const v2_1 = useStoreon;
    const v3_1 = v2_1();
    const v4_1 = v3_1[0];
    const v5_1 = v3_1[1];
    const v6_1 = (v: Mut3): void => {
        closure21(v5_1, v);
    };
    return [v4_1, v6_1];
}

export function closure22(v0_1: (arg0: void) => boolean, unitVar: void): Array<boolean> {
    return [v0_1()];
}

export function closure23(v0_1: (arg0: boolean) => void, v1_1: (arg0: void) => boolean, unitVar: void): void {
    if (v1_1()) {
        v0_1(false);
    }
}

export function closure24(unitVar: void, v0_1: Heap0): any {
    const v2_1 = createObj(method2(v0_1));
    const v5_1 = createComponent;
    return v5_1(Box, v2_1);
}

export function closure27(unitVar: void, unitVar_1: void): any {
    return [<>
        Load
    </>];
}

export function closure28(v0_1: (arg0: boolean) => void, v1_1: (arg0: Mut3) => void, v2_1: Mut3, unitVar: void): void {
    v0_1(true);
}

export function closure26(v0_1: US0, v1_1: US1, v2_1: US0, v3_1: US0, v4_1: US0, v5_1: US2, v6_1: US3, v7_1: US0, v8_1: US0, v9_1: US2, v10_1: US0, v11_1: US0, v12_1: US2, v13_1: US4, v14_1: US0, v15_1: US0, v16_1: US0, v17_1: US0, v18_1: US5, v19_1: US0, v20_1: US0, v21_1: US0, v22_1: US6, v23: US0, v24: US0, v25: US0, v26: US0, v27: US7, v28: US8, v29: US0, v30: US0, v31: US0, v32: US0, v33: US0, v34: US0, v35: US0, v36: US0, v37: US2, v38: US0, v39: US0, v40: US5, v41: US0, v42: US0, v43: US4, v44: (arg0: boolean) => void, v45: (arg0: Mut3) => void, v46: Mut3, unitVar: void): any {
    const v47 = (v: Heap0): any => closure0(void 0, v);
    const v48 = (): any => closure27(void 0, void 0);
    const v50 = (): void => {
        closure28(v44, v45, v46, void 0);
    };
    return [method14(v47, new Heap0(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, new US3(1, v48), v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, new US8(1, v50), v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43))];
}

export function closure31(unitVar: void, v0_1: Heap0): any {
    const v2_1 = createObj(method2(v0_1));
    const v5_1 = createComponent;
    return v5_1(Stack, v2_1);
}

export function method19(v0_1: any, v1_1: Heap0): any {
    const v5_1 = createComponent;
    return v5_1(v0_1, v1_1);
}

export function closure33(v0_1: (arg0: boolean) => void, unitVar: void): void {
    v0_1(true);
}

export function closure34(v0_1: (arg0: Mut3) => void, v1_1: Mut3, v2_1: int32, v3_1: (arg0: boolean) => void, v4_1: (arg0: void) => boolean, unitVar: void): void {
    const v6_1 = v4_1() === false;
    v3_1(v6_1);
    const v7_1 = (v6_1 ? v2_1 : 0) | 0;
    v1_1.l0 = (v7_1 | 0);
    toConsole(interpolate("%A%P()", ["new_state"]));
    v0_1(v1_1);
}

export function closure35(v0_1: (arg0: boolean) => void, unitVar: void): void {
    v0_1(false);
}

export function closure32(v0_1: US0, v1_1: US1, v2_1: US0, v3_1: US0, v4_1: US0, v5_1: US2, v6_1: US3, v7_1: US0, v8_1: US0, v9_1: US2, v10_1: US0, v11_1: US0, v12_1: US2, v13_1: US4, v14_1: US0, v15_1: US0, v16_1: US0, v17_1: US0, v18_1: US5, v19_1: US0, v20_1: US0, v21_1: US0, v22_1: US6, v23: US0, v24: US0, v25: US0, v26: US0, v27: US7, v28: US8, v29: US0, v30: US0, v31: US0, v32: US0, v33: US0, v34: US0, v35: US0, v36: US0, v37: US2, v38: US0, v39: US0, v40: US5, v41: US0, v42: US0, v43: US4, v44: (arg0: Mut3) => void, v45: Mut3, v46: int32, v47: (arg0: boolean) => void, v48: (arg0: boolean) => void, v49: (arg0: boolean) => void, v50: (arg0: void) => boolean, unitVar: void): any {
    let v84: any, v86: any;
    const v53 = BiRegularRefresh;
    const v54 = "14px";
    const v60 = "neutral";
    const v62 = "20px";
    const v65 = (): void => {
        closure33(v48, void 0);
    };
    const v67 = "xs";
    const v71 = createObj(method2(new Heap0(new US0(1, "Refresh"), v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, new US0(1, v60), v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, new US0(1, v62), v17_1, new US5(1, method19(v53, new Heap0(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, new US0(1, v54), v36, v37, v38, v39, v40, v41, v42, v43))), v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, new US8(1, v65), v29, v30, v31, v32, v33, v34, new US0(1, v67), v36, v37, v38, v39, v40, v41, v42, v43)));
    const v74 = createComponent;
    const v77 = v74(IconButton, v71);
    const v95 = (): void => {
        closure34(v44, v45, v46, v49, v50, void 0);
    };
    const v100 = createObj(method2(new Heap0(new US0(1, v50() ? "Restore" : "Maximize"), v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, new US0(1, v60), v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, new US0(1, v62), v17_1, new US5(1, method19(v50() ? ((v84 = BiRegularDownArrow, v84)) : ((v86 = BiRegularUpArrow, v86)), new Heap0(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, new US0(1, v54), v36, v37, v38, v39, v40, v41, v42, v43))), v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, new US8(1, v95), v29, v30, v31, v32, v33, v34, new US0(1, v67), v36, v37, v38, v39, v40, v41, v42, v43)));
    const v101 = createComponent;
    const v102 = v101(IconButton, v100);
    const v104 = BiRegularUndo;
    const v113 = (): void => {
        closure35(v47, void 0);
    };
    const v118 = createObj(method2(new Heap0(new US0(1, "Unload"), v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, new US0(1, v60), v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, new US0(1, v62), v17_1, new US5(1, method19(v104, new Heap0(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, new US0(1, v54), v36, v37, v38, v39, v40, v41, v42, v43))), v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, new US8(1, v113), v29, v30, v31, v32, v33, v34, new US0(1, v67), v36, v37, v38, v39, v40, v41, v42, v43)));
    const v119 = createComponent;
    return [v77, v102, v119(IconButton, v118)];
}

export function closure30(v0_1: US0, v1_1: US1, v2_1: US0, v3_1: US0, v4_1: US0, v5_1: US2, v6_1: US3, v7_1: US0, v8_1: US0, v9_1: US2, v10_1: US0, v11_1: US0, v12_1: US2, v13_1: US4, v14_1: US0, v15_1: US0, v16_1: US0, v17_1: US0, v18_1: US5, v19_1: US0, v20_1: US0, v21_1: US0, v22_1: US6, v23: US0, v24: US0, v25: US0, v26: US0, v27: US7, v28: US8, v29: US0, v30: US0, v31: US0, v32: US0, v33: US0, v34: US0, v35: US0, v36: US0, v37: US2, v38: US0, v39: US0, v40: US5, v41: US0, v42: US0, v43: US4, v44: (arg0: Mut3) => void, v45: Mut3, v46: int32, v47: (arg0: boolean) => void, v48: (arg0: boolean) => void, v49: (arg0: void) => boolean, v50: (arg0: boolean) => void, v51: (arg0: void) => boolean, v52: (arg0: void) => any, unitVar: void): any {
    const v53 = (v: Heap0): any => closure31(void 0, v);
    const v60 = (): any => closure32(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v50, v51, void 0);
    const v66 = "6px";
    return [method14(v53, new Heap0(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, new US3(1, v60), v7_1, v8_1, v9_1, new US0(1, "row"), (v45.l0 === v46) ? (new US0(1, "none")) : (new US0(0)), v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, new US0(1, "absolute"), new US0(1, v66), v35, new US0(1, "3px"), v37, v38, v39, v40, new US0(1, v66), v42, new US4(1, 1))), (v49() === false) ? v52() : <></>];
}

export function closure29(v0_1: Heap0, v1_1: US0, v2_1: US1, v3_1: US0, v4_1: US0, v5_1: US0, v6_1: US2, v7_1: US3, v8_1: US0, v9_1: US0, v10_1: US2, v11_1: US0, v12_1: US0, v13_1: US2, v14_1: US4, v15_1: US0, v16_1: US0, v17_1: US0, v18_1: US0, v19_1: US5, v20_1: US0, v21_1: US0, v22_1: US0, v23: US6, v24: US0, v25: US0, v26: US0, v27: US0, v28: US7, v29: US8, v30: US0, v31: US0, v32: US0, v33: US0, v34: US0, v35: US0, v36: US0, v37: US0, v38: US2, v39: US0, v40: US0, v41: US5, v42: US0, v43: US0, v44: US4, v45: (arg0: Mut3) => void, v46: Mut3, v47: int32, v48: (arg0: boolean) => void, v49: (arg0: boolean) => void, v50: (arg0: void) => boolean, v51: (arg0: boolean) => void, v52: (arg0: void) => boolean, unitVar: void): any {
    let v56: (arg0: Heap0) => any, v63: (arg0: void) => any;
    const v53 = v0_1.l6;
    return [(v53.tag === 1) ? ((v56 = ((v: Heap0): any => closure24(void 0, v)), (v63 = ((): any => closure30(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53.fields[0], void 0)), method14(v56, new Heap0(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, new US3(1, v63), v8_1, v9_1, v10_1, v11_1, new US0(1, "flex"), v13_1, new US4(1, 1), v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, (v46.l0 <= 0) ? (new US0(1, "relative")) : (new US0(0)), v35, v36, v37, v38, v39, v40, v41, v42, v43, v44))))) : <></>];
}

export function closure25(v0_1: Heap0, v1_1: US0, v2_1: US1, v3_1: US0, v4_1: US0, v5_1: US0, v6_1: US2, v7_1: US3, v8_1: US0, v9_1: US0, v10_1: US2, v11_1: US0, v12_1: US0, v13_1: US2, v14_1: US4, v15_1: US0, v16_1: US0, v17_1: US0, v18_1: US0, v19_1: US5, v20_1: US0, v21_1: US0, v22_1: US0, v23: US6, v24: US0, v25: US0, v26: US0, v27: US0, v28: US7, v29: US8, v30: US0, v31: US0, v32: US0, v33: US0, v34: US0, v35: US0, v36: US0, v37: US0, v38: US2, v39: US0, v40: US0, v41: US5, v42: US0, v43: US0, v44: US4, v45: (arg0: Mut3) => void, v46: Mut3, v47: int32, v48: (arg0: boolean) => void, v49: (arg0: void) => boolean, v50: (arg0: boolean) => void, v51: (arg0: void) => boolean, v52: (arg0: boolean) => void, v53: (arg0: void) => boolean, unitVar: void): any {
    let v56: (arg0: Heap0) => any, v57: (arg0: void) => any, v61: (arg0: Heap0) => any, v65: US4, v70: US0, v75: US0, v80: US0, v85: US0, v90: US0, v96: (arg0: void) => any;
    return [(v49() === false) ? ((v56 = ((v: Heap0): any => closure24(void 0, v)), (v57 = ((): any => closure26(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v48, v45, v46, void 0)), method14(v56, new Heap0(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, new US3(1, v57), v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44))))) : ((v61 = ((v_1: Heap0): any => closure24(void 0, v_1)), (v65 = (v53() ? (new US4(1, 1)) : (new US4(0))), (v70 = (v53() ? (new US0(1, "absolute")) : (new US0(0))), (v75 = (v53() ? (new US0(1, "0")) : (new US0(0))), (v80 = (v53() ? (new US0(1, "0")) : (new US0(0))), (v85 = (v53() ? (new US0(1, "0")) : (new US0(0))), (v90 = (v53() ? (new US0(1, "0")) : (new US0(0))), (v96 = ((): any => closure29(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v50, v51, v52, v53, void 0)), method14(v61, new Heap0(v1_1, v2_1, v53() ? (new US0(1, "$bg")) : (new US0(0)), v4_1, v85, v6_1, new US3(1, v96), v8_1, v9_1, v10_1, v11_1, new US0(1, "flex"), v13_1, new US4(1, 1), v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v90, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v70, v80, v36, v37, v38, v39, v40, v41, v75, v43, v65)))))))))))];
}

export function closure19(v0_1: Heap0, v1_1: US0, v2_1: US1, v3_1: US0, v4_1: US0, v5_1: US0, v6_1: US2, v7_1: US3, v8_1: US0, v9_1: US0, v10_1: US2, v11_1: US0, v12_1: US0, v13_1: US2, v14_1: US4, v15_1: US0, v16_1: US0, v17_1: US0, v18_1: US0, v19_1: US5, v20_1: US0, v21_1: US0, v22_1: US0, v23: US6, v24: US0, v25: US0, v26: US0, v27: US0, v28: US7, v29: US8, v30: US0, v31: US0, v32: US0, v33: US0, v34: US0, v35: US0, v36: US0, v37: US0, v38: US2, v39: US0, v40: US0, v41: US5, v42: US0, v43: US0, v44: US4, v45: (arg0: void) => boolean, v46: (arg0: void) => any, unitVar: void): any {
    let v51: (arg0: void) => any, v53: Heap0, patternInput: [US0, US1, US0, US0, US0, US2, US3, US0, US0, US2, US0, US0, US2, US4, US0, US0, US0, US0, US5, US0, US0, US0, US6, US0, US0, US0, US0, US7, US8, US0, US0, US0, US0, US0, US0, US0, US0, US2, US0, US0, US5, US0, US0, US4], v97: US4, v96: US0, v95: US0, v94: US5, v93: US0, v92: US0, v91: US2, v90: US0, v89: US0, v88: US0, v87: US0, v86: US0, v85: US0, v84: US0, v83: US0, v82: US8, v81: US7, v80: US0, v79: US0, v78: US0, v77: US0, v76: US6, v75: US0, v74: US0, v72: US5, v71: US0, v70: US0, v69: US0, v68: US0, v66: US2, v64: US0, v63: US2, v62: US0, v61: US0, v59: US2, v58: US0, v57: US0, v56: US0, v55: US1, v54: US0, patternInput_1: [Mut3, (arg0: Mut3) => void], v100: int32, patternInput_2: [(arg0: void) => boolean, (arg0: boolean) => void], patternInput_3: [(arg0: void) => boolean, (arg0: boolean) => void], v106: (arg0: boolean) => void, v105: (arg0: void) => boolean, patternInput_4: [(arg0: void) => boolean, (arg0: boolean) => void], v112: any, v113: (arg0: void) => Array<boolean>, v114: (arg0: void) => void, v115: any, v117: any, v118: (arg0: Heap0) => any, v120: (arg0: void) => any;
    return [(v0_1.l37.tag === 1) ? (v45() ? ((v51 = ((): any => closure20(v46, void 0)), (v53 = (new Heap0(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, new US3(1, v51), v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44)), (patternInput = method0(), (v97 = patternInput[43], (v96 = patternInput[42], (v95 = patternInput[41], (v94 = patternInput[40], (v93 = patternInput[39], (v92 = patternInput[38], (v91 = patternInput[37], (v90 = patternInput[36], (v89 = patternInput[35], (v88 = patternInput[34], (v87 = patternInput[33], (v86 = patternInput[32], (v85 = patternInput[31], (v84 = patternInput[30], (v83 = patternInput[29], (v82 = patternInput[28], (v81 = patternInput[27], (v80 = patternInput[26], (v79 = patternInput[25], (v78 = patternInput[24], (v77 = patternInput[23], (v76 = patternInput[22], (v75 = patternInput[21], (v74 = patternInput[20], (v72 = patternInput[18], (v71 = patternInput[17], (v70 = patternInput[16], (v69 = patternInput[15], (v68 = patternInput[14], (v66 = patternInput[12], (v64 = patternInput[10], (v63 = patternInput[9], (v62 = patternInput[8], (v61 = patternInput[7], (v59 = patternInput[5], (v58 = patternInput[4], (v57 = patternInput[3], (v56 = patternInput[2], (v55 = patternInput[1], (v54 = patternInput[0], (patternInput_1 = method18(), (v100 = (nonSeeded().Next0() | 0), (patternInput_2 = method17(true), (patternInput_3 = method17(false), (v106 = patternInput_3[1], (v105 = patternInput_3[0], (patternInput_4 = method17(false), (v112 = on, (v113 = ((): Array<boolean> => closure22(v105, void 0)), (v114 = ((): void => {
        closure23(v106, v105, void 0);
    }), (v115 = (v112(v113, v114)), (v117 = createEffect, (void (v117(v115)), (v118 = ((v: Heap0): any => closure24(void 0, v)), (v120 = ((): any => closure25(v53, v54, v55, v56, v57, v58, v59, patternInput[6], v61, v62, v63, v64, patternInput[11], v66, patternInput[13], v68, v69, v70, v71, v72, patternInput[19], v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, patternInput_1[1], patternInput_1[0], v100, patternInput_2[1], patternInput_2[0], v106, v105, patternInput_4[1], patternInput_4[0], void 0)), method14(v118, new Heap0(v54, v55, v56, v57, v58, v59, new US3(1, v120), v61, v62, v63, v64, new US0(1, "flex"), v66, new US4(1, 1), v68, v69, v70, v71, v72, v53.l19, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))) : <></>) : v46()];
}

export function closure12(v0_1: Heap0, v1_1: US0, v2_1: US1, v3_1: US0, v4_1: US0, v5_1: US0, v6_1: US2, v7_1: US3, v8_1: US0, v9_1: US0, v10_1: US2, v11_1: US0, v12_1: US0, v13_1: US2, v14_1: US4, v15_1: US0, v16_1: US0, v17_1: US0, v18_1: US0, v19_1: US5, v20_1: US0, v21_1: US0, v22_1: US0, v23: US6, v24: US0, v25: US0, v26: US0, v27: US0, v28: US7, v29: US8, v30: US0, v31: US0, v32: US0, v33: US0, v34: US0, v35: US0, v36: US0, v37: US0, v38: US2, v39: US0, v40: US0, v41: US5, v42: US0, v43: US0, v44: US4, v45: (arg0: boolean) => void, v46: (arg0: void) => boolean, unitVar: void): any {
    let v50: (arg0: Heap0) => any, v53: (arg0: void) => any, v81: (arg0: Heap0) => any, v82: US0, v88: (arg0: void) => any, v97: string, v71: (arg0: Heap0) => any, v72: (arg0: void) => any;
    const v47 = v0_1.l40;
    const v70 = v0_1.l6;
    return [(v47.tag === 1) ? ((v50 = ((v: Heap0): any => closure13(void 0, v)), (v53 = ((): any => closure14(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47.fields[0], void 0)), method14(v50, new Heap0(v1_1, v2_1, v3_1, new US0(1, "0 !important"), v5_1, v6_1, new US3(1, v53), new US0(1, "$neutral9"), v9_1, v10_1, v11_1, new US0(1, "flex"), v13_1, v14_1, new US0(1, "column"), new US0(1, "$sm"), v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, new US0(1, "1px solid $neutral5"), v31, new US0(1, "3px 20px 0 8px"), v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44))))) : <></>, (v70.tag === 1) ? ((v81 = ((v_2: Heap0): any => closure13(void 0, v_2)), (v82 = v0_1.l31, (v88 = ((): any => closure19(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v46, v70.fields[0], void 0)), (v97 = "0", method14(v81, new Heap0(v1_1, v2_1, v3_1, new US0(1, "0 !important"), v5_1, v6_1, new US3(1, v88), v8_1, v9_1, v10_1, v11_1, new US0(1, "flex"), v13_1, new US4(1, 6), new US0(1, "column"), new US0(1, "$sm"), v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, new US0(1, v97), v26, new US0(1, "85vh"), v28, v29, new US0(1, v97), new US0(1, "auto"), new US0(1, (v82.tag === 1) ? v82.fields[0] : "0"), v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44))))))) : ((v71 = ((v_1: Heap0): any => closure13(void 0, v_1)), (v72 = ((): any => closure18(void 0, void 0)), method14(v71, new Heap0(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, new US3(1, v72), v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, new US0(1, "9px"), v25, v26, v27, v28, v29, v30, v31, new US0(1, "0"), v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44)))))];
}

export function closure36(v0_1: US0, v1_1: US1, v2_1: US0, v3_1: US0, v4_1: US0, v5_1: US2, v6_1: US3, v7_1: US0, v8_1: US0, v9_1: US2, v10_1: US0, v11_1: US0, v12_1: US2, v13_1: US4, v14_1: US0, v15_1: US0, v16_1: US0, v17_1: US0, v18_1: US5, v19_1: US0, v20_1: US0, v21_1: US0, v22_1: US6, v23: US0, v24: US0, v25: US0, v26: US0, v27: US7, v28: US8, v29: US0, v30: US0, v31: US0, v32: US0, v33: US0, v34: US0, v35: US0, v36: US0, v37: US2, v38: US0, v39: US0, v40: US5, v41: US0, v42: US0, v43: US4, unitVar: void): any {
    const v44 = (v: Heap0): any => closure6(void 0, v);
    return [method14(v44, new Heap0(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, new US0(1, "https://fc1943s.github.io/tictactoe_spiral"), v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43))];
}

export function closure37(v0_1: US0, v1_1: US1, v2_1: US0, v3_1: US0, v4_1: US0, v5_1: US2, v6_1: US3, v7_1: US0, v8_1: US0, v9_1: US2, v10_1: US0, v11_1: US0, v12_1: US2, v13_1: US4, v14_1: US0, v15_1: US0, v16_1: US0, v17_1: US0, v18_1: US5, v19_1: US0, v20_1: US0, v21_1: US0, v22_1: US6, v23: US0, v24: US0, v25: US0, v26: US0, v27: US7, v28: US8, v29: US0, v30: US0, v31: US0, v32: US0, v33: US0, v34: US0, v35: US0, v36: US0, v37: US2, v38: US0, v39: US0, v40: US5, v41: US0, v42: US0, v43: US4, unitVar: void): any {
    const v44 = (v: Heap0): any => closure6(void 0, v);
    return [method14(v44, new Heap0(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, new US0(1, "https://fc1943s.github.io/tictactoe_spiral/docs"), v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43))];
}

export function closure9(v0_1: US0, v1_1: US1, v2_1: US0, v3_1: US0, v4_1: US0, v5_1: US2, v6_1: US3, v7_1: US0, v8_1: US0, v9_1: US2, v10_1: US0, v11_1: US0, v12_1: US2, v13_1: US4, v14_1: US0, v15_1: US0, v16_1: US0, v17_1: US0, v18_1: US5, v19_1: US0, v20_1: US0, v21_1: US0, v22_1: US6, v23: US0, v24: US0, v25: US0, v26: US0, v27: US7, v28: US8, v29: US0, v30: US0, v31: US0, v32: US0, v33: US0, v34: US0, v35: US0, v36: US0, v37: US2, v38: US0, v39: US0, v40: US5, v41: US0, v42: US0, v43: US4, unitVar: void): any {
    const v44 = (): any => closure10(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, void 0);
    const v46 = "1px 6px";
    const v48 = new Heap0(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, new US3(1, v44), v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, new US0(1, v46), v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);
    const patternInput = method0();
    const v92 = patternInput[43];
    const v91 = patternInput[42];
    const v90 = patternInput[41];
    const v89 = patternInput[40];
    const v88 = patternInput[39];
    const v87 = patternInput[38];
    const v86 = patternInput[37];
    const v85 = patternInput[36];
    const v84 = patternInput[35];
    const v83 = patternInput[34];
    const v82 = patternInput[33];
    const v81 = patternInput[32];
    const v80 = patternInput[31];
    const v79 = patternInput[30];
    const v78 = patternInput[29];
    const v77 = patternInput[28];
    const v76 = patternInput[27];
    const v75 = patternInput[26];
    const v74 = patternInput[25];
    const v73 = patternInput[24];
    const v72 = patternInput[23];
    const v71 = patternInput[22];
    const v70 = patternInput[21];
    const v69 = patternInput[20];
    const v67 = patternInput[18];
    const v66 = patternInput[17];
    const v65 = patternInput[16];
    const v64 = patternInput[15];
    const v61 = patternInput[12];
    const v59 = patternInput[10];
    const v58 = patternInput[9];
    const v57 = patternInput[8];
    const v56 = patternInput[7];
    const v54 = patternInput[5];
    const v53 = patternInput[4];
    const v51 = patternInput[2];
    const v50 = patternInput[1];
    const v49 = patternInput[0];
    const v93 = v48.l37;
    const patternInput_1 = method17(((v93.tag === 1) && (v93.fields[0] === false)) !== true);
    const v101 = (v: Heap0): any => closure11(void 0, v);
    const v104 = "1px solid $neutral5";
    const v106 = (): any => closure12(v48, v49, v50, v51, patternInput[3], v53, v54, patternInput[6], v56, v57, v58, v59, patternInput[11], v61, patternInput[13], patternInput[14], v64, v65, v66, v67, patternInput[19], v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, patternInput_1[1], patternInput_1[0], void 0);
    const v108 = "flex";
    const v113 = method14(v101, new Heap0(v49, v50, v51, new US0(1, v104), v53, v54, new US3(1, v106), v56, v57, v58, v59, new US0(1, v108), v61, new US4(1, 1), new US0(1, {
        "@initial": "column",
        "@sm": "row",
    }), v64, v65, v66, v67, v48.l19, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92));
    const v114 = (): any => closure36(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, void 0);
    const v117 = new Heap0(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, new US3(1, v114), v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, new US0(1, v46), v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);
    const patternInput_2 = method0();
    const v161 = patternInput_2[43];
    const v160 = patternInput_2[42];
    const v159 = patternInput_2[41];
    const v158 = patternInput_2[40];
    const v157 = patternInput_2[39];
    const v156 = patternInput_2[38];
    const v155 = patternInput_2[37];
    const v154 = patternInput_2[36];
    const v153 = patternInput_2[35];
    const v152 = patternInput_2[34];
    const v151 = patternInput_2[33];
    const v150 = patternInput_2[32];
    const v149 = patternInput_2[31];
    const v148 = patternInput_2[30];
    const v147 = patternInput_2[29];
    const v146 = patternInput_2[28];
    const v145 = patternInput_2[27];
    const v144 = patternInput_2[26];
    const v143 = patternInput_2[25];
    const v142 = patternInput_2[24];
    const v141 = patternInput_2[23];
    const v140 = patternInput_2[22];
    const v139 = patternInput_2[21];
    const v138 = patternInput_2[20];
    const v136 = patternInput_2[18];
    const v135 = patternInput_2[17];
    const v134 = patternInput_2[16];
    const v133 = patternInput_2[15];
    const v130 = patternInput_2[12];
    const v128 = patternInput_2[10];
    const v127 = patternInput_2[9];
    const v126 = patternInput_2[8];
    const v125 = patternInput_2[7];
    const v123 = patternInput_2[5];
    const v122 = patternInput_2[4];
    const v120 = patternInput_2[2];
    const v119 = patternInput_2[1];
    const v118 = patternInput_2[0];
    const v162 = v117.l37;
    const patternInput_3 = method17(((v162.tag === 1) && (v162.fields[0] === false)) !== true);
    const v173 = (): any => closure12(v117, v118, v119, v120, patternInput_2[3], v122, v123, patternInput_2[6], v125, v126, v127, v128, patternInput_2[11], v130, patternInput_2[13], patternInput_2[14], v133, v134, v135, v136, patternInput_2[19], v138, v139, v140, v141, v142, v143, v144, v145, v146, v147, v148, v149, v150, v151, v152, v153, v154, v155, v156, v157, v158, v159, v160, v161, patternInput_3[1], patternInput_3[0], void 0);
    const v179 = method14(v101, new Heap0(v118, v119, v120, new US0(1, v104), v122, v123, new US3(1, v173), v125, v126, v127, v128, new US0(1, v108), v130, new US4(1, 1), new US0(1, {
        "@initial": "column",
        "@sm": "row",
    }), v133, v134, v135, v136, v117.l19, v138, v139, v140, v141, v142, v143, v144, v145, v146, v147, v148, v149, v150, v151, v152, v153, v154, v155, v156, v157, v158, v159, v160, v161));
    const v180 = (): any => closure37(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, void 0);
    const v183 = new Heap0(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, new US3(1, v180), v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, new US0(1, v46), v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);
    const patternInput_4 = method0();
    const v227 = patternInput_4[43];
    const v226 = patternInput_4[42];
    const v225 = patternInput_4[41];
    const v224 = patternInput_4[40];
    const v223 = patternInput_4[39];
    const v222 = patternInput_4[38];
    const v221 = patternInput_4[37];
    const v220 = patternInput_4[36];
    const v219 = patternInput_4[35];
    const v218 = patternInput_4[34];
    const v217 = patternInput_4[33];
    const v216 = patternInput_4[32];
    const v215 = patternInput_4[31];
    const v214 = patternInput_4[30];
    const v213 = patternInput_4[29];
    const v212 = patternInput_4[28];
    const v211 = patternInput_4[27];
    const v210 = patternInput_4[26];
    const v209 = patternInput_4[25];
    const v208 = patternInput_4[24];
    const v207 = patternInput_4[23];
    const v206 = patternInput_4[22];
    const v205 = patternInput_4[21];
    const v204 = patternInput_4[20];
    const v202 = patternInput_4[18];
    const v201 = patternInput_4[17];
    const v200 = patternInput_4[16];
    const v199 = patternInput_4[15];
    const v196 = patternInput_4[12];
    const v194 = patternInput_4[10];
    const v193 = patternInput_4[9];
    const v192 = patternInput_4[8];
    const v191 = patternInput_4[7];
    const v189 = patternInput_4[5];
    const v188 = patternInput_4[4];
    const v186 = patternInput_4[2];
    const v185 = patternInput_4[1];
    const v184 = patternInput_4[0];
    const v228 = v183.l37;
    const patternInput_5 = method17(((v228.tag === 1) && (v228.fields[0] === false)) !== true);
    const v239 = (): any => closure12(v183, v184, v185, v186, patternInput_4[3], v188, v189, patternInput_4[6], v191, v192, v193, v194, patternInput_4[11], v196, patternInput_4[13], patternInput_4[14], v199, v200, v201, v202, patternInput_4[19], v204, v205, v206, v207, v208, v209, v210, v211, v212, v213, v214, v215, v216, v217, v218, v219, v220, v221, v222, v223, v224, v225, v226, v227, patternInput_5[1], patternInput_5[0], void 0);
    return [v113, v179, method14(v101, new Heap0(v184, v185, v186, new US0(1, v104), v188, v189, new US3(1, v239), v191, v192, v193, v194, new US0(1, v108), v196, new US4(1, 1), new US0(1, {
        "@initial": "column",
        "@sm": "row",
    }), v199, v200, v201, v202, v183.l19, v204, v205, v206, v207, v208, v209, v210, v211, v212, v213, v214, v215, v216, v217, v218, v219, v220, v221, v222, v223, v224, v225, v226, v227))];
}

export function closure8(unitVar: void, unitVar_1: void): any {
    const patternInput = method0();
    const v9_1 = patternInput[9];
    const v8_1 = patternInput[8];
    const v7_1 = patternInput[7];
    const v5_1 = patternInput[5];
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
    const v33 = patternInput[33];
    const v32 = patternInput[32];
    const v31 = patternInput[31];
    const v30 = patternInput[30];
    const v3_1 = patternInput[3];
    const v29 = patternInput[29];
    const v28 = patternInput[28];
    const v27 = patternInput[27];
    const v26 = patternInput[26];
    const v25 = patternInput[25];
    const v24 = patternInput[24];
    const v23 = patternInput[23];
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
    const v44 = (v: Heap0): any => closure1(void 0, v);
    const v45 = (): any => closure9(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, patternInput[6], v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, void 0);
    return method14(v44, new Heap0(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, new US3(1, v45), v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43));
}

export function closure41(v0_1: (arg0: boolean) => void, v1_1: US10, v2_1: (arg0: Mut3) => void, v3_1: Mut3, unitVar: void): void {
    if (v1_1.tag === 1) {
        v1_1.fields[0](v3_1, v2_1);
    }
    v0_1(true);
}

export function closure40(v0_1: US0, v1_1: US1, v2_1: US0, v3_1: US0, v4_1: US0, v5_1: US2, v6_1: US3, v7_1: US0, v8_1: US0, v9_1: US2, v10_1: US0, v11_1: US0, v12_1: US2, v13_1: US4, v14_1: US0, v15_1: US0, v16_1: US0, v17_1: US0, v18_1: US5, v19_1: US0, v20_1: US0, v21_1: US0, v22_1: US6, v23: US0, v24: US0, v25: US0, v26: US0, v27: US7, v28: US8, v29: US0, v30: US0, v31: US0, v32: US0, v33: US0, v34: US0, v35: US0, v36: US0, v37: US2, v38: US0, v39: US0, v40: US5, v41: US0, v42: US0, v43: US4, v44: (arg0: boolean) => void, v45: US10, v46: (arg0: Mut3) => void, v47: Mut3, unitVar: void): any {
    const v48 = (v: Heap0): any => closure0(void 0, v);
    const v49 = (): any => closure27(void 0, void 0);
    const v51 = (): void => {
        closure41(v44, v45, v46, v47, void 0);
    };
    return [method14(v48, new Heap0(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, new US3(1, v49), v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, new US8(1, v51), v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43))];
}

export function closure39(v0_1: Heap0, v1_1: US0, v2_1: US1, v3_1: US0, v4_1: US0, v5_1: US0, v6_1: US2, v7_1: US3, v8_1: US0, v9_1: US0, v10_1: US2, v11_1: US0, v12_1: US0, v13_1: US2, v14_1: US4, v15_1: US0, v16_1: US0, v17_1: US0, v18_1: US0, v19_1: US5, v20_1: US0, v21_1: US0, v22_1: US0, v23: US6, v24: US0, v25: US0, v26: US0, v27: US0, v28: US7, v29: US8, v30: US0, v31: US0, v32: US0, v33: US0, v34: US0, v35: US0, v36: US0, v37: US0, v38: US2, v39: US0, v40: US0, v41: US5, v42: US0, v43: US0, v44: US4, v45: (arg0: Mut3) => void, v46: Mut3, v47: int32, v48: (arg0: boolean) => void, v49: (arg0: void) => boolean, v50: (arg0: boolean) => void, v51: (arg0: void) => boolean, v52: (arg0: boolean) => void, v53: (arg0: void) => boolean, v54: US10, unitVar: void): any {
    let v57: (arg0: Heap0) => any, v58: (arg0: void) => any, v62: (arg0: Heap0) => any, v66: US4, v71: US0, v76: US0, v81: US0, v86: US0, v91: US0, v97: (arg0: void) => any;
    return [(v49() === false) ? ((v57 = ((v: Heap0): any => closure24(void 0, v)), (v58 = ((): any => closure40(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v48, v54, v45, v46, void 0)), method14(v57, new Heap0(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, new US3(1, v58), v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44))))) : ((v62 = ((v_1: Heap0): any => closure24(void 0, v_1)), (v66 = (v53() ? (new US4(1, 1)) : (new US4(0))), (v71 = (v53() ? (new US0(1, "absolute")) : (new US0(0))), (v76 = (v53() ? (new US0(1, "0")) : (new US0(0))), (v81 = (v53() ? (new US0(1, "0")) : (new US0(0))), (v86 = (v53() ? (new US0(1, "0")) : (new US0(0))), (v91 = (v53() ? (new US0(1, "0")) : (new US0(0))), (v97 = ((): any => closure29(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v50, v51, v52, v53, void 0)), method14(v62, new Heap0(v1_1, v2_1, v53() ? (new US0(1, "$bg")) : (new US0(0)), v4_1, v86, v6_1, new US3(1, v97), v8_1, v9_1, v10_1, v11_1, new US0(1, "flex"), v13_1, new US4(1, 1), v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v91, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v71, v81, v36, v37, v38, v39, v40, v41, v76, v43, v66)))))))))))];
}

export function closure38(unitVar: void, _arg: [boolean, boolean, US10, Heap0]): any {
    const v3_1 = _arg[3];
    const v2_1 = _arg[2];
    const v0_1 = _arg[0];
    const patternInput = method0();
    const v9_1 = patternInput[5];
    const v8_1 = patternInput[4];
    const v7_1 = patternInput[3];
    const v6_1 = patternInput[2];
    const v5_1 = patternInput[1];
    const v47 = patternInput[43];
    const v46 = patternInput[42];
    const v45 = patternInput[41];
    const v44 = patternInput[40];
    const v43 = patternInput[39];
    const v42 = patternInput[38];
    const v41 = patternInput[37];
    const v40 = patternInput[36];
    const v4_1 = patternInput[0];
    const v39 = patternInput[35];
    const v38 = patternInput[34];
    const v37 = patternInput[33];
    const v36 = patternInput[32];
    const v35 = patternInput[31];
    const v34 = patternInput[30];
    const v33 = patternInput[29];
    const v32 = patternInput[28];
    const v31 = patternInput[27];
    const v30 = patternInput[26];
    const v29 = patternInput[25];
    const v28 = patternInput[24];
    const v27 = patternInput[23];
    const v26 = patternInput[22];
    const v25 = patternInput[21];
    const v24 = patternInput[20];
    const v22_1 = patternInput[18];
    const v21_1 = patternInput[17];
    const v20_1 = patternInput[16];
    const v19_1 = patternInput[15];
    const v18_1 = patternInput[14];
    const v16_1 = patternInput[12];
    const v14_1 = patternInput[10];
    const v13_1 = patternInput[9];
    const v12_1 = patternInput[8];
    const v11_1 = patternInput[7];
    const patternInput_1 = method18();
    const v49 = patternInput_1[1];
    const v48 = patternInput_1[0];
    const v50 = nonSeeded().Next0() | 0;
    const patternInput_2 = method17(v0_1);
    const patternInput_3 = method17(false);
    const v55 = patternInput_3[1];
    const v54 = patternInput_3[0];
    const patternInput_4 = method17(_arg[1]);
    const v60 = on;
    const v61 = (): Array<boolean> => closure22(v54, void 0);
    const v62 = (): void => {
        closure23(v55, v54, void 0);
    };
    const v63 = v60(v61, v62);
    const v65 = createEffect;
    v65(v63);
    if (v0_1) {
        if (v2_1.tag === 1) {
            v2_1.fields[0](v48, v49);
        }
    }
    const v68 = (v: Heap0): any => closure24(void 0, v);
    const v70 = (): any => closure39(v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, patternInput[6], v11_1, v12_1, v13_1, v14_1, patternInput[11], v16_1, patternInput[13], v18_1, v19_1, v20_1, v21_1, v22_1, patternInput[19], v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v49, v48, v50, patternInput_2[1], patternInput_2[0], v55, v54, patternInput_4[1], patternInput_4[0], v2_1, void 0);
    return method14(v68, new Heap0(v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, new US3(1, v70), v11_1, v12_1, v13_1, v14_1, new US0(1, "flex"), v16_1, new US4(1, 1), v18_1, v19_1, v20_1, v21_1, v22_1, v3_1.l19, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47));
}

export function closure44(v0_1: US10, v1_1: Heap0, v2_1: US0, v3_1: US1, v4_1: US0, v5_1: US0, v6_1: US0, v7_1: US2, v8_1: US3, v9_1: US0, v10_1: US0, v11_1: US2, v12_1: US0, v13_1: US0, v14_1: US2, v15_1: US4, v16_1: US0, v17_1: US0, v18_1: US0, v19_1: US0, v20_1: US5, v21_1: US0, v22_1: US0, v23: US0, v24: US6, v25: US0, v26: US0, v27: US0, v28: US0, v29: US7, v30: US8, v31: US0, v32: US0, v33: US0, v34: US0, v35: US0, v36: US0, v37: US0, v38: US0, v39: US2, v40: US0, v41: US0, v42: US5, v43: US0, v44: US0, v45: US4, v46: (arg0: void) => boolean, v47: (arg0: void) => any, unitVar: void): any {
    let v52: (arg0: void) => any, v54: Heap0, patternInput: [US0, US1, US0, US0, US0, US2, US3, US0, US0, US2, US0, US0, US2, US4, US0, US0, US0, US0, US5, US0, US0, US0, US6, US0, US0, US0, US0, US7, US8, US0, US0, US0, US0, US0, US0, US0, US0, US2, US0, US0, US5, US0, US0, US4], v98: US4, v97: US0, v96: US0, v95: US5, v94: US0, v93: US0, v92: US2, v91: US0, v90: US0, v89: US0, v88: US0, v87: US0, v86: US0, v85: US0, v84: US0, v83: US8, v82: US7, v81: US0, v80: US0, v79: US0, v78: US0, v77: US6, v76: US0, v75: US0, v73: US5, v72: US0, v71: US0, v70: US0, v69: US0, v67: US2, v65: US0, v64: US2, v63: US0, v62: US0, v60: US2, v59: US0, v58: US0, v57: US0, v56: US1, v55: US0, patternInput_1: [Mut3, (arg0: Mut3) => void], v99: Mut3, v100: (arg0: Mut3) => void, v101: int32, patternInput_2: [(arg0: void) => boolean, (arg0: boolean) => void], patternInput_3: [(arg0: void) => boolean, (arg0: boolean) => void], v107: (arg0: boolean) => void, v106: (arg0: void) => boolean, patternInput_4: [(arg0: void) => boolean, (arg0: boolean) => void], v113: any, v114: (arg0: void) => Array<boolean>, v115: (arg0: void) => void, v116: any, v118: any, v121: (arg0: Heap0) => any, v123: (arg0: void) => any;
    return [(v1_1.l37.tag === 1) ? (v46() ? ((v52 = ((): any => closure20(v47, void 0)), (v54 = (new Heap0(v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, new US3(1, v52), v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45)), (patternInput = method0(), (v98 = patternInput[43], (v97 = patternInput[42], (v96 = patternInput[41], (v95 = patternInput[40], (v94 = patternInput[39], (v93 = patternInput[38], (v92 = patternInput[37], (v91 = patternInput[36], (v90 = patternInput[35], (v89 = patternInput[34], (v88 = patternInput[33], (v87 = patternInput[32], (v86 = patternInput[31], (v85 = patternInput[30], (v84 = patternInput[29], (v83 = patternInput[28], (v82 = patternInput[27], (v81 = patternInput[26], (v80 = patternInput[25], (v79 = patternInput[24], (v78 = patternInput[23], (v77 = patternInput[22], (v76 = patternInput[21], (v75 = patternInput[20], (v73 = patternInput[18], (v72 = patternInput[17], (v71 = patternInput[16], (v70 = patternInput[15], (v69 = patternInput[14], (v67 = patternInput[12], (v65 = patternInput[10], (v64 = patternInput[9], (v63 = patternInput[8], (v62 = patternInput[7], (v60 = patternInput[5], (v59 = patternInput[4], (v58 = patternInput[3], (v57 = patternInput[2], (v56 = patternInput[1], (v55 = patternInput[0], (patternInput_1 = method18(), (v99 = patternInput_1[0], (v100 = patternInput_1[1], (v101 = (nonSeeded().Next0() | 0), (patternInput_2 = method17(true), (patternInput_3 = method17(false), (v107 = patternInput_3[1], (v106 = patternInput_3[0], (patternInput_4 = method17(false), (v113 = on, (v114 = ((): Array<boolean> => closure22(v106, void 0)), (v115 = ((): void => {
        closure23(v107, v106, void 0);
    }), (v116 = (v113(v114, v115)), (v118 = createEffect, (void (v118(v116)), ((v0_1.tag === 1) ? ((v0_1.fields[0](v99, v100), void 0)) : (void 0), (v121 = ((v: Heap0): any => closure24(void 0, v)), (v123 = ((): any => closure39(v54, v55, v56, v57, v58, v59, v60, patternInput[6], v62, v63, v64, v65, patternInput[11], v67, patternInput[13], v69, v70, v71, v72, v73, patternInput[19], v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v100, v99, v101, patternInput_2[1], patternInput_2[0], v107, v106, patternInput_4[1], patternInput_4[0], v0_1, void 0)), method14(v121, new Heap0(v55, v56, v57, v58, v59, v60, new US3(1, v123), v62, v63, v64, v65, new US0(1, "flex"), v67, new US4(1, 1), v69, v70, v71, v72, v73, v54.l19, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98)))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))) : <></>) : v47()];
}

export function closure43(v0_1: US10, v1_1: Heap0, v2_1: US0, v3_1: US1, v4_1: US0, v5_1: US0, v6_1: US0, v7_1: US2, v8_1: US3, v9_1: US0, v10_1: US0, v11_1: US2, v12_1: US0, v13_1: US0, v14_1: US2, v15_1: US4, v16_1: US0, v17_1: US0, v18_1: US0, v19_1: US0, v20_1: US5, v21_1: US0, v22_1: US0, v23: US0, v24: US6, v25: US0, v26: US0, v27: US0, v28: US0, v29: US7, v30: US8, v31: US0, v32: US0, v33: US0, v34: US0, v35: US0, v36: US0, v37: US0, v38: US0, v39: US2, v40: US0, v41: US0, v42: US5, v43: US0, v44: US0, v45: US4, v46: (arg0: boolean) => void, v47: (arg0: void) => boolean, unitVar: void): any {
    let v51: (arg0: Heap0) => any, v54: (arg0: void) => any, v82: (arg0: Heap0) => any, v83: US0, v89: (arg0: void) => any, v98: string, v72: (arg0: Heap0) => any, v73: (arg0: void) => any;
    const v48 = v1_1.l40;
    const v71 = v1_1.l6;
    return [(v48.tag === 1) ? ((v51 = ((v: Heap0): any => closure13(void 0, v)), (v54 = ((): any => closure14(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48.fields[0], void 0)), method14(v51, new Heap0(v2_1, v3_1, v4_1, new US0(1, "0 !important"), v6_1, v7_1, new US3(1, v54), new US0(1, "$neutral9"), v10_1, v11_1, v12_1, new US0(1, "flex"), v14_1, v15_1, new US0(1, "column"), new US0(1, "$sm"), v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, new US0(1, "1px solid $neutral5"), v32, new US0(1, "3px 20px 0 8px"), v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45))))) : <></>, (v71.tag === 1) ? ((v82 = ((v_2: Heap0): any => closure13(void 0, v_2)), (v83 = v1_1.l31, (v89 = ((): any => closure44(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, v8_1, v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v47, v71.fields[0], void 0)), (v98 = "0", method14(v82, new Heap0(v2_1, v3_1, v4_1, new US0(1, "0 !important"), v6_1, v7_1, new US3(1, v89), v9_1, v10_1, v11_1, v12_1, new US0(1, "flex"), v14_1, new US4(1, 6), new US0(1, "column"), new US0(1, "$sm"), v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, v25, new US0(1, v98), v27, new US0(1, "85vh"), v29, v30, new US0(1, v98), new US0(1, "auto"), new US0(1, (v83.tag === 1) ? v83.fields[0] : "0"), v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45))))))) : ((v72 = ((v_1: Heap0): any => closure13(void 0, v_1)), (v73 = ((): any => closure18(void 0, void 0)), method14(v72, new Heap0(v2_1, v3_1, v4_1, v5_1, v6_1, v7_1, new US3(1, v73), v9_1, v10_1, v11_1, v12_1, v13_1, v14_1, v15_1, v16_1, v17_1, v18_1, v19_1, v20_1, v21_1, v22_1, v23, v24, new US0(1, "9px"), v26, v27, v28, v29, v30, v31, v32, new US0(1, "0"), v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45)))))];
}

export function closure42(unitVar: void, _arg: [US10, Heap0]): any {
    const v1_1 = _arg[1];
    const patternInput = method0();
    const v9_1 = patternInput[7];
    const v7_1 = patternInput[5];
    const v6_1 = patternInput[4];
    const v45 = patternInput[43];
    const v44 = patternInput[42];
    const v43 = patternInput[41];
    const v42 = patternInput[40];
    const v41 = patternInput[39];
    const v40 = patternInput[38];
    const v4_1 = patternInput[2];
    const v39 = patternInput[37];
    const v38 = patternInput[36];
    const v37 = patternInput[35];
    const v36 = patternInput[34];
    const v35 = patternInput[33];
    const v34 = patternInput[32];
    const v33 = patternInput[31];
    const v32 = patternInput[30];
    const v31 = patternInput[29];
    const v30 = patternInput[28];
    const v3_1 = patternInput[1];
    const v29 = patternInput[27];
    const v28 = patternInput[26];
    const v27 = patternInput[25];
    const v26 = patternInput[24];
    const v25 = patternInput[23];
    const v24 = patternInput[22];
    const v23 = patternInput[21];
    const v22_1 = patternInput[20];
    const v20_1 = patternInput[18];
    const v2_1 = patternInput[0];
    const v19_1 = patternInput[17];
    const v18_1 = patternInput[16];
    const v17_1 = patternInput[15];
    const v14_1 = patternInput[12];
    const v12_1 = patternInput[10];
    const v11_1 = patternInput[9];
    const v10_1 = patternInput[8];
    const v46 = v1_1.l37;
    const patternInput_1 = method17(((v46.tag === 1) && (v46.fields[0] === false)) !== true);
    const v54 = (v: Heap0): any => closure11(void 0, v);
    const v59 = (): any => closure43(_arg[0], v1_1, v2_1, v3_1, v4_1, patternInput[3], v6_1, v7_1, patternInput[6], v9_1, v10_1, v11_1, v12_1, patternInput[11], v14_1, patternInput[13], patternInput[14], v17_1, v18_1, v19_1, v20_1, patternInput[19], v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, patternInput_1[1], patternInput_1[0], void 0);
    return method14(v54, new Heap0(v2_1, v3_1, v4_1, new US0(1, "1px solid $neutral5"), v6_1, v7_1, new US3(1, v59), v9_1, v10_1, v11_1, v12_1, new US0(1, "flex"), v14_1, new US4(1, 1), new US0(1, {
        "@initial": "column",
        "@sm": "row",
    }), v17_1, v18_1, v19_1, v20_1, v1_1.l19, v22_1, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45));
}

export const v0 = "base_button";

export const v1 = (v: Heap0): any => closure0(void 0, v);

export const v2 = [v0, v1];

export const v3 = "base_table";

export const v4 = (v: Heap0): any => closure1(void 0, v);

export const v5 = [v3, v4];

export const v6 = "create_obj_props";

export const v7 = (v: Array<[string, any]>): Heap0 => closure5(void 0, v);

export const v8 = [v6, v7];

export const v9 = "external_link";

export const v10 = (v: Heap0): any => closure6(void 0, v);

export const v11 = [v9, v10];

export const v12 = "links";

export const v13 = (): any => closure8(void 0, void 0);

export const v14 = [v12, v13];

export const v15 = "loader";

export const v16 = (arg10$0040: [boolean, boolean, US10, Heap0]): any => closure38(void 0, arg10$0040);

export const v17 = [v15, v16];

export const v18 = "row";

export const v19 = (arg10$0040: [US10, Heap0]): any => closure42(void 0, arg10$0040);

export const v20 = [v18, v19];

export const v21 = [v2, v5, v8, v11, v14, v17, v20];

export const v22 = createObj(v21);


