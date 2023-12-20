using Microsoft.AspNetCore.SignalR;

namespace SignarR_ASP_NET_Core.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(String user, String Message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, Message);
        }
    }
}
