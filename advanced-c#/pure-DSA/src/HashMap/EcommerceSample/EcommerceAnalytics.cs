namespace pure_DSA.src.HashMap.EcommerceSample
{
    public class EcommerceAnalytics
    {
        private Dictionary<string, ShoppingCart> userShoppingCarts;

        public EcommerceAnalytics()
        {
            userShoppingCarts = new();
        }

        public void AddToCart(string userId, Product product)
        {
            if (!userShoppingCarts.ContainsKey(userId))
            {
                userShoppingCarts[userId] = new();
            }
            ShoppingCart shoppingCart = userShoppingCarts[userId];
            shoppingCart.AddProduct(product);
        }

        public void ProcessShoppingCarts()
        {
            foreach (var kvp in userShoppingCarts)
            {
                string userId = kvp.Key;
                ShoppingCart shoppingCart = kvp.Value;

                Console.WriteLine($"User Id: {userId}");
                Console.WriteLine($"Total Items: {shoppingCart.GetTotalItems()}");
                Console.WriteLine($"Total Price: ${shoppingCart.GetTotalPrice()}");
                Console.WriteLine("-----------------------");
            }
        }
    }

    public static class EcommerceHashMapUsage
    {
        public static void SampleOne()
        {
            Console.WriteLine("\nEcommerce HashMap Usage...");
            EcommerceAnalytics ecommerceAnalytics = new();
            ecommerceAnalytics.AddToCart("user1", new Product("Laptop", 989.99));
            ecommerceAnalytics.AddToCart("user1", new Product("Mouse", 19.99));
            ecommerceAnalytics.AddToCart("user2", new Product("Phone", 799.99));
            ecommerceAnalytics.AddToCart("user2", new Product("Headphones", 49.99));
            ecommerceAnalytics.AddToCart("user3", new Product("Tablet", 499.99));

            ecommerceAnalytics.ProcessShoppingCarts();
        }
    }

}