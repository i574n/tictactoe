import * as zmq from "zeromq"
import * as fs from "fs"

var start = process.hrtime()

const elapsed = (start) => process.hrtime(start)[1] / 1000000
const logStep = (note) => {
    console.log(`${process.hrtime(start)[0]} s, ${elapsed(start).toFixed(3)} ms - ${note}`)
    start = process.hrtime()
}
const sleep = ms => new Promise(resolve => setTimeout(resolve, ms))
const waitFileChange = async (path) => {
    const stat_mtime = fs.statSync(path).mtimeMs
    while (elapsed(start) < 30000 
            && (fs.statSync(path).mtimeMs === stat_mtime 
                || fs.readFileSync(path).length === 0)) {
        await sleep(50)
    }
}

const requestRun = async (prev : Promise<string | null>, file: any): Promise<string | null> => {
    const port : number = 13805
    await prev // Waiting on the previous request is so they get ordered properly. Otherwise, messages might fill up and fire in arbitrary order.
    const sock = new zmq.Request()
    const uriServer = `tcp://localhost:${port}`
    sock.connect(uriServer)
    await sock.send(JSON.stringify(file))
    const [x] = await sock.receive()
    sock.disconnect(uriServer)
    return x ? x.toString() : null
}
let prev_request : Promise<string | null> = new Promise(resolve => resolve(null))
const request = async (file: any) => { prev_request = requestRun(prev_request,file); return prev_request }
const requestJSON = (file : any) => request(file).then(x => x ? JSON.parse(x) : undefined)

const spiBuildFileReq = async (uri: string, backend : string): Promise<void> => requestJSON({ BuildFile: {uri, backend} })

const spiToFsx = async (spi_path: string) => {
    const fsx_path = spi_path.replace('.spi', '.fsx')
    await spiBuildFileReq(spi_path, 'Fsharp')
    await waitFileChange(fsx_path)
    const lines = fs.readFileSync(fsx_path).toString().split('\n')
    const [imports, code] = lines.reduce(
        ([imports, code], line) => /^(open|\#r) .*?$/.test(line) ? [[...imports, line], code] : [imports, [...code, line]]
        , [[], []]
    );
    await fs.writeFileSync(fsx_path, [...imports, '', ...code].join('\n'))
}

console.log('args:', process.argv);
const [spi_path] = process.argv.slice(2)
await spiToFsx(spi_path)
logStep('build_spiral end')
