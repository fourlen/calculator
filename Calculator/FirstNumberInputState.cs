using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class FirstNumberInputState : State
    { 
        public FirstNumberInputState(Calculator c):
            base(c)
        { }
        public override void InputDigit(int digit)
        {
            calculator.firstNumber = calculator.firstNumber * 10 + digit;
            calculator.displaynumber += digit.ToString();
        }
        public override void InputOperation (char operation)
        {
            calculator.operation = operation;
            calculator.setState(new OperationState(calculator));
        }
        public override void InputEqual()
        {
            calculator.Resault();
            calculator.displaynumber = calculator.firstNumber.ToString();
            calculator.setState(new EqualState(calculator));
        }
    }
}
