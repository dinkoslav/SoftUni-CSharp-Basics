using System;

class OddEvenElements
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] inputLine = input.Split(' ');
        decimal oddSum = 0;
        decimal evenSum = 0;
        decimal oddMin = decimal.MaxValue;
        decimal oddMax = decimal.MinValue;
        decimal evenMin = decimal.MaxValue;
        decimal evenMax = decimal.MinValue;
        if (input == "")
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
        }
        else if (inputLine.Length == 1)
        {
            decimal number = decimal.Parse(inputLine[0]);
            Console.WriteLine("OddSum={0}, OddMin={0}, OddMax={0}, EvenSum=No, EvenMin=No, EvenMax=No", (double)number);
        }
        else
        {
            for (int i = 0; i < inputLine.Length; i++)
            {
                if (i % 2 == 0)
                {
                    decimal number = decimal.Parse(inputLine[i]);
                    oddSum = oddSum + number;
                    if (number < oddMin)
                    {
                        oddMin = number;
                    }
                    if (number > oddMax)
                    {
                        oddMax = number;
                    }
                }
                else
                {
                    decimal number = decimal.Parse(inputLine[i]);
                    evenSum = evenSum + number;
                    if (number < evenMin)
                    {
                        evenMin = number;
                    }
                    if (number > evenMax)
                    {
                        evenMax = number;
                    }
                }
            }
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", (double)oddSum, (double)oddMin, (double)oddMax, (double)evenSum, (double)evenMin, (double)evenMax);
        }
    }
}
