using System;

    class PrimeNumberCheck
    {
        static void Main()
        {
            Console.WriteLine("Enter a number to see if its prime :");
            int givenNumber = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (givenNumber >= 1)
            {
                for (int i = 2; i < givenNumber; i++)
                {
                    if (givenNumber % i == 0)
                    {
                        isPrime = false;
                    }
                }
            }
            else 
            {
                isPrime = false;
            }
            Console.WriteLine(isPrime);
        }
    }