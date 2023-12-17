namespace StrategyPattern;

internal class CsvExporter : IExporter
{
    public string FileExtension => "csv";

    public string Export(List<string> contacts)
    {
        return FileExtension + " " + String.Join(", ", contacts.ToArray());
    }
}
