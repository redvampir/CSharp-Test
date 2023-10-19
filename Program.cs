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

            Console.WriteLine("Привет!");
            Console.WriteLine("Ты здесь?");
            writeError("Нет соединения с интернетом." );
            Console.WriteLine("Странно...");
            writeError("Интернет не оплачен", symbol: '@');

             void writeError(string text, ConsoleColor color = ConsoleColor.Red, char symbol = '!')
            {
                ConsoleColor defautColor = Console.ForegroundColor;
                Console.ForegroundColor = color;
                Console.WriteLine(symbol + text);
                Console.ForegroundColor = defautColor;
            }
        }
    }
}
