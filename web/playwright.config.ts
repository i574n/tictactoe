import type { PlaywrightTestConfig } from '@playwright/test'
import { devices } from '@playwright/test'

const config: PlaywrightTestConfig = {
    forbidOnly: !!process.env.CI,
    fullyParallel: false,
    outputDir: './test-results',
    repeatEach: process.env.CI ? 3 : 1,
    reporter: [['html', { open: 'never' }]], // reporter: [['html', { open: 'on-failure' }]],
    retries: process.env.CI ? 2 : 0,
    testDir: './tests',
    timeout: 40 * 1000,
    workers: 1,
    expect: {
        timeout: 30000
    },
    use: {
        video: 'on',
        trace: 'on',
        actionTimeout: 0,
        ignoreHTTPSErrors: true,
        baseURL: 'https://localhost'
    },
    projects: [
        { name: 'chromium', use: { ...devices['Desktop Chrome'] } },
        ...(!process.env.CI ? [] : [
            { name: 'firefox', use: { ...devices['Desktop Firefox'] } },
            // { name: 'webkit', use: { ...devices['Desktop Safari'] } },
            { name: 'Mobile Chrome', use: { ...devices['Pixel 5'] } },
            // { name: 'Mobile Safari', use: { ...devices['iPhone 12'] } },
            { name: 'Microsoft Edge', use: { channel: 'msedge' } },
            { name: 'Google Chrome', use: { channel: 'chrome' } }
        ])
    ],
    webServer: {
        command: 'bun run e2e-deps',
        port: 18765,
        timeout: 30 * 1000,
        reuseExistingServer: false
    }
}

export default config
