using System;

    class TheBiggestOf3Numbers
    {
        static void Main()
        {
            double biggestNumber = double.MinValue;
            for (int i = 0; i < 3; i++)
            {
                double n = double.Parse(Console.ReadLine());
                if (n>biggestNumber)
                {
                    biggestNumber = n;
                }
            }

            Console.WriteLine(biggestNumber);
        }
    }
