using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int index = 0; index < n; index++)
            {
                arr[index] = int.Parse(Console.ReadLine());
            }
            int maxSum = arr[0], currentSum = arr[0];
            int start = 0, startTemp = 0, end = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                currentSum += arr[i];
                if (currentSum < arr[i])
                {
                    currentSum = arr[i];
                    startTemp = i;
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    start = startTemp;
                    end = i;
                }
            }
                Console.Write(maxSum);
        }
    }
}
