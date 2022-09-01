import { log1221_1, log1221_2, log1221_3, log1221_4 } from './raw'
import { For } from 'solid-js'
import { Loader } from '../Loader'
// @ts-ignore
import styles from "../App.module.css"


const files = [log1221_1, log1221_2, log1221_3, log1221_4]

export function Diff() {

    const process = (file: string) => {
        return file.split('\n').map(line => {
            return line
        })
    }

    const processed: {
        cache: { [_: string]: { fileIndex: number, lineIndex: number }[] },
        lines: string[][]
    } = files.reduce((acc, file, fileIndex) => {
        const lines = process(file)
        return {
            ...acc,
            cache: lines.reduce((acc, line, lineIndex) => ({
                ...acc,
                [line]: [
                    ...(acc[line] || []),
                    {
                        fileIndex,
                        lineIndex
                    }]
            }), acc.cache),
            lines: [
                ...acc.lines,
                lines
            ]
        }
    }, {
        cache: {},
        lines: []
    })

    const classes: { [_: string]: string | undefined } =
        Object.entries(processed.cache).reduce((acc, [line, indexes]) =>
            indexes.reduce((acc, { fileIndex, lineIndex }) => ({
                ...acc,
                [line]: `${acc[line] || ''}F${fileIndex}L${lineIndex} `
            }), acc as { [_: string]: string | undefined }),
            {}
        )

    const getColor = (line: string) => {
        const colors = {
            '***0> ': '#CEA056',
            '***1> ': '#9372B7',
            '***2> ': '#C1674D',
            '***3> ': '#3672CE',
            '***4> ': '#8BA361',
            '***0 ': '#90703c',
            '***1 ': '#664f80',
            '***2 ': '#874835',
            '***3 ': '#254f90',
            '***4 ': '#617243',
        }
        return Object.entries(colors)
            .find(([key]) => line.includes(key))?.[1] || '#fff'
    }

    return (
        <Loader defaults={{ loaded: true, modal: true }}>
            <div id={styles.diff}>
                <For each={processed.lines}>
                    {(lines) => (
                        <div>
                            <For each={lines}>
                                {(line) => (
                                    <div
                                        class={classes[line]}
                                        style={{
                                            color: getColor(line)
                                        }}
                                    >
                                        {line}
                                    </div>
                                )}
                            </For>
                        </div>
                    )}
                </For>
            </div>
        </Loader>
    )
}
