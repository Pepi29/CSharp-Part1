using System;

namespace _08.Numers1toN
{
    class Numbers1toN
    {
        static void Main()
        {
            uint N = uint.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
