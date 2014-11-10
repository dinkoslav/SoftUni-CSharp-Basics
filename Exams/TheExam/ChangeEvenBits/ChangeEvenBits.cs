using System;
using System.Numerics;

class ChangeEvenBits
    {
    static void Main()
        {
        int n = int.Parse(Console.ReadLine());
        int bitsInNumber = 0;
        int bitsChanged = 0;
        for (int i = 0; i < n; i++)
            {
            int m = int.Parse(Console.ReadLine());
            for (int j = 0; j < 16; j++)
                {
                if (m == 0 && bitsInNumber == 0)
                    {
                    bitsInNumber = 1;
                    }
                else if ((m >> j & 1) == 1 && j > bitsInNumber)
                    {
                    bitsInNumber = j + 1;
                    }
                }
            }
        BigInteger L = BigInteger.Parse(Console.ReadLine());
        for (int i = 0; i < bitsInNumber*2; i++)
            {
            if (i%2 == 0 && ((L >> i) & 1) == 0)
                {
                L = L | ((BigInteger)1 << i);
                bitsChanged++;
                }
            }
        //Console.WriteLine(bitsInNumber);
        Console.WriteLine(L);
        Console.WriteLine(bitsChanged);
        }
    }