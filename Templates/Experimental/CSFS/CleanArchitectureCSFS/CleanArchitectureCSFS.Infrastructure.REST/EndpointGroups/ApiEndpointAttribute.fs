namespace CleanArchitectureCSFS.Infrastructure.REST.EndpointGroups

open System

[<AttributeUsage(AttributeTargets.Class, AllowMultiple = false)>]
type ApiEndpointGroupAttribute(route: string) =
    inherit Attribute()
    member val Route = route with get, set