using System;

namespace _03.MMSA
{
    class Program
    {
        static void Main()
        {
            double min, max;
            double sum = 0;
            double avg;
            int n = int.Parse(Console.ReadLine());
            double[] array = new double[n];

            if (n >= 1 && n <= 1000)
            {
                for (int i = 0; i <= n - 1; i++)
                {
                    array[i] = double.Parse(Console.ReadLine());
                }

                min = array[0];
                for (int i = 1; i <= n - 1; i++)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                    }
                }

                max = array[0];
                for (int i = 1; i <= n - 1; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                    }
                }

                for (int i = 0; i <= n - 1; i++)
                {
                    sum = sum + array[i];
                }

                avg = sum / n;

                Console.WriteLine("min={0:0.00}", min);
                Console.WriteLine("max={0:0.00}", max);
                Console.WriteLine("sum={0:0.00}", sum);
                Console.WriteLine("avg={0:0.00}", avg);
            }
        }
    }
}

