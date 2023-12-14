using Microsoft.AspNetCore.SignalR;

namespace Webfaggruppe.Hubs
{
    public class MyFirstHub : Hub
    {
        public async Task SendMessageToAllClients(string message)
        {
            Console.WriteLine($"Message from client {message}");
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}