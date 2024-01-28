using data_structure_algo.src.AbstractDataType;
using data_structure_algo.src.Arrays;
using data_structure_algo.src.BigONotation;
using data_structure_algo.src.Fundamentals;

Console.WriteLine("WELCOME TO C# DSA & ALGO.... 🚀");

// ------ Abstract Data Types
List<Pokemon> pokemons = new();
Pokemon pokemonOne = new("Pokemon One", 11);
Pokemon pokemonTwo = new("Pokemon Two", 11);
pokemons.Add(pokemonOne);
pokemons.Add(pokemonTwo);
Console.WriteLine("------->> Pokemons ADT " + pokemons.ToList());

// ------ BigONotation
BigOSampleOne bigOSample = new();

// ------ Arrays + Array Insertions
ArrayInsertionSample arrayInSample = new();
arrayInSample.ArrayEndInsertion();
arrayInSample.ArrayStartInsertion();

// ------ Stack Fundamentals
StackFundamentals stackFundamentals = new();
stackFundamentals.StackSampleOne();
stackFundamentals.GenericStackSample();
