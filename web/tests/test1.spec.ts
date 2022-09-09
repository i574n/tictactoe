import * as util from "../../lib_ts/util"
import { Browser, BrowserContext, Locator, Page, Frame, Request, Response, Worker, Download, WebSocket, test } from "@playwright/test"
import { injectAxe } from "axe-playwright"


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

let tmp = {
    consoleEnabled: false,
    pages: {} as {
        [_: string]: {
            wsFrameReceived: number,
            wsFrameSent: number,
            wsCount: number,
            wsCloseCount: number,
            wsErrorCount: number
        }
    }
}

const filteredLog = (...logs: any[]) => {
    if (logs.flat().some((text) => true || text.includes('0>')) || logs.length > 0 && tmp.consoleEnabled) {
        console.log(...logs)
    }
}

const tmpLog = () => JSON.stringify(Object.entries(tmp.pages))

async function newPage(index: number, context: BrowserContext) {
    const page = await context.newPage()

    page.on('console', async (msg) => {
        const newMsgs = (await Promise.all(msg.args().map((arg) => arg.jsonValue()))).join(' ').trim()
        newMsgs && filteredLog(`***${index}> ${newMsgs}`)
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

    const incCount = (key: keyof typeof tmp.pages[string]) => {
        tmp.pages = {
            ...tmp.pages,
            [`${index}`]: {
                ...tmp.pages[`${index}`],
                [key]: ((tmp.pages[`${index}`] || {})[key] || 0) + 1,
            }
        }
    }

    page.on('websocket', async (ws) => {
        incCount('wsCount')
        console.log(`***${index} websocket ***`, { url: getUrl(ws), tmpLog: tmpLog() })

        ws.on('framereceived', (data: { payload: string | Buffer }) => {
            incCount('wsFrameReceived')
            console.log(`***${index} framereceived ***`, getUrl(ws), data.payload)
        })

        ws.on('framesent', (data: { payload: string | Buffer }) => {
            incCount('wsFrameSent')
            console.log(`***${index} framesent ***`, getUrl(ws), data.payload)
        })

        ws.on('close', (ws) => {
            incCount('wsCloseCount')
            console.log(`***${index} close ***`, { url: getUrl(ws), tmpLog: tmpLog() })
        })

        ws.on('socketerror', (error) => {
            incCount('wsErrorCount')
            console.warn(`***${index} socketerror ***`, {
                url: getUrl(ws),
                error: error,
                tmpLog: tmpLog()
            })
        })
    })

    return page
}

function newTest(title: string, testFn: (_: { browser: Browser }) => any) {
    return test(title, async ({ browser, browserName }, { retry }) => {
        const context = await newContext(browser)

        // tmp.consoleEnabled = true
        if (retry > 0) {
            // tmp.consoleEnabled = true
        }
        const pages = await testFn({ browser })

        for (const [index, page] of pages.entries()) {
            console.log('test end', {
                browserName,
                index,
                pageUrl: getUrl(page),
                videoPath: await page?.video()?.path()
            })
        }

        await context.close()
        await browser.close()
    })
}

let actionIndex = 0
const action = async (pages: Page[], title: string, selector: string, fn: (_: Page[]) => Promise<any>) => {
    console.log(
        `\n!### action() ${actionIndex}: ${title}`,
    )
    let result
    for (let i = 0; i < 2; i++) {
        if (selector) {
            const textContent = await Promise.all(
                pages
                    .map(page => page
                        .locator(selector)
                        .evaluateAll((nodes) => nodes.map((node) => node.textContent))))
            console.log(
                `\n!### action() ${actionIndex}: ${title}. ${i === 0 ? 'before' : 'after'} fn`,
                ...textContent.flat().map((text) => JSON.parse(text || '""'))
            )
        }

        await Promise.all(pages.map(async (page, _index) => {
            await page.waitForTimeout(1000)
        }))

        if (i === 0) {
            result = await fn(pages)
        }
    }

    actionIndex++

    return result
}

const waitFor = (
    pages: Page[],
    title: string,
    selector: string,
    opts?: { has?: Locator; hasText?: string | RegExp }
) => action(
    pages,
    title,
    selector,
    (pages) =>
        Promise.all(
            pages.map((page) =>
                page.locator(selector, opts)
                    .waitFor())
        )
)

test.beforeEach(async ({ }, testInfo) => {
    console.log('beforeEach', { retry: testInfo.retry })
})

test.afterEach(async ({ }, testInfo) => {
    console.log('afterEach', { retry: testInfo.retry })
})

test.beforeAll(async ({ }, testInfo) => {
    console.log('beforeAll', { retry: testInfo.retry })
})

test.afterAll(async ({ }, testInfo) => {
    console.log('afterAll', { retry: testInfo.retry })
    if (testInfo.retry) {
        console.log('beforeEach', { testInfo })
    }
})

newTest("test1", async ({ browser }) => {
    const context = await newContext(browser)

    const pageCount = 5
    const pages = await Promise.all(util.range(pageCount).map((i) => newPage(i, context)))

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

    await action(pages, 'wait db', '#counter pre', async (pages) => {
        await Promise.all(pages.map(async (page, _index) => {
            await page.waitForTimeout(3500)
        }))
    })

    await action(pages, 'clear click 1', '#counter pre', async (pages) => {
        await Promise.all(pages.map(async (page, _index) => {
            await page.locator('#counter button').nth(1).click()
        }))
    })

    await waitFor(pages, 'wait empty 1', '#counter pre', { hasText: 'null' })

    for (const [index, page] of pages.entries()) {
        await action(pages, `request click p${index}`, '#counter pre', async (_pages) => {
            await page.locator('#counter button').nth(0).click()
        })

        await waitFor(pages, `wait i::${index}`, '#counter pre', { hasText: `${index}` })
    }

    await action(pages, 'clear click 2', '#counter pre', async (pages) => {
        await pages[0].locator('#counter button').nth(1).click()
    })

    await waitFor(pages, 'wait empty 2', '#counter pre', { hasText: 'null' })

    return pages
})
