using System;

namespace _12.DecToBin
{
    class DecToBin
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            string[] output = new string [n];
            int i = -1;
            if (n == 0)
            {
                Console.Write(0);
            }
            while(n>0)
            {
                i++;
                if (n % 2 == 0)
                {
                    output[i] = "0";
                }
                else
                {
                    output[i] = "1";
                }
                n = n / 2;
            }
            while (i>=0)
            {
                Console.Write(output[i]);
                i--;
            }
            
        }
    }
}

