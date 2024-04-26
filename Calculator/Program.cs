using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator<int> calc1 = new Calculator<int>();
            Calculator<double> calc2 = new Calculator<double>();
            Calculator<string> calc3 = new Calculator<string>();

            Console.WriteLine($"add = {calc1.Add(5, 4)}\tsub = {calc1.Sub(5,4)}\tmult = {calc1.Mult(5, 4)}\tdiv = {calc1.Sub(5, 0)}");
            Console.WriteLine($"add = {calc2.Add(5.4, 4)}\tsub = {calc2.Sub(5.4, 4)}\tmult = {calc2.Mult(5.4, 4)}\tdiv = {calc2.Div(5, 0)}");
            Console.WriteLine($"add = {calc3.Add("5", "4")}");
            Console.ReadKey();
        }
    }
}
