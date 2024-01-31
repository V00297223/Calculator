using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet]
        public decimal Add(decimal num1, decimal num2)
        {  
            decimal result = num1 + num2;
            return result;
        }
        
        [HttpGet]
        public decimal Subtract(decimal num1, decimal num2)
        {  
            decimal result = num1 - num2;
            return result;
        }
        [HttpGet]
        public decimal Multiply(decimal num1, decimal num2)
        {  
            decimal result = num1 * num2;
            return result;
        }
        [HttpGet]
        public decimal Divide(decimal num1, decimal num2)
        {  
            decimal result = num1 / num2;
            return result;
        }
        [HttpGet]
        public decimal Modulo(decimal num1, decimal num2)
        {  
            decimal result = num1 % num2;
            return result;
        }
    }
}
