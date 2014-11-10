using System;

class BiggestTriple
    {
        static void Main()
        {
            string values = Console.ReadLine();
            string[] tokens = values.Split(' ');
            int[] numbers = Array.ConvertAll<string, int>(tokens, int.Parse);
            int biggestSum = Int32.MinValue;
            int[] biggestSumNumbers= new int[3];

            

            for (int i = 0; i < numbers.Length - numbers.Length%3; i+=3)
            {
                if ((numbers[i]+numbers[i+1]+numbers[i+2])>biggestSum)
                {
                    biggestSumNumbers[0] = numbers[i];
                    biggestSumNumbers[1] = numbers[i+1];
                    biggestSumNumbers[2] = numbers[i+2];
                    biggestSum = (numbers[i] + numbers[i + 1] + numbers[i + 2]);
                }
            }
            if (numbers.Length %3 == 2)
            {
                if (numbers[numbers.Length-2]+numbers[numbers.Length-1]>biggestSum)
                {
                    Console.WriteLine("{0} {1}", numbers[numbers.Length - 2], numbers[numbers.Length - 1]);
                }
            }
            else if (numbers.Length %3 == 1 && numbers[numbers.Length-1]>biggestSum)
            {
                Console.WriteLine(numbers[numbers.Length - 1]);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", biggestSumNumbers[0], biggestSumNumbers[1], biggestSumNumbers[2]);
            }

        }
    }