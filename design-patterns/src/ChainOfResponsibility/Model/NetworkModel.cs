
namespace design_patterns.src.ChainOfResponsibility.Model
{
    /// <summary>
    /// Network Model
    /// </summary>
    public class NetworkModel(string IP, bool Success)
    {
        public string IP { get; set; } = IP;
        public bool Success { get; set; } = Success;
    }
}