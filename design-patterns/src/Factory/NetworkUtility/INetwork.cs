namespace design_patterns.src.Factory.NetworkUtility
{
    /// <summary>
    /// Abstracting with Network Interface
    /// </summary>
    public interface INetwork
    {
        void SendRequest(string ip, int timesSent);
    }
}