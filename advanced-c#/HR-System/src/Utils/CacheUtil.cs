namespace advanced_c_.src.Utils
{
    public static class CacheUtil
    {
        private class CachedItem
        {
            public string Data { get; set; } = string.Empty;
            public DateTime ExpiryTime { get; set; }
        }

        private static Dictionary<string, CachedItem> cache = new();

        public static string GetData(string key)
        {
            lock (cache)
            {
                if (cache.ContainsKey(key) && cache[key].ExpiryTime > DateTime.Now)
                {
                    Console.WriteLine("Data Retrieved from cache");
                    return cache[key].Data;
                }
                else
                {
                    string data = FetchDataFromSource(key);

                    cache[key] = new CachedItem
                    {
                        Data = data,
                        ExpiryTime = DateTime.UtcNow.AddMinutes(1)
                    };
                    Console.WriteLine("Data retrieved form original source and cached");
                    return data;
                }
            }
        }

        public static void RevalidateCache(object state)
        {
            Console.WriteLine("Revalidating cache...");
            lock (cache)
            {
                foreach (var key in cache.Keys)
                {
                    if (cache[key].ExpiryTime <= DateTime.UtcNow)
                    {
                        string newData = FetchDataFromSource(key);
                        cache[key] = new CachedItem
                        {
                            Data = newData,
                            ExpiryTime = DateTime.UtcNow.AddMinutes(1)
                        };
                        Console.WriteLine($"Data for key '{key}' revalidated and updated in cache.");
                    }
                }
            }
        }

        private static string FetchDataFromSource(string key)
        {
            return $"Data for key {key} fetched from original source.";
        }
    }
}