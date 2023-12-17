namespace StrategyPattern;

internal class ExportService : IExportService
{
    private readonly Dictionary<string, IExporter> _exporters = new();

    public ExportService(IEnumerable<IExporter> exporters)
    {
        foreach (var exporter in exporters)
        {
            _exporters.Add(exporter.FileExtension, exporter);
        }
    }

    public string Export(string fileType, List<string> contacts)
    {
        if (!_exporters.TryGetValue(fileType, out var exporter))
        {
            throw new ArgumentException("file type not supported", fileType);
        }

        return exporter.Export(contacts);
    }
}
