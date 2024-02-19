namespace Patterns.ObserverPattern.Interfaces;

public interface IObserver
{
    void Update(ISubject subject);
}