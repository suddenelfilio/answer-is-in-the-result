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
        var result = await _calculatorService.Divide(a, b);

        if (result.IsError)
        {
            return BadRequest(result.Error);
        }

        return Ok(result.Value);
    }
}
