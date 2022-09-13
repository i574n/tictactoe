export type ProfileState = {
    profile: {
        tmp: {
            counter?: { [_: string]: number } | undefined
            chainStatus?: { [_: string]: any } | undefined
            chainDeploy?: { [_: string]: any } | undefined
        }
    }
}
