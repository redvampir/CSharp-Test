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

            string password = "123qwe";
            string userInput;

            Console.Write("Введите пароль: ");
            
            userInput = Console.ReadLine();

            if (userInput == password)
            {
                Console.WriteLine("Пароль принят. Доступ к базе даннных разрешен.");
            }
            else
            {
                Console.WriteLine("Неверный пароль. Доступ закрыт.");
            }

            float rublesInWaller;
            float dollarsInWallet;

            int rubToUsd = 64, usdToRub = 66;

            float exchangeCurrencyCount;

            string desireOperation;

            Console.WriteLine("Добро пожаловать в обменник валют!");

            Console.Write("Введите баланс рублей: ");
            rublesInWaller = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баланс долларов: ");
            dollarsInWallet = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Выберите необходимую операцию."); 
            Console.WriteLine("1 - обменять рубли на доллары.");
            Console.WriteLine("2 - обменять доллары на рубли.");

            Console.Write("Ваш выбор: ");
            desireOperation = Console.ReadLine();

            switch (desireOperation)
            {
                case "1":
                    Console.WriteLine("Обмен рублей на доллары");
                    Console.Write("Сколько рублей хотите обменять: ");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (rublesInWaller >= exchangeCurrencyCount)
                    {
                        rublesInWaller -= exchangeCurrencyCount;
                        dollarsInWallet += exchangeCurrencyCount / rubToUsd;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое количество рублей.");
                    }
                    break;

                case "2":
                    Console.WriteLine("Обмен долларов на рубли");
                    Console.Write("Сколько долларов вы хотите обменять: ");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (dollarsInWallet >= exchangeCurrencyCount)
                    {
                        dollarsInWallet -= exchangeCurrencyCount;
                        rublesInWaller += exchangeCurrencyCount * usdToRub;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое количество долларов.");
                    }
                    break;

                default:
                    Console.WriteLine("Выбрана неверная операция");
                    break;
            }

            Console.WriteLine($"Ваш баланс: {rublesInWaller} рублей," + $" {dollarsInWallet} долларов.");
        }



    }
}
