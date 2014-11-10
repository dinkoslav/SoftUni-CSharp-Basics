using System;

    class FibonacciNumbers
    {
        static void Main()
        {
            Console.Write("Enter a number to see the Fibonacci Numbers : ");
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int c = 0;

            for (int i = 0; i < n; i++)
            {
                
                if (n == 1 || i == 0)
                {
                    Console.Write(a + " ");
                }
                else if (i == 1)
                {
                    Console.Write(b + " ");
                }
                else
                {
                    c = a + b;
                    Console.Write(c + " ");
                    a = b;
                    b = c;
                }
            }
        }
    }