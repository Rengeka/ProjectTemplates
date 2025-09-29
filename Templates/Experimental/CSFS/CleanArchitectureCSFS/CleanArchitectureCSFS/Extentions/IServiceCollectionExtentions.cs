using CleanArchitectureCSFS.Application.Contracts.Handlers;
using CleanArchitectureCSFS.Application.Contracts.Repositories;
using CleanArchitectureCSFS.Application.UseCases.Handlers;
using CleanArchitectureCSHS.Infrastructure.DataAccess;

namespace CleanArchitectureCSFS.Extentions;

public static class IServiceCollectionExtentions
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IGetUserHandler, GetUserHandler>();

        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
}