using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printable
{
    internal class Program
    {
        interface Printable04
        {
            void Print();
        }
        class Book : Printable04
        {
            public static void printBook(Printable04[] printable)
            {
                foreach (var item in printable)
                {
                    if (item.GetType() == typeof(Book))
                    {
                        item.Print();
                    }
                }
            }
            public void Print()
            {
                Console.WriteLine("'Мёртвые души' Гоголь");
            }
        }
        class Magazine : Printable04
        {
            public static void printMagazines(Printable04[] printable)
            {
                foreach (var item in printable)
                {
                    if (item.GetType() == typeof(Magazine))
                    {
                        item.Print();
                    }
                }
            }
            public void Print()
            {
                Console.WriteLine("Журнал 'FORBS'");
            }
        }
        static void Main(string[] args)
        {
            Book book = new Book();
            Book oneBook = new Book();
            Magazine magazine = new Magazine();
            Magazine oneMagazine = new Magazine();
            Printable04[] printable = { book, oneBook, magazine, oneMagazine };
            foreach (Printable04 item in printable)
            {
                item.Print();
            }

        }
    }
}
