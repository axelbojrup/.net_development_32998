using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromGenerics
{

    class Program
    {
        static void Main(string[] args)
        {

            var numbers = new List();
            numbers.Add(55);


            var book = new Book { Isbn = "132", Title = "Mastering C#" };
            var books = new BookList();
            books.Add(book);


            var numbers2 = new GenericList<int>();
            numbers2.Add(100);

            var books2 = new GenericList<Book>();
            books2.Add(new Book());



            var dic = new GenericDictionary<string, Book>();
            dic.Add("Book-A", book);


             Utilities<int> dc1 = new Utilities<int>(); // NOT OK  
            Utilities<string> dc = new Utilities<string>(); // OK
            // the argument must be reference type in case CLASS , STRUCT is value types

      





        }
    }
}
