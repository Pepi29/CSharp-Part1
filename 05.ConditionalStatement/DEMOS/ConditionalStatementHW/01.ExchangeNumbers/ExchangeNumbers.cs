using System;

namespace _01.ExchangeNumbers
{
    class ExchangeNumbers
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double biggernum = a;
            if (a > b)
            {
                biggernum = a;
                Console.WriteLine("{0} {1}", b, a);
            }
            else
            {
                Console.WriteLine("{0} {1}", a, b);
            }
           
        }
    }
}
