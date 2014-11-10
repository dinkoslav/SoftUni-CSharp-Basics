using System;

    class NumbersFrom1ToN
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int number = 1;
            for (int i = 0; i < n; i++)
            {
                if (i>0)
                {
                    Console.Write(" ");
                }
                Console.Write(number);
                number++;
            }
            Console.WriteLine("");
        }
    }