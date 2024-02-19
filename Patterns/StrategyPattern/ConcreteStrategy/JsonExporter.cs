namespace Patterns.StrategyPattern.ConcreteStrategy;

using Patterns.StrategyPattern.Strategy;

internal class JsonExporter : IExporter
{
    public string FileExtension => "json";

    public string Export(List<string> contacts)
    {
        return FileExtension + " " + string.Join(", ", contacts.ToArray());
    }
}
