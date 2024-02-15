namespace CalculatorLibrary;

public class CalculatorService
{
    public float Add(float x, float y)
    {
        return x + y;
    }

    public float Subtract(float x, float y)
    {
        return x - y;
    }

    public float Multiply(float x, float y)
    {
        return x * y;
    }

    public float Divide(float x, float y)
    {
        if (y == 0)
            throw new DivideByZeroException("Invalid Parameters.");
        return x / y;
    }

    public float Modulo(float x, float y)
    {
        if (y == 0)
            throw new DivideByZeroException("Invalid Parameters.");
        return x % y;
    }
}
