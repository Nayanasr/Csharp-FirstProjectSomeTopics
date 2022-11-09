using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    internal class JaggedArray
    {
        public void jaggedArray()
        {
            //array of arrays
            //in c# jagged array is an array whose elements are arrays
            int[][] jaggedArray = new int[4][];

            //initializing the values of the jagged array type 1
            //initialized with respect to the index
            jaggedArray[0] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            jaggedArray[1] = new int[] { 5, 6, 7, 4, 4, 5, 6, 7, 8, 5 };

            //initializing the value of the jagged array type 2
            //initialized in single line
            int[][] jaggedArray1 = { new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 6, 7, 4, 4, 5 } };

            //accessing for jaggedArray
            Console.WriteLine(jaggedArray[0][5]);

            //accessing jagged array using for loop
            //accessing the array elements
            for (int i= 0; i < jaggedArray.Length; i++) 
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine(jaggedArray[i][j]);
                } 

            }
        }
    }
}
