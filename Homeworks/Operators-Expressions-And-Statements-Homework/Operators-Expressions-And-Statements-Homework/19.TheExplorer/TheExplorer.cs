using System;

    class TheExplorer
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}", new string('-', n / 2), "*");
            for (int i = 0; i < n - 2; i++)
            {
                if (i < n / 2)
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', n / 2 - 1 - i), "*", new string('-', n - (2 * ((n / 2) - 1 - i)) - 2));
                }
                else 
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', (i - (n / 2)) + 1), "*", new string('-', n - (2 * ((i - (n / 2)) + 1) + 2)));
                }
            }
            Console.WriteLine("{0}{1}{0}", new string('-', n / 2), "*");
        }
    }
