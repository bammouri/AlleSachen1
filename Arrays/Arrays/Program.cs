﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a single-dimensional array
            int[] array1 = new int[5];

            // Declare and set array element values
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };

            // Alternative Syntax
            int[] array3 = { 1, 2, 3, 4, 5, 6 };

            // Declare a two dimensional array
            int[,] multiDimensionalArray1 = new int[2, 3];

            // Declare and set array element values
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            // Declare a jagged array
            int[][] jaggedArray = new int[6][];

            // Set the Values of the first array in the jagged array structure
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };

            Console.ReadLine();
        }
    }
}
