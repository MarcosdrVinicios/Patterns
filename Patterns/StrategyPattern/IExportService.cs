namespace Patterns.StrategyPattern;

internal interface IExportService
{
    string Export(string fileType, List<string> contacts);
}
