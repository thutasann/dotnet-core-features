namespace design_patterns.src.Facade
{
    public class Transmission
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public Transmission(string protocolName)
        {
            Name = protocolName;
        }

        public void SendTransmission()
        {
            Console.WriteLine("Sent Transmission");
        }
    }
}