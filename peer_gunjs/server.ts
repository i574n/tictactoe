import fs from 'fs'
import path from 'path'
import Gun from 'gun'
import https from 'https'
import http from 'http'
import { fileURLToPath } from 'url'
import { dirname } from 'path'

const __filename = fileURLToPath(import.meta.url)
const __dirname = dirname(__filename)

console.log('argv', process.argv)

const config = (() => {
  const port = process.env.PORT || "8765"
  const rootPath = process.argv[3] || process.env.ROOT_PATH
  const domain = process.argv[5] || process.env.PEER_DOMAIN
  const https = Boolean(process.env.HTTPS && domain)
  return { port, rootPath, domain, https }
})()

console.log("config", JSON.stringify(config, null, 4))

if (!config.rootPath || config.rootPath === "%ROOT_PATH%") {
  throw new Error('Invalid --root-path')
}
if (!config.domain || config.domain === "%PEER_DOMAIN%") {
  throw new Error('Invalid --domain')
}
if (!fs.existsSync(config.rootPath)) {
  fs.mkdirSync(config.rootPath)
}

const server = config.https
  ? https.createServer(
    {
      cert: fs.readFileSync(`./ssl/${config.domain}.pem`),
      key: fs.readFileSync(`./ssl/${config.domain}-key.pem`),
    },
    (Gun as any).serve(__dirname)
  )
  : http.createServer((Gun as any).serve(__dirname))

const gun = Gun({
  web: server.listen(config.port),
  stats: false,
  file: config.rootPath
})

console.log(`Relay peer started. URL=/gun
path.resolve(rootPath)=${path.resolve(config.rootPath)}`)

export default gun
