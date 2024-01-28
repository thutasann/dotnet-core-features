using Microsoft.AspNetCore.SignalR;

namespace practical_signalR.Hubs
{
    public class MessageHub : Hub
    {
        public Task SendMessageToAll(string message)
        {
            return Clients.All.SendAsync("ReceiveMesssage", message);
        }
    }
}