using System;

namespace _01.Numbers1toN
{
    class Number1ToN
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int number = 1;
             while (number<=n)
            {
                Console.Write(number+ " ");
                number++;
            }
        }
    }
}
