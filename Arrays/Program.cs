using System;
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

            //Declare a single dimensional array.
            int[] array1 = new int[5];

            //Declare and set array element values.
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };

            //Alternative syntax.
            int[] array3 = { 1, 2, 3, 4, 5, 6 };

            //Declare a two dimensional array.
            int[,] multiDimensionalArray1 = new int[2, 3];

            //Inserting values into 'multiDimensionalArray1'.
            multiDimensionalArray1[0, 0] = 33;

            //Declare and set array element values.
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            //Declare a jagged array.
            int[][] jaggedArray = new int[6][];
            //Set the values of the first array in the jagged array structure.
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
            jaggedArray[1] = new int[3] { 1, 2, 3 };
            jaggedArray[2] = new int[2] { 1, 2 };
            jaggedArray[3] = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            jaggedArray[4] = new int[] { 1, };
            jaggedArray[5] = new int[] { 1, 2, 3, 4 };

            foreach (int [] row in jaggedArray)
            {
                foreach (int element in row)
                {
                    System.Console.Write(element + " ");
                }
                System.Console.WriteLine();
            }
        }
    }
}
