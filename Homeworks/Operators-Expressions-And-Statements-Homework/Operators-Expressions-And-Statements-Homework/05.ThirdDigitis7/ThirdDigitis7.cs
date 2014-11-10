using System;

    class ThirdDigitis7
    {
        static void Main()
        {
            Console.WriteLine("Enter a number to see if the third number is 7 :");
            int givenNumber = Math.Abs(int.Parse(Console.ReadLine()));

            bool isSeven = (givenNumber / 100) % 10 == 7;
            Console.WriteLine(isSeven);
        }
    }