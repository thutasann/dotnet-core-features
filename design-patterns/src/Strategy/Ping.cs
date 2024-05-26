namespace design_patterns.src.Strategy
{
    public class Ping : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Sending PING...");
        }
    }
}