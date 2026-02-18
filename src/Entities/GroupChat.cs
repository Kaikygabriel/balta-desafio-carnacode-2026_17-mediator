using Src.Interfaces;

namespace Src.Entities;

public class GroupChat : IGroupChat
{
    public List<User> Users { get; set; } = new();

    public GroupChat()
    {
        
    }
    public void SendMessage(User user,string message)
    {
        if (!user.IsMuted)
        {
            Console.WriteLine($"[{user.Name}] ❌ Você está mutado");
            return;
        }

        Console.WriteLine($"[{user.Name}] Enviou: {message}");

        // Problema: Usuário precisa enviar mensagem para cada membro
        // Isso viola o princípio de responsabilidade única
        foreach (var member in Users)
            ReceiveNotification(member.Name, message);
        
    }
    public void JoinGroup(User members)
    {
        foreach(var m in Users)
            ReceiveNotification(m.Name,$"{members.Name} entrou no grupo");
        
        Users.Add(members);
            
        Console.WriteLine($"[{members.Name}] Entrou no grupo com {Users.Count} membros");
    }
    
    public void ReceiveNotification(string name,string notification)
    {
        Console.WriteLine($"  → [{name}] ℹ️ {notification}");
    }
    
    public void LeaveGroup(User user)
    {
        foreach (var member in Users)
           ReceiveNotification(member.Name,$"{user.Name} saiu do grupo");
        
        Users.Remove(user);
    }
    
    public void MuteUser(User memberMuted,User target)
    {
        memberMuted.IsMuted = true;
        Console.WriteLine($"[{target.Name}] Mutou {memberMuted.Name}");
        
        foreach (var member in Users)
            ReceiveNotification(member.Name,$"{memberMuted.Name} foi mutado por {target.Name}");
    }
    
}