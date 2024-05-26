using design_patterns.src.ChainOfResponsibility.Model;

namespace design_patterns.src.ChainOfResponsibility
{
    /// <summary>
    /// Interface of Chain
    /// </summary>
    public interface IChain
    {
        void SendRequest(NetworkModel request);
        void SetNext(IChain nextChain);
    }
}