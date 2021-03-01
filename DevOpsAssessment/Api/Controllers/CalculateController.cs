using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Website.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculateController : ControllerBase
    {
        public CalculateController()
        {
        }

        [HttpGet]
        [Route("add/{*numbers}")]
        public int Add([FromRoute]string numbers )
        {
            return Calculator.Add(numbers.ToInt());
        }
        
        [HttpGet]
        [Route("subtract/{*numbers}")]
        public int Subtract([FromRoute]string numbers )
        {
            return Calculator.Subtract(numbers.ToInt());
        }
        
        [HttpGet]
        [Route("multiply/{*numbers}")]
        public int Multiply([FromRoute]string numbers )
        {
            return Calculator.Multiply(numbers.ToInt());
        }
        
        [HttpGet]
        [Route("divide/{*numbers}")]
        public float Divide([FromRoute]string numbers )
        {
            return Calculator.Divide(numbers.ToFloat());
        }
    }
}