export abstract class DoWhileSampleOne {
    public static SampleOne() {
        console.log('Doo While Sample One ====> ')
        let count: number = 0
        do {
            console.log('Count : ', count)
            count++
        } while (count < 5)
    }
}
