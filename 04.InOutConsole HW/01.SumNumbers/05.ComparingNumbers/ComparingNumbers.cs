using System;

namespace _05.ComparingNumbers
{
    class ComparingNumbers
    {
        static void Main()
        {
            double firstnum = double.Parse(Console.ReadLine());
            double secondnum = double.Parse(Console.ReadLine());
            double greaternum = Math.Max (firstnum, secondnum);
            Console.WriteLine(greaternum);
        }
    }
}
