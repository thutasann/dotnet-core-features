using System;
using System.Collections.Generic;
using System.Reflection;

namespace data_structure_algo.src.Basics
{
    public class FindObjectWithKeySample
    {

        /// <summary>
        /// Sample One with using <b>Reflection</b>
        /// </summary>
        public void SampleOneUsingReflection()
        {
            Console.WriteLine("------->> Find Object with Key");
            var obj = new { Name = "Thuta", Age = 30, City = "Singapore" };
            string keyToFind = "Age";

            PropertyInfo? property = obj.GetType().GetProperty(keyToFind);
            if (property != null)
            {
                object? value = property.GetValue(obj);
                Console.WriteLine($"Value of {keyToFind}: {value}");
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }

        /// <summary>
        /// Find List Of Objects with Key
        /// </summary>
        public void SampleTwoWithListOfObject(string keyToFind)
        {
            Console.WriteLine("------->> Find List Of Objects with Key");
            var listOfObjects = new List<Dictionary<string, object>>
            {
                new() { { "Name", "John" }, { "Age", 30 }, { "City", "New York" } },
                new() { { "Name", "Alice" }, { "Age", 25 }, { "City", "Los Angeles" } },
                new() { { "Name", "Bob" }, { "Age", 35 }, { "City", "Chicago" } }
            };

            object valueToFind = 25;

            var foundObject = listOfObjects.FirstOrDefault(obj => obj.ContainsKey(keyToFind) && obj[keyToFind].Equals(valueToFind));

            if (foundObject != null)
            {
                Console.WriteLine("Object Found : ");
                foreach (var kvp in foundObject)
                {
                    Console.WriteLine($" {kvp.Key} : {kvp.Value}");
                }
            }
            else
            {
                Console.WriteLine($"No object found with key '{keyToFind}' and value '{valueToFind}'.");
            }
        }
    }
}