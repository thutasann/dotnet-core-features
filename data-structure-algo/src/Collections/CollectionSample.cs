using System.Data;

namespace data_structure_algo.src.Collections
{
    /// <summary>
    /// Collections -> Linear and NonLinear Collection <br/>
    /// Linear Collection 🚀
    /// List of elements where one element follows the previous element <br/>
    /// DirectAccess Collections (Arrays, String, Struct) / Sequential Access Collections <br/>
    /// NonLinear Collection 🚀
    /// Elements that do not have positional order within the collection.
    /// </summary>
    public class CollectionSample
    {
        public void DirectAccessCollection()
        {
            string[] users = { "John", "Matt" };
            Console.WriteLine(users[0]);

            StructSample structSample = new("Thuta", "Sann", "Genius");
            string fullName, inits;
            fullName = structSample.ToString();
            inits = structSample.Initials();
            Console.WriteLine("My FullName is {0}", fullName);
            Console.WriteLine("My Initials are {0}", inits);
        }
    }

}