using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Book<int> book1 = new Book<int>();
            Book<double> book2 = new Book<double>();
            Book<string> book3 = new Book<string>();
            book1.NameBook = "КнигаX";
            book1.PriceBook = 4343;
            book2.NameBook = "КнигаY";
            book2.PriceBook = 3245.43;
            book3.NameBook = "КнигаZ";
            book3.PriceBook = "444р";
            book1.Output();
            book2.Output();
            book3.Output();
            Console.ReadKey();

        }
    }
}
