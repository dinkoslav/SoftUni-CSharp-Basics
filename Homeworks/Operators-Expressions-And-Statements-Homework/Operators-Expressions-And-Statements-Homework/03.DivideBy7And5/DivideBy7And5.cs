using System;

    class DivideBy7And5
    {
        static void Main()
        {
            Console.WriteLine("Enter number to see if it can be devided by 7 and 5 :");
            int givenNumber = int.Parse(Console.ReadLine());
            bool canDevide = givenNumber % 7 == 0 && givenNumber % 5 == 0;
            Console.WriteLine(canDevide);
        }
    }
