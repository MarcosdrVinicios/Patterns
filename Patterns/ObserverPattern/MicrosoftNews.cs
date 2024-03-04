using Patterns.ObserverPattern.Interfaces;

namespace Patterns.ObserverPattern;

public class MicrosoftNews : ISubject
{
    private readonly List<IObserver> observers = new();
    private string notice;

    public string Notice
    {
        get => notice;
        set 
        {
            notice = value;
            Notify();
        }
}
    
    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void Notify()
    {
        observers.ForEach(x => { x.Update(this); });
    }
}