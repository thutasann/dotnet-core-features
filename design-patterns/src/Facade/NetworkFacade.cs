namespace design_patterns.src.Facade
{
    /// <summary>
    /// Network Facade
    /// </summary>
    public class NetworkFacade
    {
        private Packet packet;
        private Socket socket;
        private Transmission transmission;

        public NetworkFacade(string ip, string protocol)
        {
            this.packet = new Packet(ip);
            this.socket = new Socket(protocol);
            this.transmission = new Transmission(protocol);
        }

        public void BuildNetworkLayer()
        {
            packet.PacketBuild();
            socket.SocketBuild();
        }

        public void SendPacketOverNetwork()
        {
            BuildNetworkLayer();
            transmission.SendTransmission();
        }
    }
}