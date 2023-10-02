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

            while (age-- > 0)
            {

                if (age == 5)
                {
                    //break; останавливает выполнение цикла.
                    continue; // пропуск одной итерации.
                }

                Console.WriteLine("С Днем Рождения!");
                
              
            }

        }
    }
}
