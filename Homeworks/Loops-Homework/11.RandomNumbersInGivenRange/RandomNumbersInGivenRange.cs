﻿using System;

    class RandomNumbersInGivenRange
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                if (i != 0)
                {
                    Console.Write(" ");
                }
                Console.Write(rnd.Next(min, max+1));
            }
            Console.WriteLine("");
        }
    }