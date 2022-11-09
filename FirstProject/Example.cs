using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    //method overloading upto method1(int a) method
    public class Example
    {
        //compile time polymorphism
        //public void method1()
        //{
        //    Console.WriteLine("Hey! I am from Parent CLASS");
        //}

        //Run time polymorphism
        public virtual void method1()
        {
           Console.WriteLine("Hey! I am from Parent CLASS");
        }
        public void method1(int a)
        {
            Console.WriteLine("Hey! I am methods with parameter {0}", a);
        }

    }

    public class Example1 : Example
    {
        //compile time polymorphism
        //public void method1()
        //{
        //    Console.WriteLine("I am from the derived class");
        //}

        //Run time polymorphism
        public override void method1()
        {
           Console.WriteLine("I am from the derived class");
        }
    }

}
