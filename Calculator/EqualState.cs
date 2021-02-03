using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class EqualState : State
    {
        public EqualState(Calculator calculator):
            base(calculator)
        { }
        public override void InputDigit(int Digit)
        {
            calculator.firstNumber = Digit;
            calculator.setState(new FirstNumberInputState(calculator));
        }
        public override void InputEqual()
        {
            
        }
        public override void InputOperation(char Operation)
        {
            //calculator.firstnumber= resault
            calculator.operation = Operation;
            calculator.setState(new OperationState(calculator));
        }
    }
}
