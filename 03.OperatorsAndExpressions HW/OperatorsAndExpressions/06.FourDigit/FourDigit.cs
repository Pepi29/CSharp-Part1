using System;

namespace _06.FourDigit
{
    class FourDigit
    {
        static void Main()
        {          
            string number;
            do
            {
                number = Console.ReadLine();
            }
            while ((number.Length != 4) | (number.StartsWith("0")));
            int num = int.Parse(number);
            int a = (num / 1000) % 10;
            int b = (num / 100) % 10;
            int c = (num / 10) % 10;
            int d = num % 10;
            int sum = a + b + c + d;
            Console.WriteLine("{0}", sum);
            Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
        }
    }
}
