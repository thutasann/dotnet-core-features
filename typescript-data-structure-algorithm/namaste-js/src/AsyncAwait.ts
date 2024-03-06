/**
 * # Async/Await
 * - async is a keyword that is used before a function to create async function
 * - await is a keyword that can only be used inside a async function
 * @link
 * [Asyn Await from Namaste Javascript](https://www.youtube.com/watch?v=6nv3qy3oNkc&list=PLlasXeu85E9eWOpw9jxHOQyGMRiBZ60aX&index=6)
 * @example
 * ## Interviews
 * -
 */
export class AsyncAwait {
    API_URL: string = 'https://api.github.com/users/thutasann'

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

        /** # Async await approach
         * - After seconds, we get the normal log and promise resolved value together.
         * - code was waiting promiseString at `await` line.
         * - js engine was waiting for promise to be resolved.
         * - our async function is watigin for all the promises to ge completeed
         * @description
         * - when this function will be executed, it will go line by line
         * - javascript is synchronous single threaded language
         * - Initially, Call Stack is empty.
         * - Call Stack is the place where every function works
         * - As soon as the `handlePromise` function is called, this will come inside the call stak
         * - there are two promises which needs to be resolved
         * - These promises are taking their own time in resolution
         * - They will be resolved at some point of time after some time.
         * - These async promises are registered
         * @example
         * - it will see `cosnole.log('result is...)` first.
         * - it will see await P1 over there.
         * - JS doesn't wait for anything and this handlePromise function's execution will suspend for the time.
         * - And this will move out of call stack
         * - It will not block the main thread
         * - It will wait till the `p1` is resolved.
         * - Once `p1` is resolved after 5 seconds, then only in it will move ahead.
         * - After 5 seconds, that handlePromise function will again come inside the call stack.
         * - Then, this function will start executing where it actually left
         * - when it reaches `p2`, it will again suspend the execution and it will not block the call stack
         * - once the `p2` is resolved after 10 seconds, `handlePromise` will again come back to call stack
         * @summary
         * - `handlePromise` will not keep waiting in the call stack
         * - JS Engine isn't waiting it is quickly executing everything
         * - but `handlePromise` will suspend the execution of that promise
         * - see the promise, if still not resolved, move out of the stack and wait for the promise to be resolved. ⭐️
         * - after resolved, if see another promise and do the same thing but if `p2` is already resolved, it will be quickly printed. ⭐️
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
    }
}
