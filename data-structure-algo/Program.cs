using data_structure_algo.src.AbstractDataType;
using data_structure_algo.src.Arrays;
using data_structure_algo.src.Basics;
using data_structure_algo.src.BigONotation;
using data_structure_algo.src.Collections;
using data_structure_algo.src.Fundamentals;
using data_structure_algo.src.LeetCodes;
using data_structure_algo.src.LinkedList;
using data_structure_algo.src.Sortings;

Console.WriteLine("WELCOME TO C# DSA & ALGO.... 🚀");

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

// ------ With Expression
WithSample withSample = new();
withSample.SampleOne();

// ------ Dynamic Object and Dynamic Key
DictionarySample dictionarySample = new();
dictionarySample.DynamicObjectSample();
dictionarySample.DynamicKeySample();


// ------ Abstract Data Types
List<Pokemon> pokemons = new();
Pokemon pokemonOne = new("Pokemon One", 11);
Pokemon pokemonTwo = new("Pokemon Two", 11);
pokemons.Add(pokemonOne);
pokemons.Add(pokemonTwo);
Console.WriteLine("------->> Pokemons ADT " + pokemons.ToList());

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

// ------ Leet Codes
Console.WriteLine("------>> Leet Codes");
TwoSum twoSum = new();
int[] nums = { 2, 11, 7, 15 };
twoSum.TwoSumSolution(nums, 9);
twoSum.TwoSumSolutionTwo(nums, 9);
twoSum.TwoSumSolutionThree(nums, 9);

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

// -------- Bubble Sort
Console.WriteLine("------>> Bubble Sort Sample One");
BubbleSortSample bubbleSortSample = new();
bubbleSortSample.SampleOne();

// -------- Selection Sort
SelectionSortSample selectionSortSample = new();
selectionSortSample.SampleOne();
