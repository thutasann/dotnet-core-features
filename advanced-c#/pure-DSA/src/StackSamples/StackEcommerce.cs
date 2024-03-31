namespace pure_DSA.src.StackSamples
{
    public static class StackEcommerce
    {
        public static void SampleOne()
        {
            Console.WriteLine("\nEcommerce Stack Sample ===> ");
            Stack<string> shoppingCart = new();
            AddToCart(shoppingCart, "Product 1");
            AddToCart(shoppingCart, "Product 2");
            AddToCart(shoppingCart, "Product 3"); // last in -> first out

            Console.WriteLine("Original items in the shopping cart:");
            PrintCartContent(shoppingCart);

            RemoveFromCart(shoppingCart);

            Console.WriteLine("Updated items in the shopping cart:");
            PrintCartContent(shoppingCart);
        }

        private static void AddToCart(Stack<string> cart, string product)
        {
            cart.Push(product);
            Console.WriteLine($"Product {product} added to cart");
        }

        private static void RemoveFromCart(Stack<string> cart)
        {
            if (cart.Count > 0)
            {
                string removedProduct = cart.Pop();
                Console.WriteLine($"Removed {removedProduct} from the cart");
            }
            else
            {
                Console.WriteLine("The shopping cart is empty. Cannot remove any more items.");
            }
        }

        private static void PrintCartContent(Stack<string> cart)
        {
            foreach (var item in cart)
            {
                Console.WriteLine("Shopping Cart => " + item);
            }
        }
    }
}