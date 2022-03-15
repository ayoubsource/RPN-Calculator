using System;

namespace RPN_Calculator_App
{
    public class RpnCalculator
    {
        private readonly IStackServices _stackServices;

        public RpnCalculator(IStackServices stackServices)
        {
            _stackServices = stackServices;
        }

        public void  Add()
        {
            CheckStackCount();

            var e1 = _stackServices.Pop();
            var e2 = _stackServices.Pop();
            this._stackServices.AddElementToStack(e2+e1);

        }


        public void Minus()
        {
            CheckStackCount();

            var e1 = _stackServices.Pop();
            var e2 = _stackServices.Pop();
            this._stackServices.AddElementToStack(e2 - e1);

        }


        public void Multiply()
        {
            CheckStackCount();
            var e1 = _stackServices.Pop();
            var e2 = _stackServices.Pop();
            this._stackServices.AddElementToStack(e2 * e1);

        }

        public void Divide()
        {
            CheckStackCount();
            var e1 = _stackServices.Pop();
            var e2 = _stackServices.Pop();
            if (e1 == 0)
            {
                throw new InvalidOperationException("Impossible operation (division by zero)");
            }
            this._stackServices.AddElementToStack(e2 / e1);
        }

        private void CheckStackCount()
        {
            if (_stackServices.Count() < 2)
            {
                throw new InvalidOperationException("Invalid operation : Stack contains less than two elements");
            }
        }
    }
}
