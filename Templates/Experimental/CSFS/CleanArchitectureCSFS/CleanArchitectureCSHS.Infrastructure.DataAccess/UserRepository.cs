using CleanArchitectureCSFS.Application.Contracts.Repositories;
using CleanArchitectureCSFS.Domain;

namespace CleanArchitectureCSHS.Infrastructure.DataAccess;

public class UserRepository : IUserRepository
{
    public User GetUser()
    {
        return new User()
        {
            Id = Guid.NewGuid(),
            Name = "User"
        };
    }
}