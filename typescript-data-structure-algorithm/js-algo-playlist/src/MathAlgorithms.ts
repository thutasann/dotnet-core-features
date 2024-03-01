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
     * ### Fibonacci BigO
     * - Loop - O(n)
     * - the value of n increases the number of times
     */
    public SolutionOne(n: number): number[] {
        let fib = [0, 1]
        for (let i = 2; i < n; i++) {
            fib[i] = fib[i - 1] + fib[i - 2]
        }
        return fib
    }
}

/**
 * # Factoral Of A Number
 * Multiply a series of descending natural numbers. (Largest to smalles) <br/>
 *  Fact: Zero factorial is 1
 *  1 factorial = 1 * 1 = 1
 *  2 factorial = 2 * 1 = 2
 *  3 factorial = 3 * 2 * 1 = 6
 *  4 factorial = 4 * 3 * 2 * 1 = 24
 *  5 factorial = 5 * 4 * 3 * 2 * 1 = 120
 */
export class FactorialNumber {
    /**
     * ### Factorial BigO
     * - Loop - O(n)
     */
    public SolutionOne(n: number): number {
        let factorial = 1
        for (let i = 2; i <= n; i++) {
            factorial *= i
        }
        return factorial
    }
}

/**
 * # PrimeNumber
 * - Prime numbers are numbers which are divisible by 1 and by itself.
 * - 0 and 1 are not considered as prime number
 * - isPrime(5) = true (1*5 or 5*1)
 * - isPrime(4) = false (1*4 or 2*2 or 4*1)
 */
export class PrimeNumber {
    /**
     * ### PrimeNumber BigO
     * - Loop - O(n)
     * - The value of `n` increases the number of times `(n % i === 0)` executes
     */
    public SolutionOne(n: number): boolean {
        if (n < 2) return false
        for (let i = 2; i < Math.sqrt(n); i++) {
            if (n % i === 0) return false
            return true
        }
        return true
    }
}

/**
 * # Power Of Two
 * - Give `n`, determine if the number is a power of 2 or not
 * - An integer is a power of two if there exists an integer `x` such that `n` === 2x
 * - isPowerofTwo(1) = true (2^0)
 * - isPowerOfTwo(2) = true (2^2)
 * - isPowerofTwo(5) = false
 * - n = 8
 * - 8/2 = 4 (remainder 0)
 * - 4/2 = 2 (remainder 0)
 * - 2/2 = 1 (remainder 0)
 * - **if remainder is not 0 in any step, `n` is not a power of two**
 * - **if remainder is 0 and `n` comes down to 1 eventually, n is a power of two
 */
export class PowerOfTwo {
    /**
     * ### PowerOfTwo Solution One BigO
     * - while loop => reduce `n` value => O(logn)
     */
    public SolutionOne(n: number): boolean {
        if (n < 1) return false
        while (n > 2) {
            if (n % 2 !== 0) {
                return false
            }
            n /= 2
        }
        return true
    }

    /**
     * ### PowerOfTwo Solution Two BigO
     * - Constant = O(1)
     */
    public SolutionTwoBitWise(n: number): boolean {
        if (n < 1) return false
        return (n & (n - 1)) === 0
    }
}
