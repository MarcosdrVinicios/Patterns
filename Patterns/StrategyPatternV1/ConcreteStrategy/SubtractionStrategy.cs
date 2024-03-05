namespace Patterns.StrategyPatternV1.ConcreteStrategy;

public class SubtractionStrategy : ICalculationStrategy
{
    public int Calculate(int value1, int value2)
    {
        return value1 - value2;
    }
}
