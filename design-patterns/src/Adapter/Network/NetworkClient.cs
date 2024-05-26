namespace design_patterns.src.Adapter.Network
{
    /// <summary>
    /// Network Client
    /// </summary>
    public class NetworkClient : INetworkClient
    {
        public void SendRequest(string ipAddress)
        {
            Console.WriteLine("Network client request sent to IP : " + ipAddress);
        }
    }
}