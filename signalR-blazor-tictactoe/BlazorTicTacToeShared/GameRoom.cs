namespace BlazorTicTacToeShared
{
    /// <summary>
    /// Game Room Entity
    /// </summary>
    public class GameRoom
    {
        public string RoomId { get; set; } = string.Empty;
        public string RoomName { get; set; } = string.Empty;

        public GameRoom(string roomId, string roomName)
        {
            RoomId = roomId;
            RoomName = roomName;
        }
    }
}