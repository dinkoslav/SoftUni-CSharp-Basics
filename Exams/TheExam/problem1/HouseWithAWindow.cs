using System;

class HouseWithAWindow
    {
    static void Main()
        {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}", new string('.',n-1),"*"); 
        for (int i = 1; i < n; i++)
            {
            if (i==1)
                {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n - 1 - i), "*", new string('.', i));
                }
            else
                {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n - 1 - i), "*", new string('.', 1+(2*(i-1))));
                }
            }
        Console.WriteLine("{0}", new string('*', n + (n - 1)));
        for (int i = 1; i < n+1; i++)
            {
            if (i <= (n / 4) || i>(n - n / 4) )
                {
                Console.WriteLine("{0}{1}{0}", "*", new string('.', n + (n - 1) -2));
                }
            else
                {
                Console.WriteLine("{0}{1}{2}{1}{0}", "*", new string('.', n / 2), new string('*', (n - 3) ));
                }
            }
        Console.WriteLine("{0}", new string('*', n + (n - 1)));
        }
    }