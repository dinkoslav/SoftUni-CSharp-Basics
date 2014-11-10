using System;

    class CalculateFactorialAdvanced
    {
        static void Main()
        {
            CalculateFactorialAdvanced m = new CalculateFactorialAdvanced();
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int s = n - k;
            double sum = m.Factorial(n) / (m.Factorial(k)*(m.Factorial(s)));
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