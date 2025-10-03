# 🌐 CleanArchitectureCSFS — ASP.NET Template with C# & F#

A modern, modular ASP.NET Core template combining the power of **C#** and **F#** for clean architecture, functional endpoints, and scalable design.

## 🚀 Features

- ✅ ASP.NET Core 8.0+
- ✅ C# for domain logic and infrastructure
- ✅ F# for expressive routing and functional composition
- ✅ Minimal API with DI support
- ✅ Clean Architecture principles
- ✅ Swagger/OpenAPI integration
- ✅ Ready for RESTful services

## 🧠 Why C# + F#?

- **C#**: Familiar, rich ecosystem, great for enterprise logic and tooling.
- **F#**: Concise, expressive, ideal for defining clean, composable endpoints.

## ⚠️ Important Note

> When working with a mixed C# + F# solution, **any changes in F# code require recompilation of the Assembly** for C# to see the updates (and vice versa). Always rebuild the project/solution after modifying code in the other language to avoid runtime errors or stale metadata.

> Do not forget to read [ADR](./docs/decisions/0000-03-10-2025-combining-fsharp-with-csharp.md) before starting working with this template!

## 🛠️ Getting Started

### Prerequisites

- [.NET SDK 9.0+](https://dotnet.microsoft.com/download)
- Visual Studio 2022+ or JetBrains Rider
- Optional: VS Code with Ionide extension for F#

### Build & Run

```bash
dotnet restore
dotnet build
dotnet run --project CleanArchitectureCSFS
```

Once running, navigate to:

```bash
https://localhost:<port>/swagger
```

## 📦 NuGet Packages Used
Microsoft.AspNetCore.OpenApi

Swashbuckle.AspNetCore

Microsoft.FSharp.Core

## 📚 Resources
F# for Fun and Profit

ASP.NET Core Docs

Minimal APIs in ASP.NET

## 🤝 Contributing
Pull requests welcome! Feel free to open issues or suggest improvements.