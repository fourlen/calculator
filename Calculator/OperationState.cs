using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class OperationState : State
    {
        public OperationState(Calculator c):
            base(c)
        { }
        public override void InputOperation(char Operation)
        {
            calculator.operation = Operation;
        }
        public override void InputDigit(int Digit)
        {
            calculator.cecondNumber = Digit;
            calculator.setState(new SecondNumberInputState(calculator));
        }
        public override void InputEqual()
        {
            calculator.cecondNumber = calculator.firstNumber;
            calculator.Resault();
            //вывод calculator.firstnumber
            calculator.setState(new EqualState(calculator));
        }
    }
}
