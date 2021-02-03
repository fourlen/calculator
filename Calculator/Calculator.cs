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
        public double firstNumber { get; set; }
        public double cecondNumber { get; set; }
        public char operation { get; set; }
        public void setState(State s)
        {
            state = s;
        }
        public double Resault()
        {
            if (firstNumber != null && operation != null)
            {
                if (cecondNumber == null)
                {
                    cecondNumber = firstNumber;
                }
                if (operation == '+')
                {
                    return firstNumber + cecondNumber;
                }
                else if (operation == '-')
                {
                    return firstNumber - cecondNumber;
                }
                else if (operation == '*')
                {
                    return firstNumber * cecondNumber;
                }
                else if (operation == '/')
                {
                    return firstNumber / cecondNumber;
                }
            }
            return 0;
        }
    }
}
