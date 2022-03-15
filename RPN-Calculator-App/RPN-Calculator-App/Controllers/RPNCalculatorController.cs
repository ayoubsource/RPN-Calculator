using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace RPN_Calculator_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RpnCalculatorController : ControllerBase
    {

        private IStackServices _services;
        private RpnCalculator _rpnCalculator;
        public RpnCalculatorController(IStackServices services)
        {
            this._services = services;
            _rpnCalculator = new RpnCalculator(_services);
        }

        [HttpPost("/AddElement")]
        public IActionResult Post(int element)
        {
            try
            {
                _services.AddElementToStack(element);
                return Ok();
            }
            catch (Exception _)
            {
                return BadRequest();
            }
        }

        [HttpGet("/GetStack")]
        public IActionResult GetStack()
        {
            return Ok(_services.GetStackAsArray());
        }

        [HttpPost("/ClearStack")]
        public IActionResult ClearStack()
        {
            try
            {
                _services.ClearStack();
            }
            catch (Exception _)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpPost("/AddOperation")]
        public IActionResult Add()
        {
            try
            {
                _rpnCalculator.Add();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return Ok(_services.GetStackAsArray());
        }

        [HttpPost("/MinusOperation")]
        public IActionResult Minus()
        {
            try
            {
                _rpnCalculator.Minus();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return Ok(_services.GetStackAsArray());
        }


        [HttpPost("/MultiplyOperation")]
        public IActionResult Multiply()
        {
            try
            {
                _rpnCalculator.Multiply();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return Ok(_services.GetStackAsArray());
        }


        [HttpPost("/DivideOperation")]
        public IActionResult Divide()
        {
            try
            {
                _rpnCalculator.Divide();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return Ok(_services.GetStackAsArray());
        }

    }

}
