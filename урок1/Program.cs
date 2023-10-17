using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; // убирает проблему со знаком дробной части
using System.Reflection.Emit;

namespace урок1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world!");
            /* NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ","
            }
            ; */
            Converter();
            avr_arif();
            matem();
            exit();

        }
        static void Converter()
        {
            int rub;
            double usd = 95.098;
            Console.WriteLine(" введите сумму в рублях  ");
            rub = Convert.ToInt32(Console.ReadLine());
            double result = rub / usd;
            Console.WriteLine(result);
        }
        static void avr_arif()
        {
            int a, b;
            double avr;
            Console.WriteLine("введите первое число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите второе число");
            b = Convert.ToInt32(Console.ReadLine());
            avr = (a + b) / 2;
            Console.WriteLine($"среднее значение = {avr}");
        }
        static void matem()
        {
            int a, b, c;
            Console.WriteLine(" 3 numbers to operate: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            int sum = a + b + c;
            Console.WriteLine(sum);
            int pro = a * b * c;
            Console.WriteLine(pro);

        }
        static void exit()
        {
            Console.Read();
        }

    }
}
