using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Book<XxX>
    {
        string nameBook;
        XxX priceBook;
        public string NameBook { get;set; }
        public XxX PriceBook { get; set; }
        public void ChangeName(string nameBook)
        {
            NameBook = nameBook;
        }
        public void CostChange(XxX priceBook)
        {
            PriceBook = priceBook;
        }
        public void Output()
        {
            Console.WriteLine($"Книга: {NameBook}\nСтоимость книги: {PriceBook} ");
        }


    }
}
