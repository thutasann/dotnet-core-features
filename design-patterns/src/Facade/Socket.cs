namespace design_patterns.src.Facade
{
    public class Socket
    {
        public int Id { get; set; }
        public int Port { get; set; }
        public string Protocol { get; set; }

        public Socket(string protocol)
        {
            Protocol = protocol;
        }

        public void SocketBuild()
        {
            Console.WriteLine("Socket Built");
        }
    }
}