using System;

    class Cinema
    {
        static void Main()
        {
            string typeOfMovie = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double income = 0;
            int seats = rows * columns;
            if (typeOfMovie == "Premiere")
            {
                income = seats * 12;
            }
            else if (typeOfMovie == "Normal")
            {
                income = seats * 7.5;
            }
            else if (typeOfMovie == "Discount")
            {
                income = seats * 5;
            }
            Console.WriteLine("{0:F2} leva",income);
        }
    }
