namespace design_patterns.src.Adapter.Network
{
    public interface INetworkClient
    {
        void SendRequest(string ipAddress);
    }
}