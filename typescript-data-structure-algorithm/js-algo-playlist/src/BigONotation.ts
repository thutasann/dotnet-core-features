/**
 * # BigO Notation
 * The worst case complexity of an algorithm is represented using the Big-O notation.
 * It describes the complexity of an algorithm using algebraic terms.
 *
 * It has two importants characteristics
 * - it is expressed in terms of the input
 * - it focuses on the bigger picture without getting caught up in the minute details
 */
export class BigONotation {}

/**
 * ## Time Complexity
 * Count the number of times a statement executes based on the input size
 * - It focuses on the bigger picture without getting caught up in the minute details
 */
export class TimeComplexity {
    /**
     *  O(n) - Linear Time complexity
     */
    SampleOne(n: number): number {
        let total = 0
        for (let i = 0; i <= n; i++) {
            total += i
        }
        return total
    }

    /**
     *  O(1) - Constant Time Complexity
     */
    SampleTwo(n: number): number {
        return (n * (n + 1)) / 2
    }

    /**
     * O(n^2) - Quadratic
     */
    SampleThree(n: number): void {
        for (let i = 0; i <= n; i++) {
            for (let j = i + 1; j <= n; j++) {
                // some code...
            }
        }
    }

    /**
     * O(n^3) - Cubic
     */
    SampleFour(n: number): void {
        for (let i = 0; i <= n; i++) {
            for (let j = i + 1; j <= n; j++) {
                for (let k = j + 1; k <= n; k++) {
                    // some code
                }
            }
        }
    }
}

/**
 * ## Space Complexity
 * - if the algorithm does not need extra memory or the memory needed do not depend on the input size, the space comlexity is constant => O(1) - Constant complexity
 * - Example - sorting algorithms which sort within the array without utilizing additional arrays
 * - if extra space needed grows as the input size grows => O(n) - Linear complexity
 * - if extra space needed grows but not at the same rate as the input size => O(logn) - Logarithmic
 */
export class SpaceComplexity {}

/**
 * ## Object BigO Notation
 * - Insert - O(1)
 * - Remove - O(1)
 * - Access - O(1)
 * - Search - O(1)
 * - Object.keys() - O(n)
 * - Object.values() - O(n)
 */
export class ObjectBigONotation {}

/**
 * ## Array BigO Notation
 * - Insert / remove at **end** - O(1)
 * - Insert / remove at **beginning** - O(n) because index has to be reset for every remaining element in the array
 * - Access - O(1)
 * - Searching - O(n)
 * - Push/Pop - O(1)
 * - Shift/Unshift/concat/slice/splice - O(n)
 * - forEach/map/filter/reduce - O(n)
 */
export class ArrayBigONotation {}
