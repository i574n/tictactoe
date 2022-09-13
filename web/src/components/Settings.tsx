import Row from "./Row"
import { Radio, RadioGroup, Stack, useColorMode } from '@hope-ui/solid'
import BaseTable from "./BaseTable"


function Settings() {
    const { colorMode, toggleColorMode } = useColorMode()

    return (
        <BaseTable>
            <Row
                title="Theme"
                tdProps={{
                    padding: '5px 6px'
                }}
            >
                <RadioGroup
                    defaultValue={colorMode()}
                    onChange={() => {
                        toggleColorMode()
                    }}
                >
                    <Stack
                        direction="row"
                        spacing="$4"
                    >
                        <Radio value="dark" size="sm" colorScheme="neutral">Dark</Radio>
                        <Radio value="light" size="sm" colorScheme="neutral">Light</Radio>
                    </Stack>
                </RadioGroup>
            </Row>
        </BaseTable>
    )
}

export default Settings
