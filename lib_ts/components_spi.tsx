import { Anchor, Icon, Table, Tbody } from "@hope-ui/solid";
import { BiRegularLinkExternal } from "solid-icons/bi";

export function closure1(unitVar: void, v0_1: any): any {
    const v1_1 = "flex";
    const v3 = "display";
    const v4 = "column";
    const v6 = "flexDirection";
    const v8 = "children";
    const v10 = Tbody;
    const v22 = Table;
    return null;
}

export function closure0(unitVar: void, unitVar_1: void): (arg0: any) => any {
    return (v: any): any => closure1(void 0, v);
}

export function closure2(unitVar: void, v0_1: string): any {
    const v4 = BiRegularLinkExternal;
    const v8 = Icon;
    const v19 = Anchor;
    return <v19 external={true}
        href={v0_1}>
        {v0_1}
         
        <v8 as={v4}></v8>
    </v19>;
}

export const v0 = (): (arg0: any) => any => closure0(void 0, void 0);

export const v1 = (v: string): any => closure2(void 0, v);


