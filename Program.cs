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

            int[] petrovich = new int[3];
            int[] ivanovich = new int[5];
            int[] sidorovich;

            petrovich = ivanovich;

            petrovich[0] = 5;
            petrovich[1] = 3;

            sidorovich = petrovich; 

            Console.WriteLine(ivanovich[0]);
            Console.WriteLine(ivanovich[1]);

            petrovich = new int[10];
            
            
            
        }   
    }
}
