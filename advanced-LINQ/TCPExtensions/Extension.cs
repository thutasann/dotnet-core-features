namespace TCPExtensions
{
    public static class Extension
    {
        /// <summary>
        /// Extension Filtered Method
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="records"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static List<T> Filter<T>(this List<T> records, Func<T, bool> func)
        {
            List<T> filteredList = new();
            foreach (T record in records)
            {
                if (func(record))
                {
                    filteredList.Add(record);
                }
            }
            return filteredList;
        }
    }
}