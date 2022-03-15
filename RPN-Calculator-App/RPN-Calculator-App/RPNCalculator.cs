using System;
using System.Collections.Generic;

namespace RPN_Calculator_App
{
    public class RpnCalculator
    {
        public string Expression { get; set; }

        public RpnCalculator(string expression)
        {
            Expression = expression;
        }
        public  double EvaluteRpnExpr()
        {
            var stack = ParseExpr(Expression);
            return EvaluateRpnStack(stack);
        }

        private  Stack<string> ParseExpr(string s)
        {
            char[] sp = { ' ', '\t' };
            if (s == null) return new Stack<string>();
            var tks = new Stack<string>
                (s.Split(sp, StringSplitOptions.RemoveEmptyEntries));


            return tks;
        }

        private  double EvaluateRpnStack(Stack<string> tks)
        {
            var tk = tks.Pop();
            double x, y;
            if (double.TryParse(tk, out x)) return x;

            y = EvaluateRpnStack(tks);
            x = EvaluateRpnStack(tks);

            switch (tk)
            {
                case "+":
                    x += y;
                    break;
                case "-":
                    x -= y;
                    break;
                case "*":
                    x *= y;
                    break;
                case "/":
                    x /= y;
                    break;
                default:
                    throw new Exception();
            }

            return x;
        }
    }
}