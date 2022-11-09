using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    //multiple inheritance is possible with the help of interfaces but not with classes
    public class MultipleInherit
    {
        //implementation or body for a method is must
        public void Subtract()
        {

        }
      
    }
    //INTERFACE
    interface IMultipleInherit
    {
        //implementation is optional
        //interface must always have static fields
        //all the properties must be implemented
        public static string name; 
        public int Add();
    }
    //it is compulsory to implement to all the method when we are inheriting the interface of the class

    public class ClassA : IMultipleInherit
    {
        public string name = "Nayana";

        public int Add()
        {
            return 10 + 10;
        }
    }
}
