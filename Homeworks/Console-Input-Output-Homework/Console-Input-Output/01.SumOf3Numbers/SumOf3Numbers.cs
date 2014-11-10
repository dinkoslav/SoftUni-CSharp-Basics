using System;

    class SumOf3Numbers
    {
        static void Main()
        {
            Console.Write("Enter number a :");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter number b :");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter number c :");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum of {0}, {1} and {2} is {3}", a, b, c, a+b+c);
        }
    }