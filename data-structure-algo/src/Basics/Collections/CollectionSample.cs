using System.Collections;
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
    public class CollectionSample : CollectionBase
    {

        public void Add(object item)
        {
            InnerList.Add(item);
        }

        public void Remove(object item)
        {
            InnerList.Remove(item);
        }

        public new void Clear()
        {
            InnerList.Clear();
        }

        public new int Count()
        {
            return InnerList.Count;
        }

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

        /// <summary>
        /// Stacks/Queue and HashTable <br/>
        /// A list that stores its elements in sequential order <br/>
        /// We call this type of collection a linear lists <br/>
        /// Linear List are not limited by size when they are created <br/>
        /// They are able to expand and contract dynamically items <br/>
        /// Linear list are not accessed directly they are reference by their position
        /// </summary>
        public void SequentialAccessCollection()
        {
        }

    }

}