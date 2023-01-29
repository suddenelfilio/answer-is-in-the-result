using FluentResults;

namespace answer_is_in_the_result;

public class CalculatorService: ICalculatorService
{
    public Result<double> Divide(double a, double b)
    {
        return b == 0 ? Result.Fail<double>(new DivideByZeroError()) : Result.Ok(a / b);
    }
}