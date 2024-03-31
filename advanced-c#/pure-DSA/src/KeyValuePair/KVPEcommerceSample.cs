namespace pure_DSA.src.KeyValuePair
{
    public static class KVPEcommerceSample
    {
        public static void SampleOne()
        {
            Console.WriteLine("\nKVP Ecommerce Sample ====> ");
            var products = new Dictionary<int, decimal>
            {
                { 1001, 29.99m },
                { 1002, 49.99m },
                { 1003, 79.99m }
            };

            Console.WriteLine("Available Products...");
            foreach (var product in products)
            {
                Console.WriteLine($"ProductID {product.Key}, Price: {product.Value}");
            }

            var shoppingCart = new List<KeyValuePair<int, int>>
            {
                new(1001, 2),
                new(1003, 1)
            };

            Console.WriteLine("Shopping Cart...");
            foreach (var item in shoppingCart)
            {
                int productId = item.Key;
                int quantity = item.Value;
                decimal price = products[productId];
                Console.WriteLine($"ProductID: {productId}, Quantity: {quantity}, Price: {price}");
            }

            decimal totalPrice = 0;
            foreach (var item in shoppingCart)
            {
                int productId = item.Key;
                int quantity = item.Value;
                decimal price = products[productId];
                totalPrice += price * quantity;
            }
            Console.WriteLine($"Total Price: ${totalPrice}");
        }
    }
}