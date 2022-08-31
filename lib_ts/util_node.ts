import * as fs from "fs"
import * as util from "./util"


// cell
var start = process.hrtime()

export var elapsed = (start: [number, number]) => process.hrtime(start)[1] / 1000000
export var logStep = (note: string) => {
    console.log(`${process.hrtime(start)[0]} s, ${elapsed(start).toFixed(3)} ms - ${note}`)
    start = process.hrtime()
}
export var waitFileChange = async (path: string) => {
    var start = process.hrtime()
    const stat_mtime = fs.statSync(path).mtimeMs
    const oldLines = fs.readFileSync(path).toString()
    let newLines = oldLines
    while (elapsed(start) < 30000
        && (fs.statSync(path).mtimeMs === stat_mtime
            || newLines === oldLines
            || newLines.length === 0)) {
        await util.sleep(50)
        newLines = fs.readFileSync(path).toString()
    }
    return newLines
}
