using data_structure_algo.src.AbstractDataType;
using data_structure_algo.src.Arrays;
using data_structure_algo.src.Basics;
using data_structure_algo.src.Basics.Generic;
using data_structure_algo.src.BigONotation;
using data_structure_algo.src.Collections;
using data_structure_algo.src.Fundamentals;
using data_structure_algo.src.Interviews;
using data_structure_algo.src.LeetCodes;
using data_structure_algo.src.LinkedList;
using data_structure_algo.src.OOP.DependcyInjection;
using data_structure_algo.src.Searchings;
using data_structure_algo.src.Sortings;

Console.WriteLine("WELCOME TO C# DSA & ALGO.... 🚀");

// ---------------------------- Basic Concepts 🚀 ----------------------------

// ------ Lambda Expression
LambdaExpression lambdaExpression = new();
lambdaExpression.SampleOne();

// ------ Extension Method
ExtensionBaseClass extensionBaseClass = new();
extensionBaseClass.Sample();
extensionBaseClass.Display();
extensionBaseClass.Print();
extensionBaseClass.NewMethod();

string str = "12345";
int num = str.IntegerExtension();
Console.WriteLine("Extended num " + num);

// ------ Recursion
RecursionSample recursionSample = new();
recursionSample.SampleOne();


// ------ With Expression
WithSample withSample = new();
withSample.SampleOne();

// ------ Dynamic Object and Dynamic Key
DictionarySample dictionarySample = new();
dictionarySample.DynamicObjectSample();
dictionarySample.DynamicKeySample();

// ------ Find Object with Key
FindObjectWithKeySample findObjectWithKeySample = new();
findObjectWithKeySample.SampleOneUsingReflection();
findObjectWithKeySample.SampleTwoWithListOfObject("Age");

// ------ Abstract Data Types
List<Pokemon> pokemons = new();
Pokemon pokemonOne = new("Pokemon One", 11);
Pokemon pokemonTwo = new("Pokemon Two", 11);
pokemons.Add(pokemonOne);
pokemons.Add(pokemonTwo);
Console.WriteLine("------->> Pokemons ADT " + pokemons.ToList());

// ------ Generic
GenericFunctionSample genericFunctionSample = new();
genericFunctionSample.SampleOne();

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
GenericLinkedList<string> genericNode1 = new("John", null);
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
GenericLinkedList<string> genricNode2 = new("Matt", genericNode1!);

// ---------------------------- Data Structures 🚀 ----------------------------


// ------ BigONotation
BigOSampleOne bigOSample = new();

// ------ Collections
Console.WriteLine("------->> Collections");
CollectionSample collectionSample = new()
{
    "Javascript",
    "ASP.NET MVC",
    "C#",
    "Python"
};
foreach (var course in collectionSample)
{
    Console.WriteLine(course);
}
Console.WriteLine("Number of courses : " + collectionSample.Count());
collectionSample.Remove("Python");
Console.WriteLine("Number of courses : " + collectionSample.Count());
collectionSample.Clear();
Console.WriteLine("Number of courses : " + collectionSample.Count());

collectionSample.DirectAccessCollection();

// ------ Arrays + Array Insertions
ArrayInsertionSample arrayInSample = new();
arrayInSample.ArrayEndInsertion();
arrayInSample.ArrayStartInsertion();

// ------ Stack Fundamentals
StackFundamentals stackFundamentals = new();
stackFundamentals.StackSampleOne();
stackFundamentals.GenericStackSample();

// ------ Queue Fundamentals
QueueFundamental queueFundamental = new();
queueFundamental.SampleOne();
queueFundamental.EcommerceOrderSample();

// -------- LinkedList 
Console.WriteLine("------->> LinkedList");
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
LinkedListSample<string?> node1 = new("John", null);
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
LinkedListSample<string?> node2 = new("Mall", node1);
LinkedListSample<string?> obj = node2.Link;
Console.WriteLine("Node1 Data " + node1.Data);
Console.WriteLine("Node2 Data " + node2.Data);
Console.WriteLine("Object Data " + obj.Data);

LinkedListSampleTwo linkedListSampleTwo = new();

// -------- Jagged Array
Console.WriteLine("------->> Jagged Array");
JaggedArraySample jaggedArraySample = new();
jaggedArraySample.SampleOne();

// ---------------------------- Sorting/Searching 🚀 ----------------------------


// -------- Bubble Sort
Console.WriteLine("------>> Bubble Sort Sample One");
BubbleSortSample bubbleSortSample = new();
bubbleSortSample.SampleOne();

// -------- Selection Sort
SelectionSortSample selectionSortSample = new();
selectionSortSample.SampleOne();

SelectionSortSampleTwo selectionSortSampleTwo = new();
selectionSortSampleTwo.SampleOne();

// -------- Merge Sort
MergeSortSample mergeSortSample = new();

// -------- Sequential Search
SequentialSearchSample sequentialSearchSample = new();
sequentialSearchSample.SampleOne();

// -------- Binary Search
BinarySearchSample binarySearchSample = new();
binarySearchSample.SampleOne();
binarySearchSample.SampleTwo();

RecursiveBinarySearchSample recursiveBinarySearchSample = new();
recursiveBinarySearchSample.SampleOne();

// ---------------------------- Leet Codes 🚀 ----------------------------


// ------ Two Sum (Leet Codes) 
Console.WriteLine("------>> Two Sum(LeetCode)");
TwoSum twoSum = new();
int[] nums = { 2, 11, 7, 15 };
twoSum.TwoSumSolution(nums, 9);
twoSum.TwoSumSolutionTwo(nums, 9);
twoSum.TwoSumSolutionThree(nums, 9);

// ------ LongestSubstringWithoutRepeatingCharacters (Leet Codes) 
Console.WriteLine("------>> Longest SubString without repeating Characters (LeetCode)");
LongestSubstringWithoutRepeatingCharacters longestSubstringWithoutRepeatingCharacters = new();
LongestSubstringWithoutRepeatingCharacters.SampleOne("abcabcbb");

// ---------------------------- Interviews 🚀 ----------------------------

// ------ Prime Numbers (Interview) 
PrimeNumbers primeNumbers = new();
primeNumbers.SampleOne();

// ------ Reverse String/Number (Interview) 
ReverseString reverseString = new();
reverseString.SampleOne();

ReverseNumber reverseNumber = new();
reverseNumber.SampleOne();
reverseNumber.SampleTwo();

// ------ String Length  (Interview) 
StringLength stringLength = new();
stringLength.SampleOne();

// ------ BubbleSort (Interview) 
BubbleSortInterview bubbleSortInterview = new();
bubbleSortInterview.SampleOne();

// ------ Factorial (Interview) 
FactorialLogic factorialLogic = new();
factorialLogic.SampleOne();

// ------ FibonacciSeries (Interview) 
FibonacciSeries fibonacciSeries = new();
fibonacciSeries.SampleOne();

// ------ Swap Number (Interview) 
SwapNumber swapNumber = new();
swapNumber.SampleOne();

// ------ Sum Of Number (Interview) 
SumOfNumber sumOfNumber = new();
sumOfNumber.SampleOne();

// ------ Find Even or Odd Number (Interview) 
FindEvenOrOddNumber findEvenOrOddNumber = new();
findEvenOrOddNumber.SampleOne();


// ---------------------------- OOP 🚀 ----------------------------
Console.WriteLine("------>> Depedency Injection");
Logger logger = new();
UserService userService = new(logger);
userService.GetUser("123");

DatabaseService<IProduct> databaseService = new();
LoggingService loggingService = new();
NotificationService notificationService = new();
InventoryService inventoryService = new(databaseService, loggingService, notificationService);
inventoryService.AdditemToInvendotry(new IProduct()
{
    Name = "Product one",
    Quantity = 12
});

ShoppingCart shoppingCart = new();
shoppingCart.AddItems(new IEcommerceProduct()
{
    Id = 1,
    Name = "Product one",
    Price = 12,
});
OrderService orderService = new(shoppingCart);
orderService.PlaceOrder();