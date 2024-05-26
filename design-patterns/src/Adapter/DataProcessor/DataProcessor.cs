namespace design_patterns.src.Adapter.DataProcessorName
{
    /// <summary>
    /// Data Processor
    /// </summary>
    public class DataProcessor : IDataProcessor
    {
        public bool DataProcess()
        {
            Console.WriteLine("Processed data :");
            return true;
        }

        public void SendNetworkRequest(string ip, string apiKey)
        {
            Console.WriteLine("Send network request with IP Address that requires API Key " + ip);
        }
    }
}