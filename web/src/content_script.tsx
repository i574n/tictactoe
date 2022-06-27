import { render } from 'solid-js/web'
import App from './App'

const main = () => {
    const interval = setInterval(() => {
        const els = document.querySelectorAll('.paper-card-intern > .paper-value')

        console.log('readyState:', document.readyState, 'els:', els)

        if (document.readyState === 'complete') {
            if (els.length == 3) {
                clearInterval(interval)
                render(() => <App />, document.querySelector('.AE-footerContainer') as any)
            }
        }
    }, 100)
}

main()
