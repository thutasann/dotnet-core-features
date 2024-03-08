/**
 * Interview Questions and Answers
 */
export class Interviews {
    /**
     * Get Second Largest From Array
     */
    public getSecondLargest(arr: number[]): number {
        let largest: number = Number.NEGATIVE_INFINITY
        let secondLargest: number = Number.NEGATIVE_INFINITY

        for (let i = 0; i < arr.length; i++) {
            if (arr[i] > largest) {
                console.log('if arr[i]', arr[i])
                secondLargest = largest
                largest = arr[i]
            } else if (arr[i] !== secondLargest && arr[i] > secondLargest) {
                console.log('else if arr[i]', arr[i])
                secondLargest = arr[i]
            }
        }

        return secondLargest
    }

    /**
     * Remove Duplicates
     */
    public RemoveDuplicates(nums: number[]): number[] {
        if (nums.length === 0) return []

        for (let i = 0; i < nums.length - 1; i++) {
            if (nums[i] === nums[i + 1]) {
                nums.splice(i + 1, 1)
                i--
                console.log('i ', i)
            }
        }

        return nums
    }

    /**
     * Rotate Array By `K` size
     */
    public RotateArrayByK(nums: number[], k: number): number[] {
        let size = nums.length
        console.log('k', k)
        console.log('size', size)

        if (k > size) {
            k = k % size
            console.log('k > size =>', k)
        }

        const rotated = nums.splice(size - k, size) // => nums.splice(4, 7)
        nums.unshift(...rotated)

        return nums
    }

    /**
     * Sum of a Number
     */
    public SumOfNumber(): void {
        console.log('------>> Sum of a Number (Interview)')
        let number = 234
        let temp
        let sumofNum = 0

        // @ts-ignore
        while (number !== 0) {
            temp = number % 10
            number /= 10
            sumofNum += Math.floor(temp)
        }
        console.log('sumofNum', sumofNum)
    }

    /**
     * Reverse String
     */
    public ReverseString(): void {
        console.log('------>> Reverse String (Interview)')
        const sourceString = 'abcdefg'
        let reverseString: string = ''

        for (let i = sourceString.length - 1; i >= 0; i--) {
            reverseString += sourceString[i]
        }
        console.log('reverseString', reverseString)
    }

    /**
     * Reverse Number
     */
    public ReverseNumber(): void {
        console.log('------>> Reverse Number (Interview)')
        let sourceNumber = 1234567
        let reverseNum = 0
        let remainder: number

        // @ts-ignore
        while (sourceNumber !== 0) {
            remainder = sourceNumber % 10 // Get the last digit
            reverseNum = reverseNum * 10 + remainder // Append the last digit to reversed number
            sourceNumber = Math.floor(sourceNumber / 10) // Remove the last digit from original number
        }
        console.log('reverseNum', reverseNum)
    }

    /**
     * Catagorize Data with `createdAt`. by Date
     */
    public CatagorizeDataByDate(arr: any[]): void {
        console.log('------>> Catagorize Data by Date (Interview)')
        let imagesByMonth: Record<string, any> = {}

        arr.forEach((image) => {
            const createdAt = new Date(image.createdAt)
            const month = createdAt.toLocaleDateString('default', { month: 'long', year: 'numeric' })

            if (!imagesByMonth[month]) {
                imagesByMonth[month] = [image]
            } else {
                imagesByMonth[month].push(image)
            }
        })

        console.log('catagorized data => ', imagesByMonth)
    }
}
