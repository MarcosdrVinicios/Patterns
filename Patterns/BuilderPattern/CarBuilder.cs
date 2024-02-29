namespace Patterns.BuilderPattern;

public class CarBuilder
{
    private Car car = new();

    public CarBuilder AddEngine(string engine)
    {
        car.Engine = engine;
        return this;
    }
    
    public CarBuilder AddColor(string color)
    {
        car.Color = color;
        return this;
    }
    
    public CarBuilder AddChassis(string chassis)
    {
        car.Chassis = chassis;
        return this;
    }

    public Car Build()
    {
        return car;
    }
}