namespace BlazorTicTacToeShared
{
    /// <summary>
    /// Player Entitiy
    /// </summary>
    public class Player(string connectionId, string name)
    {
        public string ConnectionId { get; set; } = connectionId;
        public string Name { get; set; } = name;
    }
}