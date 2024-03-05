namespace Patterns.FactoryMethod.ConcreteCreator;

using Patterns.FactoryMethod.ConcreteTransport;

public class TruckCreator : TransportCreator
{
    public override ITransport CreateTransport()
    {
        return new Truck();
    }
}
