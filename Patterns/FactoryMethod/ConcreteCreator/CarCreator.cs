namespace Patterns.FactoryMethod.ConcreteCreator;

using Patterns.FactoryMethod.ConcreteTransport;

public class CarCreator : TransportCreator
{
    public override ITransport CreateTransport()
    {
        return new Car();
    }
}
