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
            int A = 0;
            //                  1 +   2 + 1 +   1   + "1" +    3    *2
            Console.WriteLine((++A) + 2 + 1 + (A++) + "1" + (++A) * 2);
        }

    }
}
