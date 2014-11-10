using System;

    class NumberComparer
    {
        static void Main()
        {
            Console.Write("Write number one : ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Write number two : ");
            double b = double.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("{0} is greater then {1}", a , b);
            }
            else if (b > a)
            {
                Console.WriteLine("{0} is greater then {1}", b, a);
            }
            else
            {
                Console.WriteLine("Both numbers are equal to {0}", a);
            }
        }
    }