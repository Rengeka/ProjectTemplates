using CleanArchitectureCSFS.Extentions;
using CleanArchitectureCSFS.Infrastructure.REST.EndpointGroups.User.Endpoints;
using CleanArchitectureCSFS.Infrastructure.REST.Extensions;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddServices();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapEndpointGroups(Assembly.GetAssembly(typeof(GetUserEndpoint)));

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();