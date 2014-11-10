using System;

    class OddEvenSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;
            bool odd = true;
            for (int i = 0; i < n*2; i++)
            {
                int element = int.Parse(Console.ReadLine());
                if (odd)
                {
                    oddSum = oddSum + element; 
                }
                else
                {
                    evenSum = evenSum + element;
                }
                odd = !odd;
            }
            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes, sum=" + oddSum);
            }
            else
            {
                int diff = Math.Abs(oddSum - evenSum);
                Console.WriteLine("No, diff=" + diff);
            }
        }
    }