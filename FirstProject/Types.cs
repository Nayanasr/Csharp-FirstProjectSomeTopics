using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    internal class Types
    {
        //public int evenNumbers = 2;//instead of these 4 lines of code
        //public int evenNumbers2 = 4;
        //public int evenNumbers3 = 6;
        //public int evenNumbers4 = 8;

        //it is fixed in size we need to specify the length of an array
        //index is always 0 end index will always be n-1
        public int[] evenNumbers = new int[4];//declaring an array


        //initialization of an array elements
        public void initialize()
        {
            evenNumbers[0] = 2;//at run time for this memory allocation is done dynamically
            evenNumbers[1] = 4;//at run time we get an exception
            evenNumbers[2] = 6;//creation of the object is done at run time
            evenNumbers[3] = 8;
            //evenNumbers[4] = 10;//when we uncomment it it shows an exception of out of bound

            Console.WriteLine("1st even {0}", evenNumbers[0]);
            //Console.WriteLine("last even", evenNumbers[4]);//out of bound exception


            //2)initialize and declaring an array in a single line
            int[] odd = new int[5] {1,3,5,7,9};//here initialize
            Console.WriteLine("1st odd {0}", odd[0]);

            //access the elements using loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(odd[i]);
            }

            Console.WriteLine("==========================");
            //forEach loop
            foreach(int element in evenNumbers)//it will not refer to the index
            {
                Console.WriteLine(element);
                //Console.WriteLine(evenNumbers[element]);
            }
        }
    }
}
