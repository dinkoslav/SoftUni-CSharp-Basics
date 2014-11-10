using System;

    class CalculateGCD
    {
        static void Main()
        {
            int value1 = int.Parse(Console.ReadLine());
            int value2 = int.Parse(Console.ReadLine());
            while (value1 != 0 && value2 != 0)
            {
                if (value1 > value2)
                {
                    value1 -= value2;
                }
                else
                {
                    value2 -= value1;
                }
            }
            Console.WriteLine(Math.Max(value1, value2)); 
        }
    }