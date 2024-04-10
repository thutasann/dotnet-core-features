/**
 * The primary difference between the while loop and do-while loop is that
 * - the while loop evaluates the condition before the code block is executed,
 * - while the do-while loop evaluates the condition after the code block is executed.
 */
class Difference {}

export abstract class DoWhileSampleOne {
    public static SampleOne() {
        console.log('\nDo While Sample One ====> ')
        let count: number = 0
        do {
            console.log('Count : ', count)
            count++
        } while (count < 5)
    }
}

export abstract class NestedWhileLoopSample {
    public static SampleOne() {
        console.log('\nNested While Sample One ====> ')
        let i = 1
        while (i <= 3) {
            let j = 1
            while (j <= 3) {
                console.log(i + ' ' + j)
                j++
            }
            i++
        }
    }

    public static WhileBreak() {
        console.log('\nWhile Break ====> ')
        let i = 1
        while (i <= 5) {
            if (i === 3) break
            console.log('i => ', i)
            i++
        }
    }
}
