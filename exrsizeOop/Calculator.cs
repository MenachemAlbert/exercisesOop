using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exrsizeOop
{
    internal class Calculator
    {
        public int Add(int x, int y) 
        {
            return x + y;
        }
    }

    public class MathOperations
    {
        public int x { get; set; }
        public int y { get; set; }
        public MathOperations(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int useInCalculator()
        {
            Calculator calculator = new Calculator();
            return calculator.Add(x, y);
        }
    }
}
