using System;

    class ExtractBitFromInteger
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            uint givenNumber = uint.Parse(Console.ReadLine());
            Console.WriteLine("Enter a index to tell what bit is there :");
            int givenIndex = int.Parse(Console.ReadLine());
            uint mask = 1;

            Console.WriteLine((mask << givenIndex & givenNumber) == 0 ? "0" : "1");
        }
    }
