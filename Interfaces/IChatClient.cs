using System.Threading.Tasks;
using ChatServidor.Models;

namespace ChatServidor.Interfaces
{
  public interface IChatClient
  {
    Task ReceiveMessage(ChatMessage message);
  }
}