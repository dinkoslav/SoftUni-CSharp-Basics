using System;

    class BitExchangeAdvanced
    {
        static void Main()
        {
            try
            {
                uint n = uint.Parse(Console.ReadLine());
                int p = int.Parse(Console.ReadLine());
                int q = int.Parse(Console.ReadLine());
                int k = int.Parse(Console.ReadLine());
                if ((Math.Max(p, q) + k - 1) > 31)
                {
                    Console.WriteLine("Out of range");
                }
                else if (Math.Min(p, q) + k - 1 >= Math.Max(p, q))
                {
                    Console.WriteLine("Overlapping");
                }
                else
                {
                    for (int i = p; i <= p + k - 1; i++)
                    {
                        uint mask = 1;
                        uint bitQ = (n & (mask << q)) >> q;
                        uint bitP = (n & (mask << i)) >> i;

                        n = n & ~(mask << i);
                        n = n & ~(mask << q);

                        n = n | (bitP << q);
                        n = n | (bitQ << i);
                        q++;
                    }
                    Console.WriteLine(n);
                }

            }
            catch (Exception ex) 
            {
                Console.WriteLine("Out of range");
            }
        }
    }