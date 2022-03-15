using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPN_Calculator_App
{
    public interface IStackServices
    {
        public void AddElementToStack(double e);
        public void ClearStack();

        public double[] GetStackAsArray();

        public double Pop();

        public double Count();
    }
}
