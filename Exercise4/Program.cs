using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class Program
    {
        //Show the difference break and continue by writing suitable c# code
        static void Main(string[] args)
        {

            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
                if (i == 4)
                {
                    continue;
                }
                else if(i == 6)
                {
                    break;
                }
            }

        }   
    }
}
