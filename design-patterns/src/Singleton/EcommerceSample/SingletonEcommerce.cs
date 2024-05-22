namespace design_patterns.src.Singleton.EcommerceSample
{
    public static class SingletonEcommerce
    {
        public static void Usage()
        {
            Console.WriteLine("\nSingleton Pattern in Ecommerce : ");
            var paymentServiceClient = new PaymentServiceClient();
            paymentServiceClient.Proceed();
            Logger.Instance.Log("Payment processed");
        }
    }
}