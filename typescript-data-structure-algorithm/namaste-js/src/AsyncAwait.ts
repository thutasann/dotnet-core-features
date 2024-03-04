/**
 * # Async/Await
 * - async is a keyword that is used before a function to create async function
 * - await is a keyword that can only be used inside a async function
 * @link
 * [Asyn Await from Namaste Javascript](https://www.youtube.com/watch?v=6nv3qy3oNkc&list=PLlasXeu85E9eWOpw9jxHOQyGMRiBZ60aX&index=6)
 */
export class AsyncAwait {
    public async SampleOne() {
        const promiseString = new Promise<string>((resolve, reject) => {
            setTimeout(() => {
                resolve('Promise one is resolved!')
            }, 10000)
        })

        const promiseStringTwo = new Promise<string>((resolve, reject) => {
            setTimeout(() => {
                resolve('Promise two is resolved!')
            }, 5000)
        })

        /** Async await approach
         * - After seconds, we get the normal log and promise resolved value together.
         * - code was waiting promiseString at `await` line.
         * - js engine was waiting for promise to be resolved.
         */
        async function handlePromise() {
            console.log('Result that is printed quickly')
            const val = await promiseString
            console.log('Namaste JavaScript (async await)')
            console.log('Async Await val =>', val)

            const val2 = await promiseStringTwo
            console.log('Namaste JavaScript Two (async await)')
            console.log('Async await val 2 => ', val2)
        }
        handlePromise()

        /** .then() Approach
         * - js engine wil not wait for the promise to be resolved.
         * - it goes to the next line.
         */
        // function getData() {
        //     promiseString.then((res) => console.log('(.then()) val => ', res))
        //     console.log('Namaste JavaScript (.then())')
        // }
        // getData()
    }
}
