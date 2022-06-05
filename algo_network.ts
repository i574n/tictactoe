import buffer from "buffer"
import algosdk from "algosdk"


// cell
export var encode = (value: string) => {
    return new Uint8Array(buffer.Buffer.from(value, "base64"))
}

// cell
export var newClient = (token: string, server: string, port: number) => {
    return new algosdk.Algodv2(token, server, port)
}

// cell
export var deployApplication = async (
    client: algosdk.Algodv2,
    address: string,
    privateKey: string,
    applicationStartTeal: string,
    clearProgramTeal: string,
    options = {
        numGlobalByteSlices: 0,
        numGlobalInts: 0,
        numLocalByteSlices: 0,
        numLocalInts: 0
    }) => {
    try {
        const suggestedParams = await client.getTransactionParams().do()
        suggestedParams.flatFee = true
        suggestedParams.fee = 1000

        const applicationStartCompiled = await client.compile(applicationStartTeal).do()
        const clearProgramCompiled = await client.compile(clearProgramTeal).do()

        const txn = algosdk.makeApplicationCreateTxnFromObject({
            suggestedParams,
            from: address,
            onComplete: algosdk.OnApplicationComplete.NoOpOC,
            approvalProgram: encode(applicationStartCompiled.result),
            clearProgram: encode(clearProgramCompiled.result),
            ...options
        })

        const txnSigned = txn.signTxn(encode(privateKey))
        const { txId } = await client.sendRawTransaction(txnSigned).do()
        const transactionResponse = await algosdk.waitForConfirmation(client, txId, 5)
        const appId = transactionResponse["application-index"]

        return {
            suggestedParams,
            applicationStartCompiled,
            clearProgramCompiled,
            txn,
            txnSigned,
            txId,
            transactionResponse,
            appId
        }
    } catch (e) {
        console.log(`algo_network.deployApplication() rethrowing error: ${e}`)
        throw e
    }
}
