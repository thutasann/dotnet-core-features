export class FunctionsBasic {
    /**
     * Generator Function
     */
    public GeneratorFunction(): void {
        console.log('------>> Generator Function Sample ')
        function* generateNumbers(): Generator<number> {
            let i: number = 0
            while (true) {
                yield i++
            }
        }
        const generator: Generator<number> = generateNumbers()
        console.log(' generator.next().value', generator.next().value)
        console.log(' generator.next().value', generator.next().value)
        console.log(' generator.next().value', generator.next().value)
    }

    /**
     * Generator Function RealLife Sample
     */
    public GeneratorFunctionRealLifeSample(): void {
        console.log('------>> Generator Function RealLife Sample ')

        /** Fetch users Promise */
        async function fetchUsers(page: number, pageSize: number): Promise<string[]> {
            await new Promise((resolve) => setTimeout(resolve, 1000))
            const users: string[] = []
            for (let i = 0; i < pageSize; i++) {
                users.push(`User ${page * pageSize + i}`)
            }
            return users
        }

        /** Async Generator function */
        async function* getUsersAsync(): AsyncGenerator<string[], void, unknown> {
            let page = 0
            let pageSize = 5

            while (true) {
                const users = await fetchUsers(page, pageSize)
                yield users

                if (users.length < pageSize) {
                    break // stop iterating if no more data;
                }

                page++
            }
        }

        ;(async () => {
            for await (const userChunks of getUsersAsync()) {
                console.log('Received chunk of users: ', userChunks)
            }
        })()
    }

    /**
     * Immediately Invoke Functin Sample
     */
    public ImmediatelyInvokeSample(): void {
        ;(function () {
            console.log('------>> Immediately Invoke Functin Sample ')
        })()
    }
}
