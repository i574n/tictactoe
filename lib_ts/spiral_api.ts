import * as zmq from "zeromq"
import * as fs from "fs"
import * as path from "path"
import * as util from "./util"


// cell
var requestRun = async (prev: Promise<string | null>, file: any): Promise<string | null> => {
    const port = 13805
    await prev // Waiting on the previous request is so they get ordered properly. Otherwise, messages might fill up and fire in arbitrary order.
    const sock = new zmq.Request()
    const uriServer = `tcp://localhost:${port}`
    sock.connect(uriServer)
    await sock.send(JSON.stringify(file))
    const [x] = await sock.receive()
    sock.disconnect(uriServer)
    return x ? x.toString() : null
}
var prev_request: Promise<string | null> = new Promise(resolve => resolve(null))
var request = async (file: any) => { prev_request = requestRun(prev_request, file); return prev_request }
var requestJSON = (file: any) => request(file).then(x => x ? JSON.parse(x) : undefined)

var spiBuildFileReq = async (uri: string, backend: string): Promise<void> => requestJSON({ BuildFile: { uri, backend } })

// cell
export var spiToFsx = async (spiPath = '', log = false) => {
    const cwpath = (arg: string) => path.join(process.cwd(), '..', arg)
    spiPath = spiPath || cwpath('main.spi')
    const fsxPath = spiPath.replace('.spi', '.fsx')
    await util.timeout(spiBuildFileReq(spiPath, 'Fsharp'), 2000)
    await util.waitFileChange(fsxPath)
    const lines = fs.readFileSync(fsxPath).toString().split('\n')
    const [imports, code] = lines.reduce(
        ([imports, code]: string[][], line) =>
            /^(open|\#r) .*?$/.test(line)
                ? [[...imports, line], code]
                : [imports, [...code, line]],
            [[], []]
    )
    fs.writeFileSync(fsxPath, [...imports, '', ...code].join('\n'))
    if(log) {
        util.logStep('spiral.spiToFsx() end')
    }
}
