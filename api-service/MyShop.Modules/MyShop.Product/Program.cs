using System.Reflection;
using FluentValidation;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

builder.Services.AddOpenApi();

// Add FluentValidation
builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

var app = builder.Build();

app.MapDefaultEndpoints();

app.MapOpenApi();

app.MapScalarApiReference();

app.UseHttpsRedirection();

app.Run();