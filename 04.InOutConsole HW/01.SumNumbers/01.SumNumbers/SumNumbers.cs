﻿using System;

namespace _01.SumNumbers
{
    class SumNumbers
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double sum = a + b + c;
            Console.WriteLine(sum);
        }
    }
}
