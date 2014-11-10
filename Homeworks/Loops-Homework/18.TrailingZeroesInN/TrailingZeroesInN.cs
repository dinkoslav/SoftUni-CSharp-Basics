using System;
using System.Numerics;

    class TrailingZeroesInN
    {
        static void Main()
        {
            TrailingZeroesInN m = new TrailingZeroesInN();
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger nFactorial = m.Factorial(n);
            BigInteger sum = 0;
            while ((nFactorial%10) == 0)
            {
                sum++;
                nFactorial = nFactorial / 10;
            }
            Console.WriteLine(sum);

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