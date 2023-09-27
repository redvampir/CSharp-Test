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
            

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            // Логическое и && верны оба значения тогда true

            // Логическое или || верно одно из значений

            int money = 500;
            int level = 10;

            if (money > 500 || level > 9) 
            {
                Console.WriteLine("Проходи! Добро пожаловать в гильдию!");
            }
            else
            {
                Console.WriteLine("Вас выпнули за дверь!");
            }
        }


    }
}
