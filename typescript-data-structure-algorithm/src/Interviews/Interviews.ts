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
}
