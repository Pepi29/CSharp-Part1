﻿using System;

namespace _09.SumNnumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                
                sum += num;
            }
            Console.WriteLine(sum);            
        }
    }
}
