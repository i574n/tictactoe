/* @refresh reload */
import "solid-devtools"
import { render } from 'solid-js/web'
import App from './App'


if(!process.env.GITHUB_RUN_ID) {
  window.onbeforeunload = () => "window.onbeforeunload"
}

render(() => <App />, document.getElementById('root') as HTMLElement)
