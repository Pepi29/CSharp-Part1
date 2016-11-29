using System;

namespace _02.MoonGravity
{
    class MoonGravity
    {
        static void Main()
        {
            double earthWeight = double.Parse(Console.ReadLine()); 
            double moonWeight = earthWeight * 0.17;
            Console.WriteLine("{0:0.000}" , moonWeight);
        }
    }
}
