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

            int[] bag = new int[1];
            bag[0] = 12;
            int[] tempBag = new int[bag.Length +1];
            for (int i = 0; i < bag.Length; i++)
            {
                tempBag[i] = bag[i];
                Console.WriteLine(tempBag[i] + " значение из сумки");
            }
            Console.WriteLine(tempBag[tempBag.Length - 1] + " последнее значение временного хранилища.");
        }   
    }
}
