using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    internal class Casting
    {
        public void M1()
        {
            Console.WriteLine("hello i am parent class");
        }
    }
    internal class Casting2: Casting
    {
        public void M2() {
            Console.WriteLine("hello i am child class");

        }
    }
}
