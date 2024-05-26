namespace design_patterns.src.Strategy
{
    public class ARP : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Sending ARP...");
        }
    }
}