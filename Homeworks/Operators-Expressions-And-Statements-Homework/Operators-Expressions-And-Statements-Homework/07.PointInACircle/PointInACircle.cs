using System;

class PointInACircle
    {
        static void Main()
        {
            Console.WriteLine("Enter X :");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y :");
            double y = double.Parse(Console.ReadLine());
            bool isInCircle = ((x * x) + (y * y)) <= 2 * 2;
            Console.WriteLine(isInCircle);
        }
    }
