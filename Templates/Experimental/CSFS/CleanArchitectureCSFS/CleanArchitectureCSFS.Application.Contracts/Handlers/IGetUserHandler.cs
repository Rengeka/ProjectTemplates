using CleanArchitectureCSFS.Domain;

namespace CleanArchitectureCSFS.Application.Contracts.Handlers;

public interface IGetUserHandler
{
    public User Handle();
}