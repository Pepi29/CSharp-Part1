using System;

namespace _02.NotDivisibleBy3and7
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                if (i % 7 == 0 || i % 3 == 0)
                {
                    continue;
                }
                Console.Write(i + " ");
            }
        }
    }
}
