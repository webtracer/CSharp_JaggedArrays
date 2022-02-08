using System;

namespace Jagged_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[][] jaggedArray = new int[3][];

            //Can initialize this way - specifying the values but empty
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];
            //Or initialize this way - with values instead of specifying like above
            jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 13, 21 };

            //Alternative way
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 2, 3, 5, 7, 11 },
                new int[] { 1, 2, 3 },
                new int[] { 13, 21 }
            };

            Console.WriteLine($"The value in the middle of the first entry is {jaggedArray2[0][2]}");

            // My attempt - which almost was on track
            /*int[] counter = { 0 };
            for(int i = 0, j = 0; i < jaggedArray2.GetLength(0); i++,j++)
            {
                //for (int j = 0; j < jaggedArray2.GetLength(0); j++)
                //{
                    Console.Write($"The contents of the array are: ");
                    Console.WriteLine(jaggedArray2[j][i]);
                //}
            }*/

            // The solution
            for(int i =0; i < jaggedArray2.Length; i++)
            {
                Console.WriteLine($"Element {i}");
                for(int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.WriteLine(jaggedArray2[i][j]);
                }
            }


            Console.WriteLine("Hello World!");
        }
    }
}
