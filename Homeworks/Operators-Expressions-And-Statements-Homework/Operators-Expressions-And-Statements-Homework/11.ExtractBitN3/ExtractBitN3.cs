using System;

    class ExtractBitN3
    {
        static void Main()
        {
            Console.WriteLine("Enter a number to tell you bit # 3 :");
            uint givenNumber = uint.Parse(Console.ReadLine());
            uint mask = 1;
            if ((mask << 3 & givenNumber) == 0)
            {
                Console.WriteLine("0");
            }
            else 
            {
                Console.WriteLine("1");
            }
            Console.WriteLine((mask << 3 & givenNumber) == 0 ? "0" : "1");
        }
    }