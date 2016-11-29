using System;

namespace _07.Sum5Numbers
{
    class Sum5Numbers
    {
        static void Main()
        {
            int a, b, c, d, e;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());
            int sum = a + b + c + d + e;
            Console.WriteLine(sum);
        }
    }
}
