using System;

    class NumbersNotDivisibleBy3And7
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int number = 1;
            for (int i = 0; i < n; i++)
            {
                
                if (number % 3 != 0 && number % 7 != 0)
                {
                    if (i > 0)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(number);
                }
                number++;
            }
            Console.WriteLine("");
        }
    }