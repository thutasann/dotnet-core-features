/**
 * # Async/Await
 * - async is a keyword that is used before a function to create async function
 * - await is a keyword that can only be used inside a async function
 */
export class AsyncAwait {
    public async SampleOne() {
        const promiseString = new Promise<string>((resolve, reject) => {
            resolve('Promise is resolved!')
        })

        async function GetData(): Promise<string> {
            return promiseString
        }
        const res = await GetData()
        console.log('res =>', res)

        async function handlePromise() {
            const val = await promiseString
            console.log('handlePromise val =>', val)
        }
        handlePromise()
    }
}
