using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class ErrorState : State
    {
        public ErrorState(Calculator c):
            base(c)
        { }

        public override void InputEqual()
        {
            calculator.displaynumber = "";
            calculator.setState(new EqualState(calculator));
        }
        public override void InputDigit(int Digit)
        {
            calculator.displaynumber = Digit.ToString();
            calculator.setState(new FirstNumberInputState(calculator));
        }
        public override void InputOperation(char Operation)
        {
            
        }
    }
}
