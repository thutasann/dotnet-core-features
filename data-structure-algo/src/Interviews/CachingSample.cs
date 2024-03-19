namespace data_structure_algo.src.Interviews
{
    public class CacheManager
    {
        private Dictionary<string, object> cache = new();

        public void AddToCache(string key, object value)
        {
            cache[key] = value;
        }

        public bool TryToGetValue(string key, out object value)
        {
            return cache.TryGetValue(key, out value!);
        }

        public void RemoveFromCache(string key)
        {
            cache.Remove(key);
        }
    }

    public class CacheManagerUsage
    {
        public void SampleOne()
        {
            Console.WriteLine("=======> Cache Data (Interview) ");
            CacheManager cacheManager = new();
            cacheManager.AddToCache("user:1", new { Id = 1, Name = "John" });

            if (cacheManager.TryToGetValue("user:1", out var cachedData))
            {
                Console.WriteLine("Cached data : " + cachedData);
            }
            else
            {
                Console.WriteLine("Data not found in the cache");
            }

        }
    }
}