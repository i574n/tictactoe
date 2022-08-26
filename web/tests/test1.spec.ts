import { Browser, BrowserContext, Locator, Page, Frame, Request, Response, Worker, Download, WebSocket, test } from "@playwright/test"
import { injectAxe } from "axe-playwright"

const range = (n: number) => Array.from(Array(n).keys())

function newContext(browser: Browser) {
    return browser.newContext({
        ignoreHTTPSErrors: true,
        viewport: {
            width: 1500,
            height: 2500
        },
        recordVideo: {
            dir: "./playwright-videos"
        }
    })
}

const getUrl = (obj: Page | Frame | Request | Response | Worker | Download | WebSocket) =>
    obj.url().replace(/\:\/\/localhost/g, '')

let consoleEnabled = false

async function newPage(index: number, context: BrowserContext) {
    const page = await context.newPage()

    const logs = []
    page.on('console', async (msg) => {
        const msgs = []
        for (const arg of msg.args()) {
            const newMsgs = await arg.jsonValue()
            msgs.push(newMsgs)
            logs.push(newMsgs)
        }
        if (msgs.length > 0 && consoleEnabled) {
            console.log(`${index}>`, ...msgs)
        }
    })

    page.on('close', async (page) => console.log(`***${index} close ***`, getUrl(page)))
    page.on('crash', async (page) => console.warn(`***${index} crash ***\n`, { url: getUrl(page) }))
    page.on('dialog', async (dialog) => console.log(`***${index} dialog ***\n`, { message: dialog.message() }))
    page.on('domcontentloaded', async (page) => console.log(`***${index} domcontentloaded ***`, getUrl(page)))
    page.on('download', async (download) => console.log(`***${index} download ***\n`, { url: getUrl(download) }))
    page.on('filechooser', async (fileChooser) => console.log(`***${index} filechooser ***\n`, { isMultiple: fileChooser.isMultiple() }))
    page.on('frameattached', async (frame) => console.log(`***${index} frameattached ***\n`, { url: getUrl(frame) }))
    page.on('framedetached', async (frame) => console.log(`***${index} framedetached ***\n`, { url: getUrl(frame) }))
    page.on('framenavigated', async (frame) => console.log(`***${index} framenavigated ***\n`, { url: getUrl(frame) }))
    page.on('load', async (page) => console.log(`***${index} load ***`, getUrl(page)))
    page.on('pageerror', async (error) => console.warn(`***${index} pageerror ***\n`, { error }))
    page.on('popup', async (page) => console.log(`***${index} popup ***\n`, { url: getUrl(page) }))
    page.on('request', (request) => console.log(`***${index} request ***`, request.method(), getUrl(request)))
    page.on('requestfailed', async (request) => console.warn(`***${index} requestfailed ***\n`, { method: request.method(), url: getUrl(request) }))
    page.on('requestfinished', async (request) => console.log(`***${index} requestfinished ***`, request.method(), getUrl(request)))
    page.on('response', (response) => console.log(`***${index} response **`, response.status(), getUrl(response)))
    page.on('worker', async (worker) => console.log(`***${index} worker ***\n`, { url: getUrl(worker) }))

    page.on('websocket', async (ws) => {
        console.log(`***${index} websocket ***`, { url: getUrl(ws) })

        ws.on('framereceived', (data: { payload: string | Buffer }) => {
            console.log(`***${index} framereceived ***`, getUrl(ws), data.payload)
        })

        ws.on('framesent', (data: { payload: string | Buffer }) => {
            console.log(`***${index} framesent ***`, getUrl(ws), data.payload)
        })

        ws.on('close', (ws) => { console.log(`***${index} close ***`, { url: getUrl(ws) }) })

        ws.on('socketerror', (error) => {
            console.warn(`***${index} socketerror ***`, {
                url: getUrl(ws),
                error: error
            })
        })
    })

    return page
}

function newTest(title: string, testFn: (_: { browser: Browser }) => any) {
    return test(title, async ({ browser }) => {
        const context = await newContext(browser)

        const pages = await testFn({ browser })

        for (const [index, page] of pages.entries()) {
            console.log(`# Page ${index}`)
            console.log('After Test URL:', getUrl(page))
            console.log('Video Path:', await page?.video()?.path())
        }

        await context.close()
        await browser.close()
    })
}

let actionIndex = 0
const action = async (pages: Page[], title: string, selector: string, fn: (_: Page[]) => Promise<any>) => {
    console.log(`\n!### ${actionIndex}: ${title}. wait before action`)

    await Promise.all(pages.map(async (page, _index) => {
        await page.waitForTimeout(500)
    }))

    if (selector) {
        console.log(`\n!### ${actionIndex}: ${title}. print before action`)

        const textContent1 = await Promise.all(
            pages
                .map(page => page
                    .locator(selector)
                    .evaluateAll((nodes) => nodes.map((node) => node.textContent))))
        console.log({ textContent1 })
    }

    console.log(`\n!### ${actionIndex}: ${title}. action`)

    const result = await fn(pages)

    await Promise.all(pages.map(async (page, _index) => {
        await page.waitForTimeout(500)
    }))

    if (selector) {
        console.log(`\n!### ${actionIndex}: ${title}. print after action. result: ${result}`)

        const textContent2 = await Promise.all(
            pages
                .map(page => page
                    .locator(selector)
                    .evaluateAll((nodes) => nodes.map((node) => node.textContent))))
        console.log({ textContent2 })
    }

    actionIndex++

    return result
}

const waitFor = (
    pages: Page[],
    title: string,
    selector: string,
    opts: { has?: Locator; hasText?: string | RegExp } | undefined
) => action(pages, title, selector, (pages) =>
    Promise.all(
        pages
            .map(page => page
                .locator(selector, opts)
                .waitFor())))


newTest("test1", async ({ browser }) => {
    const context = await newContext(browser)

    const pageCount = 5
    const pages = await Promise.all(range(pageCount).map((i) => newPage(i, context)))

    await Promise.all(pages.map(async page => {
        await page.goto("https://localhost:3700/tictactoe_spiral", { waitUntil: 'networkidle' })
        await injectAxe(page)
    }))

    await action(pages, 'load db', '#counter pre', async (pages) => {
        await Promise.all(pages.map(async (page, index) => {
            {
                if (index == 0 || index == 1) {
                    await page.locator('#db-gun-rs-rs button').nth(0).click()
                }
                if (index == 0 || index == 2) {
                    await page.locator('#db-gun-rs-js button').nth(0).click()
                }
                if (index == 0 || index == 3) {
                    await page.locator('#db-gun-js-js button').nth(0).click()
                }
                if (index == 0 || index == 4) {
                    await page.locator('#db-gun-js-rs button').nth(0).click()
                }
            }
        }))
    })

    await action(pages, 'clear click 1', '#counter pre', async (pages) => {
        await Promise.all(pages.map(async (page, _index) => {
            await page.locator('#counter button').nth(1).click()
            // await page.locator('#status button').nth(1).click()
            // await page.locator('#deploy button').nth(1).click()
        }))
    })

    await waitFor(pages, 'wait empty 1', '#counter pre', { hasText: '{}' })

    consoleEnabled = true

    for (const [index, page] of pages.entries()) {
        if (index < 5) {
            await action(pages, `request click ${index}`, '#counter pre', async (_pages) => {
                await page.locator('#counter button').nth(0).click()
            })

            await waitFor(pages, `wait i::${index}`, '#counter pre', { hasText: `": ${index}` })
        }
    }

    await action(pages, 'clear click 2', '#counter pre', async (pages) => {
        await pages[0].locator('#counter button').nth(1).click()
    })

    await waitFor(pages, 'wait empty 2', '#counter pre', { hasText: '{}' })

    return pages
})
