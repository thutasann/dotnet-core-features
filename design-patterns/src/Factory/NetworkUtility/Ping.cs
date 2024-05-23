namespace design_patterns.src.Factory.NetworkUtility
{
    /// <summary>
    /// Ping Class
    /// </summary>
    public class Ping : INetwork
    {
        /// <summary>
        /// Ping Send Request
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="timesSent"></param>
        public void SendRequest(string ip, int timesSent)
        {
            Console.WriteLine("Ping request sent to " + ip + " " + timesSent + " times");
        }
    }
}