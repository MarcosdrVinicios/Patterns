namespace Patterns.StrategyPatternV1;

public class Calculator
{
    private ICalculationStrategy strategy;
    
    public Calculator() { }

    public Calculator(ICalculationStrategy strategy)
    {
        this.strategy = strategy;
    }

    public void SetCalculationStrategy(ICalculationStrategy strategy)
    {
        this.strategy = strategy;
    }

    public int ExecuteCalculation(int value1, int value2)
    {
        return strategy.Calculate(value1, value2);
    }
}
