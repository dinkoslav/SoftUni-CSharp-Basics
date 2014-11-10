using System;

    class TheBiggestOfFiveNumbers
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            double biggestNumber = double.MinValue;

            if (a>=b && a>=c &&a>=d && a>=e && a>=biggestNumber)
            {
                biggestNumber = a;
            }
            else if (b >= a && b >= c && b >= d && b >= e && b >= biggestNumber)
            {
                biggestNumber = b;
            }
            else if (c>=b && c>=a && c>=d && c>=e && c>=biggestNumber)
            {
                biggestNumber = c;
            }
            else if (d>=b && d>=a && d>=c && d>=e && d>=biggestNumber)
            {
                biggestNumber = d;
            }
            else if (e>=b && e>=a && e>=d && e>=c && e>=biggestNumber)
            {
                biggestNumber = e;
            }
            Console.WriteLine(biggestNumber);
        }
    }
