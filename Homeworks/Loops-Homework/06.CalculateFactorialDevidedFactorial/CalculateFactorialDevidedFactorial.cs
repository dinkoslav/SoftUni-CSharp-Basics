using System;

    class CalculateFactorialDevidedFactorial
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            CalculateFactorialDevidedFactorial m = new CalculateFactorialDevidedFactorial();
            double sum = m.Factorial(n) / m.Factorial(k);
            Console.WriteLine(sum);
            
        }
        public int Factorial(int n)
        {

            int result;

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