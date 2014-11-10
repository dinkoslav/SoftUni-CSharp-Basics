using System;

    class SumOfElements
    {
        static void Main()
        {
            string[] userINput = Console.ReadLine().Split();
            int biggerNumber = 0;
            int sumOfSmallerNumbers = 0;

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