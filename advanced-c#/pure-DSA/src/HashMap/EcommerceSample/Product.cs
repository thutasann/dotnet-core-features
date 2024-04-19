namespace pure_DSA.src.HashMap.EcommerceSample
{
    public class Product
    {
        private readonly string name = string.Empty;
        private readonly double price;

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public string GetName()
        {
            return name;
        }

        public double GetPrice()
        {
            return price;
        }
    }
}