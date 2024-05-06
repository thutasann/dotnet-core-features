namespace BlazorTicTacToeShared
{
    /// <summary>
    /// Socket Event Names
    /// </summary>
    public static class ConnectionMethods
    {
        public static string Rooms = "Rooms";
        public static string CreateRoom = "CreateRoom";
        public static string UpdateRoom = "UpdateRoom";
        public static string JoinRoom = "JoinRoom";
        public static string PlayerJoined = "PlayerJoined";
        public static string StartGame = "StartGame";
        public static string UpdateGame = "UpdateGame";
        public static string GameStarted = "GameStarted";
        public static string MakeMove = "MakeMove";
    }
}