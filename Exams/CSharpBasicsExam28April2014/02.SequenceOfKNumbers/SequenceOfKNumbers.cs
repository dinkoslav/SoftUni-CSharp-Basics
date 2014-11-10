using System;

class SequenceOfKNumbers
    {
    static void Main()
        {
        string inputNumbers = Console.ReadLine();
        int k = int.Parse(Console.ReadLine());
        int number = 0;
        int count = 0;
        int outputWriten = 0;
        string[] numbers = inputNumbers.Split(' ');

        if (k >1)
            {
            for (int i = 0; i < numbers.Length; i++)
                {
                int n = int.Parse(numbers[i]);
                if (number == 0)
                    {
                    number = n;
                    count = 1;
                    }
                else if (number == n)
                    {
                    count++;
                    }
                else if (number != n)
                    {
                    for (int j = 0; j < count; j++)
                        {
                        if (outputWriten != 0)
                            {
                            Console.Write(" ");
                            }
                        Console.Write(number);
                        outputWriten++;
                        }
                    count = 1;
                    number = n;
                    }
                if (count == k)
                    {
                    count = 0;
                    number = 0;
                    }
                }
            }
        if (count >0)
            {
            for (int j = 0; j < count; j++)
                {
                if (outputWriten != 0)
                    {
                    Console.Write(" ");
                    }
                Console.Write(number);
                }
            }
        Console.WriteLine();
        }
    }
