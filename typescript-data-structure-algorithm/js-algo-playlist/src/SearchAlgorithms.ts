/**
 * # Search Algorithm Fundamentals
 * @description
 * Those are the fundamentals concepts frequently used in Search Algorithms
 */
export class SearchAlgorithmFundamentals {
    /** Iterating Array */
    public IteratingArray(): void {
        const arr = [1, 2, 3, 4, 5]
        for (let i = 0; i < arr.length; i++) {
            console.log('Iterating Array => ', arr[i])
        }
    }

    /** Find Middle Element */
    public FindMiddleElement(): void {
        function findMiddle(arr: number[]): number {
            if (arr.length === 0) return -1
            const middleIndex = Math.floor(arr.length / 2)
            return arr[middleIndex]
        }
        const arr = [1, 2, 3, 4, 5]
        console.log('middle element => ', findMiddle(arr))
    }

    /** Swap Elements Through Array */
    public SwapThroughArray(): void {
        function swapAdjacentNumbers(arr: number[]) {
            for (let i = 0; i < arr.length - 1; i += 2) {
                // swap elements at even indices with elements at odd indices.
                const temp = arr[i]
                arr[i] = arr[i + 1]
                arr[i + 1] = temp
            }
            return arr
        }
        const array = [1, 2, 3, 4, 5, 6]
        console.log('swapped adjacent numbers => ', swapAdjacentNumbers(array))
    }

    /** Swap elements from End to First */
    public SwapFromEndToFirst(): void {
        function swapArray(arr: number[]): number[] {
            const length = arr.length
            for (let i = 0; i < Math.floor(length / 2); i++) {
                const temp = arr[i] // [1,2,3]
                arr[i] = arr[length - 1 - i] // [6,5,4]
                arr[length - 1 - i] = temp
            }
            return arr
        }

        const arr = [1, 2, 3, 4, 5, 6]
        console.log('Swapped Array', swapArray(arr))
    }

    /** Find middle index and split array */
    public findMiddleAndSplit(): void {
        function findMiddleAndSplit(arr: number[]) {
            console.log('find middle and search =>')
            const middleIndex = Math.floor(arr.length / 2)
            const leftArray = arr.slice(0, middleIndex)
            const rightArray = arr.slice(middleIndex + 1)
            return {
                middleElement: arr[middleIndex],
                leftArray,
                rightArray,
            }
        }

        const array = [1, 2, 3, 4, 5, 6]
        const { middleElement, leftArray, rightArray } = findMiddleAndSplit(array)
        console.log('middleElement', middleElement)
        console.log('leftArray', leftArray)
        console.log('rightArray', rightArray)
    }
}

/**
 * # Linear Search
 * - Given array of `n` elements and target element `t`.
 * - Find the index of `t` in the array,
 * - Return -1 if the target element is not found.
 * @example
 * - start at the first element in the array and move towards to the last.
 * - at each element though, check if the element is equal to the target element.
 */
export class LinearSearch {
    /**
     * ### Linear Search BigO
     * - O(n)
     */
    public SolutionOne(array: number[], target: number): number {
        for (let i = 0; i < array.length; i++) {
            if (array[i] === target) {
                return i
            }
        }
        return -1
    }
}

/**
 * # Binary Search
 * - Given a **sorted** array of `n` elements and target element `t`.
 * - Find the index of `t` in the array,
 * - Return -1 if the target element is not found.
 * @description
 * - binary search only works on a sorted arry
 * @example
 * - find the middle element in the array. if target is equal to the middle element, return the middle element index
 * - if target is less than the middle element, binary search left half of the array.
 * - if target is greater than the middle element, binary search right half of the array.
 * - run the loop as the leftIndex is left than or equal to rightIndex
 */
export class BinarySearch {
    /**
     * ### BinarySearch BigO
     * - O(logn)
     */
    public SolutionOne(array: number[], target: number): number {
        let leftIndex = 0
        let rightIndex = array.length - 1
        while (leftIndex <= rightIndex) {
            let middleIndex = Math.floor((leftIndex + rightIndex) / 2)
            if (array[middleIndex] === target) {
                return middleIndex
            } else if (target < array[middleIndex]) {
                rightIndex = middleIndex - 1
            } else {
                leftIndex = middleIndex + 1
            }
        }
        return -1
    }
}

/**
 * # Recursive Binary Search
 */
export class RecursiveBinarySearch {
    public SolutionOne(array: number[], target: number): number {
        return this.search(array, target, 0, array.length - 1)
    }

    private search(array: number[], target: number, leftIndex: number, rightIndex: number): number {
        if (leftIndex > rightIndex) return -1
        let middleIndex = Math.floor((leftIndex + rightIndex) / 2)
        if (target === array[middleIndex]) return middleIndex
        if (target < array[middleIndex]) {
            return this.search(array, target, leftIndex, middleIndex - 1)
        } else {
            return this.search(array, target, middleIndex + 1, rightIndex)
        }
    }
}
