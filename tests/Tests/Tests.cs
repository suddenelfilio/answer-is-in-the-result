using answer_is_in_the_result;
using FluentAssertions;

namespace Tests;

public class Tests
{
    [Fact]
    public void Divide_WhenDivideByZero_ShouldReturnError()
    {
        var calculatorService = new CalculatorService();
        var result = calculatorService.Divide(1, 0);
        result.IsFailed.Should().BeTrue();
        result.Errors.Should().HaveCount(1);
        result.Errors.First().Should().BeOfType<DivideByZeroError>();
    }

    [Theory]
    [InlineData(1, 2, 0.5)]
    [InlineData(3, 4, 0.75)]
    public void Divide_WhenValidInput_ShouldReturnResult(double a, double b, double expectedResult)
    {
        var calculatorService = new CalculatorService();
        var result = calculatorService.Divide(a, b);
        result.IsFailed.Should().BeFalse();
        result.Value.Should().Be(expectedResult);
    }
}