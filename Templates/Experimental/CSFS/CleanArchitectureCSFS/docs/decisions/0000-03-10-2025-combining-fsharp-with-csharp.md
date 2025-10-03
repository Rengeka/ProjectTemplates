# 03-10-2025 Combining F# with C#

## Context and Problem Statement

We're building a backend application that requires:

1. Well-defined data contracts,
2. Robust and maintainable data access (e.g., using Entity Framework Core),
3. Clean and composable business logic (use cases),
4. Clear organization of HTTP endpoints (e.g., via Minimal API or web framework).

F# offers strong type safety, excellent expressiveness, and functional composition capabilities, making it ideal for business logic and endpoint implementation.

C#, on the other hand, has better tooling support for:

1. Data access frameworks (especially Entity Framework Core),
2. OOP paradigm

## Considered Options

* C#
* C# + F#
* F#

## Decision Outcome

Chosen option: "C# + F#", because We will split responsibilities across two languages in the following way:

C# will be used for:

1. Core application startup functionality
2. Implementing the Data Access Layer (Entity Framework Core),
3. Application Contracts
4. Domain Buisness logic

F# will be used for:

1. Application/business logic (use cases)
2. Defining HTTP and grpc endpoints
3. Mapping and Orchestration logic

This setup allows using Functional Programming paradigma for endpoints and use cases, and useing C# OOP for core domain logic and data access