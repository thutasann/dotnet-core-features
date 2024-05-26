namespace design_patterns.src.Strategy
{
    public class Context(IStrategy strategy)
    {
        readonly IStrategy strategy = strategy;

        public void ExecuteStrategy()
        {
            strategy.Execute();
        }
    }


}