using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        private State state;
        public Calculator()
        {
            state = new FirstNumberInputState(this);
        }
        public double firstNumber { get; set; } = 0;
        public double cecondNumber { get; set; } = 0;
        public char operation { get; set; } = ' ';
        public string displaynumber { get; set; } = "";
        public void setState(State s)
        {
            state = s;
        }
        public void Resault()
        {
            if (operation == '+')
            {
                firstNumber += cecondNumber;
            }
            else if (operation == '-')
            {
                firstNumber -= cecondNumber;
            }
            else if (operation == '*')
            {
                firstNumber *= cecondNumber;
            }   
            else if (operation == '/')
            {
                if (cecondNumber != 0)
                {
                    firstNumber /= cecondNumber;
                }
                else
                {
                    displaynumber = "Делить на ноль нельзя";
                    state = new ErrorState(this);
                }
                    
            }
        }
        public void InputDigit(int digit)
        {
            state.InputDigit(digit);
        }
        public void InputOperation(char operation)
        {
            state.InputOperation(operation);
        }
        public void InputEquel()
        {
            state.InputEqual();
        }
    }
}
