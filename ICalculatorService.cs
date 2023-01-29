using FluentResults;

namespace answer_is_in_the_result;

public interface ICalculatorService{
    public Result<double> Divide(double a, double b);
}