export class LeetCodeSolutions {
    /**
     * Swap Number
     */
    public SwapNumber(firstNum: number, secondNum: number) {
        console.log('------>> Swap Number (LeetCodes) ')
        let temp: number
        temp = firstNum
        firstNum = secondNum
        secondNum = temp
        console.log(`After Swaping, firstNum is ${firstNum} and secondNum is ${secondNum}`)
    }

    /**
     * Two Sum Solution
     */
    public TwoSum(nums: number[], target: number): number[] {
        console.log('------>> Two Sum (LeetCodes) ')
        const map: { [key: number]: number } = {}

        for (let i = 0; i < nums.length; i++) {
            const complement = target - nums[i] // 18 - 2
            map[nums[i]] = i
            if (complement in map) {
                return [map[complement], i]
            }
        }
        return []
    }

    /**
     * Binary Search (Searching...)
     */
    public BinarySearch(nums: number[], target: number): number {
        console.log('------>> Binary Search (LeetCodes) ')
        let left = 0
        let right = nums.length - 1
        let mid: number

        while (left <= right) {
            mid = Math.floor((left + right) / 2)
            if (nums[mid] === target) {
                console.log('same')
                return mid
            } else if (nums[mid] < target) {
                return (left = mid + 1)
            } else {
                return (right = mid - 1)
            }
        }
        return -1
    }

    /**
     * Linear Search (Searching...)
     */
    public LinearSearch(nums: number[], target: number): number {
        console.log('------>> Linear Search (LeetCodes) ')
        for (let i = 0; i < nums.length; i++) {
            if (nums[i] === target) {
                return i
            }
        }
        return -1
    }

    /**
     * Bubble Sort (Sorting...)
     */
    public BubbleSort(nums: number[]): number[] {
        console.log('------>> Bubble Sort (LeetCodes) ')
        let temp: number
        for (let i = 0; i < nums.length; i++) {
            for (let j = i + 1; j < nums.length; j++) {
                if (nums[i] > nums[j]) {
                    temp = nums[j]
                    nums[j] = nums[i]
                    nums[i] = temp
                }
            }
        }
        return nums
    }

    /**
     * Selection Sort (Sorting...)
     */
    public SelectionSort(nums: number[]): number[] {
        console.log('------>> Selection Sort (LeetCodes) ')
        let minIndex = 0
        let minValueFound = 0

        for (let mainIndex = 0; mainIndex < nums.length; mainIndex++) {
            minIndex = mainIndex

            for (let remainingIndex = mainIndex + 1; remainingIndex < nums.length; remainingIndex++) {
                if (nums[remainingIndex] < nums[minIndex]) {
                    minIndex = remainingIndex
                }
            }

            minValueFound = nums[minIndex]
            nums[minIndex] = nums[mainIndex]
            nums[mainIndex] = minValueFound
        }

        return nums
    }

    /**
     * Insertion Sort
     */
    public InsertionSort(nums: number[]): number[] {
        console.log('------>> Insertion Search (LeetCodes) ')
        for (let i = 0; i < nums.length; i++) {
            let current = nums[i]
            let j = i - 1
            while (j >= 0 && nums[j] > current) {
                nums[j + 1] = nums[j]
                j--
            }
            nums[j + 1] = current
        }
        return nums
    }
}
