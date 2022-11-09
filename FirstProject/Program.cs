using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class1 _class1 = new Class1();
            //_class1.firstname = "AVI";
            //_class1.lastname = "PALERYA";
            //_class1.printFullName();

            //Class2 _class2 = new Class2();
            //_class2.firstname = "AKSHATA";
            //_class2.lastname = "NAIK";
            //_class2.printFullName();

            //fit the lower type in the higher type
            //Example _example = new Example1();

            //Example _example2 = new Example1();

            //Example _example3 = new Example();

            //_example.method1(9);
            //_example2.method1(9);
            //_example3.method1(9);

            //_example.method1();//parent class method
            //_example2.method1();//child class
            //_example3.method1();//parent class

            //POLYMORPHISM
            //Runtime(time where memory allocation is done)
            //compile time 

            //CompileTime _compileTime = new CompileTime();
            //Console.WriteLine(_compileTime.Add(2, 3, 1));

            //Drawing _drawing = new Drawing();
            //Console.WriteLine(_drawing.Area(10));//0

            //Drawing _drawing2 = new Circle();
            //Console.WriteLine(_drawing2.Area(10));//314

            //Drawing _drawing3 = new Square();
            //Console.WriteLine(_drawing3.Area(10));//100

            //MultipleInherit multipleInherit = new MultipleInherit();


            //default constructor
            //instead of this default constructor we create user defined constructor in Constructor.cs
            //v r creating user defined constructor in constructor.cs so thats y error in this constructor
            //Constructor _constructor = new Constructor();

            //_constructor.id = 1;
            //_constructor.name = "Nayana";

            //instance creation
            //initializing the value

            //Console.WriteLine(new Constructor(2));
            //Console.WriteLine(new Constructor("Nayana",2));

            //Constructor ref1 = new Constructor(10);
            //Constructor ref2 = new Constructor("Nayana", 2);
            //Constructor constructor = new Constructor();

            //Console.WriteLine(ref1.id);
            //Console.WriteLine(ref2.name, ref2.id);

            //Constructor2 ref3 = new Constructor2("JAY", 30);
            //Constructor2 ref4 = new Constructor2(10);
            //Console.WriteLine(ref3.y);
            //Console.WriteLine(ref3.x);

            //Constructor2 ref5 = new Constructor2("JAY", 2, "RAJ");
            //Console.WriteLine(ref5.y);
            //Console.WriteLine(ref5.x);
            //Console.WriteLine(ref5.name);

            //Casting.cs//upcasting
            //Casting casting = new Casting2();

            ////downcasting
            /*Casting2 casting2 = new Casting();*///child class is bigger than parent class


            //Encapsulation
            //Encapsulation E = new Encapsulation();
            //E.setAge(-20);
            ////E.id = 2;
            //Console.WriteLine(E.getAge());


            //Types.cs
            //array
            //Types t = new Types();
            //t.initialize();


            //MultiDimension.cs
            //MultiDimension Ma = new MultiDimension();

            //Ma.InitTwoDimension();
            //Ma.ThreeDimension();

            //JaggedArray.cs
            JaggedArray jagged = new JaggedArray();
            jagged.jaggedArray();

        }


    }
}
