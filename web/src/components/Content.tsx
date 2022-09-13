import Row from "./Row"
import * as util from "../../../lib_ts/util"
import { Table, Tbody, Tr, Td } from '@hope-ui/solid'
import { Diff } from "../diff/Diff"
import Chain from "./Chain"
import Counter from "./Counter"
import Database from "./Database"
import Links from "./Links"
import Settings from "./Settings"
import ChainStatus from "./ChainStatus"
import ChainDeploy from "./ChainDeploy"


function Content() {
    return (
        <Table
            striped="odd"
            display="flex"
            overflow="auto"
            flex={1}
            maxWidth="100vw"
            height="100vh"
            padding="1px"
            flexDirection="column"
            backgroundColor="$bg"
            fontSize="$sm"
            color="#eeffff"
        >
            <Tbody>
                <Row
                    title="Links"
                >
                    <Links />
                </Row>
                <Row />
                <Row
                    title="Settings"
                >
                    <Settings />
                </Row>
                <Row />
                <Row
                    loader={false}
                    title="Chain"
                >
                    <Chain />
                </Row>
                <Row />
                <Row
                    id="db"
                    loader={false}
                    title="Database"
                >
                    <Database />
                </Row>
                <Row />
                <Row
                    title="Counter"
                >
                    <Counter />
                </Row>
                {!!util.env.GITHUB_RUN_ID
                    ? <>
                        <Row
                            title="Status"
                        >
                            <ChainStatus />
                        </Row>
                        <Row
                            title="Deploy"
                        >
                            <ChainDeploy />
                        </Row>
                    </>
                    : <></>}
                {/* {!util.IS_TEST && !util.env.GITHUB_RUN_ID
                    ? <>
                        <Row />
                        <Row title="Diff">
                            <Diff />
                        </Row>
                    </>
                    : <></>} */}
            </Tbody>
        </Table>
    )
}

export default Content
