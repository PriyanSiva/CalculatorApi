using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {

        [HttpGet("Add")]
        public IActionResult Add(float a, float b)
        {
            return Ok(a + b);
        }

        [HttpGet("Subtract")]
        public IActionResult Subtract(float a, float b)
        {
            return Ok(a - b);
        }

        [HttpGet("Multiply")]
        public IActionResult Multiply(float a, float b)
        {
            return Ok(a * b);
        }

        [HttpGet("Divide")]
        public ActionResult Divide(float a, float b)
        {
            if (b == 0)
            {
                return BadRequest("Invalid Parameters");
            }
            else
            {
                return Ok(a / b);
            }
        }

        [HttpGet("Modulo")]
        public ActionResult Modulo(float a, float b)
        {
            if (a == 0)
            {
                return BadRequest("Invalid Parameters");
            }

            return Ok(a % b);
        }
    }
}
