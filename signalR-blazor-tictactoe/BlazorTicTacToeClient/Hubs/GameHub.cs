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
            await Clients.Caller.SendAsync("Rooms", _rooms.OrderBy(r => r.RoomName));
        }
    }
}