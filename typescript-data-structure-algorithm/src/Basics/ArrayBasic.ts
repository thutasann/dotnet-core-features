import { UtilFunctions } from '../utils'

export class ArrayBasic {
    private utils = new UtilFunctions()

    /**
     * Slice Usage Sample
     */
    public SliceSample(): void {
        console.log('------>> Array Slice Sample')
        const array = ['apple', 'banana', 'cheery']
        const slicedArr = array.slice(0, 1)
        console.log('slicedArr', slicedArr)

        const animals = ['ant', 'bison', 'camel', 'duck', 'elephant']
        const slicedAnimals = animals.slice(2, 4)
        console.log('slicedAnimals', slicedAnimals)
    }

    /**
     * Splice Usage Sample
     */
    public SpliceSample(): void {
        console.log('------>> Array Splice Sample')
        const originalArr = ['Apple', 'Banana', 'Cherry', 'Date', 'Fig']
        const splicedArray = originalArr.splice(1, 2, 'new fruit')
        console.log('splicedArray', splicedArray)
        console.log('originalArr', originalArr)
    }

    /**
     * Fill And Find Index
     */
    public FillAndFindIndex(): void {
        console.log('------>> Fill and FindIndex Sample')
        const FILLARR = [1, 2, 3, 4, 5]
        const foundIndex = FILLARR.findIndex((item) => item === 2)
        console.log('foundIndex', foundIndex)

        FILLARR.fill(69, 2)
        console.log('FILLARR', FILLARR)
    }

    /**
     * Flat And Reverse Sample
     */
    public FlatAndReverse(): void {
        console.log('------>> Flat and Reverse Sample')
        const FLATARR: (number | (number | number[])[])[] = [1, [12, 23, 55], [35, 56], 7, 3, [[4, 5], 6]]
        const flattedArr = FLATARR.flat(2)
        console.log('flattedArr', flattedArr)
        const reversedArr = flattedArr.reverse()
        console.log('reversedArr', reversedArr)
    }

    /**
     * Split Array Into Chunks
     */
    public SplitArrayIntoChunks(): void {
        console.log('------>> SplitArrayIntoChunks Sample')
        const strArr = this.utils.CreateArrayOfString(20, 5)

        function chunkArray(array: string[], chunkSize: number): string[][] {
            const chunks: string[][] = []

            for (let i = 0; i < array.length; i += chunkSize) {
                chunks.push(array.slice(i, i + chunkSize))
            }
            return chunks
        }

        const splittedChunks = chunkArray(strArr, 2)
        console.log('splittedChunks', splittedChunks)
    }

    /**
     * While Sample
     */
    public WhileSample(): void {
        console.log('------>> While Sample')
        type Stock = {
            [key: string]: number
        }

        let stock: Stock = {
            cola: 3,
            lemonade: 3,
            water: 3,
        }

        function DispenseBeverage(beverage: string): void {
            if (stock[beverage] && stock[beverage] > 0) {
                console.log(`Dispensing ${beverage}...`)
                stock[beverage]--
            } else {
                console.log(`Sorry. ${beverage} is out of stock`)
            }
        }

        while (Object.values(stock).some((quantity) => quantity > 0)) {
            DispenseBeverage('cola')
            DispenseBeverage('lemonade')
            DispenseBeverage('water')
        }
        console.log('All beverages are sold out')
    }
}
