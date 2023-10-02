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

            Random rand = new Random();
            
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine(rand.Next(0, 5));    
            }
        }
    }
}
