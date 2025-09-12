namespace CleanArchitectureCSFS.Infrastructure.REST.Extensions

open System
open System.Runtime.CompilerServices
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Http

open CleanArchitectureCSFS.Application.Contracts.Handlers
open CleanArchitectureCSFS.Domain

[<Extension>]
type WebApplicationExtensions() =

    [<Extension>]
    static member MapEndpoints(app: WebApplication, path: string) =
        app.MapGet(path, Func<HttpContext, User>(fun ctx ->
            let handler = ctx.RequestServices.GetService(typeof<IGetUserHandler>) :?> IGetUserHandler
            handler.Handle()
        )) |> ignore
        app