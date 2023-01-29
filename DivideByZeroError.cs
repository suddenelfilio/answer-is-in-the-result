using FluentResults;

namespace answer_is_in_the_result;

public class DivideByZeroError : Error
{
    public DivideByZeroError() : base("Cannot divide by zero.") { 
        WithMetadata("ErrorCode","1");
    }
}