using data_structure_algo.src.AbstractDataType;
using data_structure_algo.src.Arrays;
using data_structure_algo.src.BigONotation;

Console.WriteLine("WELCOME TO C# DSA & ALGO.... 🚀");

// ------ Abstract Data Types
List<Pokemon> pokemons = new();
Pokemon pokemonOne = new("Pokemon One", 11);
Pokemon pokemonTwo = new("Pokemon Two", 11);
pokemons.Add(pokemonOne);
pokemons.Add(pokemonTwo);
Console.WriteLine("pokemons " + pokemons.ToList());

// ------ BigONotation
BigOSampleOne bigOSample = new();

// ------ Arrays + Array Insertions
ArraySample arraySample = new();
arraySample.ArrayEndInsertion();
arraySample.ArrayStartInsertion();