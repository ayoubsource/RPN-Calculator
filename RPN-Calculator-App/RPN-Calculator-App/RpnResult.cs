using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPN_Calculator_App
{
    public class RpnResult
    {
        public RpnResult(string expression, double result)
        {
            Expression = expression;
            Result = result;
        }
        public  string Expression { get; set; }
        public double Result { get; set; }

    }
}
