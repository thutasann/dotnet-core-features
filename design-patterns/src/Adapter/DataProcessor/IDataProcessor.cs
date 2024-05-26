namespace design_patterns.src.Adapter.DataProcessorName
{
    public interface IDataProcessor
    {
        bool DataProcess();
        void SendNetworkRequest(string ip, string apiKey);
    }
}