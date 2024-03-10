namespace data_structure_algo.src.Basics
{
    public class NestedB
    {
        public int C { get; set; }
        public required NestedD D { get; set; }
    }

    public class NestedD
    {
        public int E { get; set; }
    }

    public class NestedF
    {
        public int G { get; set; }
    }

    /// <summary>
    /// Nested Object
    /// </summary>
    public class NestedObject
    {
        public int A { get; set; }
        public required NestedB B { get; set; }
        public required NestedF F { get; set; }
    }


    public class NestedObjectTwo
    {
        public int A { get; set; }
        public Dictionary<string, object>? B { get; set; }
        public Dictionary<string, object>? F { get; set; }
    }

    /// <summary>
    /// Nested Object Usage
    /// </summary>
    public class NestedObjectUsage
    {
        public void SampleOne()
        {
            Console.WriteLine("------>> Nested object");
            NestedObject nestedObject = new()
            {
                A = 1,
                B = new NestedB
                {
                    C = 2,
                    D = new NestedD
                    {
                        E = 3
                    }
                },
                F = new NestedF
                {
                    G = 4
                }
            };
            Console.WriteLine("aValue " + nestedObject.A);
            Console.WriteLine("bCValue " + nestedObject.B.C);
            Console.WriteLine("dEValue " + nestedObject.B.D.E);
            Console.WriteLine("fGValue " + nestedObject.F.G);

            // Find Nested object value by key
            var nestedObjectTwo = new NestedObjectTwo
            {
                A = 1,
                B = new Dictionary<string, object>
            {
                {"C", 2},
                {"D", new NestedObjectTwo { A = 3 } }
            },
                F = new Dictionary<string, object>
            {
                {"G", 4}
            }
            };


            string key = "A";

            NestedObjectHelper nestedObjectHelper = new();
            var result = nestedObjectHelper.FindNestedObjectValueByKey(nestedObjectTwo, key);

            if (result != null)
            {
                Console.WriteLine($"Value associated with key {key} is {result}");
            }
            else
            {
                Console.WriteLine($"Key {key} not found in nested object");
            }
        }
    }

    /// <summary>
    /// Nested Object Helper
    /// </summary>
    public class NestedObjectHelper
    {
        /// <summary>
        /// Find Nested Object Value by key
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public object? FindNestedObjectValueByKey(NestedObjectTwo obj, string key)
        {
            // Check if the provided object is null
            if (obj == null)
            {
                return null;
            }

            // Check if the object contains the key directly
            if (obj.GetType().GetProperty(key) != null)
            {
                return obj.GetType().GetProperty(key)!.GetValue(obj);
            }

            // Search recursively for the nested object with the provided key
            foreach (var property in obj.GetType().GetProperties())
            {
                Console.WriteLine("property => " + property);
                if (property.PropertyType == typeof(NestedObject))
                {
                    var nestedObject = (NestedObjectTwo)property.GetValue(obj)!;
                    var nestedResult = FindNestedObjectValueByKey(nestedObject, key);
                    if (nestedResult != null)
                    {
                        return nestedResult;
                    }
                }
                else if (property.PropertyType == typeof(Dictionary<string, object>))
                {
                    var nestedDictionary = (Dictionary<string, object>)property.GetValue(obj)!;
                    if (nestedDictionary.ContainsKey(key))
                    {
                        return nestedDictionary[key];
                    }
                }
            }

            return null;
        }
    }
}