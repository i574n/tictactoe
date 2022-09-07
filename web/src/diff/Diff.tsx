import { log1221_1, log1221_2, log1221_3, log1221_4, log1221_5 } from './raw'
import { For } from 'solid-js'
import { Loader } from '../Loader'
import { Box } from '@hope-ui/solid'


// const rawFiles = [log1221_1, log1221_2, log1221_3, log1221_4, log1221_5]
const rawFiles = [log1221_1, log1221_2, log1221_3]

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

    const colors = Object.entries({
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
    })

    const lineColors = [...new Set(Object.values(processedFiles.lines).flat())].reduce((acc, line) => ({
        ...acc,
        [line]: colors.find(([key, _]) => line.includes(key))?.[1] || '#fff'
    }), {} as { [_: string]: string })

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
            Object.entries(files).reduce((acc, [fileIndex, lineIndexes]) => {
                return lineIndexes.reduce((acc, lineIndex) => ({
                    ...acc,
                    [line]: `${acc[line] || ''}F${fileIndex}L${lineIndex} `
                }), acc as { [_: string]: string | undefined })
            }, acc)
            , {})

    return (
        <Loader defaults={{ loaded: true, modal: true }}>
            <Box
                display="flex"
                flex={1}
                flexDirection="column"
                maxHeight="100vh"
                overflowY="auto"
            >
                <For each={Object.values(fileGroups)}>
                    {(file) => (
                        <Box
                            display="flex"
                            flex={1}
                            flexDirection="row"
                        >
                            <For each={Object.values(file)}>
                                {(groups) => (
                                    <Box
                                        css={{ wordBreak: "break-all" }}
                                        border="1px solid #222"
                                        display="flex"
                                        flex={1}
                                        flexDirection="column"
                                        fontFamily="monospace"
                                        fontSize={8}
                                    >
                                        <For each={groups}>
                                            {(groupLine) => (
                                                <Box
                                                    classList={{
                                                        [classes[groupLine] || '']: true
                                                    }}
                                                    color={lineColors[groupLine]}
                                                    marginTop="1px"
                                                    marginBottom="1px"
                                                >
                                                    {groupLine}
                                                </Box>
                                            )}
                                        </For>
                                    </Box>
                                )}
                            </For>
                        </Box>
                    )}
                </For>
            </Box>
        </Loader>
    )
}
