namespace StrategyPattern;

internal class JsonExporter : IExporter
{
    public string FileExtension => "json";

    public string Export(List<string> contacts)
    {
        return FileExtension + " " + String.Join(", ", contacts.ToArray());
    }
}
