using Src.Interfaces;

namespace Src.Entities;

public class User
{
    public User(string name)
    {
        _groupMembers = new();
        Name = name;
    }

    public string Name { get; set; }
    public bool IsMuted { get; set; }
    private List<IGroupChat> _groupMembers;
    
    
    public void SendPrivateMessage(User recipient, string message)
    {
        if (IsMuted)
        {
            Console.WriteLine($"[{Name}] ❌ Você está mutado");
            return;
        }

        Console.WriteLine($"[{Name}] Enviou mensagem privada para {recipient.Name}");
        ReceivePrivateMessage(Name, message);
    }
    
    public void ReceivePrivateMessage(string senderName, string message)
    {
        Console.WriteLine($"  → [{Name}] 🔒 Mensagem privada de {senderName}: {message}");
    }
}