using System;

namespace _10.FibonacciNumbers
{
    class Fibonacii
    {
        static void Main()
        {
            long n;
            do
            {
                n = int.Parse(Console.ReadLine()); 
            } while (n <= 0 || n > 50);

            long a = 0;
            long b = 1;
            long fibonacci;
            if (n==1)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.Write("{0}, {1}", a, b);
            }
            for (int i = 0; i < n-2; i++)
            {
                fibonacci = a + b; 
                a = b; 
                b = fibonacci; 
                Console.Write(", {0}", fibonacci);
            }
                
        }
    }
}
