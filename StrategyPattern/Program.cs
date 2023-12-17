// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using StrategyPattern;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
    {
        services.AddScoped<IExporter, XmlExporter>();
        services.AddScoped<IExporter, CsvExporter>();
        services.AddScoped<IExporter, JsonExporter>();

        services.AddScoped<IExportService, ExportService>();
    }).Build();

var contacts = new List<string> { "contact1", "contact2", "contact3", };

var exportService = host.Services.GetRequiredService<IExportService>();
var exportResult = exportService.Export("json", contacts);

Console.WriteLine(exportResult);