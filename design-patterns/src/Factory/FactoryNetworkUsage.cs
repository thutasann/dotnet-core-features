using design_patterns.src.Factory.NetworkFactoryPath;

namespace design_patterns.src.Factory
{
    /// <summary>
    /// Factory Pattern Network usage
    /// </summary>
    public static class FactoryNetworkUsage
    {
        public static void SampleOne()
        {
            Console.WriteLine("\nFactory Pattern Usage : ");
            NetworkFactory networkFactory = new();
            var ping = networkFactory.GetNetworkInstance("ping");
            var dns = networkFactory.GetNetworkInstance("dns");
            var arp = networkFactory.GetNetworkInstance("arp");

            ping.SendRequest("11111", 1);
            dns.SendRequest("22222", 2);
            arp.SendRequest("33333", 3);
        }
    }
}