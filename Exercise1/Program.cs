using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuestionTwo();
        }


        static void QuestionTwo()
        {
            Console.WriteLine("Input any string longer than 5");
            string word = Console.ReadLine();

            if (word.Length > 5)
            {
                string newString = word.Substring(0, word.Length - 4) + "####";
                Console.WriteLine(newString);
            }
            else if (word.Length == 0)
                Console.WriteLine("Invalid word, Try again!");
            else if (word.Length < 5)
            {
                Console.WriteLine("Invalid inputs. Cannot be hashed. Try again!");
            }

        }


    }
}
