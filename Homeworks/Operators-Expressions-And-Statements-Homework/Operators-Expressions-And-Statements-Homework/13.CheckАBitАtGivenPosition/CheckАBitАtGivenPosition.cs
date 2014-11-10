using System;

class CheckАBitАtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int givenNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a index to tell is the bit 1 :");
        int givenIndex = int.Parse(Console.ReadLine());

        bool isOne = (givenNumber & (1 << givenIndex)) > 1;

        Console.WriteLine(isOne);
    }
}