using System.Diagnostics.Contracts;

namespace data_structure_algo.src.Basics
{
    /// <summary>
    /// Base Class For ExtensionMethod
    /// </summary>
    public class ExtensionBaseClass
    {
        public void Sample()
        {
            Console.WriteLine("------->> Extension Method");
        }

        public string Display()
        {
            return "I am in Display";
        }

        public string Print()
        {
            return "I am in Print";
        }

    }

    public static class ExtensionMethod
    {
        /// <summary>
        /// Extended New Method
        /// </summary>
        /// <param name="obj"></param>
        public static void NewMethod(this ExtensionBaseClass obj)
        {
            Console.WriteLine("Hello I am Extended Method");
        }
    }

    // ----------------- Another Example -----------------
    public static class ExtMetClass
    {
        /// <summary>
        /// Integer Extension the extends `string`
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int IntegerExtension(this string str)
        {
            return int.Parse(str);
        }
    }
}