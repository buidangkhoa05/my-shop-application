using FluentValidation;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;

namespace MyShop.ServiceDefaults;

public static class ApiServiceExtensions
{
    public static TBuilder AddApiServiceDefaults<TBuilder>(this TBuilder builder, Assembly assembly)
        where TBuilder : IHostApplicationBuilder
    {
        builder.AddServiceDefaults();

        // FluentValidation
        builder.Services.AddValidatorsFromAssembly(assembly, includeInternalTypes: true);

        // MediatR
        builder.Services.AddMediatR(cfg => { cfg.RegisterServicesFromAssembly(assembly); });

        return builder;
    }
}