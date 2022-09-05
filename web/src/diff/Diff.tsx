import { log1221_1, log1221_2, log1221_3, log1221_4 } from './raw'
import { For } from 'solid-js'
import { Loader } from '../Loader'
// @ts-ignore
import styles from "../App.module.css"


const rawFiles = [log1221_1, log1221_2, log1221_3, log1221_4]

type LineId = string
type FileIndex = number
type LineIndex = number



export function Diff() {
    const process = (file: string) => {
        return file.split('\n').map(line => {
            return line
        })
    }

    const processedFiles: {
        cache: { [_: LineId]: { [_: FileIndex]: LineIndex[] } },
        lines: { [_: FileIndex]: string[] }
    } = rawFiles.reduce((acc, file, fileIndex) => {
        const lines = process(file)
        return {
            ...acc,
            cache: lines.reduce((acc, line, lineIndex) => ({
                ...acc,
                [line]: {
                    ...acc[line],
                    [fileIndex]: [
                        ...(acc[line] || {})[fileIndex] || [],
                        lineIndex
                    ]
                }
            }), acc.cache),
            lines: {
                ...acc.lines,
                [fileIndex]: lines
            }
        }
    }, {
        cache: {},
        lines: {}
    })

    const lineSet = new Set(
        Object.entries(processedFiles.cache)
            .filter(([_, files]) =>
                Object.keys(files).length === rawFiles.length
                && Object.values(files).every(file => file.length === 1)
            ).map(([line, _]) => line)
    )


    type GroupIndex = number

    const fileGroups: { [_: GroupIndex]: { [_: FileIndex]: string[] } } =
        Object.keys(processedFiles.lines).reduce((acc, fileIndex) => {
            const [_, result] = processedFiles.lines[fileIndex as any as FileIndex]
                .reduce(([currentGroup, acc], line, _lineIndex) => {
                    const group = currentGroup + (lineSet.has(line) ? 1 : 0)
                    return [
                        group,
                        {
                            ...acc,
                            [group]: {
                                ...acc[group],
                                [fileIndex]: [
                                    ...(acc[group] || {})[fileIndex as any as FileIndex] || [],
                                    line
                                ]
                            }
                        }
                    ]
                }, [0, acc] as [number, { [_: GroupIndex]: { [_: FileIndex]: string[] } }])
            return result
        }, {} as { [_: GroupIndex]: { [_: FileIndex]: string[] } })


    const classes: { [_: string]: string | undefined } =
        Object.entries(processedFiles.cache).reduce((acc, [line, files]) =>
            Object.entries(files).reduce((acc, [fileIndex, lineIndex]) => ({
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
                <For each={Object.values(fileGroups)}>
                    {(file) => (
                        <div>
                            <For each={Object.values(file)}>
                                {(groups) => (
                                    <div class={styles.file}>
                                        <For each={groups}>
                                            {(groupLine) => (
                                                <div
                                                    classList={{
                                                        [styles.line]: true,
                                                        [classes[groupLine] || '']: true
                                                    }}
                                                    style={{
                                                        color: getColor(groupLine)
                                                    }}
                                                >
                                                    {groupLine}
                                                </div>
                                            )}
                                        </For>
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
