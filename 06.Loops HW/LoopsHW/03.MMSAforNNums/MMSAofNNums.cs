using System;

namespace _03_MMSAOfNNumbers
{
    class _03_MMSAOfNNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double min = 1;
            double max = 0;
            double sum = 0;

            for (int i = 0; i < number; i++)
            {
                double num = double.Parse(Console.ReadLine());
                sum += num;
                if (num <= min)
                {
                    min = num;
                }
                else if (num >= max)
                {
                    max = num;
                }
            }
            Console.WriteLine("min={0:F2}", min);
            Console.WriteLine("max={0:F2}", max);
            Console.WriteLine("sum={0:F2}", sum);
            Console.WriteLine("avg={0:F2}", sum / (int)number);
        }
    }
}