public class CalculatorService: ICalculatorService
{
    public Result<double> Divide(double a, double b)
    {
        if(b == 0)
            return Result.Fail<double>(new DivideByZeroError());
        return Result.Ok(a / b);
    }
}


public interface ICalculatorService{
    public Result<double> Divide(double a, double b);
}

public class DivideByZeroError : Error
{
    public DivideByZeroError() : base("Cannot divide by zero.") { 
        WithMetadata("ErrorCode","1");
    }
}