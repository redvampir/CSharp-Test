using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // + - * / %

            float result;

            int x, y;

            x = 5;
            y = 2;

            result = Convert.ToSingle(x) / y; // конвертация в дробное число
            Console.WriteLine(result);

            int timeInMinets = 130;
            int hour;
            int minute;

            hour = timeInMinets / 60;
            minute = timeInMinets % 60;

            Console.WriteLine("hours: " + hour);
            Console.WriteLine("minuets: " + minute);

            int age = 18;
            age++;
            age += 1;

            int result_2 = 5 + (12 - 5) * 3 - 1 + 5 * 2;
            Console.WriteLine(result_2);
        }

    }
}
