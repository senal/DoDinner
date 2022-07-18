using DoDinner.Application.Common.Interfaces.Persistence;
using DoDinner.Domain.Entities;

namespace DoDinner.Infrastructure.Persistence;

public class UserRepository : IUserRepository
{
    private static List<User> _users = new List<User>();
    public void Add(User user)
    {
        _users.Add(user);
    }

    public User? GetUserByEmail(string email)
    {
        var user = _users.FirstOrDefault(u => u.Email == email);
        return user;
    }
}