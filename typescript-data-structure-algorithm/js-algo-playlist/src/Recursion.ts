import { ICategory, INestedObject } from './utils/types'

/**
 * # Recursion
 * - Recursion is a problem solving technique where the solution depends on solutions to smaller instances of the same problem
 * - Recursion is when a function call itselfs
 * - **Every recursion needs to have a base case - a condition to terminate the recursion.**
 * - Figure out how to break down the problem into smaller versions of the problem
 * - Identify the base case for recursion
 */
export class Recursive {}

/**
 * Recursive Ecommerce Sample
 */
export class RecursiveEcommerceSample {
    public GetTotalProducts(category: ICategory): number {
        let total = category.products || 0
        if (category.subcategories) {
            for (let subcategory of category.subcategories) {
                total += this.GetTotalProducts(subcategory)
            }
        }
        return total
    }
}

export class RecursiveFibonacci {
    /**
     * ## Recursive Fibonacci BigO
     * - Iterative way is better
     * - O(n) - Iteration
     * - O(2^n) - Recursive
     */
    public SolutionOne(n: number): number[] {
        let result: number[] = []
        for (let i = 0; i < n; i++) {
            result.push(this.RecursiveFibo(i))
        }
        return result
    }

    private RecursiveFibo(n: number): number {
        if (n < 2) return n
        return this.RecursiveFibo(n - 1) + this.RecursiveFibo(n - 2)
    }
}

export class RecursiveFactorial {
    /**
     * ### Recursive Factorial BigO
     * - O(n)
     * - n! = n * (n-1)
     */
    public SolutionOne(n: number): number {
        if (n === 0) return 1
        return n * this.SolutionOne(n - 1)
    }
}

export class RecursiveSearch {
    public SampleOne(obj: INestedObject, target: any): boolean {
        for (const key in obj) {
            if (obj.hasOwnProperty(key)) {
                if (obj[key] === target) {
                    return true // Value found
                } else if (typeof obj[key] === 'object' && !Array.isArray(obj[key])) {
                    // Recursively search nested object if it's not an array
                    if (this.SampleOne(obj[key], target)) {
                        return true // Value found in nested object
                    }
                }
            }
        }
        return false // Value not found
    }
}

export class RecursiveNestedObject {
    public FlattenNestedObject(obj: INestedObject, parentKey: string = ''): INestedObject {
        return Object.keys(obj).reduce((acc: INestedObject, key: string): INestedObject => {
            const prefixedKey = parentKey ? `${parentKey}.${key}` : key

            if (typeof obj[key] === 'object' && obj[key] !== null) {
                const flattenedChild = this.FlattenNestedObject(obj[key], prefixedKey)
                Object.assign(acc, flattenedChild)
            } else {
                acc[prefixedKey] = obj[key]
            }
            return acc
        }, {})
    }
}
