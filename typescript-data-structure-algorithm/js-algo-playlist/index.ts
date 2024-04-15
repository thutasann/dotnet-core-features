import { BigONotation } from './src/BigONotation'
import { handleDragStart, handleDragStop, products } from './src/DragAndDrop'
import { ForConstInSamples } from './src/ForConstInSamples'
import { ForConstOfSamples } from './src/ForConstOfSamples'
import { FactorialNumber, FibonacciSeries, PowerOfTwo, PrimeNumber } from './src/MathAlgorithms'
import {
    RecursiveEcommerceSample,
    RecursiveFactorial,
    RecursiveFibonacci,
    RecursiveNestedObject,
    RecursiveSearch,
} from './src/Recursion'
import {
    BinarySearch,
    LinearSearch,
    RecursiveBinarySearch,
    SearchAlgorithmFundamentals,
    StringSearch,
} from './src/SearchAlgorithms'
import { TopologicalSorting } from './src/SortingAlgorithms'
import { HashMapCacheUsage } from './src/data-structure/HashMap/CacheSample'
import { HashMapCheckGradeUtil, HashMapUsageSampleOne } from './src/data-structure/HashMap/HashMapSampleOne'
import { HashMapUserSearchUsage } from './src/data-structure/HashMap/HashUserSearch'
import { HashTableUsageOne } from './src/data-structure/HashTable/HashTableSampleOne'
import { HashTableUsageTwo } from './src/data-structure/HashTable/HashTableSampleTwo'
import { DoublyLinkedListUsage } from './src/data-structure/LinkedList/DoubleLinkedList'
import { SinglyLinkedListUsage } from './src/data-structure/LinkedList/SinglyLinkedList'
import { UndoRedoLinkedListUsage } from './src/data-structure/LinkedList/UndoRedo'
import { MapDataStructure } from './src/data-structure/MapStructure'
import { QueueUsage } from './src/data-structure/Queue/Queue'
import { NestedRecordSampleOne } from './src/data-structure/Record/NestedRecordSample'
import { GetPropertySample, RecordEcommerceSample, RecordSampleOne } from './src/data-structure/Record/RecordSample'
import { SetSample } from './src/data-structure/SetStructure'
import { StackUsage } from './src/data-structure/Stack/Stack'
import { StackEcommerceUsage } from './src/data-structure/Stack/StackEcommerce'
import { category, flatNestedObj, nestedObj } from './src/utils/constants'

console.log('JAVASCRIPT ALGORITHMS PLAYLIST ..... 🚀')

// ------------ BigO Notation  🚀 ------------
const bigORelateds = new BigONotation()

// ------------ Map/Set Data Structure  🚀 ------------
MapDataStructure.SampleOne()
SetSample.SampleOne()

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
const recursiveFactorial = new RecursiveFactorial()
console.log('recursive factorial => ', recursiveFactorial.SolutionOne(6))
const recursiveSearch = new RecursiveSearch()
console.log('recursive search => ', recursiveSearch.SampleOne(nestedObj, 5))
const recursiveNestedObj = new RecursiveNestedObject()
console.log('recursive nested obj => ', recursiveNestedObj.FlattenNestedObject(flatNestedObj))

// ------------ Random Functions  🚀 ------------
console.log('------>> Drag and Drop Function  🚀 ')
handleDragStart(products[0])
handleDragStop(1)
console.log('dragged products', products)

// ------------ Search Algorithms  🚀 ------------
console.log('------>> Search Algorithms  🚀 ')
const searchFundamentals = new SearchAlgorithmFundamentals()
searchFundamentals.IteratingArray()
searchFundamentals.FindMiddleElement()
searchFundamentals.SwapThroughArray()
searchFundamentals.SwapFromEndToFirst()
searchFundamentals.findMiddleAndSplit()

console.log('------>> Linear Search  🚀 ')
const linearSearch = new LinearSearch()
console.log('linear search result => ', linearSearch.SolutionOne([-5, 2, 10, 4, 6], 10))

console.log('------>> Binary Search  🚀 ')
const binarySearch = new BinarySearch()
console.log('binary search result => ', binarySearch.SolutionOne([-5, 2, 10, 4, 6], 10))

console.log('------>> Recursive Binary Search  🚀 ')
const recursiveBinarySearch = new RecursiveBinarySearch()
console.log('recursive binary search result => ', recursiveBinarySearch.SolutionOne([-5, 2, 10, 4, 6], 10))

console.log('------>> String Search  🚀 ')
const stringSearch = new StringSearch()
console.log('string search result => ', stringSearch.SolutionOne('search and find', 'an'))

// ------------ Sorting Algorithms  🚀 ------------
TopologicalSorting.SolutionOne()

// ------------ For Const Of  🚀 ------------
ForConstOfSamples.SampleOne()
ForConstOfSamples.SampleTwo()
ForConstOfSamples.SampleThree()
ForConstOfSamples.SampleFour()
ForConstOfSamples.SampleFive()
ForConstOfSamples.SampleSix()

// ------------ For Const In 🚀 ------------
ForConstInSamples.SampleOne()
ForConstInSamples.SampleTwo()
ForConstInSamples.SampleThree()
ForConstInSamples.SampleFour()

// ------------ Record, KeyValue Pair  🚀 ------------
RecordSampleOne.SampleOne()
RecordEcommerceSample.SampleOne()
NestedRecordSampleOne.SampleOne()
NestedRecordSampleOne.SampleTwo()
GetPropertySample.SampleOne()

// ------------ Stack  🚀 ------------
StackUsage.SampleOne()
StackEcommerceUsage.SampleOne()

// ------------ Queue  🚀 ------------
QueueUsage.SampleOne()

// ------------ LinkedList  🚀 ------------
SinglyLinkedListUsage.SampleOne()
SinglyLinkedListUsage.SampleTwo()
UndoRedoLinkedListUsage.SampleOne()
DoublyLinkedListUsage.SampleOne()

// ------------ Hash Map  🚀 ------------
HashMapUsageSampleOne.SampleOne()
HashMapCacheUsage.SampleOne()
console.log('Grade (Sample One) => ', HashMapCheckGradeUtil.SampleOne(80))
console.log('Grade (Sample Two) => ', HashMapCheckGradeUtil.SampleTwo(80))
HashMapUserSearchUsage.SampleOne()
// fetchCacheSample()

// ------------ Hash Table  🚀 ------------
HashTableUsageOne.SampleOne()
HashTableUsageTwo.SampleOne()
