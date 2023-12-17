namespace StrategyPattern;

public interface IExporter
{
    string Export(List<string> contacts);
    string FileExtension { get; }
}
