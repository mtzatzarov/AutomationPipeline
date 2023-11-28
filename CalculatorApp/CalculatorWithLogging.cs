public class CalculatorWithLogging
{
    private readonly Calculator calculator;
    private readonly Logger logger;

    public CalculatorWithLogging(Calculator calculator, Logger logger)
    {
        this.calculator = calculator ?? throw new ArgumentNullException(nameof(calculator));
        this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public int AddAndLog(int a, int b)
    {
        int result = calculator.Add(a, b);
        logger.Log($"Adding {a} and {b}. Result: {result}");
        return result;
    }

    public int SubtractAndLog(int a, int b)
    {
        int result = calculator.Subtract(a, b);
        logger.Log($"Subtracting {b} from {a}. Result: {result}");
        return result;
    }
}
