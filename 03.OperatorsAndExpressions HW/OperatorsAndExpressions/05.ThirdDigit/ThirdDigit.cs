using System;

namespace _05.ThirdDigit
{
    class ThirdDigit
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            uint reminder = (number / 100) % 10;
            if ((reminder == 7))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false " + reminder);
            }
        }
    }
}
