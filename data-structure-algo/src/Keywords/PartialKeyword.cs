using System.Security;

namespace data_structure_algo.src.Keywords
{
    /// <summary>
    /// - In C#, the partial keyword is used to split the definition of a class, struct, interface, or method across multiple files.
    /// -  This feature allows developers to divide large classes or structs into multiple files, making it easier to manage and maintain code.
    /// </summary>
    public partial class PartialKeyword
    {
        public void Method1()
        {
            Console.WriteLine("From Method 1");
        }
    }
}