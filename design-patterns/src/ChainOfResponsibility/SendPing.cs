using design_patterns.src.ChainOfResponsibility.Model;

namespace design_patterns.src.ChainOfResponsibility
{
    public class SendPing : IChain
    {
        private IChain? next;

        public void SendRequest(NetworkModel request)
        {
            if (request.Success == false)
            {
                Console.WriteLine("Send PING Failed. Sending ARP...");
                next!.SendRequest(request);
            }
            else
            {
                Console.WriteLine("Send PING Success");
            }
        }

        public void SetNext(IChain nextChain)
        {
            next = nextChain;
        }
    }
}