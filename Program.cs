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
            string greeting = "Привет";
            string name = "Валентин";
            string message = greeting + " " + name;

            Console.WriteLine(message + ", рад тебя видеть!");

            int age = 5;
            Console.WriteLine("Привет, завтра тебе исполнится: " + (age + 1) );
        }

    }
}
