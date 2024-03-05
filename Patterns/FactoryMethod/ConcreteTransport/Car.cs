namespace Patterns.FactoryMethod.ConcreteTransport;

public class Car : ITransport
{
    public string Deliver()
    {
        return "Initiate delivery with Car";
    }
}
