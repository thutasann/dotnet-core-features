import { RecursiveBasic } from './Basics/RecursiveBasic'
import { ArrayBasic } from './Basics/ArrayBasic'
import { ObjectBasic } from './Basics/ObjectBasic'

console.log('TYPESCRIPT DATA STRUCTURE AND ALGORITHMS..... 🚀')

// ------------ Basics ------------
const arrayBasic = new ArrayBasic()
arrayBasic.SliceSample()
arrayBasic.SplitArrayIntoChunks()
arrayBasic.SpliceSample()
arrayBasic.FillAndFindIndex()
arrayBasic.FlatAndReverse()
arrayBasic.WhileSample()

const objectBasic = new ObjectBasic()
objectBasic.ShallowCopySample()
objectBasic.DeepCopySample()
objectBasic.HashMapSample('h7wC3')
objectBasic.NestedObjectSample()

const recursiveBasic = new RecursiveBasic()
const dinner = recursiveBasic.GoToDinner(1)
console.log('------>> Recursive dinnerResult', dinner)
const multipliedResult = recursiveBasic.Multiply([1, 2, 3])
console.log('------>> Recursive multipliedResult', multipliedResult)
recursiveBasic.AllEmployeesRecursive()
const reversedString = recursiveBasic.ReverseString('hello')
console.log('------>> Reverse String Recursive Sample ', reversedString)
const factorialAnswer = recursiveBasic.FactorialLogic(5)
console.log('------>> Factorial Logic Recursive Sample ', factorialAnswer)
const fiboAnswer = recursiveBasic.FibonacciSeries(10)
console.log('------>> FibonacciSeries Recursive Sample ', fiboAnswer.join(', '))
const rangeOfNums = recursiveBasic.RangeOfNumbers(1, 5)
console.log('------>> Range of Numbers Recursive Sample ', rangeOfNums)
