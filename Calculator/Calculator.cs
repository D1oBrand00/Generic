using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator<T>
    {


        public T Add(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x + y;
        }
        public T Sub(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x - y;
        }
        public T Mult(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x * y;
        }
        public T Div(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x / y;
        }
    }
}
