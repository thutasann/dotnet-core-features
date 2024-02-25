import { RecursiveBasic } from './Basics/RecursiveBasic'
import { ArrayBasic } from './Basics/ArrayBasic'
import { ObjectBasic } from './Basics/ObjectBasic'
import { Interviews } from './Interviews/Interviews'
import { LeetCodeSolutions } from './LeetCodes'

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
arrayBasic.InOperatorSample()

// ------------ Object Basics  🚀 ------------
const objectBasic = new ObjectBasic()
objectBasic.ShallowCopySample()
objectBasic.DeepCopySample()
objectBasic.HashMapSample('h7wC3')
objectBasic.NestedObjectSample()

// ------------ Recursive Basics  🚀 ------------
const recursiveBasic = new RecursiveBasic()
recursiveBasic.AllEmployeesRecursive()
console.log('------>> Recursive dinnerResult', recursiveBasic.GoToDinner(1))
console.log('------>> Recursive multipliedResult', recursiveBasic.Multiply([1, 2, 3]))
console.log('------>> Reverse String Recursive Sample ', recursiveBasic.ReverseString('hello'))
console.log('------>> Factorial Logic Recursive Sample ', recursiveBasic.FactorialLogic(5))
console.log('------>> FibonacciSeries Recursive Sample ', recursiveBasic.FibonacciSeries(10).join(', '))
console.log('------>> Range of Numbers Recursive Sample ', recursiveBasic.RangeOfNumbers(1, 5))

// ------------ Interviews Questions and Answers 🚀   ------------
const interviews = new Interviews()
console.log('------>> Get Second Largest (Interview) ', interviews.getSecondLargest([12, 35, 1, 10, 34, 1]))
console.log('------>> Remove Duplicates (Interview) ', interviews.RemoveDuplicates([0, 0, 1, 1, 1, 2, 2, 3, 3, 4]))
console.log('------>> Rotate Array By K (Interview) ', interviews.RotateArrayByK([1, 2, 3, 4, 5, 6, 7], 3))

// ------------ LeetCodes 🚀   ------------
const leetCodes = new LeetCodeSolutions()
leetCodes.SwapNumber(2, 4)
console.log('twoSumAnswer ', leetCodes.TwoSum([2, 7, 11, 15], 18))
console.log('binarySearch ', leetCodes.BinarySearch([1, 2, 3, 4, 5, 6, 7, 8], 19))
console.log('linearSearch', leetCodes.LinearSearch([-5, 2, 10, 4, 6], 10))
console.log('bubbleSort ', leetCodes.BubbleSort([30, 10, -90, -40, 50, 25, 70, -54, -80, 38]))
console.log('selectionSort ', leetCodes.SelectionSort([30, 10, -90, -40, 50, 25, 70, -54, -80, 38]))
console.log('insertionSort ', leetCodes.InsertionSort([30, 10, -90, -40, 50, 25, 70, -54, -80, 38]))
