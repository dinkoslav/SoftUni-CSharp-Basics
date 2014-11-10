using System;

    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Console.Write("Enter radius :");
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            double perimeter = 2 * Math.PI * r;

            Console.WriteLine("If the radius is {0}, then the perimeter is {1:F2} and the area is {2:F2} !!!", r, perimeter, area);
        }
    }