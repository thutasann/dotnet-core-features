using design_patterns.src.Adapter;
using design_patterns.src.ChainOfResponsibility.Model;

namespace design_patterns.src.ChainOfResponsibility
{
    public static class ChainOfResponsibilityUsage
    {
        public static void SampleOne()
        {
            Console.WriteLine("\nChain of responsibility usage : ");
            SendSSH ssh = new();
            SendPing ping = new();
            SendARP arp = new();

            ssh.SetNext(ping);
            ping.SetNext(arp);

            NetworkModel request = new("8.8.8.8", false); // hard-coded

            ssh.SendRequest(request);
        }
    }
}