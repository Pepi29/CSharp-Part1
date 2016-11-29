using System;

class MaxSumWithFixedLength
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int k = int.Parse(Console.ReadLine());
        for (int index = 0; index < n; index++)
        {
            arr[index] = int.Parse(Console.ReadLine());
        }
       
        int Sum = 0;
        int position = 0;
        int big = int.MinValue;
        while (k>0)
        {
            big = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > big)
                {
                    big = arr[i];
                    position = i;
                }
            }
            arr[position] = int.MinValue;
            Sum += big;
            k--;
        }
        Console.Write(Sum);
    }
}