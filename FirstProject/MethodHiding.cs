using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    public class MethodHiding
    {
        public string firstname;
        public string lastname;

        public void printFullName()
        {
            Console.WriteLine(firstname + " " + lastname);
        }

    }

    public class Class1 : MethodHiding
    {
        public new void printFullName()
        {
            base.printFullName();
            Console.WriteLine();
        }

    }
    public class Class2 : MethodHiding
    {

    }
}
