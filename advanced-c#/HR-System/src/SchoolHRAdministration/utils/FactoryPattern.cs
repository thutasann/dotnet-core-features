namespace advanced_c_.src.SchoolHRAdministration.utils
{
    /// <summary>
    /// Factory Pattern
    /// </summary>
    /// <typeparam name="K"></typeparam>
    /// <typeparam name="T"></typeparam>
    public static class FactoryPattern<K, T> where T : class, K, new()
    {
        public static K GetInstance()
        {
            K objK;
            objK = new T();
            return objK;
        }
    }
}