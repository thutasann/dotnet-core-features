namespace design_patterns.src.Factory.NetworkUtility
{
    /// <summary>
    /// ARP Class
    /// </summary>
    public class ARP : INetwork
    {
        /// <summary>
        /// ARP Send Request
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="timesSent"></param>
        public void SendRequest(string ip, int timesSent)
        {
            Console.WriteLine("ARP request sent to " + ip + " " + timesSent + " times");
        }
    }
}