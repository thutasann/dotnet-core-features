export abstract class SetSample {
    public static SampleOne() {
        console.log('\nSet Sample One: ')
        let mySet = new Set<number>()
        mySet.add(1)
        mySet.add(2)
        mySet.add(1) // Duplicates are automatically removed

        console.log('mySet.size', mySet.size)

        mySet.forEach((v) => {
            console.log('value', v)
        })
    }
}
