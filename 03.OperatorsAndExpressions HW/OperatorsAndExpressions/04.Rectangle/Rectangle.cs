using System;

namespace _04.Rectangle
{
    class Rectangle
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double area = a * b;
            double perimeter = (2 * a) + (2 * b);
            Console.Write("{0:0.00} ", area);
            Console.WriteLine("{0:0.00}", perimeter);

        }
    }
}
