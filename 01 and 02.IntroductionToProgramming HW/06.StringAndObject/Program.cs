using System;

namespace _06.StringAndObject
{
    class Program
    {
        static void Main()
        {
            string greeting = "Hello";
            string name = "World";

            object container =" ";
            Console.WriteLine("The greeting is: {0}{1}{2}",  greeting, container, name);
            
           //eu Console.WriteLine("{0} {1}", greeting, name);
            
        }
    }
}
