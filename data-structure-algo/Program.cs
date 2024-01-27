using data_structure_algo.src.AbstractDataType;
using data_structure_algo.src.BigONotation;

Console.WriteLine("WELCOME TO C# DSA & ALGO.... 🚀");

// ------ Abstract Data Types
List<Pokemon> pokemons = new();
Pokemon pokemonOne = new("Pokemon One", 11);
Pokemon pokemonTwo = new("Pokemon Two", 11);
pokemons.Add(pokemonOne);
pokemons.Add(pokemonTwo);
Console.WriteLine(pokemons);

// ------ BigONotation
BigOSampleOne bigOSample = new();