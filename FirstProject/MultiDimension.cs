using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    internal class MultiDimension
    {
        //multideimensional array contains more than one row
        //in c# we also call it as rectangular array coz row length is same
        //creating a two-dimensionalarray
        //1)2-dimensional arrat
        int[,] twoDimension = new int[3,2];//[,]-->it has 2

        //initializing the value for 2-dimensional array
        public void InitTwoDimension()
        {
            twoDimension = new int[,] { { 1, 2},{ 3, 4 },{ 5, 6 } };//[3,2]-->3 rows and 2 columns

            //accessing the values using for loop
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<2; j++)
                {
                    Console.WriteLine("the elements are:{0}",twoDimension[i,j]);
                }
            }
        }



        //3-dimensional array
        //creating three-dimension array
        int[,,] threeDimension = new int[2, 3, 4];

        public void ThreeDimension()
        {
            //initializing the 3-dimensional array values
            threeDimension = new int[,,] { { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } }, { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } } };
            
            //accessing the 3-dimensional array values using for loop
            for(int i=0; i < 2; i++)
            {
                for(int j=0; j < 3; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        Console.WriteLine("elements of three dimensional array are {0}", threeDimension[i, j, k]);
                    }
                }
            }

        }
    }
}
