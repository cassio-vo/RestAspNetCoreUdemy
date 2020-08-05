using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestAspNetCoreUdemy.Util;

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
            if (UtilNumber.IsNumeric(firstNumber) && UtilNumber.IsNumeric(secondNumber))
            {
                var sum = UtilNumber.ConvertToDescimal(firstNumber) + UtilNumber.ConvertToDescimal(secondNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid input.");
        }

        //Get Api/subtraction/5/5
        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public IActionResult Subtraction(string firstNumber, string secondNumber)
        {
            if (UtilNumber.IsNumeric(firstNumber) && UtilNumber.IsNumeric(secondNumber))
            {
                var sum = UtilNumber.ConvertToDescimal(firstNumber) - UtilNumber.ConvertToDescimal(secondNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid input.");
        }

        //Get Api/subtraction/5/5
        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public IActionResult Division(string firstNumber, string secondNumber)
        {
            if (UtilNumber.IsNumeric(firstNumber) && UtilNumber.IsNumeric(secondNumber))
            {
                var sum = UtilNumber.ConvertToDescimal(firstNumber) / UtilNumber.ConvertToDescimal(secondNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid input.");
        }

        //Get Api/subtraction/5/5
        [HttpGet("multiplication/{firstNumber}/{secondNumber}")]
        public IActionResult Multiplication(string firstNumber, string secondNumber)
        {
            if (UtilNumber.IsNumeric(firstNumber) && UtilNumber.IsNumeric(secondNumber))
            {
                var sum = UtilNumber.ConvertToDescimal(firstNumber) * UtilNumber.ConvertToDescimal(secondNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid input.");
        }        
    }
}
