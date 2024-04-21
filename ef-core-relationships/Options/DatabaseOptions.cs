namespace ef_core_relationships.Options
{
    /// <summary>
    /// Database Options From `appsettings`
    /// </summary>
    public class DatabaseOptions
    {
        public string ConnectionString { get; set; } = string.Empty;
        public int MaxRetryCount { get; set; }
        public int CommandTimeout { get; set; }
        public bool EnableDetailedErrors { get; set; }
        public bool EnableSensitiveDataLogging { get; set; }
    }
}