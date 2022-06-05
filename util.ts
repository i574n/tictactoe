import * as fs from "fs"


// cell
var start = process.hrtime()

export var elapsed = (start: [number, number]) => process.hrtime(start)[1] / 1000000
export var logStep = (note: string) => {
    console.log(`${process.hrtime(start)[0]} s, ${elapsed(start).toFixed(3)} ms - ${note}`)
    start = process.hrtime()
}
export var sleep = (ms: number) => new Promise(resolve => setTimeout(resolve, ms))
export var waitFileChange = async (path: string) => {
    start = process.hrtime()
    const stat_mtime = fs.statSync(path).mtimeMs
    while (elapsed(start) < 30000
        && (fs.statSync(path).mtimeMs === stat_mtime
            || fs.readFileSync(path).length === 0)) {
        await sleep(50)
    }
}
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
