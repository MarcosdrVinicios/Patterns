using Patterns.ObserverPattern.Interfaces;

namespace Patterns.ObserverPattern;

public class Farfetcher : IObserver
{
    private string Name { get; set; }
    
    public Farfetcher(string name)
    {
        Name = name;
    }
    
    public void Update(ISubject subject)
    {
        if (subject is Teamlyzer teamlyzer)
        {
            Console.WriteLine($"Hello {Name} fresh notice: {teamlyzer.Notice}");
        }
    }
}