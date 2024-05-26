namespace design_patterns.src.Proxy
{
    public static class ProxyUsage
    {
        public static void SampleOne()
        {
            Console.WriteLine("\nProxy Usage Sample One : ");
            ISuperSecretDatabase superSecretDatabase = new SuperSecretDatabaseProxy("test_db", "Password");
            superSecretDatabase.DisplayDatabaseName();
        }
    }
}