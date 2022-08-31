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
var spiprojOpenReq = async (uri: string, spiprojText: string): Promise<void> => requestJSON({ ProjectFileOpen: { uri, spiprojText } })

// cell
export var spiToFsx = async (mainSpiPath = '', newFsxPath = '', log = false) => {
    const isTemp = !mainSpiPath
    const srcPath = path.join(process.cwd(), '..')
    const destPath = isTemp ? fs.mkdtempSync(path.join('/tmp', 'spiToFsx-')) : srcPath
    
    const spiprojPath = path.join(destPath, 'package.spiproj')
    if (!mainSpiPath) {
        mainSpiPath = path.join(destPath, 'main.spi')
        fs.cpSync(path.join(srcPath, 'main.spi'), mainSpiPath)
        fs.cpSync(path.join(srcPath, 'package.spiproj'), spiprojPath)
        fs.cpSync(path.join(srcPath, 'lib_spi'), path.join(destPath, 'lib_spi'), { recursive: true })   
    }

    const fsxPath = mainSpiPath.replace('.spi', '.fsx')
    fs.writeFileSync(fsxPath, '')
    
    await util.timeout(spiprojOpenReq(spiprojPath, fs.readFileSync(spiprojPath).toString()), 2000)
    await util.timeout(spiBuildFileReq(mainSpiPath, 'Fsharp'), 2000)

    const lines = (await util.waitFileChange(fsxPath)).split('\n')
    const [imports, code] = lines.reduce(
        ([imports, code]: string[][], line) =>
            /^(open|\#r) .*?$/.test(line)
                ? [[...imports, line], code]
                : [imports, [...code, line]],
            [[], []]
    )
    const newFsx = [...imports, '', ...code].join('\n').trim() + "\n"
    fs.writeFileSync(newFsxPath || fsxPath, newFsx)
    if(log) {
        util.logStep('spiral_api.spiToFsx() end')
    }
    return newFsx
}
