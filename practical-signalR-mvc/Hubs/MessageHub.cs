using Microsoft.AspNetCore.SignalR;

namespace practical_signalR_mvc.Hubs
{
    public class MessageHub : Hub
    {
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