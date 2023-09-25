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
            
            


            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            string name;
            Console.Write("Введите ваше имя: "); // Не переносит курсор на новую строку
            name = Console.ReadLine();
            Console.WriteLine($"Ваше имя: { name}" );
            int age;
            Console.Write("Введите ваш возраст: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Вам: {age} лет.");

            Console.ReadKey();// не завершать консольное приложение
        }

    }
}
