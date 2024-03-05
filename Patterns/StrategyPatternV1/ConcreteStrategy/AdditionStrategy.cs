namespace Patterns.StrategyPatternV1.ConcreteStrategy;

public class AdditionStrategy : ICalculationStrategy
{
    public int Calculate(int value1, int value2)
    {
        return value1 + value2;
    }
}
