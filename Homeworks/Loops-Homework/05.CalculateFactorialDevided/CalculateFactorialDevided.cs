using System;

    class CalculateFactorialDevided
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            CalculateFactorialDevided m = new CalculateFactorialDevided();
            double sum = 0;

            for (int i = 0; i <= n; i++)
            {
                if (i == 0)
                {
                    sum = 1;
                }
                else
                {
                    sum = sum + m.Factorial(i) / Math.Pow(x, i);
                    //Console.WriteLine(m.Factorial(i));
                    //Console.WriteLine(Math.Pow(x, i));
                }
            }
            Console.WriteLine("{0:F5}", sum);
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