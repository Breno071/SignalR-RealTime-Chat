using System.Threading.Tasks;
using ChatServidor.Interfaces;
using ChatServidor.Models;
using Microsoft.AspNetCore.SignalR;

namespace ChatServidor
{
  public class ChatHub : Hub<IChatClient>
  {
    public async Task SendMessage(ChatMessage message)
    {
      await Clients.All.ReceiveMessage(message);
    }
  }
}