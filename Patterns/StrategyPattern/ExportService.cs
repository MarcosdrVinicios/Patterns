using Patterns.StrategyPattern.Strategy;

namespace Patterns.StrategyPattern;

internal class ExportService : IExportService
{
    private readonly Dictionary<string, IExporter> exporters = new();

    public ExportService(IEnumerable<IExporter> exporters)
    {
        foreach (var exporter in exporters)
        {
            this.exporters.Add(exporter.FileExtension, exporter);
        }
    }

    public string Export(string fileType, List<string> contacts)
    {
        if (!exporters.TryGetValue(fileType, out var exporter))
        {
            throw new ArgumentException("file type not supported", fileType);
        }

        return exporter.Export(contacts);
    }
}
