namespace design_patterns.src.Factory.NetworkUtility
{
    /// <summary>
    /// DNS Class
    /// </summary>
    public class DNS : INetwork
    {
        /// <summary>
        /// DNS Send Request
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="timesSent"></param>
        public void SendRequest(string ip, int timesSent)
        {
            Console.WriteLine("DNS request sent to " + ip + " " + timesSent + " times");
        }
    }
}