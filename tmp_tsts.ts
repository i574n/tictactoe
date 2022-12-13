

const _tmp = () => test("test1", async ({ browser }) => {
    const context = await browser.newContext({
        recordVideo: {
            dir: "./playwright-report"
        }
    })
    const page = await context.newPage()

    await page.goto("https://www.16personalities.com/free-personality-test", { waitUntil: "networkidle" })
    await injectAxe(page)

    const title = page.locator('header h1')
    await expect(title).toHaveText('Free Personality Test')

    const allTexts = []
    const l = page.locator('button.button--fixed.button--icon-rt')
    const getNextButton = () => l
    while (await getNextButton().count() > 0) {
        const questions = page.locator('.statement > span')
        const texts = await questions.allTextContents()
        // console.log({ texts })
        allTexts.push(...texts)
        // console.log({ els: await l.evaluateAll((els, state) => ({ ...state, x: JSON.stringify(els.map(x => ({ className: x.className, outerHTML: x.outerHTML }))) }), {}) })
        //await getNextButton().scrollIntoViewIfNeeded()

        //  await getNextButton().waitFor({state: 'visible'})
        //await page.waitForTimeout(1000)

        await getNextButton().click({ force: true })

        console.log('after click url', page.url())

        // await page.goto("https://xntbhj.stackblitz.io/");
        // await page.waitForSelector(`text="Run this project"`)
        // await page.click(`button:has-text('Run this project')`);

        // // Wait for the app to render
        // await page.waitForSelector(`#go-to-sign-up`)
        // await page.waitForTimeout(1000);

        // await page.click(`#go-to-sign-up`) /// <<<<<<<< this click fails in chromium

    }


    console.log({ allTexts })

    // await page.waitForNavigation()
    await page.locator('.test-results .bar > div >> nth=0').waitFor({ state: 'attached' })

    console.log('after X url', page.url())
    const urlRegex = /16personalities.com\/(\w+)-personality$/.exec(page.url())
    console.log({ urlRegex })

    console.log({ els: await page.locator('.test-results .bar > div').evaluateAll((els, state) => ({ ...state, x: JSON.stringify(els.map(x => ({ width: x.style.width }))) }), {}) })

    console.log('video path:', await page?.video()?.path())

    await context.close()
    await browser.close()

    // '.statement > span'
    // '.action-row button'
    // 'div[role=radio]'

    // await checkA11y(page, null, {
    //     axeOptions: {},
    //     detailedReport: true,
    //     detailedReportOptions: { html: true }
    // })
})
