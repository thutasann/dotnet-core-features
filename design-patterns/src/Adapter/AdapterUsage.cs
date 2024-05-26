using design_patterns.src.Adapter.DataProcessorName;
using design_patterns.src.Adapter.Network;

namespace design_patterns.src.Adapter
{
    public static class AdapterUsage
    {
        public static void SampleOne()
        {
            Console.WriteLine("\nAdapter Usage Sample One : ");
            INetworkClient network = new NetworkClient();
            network.SendRequest("8.7.7.7");

            IDataProcessor dataProcessor = new DataProcessor();
            dataProcessor.SendNetworkRequest("8.8.8.6", "adafefd123");

            NetworkAdapter networkAdapter = new NetworkAdapter(dataProcessor);
            networkAdapter.SendRequest("4.5.5.6");
        }
    }
}