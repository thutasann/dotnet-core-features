export abstract class ForConstOfSamples {
    public static SampleOne() {
        console.log('\nFor Const Of SampleOne => ')
        const fruits = ['apple', 'banana', 'orange']
        for (const fruit of fruits) {
            console.log('fruit =>', fruit)
        }
    }

    public static SampleTwo() {
        console.log('For Const Of SampleTwo => ')
        const str = 'Hello'
        for (const value of str) {
            console.log('value => ', value)
        }
    }

    public static SampleThree() {
        console.log('For Const Of SampleThree => ')
        const mySet = new Set([1, 2, 3])
        for (const item of mySet) {
            console.log('item => ', item)
        }
    }

    public static SampleFour() {
        console.log('For Const Of SampleFour => ')
        const myMap = new Map([
            ['a', 1],
            ['b', 2],
            ['c', 3],
        ])
        for (const [key, value] of myMap) {
            console.log('key, value => ', key, value)
        }
    }

    public static SampleFive() {
        console.log('For Const Of SampleFive => ')
        const obj = { a: 1, b: 2, c: 3 }
        for (const [key, value] of Object.entries(obj)) {
            console.log(`${key}: ${value}`)
        }
    }

    public static SampleSix() {
        console.log('For Const Of SampleSix (Generator) => ')

        function* generator() {
            yield 1
            yield 2
            yield 3
        }

        for (const value of generator()) {
            console.log('value => ', value)
        }
    }
}
