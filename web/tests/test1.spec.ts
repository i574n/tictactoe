import { Browser, BrowserContext, test } from "@playwright/test"
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

async function newPage(context: BrowserContext) {
    const page = await context.newPage()

    const logs = []
    page.on('console', async msg => {
        const msgs = []
        for (const arg of msg.args()) {
            const newMsgs = await arg.jsonValue()
            msgs.push(newMsgs)
            logs.push(newMsgs)
        }
        console.log('>', ...msgs)
    })

    page.on('request', request => console.log('>>', request.method(), request.url()));
    page.on('response', response => console.log('<<', response.status(), response.url()));

    return page
}

function newTest(title: string, testFn: (_: { browser: Browser }) => any) {
    return test(title, async ({ browser }) => {
        const context = await newContext(browser)

        const pages = await testFn({ browser })

        for (const [index, page] of pages.entries()) {
            console.log(`# Page ${index}`)
            console.log('After Test URL:', page.url())
            console.log('Video Path:', await page?.video()?.path())
        }

        await context.close()
        await browser.close()
    })
}

newTest("test1", async ({ browser }) => {
    const context = await newContext(browser)

    const pageCount = 3
    const pages = await Promise.all(range(pageCount).map(_ => newPage(context)))

    await Promise.all(pages.map(async page => {
        await page.goto("https://localhost:3700/tictactoe_spiral", { waitUntil: 'networkidle' })
        await injectAxe(page)
    }))

    await Promise.all(pages.map(async page => {
        await page.locator('#counter button').nth(1).click()
        await page.locator('#status button').nth(1).click()
        await page.locator('#deploy button').nth(1).click()
    }))

    await pages[0].locator('#counter button').nth(0).click()

    await Promise.all(
        pages
            .map(page => page
                .locator('#counter pre', { hasText: '0' })
                .waitFor()))

    return pages
})
