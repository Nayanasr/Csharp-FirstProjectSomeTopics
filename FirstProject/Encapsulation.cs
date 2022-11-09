using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    internal class Encapsulation
    {
        private int id;
        private string name;
        private int age;

        public int setAge(int a)
        {
            if(a < 0 || a > 100)
            {
                throw new Exception("the age must be greater than 8 and less than hundred");

            }
            else
            {
                this.age = a;
                return age;
            }
        }

        public int getAge()
        {
            return age;
        }
        //public void Display()
        //{
        //    Console.WriteLine("age is {0}, name: {}, id is {2}", age, name, id);
        //}
    }
}
