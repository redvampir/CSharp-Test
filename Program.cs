using System;
using System.Collections.Generic;
using System.ComponentModel;
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

            int health = 5, maxHealth = 10;
            int mana = 7, maxMana = 10;

            while (true)
            {

                DrawBar(health, maxHealth, ConsoleColor.Green, 0);
                DrawBar(mana, maxMana, ConsoleColor.Blue, 1);

                Console.SetCursorPosition(0, 5);
                Console.Write("Введите число, на которое изиенятся жизни: ");
                health+= Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите число, на которое изиенятся мана: ");
                mana+= Convert.ToInt32(Console.ReadLine());

                Console.ReadKey();
                Console.Clear();
            }
            
        }

        static void DrawBar(int value, int maxValue, ConsoleColor color, int position)
        {
            ConsoleColor defaultColor = Console.BackgroundColor;

            string bar = "";

            for (int i = 0; i < value; i++)
            {
                bar += " ";
            }

            Console.SetCursorPosition(0, position);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;

            bar = "";

            for (int i = 0;i < maxValue; i++)
            {
                bar += " ";
            }

            Console.Write(bar + ']');

        }
        
        
    }


}
