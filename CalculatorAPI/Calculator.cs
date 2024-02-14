using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace MyApp.Namespace
{
    [Route("[Controller]/[action]")]
    [ApiController]
    public class Calculator : ControllerBase
    {
        public string Test(){
            return "Test";
        }

        [HttpGet]
        public decimal Add(decimal num1, decimal num2)
        {  
           decimal sum = num1 + num2;
            return sum;
        }
        
        [HttpGet]
        public decimal Subtract(decimal num1, decimal num2)
        {  
           decimal difference = num1 - num2;
            return difference;
        }
        
        [HttpGet]
        public decimal Multiply(decimal num1, decimal num2)
        {  
           decimal product = num1 * num2;
            return product;
        }
        
        [HttpGet]
        public decimal Divide(decimal num1, decimal num2)
        {  
           decimal quotient = num1 / num2;
            return quotient;
        }
        
        [HttpGet]
        public decimal Modulo(decimal num1, decimal num2)
        {  
           decimal remainder = num1 % num2;
            return remainder;
        }

    }
}
