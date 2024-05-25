namespace design_patterns.src.Facade
{
    public class Packet
    {
        public int Id { get; set; }
        public string Data { get; set; } = string.Empty;
        public string IP { get; set; } = string.Empty;

        public Packet(string ip)
        {
            this.IP = ip;
        }

        public void PacketBuild()
        {
            Console.WriteLine("Package Built");
        }
    }
}