namespace CleanArchitectureCSFS.Infrastructure.REST.EndpointGroups.User.Endpoints

open System.Threading
open System.Threading.Tasks
open Microsoft.AspNetCore.Http

open CleanArchitectureCSFS.Application.Contracts.Handlers

module GetUserEndpoint =

    let Handle (handler: IGetUserHandler, cancellationToken: CancellationToken) : Task<IResult> =
        task {
            let result = handler.Handle()
            return Results.Ok(result)
        }