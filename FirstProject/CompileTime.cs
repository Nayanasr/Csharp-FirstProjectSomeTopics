using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    //method overloading=using same method name with different parameters
    public class CompileTime
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
