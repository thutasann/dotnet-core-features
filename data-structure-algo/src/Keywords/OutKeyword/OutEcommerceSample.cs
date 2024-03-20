namespace data_structure_algo.src.Keywords.OutKeyword
{
    public class OutOrder
    {
        public decimal CalculatTotalPrice(int productId, int quantity, out decimal discount)
        {
            decimal productPrice = GetProductPrice(productId);

            decimal totalPrice = productPrice * quantity;

            if (quantity >= 10)
            {
                discount = totalPrice * 0.1m;
            }
            else
            {
                discount = 0;
            }

            return totalPrice - discount;
        }

        private decimal GetProductPrice(int productId)
        {
            return 50m;
        }
    }

    public class OutEcommerceUsage
    {
        public void SampleOne()
        {
            OutOrder outOrder = new();

            int productId = 123;
            int quanity = 15;

            decimal totalPrice = outOrder.CalculatTotalPrice(productId, quanity, out decimal discount);

            Console.WriteLine($"Total Price : {totalPrice:C}");
            Console.WriteLine($"Discount : {discount:C}");
        }
    }
}