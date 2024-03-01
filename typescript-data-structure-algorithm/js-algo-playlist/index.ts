import { BigONotation } from './src/BigONotation'
import { FactorialNumber, FibonacciSeries, PowerOfTwo, PrimeNumber } from './src/MathAlgorithms'
import { RecursiveEcommerceSample, RecursiveFibonacci } from './src/Recursion'
import { category } from './src/utils/constants'

console.log('JAVASCRIPT ALGORITHMS PLAYLIST ..... 🚀')

// ------------ BigO Notation  🚀 ------------
const bigORelateds = new BigONotation()

// ------------ Math Algorithms  🚀 ------------
console.log('------>> Math Algorithms  🚀 ')
const fibonacci = new FibonacciSeries()
console.log('fibonacci result => ', fibonacci.SolutionOne(7).join(', '))
const factorial = new FactorialNumber()
console.log('factorial result => ', factorial.SolutionOne(6))
const primeNumber = new PrimeNumber()
console.log('primeNumber result => ', primeNumber.SolutionOne(5))
const powerOfTwo = new PowerOfTwo()
console.log('powerOfTwo result => ', powerOfTwo.SolutionOne(5))
console.log('powerOfTwo result Two => ', powerOfTwo.SolutionTwoBitWise(2))

// ------------ Recursive Functions  🚀 ------------
console.log('------>> Recursive Functions  🚀 ')
const recursiveEcommerce = new RecursiveEcommerceSample()
console.log('recursive ecommerce => ', recursiveEcommerce.GetTotalProducts(category))
const recursiveFibonacci = new RecursiveFibonacci()
console.log('recursive fibonacci => ', recursiveFibonacci.SolutionOne(7).join(', '))
