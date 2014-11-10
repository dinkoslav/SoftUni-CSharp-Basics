using System;

class BitSifting
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        int numberOfSieves = int.Parse(Console.ReadLine());

        for (int index = 0; index < numberOfSieves; index++)
        {
            long sieve = long.Parse(Console.ReadLine());

            for (int bit = 0; bit < 64; bit++)
            {
                long bitToCheck = (number >> bit) & 1;
                if (bitToCheck == 1)
                {
                    long bitToSieve = (sieve >> bit) & 1;
                    number ^= bitToSieve << bit;
                }
            }
        }

        int result = 0;
        while (number > 0)
        {
            int check = (int)(number & 1);
            if (check == 1)
            {
                result++;
            }
            number >>= 1;
        }

        Console.WriteLine(result);
    }
}