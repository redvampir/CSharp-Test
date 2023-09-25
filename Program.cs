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
            int age;
            string input = "15";
            age = Convert.ToInt32(input);
            Console.WriteLine(age);

            float result;
            int x = 5, y = 2;
            //Конвертация х к типу float.
            result = Convert.ToSingle(x) / y;
            Console.WriteLine(result);

            int trigger = 1;
            bool triggerInBoolean = Convert.ToBoolean(trigger);
            Console.WriteLine(triggerInBoolean);
            int reconvert = Convert.ToInt32(triggerInBoolean);
            Console.WriteLine(reconvert);

        }

    }
}
