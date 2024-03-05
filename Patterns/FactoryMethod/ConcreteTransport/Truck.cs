namespace Patterns.FactoryMethod.ConcreteTransport;

public class Truck : ITransport
{
    public string Deliver()
    {
        return "Initiate delivery with Truck";
    }
}
