using System.Text.RegularExpressions;
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

            Player newPlayer = new(Context.ConnectionId, playerName);
            room.TryAddPlayer(newPlayer);

            await Groups.AddToGroupAsync(Context.ConnectionId, roomId);
            await Clients.All.SendAsync(ConnectionMethods.Rooms, _rooms.OrderBy(r => r.RoomName));
            return room;
        }

        public async Task<GameRoom?> JoinRoom(string roomId, string playerName)
        {
            var room = _rooms.FirstOrDefault(r => r.RoomId == roomId);
            _logger.LogInformation($"Joined Room Name -> {room?.RoomName}");
            if (room is not null)
            {
                _logger.LogInformation($"Joined Room Players Count -> {room.Players.Count}");
                var newPlayer = new Player(Context.ConnectionId, playerName);
                if (room.TryAddPlayer(newPlayer))
                {
                    await Groups.AddToGroupAsync(Context.ConnectionId, roomId);
                    await Clients.Group(roomId).SendAsync(ConnectionMethods.PlayerJoined, newPlayer);
                    return room;
                }
            }
            return null;
        }
    }
}