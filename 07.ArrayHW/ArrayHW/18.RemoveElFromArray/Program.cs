using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.RemoveElFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nArray = new int[n];
            for (int i = 0; i <= nArray.Length - 1; i++)
            {
                nArray[i] = int.Parse(Console.ReadLine());
            }

            int[] Longest = new int[n]; 
            for (int i = 0; i <= Longest.Length - 1; i++)
            {
                Longest[i] = 1;
            }
         
            for (int masterIndex = 1; masterIndex < n; masterIndex++)
            {
                for (int subIndex = 0; subIndex < masterIndex; subIndex++)
                {
                    if ((nArray[masterIndex] >= nArray[subIndex]) && (Longest[subIndex] >= Longest[masterIndex]))
                    {
                        Longest[masterIndex] = Longest[subIndex] + 1;
                    }
                }
            }
         
            Array.Sort(Longest);
            int printResult = n - Longest[Longest.Length - 1];
            Console.WriteLine(printResult);
        }
        }
    }
