using CleanArchitectureCSFS.Domain;

namespace CleanArchitectureCSFS.Application.Contracts.Repositories;

public interface IUserRepository
{
    public User GetUser();
}