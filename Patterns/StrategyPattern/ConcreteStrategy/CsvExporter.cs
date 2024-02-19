namespace Patterns.StrategyPattern.ConcreteStrategy;

using Patterns.StrategyPattern.Strategy;

internal class CsvExporter : IExporter
{
    public string FileExtension => "csv";

    public string Export(List<string> contacts)
    {
        return FileExtension + " " + string.Join(", ", contacts.ToArray());
    }
}
