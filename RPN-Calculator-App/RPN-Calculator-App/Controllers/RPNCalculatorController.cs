using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPN_Calculator_App.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RpnCalculatorController : ControllerBase
    {


        [HttpPost]
        public RpnResult Post(string RpnExpression)
        {
            RpnCalculator expression = new RpnCalculator(RpnExpression);
            var res = expression.EvaluteRpnExpr();
            return new RpnResult(RpnExpression, res);
        }
    }
}
