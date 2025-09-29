namespace CleanArchitectureCSFS.Infrastructure.REST.Extensions

open System
open System.Runtime.CompilerServices
open Microsoft.AspNetCore.Builder
open System.Reflection
open Microsoft.AspNetCore.Routing

open CleanArchitectureCSFS.Infrastructure.REST.EndpointGroups

[<Extension>]
type WebApplicationExtensions() =

    [<Extension>]
    static member MapEndpointGroups(builder: IEndpointRouteBuilder, assembly: Assembly) : IEndpointRouteBuilder =
        let endpointGroupTypes =
            assembly.GetTypes()
            |> Seq.filter (fun t ->
                typeof<IEndpointGroup>.IsAssignableFrom t &&
                t.IsClass && not t.IsAbstract &&
                Option.isSome (t.GetCustomAttribute<ApiEndpointGroupAttribute>() |> Option.ofObj)
            )

        for t in endpointGroupTypes do
            match t.GetCustomAttribute<ApiEndpointGroupAttribute>() |> Option.ofObj with
            | Some attr ->
                let instance = Activator.CreateInstance(t) :?> IEndpointGroup
                let groupBuilder = builder.MapGroup(attr.Route)
                instance.MapEndpoints(groupBuilder)
            | None -> ()

        builder