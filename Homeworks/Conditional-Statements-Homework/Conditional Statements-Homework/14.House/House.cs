using System;

    class House
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n/2; i++)
            {
                if (i==0)
                {
                    Console.WriteLine("{0}{1}{0}", new string('.', (n / 2) - i), "*");
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', (n / 2) - i), "*", new string('.', n-((2*((n / 2) - i))+2)));
                }
            }
            Console.WriteLine("{0}",new string('*',n ));
            for (int i = 0; i < (n / 2) - 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.',n/4), "*", new string('.',n-(2*(n/4)+2)));
            }
            Console.WriteLine("{0}{1}{0}", new string('.', n / 4), new string('*', n - (2 * (n / 4))));
        }
    }