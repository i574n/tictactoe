chrome.runtime.onInstalled.addListener(function () {
  console.log('chrome.runtime.onInstalled')
  chrome.contextMenus.create({
    "id": "sampleContextMenu",
    "title": "Sample Context Menu",
    "contexts": ["selection"]
  })
})

chrome.tabs.onUpdated.addListener((tabId, info, tab) => {
  if (info.url || info.status === 'loading') {
    const url = info.url || tab.pendingUrl || tab.url
    console.log('chrome.tabs.onUpdated', 'url:', url) // prints in the *background* console
  }
  console.log('chrome.tabs.onUpdated', 'tabId:', tabId, 'info:', info, 'tab:', tab)
})

chrome.webNavigation.onCompleted.addListener(
  (a, b, c) => {
    console.info("chrome.webNavigation.onCompleted", 'a:', a, 'b:', b, 'c:', c)
  },
  { url: [{ urlMatches: 'https://testnet.algoexplorer.io' }] }
)
