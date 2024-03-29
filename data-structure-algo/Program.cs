﻿using data_structure_algo.src.AbstractDataType;
using data_structure_algo.src.Arrays;
using data_structure_algo.src.Basics;
using data_structure_algo.src.Basics.Generic;
using data_structure_algo.src.Basics.ThreadSample;
using data_structure_algo.src.BigONotation;
using data_structure_algo.src.Collections;
using data_structure_algo.src.Fundamentals;
using data_structure_algo.src.Interviews;
using data_structure_algo.src.Keywords;
using data_structure_algo.src.Keywords.Delegate;
using data_structure_algo.src.Keywords.EventKeyword;
using data_structure_algo.src.Keywords.OutKeyword;
using data_structure_algo.src.LeetCodes;
using data_structure_algo.src.LinkedList;
using data_structure_algo.src.OOP.Abstraction;
using data_structure_algo.src.OOP.DependcyInjection;
using data_structure_algo.src.OOP.Encapsulation;
using data_structure_algo.src.OOP.Polymorphism;
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

// ------ Nested Object
NestedObjectUsage nestedObjectUsage = new();
nestedObjectUsage.SampleOne();

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

GenericLinkedList<string> genericNode1 = new("John", null);
GenericLinkedList<string> genricNode2 = new("Matt", genericNode1!);

// ------ Factory Pattern
Console.WriteLine("------->> Factory Pattern Sample ");
FactoryShapeUsage factorySample = new();
factorySample.SampleOne();

// ---------------------------- Async Await 🚀 ----------------------------

Console.WriteLine("------->> Async Await Sample");
AsyncAwaitSample asyncAwaitSample = new();
AsyncAwaitFetchAPIs asyncAwaitFetchAPIs = new();
CPUBoundAsyncAwait cPUBoundAsyncAwait = new();
Console.WriteLine("CPU Bound Result => " + await cPUBoundAsyncAwait.CalculateResultAsync("thutasann"));
IOBoundAsyncAwait iOBoundAsyncAwait = new();
var result = await iOBoundAsyncAwait.DownloadAsync();
Console.WriteLine("IO Bound Result => " + result);

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
LinkedListSample<string?> node1 = new("John", null);
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

// ------ Cache Data (Interview) 
CacheManagerUsage cacheManager = new();
cacheManager.SampleOne();

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

Console.WriteLine("------>> Static Keyword Sample Usage");
StaticDatabaseUsage staticDatabaseUsage = new();
staticDatabaseUsage.SampleOne();

Console.WriteLine("------>> Abstraction Vehicle Sample");
AbstractionVehicleSample abstractionVehicleSample = new();
abstractionVehicleSample.SampleOne();

Console.WriteLine("------>> Abstraction HR System Sample");
var fullTimeEmployee = new FullTimeEmployee("FT001", "John Doe", 5000);
var partTimeEmployee = new PartTimeEmployee("PT001", "Jane Smith", 15, 20);
var contractEmployee = new ContractEmployee("CE001", "Alice Johnson", 400);

DisplayEmployeeInfo(fullTimeEmployee);
DisplayEmployeeInfo(partTimeEmployee);
DisplayEmployeeInfo(contractEmployee);

static void DisplayEmployeeInfo(BaseEmployee employee)
{
    Console.WriteLine($"Employee ID: {employee.EmployeeId}");
    Console.WriteLine($"Employee Full Name: {employee.FullName}");
    Console.WriteLine($"Salary: {employee.CalculateSalary():C}");
    Console.WriteLine();
}

Console.WriteLine("------>> Abstraction Bank System Sample");
BankingSystemUsage bankingSystemUsage = new();
bankingSystemUsage.SampleOne();

Console.WriteLine("------>> Abstraction Course Sample");
CourseUsage courseUsage = new();
courseUsage.SampleOne();


Console.WriteLine("------>> Polymorphism Sample");
PolyShape[] shapes = { new PolyShape(), new Circle(), new Rectangle() };
foreach (var item in shapes)
{
    item.Draw();
}

Console.WriteLine("------>> Polymorphism banking Sample");
PolyAccount checkingsAccount = new CheckingAccount("1232312312");
checkingsAccount.Deposit(1000);
checkingsAccount.WithDraw(500);

PolyAccount savingsAccount = new SavingsAccount("0987654321");
savingsAccount.Deposit(2000);
savingsAccount.WithDraw(1500);

Console.WriteLine("------>> Encapsulation Sample");
EnCar enCar = new("Toyota", "Camry", 2002);
enCar.SartEngine();
EnBankUsage enBank = new();
enBank.SampleOne();

// ---------------------------- Keywords Samples 🚀 ----------------------------

Console.WriteLine("------>> Partial Keyword Sample");
PartialKeyword partialKeyword = new();
partialKeyword.Method1();
partialKeyword.Method2();

Console.WriteLine("------>> Using Keyword Sample");
UsingKeywordSample usingKeywordSample = new();

Console.WriteLine("------>> Base Keyword Sample");
DerivedClassMethod derivedClassMethod = new();
derivedClassMethod.BaseMethod();

Console.WriteLine("------>> NameOf Keyword Sample");
NameOfKeywordSampleTwo nameOfKeywordSampleTwo = new();
nameOfKeywordSampleTwo.SampleOne();

Console.WriteLine("------>> Delegate Keyword Sample");
DelegateKeywrodUsage delegateKeywrodUsage = new();
delegateKeywrodUsage.SampleOne();

Console.WriteLine("------>> Delegate Event Sample");
DelegateEventSample delegateEventSample = new();
delegateEventSample.SampleOne();

Console.WriteLine("------>> Delegate Trading Strategy Sample");
DelegateTradingStrategyUsage delegateTradingStrategyUsage = new();
delegateTradingStrategyUsage.SampleOne();

Console.WriteLine("------>> Delegate Calculator Sample");
DelgateCalculatorUsage delgateCalculatorUsage = new();
delgateCalculatorUsage.SampleOne();

Console.WriteLine("------>> Delegate Callback Mechanism Sample");
DelegateCallbackUsage delegateCallbackUsage = new();
delegateCallbackUsage.SampleOne();

Console.WriteLine("------>> Event Keyword Sample");
EventButtonUsage eventButtonUsage = new();
eventButtonUsage.SampleOne();

Console.WriteLine("------>> Event Subscriber Publisher Sample");
EventSubscriberPublisherUsage eventSubscriberPublisherUsage = new();
eventSubscriberPublisherUsage.SampleOne();

Console.WriteLine("------>> Out Keyword Sample");
OutKeywrdSampleUsage outKeywrdSampleUsage = new();
outKeywrdSampleUsage.SampleOne();

Console.WriteLine("------>> Out Keyword Ecommerce Sample");
OutEcommerceUsage outEcommerceUsage = new();
outEcommerceUsage.SampleOne();

// ---------------------------- Thread 🚀 ----------------------------
Console.WriteLine("------>> ThreadSample 🚀 ");
ThreadSample threadSample = new();
ThreadEcommerceSample threadEcommerceSample = new();
EventSchedulingWithThread eventSchedulingWithThread = new();
eventSchedulingWithThread.SampleOne();

LockKeywordSample lockKeywordSample = new();

DataProcessingSample dataProcessingSample = new();
dataProcessingSample.SampleOne();

ThreadAndAsyncAwait threadAndAsyncAwait = new();
threadAndAsyncAwait.SampleOne();