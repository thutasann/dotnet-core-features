namespace pure_DSA.src.HashTable
{
    /// <summary>
    /// <h1>Hash Table </h1> <br/>
    /// - just an array with key value pairs <br/>
    /// - They are sometimes called `ASSOCIATIVE ARRAY!` <br/>
    /// - it kind of has like a hash function strapped onto it. <br/>
    /// - hash tables are fast for EVERYTHING. (Find, add, remove) <br/>
    /// - Dictionary structure is built on top of a hash table <br/>
    /// - Key value pair is the element withing the hash table <br/>
    /// - Disadvantages -> Collisions! and Load Factor <br/>
    /// - Disadvantages -> The bigger the hash -> the more likely that its going to degrade <br/>
    /// </summary>
    public class HashTableExplain { }

    /// <summary>
    /// <h1> Why is it a Hash ? </h1> <br/>
    /// - use a hash function <br/>
    /// - convert array values into key <br/>
    /// - MUST BE constant time <br/>
    /// - Deterministic (some output yields same input)
    /// </summary>
    public class HashExplain { }

    /// <summary>
    /// <h1> Hash Table Sample One </h1>
    /// </summary>
    public class HashTableSampleOne
    {
        public string[] _hashTable { get; set; }

        public HashTableSampleOne()
        {
            _hashTable = new string[10];
        }

        public void Set(string key, string value)
        {
            int hashedkey = Hash(key);

            if (_hashTable[hashedkey] != null)
            {
                Console.WriteLine("Has Collision has occured");
            }
            else
            {
                _hashTable[hashedkey] = value;
            }
        }

        public string Get(string key)
        {
            int hashedkey = Hash(key);
            Console.WriteLine("hashed key => " + hashedkey);
            return _hashTable[hashedkey];
        }

        private int Hash(string key)
        {
            return key.Length % _hashTable.Length;
        }
    }

    public static class HashTableSampleOneUsage
    {
        public static void SampelOne()
        {
            Console.WriteLine("\nHash Table Sample One ===> ");
            HashTableSampleOne hashTableSampleOne = new();
            hashTableSampleOne.Set("Thuta", "123-123-123-14");
            hashTableSampleOne.Set("Steve", "343-3435-465");
            hashTableSampleOne.Set("John", "89-808-21412-12");
            Console.WriteLine(hashTableSampleOne.Get("Steve"));

        }
    }
}