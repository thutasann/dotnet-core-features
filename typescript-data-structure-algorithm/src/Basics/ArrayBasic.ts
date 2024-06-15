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

    /**
     * Unshift Sample
     */
    public UnshiftSample(): void {
        console.log('------>> Unshift Sample')

        let todoList: string[] = ['Buy groceries', 'Pay bills', 'Finish homework']
        function AddTaskToTop(task: string) {
            todoList.unshift(task)
        }

        AddTaskToTop('Call mom')
        console.log('todoList ', todoList)
    }

    /**
     * Reduce Sample
     */
    public ReduceSample(): void {
        console.log('------>> Reduce Sample')
        const numArras: number[] = [1, 2, 3, 4, 5, 6, 7, 8]
        const reducedArr = numArras.reduce((acc, item) => {
            return acc + item
        }, 0)
        console.log('reducedArr', reducedArr)

        // -------- Remove duplicate items from array.
        const ageGroup: number[] = [18, 21, 1, 51, 18, 21, 5, 18, 7, 10]
        const uniqueAgeGroup: number[] = ageGroup.reduce(function (acc: number[], currentValue: number) {
            if (acc.indexOf(currentValue)) {
                acc.push(currentValue)
            }
            return acc
        }, [])
        console.log('(Reduce) uniqueAgeGroup ', uniqueAgeGroup)

        // -------- Get max date;
        const DATES = [
            '01/08/2022',
            '02/08/2022',
            '04/08/2022', // THis is the most recent date
            '04/07/2022',
        ].map((val: string) => new Date(val))

        const maxDate = DATES.reduce((max, d) => {
            return d > max ? d : max
        })
        console.log('(Reduce) maxDate', maxDate)
    }

    /**
     * In Operator
     */
    public InOperatorSample(): void {
        console.log('------>> `In` Operator Sample')
        const person = {
            name: 'John',
            age: 30,
            city: 'New York',
        }
        console.log('name' in person) // true;
        console.log('gender' in person) // false

        const arr = [1, 2, 3]
        console.log('1 in car ', 1 in arr) // arr[1] exists
        console.log('length in arr', 'length' in arr) // arr has 'length' property
        console.log(arr.hasOwnProperty(1)) // true '1' is an own property
        console.log(arr.hasOwnProperty('length')) // true, 'length' is an own property
    }

    /**
     * To Spliced Sample
     */
    public ToSplicedSample(): void {
        console.log('------>> To Spliced Sample')
        // Original array
        const originalArray = [1, 2, 3, 4, 5]

        // Using toSpliced to create a new array with elements removed
        const removedArray = originalArray.toSpliced(2, 2) // Start at index 2, remove 2 elements
        console.log('Original Array:', originalArray) // Output: [1, 2, 3, 4, 5]
        console.log('Removed Array:', removedArray) // Output: [1, 2, 5]

        // Using toSpliced to create a new array with elements replaced
        const replacedArray = originalArray.toSpliced(1, 2, 9, 10) // Start at index 1, remove 2 elements, add 9, 10
        console.log('Replaced Array:', replacedArray) // Output: [1, 9, 10, 4, 5]

        // Using toSpliced to create a new array with elements added
        const addedArray = originalArray.toSpliced(3, 0, 6, 7) // Start at index 3, remove 0 elements, add 6, 7
        console.log('Added Array:', addedArray) // Output: [1, 2, 3, 6, 7, 4, 5]
    }
}
