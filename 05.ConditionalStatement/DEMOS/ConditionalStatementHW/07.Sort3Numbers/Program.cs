﻿using System;

namespace Sort3Numbers
{
    class Sort3Numbers
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a < b)
            {
                if (b < c)
                {
                    Console.WriteLine("{0} {1} {2}", c, b, a);
                }
                else if (a < c)
                {
                    Console.WriteLine("{0} {1} {2}", b, c, a);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", b, a, c);
                }
            }
            else
            {
                if (b < c)
                {
                    if (a < c)
                    {
                        Console.WriteLine("{0} {1} {2}", c, a, b);
                    }
                    else
                    {
                        Console.WriteLine("{0} {1} {2}", a, c, b);
                    }
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                }
            }
        }
    }
}