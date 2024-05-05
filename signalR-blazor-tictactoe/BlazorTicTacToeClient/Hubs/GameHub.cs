using BlazorTicTacToeShared;
using Microsoft.AspNetCore.SignalR;

namespace BlazorTicTacToeClient.Hubs
{
    public class GameHub(ILogger<GameHub> logger) : Hub
    {
        private static readonly List<GameRoom> _rooms = new();
        private readonly ILogger<GameHub> _logger = logger;

        public override async Task OnConnectedAsync()
        {
            _logger.LogInformation($"🚀 Player with Id '{Context.ConnectionId}' connected");
            await Clients.Caller.SendAsync(ConnectionMethods.Rooms, _rooms.OrderBy(r => r.RoomName));
        }

        public async Task<GameRoom> CreateRoom(string name, string playerName)
        {
            var roomId = Guid.NewGuid().ToString();
            var room = new GameRoom(roomId, name);
            _rooms.Add(room);
            await Clients.All.SendAsync(ConnectionMethods.Rooms, _rooms.OrderBy(r => r.RoomName));
            return room;
        }
    }
}