using Microsoft.AspNetCore.SignalR;

namespace RealTimeApi.Hubs
{
    public class NotificationHub:Hub
    {
        // Clients can call this method to broadcast a message to everyone
        public async Task SendNotification(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveNotification", user, message);
        }
    }
}
