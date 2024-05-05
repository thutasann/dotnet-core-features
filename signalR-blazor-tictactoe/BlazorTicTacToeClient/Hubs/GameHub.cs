using Microsoft.AspNetCore.SignalR;

namespace BlazorTicTacToe.Hubs
{
    public class GameHub(ILogger<GameHub> logger) : Hub
    {
        private readonly ILogger<GameHub> _logger = logger;

        public override Task OnConnectedAsync()
        {
            _logger.LogInformation($"🚀 Player with Id '{Context.ConnectionId}' connected");
            return base.OnConnectedAsync();
        }
    }
}