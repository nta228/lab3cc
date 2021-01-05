using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnipet2
{
    class Book
    {
        string bookName;
        public string Print()
        {
            return bookName;
        }
        public void Input(string bkName)
        {
            bookName = bkName;
        }
        static void Main(string[] args)
        {
           
            Book objBook = new Book();
            objBook.Input("C#-The Complete Reference");
            Console.WriteLine(objBook.Print());
        }
    }
}
