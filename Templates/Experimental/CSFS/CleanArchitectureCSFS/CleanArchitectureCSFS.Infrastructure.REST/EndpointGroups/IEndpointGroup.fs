namespace CleanArchitectureCSFS.Infrastructure.REST.EndpointGroups

open Microsoft.AspNetCore.Routing

type IEndpointGroup =
    abstract member MapEndpoints : builder:IEndpointRouteBuilder -> unit