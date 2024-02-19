namespace Patterns.StrategyPattern.ConcreteStrategy;

using Patterns.StrategyPattern.Strategy;

internal class XmlExporter : IExporter
{
    public string FileExtension => "xml";

    public string Export(List<string> contacts)
    {
        return FileExtension + " " + string.Join(", ", contacts.ToArray());
    }
}
