(async () => {
    console.log("inside plugin script start")
    const src_js = chrome.runtime.getURL('./tictactoe_spiral/assets/extension_content_script.js')
    const _contentScript = await import(src_js)

    const src_css = chrome.runtime.getURL('./tictactoe_spiral/assets/App.css')
    document.head.innerHTML += '<link rel="stylesheet" href="' + src_css + '">'

    // contentScript.main()

    console.log("inside plugin script end")
})()
