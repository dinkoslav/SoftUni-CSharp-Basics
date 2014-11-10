using System;

class Arrow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n - 1; i++)
        {
            if (i == 0)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', n / 2), new string('#', n));
            }
            else
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n / 2), "#", new string('.', n - 2));
            }
        }
        for (int i = 0; i < n; i++)
        {
            if (i == 0)
            {
                Console.WriteLine("{0}{1}{0}", new string('#', n / 2 + 1), new string('.', n - 2));
            }
            else if (i == n - 1)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', n - 1), "#");
            }
            else
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', i), "#", new string('.', ((n + (2 * (n / 2))) - (2 + (2 * i)))));
            }
        }
    }
}