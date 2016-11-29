﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            bool[] bigArr = new bool[N+1];
            for (int i = 0; i < bigArr.Length; i++)
            {
                bigArr[i] = true;
            }
            for (int i = 2; i < Math.Sqrt(bigArr.Length); i++)
            {
                if (bigArr[i])
                {
                    for (int j = i * i; j < bigArr.Length; j = j + i)
                    {
                        bigArr[j] = false;
                    }
                }
            }

            for (int i = 0; i < bigArr.Length; i++)
            {
                if (bigArr[i])
                {
                    Console.Write(i);
                }
               
            }
        }
    }
}
