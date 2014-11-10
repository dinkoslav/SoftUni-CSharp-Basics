using System;

    class NumbersInIntervalDividable
    {
        static void Main()
        {
            Console.Write("Enter first positive integer : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second positive integer : ");
            int b = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0)
                {
                    count += 1;
                }
            }
            Console.WriteLine(count);
        }
    }