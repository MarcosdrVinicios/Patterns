namespace StrategyPattern;

internal class XmlExporter : IExporter
{
    public string FileExtension => "xml";

    public string Export(List<string> contacts)
    {
        return FileExtension + " " + String.Join(", ", contacts.ToArray());
    }
}
