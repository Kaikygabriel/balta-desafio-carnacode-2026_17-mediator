using Src.Entities;

namespace Src.Interfaces;

public interface IGroupChat
{
    void JoinGroup(User user);
    void ReceiveNotification(string name, string notification);
    void LeaveGroup(User user);
    void MuteUser(User memberMuted, User target);
}