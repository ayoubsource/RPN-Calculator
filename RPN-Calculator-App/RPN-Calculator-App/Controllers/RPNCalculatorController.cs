using Microsoft.AspNetCore.Mvc;

namespace RPN_Calculator_App.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RpnCalculatorController : ControllerBase
    {


        [HttpPost]
        public RpnResult Post(string rpnExpression)
        {
            RpnCalculator expression = new RpnCalculator(rpnExpression);
            var res = expression.EvaluateRpnExpr();
            return new RpnResult(rpnExpression, res);
        }
    }
}
