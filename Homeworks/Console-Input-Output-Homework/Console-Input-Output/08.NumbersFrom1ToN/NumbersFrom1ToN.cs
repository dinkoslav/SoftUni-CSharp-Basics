using System;

    class NumbersFrom1ToN
    {
        static void Main()
        {
            Console.Write("Write a number : ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }