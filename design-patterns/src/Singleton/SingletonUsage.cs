namespace design_patterns.src.Singleton
{
    public static class SingletonUsage
    {
        public static void SampleOne()
        {
            Console.WriteLine("\nSingleton Usage SampleOne ---> ");
            Singleton object1 = Singleton.Instance();
            Singleton object2 = Singleton.Instance();

            if (object1 == object2)
            {
                Console.WriteLine("These objects are the same");
            }
        }
    }
}