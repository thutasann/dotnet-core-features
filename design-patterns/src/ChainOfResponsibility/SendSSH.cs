using design_patterns.src.ChainOfResponsibility.Model;

namespace design_patterns.src.ChainOfResponsibility
{
    public class SendSSH : IChain
    {
        private IChain? next;

        public void SendRequest(NetworkModel request)
        {
            if (request.Success == false)
            {
                Console.WriteLine("Send SSH Failed. Sending PING...");
                next!.SendRequest(request);
            }
            else
            {
                Console.WriteLine("Send SSH Success");
            }
        }

        public void SetNext(IChain nextChain)
        {
            next = nextChain;
        }
    }
}