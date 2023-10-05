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

            //int[] cucubers = { 24, 25, 17, 38, 100, int.MaxValue, int.MinValue};
            int[] cucubers = new int[4] { 4, 1, 6, 7 };
           //Console.WriteLine(cucubers[0]);

            // cucubers[7] = 13;
            //cucubers[3] = 3;

            // Random rand = new Random() пример с использованием рандома;

            for ( int i = 0; i < cucubers.Length; i++)
            {
             //   cucubers[i] = rand.Next(0,101);
                Console.WriteLine( cucubers[i]);
            }
        }   

    }
}
