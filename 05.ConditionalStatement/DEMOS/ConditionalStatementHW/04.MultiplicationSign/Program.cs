﻿using System;

namespace _04.MultiplicationSign
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if ((a * b * c) == 0)
            {
                Console.WriteLine("0");
            }
            else
                if (((a * b * c) < 0))
                {
                    Console.WriteLine("-");
                }
                else
                {
                    Console.WriteLine("+");
                }
        }
    }
}
