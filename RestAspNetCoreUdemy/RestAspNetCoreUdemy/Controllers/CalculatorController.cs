using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RestAspNetCoreUdemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        //Get Api/sum/5/5
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDescimal(firstNumber) + ConvertToDescimal(secondNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid input.");
        }

        //Get Api/subtraction/5/5
        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public IActionResult Subtraction(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDescimal(firstNumber) - ConvertToDescimal(secondNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid input.");
        }

        //Get Api/subtraction/5/5
        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public IActionResult Division(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDescimal(firstNumber) / ConvertToDescimal(secondNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid input.");
        }

        //Get Api/subtraction/5/5
        [HttpGet("multiplication/{firstNumber}/{secondNumber}")]
        public IActionResult Multiplication(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDescimal(firstNumber) * ConvertToDescimal(secondNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid input.");
        }

        private decimal ConvertToDescimal(string number)
        {
            decimal decimalValue;
            if (Decimal.TryParse(number, out decimalValue))
                return decimalValue;
            return 0;
        }

        private bool IsNumeric(string number)
        {
            double numberDouble;

            bool isNumber = Double.TryParse(
                number, 
                System.Globalization.NumberStyles.Any, 
                System.Globalization.NumberFormatInfo.InvariantInfo, 
                out numberDouble);

            return isNumber;
        }
    }
}
