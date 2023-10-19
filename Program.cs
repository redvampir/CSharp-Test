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

            int[] array = new int[5];
            array = EditArray(array, 2, 5);
            Console.WriteLine(array[2]);
    
        }

        static int[] EditArray(int[] array, int index, int value)
        {
            array = new int[6];
            array[index] = value;
            return array;
        }
    }


}
