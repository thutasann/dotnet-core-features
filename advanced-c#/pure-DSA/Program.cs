// See https://aka.ms/new-console-template for more information
using pure_DSA.src.HashTable;

Console.WriteLine("PURE DATA STRUCTURE AND ALGORITHMS!");

// ---------------------------- HashTable 🚀 ----------------------------
Console.WriteLine("Hash Table Sample ===> ");
HashTableSampleOne hashTableSampleOne = new();
hashTableSampleOne.Set("Thuta", "123-123-123-14");
hashTableSampleOne.Set("Steve", "343-3435-465");
hashTableSampleOne.Set("John", "89-808-21412-12");
Console.WriteLine(hashTableSampleOne.Get("Steve"));