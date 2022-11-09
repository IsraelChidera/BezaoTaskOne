using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Program
    {



        static void Main(string[] args)
        {
            Console.WriteLine("Input date here . . .");
            string dateByOneWeek = Dates("date here");

            Console.WriteLine(dateByOneWeek);
        }

        public static string Dates(string date)
        {
            Console.WriteLine("Input a date in this format: yyyy/mm/dd");

            date = Console.ReadLine();

            DateTime dateValue = DateTime.Parse(date);
            dateValue = dateValue.AddDays(7);
            Console.WriteLine(dateValue.Year + "/" + dateValue.Month + "/" + dateValue.Day);

            return dateValue.ToString();
        }




    }
}
