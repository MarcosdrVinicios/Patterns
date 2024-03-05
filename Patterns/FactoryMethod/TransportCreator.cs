namespace Patterns.FactoryMethod;

public abstract class TransportCreator
{
    public abstract ITransport CreateTransport();

    public string Deliver()
    {
        var transport = CreateTransport();

        return "let's create transport to " + transport.Deliver();
    }
}
