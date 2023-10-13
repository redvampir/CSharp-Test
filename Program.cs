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

            

            int[,] array3 = new int[4,4];

            Random rando= new Random();

           

            for (int i = 0; i < array3.GetLength(0); i++)
            {
                for (int j = 0; j < array3.GetLength(1); j++)
                {
                    array3[i, j] = rando.Next(0, 10);
                    Console.Write(array3[i, j] + " ");
                }
                Console.WriteLine();
            }
            
        }   
    }
}
