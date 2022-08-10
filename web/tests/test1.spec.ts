import { expect, Locator, test } from "@playwright/test"
import { checkA11y, injectAxe } from "axe-playwright"

test("test1", async ({ browser }) => {
    const context = await browser.newContext({
        ignoreHTTPSErrors: true,
        viewport: {
            width: 1500,
            height: 2500
        },
        recordVideo: {
            dir: "./playwright-videos"
        }
    })
    const page = await context.newPage()

    await page.goto("https://localhost:13700")
    await injectAxe(page)

    await page.click(`button:has-text('Load')`)
    await page.click(`button:has-text('Load')`)

    await page.waitForTimeout(1000)

    const range = (n: number) => Array.from(Array(n).keys())
    const locate = (el: Locator, sel: string, n = 0) => el.nth(n).locator(sel)
    const getRoot = (n: number) => locate(page.frameLocator('iframe') as Locator, '#root', n)

    const iframeCount = 2

    const rootArray = range(iframeCount).map(getRoot)

    await Promise.all(rootArray.map(root => root.locator('#counter button').nth(1).click()))
    await Promise.all(rootArray.map(root => root.locator('#status button').nth(1).click()))
    await Promise.all(rootArray.map(root => root.locator('#deploy button').nth(1).click()))

    await page.waitForTimeout(1000)

    const logs = []
    page.on('console', async msg => {
        const msgs = []
        for (const arg of msg.args()) {
            const newMsgs = await arg.jsonValue()
            msgs.push(newMsgs)
            logs.push(newMsgs)
        }
        console.log(...msgs)
    })

    await rootArray[0].locator('#counter button').nth(0).click()

    await page.waitForTimeout(1000)

    const counters = await Promise.all(
        rootArray
            .map(root => root
                .locator('#counter pre')
                .evaluate(counter => counter.innerHTML)))

    expect(counters).toStrictEqual(["[\n  0\n]", "[\n  0\n]"])

    console.log('after X url', page.url())
    console.log('video path:', await page?.video()?.path())

    await context.close()
    await browser.close()
})
