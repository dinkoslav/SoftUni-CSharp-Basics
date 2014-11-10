using System;
using System.Numerics;

    class CatalanNumbers
    {
        static void Main()
        {
            CatalanNumbers m = new CatalanNumbers();
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger catalanNumber = m.Factorial((2 * n)) / ((m.Factorial((n + 1)) * (m.Factorial(n))));
            Console.WriteLine(catalanNumber);
        }
        public BigInteger Factorial(BigInteger n)
        {

            BigInteger result;

            if (n == 1)
            {
                return 1;
            }
            else
            {
                result = Factorial(n - 1) * n;
                return result;
            }

        }
    }
