using Microsoft.AspNetCore.SignalR;

namespace practical_signalR_mvc.Hubs
{
    public class MessageHub : Hub
    {
        private readonly ILogger<MessageHub> _logger;

        public MessageHub(ILogger<MessageHub> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Send Message To All
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public Task SendMessageToAll(string message)
        {
            return Clients.All.SendAsync("ReceiveMesssage", message);
        }

        /// <summary>
        /// Send Message only to Caller
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public Task SendMessageToCaller(string message)
        {
            return Clients.Caller.SendAsync("ReceiveMesssage", message);
        }

        /// <summary>
        /// Send Mesage to the specific Connection
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Task SendMessageToUser(string connectionId, string message)
        {
            return Clients.Client(connectionId).SendAsync("ReceiveMesssage", message);
        }

        /// <summary>
        /// Join Group
        /// </summary>
        /// <returns></returns>
        public Task JoinGroup(string group)
        {
            _logger.LogInformation("User Joined the Group " + group);
            return Groups.AddToGroupAsync(Context.ConnectionId, group);
        }

        /// <summary>
        /// Send Message To Group
        /// </summary>
        /// <param name="group"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Task SendMessageToGroup(string group, string message)
        {
            _logger.LogInformation("Group Name " + group);
            _logger.LogInformation("Message => " + message);
            return Clients.Group(group).SendAsync("ReceiveMesssage", message);
        }

        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("UserConnected", Context.ConnectionId);
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            await Clients.All.SendAsync("UserDisconnected", Context.ConnectionId);
            await base.OnDisconnectedAsync(exception);
        }
    }
}