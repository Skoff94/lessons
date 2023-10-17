using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace урок_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num_1 = 0;
            double num_2 = 0;
            Getnum(num_1, num_2);
        }
        static void Getnum(double num_1, double num_2)
        {
            Console.WriteLine(" введите число 1: ");

            num_1 = double.Parse(Console.ReadLine());

            Console.WriteLine(" введите число 2: ");

            num_2 = double.Parse(Console.ReadLine());

            On_if(num_1, num_2);

        }
        static void On_if(double num_1, double num_2)
        {
            double result;
            Console.WriteLine(" что делаем?: ");
            string operate = Console.ReadLine();
            if ( operate == "+")
            {
                
                result = num_1 + num_2;
                Console.WriteLine($" {num_1} + {num_2} = {result}");
                Console.Read();
                Getnum(num_1, num_2);

            }
            else if (operate == "-")
            {

                result = num_1 - num_2;
                Console.WriteLine($" {num_1} - {num_2} = {result}");
                Console.Read();
                Getnum(num_1, num_2);

            }
            else if (operate == "*")
            {

                result = num_1 * num_2;
                Console.WriteLine($" {num_1} * {num_2} = {result}");
                Console.Read();
                Getnum(num_1, num_2);

            }
            else if (operate == "/")
            {

                result = num_1 / num_2;
                Console.WriteLine($" {num_1} / {num_2} = {result}");
                Console.Read();
                Getnum(num_1, num_2);

            }
            else
            {
                Console.WriteLine(" неверный знак ");
                On_if(num_1, num_2);
            }
        }
        static void On_switch()
        {

        }
    }
}
