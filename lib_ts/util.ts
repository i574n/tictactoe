// cell
export type PickByType<T, Value> = {
    [P in keyof T as T[P] extends Value | undefined ? P : never]: T[P]
}

type NoneEmptyArray = readonly any[] & { 0: any }
type CompareUnionWithArray<P, Q extends NoneEmptyArray> = Exclude<P, Q[number]> extends never
    ? (Exclude<Q[number], P> extends never ? Q : ReadonlyArray<P>)
    : readonly [...Q, Exclude<P, Q[number]>]
export function assertTypeEquals<P, Q extends NoneEmptyArray>(_test: CompareUnionWithArray<P, Q>): void { }

// cell
export var sleep = (ms: number) => new Promise(resolve => setTimeout(resolve, ms))

// cell
export var timeout = async <T>(prom: Promise<T>, ms: number) => {
	let timer
	try {
        return await Promise.race([
            prom,
            new Promise((_r, rej) => timer = setTimeout(rej, ms, new Error('timeout')))
        ])
    } finally {
        return clearTimeout(timer)
    }
}
