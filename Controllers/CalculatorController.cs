using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CalculatorLibrary;

namespace CalculatorController
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly CalculatorService _calculatorService;

        public CalculatorController()
        {
            _calculatorService = new CalculatorService();
        }

        [HttpGet("Add")]
        public IActionResult Add(float x, float y)
        {
            var result = _calculatorService.Add(x, y);
            return Ok(result);
        }

        [HttpGet("Subtract")]
        public IActionResult Subtract(float x, float y)
        {
            var result = _calculatorService.Subtract(x, y);
            return Ok(result);
        }

        [HttpGet("Multiply")]
        public IActionResult Multiply(float x, float y)
        {
            var result = _calculatorService.Multiply(x, y);
            return Ok(result);
        }

        [HttpGet("Divide")]
        public ActionResult Divide(float x, float y)
        {
            var result = _calculatorService.Divide(x, y);
            return Ok(result);
        }

        [HttpGet("Modulo")]
        public ActionResult Modulo(float x, float y)
        {
            var result = _calculatorService.Modulo(x, y);
            return Ok(result);
        }
    }
}
