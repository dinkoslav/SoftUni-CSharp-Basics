using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter a : ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b : ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c : ");
        double c = double.Parse(Console.ReadLine());

        double discriminant = (b * b) - 4 * a * c;

        if (discriminant < 0)
        {
            Console.WriteLine("There are no real roots.");
        }
        else if (discriminant == 0)
        {
            double x1 = ((-b + Math.Sqrt(discriminant)) / (2 * a));
            Console.WriteLine("X1 = X2 = {0:F2}", x1);
        }
        else
        {
            double x1 = ((-b + Math.Sqrt(discriminant)) / (2 * a));
            double x2 = ((-b - Math.Sqrt(discriminant)) / (2 * a));
            Console.WriteLine("X1 = {0}; X2 = {1}", x1, x2);
        }
    }
}