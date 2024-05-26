using design_patterns.src.Adapter.DataProcessorName;
using design_patterns.src.Adapter.Network;

namespace design_patterns.src.Adapter
{
    public class NetworkAdapter(IDataProcessor dataProcessor) : INetworkClient
    {
        private readonly IDataProcessor _dataProcessor = dataProcessor;

        public void SendRequest(string ipAddress)
        {
            var apiKey = "12323123213";
            _dataProcessor.SendNetworkRequest(ipAddress, apiKey);
        }
    }
}