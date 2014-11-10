using System;
using System.Numerics;

    class BitFlipper
    {
        static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger m = 7;
            int index = 61;

            while (index>=0)
            {
                if (((n>>index) & m) == 0 )
                {
                    n = n | (m << index);
                    index = index - 3;
                }
                else if (((n >> index) & m) == 7)
                {
                    n = n & ~(m << index);
                    index = index - 3;
                }
                else
                {
                    index--;
                }
            }
            Console.WriteLine(n);
        }
    }