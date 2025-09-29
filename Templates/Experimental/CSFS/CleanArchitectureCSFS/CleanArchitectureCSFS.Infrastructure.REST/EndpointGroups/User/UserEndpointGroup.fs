module UserEndpointGroup

open System
open Microsoft.AspNetCore.Routing
open Microsoft.AspNetCore.Http
open System.Threading.Tasks
open Microsoft.AspNetCore.Builder

open CleanArchitectureCSFS.Infrastructure.REST.EndpointGroups
open CleanArchitectureCSFS.Application.Contracts.Handlers
open CleanArchitectureCSFS.Infrastructure.REST.EndpointGroups.User.Endpoints

[<Literal>]
let GroupName = "user"

[<ApiEndpointGroup(GroupName)>]
type UserEndpointGroup() =

    interface IEndpointGroup with
        member _.MapEndpoints(builder: IEndpointRouteBuilder) =
            builder.MapGet(
                "",
                Func<HttpContext, Task<IResult>>(fun ctx -> 
                    let cancellationToken = ctx.RequestAborted
                    let handler = ctx.RequestServices.GetService(typeof<IGetUserHandler>) :?> IGetUserHandler
                    GetUserEndpoint.Handle(handler, cancellationToken)
                )
            ).WithTags(GroupName)
            |> ignore