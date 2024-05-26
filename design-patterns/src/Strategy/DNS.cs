namespace design_patterns.src.Strategy
{
    public class DNS : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Sending DNS...");
        }
    }
}