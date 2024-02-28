/**
 * # Fibonacci Series
 * - Series of numbers in which each number is the sume of two preceeding numbers
 * - The first two numbers in the sequence are 0 and 1
 * -  Examples :
 * - 0, 1, 1, 2, 3, 5, 8...
 * -  0 + 1 => 1, 1 + 1 => 2, 2 + 3 => 5, 3 + 5 => 8
 * - fibonacci(2) = [0, 1]
 * - fibonacci(3) = [0, 1, 1]
 */
export class FibonacciSeries {
    /**
     * ### BigO
     * - Loop - O(n)
     * - the value of n increases the number of times
     */
    public SolutionOne(n: number): number[] {
        console.log('------>> Fibonacci Series Solution One')
        let fib = [0, 1]
        for (let i = 2; i < n; i++) {
            fib[i] = fib[i - 1] + fib[i - 2]
            console.log('fib', fib)
        }
        return fib
    }
}
