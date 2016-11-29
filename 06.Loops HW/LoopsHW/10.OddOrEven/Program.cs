using System;


namespace _10.OddOrEven
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine()); //pokazva kolko chisla shte vyvejdam
            string[] sequence = Console.ReadLine().Split();
            int[] numbers = new int[N];
            long odd = 1;
            long even = 1;
            for (int i = 0; i < N; i++)
            {
                numbers[i] = Convert.ToInt32(sequence[i]);
            }
            for (int i = 0; i < N; i++)
            {
                if (i%2==0)
                {
                    odd *= numbers[i];
                }
                else
                {
                    even *= numbers[i];
                }
            }
            if (even==odd)
            {
                Console.WriteLine("yes {0}", even);
            }
            else
            {
                Console.WriteLine("no {0} {1}", odd, even);
            }
        }
    }
}
