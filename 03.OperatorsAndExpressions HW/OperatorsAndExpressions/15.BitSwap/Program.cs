using System;
class BitExchangeAdvanced
{
    static void Main()
    {
        int num1, num2, p, q, k, loop;
        uint n, n1, bit;
        while (true)
        {
            // input number

            Console.WriteLine("Input n:");
            if (uint.TryParse(Console.ReadLine(), out n))
            {
                if (n >= 0)
                {
                    break;
                }
            }
        }

        // input first position
        while (true)
        {
            Console.WriteLine("Input p:");
            if (int.TryParse(Console.ReadLine(), out p))
            {
                if (p >= 0)
                {
                    break;
                }
            }
        }

        // input second position

        while (true)
        {
            Console.WriteLine("Input q:");
            if (int.TryParse(Console.ReadLine(), out q))
            {
                if (q >= 0)
                {
                    break;
                }
            }
        }

        // input the limit
        while (true)
        {
            Console.WriteLine("Input k:");
            if (int.TryParse(Console.ReadLine(), out k))
            {
                if (k > 0)
                {
                    break;
                }
            }
        }

        // check which position is first
        if (p > q)
        {
            num1 = q;
            num2 = p;
        }
        else
        {
            num1 = p;
            num2 = q;
        }

        // the loop is used in the "for" loop
        loop = num1;

        // check if the inpputs are valid for completing the operation
        if (num2 - num1 < k || num1 + k > 32 || num2 + k > 32)
        {
            Console.WriteLine("Overlapping or out of range");
        }
        else
        {

            // use "for" in order to complete the formula {p, p+1, …, p+k-1}
            for (num1 = loop; num1 < (loop + k); num1++)
            {
                bit = (n >> num1) & 1; // check the first value
                if (bit == 1)
                {
                    n1 = (bit << num1 + (num2 - num1)) | n; // input the value to its analog in num2
                    bit = (n >> num1 + (num2 - num1)) & 1; // complete the opposite operation
                    if (bit == 1)
                    {
                        n1 = (bit << num1) | n1;
                    }
                    else
                    {
                        n1 = ~((bit + 1) << num1) & n1;
                    }
                }
                else
                {
                    n1 = ~((bit + 1) << num1 + (num2 - num1)) & n; // same as the above but with different operations
                    bit = (n >> num1 + (num2 - num1)) & 1; // complete the opposite operation again
                    if (bit == 1)
                    {
                        n1 = (bit << num1) | n1;
                    }
                    else
                    {
                        n1 = ~((bit + 1) << num1) & n1;
                    }
                }
                n = n1;
                num2 = num2 + 1; // completes the second formula {q, q+1, …, q+k-1}
            }

            Console.WriteLine("The result is: {0}", n); // print the result
        }



    }
}