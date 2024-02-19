using Microsoft.Extensions.DependencyInjection;
using Patterns.StrategyPattern;
using Patterns.StrategyPattern.ConcreteStrategy;
using Patterns.StrategyPattern.Strategy;

namespace Patterns.Configuration;

internal static class ConfigureServices
{
    internal static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddStrategyPatternServices();

        return services;
    }
    
    private static IServiceCollection AddStrategyPatternServices(this IServiceCollection services)
    {
        services.AddScoped<IExporter, XmlExporter>();
        services.AddScoped<IExporter, CsvExporter>();
        services.AddScoped<IExporter, JsonExporter>();
        services.AddScoped<IExportService, ExportService>();
        
        return services;
    }
}