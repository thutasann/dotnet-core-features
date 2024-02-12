using System.Dynamic;

namespace data_structure_algo.src.Basics
{
    /// <summary>
    /// Dynamic Object and Dynamic Keys Sample
    /// </summary>
    public class DictionarySample
    {
        public void DynamicObjectSample()
        {
            Console.WriteLine("------->> Dynamic Object");
            dynamic dynamicObject = new ExpandoObject();
            dynamicObject.Name = "John";
            dynamicObject.Age = 21;
            Console.WriteLine("Dynamic Object Name " + dynamicObject.Name);
        }

        /// <summary>
        /// Dynamic Keys using <b>Dictionary</b>
        /// </summary>
        public void DynamicKeySample()
        {
            Console.WriteLine("------->> Dynamic Keys Sample");
            var dynamiDictionary = new Dictionary<dynamic, dynamic>();
            dynamiDictionary["key1"] = "Value 1";
            dynamiDictionary[123] = "Value 2";
            Console.WriteLine("dynamiDictionary value 1 " + dynamiDictionary["key1"]);
            Console.WriteLine("dynamiDictionary value 2 " + dynamiDictionary[123]);
        }
    }
}