using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class SecondNumberInputState : State
    {
        public SecondNumberInputState(Calculator calculator) :
            base(calculator) 
        { }

        public override void InputDigit(int Digit)
        {
            calculator.displaynumber += Digit.ToString();
            calculator.cecondNumber = calculator.cecondNumber * 10 + Digit;
        }
        public override void InputEqual()
        {
            calculator.Resault();
            if (calculator.displaynumber != "Делить на ноль нельзя")
            {
                calculator.displaynumber = calculator.firstNumber.ToString();
                calculator.setState(new EqualState(calculator));
            }
        }
        public override void InputOperation(char Operation)
        {
            calculator.Resault();
            calculator.displaynumber = calculator.firstNumber.ToString();
            calculator.operation = Operation;
            calculator.setState(new OperationState(calculator));
        }
    }
}
