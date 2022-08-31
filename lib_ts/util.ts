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

// cell
var runId = Math.random().toString(36).substring(2, 5)

var startTimestamp = new Date().getTime()
export var newTimestamp = () => new Date().getTime() - startTimestamp

var pad = (n: string, count: number): string => n.length < count ? pad(`0${n}`, count) : `${n}`

export var env = process.env
export var CODESPACE_NAME = env.CODESPACE_NAME
export var IS_TEST = !!env.IS_TEST

export var getLog =
    (getLocals = () => ({}), argsColor = '#888') =>
        (...args: any[]) => {
            IS_TEST
                ? console.log(
                    `[${pad(newTimestamp().toString(), 6)}] ${runId}`,
                    JSON.stringify(args),
                    JSON.stringify(getLocals())
                )
                : console.log(
                    `[${pad(newTimestamp().toString(), 6)}] ${runId} %c%s %c%s`,
                    `font-weight: bold; color: ${argsColor}`,
                    JSON.stringify(args),
                    'font-weight: bold; color: #444',
                    JSON.stringify(getLocals())
                )
        }
