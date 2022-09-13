import { HopeThemeConfig } from '@hope-ui/solid'


export type UiState = {
    ui: {
        modal?: string
    }
}

export const globalCss = {
    body: {
        margin: '0px 2px 0px 0px',
        fontFamily: '-apple-system, BlinkMacSystemFont, "Segoe UI", "Roboto", sans-serif',
        '-webkit-font-smoothing': 'antialiased',
        '-moz-osx-font-smoothing': 'grayscale',
        display: 'flex',
        flexDirection: 'row',
        boxSizing: 'border-box',
        overflow: 'hidden',
        alignItems: 'stretch',
        alignContent: 'stretch'
    },
    html: {
        minWidth: '345px',
        minHeight: '700px',
        fontSize: '14px',
        overflow: 'hidden'
    },
    '*::-webkit-scrollbar': {
        width: '11px'
    },
    '*::-webkit-scrollbar:horizontal': {
        height: '8px'
    },
    '*::-webkit-scrollbar-track': {
        display: 'none'
    },
    '*::-webkit-scrollbar-corner': {
        display: 'none'
    },
    '*::-webkit-scrollbar-thumb': {
        background: '#555',
        opacity: '0.8',
        backgroundClip: 'content-box',
        borderLeft: '2px solid transparent'
    },
    '*::-webkit-scrollbar-thumb:hover': {
        background: '#ccc',
        backgroundClip: 'content-box',
        borderLeft: '2px solid transparent'
    },
    '#root': {
        display: 'flex',
        flex: '1'
    }
}

export const config: HopeThemeConfig = {
    initialColorMode: 'system',
    darkTheme: {
        colors: {
            bg: "$neutral3",
            text1: "$neutral11"
        }
    },
    lightTheme: {
        colors: {
            bg: "$neutral3",
            text1: "$neutral11"
        }
    }
}
