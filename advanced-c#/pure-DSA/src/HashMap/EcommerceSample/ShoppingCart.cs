namespace pure_DSA.src.HashMap.EcommerceSample
{
    public class ShoppingCart
    {
        private int totalItems;
        private double totalPrice;

        public ShoppingCart()
        {
            totalItems = 0;
            totalPrice = 0.0;
        }

        public void AddProduct(Product product)
        {
            totalItems++;
            totalPrice += product.GetPrice();
        }

        public int GetTotalItems()
        {
            return totalItems;
        }

        public double GetTotalPrice()
        {
            return totalPrice;
        }

    }
}