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
            int age = 27;
            string name = "Valentin";

            Console.WriteLine("Ваше имя: " + name + " вам " + age + " лет!");
            //Интерполяция
            Console.WriteLine($"Ваше имя: {name} вам {27} лет!");
        }

    }
}
