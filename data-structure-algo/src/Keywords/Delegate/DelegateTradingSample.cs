namespace data_structure_algo.src.Keywords.Delegate
{
    /// <summary>
    /// Delegate for Trading Strategy
    /// </summary>
    public delegate void TradingStrategy(string Symbol, double price);

    /// <summary>
    /// Scalping Strategy
    /// </summary>
    public class ScalpingStrategy
    {
        public void Execute(string symbol, double price)
        {
            Console.WriteLine($"Executing scalping strategy for {symbol} at {price}");
        }
    }

    public class TrendFollowingStrategy
    {
        public void Execute(string symbol, double price)
        {
            Console.WriteLine($"Executing trend follwoing strategy for {symbol} at {price}");
        }
    }

    public class MeanReversionStrategy
    {
        public void Execute(string symbol, double price)
        {
            Console.WriteLine($"Executing Mean reversion strategy for {symbol} at {price}");
        }
    }

    public class OrderManager
    {
        public Dictionary<string, TradingStrategy> strategies;

        public OrderManager()
        {
            strategies = new();
        }

        // Method to register trading strategies
        public void RegisterStrategy(string strategyName, TradingStrategy tradingStrategy)
        {
            strategies[strategyName] = tradingStrategy;
        }

        // Method to process market data and execute strategies
        public void ProcessMarketData(string symbol, double price)
        {
            Console.WriteLine($"Received market data for {symbol} at {price}");

            foreach (var strategy in strategies.Values)
            {
                strategy(symbol, price);
            }
        }
    }

    public class DelegateTradingStrategyUsage
    {
        public void SampleOne()
        {
            var orderManager = new OrderManager();

            var scalpingStrategy = new ScalpingStrategy();
            var trendFollowingStrategy = new TrendFollowingStrategy();
            var meanReversionStrategy = new MeanReversionStrategy();

            orderManager.RegisterStrategy("Scalping", scalpingStrategy.Execute);
            orderManager.RegisterStrategy("TrendFollowing", trendFollowingStrategy.Execute);
            orderManager.RegisterStrategy("MeanReversion", meanReversionStrategy.Execute);

            orderManager.ProcessMarketData("AAPL", 150.25);
        }
    }

}