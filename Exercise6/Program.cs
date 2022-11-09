using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our library.");
            Console.WriteLine("");
            Console.WriteLine("Books we have available");
            Console.WriteLine("\t C# book: (C)  - ");
            Console.WriteLine("\t .NET core books: (O)  - ");
            Console.WriteLine("\t Clean coding books: (D)  - ");
            Console.WriteLine("\t EFCore books: (E)  - ");
            Console.WriteLine("");

            string bookOption = Console.ReadLine();
            
            switch (bookOption)
            {
                case "c":
                    Console.WriteLine("C# book");
                    break;
                case "o":
                    Console.WriteLine(".NET core books");
                    break;
                case "d":
                    Console.WriteLine("Clean coding books");
                    break;
                case "e":
                    Console.WriteLine("EFCore books");
                    break;
                default:
                    Console.WriteLine("Book not available, try again!");
                    break;
            }
        }
    }
}
