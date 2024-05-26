namespace design_patterns.src.Strategy
{
    public static class StrategyPatternUsage
    {
        public static void SampleOne()
        {
            Console.WriteLine("\nStrategy Pattern Usage ");
            Context arpContext = new(new ARP());
            Context pingContext = new(new Ping());
            Context dnsContext = new(new DNS());

            arpContext.ExecuteStrategy();
            pingContext.ExecuteStrategy();
            dnsContext.ExecuteStrategy();
        }
    }
}