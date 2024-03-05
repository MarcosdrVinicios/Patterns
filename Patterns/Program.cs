// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Patterns.Configuration;
using Patterns.FactoryMethod;
using Patterns.FactoryMethod.ConcreteCreator;
using Patterns.ObserverPattern;
using Patterns.StrategyPattern;

using var host = Host.CreateDefaultBuilder(args).ConfigureServices((_, services) => { services.AddServices(); })
    .Build();


void StrategyPattern(IHost host1)
{
    var contacts = new List<string> { "contact1", "contact2", "contact3" };
    var exportService = host1.Services.GetRequiredService<IExportService>();
    var exportResult = exportService.Export("json", contacts);

    Console.WriteLine(exportResult);
}

void ObserverPattern()
{
    // Configure Observer pattern
    MicrosoftNews news = new();
    news.Attach(new Reader("Marcos"));
    news.Attach(new Reader("Vinicios"));
    news.Attach(new Reader("Dinis"));
    // Change subject and notify observers
    news.Notice = "Hello 2024";
    news.Notice = "Have a great year";
    Console.ReadKey();
}

void FactoryMethod()
{
    CreateDelivery(new TruckCreator());
    CreateDelivery(new CarCreator());

    static void CreateDelivery(TransportCreator transportCreator)
    {
        Console.WriteLine("I don't know what's the concret class but " + transportCreator.Deliver());
    }
}


//StrategyPattern(host);
//ObserverPattern();
//FactoryMethod();
