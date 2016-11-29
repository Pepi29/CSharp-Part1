using System;

namespace _12.Nbits
{
    class Program
    {
        static void Main(string[] args)
        {
            long P;
            int N;
             N = int.Parse(Console.ReadLine());
            do
	        {
	            P = long.Parse(Console.ReadLine());
	        } while ((P>=0 & P<=Math.Pow(2,55)));
            do
	        {
	                 N = int.Parse(Console.ReadLine());
	        } while (N>=0 & N<=55);
            long numRightPossition = P >> N;
            long bit = numRightPossition & 1;
            Console.WriteLine(bit);    
        }
    }
}
