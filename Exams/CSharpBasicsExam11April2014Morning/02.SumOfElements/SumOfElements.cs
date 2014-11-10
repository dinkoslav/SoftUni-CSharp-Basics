using System;
using System.Numerics;

class SumOfElements
{
    static void Main()
    {
        string[] userINput = Console.ReadLine().Split();
        BigInteger biggerNumber = 0;
        BigInteger sumOfSmallerNumbers = 0;

        for (int i = 0; i < userINput.Length; i++)
        {
            int number = Convert.ToInt32(userINput[i]);
            if (number > biggerNumber)
            {
                sumOfSmallerNumbers = sumOfSmallerNumbers + biggerNumber;
                biggerNumber = number;
            }
            else
            {
                sumOfSmallerNumbers = sumOfSmallerNumbers + number;
            }
        }

        if (sumOfSmallerNumbers == biggerNumber)
        {
            Console.WriteLine("Yes, sum={0}", sumOfSmallerNumbers);
        }
        else if (sumOfSmallerNumbers < biggerNumber)
        {
            Console.WriteLine("No, diff={0}", biggerNumber - sumOfSmallerNumbers);
        }
        else
        {
            Console.WriteLine("No, diff={0}", sumOfSmallerNumbers - biggerNumber);
        }
    }
}