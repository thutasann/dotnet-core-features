namespace design_patterns.src.Singleton.EcommerceSample
{
    /// <summary>
    /// Configuration Settings Singleton Class
    /// </summary>
    public class ConfigurationSettings
    {
        private static readonly Lazy<ConfigurationSettings> lazyInstance = new(() => new ConfigurationSettings());

        public string DatabaseConnectionString { get; private set; }
        public string ApiKey { get; private set; }

        private ConfigurationSettings()
        {
            DatabaseConnectionString = "Server=";
            ApiKey = "12345";
        }

        public static ConfigurationSettings Instance
        {
            get
            {
                return lazyInstance.Value;
            }
        }
    }
}