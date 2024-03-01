import { ICategory } from './utils/types'

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

/**
 * Recursive Fibonacci
 */
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
