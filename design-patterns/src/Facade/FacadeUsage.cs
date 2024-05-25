namespace design_patterns.src.Facade
{
    public static class FacadeUsage
    {
        public static void SampleOne()
        {
            Console.WriteLine("\nNetwork Facade Usage");
            NetworkFacade networkFacade = new("8.8.8.8", "UDP");
            networkFacade.BuildNetworkLayer();
            networkFacade.SendPacketOverNetwork();
        }
    }
}