import { int32 } from "./fable_modules/fable-library.4.0.0-theta-003/Int32.js";
import { Record, Union } from "./fable_modules/fable-library.4.0.0-theta-003/Types.js";
import { tuple_type, record_type, obj_type, int32_type, lambda_type, unit_type, bool_type, class_type, union_type, string_type, TypeInfo } from "./fable_modules/fable-library.4.0.0-theta-003/Reflection.js";
import { fill } from "./fable_modules/fable-library.4.0.0-theta-003/Array.js";
import { createObj } from "./fable_modules/fable-library.4.0.0-theta-003/Util.js";
import { createEffect, on, createSignal, createComponent } from "solid-js";
import { Tr, Stack, IconButton, Td, Checkbox, Box, Anchor, Icon, Table, Tbody, Button } from "@hope-ui/solid";
import { BiRegularUndo, BiRegularUpArrow, BiRegularDownArrow, BiRegularRefresh, BiRegularLinkExternal } from "solid-icons/bi";
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
    return union_type("Components_spi.US6", [], US6, () => [[], [["f1_0", lambda_type(obj_type, unit_type)]]]);
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
    return union_type("Components_spi.US7", [], US7, () => [[], [["f1_0", lambda_type(unit_type, unit_type)]]]);
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
    l22: US0;
    l23: US0;
    l24: US0;
    l25: US0;
    l26: US6;
    l27: US7;
    l28: US0;
    l29: US0;
    l30: US0;
    l31: US0;
    l32: US0;
    l33: US0;
    l34: US0;
    l35: US0;
    l36: US2;
    l37: US0;
    l38: US0;
    l39: US5;
    l40: US0;
    l41: US0;
    l42: US4;
    constructor(l0: US0, l1: US1, l2: US0, l3: US0, l4: US0, l5: US2, l6: US3, l7: US0, l8: US0, l9: US2, l10: US0, l11: US0, l12: US2, l13: US4, l14: US0, l15: US0, l16: US0, l17: US0, l18: US5, l19: US0, l20: US0, l21: US0, l22: US0, l23: US0, l24: US0, l25: US0, l26: US6, l27: US7, l28: US0, l29: US0, l30: US0, l31: US0, l32: US0, l33: US0, l34: US0, l35: US0, l36: US2, l37: US0, l38: US0, l39: US5, l40: US0, l41: US0, l42: US4) {
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
    }
}

export function Heap0$reflection(): TypeInfo {
    return record_type("Components_spi.Heap0", [], Heap0, () => [["l0", US0$reflection()], ["l1", US1$reflection()], ["l2", US0$reflection()], ["l3", US0$reflection()], ["l4", US0$reflection()], ["l5", US2$reflection()], ["l6", US3$reflection()], ["l7", US0$reflection()], ["l8", US0$reflection()], ["l9", US2$reflection()], ["l10", US0$reflection()], ["l11", US0$reflection()], ["l12", US2$reflection()], ["l13", US4$reflection()], ["l14", US0$reflection()], ["l15", US0$reflection()], ["l16", US0$reflection()], ["l17", US0$reflection()], ["l18", US5$reflection()], ["l19", US0$reflection()], ["l20", US0$reflection()], ["l21", US0$reflection()], ["l22", US0$reflection()], ["l23", US0$reflection()], ["l24", US0$reflection()], ["l25", US0$reflection()], ["l26", US6$reflection()], ["l27", US7$reflection()], ["l28", US0$reflection()], ["l29", US0$reflection()], ["l30", US0$reflection()], ["l31", US0$reflection()], ["l32", US0$reflection()], ["l33", US0$reflection()], ["l34", US0$reflection()], ["l35", US0$reflection()], ["l36", US2$reflection()], ["l37", US0$reflection()], ["l38", US0$reflection()], ["l39", US5$reflection()], ["l40", US0$reflection()], ["l41", US0$reflection()], ["l42", US4$reflection()]]);
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
    return union_type("Components_spi.US8", [], US8, () => [[], [["f1_0", tuple_type(string_type, obj_type)]]]);
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

export function method0(v0_1: int32, v1_1: Mut0): boolean {
    return v1_1.l0 < v0_1;
}

export function method1(v0_1: int32, v1_1: Mut1): boolean {
    return v1_1.l0 < v0_1;
}

export function closure0(unitVar: void, v0_1: Heap0): any {
    const v22 = "left";
    const v47 = new Heap0(new US0(0), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), v0_1.l6, new US0(0), new US0(1, "neutral"), new US2(1, true), new US0(0), new US0(0), new US2(0), new US4(0), new US0(0), new US0(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(1, v22), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(1, "xs"), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0));
    const v48 = v47.l0;
    const v55 = v47.l1;
    const v62 = v47.l2;
    const v69 = v47.l3;
    const v76 = v47.l4;
    const v83 = v47.l7;
    const v90 = v47.l5;
    const v97 = v47.l6;
    const v104 = v47.l8;
    const v111 = v47.l9;
    const v118 = v47.l11;
    const v125 = v47.l10;
    const v132 = v47.l12;
    const v139 = v47.l13;
    const v146 = v47.l14;
    const v153 = v47.l15;
    const v160 = v47.l16;
    const v167 = v47.l17;
    const v174 = v47.l18;
    const v181 = v47.l19;
    const v188 = v47.l20;
    const v195 = v47.l21;
    const v201 = v47.l22;
    const v208 = v47.l23;
    const v215 = v47.l24;
    const v222 = v47.l25;
    const v229 = v47.l26;
    const v236 = v47.l27;
    const v243 = v47.l28;
    const v250 = v47.l29;
    const v257 = v47.l30;
    const v264 = v47.l31;
    const v271 = v47.l32;
    const v278 = v47.l33;
    const v285 = v47.l34;
    const v292 = v47.l35;
    const v299 = v47.l36;
    const v306 = v47.l37;
    const v313 = v47.l38;
    const v320 = v47.l39;
    const v327 = v47.l40;
    const v334 = v47.l41;
    const v341 = v47.l42;
    const v348 = [(v48.tag === 1) ? (new US8(1, ["aria-label", v48.fields[0]])) : (new US8(0)), (v55.tag === 1) ? (new US8(1, ["as", v55.fields[0]])) : (new US8(0)), (v62.tag === 1) ? (new US8(1, ["backgroundColor", v62.fields[0]])) : (new US8(0)), (v69.tag === 1) ? (new US8(1, ["border", v69.fields[0]])) : (new US8(0)), (v76.tag === 1) ? (new US8(1, ["bottom", v76.fields[0]])) : (new US8(0)), (v83.tag === 1) ? (new US8(1, ["color", v83.fields[0]])) : (new US8(0)), (v90.tag === 1) ? (new US8(1, ["checked", v90.fields[0]])) : (new US8(0)), (v97.tag === 1) ? (new US8(1, ["children", v97.fields[0]])) : (new US8(0)), (v104.tag === 1) ? (new US8(1, ["colorScheme", v104.fields[0]])) : (new US8(0)), (v111.tag === 1) ? (new US8(1, ["compact", v111.fields[0]])) : (new US8(0)), (v118.tag === 1) ? (new US8(1, ["display", v118.fields[0]])) : (new US8(0)), (v125.tag === 1) ? (new US8(1, ["direction", v125.fields[0]])) : (new US8(0)), (v132.tag === 1) ? (new US8(1, ["external", v132.fields[0]])) : (new US8(0)), (v139.tag === 1) ? (new US8(1, ["flex", v139.fields[0]])) : (new US8(0)), (v146.tag === 1) ? (new US8(1, ["flexDirection", v146.fields[0]])) : (new US8(0)), (v153.tag === 1) ? (new US8(1, ["fontSize", v153.fields[0]])) : (new US8(0)), (v160.tag === 1) ? (new US8(1, ["height", v160.fields[0]])) : (new US8(0)), (v167.tag === 1) ? (new US8(1, ["href", v167.fields[0]])) : (new US8(0)), (v174.tag === 1) ? (new US8(1, ["icon", v174.fields[0]])) : (new US8(0)), (v181.tag === 1) ? (new US8(1, ["id", v181.fields[0]])) : (new US8(0)), (v188.tag === 1) ? (new US8(1, ["justifyContent", v188.fields[0]])) : (new US8(0)), (v195.tag === 1) ? (new US8(1, [v22, v195.fields[0]])) : (new US8(0)), (v201.tag === 1) ? (new US8(1, ["lineHeight", v201.fields[0]])) : (new US8(0)), (v208.tag === 1) ? (new US8(1, ["margin", v208.fields[0]])) : (new US8(0)), (v215.tag === 1) ? (new US8(1, ["marginBottom", v215.fields[0]])) : (new US8(0)), (v222.tag === 1) ? (new US8(1, ["maxHeight", v222.fields[0]])) : (new US8(0)), (v229.tag === 1) ? (new US8(1, ["onChange", v229.fields[0]])) : (new US8(0)), (v236.tag === 1) ? (new US8(1, ["onClick", v236.fields[0]])) : (new US8(0)), (v243.tag === 1) ? (new US8(1, ["outline", v243.fields[0]])) : (new US8(0)), (v250.tag === 1) ? (new US8(1, ["overflowY", v250.fields[0]])) : (new US8(0)), (v257.tag === 1) ? (new US8(1, ["padding", v257.fields[0]])) : (new US8(0)), (v264.tag === 1) ? (new US8(1, ["paddingTop", v264.fields[0]])) : (new US8(0)), (v271.tag === 1) ? (new US8(1, ["position", v271.fields[0]])) : (new US8(0)), (v278.tag === 1) ? (new US8(1, ["right", v278.fields[0]])) : (new US8(0)), (v285.tag === 1) ? (new US8(1, ["size", v285.fields[0]])) : (new US8(0)), (v292.tag === 1) ? (new US8(1, ["spacing", v292.fields[0]])) : (new US8(0)), (v299.tag === 1) ? (new US8(1, ["status", v299.fields[0]])) : (new US8(0)), (v306.tag === 1) ? (new US8(1, ["striped", v306.fields[0]])) : (new US8(0)), (v313.tag === 1) ? (new US8(1, ["thickness", v313.fields[0]])) : (new US8(0)), (v320.tag === 1) ? (new US8(1, ["title", v320.fields[0]])) : (new US8(0)), (v327.tag === 1) ? (new US8(1, ["top", v327.fields[0]])) : (new US8(0)), (v334.tag === 1) ? (new US8(1, ["width", v334.fields[0]])) : (new US8(0)), (v341.tag === 1) ? (new US8(1, ["zIndex", v341.fields[0]])) : (new US8(0))];
    const v349 = v348.length | 0;
    const v350 = fill(new Array(v349), 0, v349, null);
    const v351 = new Mut0(0, 0);
    while (method0(v349, v351)) {
        const v353 = v351.l0 | 0;
        const v354 = v351.l1 | 0;
        const v355 = v348[v353];
        let v359;
        if (v355.tag === 1) {
            v350[v354] = v355;
            v359 = (v354 + 1);
        }
        else {
            v359 = v354;
        }
        const v360 = (v353 + 1) | 0;
        v351.l0 = (v360 | 0);
        v351.l1 = (v359 | 0);
    }
    const v361 = v351.l1 | 0;
    const v362 = fill(new Array(v361), 0, v361, null);
    const v363 = new Mut1(0);
    while (method1(v361, v363)) {
        const v365 = v363.l0 | 0;
        const v366 = v350[v365];
        v362[v365] = v366;
        const v367 = (v365 + 1) | 0;
        v363.l0 = (v367 | 0);
    }
    const v368 = v362.length | 0;
    const v369 = fill(new Array(v368), 0, v368, null);
    const v370 = new Mut1(0);
    while (method1(v368, v370)) {
        const v372 = v370.l0 | 0;
        const v373 = v362[v372];
        let v376;
        if (v373.tag === 1) {
            v376 = v373.fields[0];
        }
        else {
            throw new Error("Option does not have a value.");
        }
        v369[v372] = v376;
        const v377 = (v372 + 1) | 0;
        v370.l0 = (v377 | 0);
    }
    const v378 = createObj(v369);
    const v381 = createComponent;
    return v381(Button, v378);
}

export function closure3(unitVar: void, v0_1: Heap0): any {
    const v1_1 = v0_1.l0;
    const v8_1 = v0_1.l1;
    const v15_1 = v0_1.l2;
    const v22 = v0_1.l3;
    const v29 = v0_1.l4;
    const v36 = v0_1.l7;
    const v43 = v0_1.l5;
    const v50 = v0_1.l6;
    const v57 = v0_1.l8;
    const v64 = v0_1.l9;
    const v71 = v0_1.l11;
    const v78 = v0_1.l10;
    const v85 = v0_1.l12;
    const v92 = v0_1.l13;
    const v99 = v0_1.l14;
    const v106 = v0_1.l15;
    const v113 = v0_1.l16;
    const v120 = v0_1.l17;
    const v127 = v0_1.l18;
    const v134 = v0_1.l19;
    const v141 = v0_1.l20;
    const v148 = v0_1.l21;
    const v155 = v0_1.l22;
    const v162 = v0_1.l23;
    const v169 = v0_1.l24;
    const v176 = v0_1.l25;
    const v183 = v0_1.l26;
    const v190 = v0_1.l27;
    const v197 = v0_1.l28;
    const v204 = v0_1.l29;
    const v211 = v0_1.l30;
    const v218 = v0_1.l31;
    const v225 = v0_1.l32;
    const v232 = v0_1.l33;
    const v239 = v0_1.l34;
    const v246 = v0_1.l35;
    const v253 = v0_1.l36;
    const v260 = v0_1.l37;
    const v267 = v0_1.l38;
    const v274 = v0_1.l39;
    const v281 = v0_1.l40;
    const v288 = v0_1.l41;
    const v295 = v0_1.l42;
    const v302 = [(v1_1.tag === 1) ? (new US8(1, ["aria-label", v1_1.fields[0]])) : (new US8(0)), (v8_1.tag === 1) ? (new US8(1, ["as", v8_1.fields[0]])) : (new US8(0)), (v15_1.tag === 1) ? (new US8(1, ["backgroundColor", v15_1.fields[0]])) : (new US8(0)), (v22.tag === 1) ? (new US8(1, ["border", v22.fields[0]])) : (new US8(0)), (v29.tag === 1) ? (new US8(1, ["bottom", v29.fields[0]])) : (new US8(0)), (v36.tag === 1) ? (new US8(1, ["color", v36.fields[0]])) : (new US8(0)), (v43.tag === 1) ? (new US8(1, ["checked", v43.fields[0]])) : (new US8(0)), (v50.tag === 1) ? (new US8(1, ["children", v50.fields[0]])) : (new US8(0)), (v57.tag === 1) ? (new US8(1, ["colorScheme", v57.fields[0]])) : (new US8(0)), (v64.tag === 1) ? (new US8(1, ["compact", v64.fields[0]])) : (new US8(0)), (v71.tag === 1) ? (new US8(1, ["display", v71.fields[0]])) : (new US8(0)), (v78.tag === 1) ? (new US8(1, ["direction", v78.fields[0]])) : (new US8(0)), (v85.tag === 1) ? (new US8(1, ["external", v85.fields[0]])) : (new US8(0)), (v92.tag === 1) ? (new US8(1, ["flex", v92.fields[0]])) : (new US8(0)), (v99.tag === 1) ? (new US8(1, ["flexDirection", v99.fields[0]])) : (new US8(0)), (v106.tag === 1) ? (new US8(1, ["fontSize", v106.fields[0]])) : (new US8(0)), (v113.tag === 1) ? (new US8(1, ["height", v113.fields[0]])) : (new US8(0)), (v120.tag === 1) ? (new US8(1, ["href", v120.fields[0]])) : (new US8(0)), (v127.tag === 1) ? (new US8(1, ["icon", v127.fields[0]])) : (new US8(0)), (v134.tag === 1) ? (new US8(1, ["id", v134.fields[0]])) : (new US8(0)), (v141.tag === 1) ? (new US8(1, ["justifyContent", v141.fields[0]])) : (new US8(0)), (v148.tag === 1) ? (new US8(1, ["left", v148.fields[0]])) : (new US8(0)), (v155.tag === 1) ? (new US8(1, ["lineHeight", v155.fields[0]])) : (new US8(0)), (v162.tag === 1) ? (new US8(1, ["margin", v162.fields[0]])) : (new US8(0)), (v169.tag === 1) ? (new US8(1, ["marginBottom", v169.fields[0]])) : (new US8(0)), (v176.tag === 1) ? (new US8(1, ["maxHeight", v176.fields[0]])) : (new US8(0)), (v183.tag === 1) ? (new US8(1, ["onChange", v183.fields[0]])) : (new US8(0)), (v190.tag === 1) ? (new US8(1, ["onClick", v190.fields[0]])) : (new US8(0)), (v197.tag === 1) ? (new US8(1, ["outline", v197.fields[0]])) : (new US8(0)), (v204.tag === 1) ? (new US8(1, ["overflowY", v204.fields[0]])) : (new US8(0)), (v211.tag === 1) ? (new US8(1, ["padding", v211.fields[0]])) : (new US8(0)), (v218.tag === 1) ? (new US8(1, ["paddingTop", v218.fields[0]])) : (new US8(0)), (v225.tag === 1) ? (new US8(1, ["position", v225.fields[0]])) : (new US8(0)), (v232.tag === 1) ? (new US8(1, ["right", v232.fields[0]])) : (new US8(0)), (v239.tag === 1) ? (new US8(1, ["size", v239.fields[0]])) : (new US8(0)), (v246.tag === 1) ? (new US8(1, ["spacing", v246.fields[0]])) : (new US8(0)), (v253.tag === 1) ? (new US8(1, ["status", v253.fields[0]])) : (new US8(0)), (v260.tag === 1) ? (new US8(1, ["striped", v260.fields[0]])) : (new US8(0)), (v267.tag === 1) ? (new US8(1, ["thickness", v267.fields[0]])) : (new US8(0)), (v274.tag === 1) ? (new US8(1, ["title", v274.fields[0]])) : (new US8(0)), (v281.tag === 1) ? (new US8(1, ["top", v281.fields[0]])) : (new US8(0)), (v288.tag === 1) ? (new US8(1, ["width", v288.fields[0]])) : (new US8(0)), (v295.tag === 1) ? (new US8(1, ["zIndex", v295.fields[0]])) : (new US8(0))];
    const v303 = v302.length | 0;
    const v304 = fill(new Array(v303), 0, v303, null);
    const v305 = new Mut0(0, 0);
    while (method0(v303, v305)) {
        const v307 = v305.l0 | 0;
        const v308 = v305.l1 | 0;
        const v309 = v302[v307];
        let v313;
        if (v309.tag === 1) {
            v304[v308] = v309;
            v313 = (v308 + 1);
        }
        else {
            v313 = v308;
        }
        const v314 = (v307 + 1) | 0;
        v305.l0 = (v314 | 0);
        v305.l1 = (v313 | 0);
    }
    const v315 = v305.l1 | 0;
    const v316 = fill(new Array(v315), 0, v315, null);
    const v317 = new Mut1(0);
    while (method1(v315, v317)) {
        const v319 = v317.l0 | 0;
        const v320 = v304[v319];
        v316[v319] = v320;
        const v321 = (v319 + 1) | 0;
        v317.l0 = (v321 | 0);
    }
    const v322 = v316.length | 0;
    const v323 = fill(new Array(v322), 0, v322, null);
    const v324 = new Mut1(0);
    while (method1(v322, v324)) {
        const v326 = v324.l0 | 0;
        const v327 = v316[v326];
        let v330;
        if (v327.tag === 1) {
            v330 = v327.fields[0];
        }
        else {
            throw new Error("Option does not have a value.");
        }
        v323[v326] = v330;
        const v331 = (v326 + 1) | 0;
        v324.l0 = (v331 | 0);
    }
    const v332 = createObj(v323);
    const v335 = createComponent;
    return v335(Tbody, v332);
}

export function closure2(v0_1: Heap0, unitVar: void): any {
    const v46 = new Heap0(new US0(0), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), v0_1.l6, new US0(0), new US0(0), new US2(0), new US0(0), new US0(1, "flex"), new US2(0), new US4(0), new US0(1, "column"), new US0(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0));
    const v47 = (v: Heap0): any => closure3(void 0, v);
    const v51 = createComponent;
    return [v51(v47, v46)];
}

export function closure4(unitVar: void, v0_1: Heap0): any {
    const v1_1 = v0_1.l0;
    const v8_1 = v0_1.l1;
    const v15_1 = v0_1.l2;
    const v22 = v0_1.l3;
    const v29 = v0_1.l4;
    const v36 = v0_1.l7;
    const v43 = v0_1.l5;
    const v50 = v0_1.l6;
    const v57 = v0_1.l8;
    const v64 = v0_1.l9;
    const v71 = v0_1.l11;
    const v78 = v0_1.l10;
    const v85 = v0_1.l12;
    const v92 = v0_1.l13;
    const v99 = v0_1.l14;
    const v106 = v0_1.l15;
    const v113 = v0_1.l16;
    const v120 = v0_1.l17;
    const v127 = v0_1.l18;
    const v134 = v0_1.l19;
    const v141 = v0_1.l20;
    const v148 = v0_1.l21;
    const v155 = v0_1.l22;
    const v162 = v0_1.l23;
    const v169 = v0_1.l24;
    const v176 = v0_1.l25;
    const v183 = v0_1.l26;
    const v190 = v0_1.l27;
    const v197 = v0_1.l28;
    const v204 = v0_1.l29;
    const v211 = v0_1.l30;
    const v218 = v0_1.l31;
    const v225 = v0_1.l32;
    const v232 = v0_1.l33;
    const v239 = v0_1.l34;
    const v246 = v0_1.l35;
    const v253 = v0_1.l36;
    const v260 = v0_1.l37;
    const v267 = v0_1.l38;
    const v274 = v0_1.l39;
    const v281 = v0_1.l40;
    const v288 = v0_1.l41;
    const v295 = v0_1.l42;
    const v302 = [(v1_1.tag === 1) ? (new US8(1, ["aria-label", v1_1.fields[0]])) : (new US8(0)), (v8_1.tag === 1) ? (new US8(1, ["as", v8_1.fields[0]])) : (new US8(0)), (v15_1.tag === 1) ? (new US8(1, ["backgroundColor", v15_1.fields[0]])) : (new US8(0)), (v22.tag === 1) ? (new US8(1, ["border", v22.fields[0]])) : (new US8(0)), (v29.tag === 1) ? (new US8(1, ["bottom", v29.fields[0]])) : (new US8(0)), (v36.tag === 1) ? (new US8(1, ["color", v36.fields[0]])) : (new US8(0)), (v43.tag === 1) ? (new US8(1, ["checked", v43.fields[0]])) : (new US8(0)), (v50.tag === 1) ? (new US8(1, ["children", v50.fields[0]])) : (new US8(0)), (v57.tag === 1) ? (new US8(1, ["colorScheme", v57.fields[0]])) : (new US8(0)), (v64.tag === 1) ? (new US8(1, ["compact", v64.fields[0]])) : (new US8(0)), (v71.tag === 1) ? (new US8(1, ["display", v71.fields[0]])) : (new US8(0)), (v78.tag === 1) ? (new US8(1, ["direction", v78.fields[0]])) : (new US8(0)), (v85.tag === 1) ? (new US8(1, ["external", v85.fields[0]])) : (new US8(0)), (v92.tag === 1) ? (new US8(1, ["flex", v92.fields[0]])) : (new US8(0)), (v99.tag === 1) ? (new US8(1, ["flexDirection", v99.fields[0]])) : (new US8(0)), (v106.tag === 1) ? (new US8(1, ["fontSize", v106.fields[0]])) : (new US8(0)), (v113.tag === 1) ? (new US8(1, ["height", v113.fields[0]])) : (new US8(0)), (v120.tag === 1) ? (new US8(1, ["href", v120.fields[0]])) : (new US8(0)), (v127.tag === 1) ? (new US8(1, ["icon", v127.fields[0]])) : (new US8(0)), (v134.tag === 1) ? (new US8(1, ["id", v134.fields[0]])) : (new US8(0)), (v141.tag === 1) ? (new US8(1, ["justifyContent", v141.fields[0]])) : (new US8(0)), (v148.tag === 1) ? (new US8(1, ["left", v148.fields[0]])) : (new US8(0)), (v155.tag === 1) ? (new US8(1, ["lineHeight", v155.fields[0]])) : (new US8(0)), (v162.tag === 1) ? (new US8(1, ["margin", v162.fields[0]])) : (new US8(0)), (v169.tag === 1) ? (new US8(1, ["marginBottom", v169.fields[0]])) : (new US8(0)), (v176.tag === 1) ? (new US8(1, ["maxHeight", v176.fields[0]])) : (new US8(0)), (v183.tag === 1) ? (new US8(1, ["onChange", v183.fields[0]])) : (new US8(0)), (v190.tag === 1) ? (new US8(1, ["onClick", v190.fields[0]])) : (new US8(0)), (v197.tag === 1) ? (new US8(1, ["outline", v197.fields[0]])) : (new US8(0)), (v204.tag === 1) ? (new US8(1, ["overflowY", v204.fields[0]])) : (new US8(0)), (v211.tag === 1) ? (new US8(1, ["padding", v211.fields[0]])) : (new US8(0)), (v218.tag === 1) ? (new US8(1, ["paddingTop", v218.fields[0]])) : (new US8(0)), (v225.tag === 1) ? (new US8(1, ["position", v225.fields[0]])) : (new US8(0)), (v232.tag === 1) ? (new US8(1, ["right", v232.fields[0]])) : (new US8(0)), (v239.tag === 1) ? (new US8(1, ["size", v239.fields[0]])) : (new US8(0)), (v246.tag === 1) ? (new US8(1, ["spacing", v246.fields[0]])) : (new US8(0)), (v253.tag === 1) ? (new US8(1, ["status", v253.fields[0]])) : (new US8(0)), (v260.tag === 1) ? (new US8(1, ["striped", v260.fields[0]])) : (new US8(0)), (v267.tag === 1) ? (new US8(1, ["thickness", v267.fields[0]])) : (new US8(0)), (v274.tag === 1) ? (new US8(1, ["title", v274.fields[0]])) : (new US8(0)), (v281.tag === 1) ? (new US8(1, ["top", v281.fields[0]])) : (new US8(0)), (v288.tag === 1) ? (new US8(1, ["width", v288.fields[0]])) : (new US8(0)), (v295.tag === 1) ? (new US8(1, ["zIndex", v295.fields[0]])) : (new US8(0))];
    const v303 = v302.length | 0;
    const v304 = fill(new Array(v303), 0, v303, null);
    const v305 = new Mut0(0, 0);
    while (method0(v303, v305)) {
        const v307 = v305.l0 | 0;
        const v308 = v305.l1 | 0;
        const v309 = v302[v307];
        let v313;
        if (v309.tag === 1) {
            v304[v308] = v309;
            v313 = (v308 + 1);
        }
        else {
            v313 = v308;
        }
        const v314 = (v307 + 1) | 0;
        v305.l0 = (v314 | 0);
        v305.l1 = (v313 | 0);
    }
    const v315 = v305.l1 | 0;
    const v316 = fill(new Array(v315), 0, v315, null);
    const v317 = new Mut1(0);
    while (method1(v315, v317)) {
        const v319 = v317.l0 | 0;
        const v320 = v304[v319];
        v316[v319] = v320;
        const v321 = (v319 + 1) | 0;
        v317.l0 = (v321 | 0);
    }
    const v322 = v316.length | 0;
    const v323 = fill(new Array(v322), 0, v322, null);
    const v324 = new Mut1(0);
    while (method1(v322, v324)) {
        const v326 = v324.l0 | 0;
        const v327 = v316[v326];
        let v330;
        if (v327.tag === 1) {
            v330 = v327.fields[0];
        }
        else {
            throw new Error("Option does not have a value.");
        }
        v323[v326] = v330;
        const v331 = (v326 + 1) | 0;
        v324.l0 = (v331 | 0);
    }
    const v332 = createObj(v323);
    const v335 = createComponent;
    return v335(Table, v332);
}

export function closure1(unitVar: void, v0_1: Heap0): any {
    const v7_1 = (): any => closure2(v0_1, void 0);
    const v48 = new Heap0(new US0(0), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), new US3(1, v7_1), new US0(0), new US0(0), new US2(0), new US0(0), new US0(1, "flex"), new US2(0), new US4(1, 1), new US0(1, "column"), new US0(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(1, "odd"), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0));
    const v49 = (v: Heap0): any => closure4(void 0, v);
    const v53 = createComponent;
    return v53(v49, v48);
}

export function closure6(v0_1: Heap0, unitVar: void): any {
    const v1_1 = v0_1.l17;
    const v5_1 = (v1_1.tag === 1) ? v1_1.fields[0] : "";
    const v10_1 = BiRegularLinkExternal;
    const v54 = new Heap0(new US0(0), new US1(1, v10_1), new US0(0), new US0(0), new US0(0), new US2(0), new US3(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US2(0), new US4(0), new US0(0), new US0(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0));
    const v55 = v54.l0;
    const v62 = v54.l1;
    const v69 = v54.l2;
    const v76 = v54.l3;
    const v83 = v54.l4;
    const v90 = v54.l7;
    const v97 = v54.l5;
    const v104 = v54.l6;
    const v111 = v54.l8;
    const v118 = v54.l9;
    const v125 = v54.l11;
    const v132 = v54.l10;
    const v139 = v54.l12;
    const v146 = v54.l13;
    const v153 = v54.l14;
    const v160 = v54.l15;
    const v167 = v54.l16;
    const v174 = v54.l17;
    const v181 = v54.l18;
    const v188 = v54.l19;
    const v195 = v54.l20;
    const v202 = v54.l21;
    const v209 = v54.l22;
    const v216 = v54.l23;
    const v223 = v54.l24;
    const v230 = v54.l25;
    const v237 = v54.l26;
    const v244 = v54.l27;
    const v251 = v54.l28;
    const v258 = v54.l29;
    const v265 = v54.l30;
    const v272 = v54.l31;
    const v279 = v54.l32;
    const v286 = v54.l33;
    const v293 = v54.l34;
    const v300 = v54.l35;
    const v307 = v54.l36;
    const v314 = v54.l37;
    const v321 = v54.l38;
    const v328 = v54.l39;
    const v335 = v54.l40;
    const v342 = v54.l41;
    const v349 = v54.l42;
    const v356 = [(v55.tag === 1) ? (new US8(1, ["aria-label", v55.fields[0]])) : (new US8(0)), (v62.tag === 1) ? (new US8(1, ["as", v62.fields[0]])) : (new US8(0)), (v69.tag === 1) ? (new US8(1, ["backgroundColor", v69.fields[0]])) : (new US8(0)), (v76.tag === 1) ? (new US8(1, ["border", v76.fields[0]])) : (new US8(0)), (v83.tag === 1) ? (new US8(1, ["bottom", v83.fields[0]])) : (new US8(0)), (v90.tag === 1) ? (new US8(1, ["color", v90.fields[0]])) : (new US8(0)), (v97.tag === 1) ? (new US8(1, ["checked", v97.fields[0]])) : (new US8(0)), (v104.tag === 1) ? (new US8(1, ["children", v104.fields[0]])) : (new US8(0)), (v111.tag === 1) ? (new US8(1, ["colorScheme", v111.fields[0]])) : (new US8(0)), (v118.tag === 1) ? (new US8(1, ["compact", v118.fields[0]])) : (new US8(0)), (v125.tag === 1) ? (new US8(1, ["display", v125.fields[0]])) : (new US8(0)), (v132.tag === 1) ? (new US8(1, ["direction", v132.fields[0]])) : (new US8(0)), (v139.tag === 1) ? (new US8(1, ["external", v139.fields[0]])) : (new US8(0)), (v146.tag === 1) ? (new US8(1, ["flex", v146.fields[0]])) : (new US8(0)), (v153.tag === 1) ? (new US8(1, ["flexDirection", v153.fields[0]])) : (new US8(0)), (v160.tag === 1) ? (new US8(1, ["fontSize", v160.fields[0]])) : (new US8(0)), (v167.tag === 1) ? (new US8(1, ["height", v167.fields[0]])) : (new US8(0)), (v174.tag === 1) ? (new US8(1, ["href", v174.fields[0]])) : (new US8(0)), (v181.tag === 1) ? (new US8(1, ["icon", v181.fields[0]])) : (new US8(0)), (v188.tag === 1) ? (new US8(1, ["id", v188.fields[0]])) : (new US8(0)), (v195.tag === 1) ? (new US8(1, ["justifyContent", v195.fields[0]])) : (new US8(0)), (v202.tag === 1) ? (new US8(1, ["left", v202.fields[0]])) : (new US8(0)), (v209.tag === 1) ? (new US8(1, ["lineHeight", v209.fields[0]])) : (new US8(0)), (v216.tag === 1) ? (new US8(1, ["margin", v216.fields[0]])) : (new US8(0)), (v223.tag === 1) ? (new US8(1, ["marginBottom", v223.fields[0]])) : (new US8(0)), (v230.tag === 1) ? (new US8(1, ["maxHeight", v230.fields[0]])) : (new US8(0)), (v237.tag === 1) ? (new US8(1, ["onChange", v237.fields[0]])) : (new US8(0)), (v244.tag === 1) ? (new US8(1, ["onClick", v244.fields[0]])) : (new US8(0)), (v251.tag === 1) ? (new US8(1, ["outline", v251.fields[0]])) : (new US8(0)), (v258.tag === 1) ? (new US8(1, ["overflowY", v258.fields[0]])) : (new US8(0)), (v265.tag === 1) ? (new US8(1, ["padding", v265.fields[0]])) : (new US8(0)), (v272.tag === 1) ? (new US8(1, ["paddingTop", v272.fields[0]])) : (new US8(0)), (v279.tag === 1) ? (new US8(1, ["position", v279.fields[0]])) : (new US8(0)), (v286.tag === 1) ? (new US8(1, ["right", v286.fields[0]])) : (new US8(0)), (v293.tag === 1) ? (new US8(1, ["size", v293.fields[0]])) : (new US8(0)), (v300.tag === 1) ? (new US8(1, ["spacing", v300.fields[0]])) : (new US8(0)), (v307.tag === 1) ? (new US8(1, ["status", v307.fields[0]])) : (new US8(0)), (v314.tag === 1) ? (new US8(1, ["striped", v314.fields[0]])) : (new US8(0)), (v321.tag === 1) ? (new US8(1, ["thickness", v321.fields[0]])) : (new US8(0)), (v328.tag === 1) ? (new US8(1, ["title", v328.fields[0]])) : (new US8(0)), (v335.tag === 1) ? (new US8(1, ["top", v335.fields[0]])) : (new US8(0)), (v342.tag === 1) ? (new US8(1, ["width", v342.fields[0]])) : (new US8(0)), (v349.tag === 1) ? (new US8(1, ["zIndex", v349.fields[0]])) : (new US8(0))];
    const v357 = v356.length | 0;
    const v358 = fill(new Array(v357), 0, v357, null);
    const v359 = new Mut0(0, 0);
    while (method0(v357, v359)) {
        const v361 = v359.l0 | 0;
        const v362 = v359.l1 | 0;
        const v363 = v356[v361];
        let v367;
        if (v363.tag === 1) {
            v358[v362] = v363;
            v367 = (v362 + 1);
        }
        else {
            v367 = v362;
        }
        const v368 = (v361 + 1) | 0;
        v359.l0 = (v368 | 0);
        v359.l1 = (v367 | 0);
    }
    const v369 = v359.l1 | 0;
    const v370 = fill(new Array(v369), 0, v369, null);
    const v371 = new Mut1(0);
    while (method1(v369, v371)) {
        const v373 = v371.l0 | 0;
        const v374 = v358[v373];
        v370[v373] = v374;
        const v375 = (v373 + 1) | 0;
        v371.l0 = (v375 | 0);
    }
    const v376 = v370.length | 0;
    const v377 = fill(new Array(v376), 0, v376, null);
    const v378 = new Mut1(0);
    while (method1(v376, v378)) {
        const v380 = v378.l0 | 0;
        const v381 = v370[v380];
        let v384;
        if (v381.tag === 1) {
            v384 = v381.fields[0];
        }
        else {
            throw new Error("Option does not have a value.");
        }
        v377[v380] = v384;
        const v385 = (v380 + 1) | 0;
        v378.l0 = (v385 | 0);
    }
    const v386 = createObj(v377);
    const v389 = createComponent;
    return [v5_1, " ", v389(Icon, v386)];
}

export function closure5(unitVar: void, v0_1: Heap0): any {
    const v8_1 = (): any => closure6(v0_1, void 0);
    const v45 = new Heap0(new US0(0), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), new US3(1, v8_1), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US2(1, true), new US4(0), new US0(0), new US0(0), new US0(0), v0_1.l17, new US5(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0));
    const v46 = v45.l0;
    const v53 = v45.l1;
    const v60 = v45.l2;
    const v67 = v45.l3;
    const v74 = v45.l4;
    const v81 = v45.l7;
    const v88 = v45.l5;
    const v95 = v45.l6;
    const v102 = v45.l8;
    const v109 = v45.l9;
    const v116 = v45.l11;
    const v123 = v45.l10;
    const v130 = v45.l12;
    const v137 = v45.l13;
    const v144 = v45.l14;
    const v151 = v45.l15;
    const v158 = v45.l16;
    const v165 = v45.l17;
    const v172 = v45.l18;
    const v179 = v45.l19;
    const v186 = v45.l20;
    const v193 = v45.l21;
    const v200 = v45.l22;
    const v207 = v45.l23;
    const v214 = v45.l24;
    const v221 = v45.l25;
    const v228 = v45.l26;
    const v235 = v45.l27;
    const v242 = v45.l28;
    const v249 = v45.l29;
    const v256 = v45.l30;
    const v263 = v45.l31;
    const v270 = v45.l32;
    const v277 = v45.l33;
    const v284 = v45.l34;
    const v291 = v45.l35;
    const v298 = v45.l36;
    const v305 = v45.l37;
    const v312 = v45.l38;
    const v319 = v45.l39;
    const v326 = v45.l40;
    const v333 = v45.l41;
    const v340 = v45.l42;
    const v347 = [(v46.tag === 1) ? (new US8(1, ["aria-label", v46.fields[0]])) : (new US8(0)), (v53.tag === 1) ? (new US8(1, ["as", v53.fields[0]])) : (new US8(0)), (v60.tag === 1) ? (new US8(1, ["backgroundColor", v60.fields[0]])) : (new US8(0)), (v67.tag === 1) ? (new US8(1, ["border", v67.fields[0]])) : (new US8(0)), (v74.tag === 1) ? (new US8(1, ["bottom", v74.fields[0]])) : (new US8(0)), (v81.tag === 1) ? (new US8(1, ["color", v81.fields[0]])) : (new US8(0)), (v88.tag === 1) ? (new US8(1, ["checked", v88.fields[0]])) : (new US8(0)), (v95.tag === 1) ? (new US8(1, ["children", v95.fields[0]])) : (new US8(0)), (v102.tag === 1) ? (new US8(1, ["colorScheme", v102.fields[0]])) : (new US8(0)), (v109.tag === 1) ? (new US8(1, ["compact", v109.fields[0]])) : (new US8(0)), (v116.tag === 1) ? (new US8(1, ["display", v116.fields[0]])) : (new US8(0)), (v123.tag === 1) ? (new US8(1, ["direction", v123.fields[0]])) : (new US8(0)), (v130.tag === 1) ? (new US8(1, ["external", v130.fields[0]])) : (new US8(0)), (v137.tag === 1) ? (new US8(1, ["flex", v137.fields[0]])) : (new US8(0)), (v144.tag === 1) ? (new US8(1, ["flexDirection", v144.fields[0]])) : (new US8(0)), (v151.tag === 1) ? (new US8(1, ["fontSize", v151.fields[0]])) : (new US8(0)), (v158.tag === 1) ? (new US8(1, ["height", v158.fields[0]])) : (new US8(0)), (v165.tag === 1) ? (new US8(1, ["href", v165.fields[0]])) : (new US8(0)), (v172.tag === 1) ? (new US8(1, ["icon", v172.fields[0]])) : (new US8(0)), (v179.tag === 1) ? (new US8(1, ["id", v179.fields[0]])) : (new US8(0)), (v186.tag === 1) ? (new US8(1, ["justifyContent", v186.fields[0]])) : (new US8(0)), (v193.tag === 1) ? (new US8(1, ["left", v193.fields[0]])) : (new US8(0)), (v200.tag === 1) ? (new US8(1, ["lineHeight", v200.fields[0]])) : (new US8(0)), (v207.tag === 1) ? (new US8(1, ["margin", v207.fields[0]])) : (new US8(0)), (v214.tag === 1) ? (new US8(1, ["marginBottom", v214.fields[0]])) : (new US8(0)), (v221.tag === 1) ? (new US8(1, ["maxHeight", v221.fields[0]])) : (new US8(0)), (v228.tag === 1) ? (new US8(1, ["onChange", v228.fields[0]])) : (new US8(0)), (v235.tag === 1) ? (new US8(1, ["onClick", v235.fields[0]])) : (new US8(0)), (v242.tag === 1) ? (new US8(1, ["outline", v242.fields[0]])) : (new US8(0)), (v249.tag === 1) ? (new US8(1, ["overflowY", v249.fields[0]])) : (new US8(0)), (v256.tag === 1) ? (new US8(1, ["padding", v256.fields[0]])) : (new US8(0)), (v263.tag === 1) ? (new US8(1, ["paddingTop", v263.fields[0]])) : (new US8(0)), (v270.tag === 1) ? (new US8(1, ["position", v270.fields[0]])) : (new US8(0)), (v277.tag === 1) ? (new US8(1, ["right", v277.fields[0]])) : (new US8(0)), (v284.tag === 1) ? (new US8(1, ["size", v284.fields[0]])) : (new US8(0)), (v291.tag === 1) ? (new US8(1, ["spacing", v291.fields[0]])) : (new US8(0)), (v298.tag === 1) ? (new US8(1, ["status", v298.fields[0]])) : (new US8(0)), (v305.tag === 1) ? (new US8(1, ["striped", v305.fields[0]])) : (new US8(0)), (v312.tag === 1) ? (new US8(1, ["thickness", v312.fields[0]])) : (new US8(0)), (v319.tag === 1) ? (new US8(1, ["title", v319.fields[0]])) : (new US8(0)), (v326.tag === 1) ? (new US8(1, ["top", v326.fields[0]])) : (new US8(0)), (v333.tag === 1) ? (new US8(1, ["width", v333.fields[0]])) : (new US8(0)), (v340.tag === 1) ? (new US8(1, ["zIndex", v340.fields[0]])) : (new US8(0))];
    const v348 = v347.length | 0;
    const v349 = fill(new Array(v348), 0, v348, null);
    const v350 = new Mut0(0, 0);
    while (method0(v348, v350)) {
        const v352 = v350.l0 | 0;
        const v353 = v350.l1 | 0;
        const v354 = v347[v352];
        let v358;
        if (v354.tag === 1) {
            v349[v353] = v354;
            v358 = (v353 + 1);
        }
        else {
            v358 = v353;
        }
        const v359 = (v352 + 1) | 0;
        v350.l0 = (v359 | 0);
        v350.l1 = (v358 | 0);
    }
    const v360 = v350.l1 | 0;
    const v361 = fill(new Array(v360), 0, v360, null);
    const v362 = new Mut1(0);
    while (method1(v360, v362)) {
        const v364 = v362.l0 | 0;
        const v365 = v349[v364];
        v361[v364] = v365;
        const v366 = (v364 + 1) | 0;
        v362.l0 = (v366 | 0);
    }
    const v367 = v361.length | 0;
    const v368 = fill(new Array(v367), 0, v367, null);
    const v369 = new Mut1(0);
    while (method1(v367, v369)) {
        const v371 = v369.l0 | 0;
        const v372 = v361[v371];
        let v375;
        if (v372.tag === 1) {
            v375 = v372.fields[0];
        }
        else {
            throw new Error("Option does not have a value.");
        }
        v368[v371] = v375;
        const v376 = (v371 + 1) | 0;
        v369.l0 = (v376 | 0);
    }
    const v377 = createObj(v368);
    const v380 = createComponent;
    return v380(Anchor, v377);
}

export function closure9(unitVar: void, unitVar_1: void): any {
    const v44 = new Heap0(new US0(0), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), new US3(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US2(0), new US4(0), new US0(0), new US0(0), new US0(0), new US0(1, "https://github.com/fc1943s/tictactoe_spiral"), new US5(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0));
    const v52 = (): any => closure6(v44, void 0);
    const v89 = new Heap0(new US0(0), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), new US3(1, v52), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US2(1, true), new US4(0), new US0(0), new US0(0), new US0(0), v44.l17, new US5(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0));
    const v90 = v89.l0;
    const v97 = v89.l1;
    const v104 = v89.l2;
    const v111 = v89.l3;
    const v118 = v89.l4;
    const v125 = v89.l7;
    const v132 = v89.l5;
    const v139 = v89.l6;
    const v146 = v89.l8;
    const v153 = v89.l9;
    const v160 = v89.l11;
    const v167 = v89.l10;
    const v174 = v89.l12;
    const v181 = v89.l13;
    const v188 = v89.l14;
    const v195 = v89.l15;
    const v202 = v89.l16;
    const v209 = v89.l17;
    const v216 = v89.l18;
    const v223 = v89.l19;
    const v230 = v89.l20;
    const v237 = v89.l21;
    const v244 = v89.l22;
    const v251 = v89.l23;
    const v258 = v89.l24;
    const v265 = v89.l25;
    const v272 = v89.l26;
    const v279 = v89.l27;
    const v286 = v89.l28;
    const v293 = v89.l29;
    const v300 = v89.l30;
    const v307 = v89.l31;
    const v314 = v89.l32;
    const v321 = v89.l33;
    const v328 = v89.l34;
    const v335 = v89.l35;
    const v342 = v89.l36;
    const v349 = v89.l37;
    const v356 = v89.l38;
    const v363 = v89.l39;
    const v370 = v89.l40;
    const v377 = v89.l41;
    const v384 = v89.l42;
    const v391 = [(v90.tag === 1) ? (new US8(1, ["aria-label", v90.fields[0]])) : (new US8(0)), (v97.tag === 1) ? (new US8(1, ["as", v97.fields[0]])) : (new US8(0)), (v104.tag === 1) ? (new US8(1, ["backgroundColor", v104.fields[0]])) : (new US8(0)), (v111.tag === 1) ? (new US8(1, ["border", v111.fields[0]])) : (new US8(0)), (v118.tag === 1) ? (new US8(1, ["bottom", v118.fields[0]])) : (new US8(0)), (v125.tag === 1) ? (new US8(1, ["color", v125.fields[0]])) : (new US8(0)), (v132.tag === 1) ? (new US8(1, ["checked", v132.fields[0]])) : (new US8(0)), (v139.tag === 1) ? (new US8(1, ["children", v139.fields[0]])) : (new US8(0)), (v146.tag === 1) ? (new US8(1, ["colorScheme", v146.fields[0]])) : (new US8(0)), (v153.tag === 1) ? (new US8(1, ["compact", v153.fields[0]])) : (new US8(0)), (v160.tag === 1) ? (new US8(1, ["display", v160.fields[0]])) : (new US8(0)), (v167.tag === 1) ? (new US8(1, ["direction", v167.fields[0]])) : (new US8(0)), (v174.tag === 1) ? (new US8(1, ["external", v174.fields[0]])) : (new US8(0)), (v181.tag === 1) ? (new US8(1, ["flex", v181.fields[0]])) : (new US8(0)), (v188.tag === 1) ? (new US8(1, ["flexDirection", v188.fields[0]])) : (new US8(0)), (v195.tag === 1) ? (new US8(1, ["fontSize", v195.fields[0]])) : (new US8(0)), (v202.tag === 1) ? (new US8(1, ["height", v202.fields[0]])) : (new US8(0)), (v209.tag === 1) ? (new US8(1, ["href", v209.fields[0]])) : (new US8(0)), (v216.tag === 1) ? (new US8(1, ["icon", v216.fields[0]])) : (new US8(0)), (v223.tag === 1) ? (new US8(1, ["id", v223.fields[0]])) : (new US8(0)), (v230.tag === 1) ? (new US8(1, ["justifyContent", v230.fields[0]])) : (new US8(0)), (v237.tag === 1) ? (new US8(1, ["left", v237.fields[0]])) : (new US8(0)), (v244.tag === 1) ? (new US8(1, ["lineHeight", v244.fields[0]])) : (new US8(0)), (v251.tag === 1) ? (new US8(1, ["margin", v251.fields[0]])) : (new US8(0)), (v258.tag === 1) ? (new US8(1, ["marginBottom", v258.fields[0]])) : (new US8(0)), (v265.tag === 1) ? (new US8(1, ["maxHeight", v265.fields[0]])) : (new US8(0)), (v272.tag === 1) ? (new US8(1, ["onChange", v272.fields[0]])) : (new US8(0)), (v279.tag === 1) ? (new US8(1, ["onClick", v279.fields[0]])) : (new US8(0)), (v286.tag === 1) ? (new US8(1, ["outline", v286.fields[0]])) : (new US8(0)), (v293.tag === 1) ? (new US8(1, ["overflowY", v293.fields[0]])) : (new US8(0)), (v300.tag === 1) ? (new US8(1, ["padding", v300.fields[0]])) : (new US8(0)), (v307.tag === 1) ? (new US8(1, ["paddingTop", v307.fields[0]])) : (new US8(0)), (v314.tag === 1) ? (new US8(1, ["position", v314.fields[0]])) : (new US8(0)), (v321.tag === 1) ? (new US8(1, ["right", v321.fields[0]])) : (new US8(0)), (v328.tag === 1) ? (new US8(1, ["size", v328.fields[0]])) : (new US8(0)), (v335.tag === 1) ? (new US8(1, ["spacing", v335.fields[0]])) : (new US8(0)), (v342.tag === 1) ? (new US8(1, ["status", v342.fields[0]])) : (new US8(0)), (v349.tag === 1) ? (new US8(1, ["striped", v349.fields[0]])) : (new US8(0)), (v356.tag === 1) ? (new US8(1, ["thickness", v356.fields[0]])) : (new US8(0)), (v363.tag === 1) ? (new US8(1, ["title", v363.fields[0]])) : (new US8(0)), (v370.tag === 1) ? (new US8(1, ["top", v370.fields[0]])) : (new US8(0)), (v377.tag === 1) ? (new US8(1, ["width", v377.fields[0]])) : (new US8(0)), (v384.tag === 1) ? (new US8(1, ["zIndex", v384.fields[0]])) : (new US8(0))];
    const v392 = v391.length | 0;
    const v393 = fill(new Array(v392), 0, v392, null);
    const v394 = new Mut0(0, 0);
    while (method0(v392, v394)) {
        const v396 = v394.l0 | 0;
        const v397 = v394.l1 | 0;
        const v398 = v391[v396];
        let v402;
        if (v398.tag === 1) {
            v393[v397] = v398;
            v402 = (v397 + 1);
        }
        else {
            v402 = v397;
        }
        const v403 = (v396 + 1) | 0;
        v394.l0 = (v403 | 0);
        v394.l1 = (v402 | 0);
    }
    const v404 = v394.l1 | 0;
    const v405 = fill(new Array(v404), 0, v404, null);
    const v406 = new Mut1(0);
    while (method1(v404, v406)) {
        const v408 = v406.l0 | 0;
        const v409 = v393[v408];
        v405[v408] = v409;
        const v410 = (v408 + 1) | 0;
        v406.l0 = (v410 | 0);
    }
    const v411 = v405.length | 0;
    const v412 = fill(new Array(v411), 0, v411, null);
    const v413 = new Mut1(0);
    while (method1(v411, v413)) {
        const v415 = v413.l0 | 0;
        const v416 = v405[v415];
        let v419;
        if (v416.tag === 1) {
            v419 = v416.fields[0];
        }
        else {
            throw new Error("Option does not have a value.");
        }
        v412[v415] = v419;
        const v420 = (v415 + 1) | 0;
        v413.l0 = (v420 | 0);
    }
    const v421 = createObj(v412);
    const v424 = createComponent;
    return [v424(Anchor, v421)];
}

export function closure13(v0_1: any, unitVar: void): any {
    return [v0_1];
}

export function closure12(v0_1: any, unitVar: void): any {
    const v7_1 = (): any => closure13(v0_1, void 0);
    const v46 = new Heap0(new US0(0), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), new US3(1, v7_1), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US2(0), new US4(0), new US0(0), new US0(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(0), new US0(1, "2px"), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0));
    const v47 = v46.l0;
    const v54 = v46.l1;
    const v61 = v46.l2;
    const v68 = v46.l3;
    const v75 = v46.l4;
    const v82 = v46.l7;
    const v89 = v46.l5;
    const v96 = v46.l6;
    const v103 = v46.l8;
    const v110 = v46.l9;
    const v117 = v46.l11;
    const v124 = v46.l10;
    const v131 = v46.l12;
    const v138 = v46.l13;
    const v145 = v46.l14;
    const v152 = v46.l15;
    const v159 = v46.l16;
    const v166 = v46.l17;
    const v173 = v46.l18;
    const v180 = v46.l19;
    const v187 = v46.l20;
    const v194 = v46.l21;
    const v201 = v46.l22;
    const v208 = v46.l23;
    const v215 = v46.l24;
    const v222 = v46.l25;
    const v229 = v46.l26;
    const v236 = v46.l27;
    const v243 = v46.l28;
    const v250 = v46.l29;
    const v257 = v46.l30;
    const v264 = v46.l31;
    const v271 = v46.l32;
    const v278 = v46.l33;
    const v285 = v46.l34;
    const v292 = v46.l35;
    const v299 = v46.l36;
    const v306 = v46.l37;
    const v313 = v46.l38;
    const v320 = v46.l39;
    const v327 = v46.l40;
    const v334 = v46.l41;
    const v341 = v46.l42;
    const v348 = [(v47.tag === 1) ? (new US8(1, ["aria-label", v47.fields[0]])) : (new US8(0)), (v54.tag === 1) ? (new US8(1, ["as", v54.fields[0]])) : (new US8(0)), (v61.tag === 1) ? (new US8(1, ["backgroundColor", v61.fields[0]])) : (new US8(0)), (v68.tag === 1) ? (new US8(1, ["border", v68.fields[0]])) : (new US8(0)), (v75.tag === 1) ? (new US8(1, ["bottom", v75.fields[0]])) : (new US8(0)), (v82.tag === 1) ? (new US8(1, ["color", v82.fields[0]])) : (new US8(0)), (v89.tag === 1) ? (new US8(1, ["checked", v89.fields[0]])) : (new US8(0)), (v96.tag === 1) ? (new US8(1, ["children", v96.fields[0]])) : (new US8(0)), (v103.tag === 1) ? (new US8(1, ["colorScheme", v103.fields[0]])) : (new US8(0)), (v110.tag === 1) ? (new US8(1, ["compact", v110.fields[0]])) : (new US8(0)), (v117.tag === 1) ? (new US8(1, ["display", v117.fields[0]])) : (new US8(0)), (v124.tag === 1) ? (new US8(1, ["direction", v124.fields[0]])) : (new US8(0)), (v131.tag === 1) ? (new US8(1, ["external", v131.fields[0]])) : (new US8(0)), (v138.tag === 1) ? (new US8(1, ["flex", v138.fields[0]])) : (new US8(0)), (v145.tag === 1) ? (new US8(1, ["flexDirection", v145.fields[0]])) : (new US8(0)), (v152.tag === 1) ? (new US8(1, ["fontSize", v152.fields[0]])) : (new US8(0)), (v159.tag === 1) ? (new US8(1, ["height", v159.fields[0]])) : (new US8(0)), (v166.tag === 1) ? (new US8(1, ["href", v166.fields[0]])) : (new US8(0)), (v173.tag === 1) ? (new US8(1, ["icon", v173.fields[0]])) : (new US8(0)), (v180.tag === 1) ? (new US8(1, ["id", v180.fields[0]])) : (new US8(0)), (v187.tag === 1) ? (new US8(1, ["justifyContent", v187.fields[0]])) : (new US8(0)), (v194.tag === 1) ? (new US8(1, ["left", v194.fields[0]])) : (new US8(0)), (v201.tag === 1) ? (new US8(1, ["lineHeight", v201.fields[0]])) : (new US8(0)), (v208.tag === 1) ? (new US8(1, ["margin", v208.fields[0]])) : (new US8(0)), (v215.tag === 1) ? (new US8(1, ["marginBottom", v215.fields[0]])) : (new US8(0)), (v222.tag === 1) ? (new US8(1, ["maxHeight", v222.fields[0]])) : (new US8(0)), (v229.tag === 1) ? (new US8(1, ["onChange", v229.fields[0]])) : (new US8(0)), (v236.tag === 1) ? (new US8(1, ["onClick", v236.fields[0]])) : (new US8(0)), (v243.tag === 1) ? (new US8(1, ["outline", v243.fields[0]])) : (new US8(0)), (v250.tag === 1) ? (new US8(1, ["overflowY", v250.fields[0]])) : (new US8(0)), (v257.tag === 1) ? (new US8(1, ["padding", v257.fields[0]])) : (new US8(0)), (v264.tag === 1) ? (new US8(1, ["paddingTop", v264.fields[0]])) : (new US8(0)), (v271.tag === 1) ? (new US8(1, ["position", v271.fields[0]])) : (new US8(0)), (v278.tag === 1) ? (new US8(1, ["right", v278.fields[0]])) : (new US8(0)), (v285.tag === 1) ? (new US8(1, ["size", v285.fields[0]])) : (new US8(0)), (v292.tag === 1) ? (new US8(1, ["spacing", v292.fields[0]])) : (new US8(0)), (v299.tag === 1) ? (new US8(1, ["status", v299.fields[0]])) : (new US8(0)), (v306.tag === 1) ? (new US8(1, ["striped", v306.fields[0]])) : (new US8(0)), (v313.tag === 1) ? (new US8(1, ["thickness", v313.fields[0]])) : (new US8(0)), (v320.tag === 1) ? (new US8(1, ["title", v320.fields[0]])) : (new US8(0)), (v327.tag === 1) ? (new US8(1, ["top", v327.fields[0]])) : (new US8(0)), (v334.tag === 1) ? (new US8(1, ["width", v334.fields[0]])) : (new US8(0)), (v341.tag === 1) ? (new US8(1, ["zIndex", v341.fields[0]])) : (new US8(0))];
    const v349 = v348.length | 0;
    const v350 = fill(new Array(v349), 0, v349, null);
    const v351 = new Mut0(0, 0);
    while (method0(v349, v351)) {
        const v353 = v351.l0 | 0;
        const v354 = v351.l1 | 0;
        const v355 = v348[v353];
        let v359;
        if (v355.tag === 1) {
            v350[v354] = v355;
            v359 = (v354 + 1);
        }
        else {
            v359 = v354;
        }
        const v360 = (v353 + 1) | 0;
        v351.l0 = (v360 | 0);
        v351.l1 = (v359 | 0);
    }
    const v361 = v351.l1 | 0;
    const v362 = fill(new Array(v361), 0, v361, null);
    const v363 = new Mut1(0);
    while (method1(v361, v363)) {
        const v365 = v363.l0 | 0;
        const v366 = v350[v365];
        v362[v365] = v366;
        const v367 = (v365 + 1) | 0;
        v363.l0 = (v367 | 0);
    }
    const v368 = v362.length | 0;
    const v369 = fill(new Array(v368), 0, v368, null);
    const v370 = new Mut1(0);
    while (method1(v368, v370)) {
        const v372 = v370.l0 | 0;
        const v373 = v362[v372];
        let v376;
        if (v373.tag === 1) {
            v376 = v373.fields[0];
        }
        else {
            throw new Error("Option does not have a value.");
        }
        v369[v372] = v376;
        const v377 = (v372 + 1) | 0;
        v370.l0 = (v377 | 0);
    }
    const v378 = createObj(v369);
    const v381 = createComponent;
    return [v381(Box, v378)];
}

export function closure14(v0_1: (arg0: boolean) => void, v1_1: any): void {
    v0_1(v1_1.target.checked);
}

export function closure11(v0_1: Heap0, v1_1: (arg0: boolean) => void, v2_1: (arg0: void) => boolean, v3_1: any, unitVar: void): any {
    let v13_1: (arg0: void) => any, v36: (arg0: any) => void, v55: Heap0, v56: US0, v63: US1, v70: US0, v77: US0, v84: US0, v91: US0, v98: US2, v105: US3, v112: US0, v119: US2, v126: US0, v133: US0, v140: US2, v147: US4, v154: US0, v161: US0, v168: US0, v175: US0, v182: US5, v189: US0, v196: US0, v203: US0, v210: US0, v217: US0, v224: US0, v231: US0, v238: US6, v245: US7, v252: US0, v259: US0, v266: US0, v273: US0, v280: US0, v287: US0, v294: US0, v301: US0, v308: US2, v315: US0, v322: US0, v329: US5, v336: US0, v343: US0, v350: US4, v357: Array<US8>, v358: int32, v359: Array<US8>, v360: Mut0, v370: int32, v371: Array<US8>, v372: Mut1, v377: int32, v378: Array<[string, any]>, v379: Mut1, v387: any, v390: any;
    return [(v0_1.l36.tag === 1) ? ((v13_1 = ((): any => closure12(v3_1, void 0)), (v36 = ((v: any): void => {
        closure14(v1_1, v);
    }), (v55 = (new Heap0(new US0(0), new US1(0), new US0(0), new US0(0), new US0(0), new US2(1, v2_1()), new US3(1, v13_1), new US0(0), new US0(1, "neutral"), new US2(0), new US0(0), new US0(0), new US2(0), new US4(0), new US0(0), new US0(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(1, "2px"), new US0(0), new US6(1, v36), new US7(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(1, "sm"), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0))), (v56 = v55.l0, (v63 = v55.l1, (v70 = v55.l2, (v77 = v55.l3, (v84 = v55.l4, (v91 = v55.l7, (v98 = v55.l5, (v105 = v55.l6, (v112 = v55.l8, (v119 = v55.l9, (v126 = v55.l11, (v133 = v55.l10, (v140 = v55.l12, (v147 = v55.l13, (v154 = v55.l14, (v161 = v55.l15, (v168 = v55.l16, (v175 = v55.l17, (v182 = v55.l18, (v189 = v55.l19, (v196 = v55.l20, (v203 = v55.l21, (v210 = v55.l22, (v217 = v55.l23, (v224 = v55.l24, (v231 = v55.l25, (v238 = v55.l26, (v245 = v55.l27, (v252 = v55.l28, (v259 = v55.l29, (v266 = v55.l30, (v273 = v55.l31, (v280 = v55.l32, (v287 = v55.l33, (v294 = v55.l34, (v301 = v55.l35, (v308 = v55.l36, (v315 = v55.l37, (v322 = v55.l38, (v329 = v55.l39, (v336 = v55.l40, (v343 = v55.l41, (v350 = v55.l42, (v357 = [(v56.tag === 1) ? (new US8(1, ["aria-label", v56.fields[0]])) : (new US8(0)), (v63.tag === 1) ? (new US8(1, ["as", v63.fields[0]])) : (new US8(0)), (v70.tag === 1) ? (new US8(1, ["backgroundColor", v70.fields[0]])) : (new US8(0)), (v77.tag === 1) ? (new US8(1, ["border", v77.fields[0]])) : (new US8(0)), (v84.tag === 1) ? (new US8(1, ["bottom", v84.fields[0]])) : (new US8(0)), (v91.tag === 1) ? (new US8(1, ["color", v91.fields[0]])) : (new US8(0)), (v98.tag === 1) ? (new US8(1, ["checked", v98.fields[0]])) : (new US8(0)), (v105.tag === 1) ? (new US8(1, ["children", v105.fields[0]])) : (new US8(0)), (v112.tag === 1) ? (new US8(1, ["colorScheme", v112.fields[0]])) : (new US8(0)), (v119.tag === 1) ? (new US8(1, ["compact", v119.fields[0]])) : (new US8(0)), (v126.tag === 1) ? (new US8(1, ["display", v126.fields[0]])) : (new US8(0)), (v133.tag === 1) ? (new US8(1, ["direction", v133.fields[0]])) : (new US8(0)), (v140.tag === 1) ? (new US8(1, ["external", v140.fields[0]])) : (new US8(0)), (v147.tag === 1) ? (new US8(1, ["flex", v147.fields[0]])) : (new US8(0)), (v154.tag === 1) ? (new US8(1, ["flexDirection", v154.fields[0]])) : (new US8(0)), (v161.tag === 1) ? (new US8(1, ["fontSize", v161.fields[0]])) : (new US8(0)), (v168.tag === 1) ? (new US8(1, ["height", v168.fields[0]])) : (new US8(0)), (v175.tag === 1) ? (new US8(1, ["href", v175.fields[0]])) : (new US8(0)), (v182.tag === 1) ? (new US8(1, ["icon", v182.fields[0]])) : (new US8(0)), (v189.tag === 1) ? (new US8(1, ["id", v189.fields[0]])) : (new US8(0)), (v196.tag === 1) ? (new US8(1, ["justifyContent", v196.fields[0]])) : (new US8(0)), (v203.tag === 1) ? (new US8(1, ["left", v203.fields[0]])) : (new US8(0)), (v210.tag === 1) ? (new US8(1, ["lineHeight", v210.fields[0]])) : (new US8(0)), (v217.tag === 1) ? (new US8(1, ["margin", v217.fields[0]])) : (new US8(0)), (v224.tag === 1) ? (new US8(1, ["marginBottom", v224.fields[0]])) : (new US8(0)), (v231.tag === 1) ? (new US8(1, ["maxHeight", v231.fields[0]])) : (new US8(0)), (v238.tag === 1) ? (new US8(1, ["onChange", v238.fields[0]])) : (new US8(0)), (v245.tag === 1) ? (new US8(1, ["onClick", v245.fields[0]])) : (new US8(0)), (v252.tag === 1) ? (new US8(1, ["outline", v252.fields[0]])) : (new US8(0)), (v259.tag === 1) ? (new US8(1, ["overflowY", v259.fields[0]])) : (new US8(0)), (v266.tag === 1) ? (new US8(1, ["padding", v266.fields[0]])) : (new US8(0)), (v273.tag === 1) ? (new US8(1, ["paddingTop", v273.fields[0]])) : (new US8(0)), (v280.tag === 1) ? (new US8(1, ["position", v280.fields[0]])) : (new US8(0)), (v287.tag === 1) ? (new US8(1, ["right", v287.fields[0]])) : (new US8(0)), (v294.tag === 1) ? (new US8(1, ["size", v294.fields[0]])) : (new US8(0)), (v301.tag === 1) ? (new US8(1, ["spacing", v301.fields[0]])) : (new US8(0)), (v308.tag === 1) ? (new US8(1, ["status", v308.fields[0]])) : (new US8(0)), (v315.tag === 1) ? (new US8(1, ["striped", v315.fields[0]])) : (new US8(0)), (v322.tag === 1) ? (new US8(1, ["thickness", v322.fields[0]])) : (new US8(0)), (v329.tag === 1) ? (new US8(1, ["title", v329.fields[0]])) : (new US8(0)), (v336.tag === 1) ? (new US8(1, ["top", v336.fields[0]])) : (new US8(0)), (v343.tag === 1) ? (new US8(1, ["width", v343.fields[0]])) : (new US8(0)), (v350.tag === 1) ? (new US8(1, ["zIndex", v350.fields[0]])) : (new US8(0))], (v358 = (v357.length | 0), (v359 = fill(new Array(v358), 0, v358, null), (v360 = (new Mut0(0, 0)), ((() => {
        while (method0(v358, v360)) {
            const v362 = v360.l0 | 0;
            const v363 = v360.l1 | 0;
            const v364 = v357[v362];
            let v368;
            if (v364.tag === 1) {
                v359[v363] = v364;
                v368 = (v363 + 1);
            }
            else {
                v368 = v363;
            }
            const v369 = (v362 + 1) | 0;
            v360.l0 = (v369 | 0);
            v360.l1 = (v368 | 0);
        }
    })(), (v370 = (v360.l1 | 0), (v371 = fill(new Array(v370), 0, v370, null), (v372 = (new Mut1(0)), ((() => {
        while (method1(v370, v372)) {
            const v374 = v372.l0 | 0;
            const v375 = v359[v374];
            v371[v374] = v375;
            const v376 = (v374 + 1) | 0;
            v372.l0 = (v376 | 0);
        }
    })(), (v377 = (v371.length | 0), (v378 = fill(new Array(v377), 0, v377, null), (v379 = (new Mut1(0)), ((() => {
        while (method1(v377, v379)) {
            const v381 = v379.l0 | 0;
            const v382 = v371[v381];
            let v385;
            if (v382.tag === 1) {
                v385 = v382.fields[0];
            }
            else {
                throw new Error("Option does not have a value.");
            }
            v378[v381] = v385;
            const v386 = (v381 + 1) | 0;
            v379.l0 = (v386 | 0);
        }
    })(), (v387 = createObj(v378), (v390 = createComponent, v390(Checkbox, v387))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))) : v3_1];
}

export function closure15(unitVar: void, v0_1: Heap0): any {
    const v1_1 = v0_1.l0;
    const v8_1 = v0_1.l1;
    const v15_1 = v0_1.l2;
    const v22 = v0_1.l3;
    const v29 = v0_1.l4;
    const v36 = v0_1.l7;
    const v43 = v0_1.l5;
    const v50 = v0_1.l6;
    const v57 = v0_1.l8;
    const v64 = v0_1.l9;
    const v71 = v0_1.l11;
    const v78 = v0_1.l10;
    const v85 = v0_1.l12;
    const v92 = v0_1.l13;
    const v99 = v0_1.l14;
    const v106 = v0_1.l15;
    const v113 = v0_1.l16;
    const v120 = v0_1.l17;
    const v127 = v0_1.l18;
    const v134 = v0_1.l19;
    const v141 = v0_1.l20;
    const v148 = v0_1.l21;
    const v155 = v0_1.l22;
    const v162 = v0_1.l23;
    const v169 = v0_1.l24;
    const v176 = v0_1.l25;
    const v183 = v0_1.l26;
    const v190 = v0_1.l27;
    const v197 = v0_1.l28;
    const v204 = v0_1.l29;
    const v211 = v0_1.l30;
    const v218 = v0_1.l31;
    const v225 = v0_1.l32;
    const v232 = v0_1.l33;
    const v239 = v0_1.l34;
    const v246 = v0_1.l35;
    const v253 = v0_1.l36;
    const v260 = v0_1.l37;
    const v267 = v0_1.l38;
    const v274 = v0_1.l39;
    const v281 = v0_1.l40;
    const v288 = v0_1.l41;
    const v295 = v0_1.l42;
    const v302 = [(v1_1.tag === 1) ? (new US8(1, ["aria-label", v1_1.fields[0]])) : (new US8(0)), (v8_1.tag === 1) ? (new US8(1, ["as", v8_1.fields[0]])) : (new US8(0)), (v15_1.tag === 1) ? (new US8(1, ["backgroundColor", v15_1.fields[0]])) : (new US8(0)), (v22.tag === 1) ? (new US8(1, ["border", v22.fields[0]])) : (new US8(0)), (v29.tag === 1) ? (new US8(1, ["bottom", v29.fields[0]])) : (new US8(0)), (v36.tag === 1) ? (new US8(1, ["color", v36.fields[0]])) : (new US8(0)), (v43.tag === 1) ? (new US8(1, ["checked", v43.fields[0]])) : (new US8(0)), (v50.tag === 1) ? (new US8(1, ["children", v50.fields[0]])) : (new US8(0)), (v57.tag === 1) ? (new US8(1, ["colorScheme", v57.fields[0]])) : (new US8(0)), (v64.tag === 1) ? (new US8(1, ["compact", v64.fields[0]])) : (new US8(0)), (v71.tag === 1) ? (new US8(1, ["display", v71.fields[0]])) : (new US8(0)), (v78.tag === 1) ? (new US8(1, ["direction", v78.fields[0]])) : (new US8(0)), (v85.tag === 1) ? (new US8(1, ["external", v85.fields[0]])) : (new US8(0)), (v92.tag === 1) ? (new US8(1, ["flex", v92.fields[0]])) : (new US8(0)), (v99.tag === 1) ? (new US8(1, ["flexDirection", v99.fields[0]])) : (new US8(0)), (v106.tag === 1) ? (new US8(1, ["fontSize", v106.fields[0]])) : (new US8(0)), (v113.tag === 1) ? (new US8(1, ["height", v113.fields[0]])) : (new US8(0)), (v120.tag === 1) ? (new US8(1, ["href", v120.fields[0]])) : (new US8(0)), (v127.tag === 1) ? (new US8(1, ["icon", v127.fields[0]])) : (new US8(0)), (v134.tag === 1) ? (new US8(1, ["id", v134.fields[0]])) : (new US8(0)), (v141.tag === 1) ? (new US8(1, ["justifyContent", v141.fields[0]])) : (new US8(0)), (v148.tag === 1) ? (new US8(1, ["left", v148.fields[0]])) : (new US8(0)), (v155.tag === 1) ? (new US8(1, ["lineHeight", v155.fields[0]])) : (new US8(0)), (v162.tag === 1) ? (new US8(1, ["margin", v162.fields[0]])) : (new US8(0)), (v169.tag === 1) ? (new US8(1, ["marginBottom", v169.fields[0]])) : (new US8(0)), (v176.tag === 1) ? (new US8(1, ["maxHeight", v176.fields[0]])) : (new US8(0)), (v183.tag === 1) ? (new US8(1, ["onChange", v183.fields[0]])) : (new US8(0)), (v190.tag === 1) ? (new US8(1, ["onClick", v190.fields[0]])) : (new US8(0)), (v197.tag === 1) ? (new US8(1, ["outline", v197.fields[0]])) : (new US8(0)), (v204.tag === 1) ? (new US8(1, ["overflowY", v204.fields[0]])) : (new US8(0)), (v211.tag === 1) ? (new US8(1, ["padding", v211.fields[0]])) : (new US8(0)), (v218.tag === 1) ? (new US8(1, ["paddingTop", v218.fields[0]])) : (new US8(0)), (v225.tag === 1) ? (new US8(1, ["position", v225.fields[0]])) : (new US8(0)), (v232.tag === 1) ? (new US8(1, ["right", v232.fields[0]])) : (new US8(0)), (v239.tag === 1) ? (new US8(1, ["size", v239.fields[0]])) : (new US8(0)), (v246.tag === 1) ? (new US8(1, ["spacing", v246.fields[0]])) : (new US8(0)), (v253.tag === 1) ? (new US8(1, ["status", v253.fields[0]])) : (new US8(0)), (v260.tag === 1) ? (new US8(1, ["striped", v260.fields[0]])) : (new US8(0)), (v267.tag === 1) ? (new US8(1, ["thickness", v267.fields[0]])) : (new US8(0)), (v274.tag === 1) ? (new US8(1, ["title", v274.fields[0]])) : (new US8(0)), (v281.tag === 1) ? (new US8(1, ["top", v281.fields[0]])) : (new US8(0)), (v288.tag === 1) ? (new US8(1, ["width", v288.fields[0]])) : (new US8(0)), (v295.tag === 1) ? (new US8(1, ["zIndex", v295.fields[0]])) : (new US8(0))];
    const v303 = v302.length | 0;
    const v304 = fill(new Array(v303), 0, v303, null);
    const v305 = new Mut0(0, 0);
    while (method0(v303, v305)) {
        const v307 = v305.l0 | 0;
        const v308 = v305.l1 | 0;
        const v309 = v302[v307];
        let v313;
        if (v309.tag === 1) {
            v304[v308] = v309;
            v313 = (v308 + 1);
        }
        else {
            v313 = v308;
        }
        const v314 = (v307 + 1) | 0;
        v305.l0 = (v314 | 0);
        v305.l1 = (v313 | 0);
    }
    const v315 = v305.l1 | 0;
    const v316 = fill(new Array(v315), 0, v315, null);
    const v317 = new Mut1(0);
    while (method1(v315, v317)) {
        const v319 = v317.l0 | 0;
        const v320 = v304[v319];
        v316[v319] = v320;
        const v321 = (v319 + 1) | 0;
        v317.l0 = (v321 | 0);
    }
    const v322 = v316.length | 0;
    const v323 = fill(new Array(v322), 0, v322, null);
    const v324 = new Mut1(0);
    while (method1(v322, v324)) {
        const v326 = v324.l0 | 0;
        const v327 = v316[v326];
        let v330;
        if (v327.tag === 1) {
            v330 = v327.fields[0];
        }
        else {
            throw new Error("Option does not have a value.");
        }
        v323[v326] = v330;
        const v331 = (v326 + 1) | 0;
        v324.l0 = (v331 | 0);
    }
    const v332 = createObj(v323);
    const v335 = createComponent;
    return v335(Td, v332);
}

export function closure16(unitVar: void, unitVar_1: void): any {
    return ["&nbsp;"];
}

export function closure18(v0_1: (arg0: void) => any, unitVar: void): any {
    return [v0_1()];
}

export function closure19(v0_1: (arg0: void) => boolean, unitVar: void): Array<boolean> {
    return [v0_1()];
}

export function closure20(v0_1: (arg0: boolean) => void, v1_1: (arg0: void) => boolean, unitVar: void): void {
    if (v1_1()) {
        v0_1(false);
    }
}

export function closure23(unitVar: void, unitVar_1: void): any {
    return ["Load"];
}

export function closure24(v0_1: (arg0: boolean) => void, unitVar: void): void {
    v0_1(true);
}

export function closure22(v0_1: (arg0: boolean) => void, unitVar: void): any {
    const v7_1 = (): any => closure23(void 0, void 0);
    const v29 = (): void => {
        closure24(v0_1, void 0);
    };
    const v68 = "left";
    const v93 = new Heap0(new US0(0), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), (new Heap0(new US0(0), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), new US3(1, v7_1), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US2(0), new US4(0), new US0(0), new US0(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(1, v29), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0))).l6, new US0(0), new US0(1, "neutral"), new US2(1, true), new US0(0), new US0(0), new US2(0), new US4(0), new US0(0), new US0(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(1, v68), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(1, "xs"), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0));
    const v94 = v93.l0;
    const v101 = v93.l1;
    const v108 = v93.l2;
    const v115 = v93.l3;
    const v122 = v93.l4;
    const v129 = v93.l7;
    const v136 = v93.l5;
    const v143 = v93.l6;
    const v150 = v93.l8;
    const v157 = v93.l9;
    const v164 = v93.l11;
    const v171 = v93.l10;
    const v178 = v93.l12;
    const v185 = v93.l13;
    const v192 = v93.l14;
    const v199 = v93.l15;
    const v206 = v93.l16;
    const v213 = v93.l17;
    const v220 = v93.l18;
    const v227 = v93.l19;
    const v234 = v93.l20;
    const v241 = v93.l21;
    const v247 = v93.l22;
    const v254 = v93.l23;
    const v261 = v93.l24;
    const v268 = v93.l25;
    const v275 = v93.l26;
    const v282 = v93.l27;
    const v289 = v93.l28;
    const v296 = v93.l29;
    const v303 = v93.l30;
    const v310 = v93.l31;
    const v317 = v93.l32;
    const v324 = v93.l33;
    const v331 = v93.l34;
    const v338 = v93.l35;
    const v345 = v93.l36;
    const v352 = v93.l37;
    const v359 = v93.l38;
    const v366 = v93.l39;
    const v373 = v93.l40;
    const v380 = v93.l41;
    const v387 = v93.l42;
    const v394 = [(v94.tag === 1) ? (new US8(1, ["aria-label", v94.fields[0]])) : (new US8(0)), (v101.tag === 1) ? (new US8(1, ["as", v101.fields[0]])) : (new US8(0)), (v108.tag === 1) ? (new US8(1, ["backgroundColor", v108.fields[0]])) : (new US8(0)), (v115.tag === 1) ? (new US8(1, ["border", v115.fields[0]])) : (new US8(0)), (v122.tag === 1) ? (new US8(1, ["bottom", v122.fields[0]])) : (new US8(0)), (v129.tag === 1) ? (new US8(1, ["color", v129.fields[0]])) : (new US8(0)), (v136.tag === 1) ? (new US8(1, ["checked", v136.fields[0]])) : (new US8(0)), (v143.tag === 1) ? (new US8(1, ["children", v143.fields[0]])) : (new US8(0)), (v150.tag === 1) ? (new US8(1, ["colorScheme", v150.fields[0]])) : (new US8(0)), (v157.tag === 1) ? (new US8(1, ["compact", v157.fields[0]])) : (new US8(0)), (v164.tag === 1) ? (new US8(1, ["display", v164.fields[0]])) : (new US8(0)), (v171.tag === 1) ? (new US8(1, ["direction", v171.fields[0]])) : (new US8(0)), (v178.tag === 1) ? (new US8(1, ["external", v178.fields[0]])) : (new US8(0)), (v185.tag === 1) ? (new US8(1, ["flex", v185.fields[0]])) : (new US8(0)), (v192.tag === 1) ? (new US8(1, ["flexDirection", v192.fields[0]])) : (new US8(0)), (v199.tag === 1) ? (new US8(1, ["fontSize", v199.fields[0]])) : (new US8(0)), (v206.tag === 1) ? (new US8(1, ["height", v206.fields[0]])) : (new US8(0)), (v213.tag === 1) ? (new US8(1, ["href", v213.fields[0]])) : (new US8(0)), (v220.tag === 1) ? (new US8(1, ["icon", v220.fields[0]])) : (new US8(0)), (v227.tag === 1) ? (new US8(1, ["id", v227.fields[0]])) : (new US8(0)), (v234.tag === 1) ? (new US8(1, ["justifyContent", v234.fields[0]])) : (new US8(0)), (v241.tag === 1) ? (new US8(1, [v68, v241.fields[0]])) : (new US8(0)), (v247.tag === 1) ? (new US8(1, ["lineHeight", v247.fields[0]])) : (new US8(0)), (v254.tag === 1) ? (new US8(1, ["margin", v254.fields[0]])) : (new US8(0)), (v261.tag === 1) ? (new US8(1, ["marginBottom", v261.fields[0]])) : (new US8(0)), (v268.tag === 1) ? (new US8(1, ["maxHeight", v268.fields[0]])) : (new US8(0)), (v275.tag === 1) ? (new US8(1, ["onChange", v275.fields[0]])) : (new US8(0)), (v282.tag === 1) ? (new US8(1, ["onClick", v282.fields[0]])) : (new US8(0)), (v289.tag === 1) ? (new US8(1, ["outline", v289.fields[0]])) : (new US8(0)), (v296.tag === 1) ? (new US8(1, ["overflowY", v296.fields[0]])) : (new US8(0)), (v303.tag === 1) ? (new US8(1, ["padding", v303.fields[0]])) : (new US8(0)), (v310.tag === 1) ? (new US8(1, ["paddingTop", v310.fields[0]])) : (new US8(0)), (v317.tag === 1) ? (new US8(1, ["position", v317.fields[0]])) : (new US8(0)), (v324.tag === 1) ? (new US8(1, ["right", v324.fields[0]])) : (new US8(0)), (v331.tag === 1) ? (new US8(1, ["size", v331.fields[0]])) : (new US8(0)), (v338.tag === 1) ? (new US8(1, ["spacing", v338.fields[0]])) : (new US8(0)), (v345.tag === 1) ? (new US8(1, ["status", v345.fields[0]])) : (new US8(0)), (v352.tag === 1) ? (new US8(1, ["striped", v352.fields[0]])) : (new US8(0)), (v359.tag === 1) ? (new US8(1, ["thickness", v359.fields[0]])) : (new US8(0)), (v366.tag === 1) ? (new US8(1, ["title", v366.fields[0]])) : (new US8(0)), (v373.tag === 1) ? (new US8(1, ["top", v373.fields[0]])) : (new US8(0)), (v380.tag === 1) ? (new US8(1, ["width", v380.fields[0]])) : (new US8(0)), (v387.tag === 1) ? (new US8(1, ["zIndex", v387.fields[0]])) : (new US8(0))];
    const v395 = v394.length | 0;
    const v396 = fill(new Array(v395), 0, v395, null);
    const v397 = new Mut0(0, 0);
    while (method0(v395, v397)) {
        const v399 = v397.l0 | 0;
        const v400 = v397.l1 | 0;
        const v401 = v394[v399];
        let v405;
        if (v401.tag === 1) {
            v396[v400] = v401;
            v405 = (v400 + 1);
        }
        else {
            v405 = v400;
        }
        const v406 = (v399 + 1) | 0;
        v397.l0 = (v406 | 0);
        v397.l1 = (v405 | 0);
    }
    const v407 = v397.l1 | 0;
    const v408 = fill(new Array(v407), 0, v407, null);
    const v409 = new Mut1(0);
    while (method1(v407, v409)) {
        const v411 = v409.l0 | 0;
        const v412 = v396[v411];
        v408[v411] = v412;
        const v413 = (v411 + 1) | 0;
        v409.l0 = (v413 | 0);
    }
    const v414 = v408.length | 0;
    const v415 = fill(new Array(v414), 0, v414, null);
    const v416 = new Mut1(0);
    while (method1(v414, v416)) {
        const v418 = v416.l0 | 0;
        const v419 = v408[v418];
        let v422;
        if (v419.tag === 1) {
            v422 = v419.fields[0];
        }
        else {
            throw new Error("Option does not have a value.");
        }
        v415[v418] = v422;
        const v423 = (v418 + 1) | 0;
        v416.l0 = (v423 | 0);
    }
    const v424 = createObj(v415);
    const v427 = createComponent;
    return [v427(Button, v424)];
}

export function closure25(unitVar: void, v0_1: Heap0): any {
    const v1_1 = v0_1.l0;
    const v8_1 = v0_1.l1;
    const v15_1 = v0_1.l2;
    const v22 = v0_1.l3;
    const v29 = v0_1.l4;
    const v36 = v0_1.l7;
    const v43 = v0_1.l5;
    const v50 = v0_1.l6;
    const v57 = v0_1.l8;
    const v64 = v0_1.l9;
    const v71 = v0_1.l11;
    const v78 = v0_1.l10;
    const v85 = v0_1.l12;
    const v92 = v0_1.l13;
    const v99 = v0_1.l14;
    const v106 = v0_1.l15;
    const v113 = v0_1.l16;
    const v120 = v0_1.l17;
    const v127 = v0_1.l18;
    const v134 = v0_1.l19;
    const v141 = v0_1.l20;
    const v148 = v0_1.l21;
    const v155 = v0_1.l22;
    const v162 = v0_1.l23;
    const v169 = v0_1.l24;
    const v176 = v0_1.l25;
    const v183 = v0_1.l26;
    const v190 = v0_1.l27;
    const v197 = v0_1.l28;
    const v204 = v0_1.l29;
    const v211 = v0_1.l30;
    const v218 = v0_1.l31;
    const v225 = v0_1.l32;
    const v232 = v0_1.l33;
    const v239 = v0_1.l34;
    const v246 = v0_1.l35;
    const v253 = v0_1.l36;
    const v260 = v0_1.l37;
    const v267 = v0_1.l38;
    const v274 = v0_1.l39;
    const v281 = v0_1.l40;
    const v288 = v0_1.l41;
    const v295 = v0_1.l42;
    const v302 = [(v1_1.tag === 1) ? (new US8(1, ["aria-label", v1_1.fields[0]])) : (new US8(0)), (v8_1.tag === 1) ? (new US8(1, ["as", v8_1.fields[0]])) : (new US8(0)), (v15_1.tag === 1) ? (new US8(1, ["backgroundColor", v15_1.fields[0]])) : (new US8(0)), (v22.tag === 1) ? (new US8(1, ["border", v22.fields[0]])) : (new US8(0)), (v29.tag === 1) ? (new US8(1, ["bottom", v29.fields[0]])) : (new US8(0)), (v36.tag === 1) ? (new US8(1, ["color", v36.fields[0]])) : (new US8(0)), (v43.tag === 1) ? (new US8(1, ["checked", v43.fields[0]])) : (new US8(0)), (v50.tag === 1) ? (new US8(1, ["children", v50.fields[0]])) : (new US8(0)), (v57.tag === 1) ? (new US8(1, ["colorScheme", v57.fields[0]])) : (new US8(0)), (v64.tag === 1) ? (new US8(1, ["compact", v64.fields[0]])) : (new US8(0)), (v71.tag === 1) ? (new US8(1, ["display", v71.fields[0]])) : (new US8(0)), (v78.tag === 1) ? (new US8(1, ["direction", v78.fields[0]])) : (new US8(0)), (v85.tag === 1) ? (new US8(1, ["external", v85.fields[0]])) : (new US8(0)), (v92.tag === 1) ? (new US8(1, ["flex", v92.fields[0]])) : (new US8(0)), (v99.tag === 1) ? (new US8(1, ["flexDirection", v99.fields[0]])) : (new US8(0)), (v106.tag === 1) ? (new US8(1, ["fontSize", v106.fields[0]])) : (new US8(0)), (v113.tag === 1) ? (new US8(1, ["height", v113.fields[0]])) : (new US8(0)), (v120.tag === 1) ? (new US8(1, ["href", v120.fields[0]])) : (new US8(0)), (v127.tag === 1) ? (new US8(1, ["icon", v127.fields[0]])) : (new US8(0)), (v134.tag === 1) ? (new US8(1, ["id", v134.fields[0]])) : (new US8(0)), (v141.tag === 1) ? (new US8(1, ["justifyContent", v141.fields[0]])) : (new US8(0)), (v148.tag === 1) ? (new US8(1, ["left", v148.fields[0]])) : (new US8(0)), (v155.tag === 1) ? (new US8(1, ["lineHeight", v155.fields[0]])) : (new US8(0)), (v162.tag === 1) ? (new US8(1, ["margin", v162.fields[0]])) : (new US8(0)), (v169.tag === 1) ? (new US8(1, ["marginBottom", v169.fields[0]])) : (new US8(0)), (v176.tag === 1) ? (new US8(1, ["maxHeight", v176.fields[0]])) : (new US8(0)), (v183.tag === 1) ? (new US8(1, ["onChange", v183.fields[0]])) : (new US8(0)), (v190.tag === 1) ? (new US8(1, ["onClick", v190.fields[0]])) : (new US8(0)), (v197.tag === 1) ? (new US8(1, ["outline", v197.fields[0]])) : (new US8(0)), (v204.tag === 1) ? (new US8(1, ["overflowY", v204.fields[0]])) : (new US8(0)), (v211.tag === 1) ? (new US8(1, ["padding", v211.fields[0]])) : (new US8(0)), (v218.tag === 1) ? (new US8(1, ["paddingTop", v218.fields[0]])) : (new US8(0)), (v225.tag === 1) ? (new US8(1, ["position", v225.fields[0]])) : (new US8(0)), (v232.tag === 1) ? (new US8(1, ["right", v232.fields[0]])) : (new US8(0)), (v239.tag === 1) ? (new US8(1, ["size", v239.fields[0]])) : (new US8(0)), (v246.tag === 1) ? (new US8(1, ["spacing", v246.fields[0]])) : (new US8(0)), (v253.tag === 1) ? (new US8(1, ["status", v253.fields[0]])) : (new US8(0)), (v260.tag === 1) ? (new US8(1, ["striped", v260.fields[0]])) : (new US8(0)), (v267.tag === 1) ? (new US8(1, ["thickness", v267.fields[0]])) : (new US8(0)), (v274.tag === 1) ? (new US8(1, ["title", v274.fields[0]])) : (new US8(0)), (v281.tag === 1) ? (new US8(1, ["top", v281.fields[0]])) : (new US8(0)), (v288.tag === 1) ? (new US8(1, ["width", v288.fields[0]])) : (new US8(0)), (v295.tag === 1) ? (new US8(1, ["zIndex", v295.fields[0]])) : (new US8(0))];
    const v303 = v302.length | 0;
    const v304 = fill(new Array(v303), 0, v303, null);
    const v305 = new Mut0(0, 0);
    while (method0(v303, v305)) {
        const v307 = v305.l0 | 0;
        const v308 = v305.l1 | 0;
        const v309 = v302[v307];
        let v313;
        if (v309.tag === 1) {
            v304[v308] = v309;
            v313 = (v308 + 1);
        }
        else {
            v313 = v308;
        }
        const v314 = (v307 + 1) | 0;
        v305.l0 = (v314 | 0);
        v305.l1 = (v313 | 0);
    }
    const v315 = v305.l1 | 0;
    const v316 = fill(new Array(v315), 0, v315, null);
    const v317 = new Mut1(0);
    while (method1(v315, v317)) {
        const v319 = v317.l0 | 0;
        const v320 = v304[v319];
        v316[v319] = v320;
        const v321 = (v319 + 1) | 0;
        v317.l0 = (v321 | 0);
    }
    const v322 = v316.length | 0;
    const v323 = fill(new Array(v322), 0, v322, null);
    const v324 = new Mut1(0);
    while (method1(v322, v324)) {
        const v326 = v324.l0 | 0;
        const v327 = v316[v326];
        let v330;
        if (v327.tag === 1) {
            v330 = v327.fields[0];
        }
        else {
            throw new Error("Option does not have a value.");
        }
        v323[v326] = v330;
        const v331 = (v326 + 1) | 0;
        v324.l0 = (v331 | 0);
    }
    const v332 = createObj(v323);
    const v335 = createComponent;
    return v335(Box, v332);
}

export function closure29(v0_1: (arg0: boolean) => void, unitVar: void): void {
    v0_1(true);
}

export function closure30(v0_1: (arg0: boolean) => void, v1_1: (arg0: void) => boolean, unitVar: void): void {
    v0_1(v1_1() === false);
}

export function closure31(v0_1: (arg0: boolean) => void, unitVar: void): void {
    v0_1(false);
}

export function closure28(v0_1: (arg0: boolean) => void, v1_1: (arg0: boolean) => void, v2_1: (arg0: boolean) => void, v3_1: (arg0: void) => boolean, unitVar: void): any {
    let v448: any, v450: any;
    const v6_1 = BiRegularRefresh;
    const v41 = "14px";
    const v51 = new Heap0(new US0(0), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), new US3(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US2(0), new US4(0), new US0(0), new US0(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(1, v41), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0));
    const v55 = createComponent;
    const v66 = "neutral";
    const v75 = "20px";
    const v87 = (): void => {
        closure29(v1_1, void 0);
    };
    const v95 = "xs";
    const v105 = new Heap0(new US0(1, "Refresh"), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), new US3(0), new US0(0), new US0(1, v66), new US2(0), new US0(0), new US0(0), new US2(0), new US4(0), new US0(0), new US0(0), new US0(1, v75), new US0(0), new US5(1, v55(v6_1, v51)), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(1, v87), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(1, v95), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0));
    const v106 = v105.l0;
    const v113 = v105.l1;
    const v120 = v105.l2;
    const v127 = v105.l3;
    const v134 = v105.l4;
    const v141 = v105.l7;
    const v148 = v105.l5;
    const v155 = v105.l6;
    const v162 = v105.l8;
    const v169 = v105.l9;
    const v176 = v105.l11;
    const v183 = v105.l10;
    const v190 = v105.l12;
    const v197 = v105.l13;
    const v204 = v105.l14;
    const v211 = v105.l15;
    const v218 = v105.l16;
    const v225 = v105.l17;
    const v232 = v105.l18;
    const v239 = v105.l19;
    const v246 = v105.l20;
    const v253 = v105.l21;
    const v260 = v105.l22;
    const v267 = v105.l23;
    const v274 = v105.l24;
    const v281 = v105.l25;
    const v288 = v105.l26;
    const v295 = v105.l27;
    const v302 = v105.l28;
    const v309 = v105.l29;
    const v316 = v105.l30;
    const v323 = v105.l31;
    const v330 = v105.l32;
    const v337 = v105.l33;
    const v344 = v105.l34;
    const v351 = v105.l35;
    const v358 = v105.l36;
    const v365 = v105.l37;
    const v372 = v105.l38;
    const v379 = v105.l39;
    const v386 = v105.l40;
    const v393 = v105.l41;
    const v400 = v105.l42;
    const v407 = [(v106.tag === 1) ? (new US8(1, ["aria-label", v106.fields[0]])) : (new US8(0)), (v113.tag === 1) ? (new US8(1, ["as", v113.fields[0]])) : (new US8(0)), (v120.tag === 1) ? (new US8(1, ["backgroundColor", v120.fields[0]])) : (new US8(0)), (v127.tag === 1) ? (new US8(1, ["border", v127.fields[0]])) : (new US8(0)), (v134.tag === 1) ? (new US8(1, ["bottom", v134.fields[0]])) : (new US8(0)), (v141.tag === 1) ? (new US8(1, ["color", v141.fields[0]])) : (new US8(0)), (v148.tag === 1) ? (new US8(1, ["checked", v148.fields[0]])) : (new US8(0)), (v155.tag === 1) ? (new US8(1, ["children", v155.fields[0]])) : (new US8(0)), (v162.tag === 1) ? (new US8(1, ["colorScheme", v162.fields[0]])) : (new US8(0)), (v169.tag === 1) ? (new US8(1, ["compact", v169.fields[0]])) : (new US8(0)), (v176.tag === 1) ? (new US8(1, ["display", v176.fields[0]])) : (new US8(0)), (v183.tag === 1) ? (new US8(1, ["direction", v183.fields[0]])) : (new US8(0)), (v190.tag === 1) ? (new US8(1, ["external", v190.fields[0]])) : (new US8(0)), (v197.tag === 1) ? (new US8(1, ["flex", v197.fields[0]])) : (new US8(0)), (v204.tag === 1) ? (new US8(1, ["flexDirection", v204.fields[0]])) : (new US8(0)), (v211.tag === 1) ? (new US8(1, ["fontSize", v211.fields[0]])) : (new US8(0)), (v218.tag === 1) ? (new US8(1, ["height", v218.fields[0]])) : (new US8(0)), (v225.tag === 1) ? (new US8(1, ["href", v225.fields[0]])) : (new US8(0)), (v232.tag === 1) ? (new US8(1, ["icon", v232.fields[0]])) : (new US8(0)), (v239.tag === 1) ? (new US8(1, ["id", v239.fields[0]])) : (new US8(0)), (v246.tag === 1) ? (new US8(1, ["justifyContent", v246.fields[0]])) : (new US8(0)), (v253.tag === 1) ? (new US8(1, ["left", v253.fields[0]])) : (new US8(0)), (v260.tag === 1) ? (new US8(1, ["lineHeight", v260.fields[0]])) : (new US8(0)), (v267.tag === 1) ? (new US8(1, ["margin", v267.fields[0]])) : (new US8(0)), (v274.tag === 1) ? (new US8(1, ["marginBottom", v274.fields[0]])) : (new US8(0)), (v281.tag === 1) ? (new US8(1, ["maxHeight", v281.fields[0]])) : (new US8(0)), (v288.tag === 1) ? (new US8(1, ["onChange", v288.fields[0]])) : (new US8(0)), (v295.tag === 1) ? (new US8(1, ["onClick", v295.fields[0]])) : (new US8(0)), (v302.tag === 1) ? (new US8(1, ["outline", v302.fields[0]])) : (new US8(0)), (v309.tag === 1) ? (new US8(1, ["overflowY", v309.fields[0]])) : (new US8(0)), (v316.tag === 1) ? (new US8(1, ["padding", v316.fields[0]])) : (new US8(0)), (v323.tag === 1) ? (new US8(1, ["paddingTop", v323.fields[0]])) : (new US8(0)), (v330.tag === 1) ? (new US8(1, ["position", v330.fields[0]])) : (new US8(0)), (v337.tag === 1) ? (new US8(1, ["right", v337.fields[0]])) : (new US8(0)), (v344.tag === 1) ? (new US8(1, ["size", v344.fields[0]])) : (new US8(0)), (v351.tag === 1) ? (new US8(1, ["spacing", v351.fields[0]])) : (new US8(0)), (v358.tag === 1) ? (new US8(1, ["status", v358.fields[0]])) : (new US8(0)), (v365.tag === 1) ? (new US8(1, ["striped", v365.fields[0]])) : (new US8(0)), (v372.tag === 1) ? (new US8(1, ["thickness", v372.fields[0]])) : (new US8(0)), (v379.tag === 1) ? (new US8(1, ["title", v379.fields[0]])) : (new US8(0)), (v386.tag === 1) ? (new US8(1, ["top", v386.fields[0]])) : (new US8(0)), (v393.tag === 1) ? (new US8(1, ["width", v393.fields[0]])) : (new US8(0)), (v400.tag === 1) ? (new US8(1, ["zIndex", v400.fields[0]])) : (new US8(0))];
    const v408 = v407.length | 0;
    const v409 = fill(new Array(v408), 0, v408, null);
    const v410 = new Mut0(0, 0);
    while (method0(v408, v410)) {
        const v412 = v410.l0 | 0;
        const v413 = v410.l1 | 0;
        const v414 = v407[v412];
        let v418;
        if (v414.tag === 1) {
            v409[v413] = v414;
            v418 = (v413 + 1);
        }
        else {
            v418 = v413;
        }
        const v419 = (v412 + 1) | 0;
        v410.l0 = (v419 | 0);
        v410.l1 = (v418 | 0);
    }
    const v420 = v410.l1 | 0;
    const v421 = fill(new Array(v420), 0, v420, null);
    const v422 = new Mut1(0);
    while (method1(v420, v422)) {
        const v424 = v422.l0 | 0;
        const v425 = v409[v424];
        v421[v424] = v425;
        const v426 = (v424 + 1) | 0;
        v422.l0 = (v426 | 0);
    }
    const v427 = v421.length | 0;
    const v428 = fill(new Array(v427), 0, v427, null);
    const v429 = new Mut1(0);
    while (method1(v427, v429)) {
        const v431 = v429.l0 | 0;
        const v432 = v421[v431];
        let v435;
        if (v432.tag === 1) {
            v435 = v432.fields[0];
        }
        else {
            throw new Error("Option does not have a value.");
        }
        v428[v431] = v435;
        const v436 = (v431 + 1) | 0;
        v429.l0 = (v436 | 0);
    }
    const v437 = createObj(v428);
    const v438 = createComponent;
    const v441 = v438(IconButton, v437);
    const v445 = v3_1() ? "Restore" : "Maximize";
    const v495 = new Heap0(new US0(0), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), new US3(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US2(0), new US4(0), new US0(0), new US0(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(1, v41), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0));
    let v496;
    v496 = (v3_1() ? ((v448 = BiRegularDownArrow, v448)) : ((v450 = BiRegularUpArrow, v450)));
    const v497 = createComponent;
    const v526 = (): void => {
        closure30(v2_1, v3_1, void 0);
    };
    const v543 = new Heap0(new US0(1, v445), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), new US3(0), new US0(0), new US0(1, v66), new US2(0), new US0(0), new US0(0), new US2(0), new US4(0), new US0(0), new US0(0), new US0(1, v75), new US0(0), new US5(1, v497(v496, v495)), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(1, v526), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(1, v95), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0));
    const v544 = v543.l0;
    const v551 = v543.l1;
    const v558 = v543.l2;
    const v565 = v543.l3;
    const v572 = v543.l4;
    const v579 = v543.l7;
    const v586 = v543.l5;
    const v593 = v543.l6;
    const v600 = v543.l8;
    const v607 = v543.l9;
    const v614 = v543.l11;
    const v621 = v543.l10;
    const v628 = v543.l12;
    const v635 = v543.l13;
    const v642 = v543.l14;
    const v649 = v543.l15;
    const v656 = v543.l16;
    const v663 = v543.l17;
    const v670 = v543.l18;
    const v677 = v543.l19;
    const v684 = v543.l20;
    const v691 = v543.l21;
    const v698 = v543.l22;
    const v705 = v543.l23;
    const v712 = v543.l24;
    const v719 = v543.l25;
    const v726 = v543.l26;
    const v733 = v543.l27;
    const v740 = v543.l28;
    const v747 = v543.l29;
    const v754 = v543.l30;
    const v761 = v543.l31;
    const v768 = v543.l32;
    const v775 = v543.l33;
    const v782 = v543.l34;
    const v789 = v543.l35;
    const v796 = v543.l36;
    const v803 = v543.l37;
    const v810 = v543.l38;
    const v817 = v543.l39;
    const v824 = v543.l40;
    const v831 = v543.l41;
    const v838 = v543.l42;
    const v845 = [(v544.tag === 1) ? (new US8(1, ["aria-label", v544.fields[0]])) : (new US8(0)), (v551.tag === 1) ? (new US8(1, ["as", v551.fields[0]])) : (new US8(0)), (v558.tag === 1) ? (new US8(1, ["backgroundColor", v558.fields[0]])) : (new US8(0)), (v565.tag === 1) ? (new US8(1, ["border", v565.fields[0]])) : (new US8(0)), (v572.tag === 1) ? (new US8(1, ["bottom", v572.fields[0]])) : (new US8(0)), (v579.tag === 1) ? (new US8(1, ["color", v579.fields[0]])) : (new US8(0)), (v586.tag === 1) ? (new US8(1, ["checked", v586.fields[0]])) : (new US8(0)), (v593.tag === 1) ? (new US8(1, ["children", v593.fields[0]])) : (new US8(0)), (v600.tag === 1) ? (new US8(1, ["colorScheme", v600.fields[0]])) : (new US8(0)), (v607.tag === 1) ? (new US8(1, ["compact", v607.fields[0]])) : (new US8(0)), (v614.tag === 1) ? (new US8(1, ["display", v614.fields[0]])) : (new US8(0)), (v621.tag === 1) ? (new US8(1, ["direction", v621.fields[0]])) : (new US8(0)), (v628.tag === 1) ? (new US8(1, ["external", v628.fields[0]])) : (new US8(0)), (v635.tag === 1) ? (new US8(1, ["flex", v635.fields[0]])) : (new US8(0)), (v642.tag === 1) ? (new US8(1, ["flexDirection", v642.fields[0]])) : (new US8(0)), (v649.tag === 1) ? (new US8(1, ["fontSize", v649.fields[0]])) : (new US8(0)), (v656.tag === 1) ? (new US8(1, ["height", v656.fields[0]])) : (new US8(0)), (v663.tag === 1) ? (new US8(1, ["href", v663.fields[0]])) : (new US8(0)), (v670.tag === 1) ? (new US8(1, ["icon", v670.fields[0]])) : (new US8(0)), (v677.tag === 1) ? (new US8(1, ["id", v677.fields[0]])) : (new US8(0)), (v684.tag === 1) ? (new US8(1, ["justifyContent", v684.fields[0]])) : (new US8(0)), (v691.tag === 1) ? (new US8(1, ["left", v691.fields[0]])) : (new US8(0)), (v698.tag === 1) ? (new US8(1, ["lineHeight", v698.fields[0]])) : (new US8(0)), (v705.tag === 1) ? (new US8(1, ["margin", v705.fields[0]])) : (new US8(0)), (v712.tag === 1) ? (new US8(1, ["marginBottom", v712.fields[0]])) : (new US8(0)), (v719.tag === 1) ? (new US8(1, ["maxHeight", v719.fields[0]])) : (new US8(0)), (v726.tag === 1) ? (new US8(1, ["onChange", v726.fields[0]])) : (new US8(0)), (v733.tag === 1) ? (new US8(1, ["onClick", v733.fields[0]])) : (new US8(0)), (v740.tag === 1) ? (new US8(1, ["outline", v740.fields[0]])) : (new US8(0)), (v747.tag === 1) ? (new US8(1, ["overflowY", v747.fields[0]])) : (new US8(0)), (v754.tag === 1) ? (new US8(1, ["padding", v754.fields[0]])) : (new US8(0)), (v761.tag === 1) ? (new US8(1, ["paddingTop", v761.fields[0]])) : (new US8(0)), (v768.tag === 1) ? (new US8(1, ["position", v768.fields[0]])) : (new US8(0)), (v775.tag === 1) ? (new US8(1, ["right", v775.fields[0]])) : (new US8(0)), (v782.tag === 1) ? (new US8(1, ["size", v782.fields[0]])) : (new US8(0)), (v789.tag === 1) ? (new US8(1, ["spacing", v789.fields[0]])) : (new US8(0)), (v796.tag === 1) ? (new US8(1, ["status", v796.fields[0]])) : (new US8(0)), (v803.tag === 1) ? (new US8(1, ["striped", v803.fields[0]])) : (new US8(0)), (v810.tag === 1) ? (new US8(1, ["thickness", v810.fields[0]])) : (new US8(0)), (v817.tag === 1) ? (new US8(1, ["title", v817.fields[0]])) : (new US8(0)), (v824.tag === 1) ? (new US8(1, ["top", v824.fields[0]])) : (new US8(0)), (v831.tag === 1) ? (new US8(1, ["width", v831.fields[0]])) : (new US8(0)), (v838.tag === 1) ? (new US8(1, ["zIndex", v838.fields[0]])) : (new US8(0))];
    const v846 = v845.length | 0;
    const v847 = fill(new Array(v846), 0, v846, null);
    const v848 = new Mut0(0, 0);
    while (method0(v846, v848)) {
        const v850 = v848.l0 | 0;
        const v851 = v848.l1 | 0;
        const v852 = v845[v850];
        let v856;
        if (v852.tag === 1) {
            v847[v851] = v852;
            v856 = (v851 + 1);
        }
        else {
            v856 = v851;
        }
        const v857 = (v850 + 1) | 0;
        v848.l0 = (v857 | 0);
        v848.l1 = (v856 | 0);
    }
    const v858 = v848.l1 | 0;
    const v859 = fill(new Array(v858), 0, v858, null);
    const v860 = new Mut1(0);
    while (method1(v858, v860)) {
        const v862 = v860.l0 | 0;
        const v863 = v847[v862];
        v859[v862] = v863;
        const v864 = (v862 + 1) | 0;
        v860.l0 = (v864 | 0);
    }
    const v865 = v859.length | 0;
    const v866 = fill(new Array(v865), 0, v865, null);
    const v867 = new Mut1(0);
    while (method1(v865, v867)) {
        const v869 = v867.l0 | 0;
        const v870 = v859[v869];
        let v873;
        if (v870.tag === 1) {
            v873 = v870.fields[0];
        }
        else {
            throw new Error("Option does not have a value.");
        }
        v866[v869] = v873;
        const v874 = (v869 + 1) | 0;
        v867.l0 = (v874 | 0);
    }
    const v875 = createObj(v866);
    const v876 = createComponent;
    const v877 = v876(IconButton, v875);
    const v879 = BiRegularUndo;
    const v923 = new Heap0(new US0(0), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), new US3(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US2(0), new US4(0), new US0(0), new US0(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(1, v41), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0));
    const v925 = createComponent;
    const v955 = (): void => {
        closure31(v0_1, void 0);
    };
    const v972 = new Heap0(new US0(1, "Unload"), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), new US3(0), new US0(0), new US0(1, v66), new US2(0), new US0(0), new US0(0), new US2(0), new US4(0), new US0(0), new US0(0), new US0(1, v75), new US0(0), new US5(1, v925(v879, v923)), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(1, v955), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(1, v95), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0));
    const v973 = v972.l0;
    const v980 = v972.l1;
    const v987 = v972.l2;
    const v994 = v972.l3;
    const v1001 = v972.l4;
    const v1008 = v972.l7;
    const v1015 = v972.l5;
    const v1022 = v972.l6;
    const v1029 = v972.l8;
    const v1036 = v972.l9;
    const v1043 = v972.l11;
    const v1050 = v972.l10;
    const v1057 = v972.l12;
    const v1064 = v972.l13;
    const v1071 = v972.l14;
    const v1078 = v972.l15;
    const v1085 = v972.l16;
    const v1092 = v972.l17;
    const v1099 = v972.l18;
    const v1106 = v972.l19;
    const v1113 = v972.l20;
    const v1120 = v972.l21;
    const v1127 = v972.l22;
    const v1134 = v972.l23;
    const v1141 = v972.l24;
    const v1148 = v972.l25;
    const v1155 = v972.l26;
    const v1162 = v972.l27;
    const v1169 = v972.l28;
    const v1176 = v972.l29;
    const v1183 = v972.l30;
    const v1190 = v972.l31;
    const v1197 = v972.l32;
    const v1204 = v972.l33;
    const v1211 = v972.l34;
    const v1218 = v972.l35;
    const v1225 = v972.l36;
    const v1232 = v972.l37;
    const v1239 = v972.l38;
    const v1246 = v972.l39;
    const v1253 = v972.l40;
    const v1260 = v972.l41;
    const v1267 = v972.l42;
    const v1274 = [(v973.tag === 1) ? (new US8(1, ["aria-label", v973.fields[0]])) : (new US8(0)), (v980.tag === 1) ? (new US8(1, ["as", v980.fields[0]])) : (new US8(0)), (v987.tag === 1) ? (new US8(1, ["backgroundColor", v987.fields[0]])) : (new US8(0)), (v994.tag === 1) ? (new US8(1, ["border", v994.fields[0]])) : (new US8(0)), (v1001.tag === 1) ? (new US8(1, ["bottom", v1001.fields[0]])) : (new US8(0)), (v1008.tag === 1) ? (new US8(1, ["color", v1008.fields[0]])) : (new US8(0)), (v1015.tag === 1) ? (new US8(1, ["checked", v1015.fields[0]])) : (new US8(0)), (v1022.tag === 1) ? (new US8(1, ["children", v1022.fields[0]])) : (new US8(0)), (v1029.tag === 1) ? (new US8(1, ["colorScheme", v1029.fields[0]])) : (new US8(0)), (v1036.tag === 1) ? (new US8(1, ["compact", v1036.fields[0]])) : (new US8(0)), (v1043.tag === 1) ? (new US8(1, ["display", v1043.fields[0]])) : (new US8(0)), (v1050.tag === 1) ? (new US8(1, ["direction", v1050.fields[0]])) : (new US8(0)), (v1057.tag === 1) ? (new US8(1, ["external", v1057.fields[0]])) : (new US8(0)), (v1064.tag === 1) ? (new US8(1, ["flex", v1064.fields[0]])) : (new US8(0)), (v1071.tag === 1) ? (new US8(1, ["flexDirection", v1071.fields[0]])) : (new US8(0)), (v1078.tag === 1) ? (new US8(1, ["fontSize", v1078.fields[0]])) : (new US8(0)), (v1085.tag === 1) ? (new US8(1, ["height", v1085.fields[0]])) : (new US8(0)), (v1092.tag === 1) ? (new US8(1, ["href", v1092.fields[0]])) : (new US8(0)), (v1099.tag === 1) ? (new US8(1, ["icon", v1099.fields[0]])) : (new US8(0)), (v1106.tag === 1) ? (new US8(1, ["id", v1106.fields[0]])) : (new US8(0)), (v1113.tag === 1) ? (new US8(1, ["justifyContent", v1113.fields[0]])) : (new US8(0)), (v1120.tag === 1) ? (new US8(1, ["left", v1120.fields[0]])) : (new US8(0)), (v1127.tag === 1) ? (new US8(1, ["lineHeight", v1127.fields[0]])) : (new US8(0)), (v1134.tag === 1) ? (new US8(1, ["margin", v1134.fields[0]])) : (new US8(0)), (v1141.tag === 1) ? (new US8(1, ["marginBottom", v1141.fields[0]])) : (new US8(0)), (v1148.tag === 1) ? (new US8(1, ["maxHeight", v1148.fields[0]])) : (new US8(0)), (v1155.tag === 1) ? (new US8(1, ["onChange", v1155.fields[0]])) : (new US8(0)), (v1162.tag === 1) ? (new US8(1, ["onClick", v1162.fields[0]])) : (new US8(0)), (v1169.tag === 1) ? (new US8(1, ["outline", v1169.fields[0]])) : (new US8(0)), (v1176.tag === 1) ? (new US8(1, ["overflowY", v1176.fields[0]])) : (new US8(0)), (v1183.tag === 1) ? (new US8(1, ["padding", v1183.fields[0]])) : (new US8(0)), (v1190.tag === 1) ? (new US8(1, ["paddingTop", v1190.fields[0]])) : (new US8(0)), (v1197.tag === 1) ? (new US8(1, ["position", v1197.fields[0]])) : (new US8(0)), (v1204.tag === 1) ? (new US8(1, ["right", v1204.fields[0]])) : (new US8(0)), (v1211.tag === 1) ? (new US8(1, ["size", v1211.fields[0]])) : (new US8(0)), (v1218.tag === 1) ? (new US8(1, ["spacing", v1218.fields[0]])) : (new US8(0)), (v1225.tag === 1) ? (new US8(1, ["status", v1225.fields[0]])) : (new US8(0)), (v1232.tag === 1) ? (new US8(1, ["striped", v1232.fields[0]])) : (new US8(0)), (v1239.tag === 1) ? (new US8(1, ["thickness", v1239.fields[0]])) : (new US8(0)), (v1246.tag === 1) ? (new US8(1, ["title", v1246.fields[0]])) : (new US8(0)), (v1253.tag === 1) ? (new US8(1, ["top", v1253.fields[0]])) : (new US8(0)), (v1260.tag === 1) ? (new US8(1, ["width", v1260.fields[0]])) : (new US8(0)), (v1267.tag === 1) ? (new US8(1, ["zIndex", v1267.fields[0]])) : (new US8(0))];
    const v1275 = v1274.length | 0;
    const v1276 = fill(new Array(v1275), 0, v1275, null);
    const v1277 = new Mut0(0, 0);
    while (method0(v1275, v1277)) {
        const v1279 = v1277.l0 | 0;
        const v1280 = v1277.l1 | 0;
        const v1281 = v1274[v1279];
        let v1285;
        if (v1281.tag === 1) {
            v1276[v1280] = v1281;
            v1285 = (v1280 + 1);
        }
        else {
            v1285 = v1280;
        }
        const v1286 = (v1279 + 1) | 0;
        v1277.l0 = (v1286 | 0);
        v1277.l1 = (v1285 | 0);
    }
    const v1287 = v1277.l1 | 0;
    const v1288 = fill(new Array(v1287), 0, v1287, null);
    const v1289 = new Mut1(0);
    while (method1(v1287, v1289)) {
        const v1291 = v1289.l0 | 0;
        const v1292 = v1276[v1291];
        v1288[v1291] = v1292;
        const v1293 = (v1291 + 1) | 0;
        v1289.l0 = (v1293 | 0);
    }
    const v1294 = v1288.length | 0;
    const v1295 = fill(new Array(v1294), 0, v1294, null);
    const v1296 = new Mut1(0);
    while (method1(v1294, v1296)) {
        const v1298 = v1296.l0 | 0;
        const v1299 = v1288[v1298];
        let v1302;
        if (v1299.tag === 1) {
            v1302 = v1299.fields[0];
        }
        else {
            throw new Error("Option does not have a value.");
        }
        v1295[v1298] = v1302;
        const v1303 = (v1298 + 1) | 0;
        v1296.l0 = (v1303 | 0);
    }
    const v1304 = createObj(v1295);
    const v1305 = createComponent;
    return [v441, v877, v1305(IconButton, v1304)];
}

export function closure32(unitVar: void, v0_1: Heap0): any {
    const v1_1 = v0_1.l0;
    const v8_1 = v0_1.l1;
    const v15_1 = v0_1.l2;
    const v22 = v0_1.l3;
    const v29 = v0_1.l4;
    const v36 = v0_1.l7;
    const v43 = v0_1.l5;
    const v50 = v0_1.l6;
    const v57 = v0_1.l8;
    const v64 = v0_1.l9;
    const v71 = v0_1.l11;
    const v78 = v0_1.l10;
    const v85 = v0_1.l12;
    const v92 = v0_1.l13;
    const v99 = v0_1.l14;
    const v106 = v0_1.l15;
    const v113 = v0_1.l16;
    const v120 = v0_1.l17;
    const v127 = v0_1.l18;
    const v134 = v0_1.l19;
    const v141 = v0_1.l20;
    const v148 = v0_1.l21;
    const v155 = v0_1.l22;
    const v162 = v0_1.l23;
    const v169 = v0_1.l24;
    const v176 = v0_1.l25;
    const v183 = v0_1.l26;
    const v190 = v0_1.l27;
    const v197 = v0_1.l28;
    const v204 = v0_1.l29;
    const v211 = v0_1.l30;
    const v218 = v0_1.l31;
    const v225 = v0_1.l32;
    const v232 = v0_1.l33;
    const v239 = v0_1.l34;
    const v246 = v0_1.l35;
    const v253 = v0_1.l36;
    const v260 = v0_1.l37;
    const v267 = v0_1.l38;
    const v274 = v0_1.l39;
    const v281 = v0_1.l40;
    const v288 = v0_1.l41;
    const v295 = v0_1.l42;
    const v302 = [(v1_1.tag === 1) ? (new US8(1, ["aria-label", v1_1.fields[0]])) : (new US8(0)), (v8_1.tag === 1) ? (new US8(1, ["as", v8_1.fields[0]])) : (new US8(0)), (v15_1.tag === 1) ? (new US8(1, ["backgroundColor", v15_1.fields[0]])) : (new US8(0)), (v22.tag === 1) ? (new US8(1, ["border", v22.fields[0]])) : (new US8(0)), (v29.tag === 1) ? (new US8(1, ["bottom", v29.fields[0]])) : (new US8(0)), (v36.tag === 1) ? (new US8(1, ["color", v36.fields[0]])) : (new US8(0)), (v43.tag === 1) ? (new US8(1, ["checked", v43.fields[0]])) : (new US8(0)), (v50.tag === 1) ? (new US8(1, ["children", v50.fields[0]])) : (new US8(0)), (v57.tag === 1) ? (new US8(1, ["colorScheme", v57.fields[0]])) : (new US8(0)), (v64.tag === 1) ? (new US8(1, ["compact", v64.fields[0]])) : (new US8(0)), (v71.tag === 1) ? (new US8(1, ["display", v71.fields[0]])) : (new US8(0)), (v78.tag === 1) ? (new US8(1, ["direction", v78.fields[0]])) : (new US8(0)), (v85.tag === 1) ? (new US8(1, ["external", v85.fields[0]])) : (new US8(0)), (v92.tag === 1) ? (new US8(1, ["flex", v92.fields[0]])) : (new US8(0)), (v99.tag === 1) ? (new US8(1, ["flexDirection", v99.fields[0]])) : (new US8(0)), (v106.tag === 1) ? (new US8(1, ["fontSize", v106.fields[0]])) : (new US8(0)), (v113.tag === 1) ? (new US8(1, ["height", v113.fields[0]])) : (new US8(0)), (v120.tag === 1) ? (new US8(1, ["href", v120.fields[0]])) : (new US8(0)), (v127.tag === 1) ? (new US8(1, ["icon", v127.fields[0]])) : (new US8(0)), (v134.tag === 1) ? (new US8(1, ["id", v134.fields[0]])) : (new US8(0)), (v141.tag === 1) ? (new US8(1, ["justifyContent", v141.fields[0]])) : (new US8(0)), (v148.tag === 1) ? (new US8(1, ["left", v148.fields[0]])) : (new US8(0)), (v155.tag === 1) ? (new US8(1, ["lineHeight", v155.fields[0]])) : (new US8(0)), (v162.tag === 1) ? (new US8(1, ["margin", v162.fields[0]])) : (new US8(0)), (v169.tag === 1) ? (new US8(1, ["marginBottom", v169.fields[0]])) : (new US8(0)), (v176.tag === 1) ? (new US8(1, ["maxHeight", v176.fields[0]])) : (new US8(0)), (v183.tag === 1) ? (new US8(1, ["onChange", v183.fields[0]])) : (new US8(0)), (v190.tag === 1) ? (new US8(1, ["onClick", v190.fields[0]])) : (new US8(0)), (v197.tag === 1) ? (new US8(1, ["outline", v197.fields[0]])) : (new US8(0)), (v204.tag === 1) ? (new US8(1, ["overflowY", v204.fields[0]])) : (new US8(0)), (v211.tag === 1) ? (new US8(1, ["padding", v211.fields[0]])) : (new US8(0)), (v218.tag === 1) ? (new US8(1, ["paddingTop", v218.fields[0]])) : (new US8(0)), (v225.tag === 1) ? (new US8(1, ["position", v225.fields[0]])) : (new US8(0)), (v232.tag === 1) ? (new US8(1, ["right", v232.fields[0]])) : (new US8(0)), (v239.tag === 1) ? (new US8(1, ["size", v239.fields[0]])) : (new US8(0)), (v246.tag === 1) ? (new US8(1, ["spacing", v246.fields[0]])) : (new US8(0)), (v253.tag === 1) ? (new US8(1, ["status", v253.fields[0]])) : (new US8(0)), (v260.tag === 1) ? (new US8(1, ["striped", v260.fields[0]])) : (new US8(0)), (v267.tag === 1) ? (new US8(1, ["thickness", v267.fields[0]])) : (new US8(0)), (v274.tag === 1) ? (new US8(1, ["title", v274.fields[0]])) : (new US8(0)), (v281.tag === 1) ? (new US8(1, ["top", v281.fields[0]])) : (new US8(0)), (v288.tag === 1) ? (new US8(1, ["width", v288.fields[0]])) : (new US8(0)), (v295.tag === 1) ? (new US8(1, ["zIndex", v295.fields[0]])) : (new US8(0))];
    const v303 = v302.length | 0;
    const v304 = fill(new Array(v303), 0, v303, null);
    const v305 = new Mut0(0, 0);
    while (method0(v303, v305)) {
        const v307 = v305.l0 | 0;
        const v308 = v305.l1 | 0;
        const v309 = v302[v307];
        let v313;
        if (v309.tag === 1) {
            v304[v308] = v309;
            v313 = (v308 + 1);
        }
        else {
            v313 = v308;
        }
        const v314 = (v307 + 1) | 0;
        v305.l0 = (v314 | 0);
        v305.l1 = (v313 | 0);
    }
    const v315 = v305.l1 | 0;
    const v316 = fill(new Array(v315), 0, v315, null);
    const v317 = new Mut1(0);
    while (method1(v315, v317)) {
        const v319 = v317.l0 | 0;
        const v320 = v304[v319];
        v316[v319] = v320;
        const v321 = (v319 + 1) | 0;
        v317.l0 = (v321 | 0);
    }
    const v322 = v316.length | 0;
    const v323 = fill(new Array(v322), 0, v322, null);
    const v324 = new Mut1(0);
    while (method1(v322, v324)) {
        const v326 = v324.l0 | 0;
        const v327 = v316[v326];
        let v330;
        if (v327.tag === 1) {
            v330 = v327.fields[0];
        }
        else {
            throw new Error("Option does not have a value.");
        }
        v323[v326] = v330;
        const v331 = (v326 + 1) | 0;
        v324.l0 = (v331 | 0);
    }
    const v332 = createObj(v323);
    const v335 = createComponent;
    return v335(Stack, v332);
}

export function closure27(v0_1: int32, v1_1: (arg0: boolean) => void, v2_1: (arg0: boolean) => void, v3_1: (arg0: void) => boolean, v4_1: (arg0: boolean) => void, v5_1: (arg0: void) => boolean, v6_1: (arg0: void) => any, unitVar: void): any {
    const v16_1 = (): any => closure28(v1_1, v2_1, v4_1, v5_1, void 0);
    const v46 = "6px";
    const v58 = new Heap0(new US0(0), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), new US3(1, v16_1), new US0(0), new US0(0), new US2(0), new US0(1, "row"), new US0(0), new US2(0), new US4(0), new US0(0), new US0(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(1, "absolute"), new US0(1, v46), new US0(0), new US0(1, "3px"), new US2(0), new US0(0), new US0(0), new US5(0), new US0(1, v46), new US0(0), new US4(1, 1));
    const v59 = (v: Heap0): any => closure32(void 0, v);
    const v63 = createComponent;
    return [v63(v59, v58), (v3_1() === false) ? v6_1() : <></>];
}

export function closure26(v0_1: Heap0, v1_1: int32, v2_1: (arg0: boolean) => void, v3_1: (arg0: boolean) => void, v4_1: (arg0: void) => boolean, v5_1: (arg0: boolean) => void, v6_1: (arg0: void) => boolean, unitVar: void): any {
    let v16_1: (arg0: void) => any, v55: Heap0, v56: (arg0: Heap0) => any, v60: any;
    const v7_1 = v0_1.l6;
    return [(v7_1.tag === 1) ? ((v16_1 = ((): any => closure27(v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7_1.fields[0], void 0)), (v55 = (new Heap0(new US0(0), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), new US3(1, v16_1), new US0(0), new US0(0), new US2(0), new US0(0), new US0(1, "flex"), new US2(0), new US4(1, 1), new US0(0), new US0(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0))), (v56 = ((v: Heap0): any => closure25(void 0, v)), (v60 = createComponent, v60(v56, v55)))))) : <></>];
}

export function closure21(v0_1: Heap0, v1_1: int32, v2_1: (arg0: boolean) => void, v3_1: (arg0: void) => boolean, v4_1: (arg0: boolean) => void, v5_1: (arg0: void) => boolean, v6_1: (arg0: boolean) => void, v7_1: (arg0: void) => boolean, unitVar: void): any {
    let v16_1: (arg0: void) => any, v54: Heap0, v55: (arg0: Heap0) => any, v59: any, v64: US4, v69: US0, v74: US0, v79: US0, v84: US0, v89: US0, v99: (arg0: void) => any, v133: Heap0, v134: (arg0: Heap0) => any, v138: any;
    return [(v3_1() === false) ? ((v16_1 = ((): any => closure22(v2_1, void 0)), (v54 = (new Heap0(new US0(0), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), new US3(1, v16_1), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US2(0), new US4(0), new US0(0), new US0(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0))), (v55 = ((v: Heap0): any => closure25(void 0, v)), (v59 = createComponent, v59(v55, v54)))))) : ((v64 = (v7_1() ? (new US4(1, 1)) : (new US4(0))), (v69 = (v7_1() ? (new US0(1, "absolute")) : (new US0(0))), (v74 = (v7_1() ? (new US0(1, "0")) : (new US0(0))), (v79 = (v7_1() ? (new US0(1, "0")) : (new US0(0))), (v84 = (v7_1() ? (new US0(1, "0")) : (new US0(0))), (v89 = (v7_1() ? (new US0(1, "0")) : (new US0(0))), (v99 = ((): any => closure26(v0_1, v1_1, v2_1, v4_1, v5_1, v6_1, v7_1, void 0)), (v133 = (new Heap0(new US0(0), new US1(0), v7_1() ? (new US0(1, "$bg")) : (new US0(0)), new US0(0), v84, new US2(0), new US3(1, v99), new US0(0), new US0(0), new US2(0), new US0(0), new US0(1, "flex"), new US2(0), new US4(1, 1), new US0(0), new US0(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), v89, new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(0), new US0(0), v69, v79, new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), v74, new US0(0), v64)), (v134 = ((v_1: Heap0): any => closure25(void 0, v_1)), (v138 = createComponent, v138(v134, v133))))))))))))];
}

export function closure17(v0_1: Heap0, v1_1: (arg0: void) => boolean, v2_1: (arg0: void) => any, unitVar: void): any {
    let v13_1: (arg0: void) => any, v51: Heap0, v52: int32, v55: any, v56: Array<any>, v57: (arg0: void) => boolean, value_1: any, v58: (arg0: boolean) => void, value_2: any, v59: any, v60: Array<any>, v61: (arg0: void) => boolean, value_4: any, v62: (arg0: boolean) => void, value_5: any, v63: any, v64: Array<any>, v65: (arg0: void) => boolean, value_7: any, v66: (arg0: boolean) => void, value_8: any, v68: any, v69: (arg0: void) => Array<boolean>, v70: (arg0: void) => void, v71: any, v73: any, v81: (arg0: void) => any, v119: Heap0, v120: (arg0: Heap0) => any, v123: any;
    return [(v0_1.l36.tag === 1) ? (v1_1() ? ((v13_1 = ((): any => closure18(v2_1, void 0)), (v51 = (new Heap0(new US0(0), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), new US3(1, v13_1), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US2(0), new US4(0), new US0(0), new US0(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0))), (v52 = (nonSeeded().Next0() | 0), (v55 = createSignal, (v56 = (v55(true)), (v57 = ((value_1 = v56[0], value_1)), (v58 = ((value_2 = v56[1], (arg_1: boolean): void => {
        value_2(arg_1);
    })), (v59 = createSignal, (v60 = (v59(false)), (v61 = ((value_4 = v60[0], value_4)), (v62 = ((value_5 = v60[1], (arg_3: boolean): void => {
        value_5(arg_3);
    })), (v63 = createSignal, (v64 = (v63(false)), (v65 = ((value_7 = v64[0], value_7)), (v66 = ((value_8 = v64[1], (arg_5: boolean): void => {
        value_8(arg_5);
    })), (v68 = on, (v69 = ((): Array<boolean> => closure19(v61, void 0)), (v70 = ((): void => {
        closure20(v62, v61, void 0);
    }), (v71 = (v68(v69, v70)), (v73 = createEffect, (void (v73(v71)), (v81 = ((): any => closure21(v51, v52, v58, v57, v62, v61, v66, v65, void 0)), (v119 = (new Heap0(new US0(0), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), new US3(1, v81), new US0(0), new US0(0), new US2(0), new US0(0), new US0(1, "flex"), new US2(0), new US4(1, 1), new US0(0), new US0(0), new US0(0), new US0(0), new US5(0), v51.l19, new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0))), (v120 = ((v: Heap0): any => closure25(void 0, v)), (v123 = createComponent, v123(v120, v119))))))))))))))))))))))))))) : <></>) : v2_1()];
}

export function closure10(v0_1: Heap0, v1_1: (arg0: boolean) => void, v2_1: (arg0: void) => boolean, unitVar: void): any {
    let v13_1: (arg0: void) => any, v57: Heap0, v58: (arg0: Heap0) => any, v62: any, v120: US0, v131: (arg0: void) => any, v152: string, v175: Heap0, v176: (arg0: Heap0) => any, v180: any, v72: (arg0: void) => any, v112: Heap0, v113: (arg0: Heap0) => any, v117: any;
    const v3_1 = v0_1.l39;
    const v65 = v0_1.l6;
    return [(v3_1.tag === 1) ? ((v13_1 = ((): any => closure11(v0_1, v1_1, v2_1, v3_1.fields[0], void 0)), (v57 = (new Heap0(new US0(0), new US1(0), new US0(0), new US0(1, "0 !important"), new US0(0), new US2(0), new US3(1, v13_1), new US0(1, "$neutral9"), new US0(0), new US2(0), new US0(0), new US0(1, "flex"), new US2(0), new US4(0), new US0(1, "column"), new US0(1, "$sm"), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(1, "1px solid $neutral5"), new US0(0), new US0(1, "3px 20px 0 8px"), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0))), (v58 = ((v: Heap0): any => closure15(void 0, v)), (v62 = createComponent, v62(v58, v57)))))) : <></>, (v65.tag === 1) ? ((v120 = v0_1.l30, (v131 = ((): any => closure17(v0_1, v2_1, v65.fields[0], void 0)), (v152 = "0", (v175 = (new Heap0(new US0(0), new US1(0), new US0(0), new US0(1, "0 !important"), new US0(0), new US2(0), new US3(1, v131), new US0(0), new US0(0), new US2(0), new US0(0), new US0(1, "flex"), new US2(0), new US4(1, 6), new US0(1, "column"), new US0(1, "$sm"), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(1, v152), new US0(0), new US0(1, "85vh"), new US6(0), new US7(0), new US0(1, v152), new US0(1, "auto"), new US0(1, (v120.tag === 1) ? v120.fields[0] : "0"), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0))), (v176 = ((v_2: Heap0): any => closure15(void 0, v_2)), (v180 = createComponent, v180(v176, v175)))))))) : ((v72 = ((): any => closure16(void 0, void 0)), (v112 = (new Heap0(new US0(0), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), new US3(1, v72), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US2(0), new US4(0), new US0(0), new US0(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US0(0), new US0(1, "9px"), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(1, "0"), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0))), (v113 = ((v_1: Heap0): any => closure15(void 0, v_1)), (v117 = createComponent, v117(v113, v112))))))];
}

export function closure33(unitVar: void, v0_1: Heap0): any {
    const v1_1 = v0_1.l0;
    const v8_1 = v0_1.l1;
    const v15_1 = v0_1.l2;
    const v22 = v0_1.l3;
    const v29 = v0_1.l4;
    const v36 = v0_1.l7;
    const v43 = v0_1.l5;
    const v50 = v0_1.l6;
    const v57 = v0_1.l8;
    const v64 = v0_1.l9;
    const v71 = v0_1.l11;
    const v78 = v0_1.l10;
    const v85 = v0_1.l12;
    const v92 = v0_1.l13;
    const v99 = v0_1.l14;
    const v106 = v0_1.l15;
    const v113 = v0_1.l16;
    const v120 = v0_1.l17;
    const v127 = v0_1.l18;
    const v134 = v0_1.l19;
    const v141 = v0_1.l20;
    const v148 = v0_1.l21;
    const v155 = v0_1.l22;
    const v162 = v0_1.l23;
    const v169 = v0_1.l24;
    const v176 = v0_1.l25;
    const v183 = v0_1.l26;
    const v190 = v0_1.l27;
    const v197 = v0_1.l28;
    const v204 = v0_1.l29;
    const v211 = v0_1.l30;
    const v218 = v0_1.l31;
    const v225 = v0_1.l32;
    const v232 = v0_1.l33;
    const v239 = v0_1.l34;
    const v246 = v0_1.l35;
    const v253 = v0_1.l36;
    const v260 = v0_1.l37;
    const v267 = v0_1.l38;
    const v274 = v0_1.l39;
    const v281 = v0_1.l40;
    const v288 = v0_1.l41;
    const v295 = v0_1.l42;
    const v302 = [(v1_1.tag === 1) ? (new US8(1, ["aria-label", v1_1.fields[0]])) : (new US8(0)), (v8_1.tag === 1) ? (new US8(1, ["as", v8_1.fields[0]])) : (new US8(0)), (v15_1.tag === 1) ? (new US8(1, ["backgroundColor", v15_1.fields[0]])) : (new US8(0)), (v22.tag === 1) ? (new US8(1, ["border", v22.fields[0]])) : (new US8(0)), (v29.tag === 1) ? (new US8(1, ["bottom", v29.fields[0]])) : (new US8(0)), (v36.tag === 1) ? (new US8(1, ["color", v36.fields[0]])) : (new US8(0)), (v43.tag === 1) ? (new US8(1, ["checked", v43.fields[0]])) : (new US8(0)), (v50.tag === 1) ? (new US8(1, ["children", v50.fields[0]])) : (new US8(0)), (v57.tag === 1) ? (new US8(1, ["colorScheme", v57.fields[0]])) : (new US8(0)), (v64.tag === 1) ? (new US8(1, ["compact", v64.fields[0]])) : (new US8(0)), (v71.tag === 1) ? (new US8(1, ["display", v71.fields[0]])) : (new US8(0)), (v78.tag === 1) ? (new US8(1, ["direction", v78.fields[0]])) : (new US8(0)), (v85.tag === 1) ? (new US8(1, ["external", v85.fields[0]])) : (new US8(0)), (v92.tag === 1) ? (new US8(1, ["flex", v92.fields[0]])) : (new US8(0)), (v99.tag === 1) ? (new US8(1, ["flexDirection", v99.fields[0]])) : (new US8(0)), (v106.tag === 1) ? (new US8(1, ["fontSize", v106.fields[0]])) : (new US8(0)), (v113.tag === 1) ? (new US8(1, ["height", v113.fields[0]])) : (new US8(0)), (v120.tag === 1) ? (new US8(1, ["href", v120.fields[0]])) : (new US8(0)), (v127.tag === 1) ? (new US8(1, ["icon", v127.fields[0]])) : (new US8(0)), (v134.tag === 1) ? (new US8(1, ["id", v134.fields[0]])) : (new US8(0)), (v141.tag === 1) ? (new US8(1, ["justifyContent", v141.fields[0]])) : (new US8(0)), (v148.tag === 1) ? (new US8(1, ["left", v148.fields[0]])) : (new US8(0)), (v155.tag === 1) ? (new US8(1, ["lineHeight", v155.fields[0]])) : (new US8(0)), (v162.tag === 1) ? (new US8(1, ["margin", v162.fields[0]])) : (new US8(0)), (v169.tag === 1) ? (new US8(1, ["marginBottom", v169.fields[0]])) : (new US8(0)), (v176.tag === 1) ? (new US8(1, ["maxHeight", v176.fields[0]])) : (new US8(0)), (v183.tag === 1) ? (new US8(1, ["onChange", v183.fields[0]])) : (new US8(0)), (v190.tag === 1) ? (new US8(1, ["onClick", v190.fields[0]])) : (new US8(0)), (v197.tag === 1) ? (new US8(1, ["outline", v197.fields[0]])) : (new US8(0)), (v204.tag === 1) ? (new US8(1, ["overflowY", v204.fields[0]])) : (new US8(0)), (v211.tag === 1) ? (new US8(1, ["padding", v211.fields[0]])) : (new US8(0)), (v218.tag === 1) ? (new US8(1, ["paddingTop", v218.fields[0]])) : (new US8(0)), (v225.tag === 1) ? (new US8(1, ["position", v225.fields[0]])) : (new US8(0)), (v232.tag === 1) ? (new US8(1, ["right", v232.fields[0]])) : (new US8(0)), (v239.tag === 1) ? (new US8(1, ["size", v239.fields[0]])) : (new US8(0)), (v246.tag === 1) ? (new US8(1, ["spacing", v246.fields[0]])) : (new US8(0)), (v253.tag === 1) ? (new US8(1, ["status", v253.fields[0]])) : (new US8(0)), (v260.tag === 1) ? (new US8(1, ["striped", v260.fields[0]])) : (new US8(0)), (v267.tag === 1) ? (new US8(1, ["thickness", v267.fields[0]])) : (new US8(0)), (v274.tag === 1) ? (new US8(1, ["title", v274.fields[0]])) : (new US8(0)), (v281.tag === 1) ? (new US8(1, ["top", v281.fields[0]])) : (new US8(0)), (v288.tag === 1) ? (new US8(1, ["width", v288.fields[0]])) : (new US8(0)), (v295.tag === 1) ? (new US8(1, ["zIndex", v295.fields[0]])) : (new US8(0))];
    const v303 = v302.length | 0;
    const v304 = fill(new Array(v303), 0, v303, null);
    const v305 = new Mut0(0, 0);
    while (method0(v303, v305)) {
        const v307 = v305.l0 | 0;
        const v308 = v305.l1 | 0;
        const v309 = v302[v307];
        let v313;
        if (v309.tag === 1) {
            v304[v308] = v309;
            v313 = (v308 + 1);
        }
        else {
            v313 = v308;
        }
        const v314 = (v307 + 1) | 0;
        v305.l0 = (v314 | 0);
        v305.l1 = (v313 | 0);
    }
    const v315 = v305.l1 | 0;
    const v316 = fill(new Array(v315), 0, v315, null);
    const v317 = new Mut1(0);
    while (method1(v315, v317)) {
        const v319 = v317.l0 | 0;
        const v320 = v304[v319];
        v316[v319] = v320;
        const v321 = (v319 + 1) | 0;
        v317.l0 = (v321 | 0);
    }
    const v322 = v316.length | 0;
    const v323 = fill(new Array(v322), 0, v322, null);
    const v324 = new Mut1(0);
    while (method1(v322, v324)) {
        const v326 = v324.l0 | 0;
        const v327 = v316[v326];
        let v330;
        if (v327.tag === 1) {
            v330 = v327.fields[0];
        }
        else {
            throw new Error("Option does not have a value.");
        }
        v323[v326] = v330;
        const v331 = (v326 + 1) | 0;
        v324.l0 = (v331 | 0);
    }
    const v332 = createObj(v323);
    const v335 = createComponent;
    return v335(Tr, v332);
}

export function closure34(unitVar: void, unitVar_1: void): any {
    const v44 = new Heap0(new US0(0), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), new US3(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US2(0), new US4(0), new US0(0), new US0(0), new US0(0), new US0(1, "https://fc1943s.github.io/tictactoe_spiral"), new US5(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0));
    const v52 = (): any => closure6(v44, void 0);
    const v89 = new Heap0(new US0(0), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), new US3(1, v52), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US2(1, true), new US4(0), new US0(0), new US0(0), new US0(0), v44.l17, new US5(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0));
    const v90 = v89.l0;
    const v97 = v89.l1;
    const v104 = v89.l2;
    const v111 = v89.l3;
    const v118 = v89.l4;
    const v125 = v89.l7;
    const v132 = v89.l5;
    const v139 = v89.l6;
    const v146 = v89.l8;
    const v153 = v89.l9;
    const v160 = v89.l11;
    const v167 = v89.l10;
    const v174 = v89.l12;
    const v181 = v89.l13;
    const v188 = v89.l14;
    const v195 = v89.l15;
    const v202 = v89.l16;
    const v209 = v89.l17;
    const v216 = v89.l18;
    const v223 = v89.l19;
    const v230 = v89.l20;
    const v237 = v89.l21;
    const v244 = v89.l22;
    const v251 = v89.l23;
    const v258 = v89.l24;
    const v265 = v89.l25;
    const v272 = v89.l26;
    const v279 = v89.l27;
    const v286 = v89.l28;
    const v293 = v89.l29;
    const v300 = v89.l30;
    const v307 = v89.l31;
    const v314 = v89.l32;
    const v321 = v89.l33;
    const v328 = v89.l34;
    const v335 = v89.l35;
    const v342 = v89.l36;
    const v349 = v89.l37;
    const v356 = v89.l38;
    const v363 = v89.l39;
    const v370 = v89.l40;
    const v377 = v89.l41;
    const v384 = v89.l42;
    const v391 = [(v90.tag === 1) ? (new US8(1, ["aria-label", v90.fields[0]])) : (new US8(0)), (v97.tag === 1) ? (new US8(1, ["as", v97.fields[0]])) : (new US8(0)), (v104.tag === 1) ? (new US8(1, ["backgroundColor", v104.fields[0]])) : (new US8(0)), (v111.tag === 1) ? (new US8(1, ["border", v111.fields[0]])) : (new US8(0)), (v118.tag === 1) ? (new US8(1, ["bottom", v118.fields[0]])) : (new US8(0)), (v125.tag === 1) ? (new US8(1, ["color", v125.fields[0]])) : (new US8(0)), (v132.tag === 1) ? (new US8(1, ["checked", v132.fields[0]])) : (new US8(0)), (v139.tag === 1) ? (new US8(1, ["children", v139.fields[0]])) : (new US8(0)), (v146.tag === 1) ? (new US8(1, ["colorScheme", v146.fields[0]])) : (new US8(0)), (v153.tag === 1) ? (new US8(1, ["compact", v153.fields[0]])) : (new US8(0)), (v160.tag === 1) ? (new US8(1, ["display", v160.fields[0]])) : (new US8(0)), (v167.tag === 1) ? (new US8(1, ["direction", v167.fields[0]])) : (new US8(0)), (v174.tag === 1) ? (new US8(1, ["external", v174.fields[0]])) : (new US8(0)), (v181.tag === 1) ? (new US8(1, ["flex", v181.fields[0]])) : (new US8(0)), (v188.tag === 1) ? (new US8(1, ["flexDirection", v188.fields[0]])) : (new US8(0)), (v195.tag === 1) ? (new US8(1, ["fontSize", v195.fields[0]])) : (new US8(0)), (v202.tag === 1) ? (new US8(1, ["height", v202.fields[0]])) : (new US8(0)), (v209.tag === 1) ? (new US8(1, ["href", v209.fields[0]])) : (new US8(0)), (v216.tag === 1) ? (new US8(1, ["icon", v216.fields[0]])) : (new US8(0)), (v223.tag === 1) ? (new US8(1, ["id", v223.fields[0]])) : (new US8(0)), (v230.tag === 1) ? (new US8(1, ["justifyContent", v230.fields[0]])) : (new US8(0)), (v237.tag === 1) ? (new US8(1, ["left", v237.fields[0]])) : (new US8(0)), (v244.tag === 1) ? (new US8(1, ["lineHeight", v244.fields[0]])) : (new US8(0)), (v251.tag === 1) ? (new US8(1, ["margin", v251.fields[0]])) : (new US8(0)), (v258.tag === 1) ? (new US8(1, ["marginBottom", v258.fields[0]])) : (new US8(0)), (v265.tag === 1) ? (new US8(1, ["maxHeight", v265.fields[0]])) : (new US8(0)), (v272.tag === 1) ? (new US8(1, ["onChange", v272.fields[0]])) : (new US8(0)), (v279.tag === 1) ? (new US8(1, ["onClick", v279.fields[0]])) : (new US8(0)), (v286.tag === 1) ? (new US8(1, ["outline", v286.fields[0]])) : (new US8(0)), (v293.tag === 1) ? (new US8(1, ["overflowY", v293.fields[0]])) : (new US8(0)), (v300.tag === 1) ? (new US8(1, ["padding", v300.fields[0]])) : (new US8(0)), (v307.tag === 1) ? (new US8(1, ["paddingTop", v307.fields[0]])) : (new US8(0)), (v314.tag === 1) ? (new US8(1, ["position", v314.fields[0]])) : (new US8(0)), (v321.tag === 1) ? (new US8(1, ["right", v321.fields[0]])) : (new US8(0)), (v328.tag === 1) ? (new US8(1, ["size", v328.fields[0]])) : (new US8(0)), (v335.tag === 1) ? (new US8(1, ["spacing", v335.fields[0]])) : (new US8(0)), (v342.tag === 1) ? (new US8(1, ["status", v342.fields[0]])) : (new US8(0)), (v349.tag === 1) ? (new US8(1, ["striped", v349.fields[0]])) : (new US8(0)), (v356.tag === 1) ? (new US8(1, ["thickness", v356.fields[0]])) : (new US8(0)), (v363.tag === 1) ? (new US8(1, ["title", v363.fields[0]])) : (new US8(0)), (v370.tag === 1) ? (new US8(1, ["top", v370.fields[0]])) : (new US8(0)), (v377.tag === 1) ? (new US8(1, ["width", v377.fields[0]])) : (new US8(0)), (v384.tag === 1) ? (new US8(1, ["zIndex", v384.fields[0]])) : (new US8(0))];
    const v392 = v391.length | 0;
    const v393 = fill(new Array(v392), 0, v392, null);
    const v394 = new Mut0(0, 0);
    while (method0(v392, v394)) {
        const v396 = v394.l0 | 0;
        const v397 = v394.l1 | 0;
        const v398 = v391[v396];
        let v402;
        if (v398.tag === 1) {
            v393[v397] = v398;
            v402 = (v397 + 1);
        }
        else {
            v402 = v397;
        }
        const v403 = (v396 + 1) | 0;
        v394.l0 = (v403 | 0);
        v394.l1 = (v402 | 0);
    }
    const v404 = v394.l1 | 0;
    const v405 = fill(new Array(v404), 0, v404, null);
    const v406 = new Mut1(0);
    while (method1(v404, v406)) {
        const v408 = v406.l0 | 0;
        const v409 = v393[v408];
        v405[v408] = v409;
        const v410 = (v408 + 1) | 0;
        v406.l0 = (v410 | 0);
    }
    const v411 = v405.length | 0;
    const v412 = fill(new Array(v411), 0, v411, null);
    const v413 = new Mut1(0);
    while (method1(v411, v413)) {
        const v415 = v413.l0 | 0;
        const v416 = v405[v415];
        let v419;
        if (v416.tag === 1) {
            v419 = v416.fields[0];
        }
        else {
            throw new Error("Option does not have a value.");
        }
        v412[v415] = v419;
        const v420 = (v415 + 1) | 0;
        v413.l0 = (v420 | 0);
    }
    const v421 = createObj(v412);
    const v424 = createComponent;
    return [v424(Anchor, v421)];
}

export function closure35(unitVar: void, unitVar_1: void): any {
    const v44 = new Heap0(new US0(0), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), new US3(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US2(0), new US4(0), new US0(0), new US0(0), new US0(0), new US0(1, "https://fc1943s.github.io/tictactoe_spiral/docs"), new US5(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0));
    const v52 = (): any => closure6(v44, void 0);
    const v89 = new Heap0(new US0(0), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), new US3(1, v52), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US2(1, true), new US4(0), new US0(0), new US0(0), new US0(0), v44.l17, new US5(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0));
    const v90 = v89.l0;
    const v97 = v89.l1;
    const v104 = v89.l2;
    const v111 = v89.l3;
    const v118 = v89.l4;
    const v125 = v89.l7;
    const v132 = v89.l5;
    const v139 = v89.l6;
    const v146 = v89.l8;
    const v153 = v89.l9;
    const v160 = v89.l11;
    const v167 = v89.l10;
    const v174 = v89.l12;
    const v181 = v89.l13;
    const v188 = v89.l14;
    const v195 = v89.l15;
    const v202 = v89.l16;
    const v209 = v89.l17;
    const v216 = v89.l18;
    const v223 = v89.l19;
    const v230 = v89.l20;
    const v237 = v89.l21;
    const v244 = v89.l22;
    const v251 = v89.l23;
    const v258 = v89.l24;
    const v265 = v89.l25;
    const v272 = v89.l26;
    const v279 = v89.l27;
    const v286 = v89.l28;
    const v293 = v89.l29;
    const v300 = v89.l30;
    const v307 = v89.l31;
    const v314 = v89.l32;
    const v321 = v89.l33;
    const v328 = v89.l34;
    const v335 = v89.l35;
    const v342 = v89.l36;
    const v349 = v89.l37;
    const v356 = v89.l38;
    const v363 = v89.l39;
    const v370 = v89.l40;
    const v377 = v89.l41;
    const v384 = v89.l42;
    const v391 = [(v90.tag === 1) ? (new US8(1, ["aria-label", v90.fields[0]])) : (new US8(0)), (v97.tag === 1) ? (new US8(1, ["as", v97.fields[0]])) : (new US8(0)), (v104.tag === 1) ? (new US8(1, ["backgroundColor", v104.fields[0]])) : (new US8(0)), (v111.tag === 1) ? (new US8(1, ["border", v111.fields[0]])) : (new US8(0)), (v118.tag === 1) ? (new US8(1, ["bottom", v118.fields[0]])) : (new US8(0)), (v125.tag === 1) ? (new US8(1, ["color", v125.fields[0]])) : (new US8(0)), (v132.tag === 1) ? (new US8(1, ["checked", v132.fields[0]])) : (new US8(0)), (v139.tag === 1) ? (new US8(1, ["children", v139.fields[0]])) : (new US8(0)), (v146.tag === 1) ? (new US8(1, ["colorScheme", v146.fields[0]])) : (new US8(0)), (v153.tag === 1) ? (new US8(1, ["compact", v153.fields[0]])) : (new US8(0)), (v160.tag === 1) ? (new US8(1, ["display", v160.fields[0]])) : (new US8(0)), (v167.tag === 1) ? (new US8(1, ["direction", v167.fields[0]])) : (new US8(0)), (v174.tag === 1) ? (new US8(1, ["external", v174.fields[0]])) : (new US8(0)), (v181.tag === 1) ? (new US8(1, ["flex", v181.fields[0]])) : (new US8(0)), (v188.tag === 1) ? (new US8(1, ["flexDirection", v188.fields[0]])) : (new US8(0)), (v195.tag === 1) ? (new US8(1, ["fontSize", v195.fields[0]])) : (new US8(0)), (v202.tag === 1) ? (new US8(1, ["height", v202.fields[0]])) : (new US8(0)), (v209.tag === 1) ? (new US8(1, ["href", v209.fields[0]])) : (new US8(0)), (v216.tag === 1) ? (new US8(1, ["icon", v216.fields[0]])) : (new US8(0)), (v223.tag === 1) ? (new US8(1, ["id", v223.fields[0]])) : (new US8(0)), (v230.tag === 1) ? (new US8(1, ["justifyContent", v230.fields[0]])) : (new US8(0)), (v237.tag === 1) ? (new US8(1, ["left", v237.fields[0]])) : (new US8(0)), (v244.tag === 1) ? (new US8(1, ["lineHeight", v244.fields[0]])) : (new US8(0)), (v251.tag === 1) ? (new US8(1, ["margin", v251.fields[0]])) : (new US8(0)), (v258.tag === 1) ? (new US8(1, ["marginBottom", v258.fields[0]])) : (new US8(0)), (v265.tag === 1) ? (new US8(1, ["maxHeight", v265.fields[0]])) : (new US8(0)), (v272.tag === 1) ? (new US8(1, ["onChange", v272.fields[0]])) : (new US8(0)), (v279.tag === 1) ? (new US8(1, ["onClick", v279.fields[0]])) : (new US8(0)), (v286.tag === 1) ? (new US8(1, ["outline", v286.fields[0]])) : (new US8(0)), (v293.tag === 1) ? (new US8(1, ["overflowY", v293.fields[0]])) : (new US8(0)), (v300.tag === 1) ? (new US8(1, ["padding", v300.fields[0]])) : (new US8(0)), (v307.tag === 1) ? (new US8(1, ["paddingTop", v307.fields[0]])) : (new US8(0)), (v314.tag === 1) ? (new US8(1, ["position", v314.fields[0]])) : (new US8(0)), (v321.tag === 1) ? (new US8(1, ["right", v321.fields[0]])) : (new US8(0)), (v328.tag === 1) ? (new US8(1, ["size", v328.fields[0]])) : (new US8(0)), (v335.tag === 1) ? (new US8(1, ["spacing", v335.fields[0]])) : (new US8(0)), (v342.tag === 1) ? (new US8(1, ["status", v342.fields[0]])) : (new US8(0)), (v349.tag === 1) ? (new US8(1, ["striped", v349.fields[0]])) : (new US8(0)), (v356.tag === 1) ? (new US8(1, ["thickness", v356.fields[0]])) : (new US8(0)), (v363.tag === 1) ? (new US8(1, ["title", v363.fields[0]])) : (new US8(0)), (v370.tag === 1) ? (new US8(1, ["top", v370.fields[0]])) : (new US8(0)), (v377.tag === 1) ? (new US8(1, ["width", v377.fields[0]])) : (new US8(0)), (v384.tag === 1) ? (new US8(1, ["zIndex", v384.fields[0]])) : (new US8(0))];
    const v392 = v391.length | 0;
    const v393 = fill(new Array(v392), 0, v392, null);
    const v394 = new Mut0(0, 0);
    while (method0(v392, v394)) {
        const v396 = v394.l0 | 0;
        const v397 = v394.l1 | 0;
        const v398 = v391[v396];
        let v402;
        if (v398.tag === 1) {
            v393[v397] = v398;
            v402 = (v397 + 1);
        }
        else {
            v402 = v397;
        }
        const v403 = (v396 + 1) | 0;
        v394.l0 = (v403 | 0);
        v394.l1 = (v402 | 0);
    }
    const v404 = v394.l1 | 0;
    const v405 = fill(new Array(v404), 0, v404, null);
    const v406 = new Mut1(0);
    while (method1(v404, v406)) {
        const v408 = v406.l0 | 0;
        const v409 = v393[v408];
        v405[v408] = v409;
        const v410 = (v408 + 1) | 0;
        v406.l0 = (v410 | 0);
    }
    const v411 = v405.length | 0;
    const v412 = fill(new Array(v411), 0, v411, null);
    const v413 = new Mut1(0);
    while (method1(v411, v413)) {
        const v415 = v413.l0 | 0;
        const v416 = v405[v415];
        let v419;
        if (v416.tag === 1) {
            v419 = v416.fields[0];
        }
        else {
            throw new Error("Option does not have a value.");
        }
        v412[v415] = v419;
        const v420 = (v415 + 1) | 0;
        v413.l0 = (v420 | 0);
    }
    const v421 = createObj(v412);
    const v424 = createComponent;
    return [v424(Anchor, v421)];
}

export function closure8(unitVar: void, unitVar_1: void): any {
    const v6_1 = (): any => closure9(void 0, void 0);
    const v31 = "1px 6px";
    const v45 = new Heap0(new US0(0), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), new US3(1, v6_1), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US2(0), new US4(0), new US0(0), new US0(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(1, v31), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0));
    const v46 = v45.l36;
    const v51 = ((v46.tag === 1) && (v46.fields[0] === false)) !== true;
    const v54 = createSignal;
    const v55 = v54(v51);
    let v56;
    const value_1 = v55[0];
    v56 = (value_1);
    let v57;
    const value_2 = v55[1];
    v57 = ((arg_1: boolean): void => {
        value_2(arg_1);
    });
    const v63 = "1px solid $neutral5";
    const v67 = (): any => closure10(v45, v57, v56, void 0);
    const v73 = "flex";
    const v105 = new Heap0(new US0(0), new US1(0), new US0(0), new US0(1, v63), new US0(0), new US2(0), new US3(1, v67), new US0(0), new US0(0), new US2(0), new US0(0), new US0(1, v73), new US2(0), new US4(1, 1), new US0(1, {
        "@initial": "column",
        "@sm": "row",
    }), new US0(0), new US0(0), new US0(0), new US5(0), v45.l19, new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0));
    const v106 = (v: Heap0): any => closure33(void 0, v);
    const v109 = createComponent;
    const v110 = v109(v106, v105);
    const v117 = (): any => closure34(void 0, void 0);
    const v155 = new Heap0(new US0(0), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), new US3(1, v117), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US2(0), new US4(0), new US0(0), new US0(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(1, v31), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0));
    const v156 = v155.l36;
    const v161 = ((v156.tag === 1) && (v156.fields[0] === false)) !== true;
    const v162 = createSignal;
    const v163 = v162(v161);
    let v164;
    const value_7 = v163[0];
    v164 = (value_7);
    let v165;
    const value_8 = v163[1];
    v165 = ((arg_3: boolean): void => {
        value_8(arg_3);
    });
    const v174 = (): any => closure10(v155, v165, v164, void 0);
    const v211 = new Heap0(new US0(0), new US1(0), new US0(0), new US0(1, v63), new US0(0), new US2(0), new US3(1, v174), new US0(0), new US0(0), new US2(0), new US0(0), new US0(1, v73), new US2(0), new US4(1, 1), new US0(1, {
        "@initial": "column",
        "@sm": "row",
    }), new US0(0), new US0(0), new US0(0), new US5(0), v155.l19, new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0));
    const v213 = createComponent;
    const v214 = v213(v106, v211);
    const v221 = (): any => closure35(void 0, void 0);
    const v259 = new Heap0(new US0(0), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), new US3(1, v221), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US2(0), new US4(0), new US0(0), new US0(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(1, v31), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0));
    const v260 = v259.l36;
    const v265 = ((v260.tag === 1) && (v260.fields[0] === false)) !== true;
    const v266 = createSignal;
    const v267 = v266(v265);
    let v268;
    const value_13 = v267[0];
    v268 = (value_13);
    let v269;
    const value_14 = v267[1];
    v269 = ((arg_5: boolean): void => {
        value_14(arg_5);
    });
    const v278 = (): any => closure10(v259, v269, v268, void 0);
    const v315 = new Heap0(new US0(0), new US1(0), new US0(0), new US0(1, v63), new US0(0), new US2(0), new US3(1, v278), new US0(0), new US0(0), new US2(0), new US0(0), new US0(1, v73), new US2(0), new US4(1, 1), new US0(1, {
        "@initial": "column",
        "@sm": "row",
    }), new US0(0), new US0(0), new US0(0), new US5(0), v259.l19, new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0));
    const v317 = createComponent;
    return [v110, v214, v317(v106, v315)];
}

export function closure7(unitVar: void, unitVar_1: void): any {
    const v6_1 = (): any => closure8(void 0, void 0);
    const v44 = new Heap0(new US0(0), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), new US3(1, v6_1), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US2(0), new US4(0), new US0(0), new US0(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0));
    const v45 = (v: Heap0): any => closure1(void 0, v);
    const v49 = createComponent;
    return v49(v45, v44);
}

export function closure40(v0_1: US7, v1_1: (arg0: boolean) => void, unitVar: void): void {
    if (v0_1.tag === 1) {
        v0_1.fields[0]();
    }
    v1_1(true);
}

export function closure39(v0_1: US7, v1_1: (arg0: boolean) => void, unitVar: void): any {
    const v8_1 = (): any => closure23(void 0, void 0);
    const v30 = (): void => {
        closure40(v0_1, v1_1, void 0);
    };
    const v69 = "left";
    const v94 = new Heap0(new US0(0), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), (new Heap0(new US0(0), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), new US3(1, v8_1), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US2(0), new US4(0), new US0(0), new US0(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(1, v30), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0))).l6, new US0(0), new US0(1, "neutral"), new US2(1, true), new US0(0), new US0(0), new US2(0), new US4(0), new US0(0), new US0(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(1, v69), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(1, "xs"), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0));
    const v95 = v94.l0;
    const v102 = v94.l1;
    const v109 = v94.l2;
    const v116 = v94.l3;
    const v123 = v94.l4;
    const v130 = v94.l7;
    const v137 = v94.l5;
    const v144 = v94.l6;
    const v151 = v94.l8;
    const v158 = v94.l9;
    const v165 = v94.l11;
    const v172 = v94.l10;
    const v179 = v94.l12;
    const v186 = v94.l13;
    const v193 = v94.l14;
    const v200 = v94.l15;
    const v207 = v94.l16;
    const v214 = v94.l17;
    const v221 = v94.l18;
    const v228 = v94.l19;
    const v235 = v94.l20;
    const v242 = v94.l21;
    const v248 = v94.l22;
    const v255 = v94.l23;
    const v262 = v94.l24;
    const v269 = v94.l25;
    const v276 = v94.l26;
    const v283 = v94.l27;
    const v290 = v94.l28;
    const v297 = v94.l29;
    const v304 = v94.l30;
    const v311 = v94.l31;
    const v318 = v94.l32;
    const v325 = v94.l33;
    const v332 = v94.l34;
    const v339 = v94.l35;
    const v346 = v94.l36;
    const v353 = v94.l37;
    const v360 = v94.l38;
    const v367 = v94.l39;
    const v374 = v94.l40;
    const v381 = v94.l41;
    const v388 = v94.l42;
    const v395 = [(v95.tag === 1) ? (new US8(1, ["aria-label", v95.fields[0]])) : (new US8(0)), (v102.tag === 1) ? (new US8(1, ["as", v102.fields[0]])) : (new US8(0)), (v109.tag === 1) ? (new US8(1, ["backgroundColor", v109.fields[0]])) : (new US8(0)), (v116.tag === 1) ? (new US8(1, ["border", v116.fields[0]])) : (new US8(0)), (v123.tag === 1) ? (new US8(1, ["bottom", v123.fields[0]])) : (new US8(0)), (v130.tag === 1) ? (new US8(1, ["color", v130.fields[0]])) : (new US8(0)), (v137.tag === 1) ? (new US8(1, ["checked", v137.fields[0]])) : (new US8(0)), (v144.tag === 1) ? (new US8(1, ["children", v144.fields[0]])) : (new US8(0)), (v151.tag === 1) ? (new US8(1, ["colorScheme", v151.fields[0]])) : (new US8(0)), (v158.tag === 1) ? (new US8(1, ["compact", v158.fields[0]])) : (new US8(0)), (v165.tag === 1) ? (new US8(1, ["display", v165.fields[0]])) : (new US8(0)), (v172.tag === 1) ? (new US8(1, ["direction", v172.fields[0]])) : (new US8(0)), (v179.tag === 1) ? (new US8(1, ["external", v179.fields[0]])) : (new US8(0)), (v186.tag === 1) ? (new US8(1, ["flex", v186.fields[0]])) : (new US8(0)), (v193.tag === 1) ? (new US8(1, ["flexDirection", v193.fields[0]])) : (new US8(0)), (v200.tag === 1) ? (new US8(1, ["fontSize", v200.fields[0]])) : (new US8(0)), (v207.tag === 1) ? (new US8(1, ["height", v207.fields[0]])) : (new US8(0)), (v214.tag === 1) ? (new US8(1, ["href", v214.fields[0]])) : (new US8(0)), (v221.tag === 1) ? (new US8(1, ["icon", v221.fields[0]])) : (new US8(0)), (v228.tag === 1) ? (new US8(1, ["id", v228.fields[0]])) : (new US8(0)), (v235.tag === 1) ? (new US8(1, ["justifyContent", v235.fields[0]])) : (new US8(0)), (v242.tag === 1) ? (new US8(1, [v69, v242.fields[0]])) : (new US8(0)), (v248.tag === 1) ? (new US8(1, ["lineHeight", v248.fields[0]])) : (new US8(0)), (v255.tag === 1) ? (new US8(1, ["margin", v255.fields[0]])) : (new US8(0)), (v262.tag === 1) ? (new US8(1, ["marginBottom", v262.fields[0]])) : (new US8(0)), (v269.tag === 1) ? (new US8(1, ["maxHeight", v269.fields[0]])) : (new US8(0)), (v276.tag === 1) ? (new US8(1, ["onChange", v276.fields[0]])) : (new US8(0)), (v283.tag === 1) ? (new US8(1, ["onClick", v283.fields[0]])) : (new US8(0)), (v290.tag === 1) ? (new US8(1, ["outline", v290.fields[0]])) : (new US8(0)), (v297.tag === 1) ? (new US8(1, ["overflowY", v297.fields[0]])) : (new US8(0)), (v304.tag === 1) ? (new US8(1, ["padding", v304.fields[0]])) : (new US8(0)), (v311.tag === 1) ? (new US8(1, ["paddingTop", v311.fields[0]])) : (new US8(0)), (v318.tag === 1) ? (new US8(1, ["position", v318.fields[0]])) : (new US8(0)), (v325.tag === 1) ? (new US8(1, ["right", v325.fields[0]])) : (new US8(0)), (v332.tag === 1) ? (new US8(1, ["size", v332.fields[0]])) : (new US8(0)), (v339.tag === 1) ? (new US8(1, ["spacing", v339.fields[0]])) : (new US8(0)), (v346.tag === 1) ? (new US8(1, ["status", v346.fields[0]])) : (new US8(0)), (v353.tag === 1) ? (new US8(1, ["striped", v353.fields[0]])) : (new US8(0)), (v360.tag === 1) ? (new US8(1, ["thickness", v360.fields[0]])) : (new US8(0)), (v367.tag === 1) ? (new US8(1, ["title", v367.fields[0]])) : (new US8(0)), (v374.tag === 1) ? (new US8(1, ["top", v374.fields[0]])) : (new US8(0)), (v381.tag === 1) ? (new US8(1, ["width", v381.fields[0]])) : (new US8(0)), (v388.tag === 1) ? (new US8(1, ["zIndex", v388.fields[0]])) : (new US8(0))];
    const v396 = v395.length | 0;
    const v397 = fill(new Array(v396), 0, v396, null);
    const v398 = new Mut0(0, 0);
    while (method0(v396, v398)) {
        const v400 = v398.l0 | 0;
        const v401 = v398.l1 | 0;
        const v402 = v395[v400];
        let v406;
        if (v402.tag === 1) {
            v397[v401] = v402;
            v406 = (v401 + 1);
        }
        else {
            v406 = v401;
        }
        const v407 = (v400 + 1) | 0;
        v398.l0 = (v407 | 0);
        v398.l1 = (v406 | 0);
    }
    const v408 = v398.l1 | 0;
    const v409 = fill(new Array(v408), 0, v408, null);
    const v410 = new Mut1(0);
    while (method1(v408, v410)) {
        const v412 = v410.l0 | 0;
        const v413 = v397[v412];
        v409[v412] = v413;
        const v414 = (v412 + 1) | 0;
        v410.l0 = (v414 | 0);
    }
    const v415 = v409.length | 0;
    const v416 = fill(new Array(v415), 0, v415, null);
    const v417 = new Mut1(0);
    while (method1(v415, v417)) {
        const v419 = v417.l0 | 0;
        const v420 = v409[v419];
        let v423;
        if (v420.tag === 1) {
            v423 = v420.fields[0];
        }
        else {
            throw new Error("Option does not have a value.");
        }
        v416[v419] = v423;
        const v424 = (v419 + 1) | 0;
        v417.l0 = (v424 | 0);
    }
    const v425 = createObj(v416);
    const v428 = createComponent;
    return [v428(Button, v425)];
}

export function closure38(v0_1: Heap0, v1_1: int32, v2_1: (arg0: boolean) => void, v3_1: (arg0: void) => boolean, v4_1: (arg0: boolean) => void, v5_1: (arg0: void) => boolean, v6_1: (arg0: boolean) => void, v7_1: (arg0: void) => boolean, v8_1: US7, unitVar: void): any {
    let v17_1: (arg0: void) => any, v55: Heap0, v56: (arg0: Heap0) => any, v60: any, v65: US4, v70: US0, v75: US0, v80: US0, v85: US0, v90: US0, v100: (arg0: void) => any, v134: Heap0, v135: (arg0: Heap0) => any, v139: any;
    return [(v3_1() === false) ? ((v17_1 = ((): any => closure39(v8_1, v2_1, void 0)), (v55 = (new Heap0(new US0(0), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), new US3(1, v17_1), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US2(0), new US4(0), new US0(0), new US0(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0))), (v56 = ((v: Heap0): any => closure25(void 0, v)), (v60 = createComponent, v60(v56, v55)))))) : ((v65 = (v7_1() ? (new US4(1, 1)) : (new US4(0))), (v70 = (v7_1() ? (new US0(1, "absolute")) : (new US0(0))), (v75 = (v7_1() ? (new US0(1, "0")) : (new US0(0))), (v80 = (v7_1() ? (new US0(1, "0")) : (new US0(0))), (v85 = (v7_1() ? (new US0(1, "0")) : (new US0(0))), (v90 = (v7_1() ? (new US0(1, "0")) : (new US0(0))), (v100 = ((): any => closure26(v0_1, v1_1, v2_1, v4_1, v5_1, v6_1, v7_1, void 0)), (v134 = (new Heap0(new US0(0), new US1(0), v7_1() ? (new US0(1, "$bg")) : (new US0(0)), new US0(0), v85, new US2(0), new US3(1, v100), new US0(0), new US0(0), new US2(0), new US0(0), new US0(1, "flex"), new US2(0), new US4(1, 1), new US0(0), new US0(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), v90, new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(0), new US0(0), v70, v80, new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), v75, new US0(0), v65)), (v135 = ((v_1: Heap0): any => closure25(void 0, v_1)), (v139 = createComponent, v139(v135, v134))))))))))))];
}

export function closure37(v0_1: Heap0, _arg: [boolean, boolean, US7]): any {
    const v3_1 = _arg[2];
    const v4_1 = nonSeeded().Next0() | 0;
    const v7_1 = createSignal;
    const v8_1 = v7_1(_arg[0]);
    let v9_1;
    const value_1 = v8_1[0];
    v9_1 = (value_1);
    let v10_1;
    const value_2 = v8_1[1];
    v10_1 = ((arg_1: boolean): void => {
        value_2(arg_1);
    });
    const v11_1 = createSignal;
    const v12_1 = v11_1(false);
    let v13_1;
    const value_4 = v12_1[0];
    v13_1 = (value_4);
    let v14_1;
    const value_5 = v12_1[1];
    v14_1 = ((arg_3: boolean): void => {
        value_5(arg_3);
    });
    const v15_1 = createSignal;
    const v16_1 = v15_1(_arg[1]);
    let v17_1;
    const value_7 = v16_1[0];
    v17_1 = (value_7);
    let v18_1;
    const value_8 = v16_1[1];
    v18_1 = ((arg_5: boolean): void => {
        value_8(arg_5);
    });
    const v20 = on;
    const v21 = (): Array<boolean> => closure19(v13_1, void 0);
    const v22 = (): void => {
        closure20(v14_1, v13_1, void 0);
    };
    const v23 = v20(v21, v22);
    const v25 = createEffect;
    v25(v23);
    if (v3_1.tag === 1) {
        v3_1.fields[0]();
    }
    const v34 = (): any => closure38(v0_1, v4_1, v10_1, v9_1, v14_1, v13_1, v18_1, v17_1, v3_1, void 0);
    const v72 = new Heap0(new US0(0), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), new US3(1, v34), new US0(0), new US0(0), new US2(0), new US0(0), new US0(1, "flex"), new US2(0), new US4(1, 1), new US0(0), new US0(0), new US0(0), new US0(0), new US5(0), v0_1.l19, new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0));
    const v73 = (v: Heap0): any => closure25(void 0, v);
    const v76 = createComponent;
    return v76(v73, v72);
}

export function closure36(unitVar: void, v0_1: Heap0): (arg0: [boolean, boolean, US7]) => any {
    return (arg10$0040: [boolean, boolean, US7]): any => closure37(v0_1, arg10$0040);
}

export function closure44(v0_1: US7, v1_1: Heap0, v2_1: (arg0: void) => boolean, v3_1: (arg0: void) => any, unitVar: void): any {
    let v14_1: (arg0: void) => any, v52: Heap0, v53: int32, v56: any, v57: Array<any>, v58: (arg0: void) => boolean, value_1: any, v59: (arg0: boolean) => void, value_2: any, v60: any, v61: Array<any>, v62: (arg0: void) => boolean, value_4: any, v63: (arg0: boolean) => void, value_5: any, v64: any, v65: Array<any>, v66: (arg0: void) => boolean, value_7: any, v67: (arg0: boolean) => void, value_8: any, v69: any, v70: (arg0: void) => Array<boolean>, v71: (arg0: void) => void, v72: any, v74: any, v83: (arg0: void) => any, v121: Heap0, v122: (arg0: Heap0) => any, v125: any;
    return [(v1_1.l36.tag === 1) ? (v2_1() ? ((v14_1 = ((): any => closure18(v3_1, void 0)), (v52 = (new Heap0(new US0(0), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), new US3(1, v14_1), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US2(0), new US4(0), new US0(0), new US0(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0))), (v53 = (nonSeeded().Next0() | 0), (v56 = createSignal, (v57 = (v56(true)), (v58 = ((value_1 = v57[0], value_1)), (v59 = ((value_2 = v57[1], (arg_1: boolean): void => {
        value_2(arg_1);
    })), (v60 = createSignal, (v61 = (v60(false)), (v62 = ((value_4 = v61[0], value_4)), (v63 = ((value_5 = v61[1], (arg_3: boolean): void => {
        value_5(arg_3);
    })), (v64 = createSignal, (v65 = (v64(false)), (v66 = ((value_7 = v65[0], value_7)), (v67 = ((value_8 = v65[1], (arg_5: boolean): void => {
        value_8(arg_5);
    })), (v69 = on, (v70 = ((): Array<boolean> => closure19(v62, void 0)), (v71 = ((): void => {
        closure20(v63, v62, void 0);
    }), (v72 = (v69(v70, v71)), (v74 = createEffect, (void (v74(v72)), ((v0_1.tag === 1) ? ((v0_1.fields[0](), void 0)) : (void 0), (v83 = ((): any => closure38(v52, v53, v59, v58, v63, v62, v67, v66, v0_1, void 0)), (v121 = (new Heap0(new US0(0), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), new US3(1, v83), new US0(0), new US0(0), new US2(0), new US0(0), new US0(1, "flex"), new US2(0), new US4(1, 1), new US0(0), new US0(0), new US0(0), new US0(0), new US5(0), v52.l19, new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0))), (v122 = ((v: Heap0): any => closure25(void 0, v)), (v125 = createComponent, v125(v122, v121)))))))))))))))))))))))))))) : <></>) : v3_1()];
}

export function closure43(v0_1: US7, v1_1: Heap0, v2_1: (arg0: boolean) => void, v3_1: (arg0: void) => boolean, unitVar: void): any {
    let v14_1: (arg0: void) => any, v58: Heap0, v59: (arg0: Heap0) => any, v63: any, v121: US0, v132: (arg0: void) => any, v153: string, v176: Heap0, v177: (arg0: Heap0) => any, v181: any, v73: (arg0: void) => any, v113: Heap0, v114: (arg0: Heap0) => any, v118: any;
    const v4_1 = v1_1.l39;
    const v66 = v1_1.l6;
    return [(v4_1.tag === 1) ? ((v14_1 = ((): any => closure11(v1_1, v2_1, v3_1, v4_1.fields[0], void 0)), (v58 = (new Heap0(new US0(0), new US1(0), new US0(0), new US0(1, "0 !important"), new US0(0), new US2(0), new US3(1, v14_1), new US0(1, "$neutral9"), new US0(0), new US2(0), new US0(0), new US0(1, "flex"), new US2(0), new US4(0), new US0(1, "column"), new US0(1, "$sm"), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(1, "1px solid $neutral5"), new US0(0), new US0(1, "3px 20px 0 8px"), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0))), (v59 = ((v: Heap0): any => closure15(void 0, v)), (v63 = createComponent, v63(v59, v58)))))) : <></>, (v66.tag === 1) ? ((v121 = v1_1.l30, (v132 = ((): any => closure44(v0_1, v1_1, v3_1, v66.fields[0], void 0)), (v153 = "0", (v176 = (new Heap0(new US0(0), new US1(0), new US0(0), new US0(1, "0 !important"), new US0(0), new US2(0), new US3(1, v132), new US0(0), new US0(0), new US2(0), new US0(0), new US0(1, "flex"), new US2(0), new US4(1, 6), new US0(1, "column"), new US0(1, "$sm"), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(1, v153), new US0(0), new US0(1, "85vh"), new US6(0), new US7(0), new US0(1, v153), new US0(1, "auto"), new US0(1, (v121.tag === 1) ? v121.fields[0] : "0"), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0))), (v177 = ((v_2: Heap0): any => closure15(void 0, v_2)), (v181 = createComponent, v181(v177, v176)))))))) : ((v73 = ((): any => closure16(void 0, void 0)), (v113 = (new Heap0(new US0(0), new US1(0), new US0(0), new US0(0), new US0(0), new US2(0), new US3(1, v73), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US2(0), new US4(0), new US0(0), new US0(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US0(0), new US0(1, "9px"), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(1, "0"), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0))), (v114 = ((v_1: Heap0): any => closure15(void 0, v_1)), (v118 = createComponent, v118(v114, v113))))))];
}

export function closure42(v0_1: Heap0, v1_1: US7): any {
    const v2_1 = v0_1.l36;
    const v7_1 = ((v2_1.tag === 1) && (v2_1.fields[0] === false)) !== true;
    const v10_1 = createSignal;
    const v11_1 = v10_1(v7_1);
    let v12_1;
    const value_1 = v11_1[0];
    v12_1 = (value_1);
    let v13_1;
    const value_2 = v11_1[1];
    v13_1 = ((arg_1: boolean): void => {
        value_2(arg_1);
    });
    const v23 = (): any => closure43(v1_1, v0_1, v13_1, v12_1, void 0);
    const v61 = new Heap0(new US0(0), new US1(0), new US0(0), new US0(1, "1px solid $neutral5"), new US0(0), new US2(0), new US3(1, v23), new US0(0), new US0(0), new US2(0), new US0(0), new US0(1, "flex"), new US2(0), new US4(1, 1), new US0(1, {
        "@initial": "column",
        "@sm": "row",
    }), new US0(0), new US0(0), new US0(0), new US5(0), v0_1.l19, new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US6(0), new US7(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US0(0), new US2(0), new US0(0), new US0(0), new US5(0), new US0(0), new US0(0), new US4(0));
    const v62 = (v: Heap0): any => closure33(void 0, v);
    const v65 = createComponent;
    return v65(v62, v61);
}

export function closure41(unitVar: void, v0_1: Heap0): (arg0: US7) => any {
    return (v: US7): any => closure42(v0_1, v);
}

export const v0 = "base_button";

export const v1 = (v: Heap0): any => closure0(void 0, v);

export const v2 = [v0, v1];

export const v3 = "base_table";

export const v4 = (v: Heap0): any => closure1(void 0, v);

export const v5 = [v3, v4];

export const v6 = "external_link";

export const v7 = (v: Heap0): any => closure5(void 0, v);

export const v8 = [v6, v7];

export const v9 = "links";

export const v10 = (): any => closure7(void 0, void 0);

export const v11 = [v9, v10];

export const v12 = "loader";

export const v13 = (v: Heap0): (arg0: [boolean, boolean, US7]) => any => closure36(void 0, v);

export const v14 = [v12, v13];

export const v15 = "row";

export const v16 = (v: Heap0): (arg0: US7) => any => closure41(void 0, v);

export const v17 = [v15, v16];

export const v18 = [v2, v5, v8, v11, v14, v17];

export const v19 = createObj(v18);


