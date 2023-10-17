using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace урок2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value;

            Console.WriteLine(" введите число: "); 

            value = double.Parse(Console.ReadLine());

            if ((value % 2) > 0 || (value % 2) < 0)
            {
                Console.WriteLine(" число " + value + " нечетное ");
            }
            else
            {
                Console.WriteLine(" число " + value + " четное ");
            }
        }
    }
}
