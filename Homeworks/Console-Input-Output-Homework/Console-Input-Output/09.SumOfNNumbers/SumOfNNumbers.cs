using System;

    class SumOfNNumbers
    {
        static void Main()
        {
            Console.Write("Write a count : ");
            int count = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < count; i++)
            {
                Console.Write("Write a number : ");
                sum = sum + double.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
