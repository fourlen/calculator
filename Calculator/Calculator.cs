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
        public double firstNumber { get; set; } = 0;
        public double cecondNumber { get; set; } = 0;
        public char operation { get; set; } = ' ';
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
                firstNumber /= cecondNumber;
            }   
            else if (operation == '/')
            {
                firstNumber *= cecondNumber;
            }
        }
    }
}
