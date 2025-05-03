using MyShop.ServiceDefaults;
using Scalar.AspNetCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.AddApiServiceDefaults(Assembly.GetExecutingAssembly());

builder.Services.AddOpenApi();

var app = builder.Build();

app.MapDefaultEndpoints();

app.MapOpenApi();

app.MapScalarApiReference();

app.UseHttpsRedirection();

app.Run();