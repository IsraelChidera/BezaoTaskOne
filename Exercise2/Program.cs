using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Program
    {
        /* Write a program that takes a string and returns an ordered array
        containing the indices of all capital letters in the string */
        static void Main(string[] args)
        {
            Console.WriteLine("Input any string");
            //Console.ReadLine();
            string words = Console.ReadLine();
            List<int> CapitalLetterList = new List<int>();
            for (int i = 0; i < words.Length; i++)
            {
                //int indexed = words.IndexOf(words[i]);

                if (Char.IsUpper(words[i]))
                {
                    Console.WriteLine(words.IndexOf(words[i]));                    
                }
                
            }
        }
    }
}
