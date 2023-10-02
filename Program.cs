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

            int age;

            Console.Write("Введите ваш возраст: ");

            age = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < age; i++)
            {
                Console.WriteLine($"С днем рождения. Вам исполнилось {age} лет.") ;
            }
           

        }
    }
}
