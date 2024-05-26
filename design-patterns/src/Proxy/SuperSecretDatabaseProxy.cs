namespace design_patterns.src.Proxy
{
    public class SuperSecretDatabaseProxy(string databaseName, string password) : ISuperSecretDatabase
    {
        private SuperSecretDatabase? superSecretDatabase;
        private readonly string databaseName = databaseName;
        private readonly string password = password;

        public void DisplayDatabaseName()
        {
            if (password.Equals("Password"))
            {
                if (superSecretDatabase == null)
                {
                    superSecretDatabase = new(databaseName);
                }
                superSecretDatabase!.DisplayDatabaseName();
            }
        }
    }
}