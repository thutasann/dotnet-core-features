namespace design_patterns.src.Singleton
{
    /// <summary>
    /// Singleton Sample One
    /// </summary>
    public class Singleton
    {
        static Singleton? instance;
        public string Setting { get; set; } = "Color blue";
        public double IP { get; set; } = 3.3;

        protected Singleton()
        {
        }

        /// <summary>
        /// Instance Method
        /// </summary>
        /// <returns></returns>
        public static Singleton Instance()
        {
            instance ??= new Singleton();
            return instance;
        }
    }
}