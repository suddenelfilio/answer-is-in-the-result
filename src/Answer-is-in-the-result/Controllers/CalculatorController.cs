using FluentResults.Extensions.AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace answer_is_in_the_result.Controllers;


[ApiController]
[Route("api/[controller]")]
public class CalculatorController : ControllerBase
{
    private readonly ICalculatorService _calculatorService;
    
    public CalculatorController(ICalculatorService calculatorService)
    {
        _calculatorService = calculatorService;
    }
    
    [HttpGet("divide/{a}/{b}")]
    public async Task<IActionResult> Divide(double a, double b)
    {
        var result = _calculatorService.Divide(a, b);

        return result.ToActionResult();
    }
}
