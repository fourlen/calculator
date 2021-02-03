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
            calculator.cecondNumber = calculator.cecondNumber * 10 + Digit;
        }
        public override void InputEqual()
        {
            calculator.firstNumber = calculator.Resault();
            //вывести firstnumber (операция) secondnumber
            calculator.setState(new EqualState(calculator));
        }
        public override void InputOperation(char Operation)
        {
            calculator.firstNumber = calculator.Resault();
            //вывести firstnumber (операция) secondnumber
            calculator.operation = Operation;
            calculator.setState(new OperationState(calculator));
        }
    }
}
