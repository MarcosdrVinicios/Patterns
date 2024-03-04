using Patterns.ObserverPattern.Interfaces;

namespace Patterns.ObserverPattern;

public class Reader : IObserver
{
    private string Name { get; set; }
    
    public Reader(string name)
    {
        Name = name;
    }
    
    public void Update(ISubject subject)
    {
        if (subject is MicrosoftNews post)
        {
            Console.WriteLine($"Hello {Name} fresh notice: {post.Notice}");
        }
    }
}