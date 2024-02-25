import { organization } from '../utils/constants'
import { IEmployee } from '../utils/types'

export class RecursiveBasic {
    /**
     * Go To Dinner Recursive
     */
    public GoToDinner(person: number): boolean {
        if (person === 5) return true
        return this.GoToDinner(person + 1)
    }

    /**
     * Multiply Nums Recursive
     */
    public Multiply(arr: number[]): number {
        if (arr.length <= 0) {
            return 1
        } else {
            return arr[arr.length - 1] * this.Multiply(arr.slice(0, arr.length - 1))
        }
    }

    /**
     * Get All Employees Recursive
     */
    public AllEmployeesRecursive(): void {
        console.log('------>> All Employees Recursive Sample')
        function getAllEmployees(root: IEmployee): string[] {
            const employees: string[] = []

            function traverse(node: IEmployee): void {
                if (node.children) {
                    for (const child of node.children) {
                        traverse(child)
                    }
                }
                employees.push(node.name)
            }

            traverse(root)
            return employees
        }

        const allEmployees = getAllEmployees(organization)
        console.log('allEmployees', allEmployees)
    }

    /**
     * Reverse String
     */
    public ReverseString(str: string): string {
        if (str === '') return str
        return this.ReverseString(str.substring(1)) + str.charAt(0)
    }

    /**
     * Factorial Logic
     */
    public FactorialLogic(n: number): number {
        if (n === 0) return 1
        return n * this.FactorialLogic(n - 1)
    }

    /**
     * Fibonacci Series
     */
    public FibonacciSeries(n: number): number[] {
        if (n <= 0) return []
        else if (n === 1) return [0]
        else if (n === 2) return [0, 1]
        else {
            const series = this.FibonacciSeries(n - 1)
            series.push(series[series.length - 1], series[series.length - 2])
            return series
        }
    }

    /**
     * Range Of Start Number and End Number
     */
    public RangeOfNumbers(startNum: number, endNumb: number): number[] {
        if (endNumb < startNum) return []
        const numbers = this.RangeOfNumbers(startNum, endNumb - 1)
        numbers.push(endNumb)
        return numbers
    }
}
