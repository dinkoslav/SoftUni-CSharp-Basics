using System;

    class Pairs
    {
        static void Main()
        {
            string str = Console.ReadLine();
            string[] tokens = str.Split(' ');
            int[] convertedNumbers = Array.ConvertAll<string, int>(tokens, int.Parse);
            int[] sumOfNumbers = new int[convertedNumbers.Length/2];
            int value = 0;
            int difference = 0;
            int tempCounter = 0;
            for (int i = 0; i < convertedNumbers.Length; i+=2,tempCounter++)
            {
                sumOfNumbers[tempCounter] = convertedNumbers[i] + convertedNumbers[i+1];
            }

            for (int i = 0; i < sumOfNumbers.Length; i++)
            {
                for (int j = i+1; j < sumOfNumbers.Length; j++)
                {
                    if (sumOfNumbers[i]<sumOfNumbers[j])
                    {
                        int tempDifference = Math.Abs(sumOfNumbers[j] - sumOfNumbers[i]);
                        if (difference<tempDifference)
                        {
                            difference = tempDifference;
                        }
                    }
                    else
                    {
                        int tempDifference = Math.Abs(sumOfNumbers[i] - sumOfNumbers[j]);
                        if (difference < tempDifference)
                        {
                            difference = tempDifference;
                        }
                    }
                }
            }
            if (difference>0)
            {
                Console.WriteLine("No, maxdiff={0}",difference);
            }
            else
            {
                value = sumOfNumbers[0];
                Console.WriteLine("Yes, value={0}", value);
            }
        }
    }