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

            int x = 3, y = 8, sum;

            sum = Sum(x, y);
            Console.WriteLine(sum);

           int Sum(int z, int c)
            {
                return z + c;

            }
        }
    }
}
