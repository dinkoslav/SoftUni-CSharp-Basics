using System;

    class Trapezoids
    {
        static void Main()
        {
            Console.WriteLine("Enter A :");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter B :");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter H :");
            double h = double.Parse(Console.ReadLine());

            double area = ((a + b) / 2) * h;

            Console.WriteLine(area);
        }
    }
