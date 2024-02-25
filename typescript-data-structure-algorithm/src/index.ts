import { RecursiveBasic } from './Basics/RecursiveBasic'
import { ArrayBasic } from './Basics/ArrayBasic'
import { ObjectBasic } from './Basics/ObjectBasic'
import { Interviews } from './Interviews/Interviews'

console.log('TYPESCRIPT DATA STRUCTURE AND ALGORITHMS..... 🚀')

// ------------ Array Basics  🚀 ------------
const arrayBasic = new ArrayBasic()
arrayBasic.SliceSample()
arrayBasic.SplitArrayIntoChunks()
arrayBasic.SpliceSample()
arrayBasic.FillAndFindIndex()
arrayBasic.FlatAndReverse()
arrayBasic.WhileSample()
arrayBasic.UnshiftSample()
arrayBasic.ReduceSample()

// ------------ Object Basics  🚀 ------------
const objectBasic = new ObjectBasic()
objectBasic.ShallowCopySample()
objectBasic.DeepCopySample()
objectBasic.HashMapSample('h7wC3')
objectBasic.NestedObjectSample()

// ------------ Recursive Basics  🚀 ------------
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

// ------------ Interviews Questions and Answers 🚀   ------------
const interviews = new Interviews()
const secondLargest = interviews.getSecondLargest([12, 35, 1, 10, 34, 1])
console.log('------>> Get Second Largest (Interview) ', secondLargest)
const removeDuplicateAnswer = interviews.RemoveDuplicates([0, 0, 1, 1, 1, 2, 2, 3, 3, 4])
console.log('------>> Remove Duplicates (Interview) ', removeDuplicateAnswer)
const rotateAnswer = interviews.RotateArrayByK([1, 2, 3, 4, 5, 6, 7], 3)
console.log('------>> Rotate Array By K (Interview) ', rotateAnswer)
