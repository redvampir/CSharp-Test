﻿using System;
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

            int[] array1 = new int[5];
            int[,] array2 = new int[5, 5];
            array1 = Resize(array1, 6);
            array2 = Resize(array2, 10, 10);
            Console.WriteLine(array1.Length);
            Console.WriteLine(array2.Length);
        }
           

        static int[] Resize (int[] array, int size)
        {
            int[] tempArray = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }

            array = tempArray;
            return array;
        }

        static int[,] Resize(int[,] array, int x, int y)
        {
            int[,] tempArray = new int[x, y];

            for (int i = 0;i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    tempArray[i,j] = array[i,j];
                }
            }
            array = tempArray;
            return array;
        }
    }


}
