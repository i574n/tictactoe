import { test } from "@playwright/test"
import { checkA11y, injectAxe } from "axe-playwright"

test("test1", async ({ page }) => {
    await page.goto("https://localhost:3700")
    await injectAxe(page);
    await checkA11y(page, null, {
        axeOptions: {},
        detailedReport: true,
        detailedReportOptions: { html: true }
    })
})
