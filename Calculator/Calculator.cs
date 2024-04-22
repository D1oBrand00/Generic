using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator<X,Y>
    {
        public void Mathem(X a, Y b)
        {
            Console.WriteLine($"{a}+{b}={a+b}");
        }
    }
}
