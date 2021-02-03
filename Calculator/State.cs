using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    abstract class State
    {
        protected Calculator calculator;
        public State(Calculator c)
        {
            calculator = c;
        }
        public abstract void InputDigit(int Digit);
        public abstract void InputOperation(char Operation);
        public abstract void InputEqual();
    }
}
