using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    //parent class
    public class Drawing
    {
        
        public virtual double Area(int a)
        {
            return 0;
        }
    }

    //inheritance is involved
    public class Circle : Drawing
    {
        public override double Area(int a)
        {
            //circle area formula pi r square

            return (3.14) * a * a;
        }
    }

    public class Square : Circle
    {
        //writing square area formula a*a
        public override double Area(int a)
        {
            return a * a;
        }

    }
}
