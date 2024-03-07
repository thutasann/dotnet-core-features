namespace data_structure_algo.src.OOP.DependcyInjection
{
    public class IEcommerceProduct
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Price { get; set; }
    }

    public class ShoppingCart
    {
        List<IEcommerceProduct> products = new();

        public void AddItems(IEcommerceProduct product)
        {
            products.Add(product);
        }

        public List<IEcommerceProduct> GetItems()
        {
            return products;
        }
    }

    public class OrderService
    {
        private readonly ShoppingCart _shoppingCart;

        public OrderService(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public void PlaceOrder()
        {
            List<IEcommerceProduct> items = _shoppingCart.GetItems();
            Console.WriteLine($"Order placed with items => {items[0].Name}");
        }
    }
}