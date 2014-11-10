using System;

    class OddOrEvenIntegers
    {
        static void Main()
        {
            Console.WriteLine("Write me a number and ill tell you if its even ...");
            int givenNumber = int.Parse(Console.ReadLine());
            bool isEven = givenNumber % 2 == 0;

            Console.WriteLine(isEven);
            
        }
    }
