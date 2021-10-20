using System;

namespace Dynamic_object
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Dynamic_Object obj1 = new Dynamic_Object();
            obj1.First_Method();
            obj1.Second_Method();

            dynamic obj2 = new Dynamic_Object();
            obj2.First_Method();
            obj2.Second_Method();
        }
    }
}
