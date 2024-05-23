using design_patterns.src.Factory.NetworkUtility;

namespace design_patterns.src.Factory.NetworkFactoryPath
{
    public class NetworkFactory
    {
        /// <summary>
        /// Get Network Instance
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public INetwork GetNetworkInstance(string type)
        {
            INetwork? obj = null;

            if (type.ToLower().Equals("ping"))
            {
                obj = new Ping();
            }
            else if (type.ToLower().Equals("arp"))
            {
                obj = new ARP();
            }
            else if (type.ToLower().Equals("dns"))
            {
                obj = new DNS();
            }
            else
            {
                Console.WriteLine($"Type {type} is not found");
            }

            return obj!;
        }
    }
}