using design_patterns.src.ChainOfResponsibility;
using design_patterns.src.ChainOfResponsibility.Model;

namespace design_patterns.src.Adapter
{
    public class SendARP : IChain
    {
        private IChain? next;

        public void SendRequest(NetworkModel request)
        {
            if (request.Success == false)
            {
                Console.WriteLine("Send ARP Failed");
                if (next != null)
                {
                    next.SendRequest(request);
                }
                else
                {
                    Console.WriteLine("Network transmission failed. Shutting it down!!!");
                }
            }
            else
            {
                Console.WriteLine("Send ARP Success");
            }
        }

        public void SetNext(IChain nextChain)
        {
            this.next = nextChain;
        }
    }
}