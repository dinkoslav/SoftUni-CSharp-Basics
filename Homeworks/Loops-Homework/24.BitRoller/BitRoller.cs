using System;

    class BitRoller
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine()); ;
            int f = int.Parse(Console.ReadLine()); ;
            int r = int.Parse(Console.ReadLine()); ;
            for (int roll = 0; roll < r; roll++)
            {
                if ((n & 1) == 1)
                {
                    n = n >> 1;
                    n = n | (1 << 18);
                }
                else if ((n & 1) == 0)
                {
                    n = n >> 1;
                }
                if (f == 0)
                {
                    int positionF = (n) & 1;
                    int positionX = (n >> 18) & 1;
                    if (positionF > positionX)
                    {
                        n = n & ~1;
                        n = n | (1 << 18);
                    }
                    else if (positionF < positionX)
                    {
                        n = n | 1 ;
                        n = n & ~(1 << 18);
                    }
                }
                else
                {
                    int positionF = (n >> (f-1))&1;
                    int positionX = (n >> (f))&1;
                    if (positionF > positionX)
                    {
                        n = n&~(1<<(f-1));
                        n = n | (1 << f);
                    }
                    else if (positionF < positionX)
                    {
                        n = n|(1<<(f-1));
                        n = n & ~(1 << f);
                    }
                }
            }
            Console.WriteLine(n);
        }
    }
