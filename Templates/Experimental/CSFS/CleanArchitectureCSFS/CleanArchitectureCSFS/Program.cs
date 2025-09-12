using CleanArchitectureCSFS.Extentions;
using CleanArchitectureCSFS.Infrastructure.REST.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddServices();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapEndpoints("/user");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();