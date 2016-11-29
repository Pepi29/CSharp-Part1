using System;

namespace _15.MineProject
{
    class BitExchandeAdv
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            for (int i=p;  i < ((p+k)-1); i ++)
            {
                uint mask = 1;
                uint Pbit = ((mask << i) & n) >> i;
                uint Qbit = ((mask << q) & n) >> q;

                n = n & ~(mask << i);
                n = n & ~(mask << q);
                n = n | (Pbit << q);
                n = n | (Qbit << i);
                q++;
            }
            Console.WriteLine(n);
        }
    }
}
