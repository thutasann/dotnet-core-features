namespace design_patterns.src.Proxy
{
    /// <summary>
    /// Super Secret Database
    /// </summary>
    public class SuperSecretDatabase(string databaseName) : ISuperSecretDatabase
    {
        private readonly string _databaseName = databaseName;

        public void DisplayDatabaseName()
        {
            Console.WriteLine("Display database name : " + _databaseName);
        }
    }
}